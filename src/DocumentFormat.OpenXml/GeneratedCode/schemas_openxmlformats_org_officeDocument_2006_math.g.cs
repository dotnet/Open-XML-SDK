// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Math
{
    /// <summary>
    /// <para>Script.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:scr.</para>
    /// </summary>
    public partial class Script : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Script class.
        /// </summary>
        public Script() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Math.ScriptValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.ScriptValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "scr");
            builder.AddElement<Script>()
.AddAttribute(21, "val", a => a.Val, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Script>(deep);
    }

    /// <summary>
    /// <para>style.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sty.</para>
    /// </summary>
    public partial class Style : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Style class.
        /// </summary>
        public Style() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Math.StyleValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.StyleValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "sty");
            builder.AddElement<Style>()
.AddAttribute(21, "val", a => a.Val, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Style>(deep);
    }

    /// <summary>
    /// <para>Defines the Run Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:r.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RunProperties &lt;m:rPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.RunProperties &lt;w:rPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Break &lt;w:br></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Text &lt;w:t></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedText &lt;w:delText></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.FieldCode &lt;w:instrText></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedFieldCode &lt;w:delInstrText></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.NoBreakHyphen &lt;w:noBreakHyphen></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SoftHyphen &lt;w:softHyphen></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DayShort &lt;w:dayShort></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MonthShort &lt;w:monthShort></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.YearShort &lt;w:yearShort></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DayLong &lt;w:dayLong></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MonthLong &lt;w:monthLong></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.YearLong &lt;w:yearLong></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.AnnotationReferenceMark &lt;w:annotationRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.FootnoteReferenceMark &lt;w:footnoteRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.EndnoteReferenceMark &lt;w:endnoteRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SeparatorMark &lt;w:separator></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ContinuationSeparatorMark &lt;w:continuationSeparator></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SymbolChar &lt;w:sym></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PageNumber &lt;w:pgNum></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CarriageReturn &lt;w:cr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.TabChar &lt;w:tab></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject &lt;w:object></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Picture &lt;w:pict></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.FieldChar &lt;w:fldChar></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Ruby &lt;w:ruby></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.FootnoteReference &lt;w:footnoteReference></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.EndnoteReference &lt;w:endnoteReference></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentReference &lt;w:commentReference></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Drawing &lt;w:drawing></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PositionalTab &lt;w:ptab></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.LastRenderedPageBreak &lt;w:lastRenderedPageBreak></description></item>
    ///   <item><description>Text &lt;m:t></description></item>
    /// </list>
    /// </remark>
    public partial class Run : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Run class.
        /// </summary>
        public Run() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Run class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Run(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Run class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Run(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Run class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Run(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "r");
            builder.AddChild<RunProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Break>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Text>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DeletedText>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.FieldCode>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DeletedFieldCode>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.NoBreakHyphen>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.SoftHyphen>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DayShort>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MonthShort>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.YearShort>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DayLong>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MonthLong>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.YearLong>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.AnnotationReferenceMark>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteReferenceMark>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteReferenceMark>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.SeparatorMark>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.ContinuationSeparatorMark>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.SymbolChar>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PageNumber>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CarriageReturn>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.TabChar>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Picture>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.FieldChar>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Ruby>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteReference>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteReference>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CommentReference>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PositionalTab>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.LastRenderedPageBreak>();
            builder.AddChild<Text>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.RunProperties), 0, 1),
                new CompositeParticle(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.RunProperties), 0, 1)
                    }
                },
                new CompositeParticle(ParticleType.Choice, 0, 0)
                {
                    new CompositeParticle(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Break), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Text), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedText), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.FieldCode), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedFieldCode), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.NoBreakHyphen), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SoftHyphen), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DayShort), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MonthShort), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.YearShort), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DayLong), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MonthLong), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.YearLong), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.AnnotationReferenceMark), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.FootnoteReferenceMark), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.EndnoteReferenceMark), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SeparatorMark), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContinuationSeparatorMark), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SymbolChar), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PageNumber), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CarriageReturn), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.TabChar), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Picture), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.FieldChar), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Ruby), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.FootnoteReference), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.EndnoteReference), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentReference), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Drawing), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PositionalTab), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.LastRenderedPageBreak), 0, 1)
                        }
                    },
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Text), 0, 1)
                }
            };
        }

        /// <summary>
        /// <para>Run Properties.</para>
        /// <para>Represents the following element tag in the schema: m:rPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public RunProperties MathRunProperties
        {
            get => GetElement<RunProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Run Properties.</para>
        /// <para>Represents the following element tag in the schema: w:rPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w = http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Wordprocessing.RunProperties RunProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Run>(deep);
    }

    /// <summary>
    /// <para>Accent.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:acc.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AccentProperties &lt;m:accPr></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    /// </list>
    /// </remark>
    public partial class Accent : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Accent class.
        /// </summary>
        public Accent() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Accent class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Accent(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Accent class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Accent(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Accent class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Accent(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "acc");
            builder.AddChild<AccentProperties>();
            builder.AddChild<Base>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.AccentProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Accent Properties.</para>
        /// <para>Represents the following element tag in the schema: m:accPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public AccentProperties AccentProperties
        {
            get => GetElement<AccentProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Base Base
        {
            get => GetElement<Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Accent>(deep);
    }

    /// <summary>
    /// <para>Bar.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:bar.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BarProperties &lt;m:barPr></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    /// </list>
    /// </remark>
    public partial class Bar : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Bar class.
        /// </summary>
        public Bar() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Bar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Bar(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Bar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Bar(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Bar class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Bar(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "bar");
            builder.AddChild<BarProperties>();
            builder.AddChild<Base>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BarProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Bar Properties.</para>
        /// <para>Represents the following element tag in the schema: m:barPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public BarProperties BarProperties
        {
            get => GetElement<BarProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Base Base
        {
            get => GetElement<Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bar>(deep);
    }

    /// <summary>
    /// <para>Box Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:box.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BoxProperties &lt;m:boxPr></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    /// </list>
    /// </remark>
    public partial class Box : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Box class.
        /// </summary>
        public Box() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Box class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Box(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Box class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Box(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Box class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Box(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "box");
            builder.AddChild<BoxProperties>();
            builder.AddChild<Base>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BoxProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Box Properties.</para>
        /// <para>Represents the following element tag in the schema: m:boxPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public BoxProperties BoxProperties
        {
            get => GetElement<BoxProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Base Base
        {
            get => GetElement<Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Box>(deep);
    }

    /// <summary>
    /// <para>Border-Box Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:borderBox.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BorderBoxProperties &lt;m:borderBoxPr></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    /// </list>
    /// </remark>
    public partial class BorderBox : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BorderBox class.
        /// </summary>
        public BorderBox() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BorderBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BorderBox(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BorderBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BorderBox(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BorderBox class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BorderBox(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "borderBox");
            builder.AddChild<BorderBoxProperties>();
            builder.AddChild<Base>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBoxProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Border Box Properties.</para>
        /// <para>Represents the following element tag in the schema: m:borderBoxPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public BorderBoxProperties BorderBoxProperties
        {
            get => GetElement<BorderBoxProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Base Base
        {
            get => GetElement<Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BorderBox>(deep);
    }

    /// <summary>
    /// <para>Delimiter Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:d.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DelimiterProperties &lt;m:dPr></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    /// </list>
    /// </remark>
    public partial class Delimiter : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Delimiter class.
        /// </summary>
        public Delimiter() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Delimiter class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Delimiter(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Delimiter class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Delimiter(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Delimiter class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Delimiter(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "d");
            builder.AddChild<DelimiterProperties>();
            builder.AddChild<Base>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.DelimiterProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 64)
            };
        }

        /// <summary>
        /// <para>Delimiter Properties.</para>
        /// <para>Represents the following element tag in the schema: m:dPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DelimiterProperties DelimiterProperties
        {
            get => GetElement<DelimiterProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Delimiter>(deep);
    }

    /// <summary>
    /// <para>Equation-Array Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:eqArr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>EquationArrayProperties &lt;m:eqArrPr></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    /// </list>
    /// </remark>
    public partial class EquationArray : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the EquationArray class.
        /// </summary>
        public EquationArray() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EquationArray class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EquationArray(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EquationArray class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EquationArray(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EquationArray class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EquationArray(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "eqArr");
            builder.AddChild<EquationArrayProperties>();
            builder.AddChild<Base>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArrayProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 64)
            };
        }

        /// <summary>
        /// <para>Equation Array Properties.</para>
        /// <para>Represents the following element tag in the schema: m:eqArrPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public EquationArrayProperties EquationArrayProperties
        {
            get => GetElement<EquationArrayProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EquationArray>(deep);
    }

    /// <summary>
    /// <para>Fraction Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:f.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>FractionProperties &lt;m:fPr></description></item>
    ///   <item><description>Numerator &lt;m:num></description></item>
    ///   <item><description>Denominator &lt;m:den></description></item>
    /// </list>
    /// </remark>
    public partial class Fraction : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Fraction class.
        /// </summary>
        public Fraction() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Fraction class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Fraction(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Fraction class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Fraction(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Fraction class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Fraction(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "f");
            builder.AddChild<FractionProperties>();
            builder.AddChild<Numerator>();
            builder.AddChild<Denominator>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.FractionProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Numerator), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Denominator), 1, 1)
            };
        }

        /// <summary>
        /// <para>Fraction Properties.</para>
        /// <para>Represents the following element tag in the schema: m:fPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public FractionProperties FractionProperties
        {
            get => GetElement<FractionProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Numerator.</para>
        /// <para>Represents the following element tag in the schema: m:num.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Numerator Numerator
        {
            get => GetElement<Numerator>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Denominator.</para>
        /// <para>Represents the following element tag in the schema: m:den.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Denominator Denominator
        {
            get => GetElement<Denominator>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Fraction>(deep);
    }

    /// <summary>
    /// <para>Function Apply Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:func.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>FunctionProperties &lt;m:funcPr></description></item>
    ///   <item><description>FunctionName &lt;m:fName></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    /// </list>
    /// </remark>
    public partial class MathFunction : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MathFunction class.
        /// </summary>
        public MathFunction() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MathFunction class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MathFunction(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MathFunction class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MathFunction(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MathFunction class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MathFunction(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "func");
            builder.AddChild<FunctionProperties>();
            builder.AddChild<FunctionName>();
            builder.AddChild<Base>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.FunctionProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.FunctionName), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Function Properties.</para>
        /// <para>Represents the following element tag in the schema: m:funcPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public FunctionProperties FunctionProperties
        {
            get => GetElement<FunctionProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Function Name.</para>
        /// <para>Represents the following element tag in the schema: m:fName.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public FunctionName FunctionName
        {
            get => GetElement<FunctionName>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base (Argument).</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Base Base
        {
            get => GetElement<Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MathFunction>(deep);
    }

    /// <summary>
    /// <para>Group-Character Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:groupChr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>GroupCharProperties &lt;m:groupChrPr></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    /// </list>
    /// </remark>
    public partial class GroupChar : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupChar class.
        /// </summary>
        public GroupChar() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupChar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupChar(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupChar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupChar(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupChar class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupChar(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "groupChr");
            builder.AddChild<GroupCharProperties>();
            builder.AddChild<Base>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupCharProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Group-Character Properties.</para>
        /// <para>Represents the following element tag in the schema: m:groupChrPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public GroupCharProperties GroupCharProperties
        {
            get => GetElement<GroupCharProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Base Base
        {
            get => GetElement<Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupChar>(deep);
    }

    /// <summary>
    /// <para>Lower-Limit Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:limLow.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LimitLowerProperties &lt;m:limLowPr></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    ///   <item><description>Limit &lt;m:lim></description></item>
    /// </list>
    /// </remark>
    public partial class LimitLower : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LimitLower class.
        /// </summary>
        public LimitLower() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitLower class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LimitLower(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitLower class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LimitLower(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitLower class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LimitLower(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "limLow");
            builder.AddChild<LimitLowerProperties>();
            builder.AddChild<Base>();
            builder.AddChild<Limit>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLowerProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Limit), 1, 1)
            };
        }

        /// <summary>
        /// <para>Lower Limit Properties.</para>
        /// <para>Represents the following element tag in the schema: m:limLowPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public LimitLowerProperties LimitLowerProperties
        {
            get => GetElement<LimitLowerProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Base Base
        {
            get => GetElement<Base>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Limit (Lower).</para>
        /// <para>Represents the following element tag in the schema: m:lim.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Limit Limit
        {
            get => GetElement<Limit>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LimitLower>(deep);
    }

    /// <summary>
    /// <para>Upper-Limit Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:limUpp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LimitUpperProperties &lt;m:limUppPr></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    ///   <item><description>Limit &lt;m:lim></description></item>
    /// </list>
    /// </remark>
    public partial class LimitUpper : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LimitUpper class.
        /// </summary>
        public LimitUpper() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitUpper class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LimitUpper(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitUpper class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LimitUpper(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitUpper class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LimitUpper(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "limUpp");
            builder.AddChild<LimitUpperProperties>();
            builder.AddChild<Base>();
            builder.AddChild<Limit>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpperProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Limit), 1, 1)
            };
        }

        /// <summary>
        /// <para>Upper Limit Properties.</para>
        /// <para>Represents the following element tag in the schema: m:limUppPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public LimitUpperProperties LimitUpperProperties
        {
            get => GetElement<LimitUpperProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Base Base
        {
            get => GetElement<Base>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Limit (Upper).</para>
        /// <para>Represents the following element tag in the schema: m:lim.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Limit Limit
        {
            get => GetElement<Limit>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LimitUpper>(deep);
    }

    /// <summary>
    /// <para>Matrix Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:m.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>MatrixProperties &lt;m:mPr></description></item>
    ///   <item><description>MatrixRow &lt;m:mr></description></item>
    /// </list>
    /// </remark>
    public partial class Matrix : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Matrix class.
        /// </summary>
        public Matrix() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Matrix class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Matrix(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Matrix class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Matrix(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Matrix class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Matrix(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "m");
            builder.AddChild<MatrixProperties>();
            builder.AddChild<MatrixRow>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MatrixProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MatrixRow), 1, 256)
            };
        }

        /// <summary>
        /// <para>Matrix Properties.</para>
        /// <para>Represents the following element tag in the schema: m:mPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public MatrixProperties MatrixProperties
        {
            get => GetElement<MatrixProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Matrix>(deep);
    }

    /// <summary>
    /// <para>n-ary Operator Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:nary.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NaryProperties &lt;m:naryPr></description></item>
    ///   <item><description>SubArgument &lt;m:sub></description></item>
    ///   <item><description>SuperArgument &lt;m:sup></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    /// </list>
    /// </remark>
    public partial class Nary : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Nary class.
        /// </summary>
        public Nary() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Nary class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Nary(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Nary class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Nary(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Nary class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Nary(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "nary");
            builder.AddChild<NaryProperties>();
            builder.AddChild<SubArgument>();
            builder.AddChild<SuperArgument>();
            builder.AddChild<Base>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.NaryProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubArgument), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SuperArgument), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>n-ary Properties.</para>
        /// <para>Represents the following element tag in the schema: m:naryPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public NaryProperties NaryProperties
        {
            get => GetElement<NaryProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Lower limit (n-ary) .</para>
        /// <para>Represents the following element tag in the schema: m:sub.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public SubArgument SubArgument
        {
            get => GetElement<SubArgument>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Upper limit (n-ary).</para>
        /// <para>Represents the following element tag in the schema: m:sup.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public SuperArgument SuperArgument
        {
            get => GetElement<SuperArgument>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base (Argument).</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Base Base
        {
            get => GetElement<Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Nary>(deep);
    }

    /// <summary>
    /// <para>Phantom Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:phant.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PhantomProperties &lt;m:phantPr></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    /// </list>
    /// </remark>
    public partial class Phantom : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Phantom class.
        /// </summary>
        public Phantom() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Phantom class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Phantom(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Phantom class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Phantom(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Phantom class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Phantom(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "phant");
            builder.AddChild<PhantomProperties>();
            builder.AddChild<Base>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PhantomProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Phantom Properties.</para>
        /// <para>Represents the following element tag in the schema: m:phantPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public PhantomProperties PhantomProperties
        {
            get => GetElement<PhantomProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Base Base
        {
            get => GetElement<Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Phantom>(deep);
    }

    /// <summary>
    /// <para>Radical Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:rad.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RadicalProperties &lt;m:radPr></description></item>
    ///   <item><description>Degree &lt;m:deg></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    /// </list>
    /// </remark>
    public partial class Radical : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Radical class.
        /// </summary>
        public Radical() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Radical class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Radical(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Radical class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Radical(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Radical class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Radical(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "rad");
            builder.AddChild<RadicalProperties>();
            builder.AddChild<Degree>();
            builder.AddChild<Base>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.RadicalProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Degree), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Radical Properties.</para>
        /// <para>Represents the following element tag in the schema: m:radPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public RadicalProperties RadicalProperties
        {
            get => GetElement<RadicalProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Degree.</para>
        /// <para>Represents the following element tag in the schema: m:deg.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Degree Degree
        {
            get => GetElement<Degree>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Base Base
        {
            get => GetElement<Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Radical>(deep);
    }

    /// <summary>
    /// <para>Pre-Sub-Superscript Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sPre.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PreSubSuperProperties &lt;m:sPrePr></description></item>
    ///   <item><description>SubArgument &lt;m:sub></description></item>
    ///   <item><description>SuperArgument &lt;m:sup></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    /// </list>
    /// </remark>
    public partial class PreSubSuper : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PreSubSuper class.
        /// </summary>
        public PreSubSuper() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PreSubSuper class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PreSubSuper(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PreSubSuper class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PreSubSuper(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PreSubSuper class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PreSubSuper(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "sPre");
            builder.AddChild<PreSubSuperProperties>();
            builder.AddChild<SubArgument>();
            builder.AddChild<SuperArgument>();
            builder.AddChild<Base>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuperProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubArgument), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SuperArgument), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Pre-Sub-Superscript Properties.</para>
        /// <para>Represents the following element tag in the schema: m:sPrePr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public PreSubSuperProperties PreSubSuperProperties
        {
            get => GetElement<PreSubSuperProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Subscript (Pre-Sub-Superscript).</para>
        /// <para>Represents the following element tag in the schema: m:sub.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public SubArgument SubArgument
        {
            get => GetElement<SubArgument>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Superscript(Pre-Sub-Superscript function).</para>
        /// <para>Represents the following element tag in the schema: m:sup.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public SuperArgument SuperArgument
        {
            get => GetElement<SuperArgument>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Base Base
        {
            get => GetElement<Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PreSubSuper>(deep);
    }

    /// <summary>
    /// <para>Subscript Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sSub.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SubscriptProperties &lt;m:sSubPr></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    ///   <item><description>SubArgument &lt;m:sub></description></item>
    /// </list>
    /// </remark>
    public partial class Subscript : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Subscript class.
        /// </summary>
        public Subscript() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Subscript class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Subscript(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Subscript class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Subscript(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Subscript class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Subscript(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "sSub");
            builder.AddChild<SubscriptProperties>();
            builder.AddChild<Base>();
            builder.AddChild<SubArgument>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubscriptProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubArgument), 1, 1)
            };
        }

        /// <summary>
        /// <para>Subscript Properties.</para>
        /// <para>Represents the following element tag in the schema: m:sSubPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public SubscriptProperties SubscriptProperties
        {
            get => GetElement<SubscriptProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Base Base
        {
            get => GetElement<Base>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Subscript (Subscript function).</para>
        /// <para>Represents the following element tag in the schema: m:sub.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public SubArgument SubArgument
        {
            get => GetElement<SubArgument>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Subscript>(deep);
    }

    /// <summary>
    /// <para>Sub-Superscript Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sSubSup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SubSuperscriptProperties &lt;m:sSubSupPr></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    ///   <item><description>SubArgument &lt;m:sub></description></item>
    ///   <item><description>SuperArgument &lt;m:sup></description></item>
    /// </list>
    /// </remark>
    public partial class SubSuperscript : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SubSuperscript class.
        /// </summary>
        public SubSuperscript() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubSuperscript class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubSuperscript(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubSuperscript class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubSuperscript(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubSuperscript class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SubSuperscript(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "sSubSup");
            builder.AddChild<SubSuperscriptProperties>();
            builder.AddChild<Base>();
            builder.AddChild<SubArgument>();
            builder.AddChild<SuperArgument>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscriptProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubArgument), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SuperArgument), 1, 1)
            };
        }

        /// <summary>
        /// <para>Sub-Superscript Properties.</para>
        /// <para>Represents the following element tag in the schema: m:sSubSupPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public SubSuperscriptProperties SubSuperscriptProperties
        {
            get => GetElement<SubSuperscriptProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Base Base
        {
            get => GetElement<Base>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Subscript (Sub-Superscript).</para>
        /// <para>Represents the following element tag in the schema: m:sub.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public SubArgument SubArgument
        {
            get => GetElement<SubArgument>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Superscript (Sub-Superscript function).</para>
        /// <para>Represents the following element tag in the schema: m:sup.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public SuperArgument SuperArgument
        {
            get => GetElement<SuperArgument>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SubSuperscript>(deep);
    }

    /// <summary>
    /// <para>Superscript Function.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sSup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SuperscriptProperties &lt;m:sSupPr></description></item>
    ///   <item><description>Base &lt;m:e></description></item>
    ///   <item><description>SuperArgument &lt;m:sup></description></item>
    /// </list>
    /// </remark>
    public partial class Superscript : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Superscript class.
        /// </summary>
        public Superscript() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Superscript class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Superscript(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Superscript class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Superscript(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Superscript class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Superscript(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "sSup");
            builder.AddChild<SuperscriptProperties>();
            builder.AddChild<Base>();
            builder.AddChild<SuperArgument>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SuperscriptProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SuperArgument), 1, 1)
            };
        }

        /// <summary>
        /// <para>Superscript Properties.</para>
        /// <para>Represents the following element tag in the schema: m:sSupPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public SuperscriptProperties SuperscriptProperties
        {
            get => GetElement<SuperscriptProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Base Base
        {
            get => GetElement<Base>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Superscript (Superscript function).</para>
        /// <para>Represents the following element tag in the schema: m:sup.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public SuperArgument SuperArgument
        {
            get => GetElement<SuperArgument>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Superscript>(deep);
    }

    /// <summary>
    /// <para>Defines the Paragraph Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:oMathPara.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ParagraphProperties &lt;m:oMathParaPr></description></item>
    ///   <item><description>OfficeMath &lt;m:oMath></description></item>
    ///   <item><description>Run &lt;m:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Run &lt;w:r></description></item>
    /// </list>
    /// </remark>
    public partial class Paragraph : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Paragraph class.
        /// </summary>
        public Paragraph() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Paragraph class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Paragraph(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Paragraph class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Paragraph(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Paragraph class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Paragraph(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "oMathPara");
            builder.AddChild<ParagraphProperties>();
            builder.AddChild<OfficeMath>();
            builder.AddChild<Run>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.ContentPart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Run>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ParagraphProperties), 0, 1),
                new CompositeParticle(ParticleType.Choice, 1, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 0),
                    new CompositeParticle(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Choice, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Group, 1, 1)
                            {
                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                {
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                }
                            },
                            new CompositeParticle(ParticleType.Group, 1, 1)
                            {
                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                {
                                    new CompositeParticle(ParticleType.Group, 0, 0)
                                    {
                                        new CompositeParticle(ParticleType.Choice, 1, 1)
                                        {
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                        }
                                    },
                                    new CompositeParticle(ParticleType.Group, 0, 0)
                                    {
                                        new CompositeParticle(ParticleType.Choice, 1, 1)
                                        {
                                            new CompositeParticle(ParticleType.Group, 0, 0)
                                            {
                                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                                {
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                }
                                            },
                                            new CompositeParticle(ParticleType.Group, 0, 0)
                                            {
                                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                                {
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                }
                                            },
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                        }
                                    },
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                    new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                    {
                                        new CompositeParticle(ParticleType.Sequence, 1, 1)
                                        {
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                        }
                                    }
                                }
                            },
                            new CompositeParticle(ParticleType.Group, 1, 1)
                            {
                                new CompositeParticle(ParticleType.Choice, 1, 1)
                                {
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Run), 1, 1)
                                }
                            }
                        }
                    }
                }
            };
        }

        /// <summary>
        /// <para>Office Math Paragraph Properties.</para>
        /// <para>Represents the following element tag in the schema: m:oMathParaPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ParagraphProperties ParagraphProperties
        {
            get => GetElement<ParagraphProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Paragraph>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeMath Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:oMath.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Accent &lt;m:acc></description></item>
    ///   <item><description>Bar &lt;m:bar></description></item>
    ///   <item><description>Box &lt;m:box></description></item>
    ///   <item><description>BorderBox &lt;m:borderBox></description></item>
    ///   <item><description>Delimiter &lt;m:d></description></item>
    ///   <item><description>EquationArray &lt;m:eqArr></description></item>
    ///   <item><description>Fraction &lt;m:f></description></item>
    ///   <item><description>MathFunction &lt;m:func></description></item>
    ///   <item><description>GroupChar &lt;m:groupChr></description></item>
    ///   <item><description>LimitLower &lt;m:limLow></description></item>
    ///   <item><description>LimitUpper &lt;m:limUpp></description></item>
    ///   <item><description>Matrix &lt;m:m></description></item>
    ///   <item><description>Nary &lt;m:nary></description></item>
    ///   <item><description>Phantom &lt;m:phant></description></item>
    ///   <item><description>Radical &lt;m:rad></description></item>
    ///   <item><description>PreSubSuper &lt;m:sPre></description></item>
    ///   <item><description>Subscript &lt;m:sSub></description></item>
    ///   <item><description>SubSuperscript &lt;m:sSubSup></description></item>
    ///   <item><description>Superscript &lt;m:sSup></description></item>
    ///   <item><description>Run &lt;m:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
    ///   <item><description>Paragraph &lt;m:oMathPara></description></item>
    ///   <item><description>OfficeMath &lt;m:oMath></description></item>
    /// </list>
    /// </remark>
    public partial class OfficeMath : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeMath class.
        /// </summary>
        public OfficeMath() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMath class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeMath(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMath class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeMath(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMath class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OfficeMath(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "oMath");
            builder.AddChild<Accent>();
            builder.AddChild<Bar>();
            builder.AddChild<Box>();
            builder.AddChild<BorderBox>();
            builder.AddChild<Delimiter>();
            builder.AddChild<EquationArray>();
            builder.AddChild<Fraction>();
            builder.AddChild<MathFunction>();
            builder.AddChild<GroupChar>();
            builder.AddChild<LimitLower>();
            builder.AddChild<LimitUpper>();
            builder.AddChild<Matrix>();
            builder.AddChild<Nary>();
            builder.AddChild<Phantom>();
            builder.AddChild<Radical>();
            builder.AddChild<PreSubSuper>();
            builder.AddChild<Subscript>();
            builder.AddChild<SubSuperscript>();
            builder.AddChild<Superscript>();
            builder.AddChild<Run>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.SimpleField>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Hyperlink>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.SdtRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.ContentPart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
            builder.AddChild<Paragraph>();
            builder.AddChild<OfficeMath>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeMath>(deep);
    }

    /// <summary>
    /// <para>Math Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:mathPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>MathFont &lt;m:mathFont></description></item>
    ///   <item><description>BreakBinary &lt;m:brkBin></description></item>
    ///   <item><description>BreakBinarySubtraction &lt;m:brkBinSub></description></item>
    ///   <item><description>SmallFraction &lt;m:smallFrac></description></item>
    ///   <item><description>DisplayDefaults &lt;m:dispDef></description></item>
    ///   <item><description>LeftMargin &lt;m:lMargin></description></item>
    ///   <item><description>RightMargin &lt;m:rMargin></description></item>
    ///   <item><description>DefaultJustification &lt;m:defJc></description></item>
    ///   <item><description>PreSpacing &lt;m:preSp></description></item>
    ///   <item><description>PostSpacing &lt;m:postSp></description></item>
    ///   <item><description>InterSpacing &lt;m:interSp></description></item>
    ///   <item><description>IntraSpacing &lt;m:intraSp></description></item>
    ///   <item><description>WrapIndent &lt;m:wrapIndent></description></item>
    ///   <item><description>WrapRight &lt;m:wrapRight></description></item>
    ///   <item><description>IntegralLimitLocation &lt;m:intLim></description></item>
    ///   <item><description>NaryLimitLocation &lt;m:naryLim></description></item>
    /// </list>
    /// </remark>
    public partial class MathProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MathProperties class.
        /// </summary>
        public MathProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MathProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MathProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MathProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MathProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MathProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MathProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "mathPr");
            builder.AddChild<MathFont>();
            builder.AddChild<BreakBinary>();
            builder.AddChild<BreakBinarySubtraction>();
            builder.AddChild<SmallFraction>();
            builder.AddChild<DisplayDefaults>();
            builder.AddChild<LeftMargin>();
            builder.AddChild<RightMargin>();
            builder.AddChild<DefaultJustification>();
            builder.AddChild<PreSpacing>();
            builder.AddChild<PostSpacing>();
            builder.AddChild<InterSpacing>();
            builder.AddChild<IntraSpacing>();
            builder.AddChild<WrapIndent>();
            builder.AddChild<WrapRight>();
            builder.AddChild<IntegralLimitLocation>();
            builder.AddChild<NaryLimitLocation>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFont), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BreakBinary), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BreakBinarySubtraction), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SmallFraction), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.DisplayDefaults), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LeftMargin), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.RightMargin), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.DefaultJustification), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSpacing), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PostSpacing), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.InterSpacing), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.IntraSpacing), 0, 1),
                new CompositeParticle(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.WrapIndent), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.WrapRight), 1, 1)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.IntegralLimitLocation), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.NaryLimitLocation), 0, 1)
            };
        }

        /// <summary>
        /// <para>Math Font.</para>
        /// <para>Represents the following element tag in the schema: m:mathFont.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public MathFont MathFont
        {
            get => GetElement<MathFont>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Break on Binary Operators.</para>
        /// <para>Represents the following element tag in the schema: m:brkBin.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public BreakBinary BreakBinary
        {
            get => GetElement<BreakBinary>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Break on Binary Subtraction.</para>
        /// <para>Represents the following element tag in the schema: m:brkBinSub.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public BreakBinarySubtraction BreakBinarySubtraction
        {
            get => GetElement<BreakBinarySubtraction>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Small Fraction.</para>
        /// <para>Represents the following element tag in the schema: m:smallFrac.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public SmallFraction SmallFraction
        {
            get => GetElement<SmallFraction>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Use Display Math Defaults.</para>
        /// <para>Represents the following element tag in the schema: m:dispDef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DisplayDefaults DisplayDefaults
        {
            get => GetElement<DisplayDefaults>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Left Margin.</para>
        /// <para>Represents the following element tag in the schema: m:lMargin.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public LeftMargin LeftMargin
        {
            get => GetElement<LeftMargin>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Right Margin.</para>
        /// <para>Represents the following element tag in the schema: m:rMargin.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public RightMargin RightMargin
        {
            get => GetElement<RightMargin>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Default Justification.</para>
        /// <para>Represents the following element tag in the schema: m:defJc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DefaultJustification DefaultJustification
        {
            get => GetElement<DefaultJustification>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Pre-Equation Spacing.</para>
        /// <para>Represents the following element tag in the schema: m:preSp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public PreSpacing PreSpacing
        {
            get => GetElement<PreSpacing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Post-Equation Spacing.</para>
        /// <para>Represents the following element tag in the schema: m:postSp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public PostSpacing PostSpacing
        {
            get => GetElement<PostSpacing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Inter-Equation Spacing.</para>
        /// <para>Represents the following element tag in the schema: m:interSp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public InterSpacing InterSpacing
        {
            get => GetElement<InterSpacing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Intra-Equation Spacing.</para>
        /// <para>Represents the following element tag in the schema: m:intraSp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public IntraSpacing IntraSpacing
        {
            get => GetElement<IntraSpacing>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MathProperties>(deep);
    }

    /// <summary>
    /// <para>Literal.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:lit.</para>
    /// </summary>
    public partial class Literal : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the Literal class.
        /// </summary>
        public Literal() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "lit");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Literal>(deep);
    }

    /// <summary>
    /// <para>Normal Text.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:nor.</para>
    /// </summary>
    public partial class NormalText : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the NormalText class.
        /// </summary>
        public NormalText() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "nor");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NormalText>(deep);
    }

    /// <summary>
    /// <para>Align.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:aln.</para>
    /// </summary>
    public partial class Alignment : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the Alignment class.
        /// </summary>
        public Alignment() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "aln");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Alignment>(deep);
    }

    /// <summary>
    /// <para>Operator Emulator.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:opEmu.</para>
    /// </summary>
    public partial class OperatorEmulator : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the OperatorEmulator class.
        /// </summary>
        public OperatorEmulator() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "opEmu");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OperatorEmulator>(deep);
    }

    /// <summary>
    /// <para>No Break.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:noBreak.</para>
    /// </summary>
    public partial class NoBreak : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the NoBreak class.
        /// </summary>
        public NoBreak() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "noBreak");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoBreak>(deep);
    }

    /// <summary>
    /// <para>Differential.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:diff.</para>
    /// </summary>
    public partial class Differential : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the Differential class.
        /// </summary>
        public Differential() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "diff");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Differential>(deep);
    }

    /// <summary>
    /// <para>Hide Top Edge.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:hideTop.</para>
    /// </summary>
    public partial class HideTop : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the HideTop class.
        /// </summary>
        public HideTop() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "hideTop");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideTop>(deep);
    }

    /// <summary>
    /// <para>Hide Bottom Edge.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:hideBot.</para>
    /// </summary>
    public partial class HideBottom : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the HideBottom class.
        /// </summary>
        public HideBottom() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "hideBot");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideBottom>(deep);
    }

    /// <summary>
    /// <para>Hide Left Edge.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:hideLeft.</para>
    /// </summary>
    public partial class HideLeft : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the HideLeft class.
        /// </summary>
        public HideLeft() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "hideLeft");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideLeft>(deep);
    }

    /// <summary>
    /// <para>Hide Right Edge.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:hideRight.</para>
    /// </summary>
    public partial class HideRight : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the HideRight class.
        /// </summary>
        public HideRight() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "hideRight");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideRight>(deep);
    }

    /// <summary>
    /// <para>Border Box Strikethrough Horizontal.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:strikeH.</para>
    /// </summary>
    public partial class StrikeHorizontal : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the StrikeHorizontal class.
        /// </summary>
        public StrikeHorizontal() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "strikeH");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrikeHorizontal>(deep);
    }

    /// <summary>
    /// <para>Border Box Strikethrough Vertical.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:strikeV.</para>
    /// </summary>
    public partial class StrikeVertical : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the StrikeVertical class.
        /// </summary>
        public StrikeVertical() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "strikeV");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrikeVertical>(deep);
    }

    /// <summary>
    /// <para>Border Box Strikethrough Bottom-Left to Top-Right.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:strikeBLTR.</para>
    /// </summary>
    public partial class StrikeBottomLeftToTopRight : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the StrikeBottomLeftToTopRight class.
        /// </summary>
        public StrikeBottomLeftToTopRight() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "strikeBLTR");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrikeBottomLeftToTopRight>(deep);
    }

    /// <summary>
    /// <para>Border Box Strikethrough Top-Left to Bottom-Right.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:strikeTLBR.</para>
    /// </summary>
    public partial class StrikeTopLeftToBottomRight : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the StrikeTopLeftToBottomRight class.
        /// </summary>
        public StrikeTopLeftToBottomRight() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "strikeTLBR");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrikeTopLeftToBottomRight>(deep);
    }

    /// <summary>
    /// <para>Delimiter Grow.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:grow.</para>
    /// </summary>
    public partial class GrowOperators : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the GrowOperators class.
        /// </summary>
        public GrowOperators() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "grow");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GrowOperators>(deep);
    }

    /// <summary>
    /// <para>Maximum Distribution.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:maxDist.</para>
    /// </summary>
    public partial class MaxDistribution : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the MaxDistribution class.
        /// </summary>
        public MaxDistribution() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "maxDist");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MaxDistribution>(deep);
    }

    /// <summary>
    /// <para>Object Distribution.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:objDist.</para>
    /// </summary>
    public partial class ObjectDistribution : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the ObjectDistribution class.
        /// </summary>
        public ObjectDistribution() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "objDist");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ObjectDistribution>(deep);
    }

    /// <summary>
    /// <para>Hide Placeholders (Matrix).</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:plcHide.</para>
    /// </summary>
    public partial class HidePlaceholder : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the HidePlaceholder class.
        /// </summary>
        public HidePlaceholder() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "plcHide");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HidePlaceholder>(deep);
    }

    /// <summary>
    /// <para>Hide Subscript (n-ary).</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:subHide.</para>
    /// </summary>
    public partial class HideSubArgument : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the HideSubArgument class.
        /// </summary>
        public HideSubArgument() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "subHide");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideSubArgument>(deep);
    }

    /// <summary>
    /// <para>Hide Superscript (n-ary).</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:supHide.</para>
    /// </summary>
    public partial class HideSuperArgument : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the HideSuperArgument class.
        /// </summary>
        public HideSuperArgument() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "supHide");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideSuperArgument>(deep);
    }

    /// <summary>
    /// <para>Phantom Show.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:show.</para>
    /// </summary>
    public partial class ShowPhantom : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the ShowPhantom class.
        /// </summary>
        public ShowPhantom() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "show");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowPhantom>(deep);
    }

    /// <summary>
    /// <para>Phantom Zero Width.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:zeroWid.</para>
    /// </summary>
    public partial class ZeroWidth : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the ZeroWidth class.
        /// </summary>
        public ZeroWidth() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "zeroWid");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ZeroWidth>(deep);
    }

    /// <summary>
    /// <para>Phantom Zero Ascent.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:zeroAsc.</para>
    /// </summary>
    public partial class ZeroAscent : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the ZeroAscent class.
        /// </summary>
        public ZeroAscent() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "zeroAsc");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ZeroAscent>(deep);
    }

    /// <summary>
    /// <para>Phantom Zero Descent.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:zeroDesc.</para>
    /// </summary>
    public partial class ZeroDescent : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the ZeroDescent class.
        /// </summary>
        public ZeroDescent() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "zeroDesc");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ZeroDescent>(deep);
    }

    /// <summary>
    /// <para>Transparent (Phantom).</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:transp.</para>
    /// </summary>
    public partial class Transparent : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the Transparent class.
        /// </summary>
        public Transparent() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "transp");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transparent>(deep);
    }

    /// <summary>
    /// <para>Hide Degree.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:degHide.</para>
    /// </summary>
    public partial class HideDegree : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the HideDegree class.
        /// </summary>
        public HideDegree() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "degHide");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideDegree>(deep);
    }

    /// <summary>
    /// <para>Align Scripts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:alnScr.</para>
    /// </summary>
    public partial class AlignScripts : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the AlignScripts class.
        /// </summary>
        public AlignScripts() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "alnScr");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AlignScripts>(deep);
    }

    /// <summary>
    /// <para>Small Fraction.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:smallFrac.</para>
    /// </summary>
    public partial class SmallFraction : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the SmallFraction class.
        /// </summary>
        public SmallFraction() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "smallFrac");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SmallFraction>(deep);
    }

    /// <summary>
    /// <para>Use Display Math Defaults.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:dispDef.</para>
    /// </summary>
    public partial class DisplayDefaults : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the DisplayDefaults class.
        /// </summary>
        public DisplayDefaults() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "dispDef");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DisplayDefaults>(deep);
    }

    /// <summary>
    /// <para>Wrap Right.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:wrapRight.</para>
    /// </summary>
    public partial class WrapRight : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the WrapRight class.
        /// </summary>
        public WrapRight() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "wrapRight");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapRight>(deep);
    }

    /// <summary>
    /// <para>Defines the OnOffType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OnOffType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OnOffType class.
        /// </summary>
        protected OnOffType() : base()
        {
        }

        /// <summary>
        /// <para>value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Math.BooleanValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.BooleanValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OnOffType>()
                           .AddAttribute(21, "val", a => a.Val);
        }
    }

    /// <summary>
    /// <para>Break.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:brk.</para>
    /// </summary>
    public partial class Break : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Break class.
        /// </summary>
        public Break() : base()
        {
        }

        /// <summary>
        /// <para>Index of Operator to Align To</para>
        /// <para>Represents the following attribute in the schema: m:alnAt</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public IntegerValue AlignAt
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Index of Operator to Align To</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public IntegerValue Val
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "brk");
            builder.AddElement<Break>()
.AddAttribute(21, "alnAt", a => a.AlignAt, aBuilder =>
{
   aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (255L) });
})
.AddAttribute(21, "val", a => a.Val, aBuilder =>
{
   aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (255L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Break>(deep);
    }

    /// <summary>
    /// <para>Run Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:rPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Literal &lt;m:lit></description></item>
    ///   <item><description>NormalText &lt;m:nor></description></item>
    ///   <item><description>Script &lt;m:scr></description></item>
    ///   <item><description>Style &lt;m:sty></description></item>
    ///   <item><description>Break &lt;m:brk></description></item>
    ///   <item><description>Alignment &lt;m:aln></description></item>
    /// </list>
    /// </remark>
    public partial class RunProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RunProperties class.
        /// </summary>
        public RunProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RunProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RunProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RunProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RunProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RunProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RunProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "rPr");
            builder.AddChild<Literal>();
            builder.AddChild<NormalText>();
            builder.AddChild<Script>();
            builder.AddChild<Style>();
            builder.AddChild<Break>();
            builder.AddChild<Alignment>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Literal), 0, 1),
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.NormalText), 0, 1),
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Sequence, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Script), 0, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Style), 0, 1)
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Break), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Alignment), 0, 1)
            };
        }

        /// <summary>
        /// <para>Literal.</para>
        /// <para>Represents the following element tag in the schema: m:lit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Literal Literal
        {
            get => GetElement<Literal>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RunProperties>(deep);
    }

    /// <summary>
    /// <para>Text.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:t.</para>
    /// </summary>
    public partial class Text : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Text class.
        /// </summary>
        public Text() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Text class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Text(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>space</para>
        /// <para>Represents the following attribute in the schema: xml:space</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues> Space
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "t");
            builder.AddElement<Text>()
 .AddAttribute(1, "space", a => a.Space);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Text>(deep);
    }

    /// <summary>
    /// <para>Accent Character.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:chr.</para>
    /// </summary>
    public partial class AccentChar : CharType
    {
        /// <summary>
        /// Initializes a new instance of the AccentChar class.
        /// </summary>
        public AccentChar() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "chr");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AccentChar>(deep);
    }

    /// <summary>
    /// <para>Delimiter Beginning Character.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:begChr.</para>
    /// </summary>
    public partial class BeginChar : CharType
    {
        /// <summary>
        /// Initializes a new instance of the BeginChar class.
        /// </summary>
        public BeginChar() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "begChr");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BeginChar>(deep);
    }

    /// <summary>
    /// <para>Delimiter Separator Character.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sepChr.</para>
    /// </summary>
    public partial class SeparatorChar : CharType
    {
        /// <summary>
        /// Initializes a new instance of the SeparatorChar class.
        /// </summary>
        public SeparatorChar() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "sepChr");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeparatorChar>(deep);
    }

    /// <summary>
    /// <para>Delimiter Ending Character.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:endChr.</para>
    /// </summary>
    public partial class EndChar : CharType
    {
        /// <summary>
        /// Initializes a new instance of the EndChar class.
        /// </summary>
        public EndChar() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "endChr");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EndChar>(deep);
    }

    /// <summary>
    /// <para>Defines the CharType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class CharType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CharType class.
        /// </summary>
        protected CharType() : base()
        {
        }

        /// <summary>
        /// <para>value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<CharType>()
                           .AddAttribute(21, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new StringValidator() { MaxLength = (1L) });
                           });
        }
    }

    /// <summary>
    /// <para>Control Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:ctrlPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.RunProperties &lt;w:rPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl &lt;w:ins></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl &lt;w:del></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl &lt;w:moveFrom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl &lt;w:moveTo></description></item>
    /// </list>
    /// </remark>
    public partial class ControlProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ControlProperties class.
        /// </summary>
        public ControlProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ControlProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ControlProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ControlProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ControlProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ControlProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ControlProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "ctrlPr");
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Sequence, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.RunProperties), 0, 1)
                            }
                        },
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl), 1, 1)
                            }
                        },
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl), 1, 1)
                            }
                        },
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ControlProperties>(deep);
    }

    /// <summary>
    /// <para>Accent Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:accPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AccentChar &lt;m:chr></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class AccentProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AccentProperties class.
        /// </summary>
        public AccentProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AccentProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AccentProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AccentProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AccentProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AccentProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AccentProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "accPr");
            builder.AddChild<AccentChar>();
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.AccentChar), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Accent Character.</para>
        /// <para>Represents the following element tag in the schema: m:chr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public AccentChar AccentChar
        {
            get => GetElement<AccentChar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Control Properties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AccentProperties>(deep);
    }

    /// <summary>
    /// <para>Base.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:e.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ArgumentProperties &lt;m:argPr></description></item>
    ///   <item><description>Accent &lt;m:acc></description></item>
    ///   <item><description>Bar &lt;m:bar></description></item>
    ///   <item><description>Box &lt;m:box></description></item>
    ///   <item><description>BorderBox &lt;m:borderBox></description></item>
    ///   <item><description>Delimiter &lt;m:d></description></item>
    ///   <item><description>EquationArray &lt;m:eqArr></description></item>
    ///   <item><description>Fraction &lt;m:f></description></item>
    ///   <item><description>MathFunction &lt;m:func></description></item>
    ///   <item><description>GroupChar &lt;m:groupChr></description></item>
    ///   <item><description>LimitLower &lt;m:limLow></description></item>
    ///   <item><description>LimitUpper &lt;m:limUpp></description></item>
    ///   <item><description>Matrix &lt;m:m></description></item>
    ///   <item><description>Nary &lt;m:nary></description></item>
    ///   <item><description>Phantom &lt;m:phant></description></item>
    ///   <item><description>Radical &lt;m:rad></description></item>
    ///   <item><description>PreSubSuper &lt;m:sPre></description></item>
    ///   <item><description>Subscript &lt;m:sSub></description></item>
    ///   <item><description>SubSuperscript &lt;m:sSubSup></description></item>
    ///   <item><description>Superscript &lt;m:sSup></description></item>
    ///   <item><description>Run &lt;m:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
    ///   <item><description>Paragraph &lt;m:oMathPara></description></item>
    ///   <item><description>OfficeMath &lt;m:oMath></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class Base : OfficeMathArgumentType
    {
        /// <summary>
        /// Initializes a new instance of the Base class.
        /// </summary>
        public Base() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Base class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Base(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Base class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Base(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Base class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Base(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "e");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentProperties), 0, 1),
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Base>(deep);
    }

    /// <summary>
    /// <para>Numerator.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:num.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ArgumentProperties &lt;m:argPr></description></item>
    ///   <item><description>Accent &lt;m:acc></description></item>
    ///   <item><description>Bar &lt;m:bar></description></item>
    ///   <item><description>Box &lt;m:box></description></item>
    ///   <item><description>BorderBox &lt;m:borderBox></description></item>
    ///   <item><description>Delimiter &lt;m:d></description></item>
    ///   <item><description>EquationArray &lt;m:eqArr></description></item>
    ///   <item><description>Fraction &lt;m:f></description></item>
    ///   <item><description>MathFunction &lt;m:func></description></item>
    ///   <item><description>GroupChar &lt;m:groupChr></description></item>
    ///   <item><description>LimitLower &lt;m:limLow></description></item>
    ///   <item><description>LimitUpper &lt;m:limUpp></description></item>
    ///   <item><description>Matrix &lt;m:m></description></item>
    ///   <item><description>Nary &lt;m:nary></description></item>
    ///   <item><description>Phantom &lt;m:phant></description></item>
    ///   <item><description>Radical &lt;m:rad></description></item>
    ///   <item><description>PreSubSuper &lt;m:sPre></description></item>
    ///   <item><description>Subscript &lt;m:sSub></description></item>
    ///   <item><description>SubSuperscript &lt;m:sSubSup></description></item>
    ///   <item><description>Superscript &lt;m:sSup></description></item>
    ///   <item><description>Run &lt;m:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
    ///   <item><description>Paragraph &lt;m:oMathPara></description></item>
    ///   <item><description>OfficeMath &lt;m:oMath></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class Numerator : OfficeMathArgumentType
    {
        /// <summary>
        /// Initializes a new instance of the Numerator class.
        /// </summary>
        public Numerator() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Numerator class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Numerator(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Numerator class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Numerator(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Numerator class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Numerator(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "num");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentProperties), 0, 1),
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Numerator>(deep);
    }

    /// <summary>
    /// <para>Denominator.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:den.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ArgumentProperties &lt;m:argPr></description></item>
    ///   <item><description>Accent &lt;m:acc></description></item>
    ///   <item><description>Bar &lt;m:bar></description></item>
    ///   <item><description>Box &lt;m:box></description></item>
    ///   <item><description>BorderBox &lt;m:borderBox></description></item>
    ///   <item><description>Delimiter &lt;m:d></description></item>
    ///   <item><description>EquationArray &lt;m:eqArr></description></item>
    ///   <item><description>Fraction &lt;m:f></description></item>
    ///   <item><description>MathFunction &lt;m:func></description></item>
    ///   <item><description>GroupChar &lt;m:groupChr></description></item>
    ///   <item><description>LimitLower &lt;m:limLow></description></item>
    ///   <item><description>LimitUpper &lt;m:limUpp></description></item>
    ///   <item><description>Matrix &lt;m:m></description></item>
    ///   <item><description>Nary &lt;m:nary></description></item>
    ///   <item><description>Phantom &lt;m:phant></description></item>
    ///   <item><description>Radical &lt;m:rad></description></item>
    ///   <item><description>PreSubSuper &lt;m:sPre></description></item>
    ///   <item><description>Subscript &lt;m:sSub></description></item>
    ///   <item><description>SubSuperscript &lt;m:sSubSup></description></item>
    ///   <item><description>Superscript &lt;m:sSup></description></item>
    ///   <item><description>Run &lt;m:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
    ///   <item><description>Paragraph &lt;m:oMathPara></description></item>
    ///   <item><description>OfficeMath &lt;m:oMath></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class Denominator : OfficeMathArgumentType
    {
        /// <summary>
        /// Initializes a new instance of the Denominator class.
        /// </summary>
        public Denominator() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Denominator class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Denominator(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Denominator class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Denominator(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Denominator class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Denominator(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "den");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentProperties), 0, 1),
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Denominator>(deep);
    }

    /// <summary>
    /// <para>Function Name.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:fName.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ArgumentProperties &lt;m:argPr></description></item>
    ///   <item><description>Accent &lt;m:acc></description></item>
    ///   <item><description>Bar &lt;m:bar></description></item>
    ///   <item><description>Box &lt;m:box></description></item>
    ///   <item><description>BorderBox &lt;m:borderBox></description></item>
    ///   <item><description>Delimiter &lt;m:d></description></item>
    ///   <item><description>EquationArray &lt;m:eqArr></description></item>
    ///   <item><description>Fraction &lt;m:f></description></item>
    ///   <item><description>MathFunction &lt;m:func></description></item>
    ///   <item><description>GroupChar &lt;m:groupChr></description></item>
    ///   <item><description>LimitLower &lt;m:limLow></description></item>
    ///   <item><description>LimitUpper &lt;m:limUpp></description></item>
    ///   <item><description>Matrix &lt;m:m></description></item>
    ///   <item><description>Nary &lt;m:nary></description></item>
    ///   <item><description>Phantom &lt;m:phant></description></item>
    ///   <item><description>Radical &lt;m:rad></description></item>
    ///   <item><description>PreSubSuper &lt;m:sPre></description></item>
    ///   <item><description>Subscript &lt;m:sSub></description></item>
    ///   <item><description>SubSuperscript &lt;m:sSubSup></description></item>
    ///   <item><description>Superscript &lt;m:sSup></description></item>
    ///   <item><description>Run &lt;m:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
    ///   <item><description>Paragraph &lt;m:oMathPara></description></item>
    ///   <item><description>OfficeMath &lt;m:oMath></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class FunctionName : OfficeMathArgumentType
    {
        /// <summary>
        /// Initializes a new instance of the FunctionName class.
        /// </summary>
        public FunctionName() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FunctionName class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FunctionName(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FunctionName class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FunctionName(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FunctionName class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FunctionName(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "fName");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentProperties), 0, 1),
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FunctionName>(deep);
    }

    /// <summary>
    /// <para>Limit (Lower).</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:lim.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ArgumentProperties &lt;m:argPr></description></item>
    ///   <item><description>Accent &lt;m:acc></description></item>
    ///   <item><description>Bar &lt;m:bar></description></item>
    ///   <item><description>Box &lt;m:box></description></item>
    ///   <item><description>BorderBox &lt;m:borderBox></description></item>
    ///   <item><description>Delimiter &lt;m:d></description></item>
    ///   <item><description>EquationArray &lt;m:eqArr></description></item>
    ///   <item><description>Fraction &lt;m:f></description></item>
    ///   <item><description>MathFunction &lt;m:func></description></item>
    ///   <item><description>GroupChar &lt;m:groupChr></description></item>
    ///   <item><description>LimitLower &lt;m:limLow></description></item>
    ///   <item><description>LimitUpper &lt;m:limUpp></description></item>
    ///   <item><description>Matrix &lt;m:m></description></item>
    ///   <item><description>Nary &lt;m:nary></description></item>
    ///   <item><description>Phantom &lt;m:phant></description></item>
    ///   <item><description>Radical &lt;m:rad></description></item>
    ///   <item><description>PreSubSuper &lt;m:sPre></description></item>
    ///   <item><description>Subscript &lt;m:sSub></description></item>
    ///   <item><description>SubSuperscript &lt;m:sSubSup></description></item>
    ///   <item><description>Superscript &lt;m:sSup></description></item>
    ///   <item><description>Run &lt;m:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
    ///   <item><description>Paragraph &lt;m:oMathPara></description></item>
    ///   <item><description>OfficeMath &lt;m:oMath></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class Limit : OfficeMathArgumentType
    {
        /// <summary>
        /// Initializes a new instance of the Limit class.
        /// </summary>
        public Limit() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Limit class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Limit(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Limit class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Limit(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Limit class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Limit(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "lim");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentProperties), 0, 1),
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Limit>(deep);
    }

    /// <summary>
    /// <para>Lower limit (n-ary) .</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sub.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ArgumentProperties &lt;m:argPr></description></item>
    ///   <item><description>Accent &lt;m:acc></description></item>
    ///   <item><description>Bar &lt;m:bar></description></item>
    ///   <item><description>Box &lt;m:box></description></item>
    ///   <item><description>BorderBox &lt;m:borderBox></description></item>
    ///   <item><description>Delimiter &lt;m:d></description></item>
    ///   <item><description>EquationArray &lt;m:eqArr></description></item>
    ///   <item><description>Fraction &lt;m:f></description></item>
    ///   <item><description>MathFunction &lt;m:func></description></item>
    ///   <item><description>GroupChar &lt;m:groupChr></description></item>
    ///   <item><description>LimitLower &lt;m:limLow></description></item>
    ///   <item><description>LimitUpper &lt;m:limUpp></description></item>
    ///   <item><description>Matrix &lt;m:m></description></item>
    ///   <item><description>Nary &lt;m:nary></description></item>
    ///   <item><description>Phantom &lt;m:phant></description></item>
    ///   <item><description>Radical &lt;m:rad></description></item>
    ///   <item><description>PreSubSuper &lt;m:sPre></description></item>
    ///   <item><description>Subscript &lt;m:sSub></description></item>
    ///   <item><description>SubSuperscript &lt;m:sSubSup></description></item>
    ///   <item><description>Superscript &lt;m:sSup></description></item>
    ///   <item><description>Run &lt;m:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
    ///   <item><description>Paragraph &lt;m:oMathPara></description></item>
    ///   <item><description>OfficeMath &lt;m:oMath></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class SubArgument : OfficeMathArgumentType
    {
        /// <summary>
        /// Initializes a new instance of the SubArgument class.
        /// </summary>
        public SubArgument() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubArgument class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubArgument(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubArgument class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubArgument(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubArgument class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SubArgument(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "sub");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentProperties), 0, 1),
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SubArgument>(deep);
    }

    /// <summary>
    /// <para>Upper limit (n-ary).</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ArgumentProperties &lt;m:argPr></description></item>
    ///   <item><description>Accent &lt;m:acc></description></item>
    ///   <item><description>Bar &lt;m:bar></description></item>
    ///   <item><description>Box &lt;m:box></description></item>
    ///   <item><description>BorderBox &lt;m:borderBox></description></item>
    ///   <item><description>Delimiter &lt;m:d></description></item>
    ///   <item><description>EquationArray &lt;m:eqArr></description></item>
    ///   <item><description>Fraction &lt;m:f></description></item>
    ///   <item><description>MathFunction &lt;m:func></description></item>
    ///   <item><description>GroupChar &lt;m:groupChr></description></item>
    ///   <item><description>LimitLower &lt;m:limLow></description></item>
    ///   <item><description>LimitUpper &lt;m:limUpp></description></item>
    ///   <item><description>Matrix &lt;m:m></description></item>
    ///   <item><description>Nary &lt;m:nary></description></item>
    ///   <item><description>Phantom &lt;m:phant></description></item>
    ///   <item><description>Radical &lt;m:rad></description></item>
    ///   <item><description>PreSubSuper &lt;m:sPre></description></item>
    ///   <item><description>Subscript &lt;m:sSub></description></item>
    ///   <item><description>SubSuperscript &lt;m:sSubSup></description></item>
    ///   <item><description>Superscript &lt;m:sSup></description></item>
    ///   <item><description>Run &lt;m:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
    ///   <item><description>Paragraph &lt;m:oMathPara></description></item>
    ///   <item><description>OfficeMath &lt;m:oMath></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class SuperArgument : OfficeMathArgumentType
    {
        /// <summary>
        /// Initializes a new instance of the SuperArgument class.
        /// </summary>
        public SuperArgument() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SuperArgument class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SuperArgument(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SuperArgument class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SuperArgument(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SuperArgument class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SuperArgument(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "sup");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentProperties), 0, 1),
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SuperArgument>(deep);
    }

    /// <summary>
    /// <para>Degree.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:deg.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ArgumentProperties &lt;m:argPr></description></item>
    ///   <item><description>Accent &lt;m:acc></description></item>
    ///   <item><description>Bar &lt;m:bar></description></item>
    ///   <item><description>Box &lt;m:box></description></item>
    ///   <item><description>BorderBox &lt;m:borderBox></description></item>
    ///   <item><description>Delimiter &lt;m:d></description></item>
    ///   <item><description>EquationArray &lt;m:eqArr></description></item>
    ///   <item><description>Fraction &lt;m:f></description></item>
    ///   <item><description>MathFunction &lt;m:func></description></item>
    ///   <item><description>GroupChar &lt;m:groupChr></description></item>
    ///   <item><description>LimitLower &lt;m:limLow></description></item>
    ///   <item><description>LimitUpper &lt;m:limUpp></description></item>
    ///   <item><description>Matrix &lt;m:m></description></item>
    ///   <item><description>Nary &lt;m:nary></description></item>
    ///   <item><description>Phantom &lt;m:phant></description></item>
    ///   <item><description>Radical &lt;m:rad></description></item>
    ///   <item><description>PreSubSuper &lt;m:sPre></description></item>
    ///   <item><description>Subscript &lt;m:sSub></description></item>
    ///   <item><description>SubSuperscript &lt;m:sSubSup></description></item>
    ///   <item><description>Superscript &lt;m:sSup></description></item>
    ///   <item><description>Run &lt;m:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
    ///   <item><description>Paragraph &lt;m:oMathPara></description></item>
    ///   <item><description>OfficeMath &lt;m:oMath></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class Degree : OfficeMathArgumentType
    {
        /// <summary>
        /// Initializes a new instance of the Degree class.
        /// </summary>
        public Degree() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Degree class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Degree(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Degree class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Degree(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Degree class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Degree(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "deg");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentProperties), 0, 1),
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Degree>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeMathArgumentType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ArgumentProperties &lt;m:argPr></description></item>
    ///   <item><description>Accent &lt;m:acc></description></item>
    ///   <item><description>Bar &lt;m:bar></description></item>
    ///   <item><description>Box &lt;m:box></description></item>
    ///   <item><description>BorderBox &lt;m:borderBox></description></item>
    ///   <item><description>Delimiter &lt;m:d></description></item>
    ///   <item><description>EquationArray &lt;m:eqArr></description></item>
    ///   <item><description>Fraction &lt;m:f></description></item>
    ///   <item><description>MathFunction &lt;m:func></description></item>
    ///   <item><description>GroupChar &lt;m:groupChr></description></item>
    ///   <item><description>LimitLower &lt;m:limLow></description></item>
    ///   <item><description>LimitUpper &lt;m:limUpp></description></item>
    ///   <item><description>Matrix &lt;m:m></description></item>
    ///   <item><description>Nary &lt;m:nary></description></item>
    ///   <item><description>Phantom &lt;m:phant></description></item>
    ///   <item><description>Radical &lt;m:rad></description></item>
    ///   <item><description>PreSubSuper &lt;m:sPre></description></item>
    ///   <item><description>Subscript &lt;m:sSub></description></item>
    ///   <item><description>SubSuperscript &lt;m:sSubSup></description></item>
    ///   <item><description>Superscript &lt;m:sSup></description></item>
    ///   <item><description>Run &lt;m:r></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
    ///   <item><description>Paragraph &lt;m:oMathPara></description></item>
    ///   <item><description>OfficeMath &lt;m:oMath></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public abstract partial class OfficeMathArgumentType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeMathArgumentType class.
        /// </summary>
        protected OfficeMathArgumentType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMathArgumentType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OfficeMathArgumentType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMathArgumentType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OfficeMathArgumentType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMathArgumentType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected OfficeMathArgumentType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<ArgumentProperties>();
            builder.AddChild<Accent>();
            builder.AddChild<Bar>();
            builder.AddChild<Box>();
            builder.AddChild<BorderBox>();
            builder.AddChild<Delimiter>();
            builder.AddChild<EquationArray>();
            builder.AddChild<Fraction>();
            builder.AddChild<MathFunction>();
            builder.AddChild<GroupChar>();
            builder.AddChild<LimitLower>();
            builder.AddChild<LimitUpper>();
            builder.AddChild<Matrix>();
            builder.AddChild<Nary>();
            builder.AddChild<Phantom>();
            builder.AddChild<Radical>();
            builder.AddChild<PreSubSuper>();
            builder.AddChild<Subscript>();
            builder.AddChild<SubSuperscript>();
            builder.AddChild<Superscript>();
            builder.AddChild<Run>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.SimpleField>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Hyperlink>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.SdtRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.ContentPart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
            builder.AddChild<Paragraph>();
            builder.AddChild<OfficeMath>();
            builder.AddChild<ControlProperties>();
        }

        /// <summary>
        /// <para>Argument Properties.</para>
        /// <para>Represents the following element tag in the schema: m:argPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ArgumentProperties ArgumentProperties
        {
            get => GetElement<ArgumentProperties>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Position (Bar).</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:pos.</para>
    /// </summary>
    public partial class Position : TopBottomType
    {
        /// <summary>
        /// Initializes a new instance of the Position class.
        /// </summary>
        public Position() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "pos");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Position>(deep);
    }

    /// <summary>
    /// <para>Vertical Justification.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:vertJc.</para>
    /// </summary>
    public partial class VerticalJustification : TopBottomType
    {
        /// <summary>
        /// Initializes a new instance of the VerticalJustification class.
        /// </summary>
        public VerticalJustification() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "vertJc");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VerticalJustification>(deep);
    }

    /// <summary>
    /// <para>Defines the TopBottomType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class TopBottomType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TopBottomType class.
        /// </summary>
        protected TopBottomType() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<TopBottomType>()
                           .AddAttribute(21, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>Bar Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:barPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Position &lt;m:pos></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class BarProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BarProperties class.
        /// </summary>
        public BarProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BarProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "barPr");
            builder.AddChild<Position>();
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Position), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Position (Bar).</para>
        /// <para>Represents the following element tag in the schema: m:pos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Position Position
        {
            get => GetElement<Position>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarProperties>(deep);
    }

    /// <summary>
    /// <para>Box Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:boxPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OperatorEmulator &lt;m:opEmu></description></item>
    ///   <item><description>NoBreak &lt;m:noBreak></description></item>
    ///   <item><description>Differential &lt;m:diff></description></item>
    ///   <item><description>Break &lt;m:brk></description></item>
    ///   <item><description>Alignment &lt;m:aln></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class BoxProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BoxProperties class.
        /// </summary>
        public BoxProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BoxProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BoxProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BoxProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BoxProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BoxProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BoxProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "boxPr");
            builder.AddChild<OperatorEmulator>();
            builder.AddChild<NoBreak>();
            builder.AddChild<Differential>();
            builder.AddChild<Break>();
            builder.AddChild<Alignment>();
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OperatorEmulator), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.NoBreak), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Differential), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Break), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Alignment), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Operator Emulator.</para>
        /// <para>Represents the following element tag in the schema: m:opEmu.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public OperatorEmulator OperatorEmulator
        {
            get => GetElement<OperatorEmulator>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>No Break.</para>
        /// <para>Represents the following element tag in the schema: m:noBreak.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public NoBreak NoBreak
        {
            get => GetElement<NoBreak>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Differential.</para>
        /// <para>Represents the following element tag in the schema: m:diff.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Differential Differential
        {
            get => GetElement<Differential>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Break.</para>
        /// <para>Represents the following element tag in the schema: m:brk.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Break Break
        {
            get => GetElement<Break>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Alignment.</para>
        /// <para>Represents the following element tag in the schema: m:aln.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Alignment Alignment
        {
            get => GetElement<Alignment>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BoxProperties>(deep);
    }

    /// <summary>
    /// <para>Border Box Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:borderBoxPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>HideTop &lt;m:hideTop></description></item>
    ///   <item><description>HideBottom &lt;m:hideBot></description></item>
    ///   <item><description>HideLeft &lt;m:hideLeft></description></item>
    ///   <item><description>HideRight &lt;m:hideRight></description></item>
    ///   <item><description>StrikeHorizontal &lt;m:strikeH></description></item>
    ///   <item><description>StrikeVertical &lt;m:strikeV></description></item>
    ///   <item><description>StrikeBottomLeftToTopRight &lt;m:strikeBLTR></description></item>
    ///   <item><description>StrikeTopLeftToBottomRight &lt;m:strikeTLBR></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class BorderBoxProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BorderBoxProperties class.
        /// </summary>
        public BorderBoxProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BorderBoxProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BorderBoxProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BorderBoxProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BorderBoxProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BorderBoxProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BorderBoxProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "borderBoxPr");
            builder.AddChild<HideTop>();
            builder.AddChild<HideBottom>();
            builder.AddChild<HideLeft>();
            builder.AddChild<HideRight>();
            builder.AddChild<StrikeHorizontal>();
            builder.AddChild<StrikeVertical>();
            builder.AddChild<StrikeBottomLeftToTopRight>();
            builder.AddChild<StrikeTopLeftToBottomRight>();
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.HideTop), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.HideBottom), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.HideLeft), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.HideRight), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.StrikeHorizontal), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.StrikeVertical), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.StrikeBottomLeftToTopRight), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.StrikeTopLeftToBottomRight), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Hide Top Edge.</para>
        /// <para>Represents the following element tag in the schema: m:hideTop.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public HideTop HideTop
        {
            get => GetElement<HideTop>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hide Bottom Edge.</para>
        /// <para>Represents the following element tag in the schema: m:hideBot.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public HideBottom HideBottom
        {
            get => GetElement<HideBottom>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hide Left Edge.</para>
        /// <para>Represents the following element tag in the schema: m:hideLeft.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public HideLeft HideLeft
        {
            get => GetElement<HideLeft>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hide Right Edge.</para>
        /// <para>Represents the following element tag in the schema: m:hideRight.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public HideRight HideRight
        {
            get => GetElement<HideRight>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Border Box Strikethrough Horizontal.</para>
        /// <para>Represents the following element tag in the schema: m:strikeH.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public StrikeHorizontal StrikeHorizontal
        {
            get => GetElement<StrikeHorizontal>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Border Box Strikethrough Vertical.</para>
        /// <para>Represents the following element tag in the schema: m:strikeV.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public StrikeVertical StrikeVertical
        {
            get => GetElement<StrikeVertical>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Border Box Strikethrough Bottom-Left to Top-Right.</para>
        /// <para>Represents the following element tag in the schema: m:strikeBLTR.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public StrikeBottomLeftToTopRight StrikeBottomLeftToTopRight
        {
            get => GetElement<StrikeBottomLeftToTopRight>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Border Box Strikethrough Top-Left to Bottom-Right.</para>
        /// <para>Represents the following element tag in the schema: m:strikeTLBR.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public StrikeTopLeftToBottomRight StrikeTopLeftToBottomRight
        {
            get => GetElement<StrikeTopLeftToBottomRight>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BorderBoxProperties>(deep);
    }

    /// <summary>
    /// <para>Shape (Delimiters).</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:shp.</para>
    /// </summary>
    public partial class Shape : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Shape class.
        /// </summary>
        public Shape() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "shp");
            builder.AddElement<Shape>()
.AddAttribute(21, "val", a => a.Val, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);
    }

    /// <summary>
    /// <para>Delimiter Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:dPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BeginChar &lt;m:begChr></description></item>
    ///   <item><description>SeparatorChar &lt;m:sepChr></description></item>
    ///   <item><description>EndChar &lt;m:endChr></description></item>
    ///   <item><description>GrowOperators &lt;m:grow></description></item>
    ///   <item><description>Shape &lt;m:shp></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class DelimiterProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DelimiterProperties class.
        /// </summary>
        public DelimiterProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DelimiterProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DelimiterProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DelimiterProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DelimiterProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DelimiterProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DelimiterProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "dPr");
            builder.AddChild<BeginChar>();
            builder.AddChild<SeparatorChar>();
            builder.AddChild<EndChar>();
            builder.AddChild<GrowOperators>();
            builder.AddChild<Shape>();
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BeginChar), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SeparatorChar), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EndChar), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GrowOperators), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Shape), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Delimiter Beginning Character.</para>
        /// <para>Represents the following element tag in the schema: m:begChr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public BeginChar BeginChar
        {
            get => GetElement<BeginChar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Delimiter Separator Character.</para>
        /// <para>Represents the following element tag in the schema: m:sepChr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public SeparatorChar SeparatorChar
        {
            get => GetElement<SeparatorChar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Delimiter Ending Character.</para>
        /// <para>Represents the following element tag in the schema: m:endChr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public EndChar EndChar
        {
            get => GetElement<EndChar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Delimiter Grow.</para>
        /// <para>Represents the following element tag in the schema: m:grow.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public GrowOperators GrowOperators
        {
            get => GetElement<GrowOperators>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape (Delimiters).</para>
        /// <para>Represents the following element tag in the schema: m:shp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Shape Shape
        {
            get => GetElement<Shape>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DelimiterProperties>(deep);
    }

    /// <summary>
    /// <para>Equation Array Base Justification.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:baseJc.</para>
    /// </summary>
    public partial class BaseJustification : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BaseJustification class.
        /// </summary>
        public BaseJustification() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "baseJc");
            builder.AddElement<BaseJustification>()
.AddAttribute(21, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BaseJustification>(deep);
    }

    /// <summary>
    /// <para>Row Spacing Rule.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:rSpRule.</para>
    /// </summary>
    public partial class RowSpacingRule : SpacingRuleType
    {
        /// <summary>
        /// Initializes a new instance of the RowSpacingRule class.
        /// </summary>
        public RowSpacingRule() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "rSpRule");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowSpacingRule>(deep);
    }

    /// <summary>
    /// <para>Matrix Column Gap Rule.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:cGpRule.</para>
    /// </summary>
    public partial class ColumnGapRule : SpacingRuleType
    {
        /// <summary>
        /// Initializes a new instance of the ColumnGapRule class.
        /// </summary>
        public ColumnGapRule() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "cGpRule");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnGapRule>(deep);
    }

    /// <summary>
    /// <para>Defines the SpacingRuleType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class SpacingRuleType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SpacingRuleType class.
        /// </summary>
        protected SpacingRuleType() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public IntegerValue Val
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<SpacingRuleType>()
                           .AddAttribute(21, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (4L) });
                           });
        }
    }

    /// <summary>
    /// <para>Row Spacing (Equation Array).</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:rSp.</para>
    /// </summary>
    public partial class RowSpacing : UnsignedShortType
    {
        /// <summary>
        /// Initializes a new instance of the RowSpacing class.
        /// </summary>
        public RowSpacing() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "rSp");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowSpacing>(deep);
    }

    /// <summary>
    /// <para>Matrix Column Gap.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:cGp.</para>
    /// </summary>
    public partial class ColumnGap : UnsignedShortType
    {
        /// <summary>
        /// Initializes a new instance of the ColumnGap class.
        /// </summary>
        public ColumnGap() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "cGp");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnGap>(deep);
    }

    /// <summary>
    /// <para>Defines the UnsignedShortType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class UnsignedShortType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsignedShortType class.
        /// </summary>
        protected UnsignedShortType() : base()
        {
        }

        /// <summary>
        /// <para>val</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public UInt16Value Val
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<UnsignedShortType>()
                           .AddAttribute(21, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>Equation Array Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:eqArrPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BaseJustification &lt;m:baseJc></description></item>
    ///   <item><description>MaxDistribution &lt;m:maxDist></description></item>
    ///   <item><description>ObjectDistribution &lt;m:objDist></description></item>
    ///   <item><description>RowSpacingRule &lt;m:rSpRule></description></item>
    ///   <item><description>RowSpacing &lt;m:rSp></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class EquationArrayProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the EquationArrayProperties class.
        /// </summary>
        public EquationArrayProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EquationArrayProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EquationArrayProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EquationArrayProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EquationArrayProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EquationArrayProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EquationArrayProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "eqArrPr");
            builder.AddChild<BaseJustification>();
            builder.AddChild<MaxDistribution>();
            builder.AddChild<ObjectDistribution>();
            builder.AddChild<RowSpacingRule>();
            builder.AddChild<RowSpacing>();
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BaseJustification), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MaxDistribution), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ObjectDistribution), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.RowSpacingRule), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.RowSpacing), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Equation Array Base Justification.</para>
        /// <para>Represents the following element tag in the schema: m:baseJc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public BaseJustification BaseJustification
        {
            get => GetElement<BaseJustification>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Maximum Distribution.</para>
        /// <para>Represents the following element tag in the schema: m:maxDist.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public MaxDistribution MaxDistribution
        {
            get => GetElement<MaxDistribution>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Object Distribution.</para>
        /// <para>Represents the following element tag in the schema: m:objDist.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ObjectDistribution ObjectDistribution
        {
            get => GetElement<ObjectDistribution>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Row Spacing Rule.</para>
        /// <para>Represents the following element tag in the schema: m:rSpRule.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public RowSpacingRule RowSpacingRule
        {
            get => GetElement<RowSpacingRule>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Row Spacing (Equation Array).</para>
        /// <para>Represents the following element tag in the schema: m:rSp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public RowSpacing RowSpacing
        {
            get => GetElement<RowSpacing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EquationArrayProperties>(deep);
    }

    /// <summary>
    /// <para>Fraction type.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:type.</para>
    /// </summary>
    public partial class FractionType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the FractionType class.
        /// </summary>
        public FractionType() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Math.FractionTypeValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.FractionTypeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "type");
            builder.AddElement<FractionType>()
.AddAttribute(21, "val", a => a.Val, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FractionType>(deep);
    }

    /// <summary>
    /// <para>Fraction Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:fPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>FractionType &lt;m:type></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class FractionProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FractionProperties class.
        /// </summary>
        public FractionProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FractionProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FractionProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FractionProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FractionProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FractionProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FractionProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "fPr");
            builder.AddChild<FractionType>();
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.FractionType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Fraction type.</para>
        /// <para>Represents the following element tag in the schema: m:type.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public FractionType FractionType
        {
            get => GetElement<FractionType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FractionProperties>(deep);
    }

    /// <summary>
    /// <para>Function Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:funcPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class FunctionProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FunctionProperties class.
        /// </summary>
        public FunctionProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FunctionProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FunctionProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FunctionProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FunctionProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FunctionProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FunctionProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "funcPr");
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FunctionProperties>(deep);
    }

    /// <summary>
    /// <para>Group-Character Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:groupChrPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AccentChar &lt;m:chr></description></item>
    ///   <item><description>Position &lt;m:pos></description></item>
    ///   <item><description>VerticalJustification &lt;m:vertJc></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class GroupCharProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupCharProperties class.
        /// </summary>
        public GroupCharProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupCharProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupCharProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupCharProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupCharProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupCharProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupCharProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "groupChrPr");
            builder.AddChild<AccentChar>();
            builder.AddChild<Position>();
            builder.AddChild<VerticalJustification>();
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.AccentChar), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Position), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.VerticalJustification), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Group Character (Grouping Character).</para>
        /// <para>Represents the following element tag in the schema: m:chr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public AccentChar AccentChar
        {
            get => GetElement<AccentChar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Position (Group Character).</para>
        /// <para>Represents the following element tag in the schema: m:pos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Position Position
        {
            get => GetElement<Position>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Vertical Justification.</para>
        /// <para>Represents the following element tag in the schema: m:vertJc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public VerticalJustification VerticalJustification
        {
            get => GetElement<VerticalJustification>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupCharProperties>(deep);
    }

    /// <summary>
    /// <para>Lower Limit Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:limLowPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class LimitLowerProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LimitLowerProperties class.
        /// </summary>
        public LimitLowerProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitLowerProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LimitLowerProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitLowerProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LimitLowerProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitLowerProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LimitLowerProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "limLowPr");
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LimitLowerProperties>(deep);
    }

    /// <summary>
    /// <para>Upper Limit Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:limUppPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class LimitUpperProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LimitUpperProperties class.
        /// </summary>
        public LimitUpperProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitUpperProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LimitUpperProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitUpperProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LimitUpperProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitUpperProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LimitUpperProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "limUppPr");
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LimitUpperProperties>(deep);
    }

    /// <summary>
    /// <para>Matrix Column Count.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:count.</para>
    /// </summary>
    public partial class MatrixColumnCount : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MatrixColumnCount class.
        /// </summary>
        public MatrixColumnCount() : base()
        {
        }

        /// <summary>
        /// <para>val</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public IntegerValue Val
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "count");
            builder.AddElement<MatrixColumnCount>()
.AddAttribute(21, "val", a => a.Val, aBuilder =>
{
 aBuilder.AddValidator(RequiredValidator.Instance);
 aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (64L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixColumnCount>(deep);
    }

    /// <summary>
    /// <para>Matrix Column Justification.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:mcJc.</para>
    /// </summary>
    public partial class MatrixColumnJustification : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MatrixColumnJustification class.
        /// </summary>
        public MatrixColumnJustification() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "mcJc");
            builder.AddElement<MatrixColumnJustification>()
.AddAttribute(21, "val", a => a.Val, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixColumnJustification>(deep);
    }

    /// <summary>
    /// <para>Matrix Column Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:mcPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>MatrixColumnCount &lt;m:count></description></item>
    ///   <item><description>MatrixColumnJustification &lt;m:mcJc></description></item>
    /// </list>
    /// </remark>
    public partial class MatrixColumnProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MatrixColumnProperties class.
        /// </summary>
        public MatrixColumnProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumnProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixColumnProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumnProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixColumnProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumnProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MatrixColumnProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "mcPr");
            builder.AddChild<MatrixColumnCount>();
            builder.AddChild<MatrixColumnJustification>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MatrixColumnCount), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MatrixColumnJustification), 0, 1)
            };
        }

        /// <summary>
        /// <para>Matrix Column Count.</para>
        /// <para>Represents the following element tag in the schema: m:count.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public MatrixColumnCount MatrixColumnCount
        {
            get => GetElement<MatrixColumnCount>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Matrix Column Justification.</para>
        /// <para>Represents the following element tag in the schema: m:mcJc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public MatrixColumnJustification MatrixColumnJustification
        {
            get => GetElement<MatrixColumnJustification>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixColumnProperties>(deep);
    }

    /// <summary>
    /// <para>Matrix Column.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:mc.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>MatrixColumnProperties &lt;m:mcPr></description></item>
    /// </list>
    /// </remark>
    public partial class MatrixColumn : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MatrixColumn class.
        /// </summary>
        public MatrixColumn() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumn class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixColumn(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumn class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixColumn(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumn class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MatrixColumn(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "mc");
            builder.AddChild<MatrixColumnProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MatrixColumnProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Matrix Column Properties.</para>
        /// <para>Represents the following element tag in the schema: m:mcPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public MatrixColumnProperties MatrixColumnProperties
        {
            get => GetElement<MatrixColumnProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixColumn>(deep);
    }

    /// <summary>
    /// <para>Matrix Column Spacing.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:cSp.</para>
    /// </summary>
    public partial class ColumnSpacing : TwipsMeasureType
    {
        /// <summary>
        /// Initializes a new instance of the ColumnSpacing class.
        /// </summary>
        public ColumnSpacing() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "cSp");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnSpacing>(deep);
    }

    /// <summary>
    /// <para>Left Margin.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:lMargin.</para>
    /// </summary>
    public partial class LeftMargin : TwipsMeasureType
    {
        /// <summary>
        /// Initializes a new instance of the LeftMargin class.
        /// </summary>
        public LeftMargin() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "lMargin");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LeftMargin>(deep);
    }

    /// <summary>
    /// <para>Right Margin.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:rMargin.</para>
    /// </summary>
    public partial class RightMargin : TwipsMeasureType
    {
        /// <summary>
        /// Initializes a new instance of the RightMargin class.
        /// </summary>
        public RightMargin() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "rMargin");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RightMargin>(deep);
    }

    /// <summary>
    /// <para>Pre-Equation Spacing.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:preSp.</para>
    /// </summary>
    public partial class PreSpacing : TwipsMeasureType
    {
        /// <summary>
        /// Initializes a new instance of the PreSpacing class.
        /// </summary>
        public PreSpacing() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "preSp");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PreSpacing>(deep);
    }

    /// <summary>
    /// <para>Post-Equation Spacing.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:postSp.</para>
    /// </summary>
    public partial class PostSpacing : TwipsMeasureType
    {
        /// <summary>
        /// Initializes a new instance of the PostSpacing class.
        /// </summary>
        public PostSpacing() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "postSp");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PostSpacing>(deep);
    }

    /// <summary>
    /// <para>Inter-Equation Spacing.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:interSp.</para>
    /// </summary>
    public partial class InterSpacing : TwipsMeasureType
    {
        /// <summary>
        /// Initializes a new instance of the InterSpacing class.
        /// </summary>
        public InterSpacing() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "interSp");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InterSpacing>(deep);
    }

    /// <summary>
    /// <para>Intra-Equation Spacing.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:intraSp.</para>
    /// </summary>
    public partial class IntraSpacing : TwipsMeasureType
    {
        /// <summary>
        /// Initializes a new instance of the IntraSpacing class.
        /// </summary>
        public IntraSpacing() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "intraSp");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IntraSpacing>(deep);
    }

    /// <summary>
    /// <para>Wrap Indent.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:wrapIndent.</para>
    /// </summary>
    public partial class WrapIndent : TwipsMeasureType
    {
        /// <summary>
        /// Initializes a new instance of the WrapIndent class.
        /// </summary>
        public WrapIndent() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "wrapIndent");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapIndent>(deep);
    }

    /// <summary>
    /// <para>Defines the TwipsMeasureType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class TwipsMeasureType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TwipsMeasureType class.
        /// </summary>
        protected TwipsMeasureType() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public UInt32Value Val
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<TwipsMeasureType>()
                           .AddAttribute(21, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new NumberValidator() { MaxInclusive = (31680L) });
                           });
        }
    }

    /// <summary>
    /// <para>Matrix Columns.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:mcs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>MatrixColumn &lt;m:mc></description></item>
    /// </list>
    /// </remark>
    public partial class MatrixColumns : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MatrixColumns class.
        /// </summary>
        public MatrixColumns() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumns class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixColumns(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumns class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixColumns(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumns class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MatrixColumns(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "mcs");
            builder.AddChild<MatrixColumn>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MatrixColumn), 1, 64)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixColumns>(deep);
    }

    /// <summary>
    /// <para>Matrix Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:mPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BaseJustification &lt;m:baseJc></description></item>
    ///   <item><description>HidePlaceholder &lt;m:plcHide></description></item>
    ///   <item><description>RowSpacingRule &lt;m:rSpRule></description></item>
    ///   <item><description>ColumnGapRule &lt;m:cGpRule></description></item>
    ///   <item><description>RowSpacing &lt;m:rSp></description></item>
    ///   <item><description>ColumnSpacing &lt;m:cSp></description></item>
    ///   <item><description>ColumnGap &lt;m:cGp></description></item>
    ///   <item><description>MatrixColumns &lt;m:mcs></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class MatrixProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MatrixProperties class.
        /// </summary>
        public MatrixProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MatrixProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "mPr");
            builder.AddChild<BaseJustification>();
            builder.AddChild<HidePlaceholder>();
            builder.AddChild<RowSpacingRule>();
            builder.AddChild<ColumnGapRule>();
            builder.AddChild<RowSpacing>();
            builder.AddChild<ColumnSpacing>();
            builder.AddChild<ColumnGap>();
            builder.AddChild<MatrixColumns>();
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BaseJustification), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.HidePlaceholder), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.RowSpacingRule), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ColumnGapRule), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.RowSpacing), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ColumnSpacing), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ColumnGap), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MatrixColumns), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Matrix Base Justification.</para>
        /// <para>Represents the following element tag in the schema: m:baseJc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public BaseJustification BaseJustification
        {
            get => GetElement<BaseJustification>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hide Placeholders (Matrix).</para>
        /// <para>Represents the following element tag in the schema: m:plcHide.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public HidePlaceholder HidePlaceholder
        {
            get => GetElement<HidePlaceholder>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Row Spacing Rule.</para>
        /// <para>Represents the following element tag in the schema: m:rSpRule.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public RowSpacingRule RowSpacingRule
        {
            get => GetElement<RowSpacingRule>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Matrix Column Gap Rule.</para>
        /// <para>Represents the following element tag in the schema: m:cGpRule.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ColumnGapRule ColumnGapRule
        {
            get => GetElement<ColumnGapRule>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Row Spacing (Matrix).</para>
        /// <para>Represents the following element tag in the schema: m:rSp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public RowSpacing RowSpacing
        {
            get => GetElement<RowSpacing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Matrix Column Spacing.</para>
        /// <para>Represents the following element tag in the schema: m:cSp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ColumnSpacing ColumnSpacing
        {
            get => GetElement<ColumnSpacing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Matrix Column Gap.</para>
        /// <para>Represents the following element tag in the schema: m:cGp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ColumnGap ColumnGap
        {
            get => GetElement<ColumnGap>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Matrix Columns.</para>
        /// <para>Represents the following element tag in the schema: m:mcs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public MatrixColumns MatrixColumns
        {
            get => GetElement<MatrixColumns>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixProperties>(deep);
    }

    /// <summary>
    /// <para>Matrix Row.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:mr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Base &lt;m:e></description></item>
    /// </list>
    /// </remark>
    public partial class MatrixRow : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MatrixRow class.
        /// </summary>
        public MatrixRow() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixRow class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixRow(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixRow class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixRow(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixRow class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MatrixRow(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "mr");
            builder.AddChild<Base>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 64)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixRow>(deep);
    }

    /// <summary>
    /// <para>n-ary Limit Location.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:limLoc.</para>
    /// </summary>
    public partial class LimitLocation : LimitLocationType
    {
        /// <summary>
        /// Initializes a new instance of the LimitLocation class.
        /// </summary>
        public LimitLocation() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "limLoc");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LimitLocation>(deep);
    }

    /// <summary>
    /// <para>Integral Limit Locations.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:intLim.</para>
    /// </summary>
    public partial class IntegralLimitLocation : LimitLocationType
    {
        /// <summary>
        /// Initializes a new instance of the IntegralLimitLocation class.
        /// </summary>
        public IntegralLimitLocation() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "intLim");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IntegralLimitLocation>(deep);
    }

    /// <summary>
    /// <para>n-ary Limit Location.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:naryLim.</para>
    /// </summary>
    public partial class NaryLimitLocation : LimitLocationType
    {
        /// <summary>
        /// Initializes a new instance of the NaryLimitLocation class.
        /// </summary>
        public NaryLimitLocation() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "naryLim");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NaryLimitLocation>(deep);
    }

    /// <summary>
    /// <para>Defines the LimitLocationType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class LimitLocationType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the LimitLocationType class.
        /// </summary>
        protected LimitLocationType() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Math.LimitLocationValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.LimitLocationValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<LimitLocationType>()
                           .AddAttribute(21, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>n-ary Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:naryPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AccentChar &lt;m:chr></description></item>
    ///   <item><description>LimitLocation &lt;m:limLoc></description></item>
    ///   <item><description>GrowOperators &lt;m:grow></description></item>
    ///   <item><description>HideSubArgument &lt;m:subHide></description></item>
    ///   <item><description>HideSuperArgument &lt;m:supHide></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class NaryProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NaryProperties class.
        /// </summary>
        public NaryProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NaryProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NaryProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NaryProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NaryProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NaryProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NaryProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "naryPr");
            builder.AddChild<AccentChar>();
            builder.AddChild<LimitLocation>();
            builder.AddChild<GrowOperators>();
            builder.AddChild<HideSubArgument>();
            builder.AddChild<HideSuperArgument>();
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.AccentChar), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLocation), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GrowOperators), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.HideSubArgument), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.HideSuperArgument), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>n-ary Operator Character.</para>
        /// <para>Represents the following element tag in the schema: m:chr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public AccentChar AccentChar
        {
            get => GetElement<AccentChar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>n-ary Limit Location.</para>
        /// <para>Represents the following element tag in the schema: m:limLoc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public LimitLocation LimitLocation
        {
            get => GetElement<LimitLocation>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>n-ary Grow.</para>
        /// <para>Represents the following element tag in the schema: m:grow.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public GrowOperators GrowOperators
        {
            get => GetElement<GrowOperators>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hide Subscript (n-ary).</para>
        /// <para>Represents the following element tag in the schema: m:subHide.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public HideSubArgument HideSubArgument
        {
            get => GetElement<HideSubArgument>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hide Superscript (n-ary).</para>
        /// <para>Represents the following element tag in the schema: m:supHide.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public HideSuperArgument HideSuperArgument
        {
            get => GetElement<HideSuperArgument>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NaryProperties>(deep);
    }

    /// <summary>
    /// <para>Phantom Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:phantPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ShowPhantom &lt;m:show></description></item>
    ///   <item><description>ZeroWidth &lt;m:zeroWid></description></item>
    ///   <item><description>ZeroAscent &lt;m:zeroAsc></description></item>
    ///   <item><description>ZeroDescent &lt;m:zeroDesc></description></item>
    ///   <item><description>Transparent &lt;m:transp></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class PhantomProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PhantomProperties class.
        /// </summary>
        public PhantomProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PhantomProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PhantomProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PhantomProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PhantomProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PhantomProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PhantomProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "phantPr");
            builder.AddChild<ShowPhantom>();
            builder.AddChild<ZeroWidth>();
            builder.AddChild<ZeroAscent>();
            builder.AddChild<ZeroDescent>();
            builder.AddChild<Transparent>();
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ShowPhantom), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ZeroWidth), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ZeroAscent), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ZeroDescent), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Transparent), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Phantom Show.</para>
        /// <para>Represents the following element tag in the schema: m:show.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ShowPhantom ShowPhantom
        {
            get => GetElement<ShowPhantom>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Phantom Zero Width.</para>
        /// <para>Represents the following element tag in the schema: m:zeroWid.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ZeroWidth ZeroWidth
        {
            get => GetElement<ZeroWidth>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Phantom Zero Ascent.</para>
        /// <para>Represents the following element tag in the schema: m:zeroAsc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ZeroAscent ZeroAscent
        {
            get => GetElement<ZeroAscent>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Phantom Zero Descent.</para>
        /// <para>Represents the following element tag in the schema: m:zeroDesc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ZeroDescent ZeroDescent
        {
            get => GetElement<ZeroDescent>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Transparent (Phantom).</para>
        /// <para>Represents the following element tag in the schema: m:transp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Transparent Transparent
        {
            get => GetElement<Transparent>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PhantomProperties>(deep);
    }

    /// <summary>
    /// <para>Radical Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:radPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>HideDegree &lt;m:degHide></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class RadicalProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RadicalProperties class.
        /// </summary>
        public RadicalProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadicalProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadicalProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadicalProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadicalProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadicalProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RadicalProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "radPr");
            builder.AddChild<HideDegree>();
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.HideDegree), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Hide Degree.</para>
        /// <para>Represents the following element tag in the schema: m:degHide.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public HideDegree HideDegree
        {
            get => GetElement<HideDegree>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadicalProperties>(deep);
    }

    /// <summary>
    /// <para>Pre-Sub-Superscript Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sPrePr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class PreSubSuperProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PreSubSuperProperties class.
        /// </summary>
        public PreSubSuperProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PreSubSuperProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PreSubSuperProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PreSubSuperProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PreSubSuperProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PreSubSuperProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PreSubSuperProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "sPrePr");
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PreSubSuperProperties>(deep);
    }

    /// <summary>
    /// <para>Subscript Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sSubPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class SubscriptProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptProperties class.
        /// </summary>
        public SubscriptProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubscriptProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubscriptProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SubscriptProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "sSubPr");
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SubscriptProperties>(deep);
    }

    /// <summary>
    /// <para>Sub-Superscript Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sSubSupPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AlignScripts &lt;m:alnScr></description></item>
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class SubSuperscriptProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SubSuperscriptProperties class.
        /// </summary>
        public SubSuperscriptProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubSuperscriptProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubSuperscriptProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubSuperscriptProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubSuperscriptProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubSuperscriptProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SubSuperscriptProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "sSubSupPr");
            builder.AddChild<AlignScripts>();
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.AlignScripts), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Align Scripts.</para>
        /// <para>Represents the following element tag in the schema: m:alnScr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public AlignScripts AlignScripts
        {
            get => GetElement<AlignScripts>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SubSuperscriptProperties>(deep);
    }

    /// <summary>
    /// <para>Superscript Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sSupPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ControlProperties &lt;m:ctrlPr></description></item>
    /// </list>
    /// </remark>
    public partial class SuperscriptProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SuperscriptProperties class.
        /// </summary>
        public SuperscriptProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SuperscriptProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SuperscriptProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SuperscriptProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SuperscriptProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SuperscriptProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SuperscriptProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "sSupPr");
            builder.AddChild<ControlProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ControlProperties ControlProperties
        {
            get => GetElement<ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SuperscriptProperties>(deep);
    }

    /// <summary>
    /// <para>Argument Size.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:argSz.</para>
    /// </summary>
    public partial class ArgumentSize : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArgumentSize class.
        /// </summary>
        public ArgumentSize() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public IntegerValue Val
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "argSz");
            builder.AddElement<ArgumentSize>()
.AddAttribute(21, "val", a => a.Val, aBuilder =>
{
 aBuilder.AddValidator(RequiredValidator.Instance);
 aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-2L), MaxInclusive = (2L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArgumentSize>(deep);
    }

    /// <summary>
    /// <para>Argument Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:argPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ArgumentSize &lt;m:argSz></description></item>
    /// </list>
    /// </remark>
    public partial class ArgumentProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ArgumentProperties class.
        /// </summary>
        public ArgumentProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArgumentProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ArgumentProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArgumentProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ArgumentProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArgumentProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ArgumentProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "argPr");
            builder.AddChild<ArgumentSize>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentSize), 0, 1)
            };
        }

        /// <summary>
        /// <para>Argument Size.</para>
        /// <para>Represents the following element tag in the schema: m:argSz.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public ArgumentSize ArgumentSize
        {
            get => GetElement<ArgumentSize>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArgumentProperties>(deep);
    }

    /// <summary>
    /// <para>Justification.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:jc.</para>
    /// </summary>
    public partial class Justification : OfficeMathJustificationType
    {
        /// <summary>
        /// Initializes a new instance of the Justification class.
        /// </summary>
        public Justification() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "jc");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Justification>(deep);
    }

    /// <summary>
    /// <para>Default Justification.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:defJc.</para>
    /// </summary>
    public partial class DefaultJustification : OfficeMathJustificationType
    {
        /// <summary>
        /// Initializes a new instance of the DefaultJustification class.
        /// </summary>
        public DefaultJustification() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "defJc");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultJustification>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeMathJustificationType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OfficeMathJustificationType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeMathJustificationType class.
        /// </summary>
        protected OfficeMathJustificationType() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Math.JustificationValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.JustificationValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OfficeMathJustificationType>()
                           .AddAttribute(21, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>Math Font.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:mathFont.</para>
    /// </summary>
    public partial class MathFont : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MathFont class.
        /// </summary>
        public MathFont() : base()
        {
        }

        /// <summary>
        /// <para>val</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "mathFont");
            builder.AddElement<MathFont>()
.AddAttribute(21, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { MaxLength = (31L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MathFont>(deep);
    }

    /// <summary>
    /// <para>Break on Binary Operators.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:brkBin.</para>
    /// </summary>
    public partial class BreakBinary : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BreakBinary class.
        /// </summary>
        public BreakBinary() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "brkBin");
            builder.AddElement<BreakBinary>()
.AddAttribute(21, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BreakBinary>(deep);
    }

    /// <summary>
    /// <para>Break on Binary Subtraction.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:brkBinSub.</para>
    /// </summary>
    public partial class BreakBinarySubtraction : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BreakBinarySubtraction class.
        /// </summary>
        public BreakBinarySubtraction() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "brkBinSub");
            builder.AddElement<BreakBinarySubtraction>()
.AddAttribute(21, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new RequiredValidator() { Version = (FileFormatVersions.Office2007) });
aBuilder.AddValidator(new RequiredValidator() { IsRequired = (false), InitialVersion = (FileFormatVersions.Office2010) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BreakBinarySubtraction>(deep);
    }

    /// <summary>
    /// <para>Office Math Paragraph Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:oMathParaPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Justification &lt;m:jc></description></item>
    /// </list>
    /// </remark>
    public partial class ParagraphProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ParagraphProperties class.
        /// </summary>
        public ParagraphProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ParagraphProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ParagraphProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ParagraphProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ParagraphProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ParagraphProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ParagraphProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(21, "oMathParaPr");
            builder.AddChild<Justification>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Justification), 0, 1)
            };
        }

        /// <summary>
        /// <para>Justification.</para>
        /// <para>Represents the following element tag in the schema: m:jc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public Justification Justification
        {
            get => GetElement<Justification>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ParagraphProperties>(deep);
    }

    /// <summary>
    /// Defines the HorizontalAlignmentValues enumeration.
    /// </summary>
    public enum HorizontalAlignmentValues
    {
        ///<summary>
        ///Left Justification.
        ///<para>When the item is serialized out as xml, its value is "left".</para>
        ///</summary>
        [EnumString("left")]
        Left,
        ///<summary>
        ///Center.
        ///<para>When the item is serialized out as xml, its value is "center".</para>
        ///</summary>
        [EnumString("center")]
        Center,
        ///<summary>
        ///Right.
        ///<para>When the item is serialized out as xml, its value is "right".</para>
        ///</summary>
        [EnumString("right")]
        Right,
    }

    /// <summary>
    /// Defines the ShapeDelimiterValues enumeration.
    /// </summary>
    public enum ShapeDelimiterValues
    {
        ///<summary>
        ///Centered (Delimiters).
        ///<para>When the item is serialized out as xml, its value is "centered".</para>
        ///</summary>
        [EnumString("centered")]
        Centered,
        ///<summary>
        ///Match.
        ///<para>When the item is serialized out as xml, its value is "match".</para>
        ///</summary>
        [EnumString("match")]
        Match,
    }

    /// <summary>
    /// Defines the FractionTypeValues enumeration.
    /// </summary>
    public enum FractionTypeValues
    {
        ///<summary>
        ///Bar Fraction.
        ///<para>When the item is serialized out as xml, its value is "bar".</para>
        ///</summary>
        [EnumString("bar")]
        Bar,
        ///<summary>
        ///Skewed.
        ///<para>When the item is serialized out as xml, its value is "skw".</para>
        ///</summary>
        [EnumString("skw")]
        Skewed,
        ///<summary>
        ///Linear Fraction.
        ///<para>When the item is serialized out as xml, its value is "lin".</para>
        ///</summary>
        [EnumString("lin")]
        Linear,
        ///<summary>
        ///No-Bar Fraction (Stack).
        ///<para>When the item is serialized out as xml, its value is "noBar".</para>
        ///</summary>
        [EnumString("noBar")]
        NoBar,
    }

    /// <summary>
    /// Defines the LimitLocationValues enumeration.
    /// </summary>
    public enum LimitLocationValues
    {
        ///<summary>
        ///Under-Over location.
        ///<para>When the item is serialized out as xml, its value is "undOvr".</para>
        ///</summary>
        [EnumString("undOvr")]
        UnderOver,
        ///<summary>
        ///Subscript-Superscript location.
        ///<para>When the item is serialized out as xml, its value is "subSup".</para>
        ///</summary>
        [EnumString("subSup")]
        SubscriptSuperscript,
    }

    /// <summary>
    /// Defines the VerticalJustificationValues enumeration.
    /// </summary>
    public enum VerticalJustificationValues
    {
        ///<summary>
        ///Top.
        ///<para>When the item is serialized out as xml, its value is "top".</para>
        ///</summary>
        [EnumString("top")]
        Top,
        ///<summary>
        ///Bottom Alignment.
        ///<para>When the item is serialized out as xml, its value is "bot".</para>
        ///</summary>
        [EnumString("bot")]
        Bottom,
    }

    /// <summary>
    /// Defines the ScriptValues enumeration.
    /// </summary>
    public enum ScriptValues
    {
        ///<summary>
        ///Roman.
        ///<para>When the item is serialized out as xml, its value is "roman".</para>
        ///</summary>
        [EnumString("roman")]
        Roman,
        ///<summary>
        ///Script.
        ///<para>When the item is serialized out as xml, its value is "script".</para>
        ///</summary>
        [EnumString("script")]
        Script,
        ///<summary>
        ///Fraktur.
        ///<para>When the item is serialized out as xml, its value is "fraktur".</para>
        ///</summary>
        [EnumString("fraktur")]
        Fraktur,
        ///<summary>
        ///double-struck.
        ///<para>When the item is serialized out as xml, its value is "double-struck".</para>
        ///</summary>
        [EnumString("double-struck")]
        DoubleStruck,
        ///<summary>
        ///Sans-Serif.
        ///<para>When the item is serialized out as xml, its value is "sans-serif".</para>
        ///</summary>
        [EnumString("sans-serif")]
        SansSerif,
        ///<summary>
        ///Monospace.
        ///<para>When the item is serialized out as xml, its value is "monospace".</para>
        ///</summary>
        [EnumString("monospace")]
        Monospace,
    }

    /// <summary>
    /// Defines the StyleValues enumeration.
    /// </summary>
    public enum StyleValues
    {
        ///<summary>
        ///Plain.
        ///<para>When the item is serialized out as xml, its value is "p".</para>
        ///</summary>
        [EnumString("p")]
        Plain,
        ///<summary>
        ///Bold.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        Bold,
        ///<summary>
        ///Italic.
        ///<para>When the item is serialized out as xml, its value is "i".</para>
        ///</summary>
        [EnumString("i")]
        Italic,
        ///<summary>
        ///Bold-Italic.
        ///<para>When the item is serialized out as xml, its value is "bi".</para>
        ///</summary>
        [EnumString("bi")]
        BoldItalic,
    }

    /// <summary>
    /// Defines the JustificationValues enumeration.
    /// </summary>
    public enum JustificationValues
    {
        ///<summary>
        ///Left Justification.
        ///<para>When the item is serialized out as xml, its value is "left".</para>
        ///</summary>
        [EnumString("left")]
        Left,
        ///<summary>
        ///Right.
        ///<para>When the item is serialized out as xml, its value is "right".</para>
        ///</summary>
        [EnumString("right")]
        Right,
        ///<summary>
        ///Center (Equation).
        ///<para>When the item is serialized out as xml, its value is "center".</para>
        ///</summary>
        [EnumString("center")]
        Center,
        ///<summary>
        ///Centered as Group (Equations).
        ///<para>When the item is serialized out as xml, its value is "centerGroup".</para>
        ///</summary>
        [EnumString("centerGroup")]
        CenterGroup,
    }

    /// <summary>
    /// Defines the BreakBinaryOperatorValues enumeration.
    /// </summary>
    public enum BreakBinaryOperatorValues
    {
        ///<summary>
        ///Before.
        ///<para>When the item is serialized out as xml, its value is "before".</para>
        ///</summary>
        [EnumString("before")]
        Before,
        ///<summary>
        ///After.
        ///<para>When the item is serialized out as xml, its value is "after".</para>
        ///</summary>
        [EnumString("after")]
        After,
        ///<summary>
        ///Repeat.
        ///<para>When the item is serialized out as xml, its value is "repeat".</para>
        ///</summary>
        [EnumString("repeat")]
        Repeat,
    }

    /// <summary>
    /// Defines the BreakBinarySubtractionValues enumeration.
    /// </summary>
    public enum BreakBinarySubtractionValues
    {
        ///<summary>
        ///Minus Minus.
        ///<para>When the item is serialized out as xml, its value is "--".</para>
        ///</summary>
        [EnumString("--")]
        MinusMinus,
        ///<summary>
        ///Minus Plus.
        ///<para>When the item is serialized out as xml, its value is "-+".</para>
        ///</summary>
        [EnumString("-+")]
        MinusPlus,
        ///<summary>
        ///Plus Minus.
        ///<para>When the item is serialized out as xml, its value is "+-".</para>
        ///</summary>
        [EnumString("+-")]
        PlusMinus,
    }

    /// <summary>
    /// Defines the VerticalAlignmentValues enumeration.
    /// </summary>
    public enum VerticalAlignmentValues
    {
        ///<summary>
        ///Top.
        ///<para>When the item is serialized out as xml, its value is "top".</para>
        ///</summary>
        [EnumString("top")]
        Top,
        ///<summary>
        ///Center (Function).
        ///<para>When the item is serialized out as xml, its value is "center".</para>
        ///</summary>
        [EnumString("center")]
        Center,
        ///<summary>
        ///bottom.
        ///<para>When the item is serialized out as xml, its value is "bottom".</para>
        ///</summary>
        [EnumString("bottom")]
        Bottom,
        ///<summary>
        ///Bottom Alignment.
        ///<para>When the item is serialized out as xml, its value is "bot".</para>
        ///</summary>
        [EnumString("bot")]
        Bot,
    }

    /// <summary>
    /// Defines the BooleanValues enumeration.
    /// </summary>
    public enum BooleanValues
    {
        ///<summary>
        ///true.
        ///<para>When the item is serialized out as xml, its value is "true".</para>
        ///</summary>
        [EnumString("true")]
        True,
        ///<summary>
        ///false.
        ///<para>When the item is serialized out as xml, its value is "false".</para>
        ///</summary>
        [EnumString("false")]
        False,
        ///<summary>
        ///On.
        ///<para>When the item is serialized out as xml, its value is "on".</para>
        ///</summary>
        [EnumString("on")]
        On,
        ///<summary>
        ///Off.
        ///<para>When the item is serialized out as xml, its value is "off".</para>
        ///</summary>
        [EnumString("off")]
        Off,
        ///<summary>
        ///0.
        ///<para>When the item is serialized out as xml, its value is "0".</para>
        ///</summary>
        [EnumString("0")]
        Zero,
        ///<summary>
        ///1.
        ///<para>When the item is serialized out as xml, its value is "1".</para>
        ///</summary>
        [EnumString("1")]
        One,
    }
}