// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2010.Drawing.Charts;
using DocumentFormat.OpenXml.Office2013.Drawing.Chart;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Drawing.Charts
{
    /// <summary>
    /// <para>Number Format.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:numFmt.</para>
    /// </summary>
    public partial class NumberingFormat : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the NumberingFormat class.
        /// </summary>
        public NumberingFormat() : base()
        {
        }

        /// <summary>
        /// <para>Number Format Code</para>
        /// <para>Represents the following attribute in the schema: formatCode</para>
        /// </summary>
        public StringValue FormatCode
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Linked to Source</para>
        /// <para>Represents the following attribute in the schema: sourceLinked</para>
        /// </summary>
        public BooleanValue SourceLinked
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "numFmt");
            builder.AddElement<NumberingFormat>()
.AddAttribute(0, "formatCode", a => a.FormatCode, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "sourceLinked", a => a.SourceLinked);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberingFormat>(deep);
    }

    /// <summary>
    /// <para>Defines the ChartShapeProperties Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:spPr.</para>
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
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ChartShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartShapeProperties class.
        /// </summary>
        public ChartShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChartShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Black and White Mode</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "spPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Transform2D>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Outline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddElement<ChartShapeProperties>()
.AddAttribute(0, "bwMode", a => a.BlackWhiteMode, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
                new CompositeParticle(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1)
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
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the TextProperties Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:txPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BodyProperties &lt;a:bodyPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ListStyle &lt;a:lstStyle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Paragraph &lt;a:p></description></item>
    /// </list>
    /// </remark>
    public partial class TextProperties : TextBodyType
    {
        /// <summary>
        /// Initializes a new instance of the TextProperties class.
        /// </summary>
        public TextProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "txPr");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ListStyle), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Paragraph), 1, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextProperties>(deep);
    }

    /// <summary>
    /// <para>Rich Text.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:rich.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BodyProperties &lt;a:bodyPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ListStyle &lt;a:lstStyle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Paragraph &lt;a:p></description></item>
    /// </list>
    /// </remark>
    public partial class RichText : TextBodyType
    {
        /// <summary>
        /// Initializes a new instance of the RichText class.
        /// </summary>
        public RichText() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichText class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichText(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichText class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichText(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichText class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichText(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "rich");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ListStyle), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Paragraph), 1, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichText>(deep);
    }

    /// <summary>
    /// <para>Defines the TextBodyType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BodyProperties &lt;a:bodyPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ListStyle &lt;a:lstStyle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Paragraph &lt;a:p></description></item>
    /// </list>
    /// </remark>
    public abstract partial class TextBodyType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBodyType class.
        /// </summary>
        protected TextBodyType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected TextBodyType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected TextBodyType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected TextBodyType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
        }

        /// <summary>
        /// <para>Body Properties.</para>
        /// <para>Represents the following element tag in the schema: a:bodyPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.BodyProperties BodyProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.BodyProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text List Styles.</para>
        /// <para>Represents the following element tag in the schema: a:lstStyle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ListStyle ListStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ListStyle>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Data Label Position.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:dLblPos.</para>
    /// </summary>
    public partial class DataLabelPosition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelPosition class.
        /// </summary>
        public DataLabelPosition() : base()
        {
        }

        /// <summary>
        /// <para>Data Label Position Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "dLblPos");
            builder.AddElement<DataLabelPosition>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelPosition>(deep);
    }

    /// <summary>
    /// <para>Show Legend Key.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:showLegendKey.</para>
    /// </summary>
    public partial class ShowLegendKey : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowLegendKey class.
        /// </summary>
        public ShowLegendKey() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "showLegendKey");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowLegendKey>(deep);
    }

    /// <summary>
    /// <para>Show Value.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:showVal.</para>
    /// </summary>
    public partial class ShowValue : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowValue class.
        /// </summary>
        public ShowValue() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "showVal");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowValue>(deep);
    }

    /// <summary>
    /// <para>Show Category Name.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:showCatName.</para>
    /// </summary>
    public partial class ShowCategoryName : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowCategoryName class.
        /// </summary>
        public ShowCategoryName() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "showCatName");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowCategoryName>(deep);
    }

    /// <summary>
    /// <para>Show Series Name.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:showSerName.</para>
    /// </summary>
    public partial class ShowSeriesName : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowSeriesName class.
        /// </summary>
        public ShowSeriesName() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "showSerName");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowSeriesName>(deep);
    }

    /// <summary>
    /// <para>Show Percent.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:showPercent.</para>
    /// </summary>
    public partial class ShowPercent : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowPercent class.
        /// </summary>
        public ShowPercent() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "showPercent");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowPercent>(deep);
    }

    /// <summary>
    /// <para>Show Bubble Size.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:showBubbleSize.</para>
    /// </summary>
    public partial class ShowBubbleSize : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowBubbleSize class.
        /// </summary>
        public ShowBubbleSize() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "showBubbleSize");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowBubbleSize>(deep);
    }

    /// <summary>
    /// <para>Show Leader Lines.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:showLeaderLines.</para>
    /// </summary>
    public partial class ShowLeaderLines : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowLeaderLines class.
        /// </summary>
        public ShowLeaderLines() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "showLeaderLines");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowLeaderLines>(deep);
    }

    /// <summary>
    /// <para>Defines the VaryColors Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:varyColors.</para>
    /// </summary>
    public partial class VaryColors : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the VaryColors class.
        /// </summary>
        public VaryColors() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "varyColors");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VaryColors>(deep);
    }

    /// <summary>
    /// <para>Wireframe.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:wireframe.</para>
    /// </summary>
    public partial class Wireframe : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the Wireframe class.
        /// </summary>
        public Wireframe() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "wireframe");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Wireframe>(deep);
    }

    /// <summary>
    /// <para>Delete.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:delete.</para>
    /// </summary>
    public partial class Delete : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the Delete class.
        /// </summary>
        public Delete() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "delete");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Delete>(deep);
    }

    /// <summary>
    /// <para>Overlay.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:overlay.</para>
    /// </summary>
    public partial class Overlay : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the Overlay class.
        /// </summary>
        public Overlay() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "overlay");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Overlay>(deep);
    }

    /// <summary>
    /// <para>Right Angle Axes.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:rAngAx.</para>
    /// </summary>
    public partial class RightAngleAxes : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the RightAngleAxes class.
        /// </summary>
        public RightAngleAxes() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "rAngAx");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RightAngleAxes>(deep);
    }

    /// <summary>
    /// <para>Show Horizontal Border.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:showHorzBorder.</para>
    /// </summary>
    public partial class ShowHorizontalBorder : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowHorizontalBorder class.
        /// </summary>
        public ShowHorizontalBorder() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "showHorzBorder");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowHorizontalBorder>(deep);
    }

    /// <summary>
    /// <para>Show Vertical Border.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:showVertBorder.</para>
    /// </summary>
    public partial class ShowVerticalBorder : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowVerticalBorder class.
        /// </summary>
        public ShowVerticalBorder() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "showVertBorder");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowVerticalBorder>(deep);
    }

    /// <summary>
    /// <para>Show Outline Border.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:showOutline.</para>
    /// </summary>
    public partial class ShowOutlineBorder : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowOutlineBorder class.
        /// </summary>
        public ShowOutlineBorder() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "showOutline");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowOutlineBorder>(deep);
    }

    /// <summary>
    /// <para>Show Legend Keys.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:showKeys.</para>
    /// </summary>
    public partial class ShowKeys : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowKeys class.
        /// </summary>
        public ShowKeys() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "showKeys");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowKeys>(deep);
    }

    /// <summary>
    /// <para>Invert if Negative.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:invertIfNegative.</para>
    /// </summary>
    public partial class InvertIfNegative : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the InvertIfNegative class.
        /// </summary>
        public InvertIfNegative() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "invertIfNegative");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InvertIfNegative>(deep);
    }

    /// <summary>
    /// <para>3D Bubble.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:bubble3D.</para>
    /// </summary>
    public partial class Bubble3D : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the Bubble3D class.
        /// </summary>
        public Bubble3D() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "bubble3D");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bubble3D>(deep);
    }

    /// <summary>
    /// <para>Display R Squared Value.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:dispRSqr.</para>
    /// </summary>
    public partial class DisplayRSquaredValue : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the DisplayRSquaredValue class.
        /// </summary>
        public DisplayRSquaredValue() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "dispRSqr");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DisplayRSquaredValue>(deep);
    }

    /// <summary>
    /// <para>Display Equation.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:dispEq.</para>
    /// </summary>
    public partial class DisplayEquation : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the DisplayEquation class.
        /// </summary>
        public DisplayEquation() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "dispEq");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DisplayEquation>(deep);
    }

    /// <summary>
    /// <para>No End Cap.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:noEndCap.</para>
    /// </summary>
    public partial class NoEndCap : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the NoEndCap class.
        /// </summary>
        public NoEndCap() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "noEndCap");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoEndCap>(deep);
    }

    /// <summary>
    /// <para>Apply To Front.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:applyToFront.</para>
    /// </summary>
    public partial class ApplyToFront : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ApplyToFront class.
        /// </summary>
        public ApplyToFront() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "applyToFront");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ApplyToFront>(deep);
    }

    /// <summary>
    /// <para>Apply To Sides.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:applyToSides.</para>
    /// </summary>
    public partial class ApplyToSides : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ApplyToSides class.
        /// </summary>
        public ApplyToSides() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "applyToSides");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ApplyToSides>(deep);
    }

    /// <summary>
    /// <para>Apply to End.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:applyToEnd.</para>
    /// </summary>
    public partial class ApplyToEnd : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ApplyToEnd class.
        /// </summary>
        public ApplyToEnd() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "applyToEnd");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ApplyToEnd>(deep);
    }

    /// <summary>
    /// <para>Auto Title Is Deleted.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:autoTitleDeleted.</para>
    /// </summary>
    public partial class AutoTitleDeleted : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the AutoTitleDeleted class.
        /// </summary>
        public AutoTitleDeleted() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "autoTitleDeleted");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoTitleDeleted>(deep);
    }

    /// <summary>
    /// <para>Plot Visible Only.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:plotVisOnly.</para>
    /// </summary>
    public partial class PlotVisibleOnly : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the PlotVisibleOnly class.
        /// </summary>
        public PlotVisibleOnly() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "plotVisOnly");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotVisibleOnly>(deep);
    }

    /// <summary>
    /// <para>Show Data Labels over Maximum.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:showDLblsOverMax.</para>
    /// </summary>
    public partial class ShowDataLabelsOverMaximum : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowDataLabelsOverMaximum class.
        /// </summary>
        public ShowDataLabelsOverMaximum() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "showDLblsOverMax");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowDataLabelsOverMaximum>(deep);
    }

    /// <summary>
    /// <para>Chart Object.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:chartObject.</para>
    /// </summary>
    public partial class ChartObject : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ChartObject class.
        /// </summary>
        public ChartObject() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "chartObject");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartObject>(deep);
    }

    /// <summary>
    /// <para>Data Cannot Be Changed.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:data.</para>
    /// </summary>
    public partial class Data : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the Data class.
        /// </summary>
        public Data() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "data");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Data>(deep);
    }

    /// <summary>
    /// <para>Formatting.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:formatting.</para>
    /// </summary>
    public partial class Formatting : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the Formatting class.
        /// </summary>
        public Formatting() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "formatting");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formatting>(deep);
    }

    /// <summary>
    /// <para>Selection.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:selection.</para>
    /// </summary>
    public partial class Selection : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the Selection class.
        /// </summary>
        public Selection() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "selection");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Selection>(deep);
    }

    /// <summary>
    /// <para>User Interface.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:userInterface.</para>
    /// </summary>
    public partial class UserInterface : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the UserInterface class.
        /// </summary>
        public UserInterface() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "userInterface");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UserInterface>(deep);
    }

    /// <summary>
    /// <para>Update Automatically.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:autoUpdate.</para>
    /// </summary>
    public partial class AutoUpdate : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the AutoUpdate class.
        /// </summary>
        public AutoUpdate() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "autoUpdate");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoUpdate>(deep);
    }

    /// <summary>
    /// <para>Defines the Smooth Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:smooth.</para>
    /// </summary>
    public partial class Smooth : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the Smooth class.
        /// </summary>
        public Smooth() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "smooth");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Smooth>(deep);
    }

    /// <summary>
    /// <para>Defines the ShowMarker Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:marker.</para>
    /// </summary>
    public partial class ShowMarker : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowMarker class.
        /// </summary>
        public ShowMarker() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "marker");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowMarker>(deep);
    }

    /// <summary>
    /// <para>Defines the ShowNegativeBubbles Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:showNegBubbles.</para>
    /// </summary>
    public partial class ShowNegativeBubbles : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the ShowNegativeBubbles class.
        /// </summary>
        public ShowNegativeBubbles() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "showNegBubbles");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowNegativeBubbles>(deep);
    }

    /// <summary>
    /// <para>Defines the AutoLabeled Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:auto.</para>
    /// </summary>
    public partial class AutoLabeled : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the AutoLabeled class.
        /// </summary>
        public AutoLabeled() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "auto");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoLabeled>(deep);
    }

    /// <summary>
    /// <para>Defines the NoMultiLevelLabels Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:noMultiLvlLbl.</para>
    /// </summary>
    public partial class NoMultiLevelLabels : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the NoMultiLevelLabels class.
        /// </summary>
        public NoMultiLevelLabels() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "noMultiLvlLbl");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoMultiLevelLabels>(deep);
    }

    /// <summary>
    /// <para>Defines the Date1904 Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:date1904.</para>
    /// </summary>
    public partial class Date1904 : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the Date1904 class.
        /// </summary>
        public Date1904() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "date1904");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Date1904>(deep);
    }

    /// <summary>
    /// <para>Defines the RoundedCorners Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:roundedCorners.</para>
    /// </summary>
    public partial class RoundedCorners : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the RoundedCorners class.
        /// </summary>
        public RoundedCorners() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "roundedCorners");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RoundedCorners>(deep);
    }

    /// <summary>
    /// <para>Defines the BooleanType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class BooleanType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BooleanType class.
        /// </summary>
        protected BooleanType() : base()
        {
        }

        /// <summary>
        /// <para>Boolean Value</para>
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
            builder.AddElement<BooleanType>()
                           .AddAttribute(0, "val", a => a.Val);
        }
    }

    /// <summary>
    /// <para>Separator.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:separator.</para>
    /// </summary>
    public partial class Separator : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Separator class.
        /// </summary>
        public Separator() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Separator class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Separator(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "separator");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Separator>(deep);
    }

    /// <summary>
    /// <para>Trendline Name.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:name.</para>
    /// </summary>
    public partial class TrendlineName : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the TrendlineName class.
        /// </summary>
        public TrendlineName() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TrendlineName class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public TrendlineName(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "name");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TrendlineName>(deep);
    }

    /// <summary>
    /// <para>Defines the Formula Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:f.</para>
    /// </summary>
    public partial class Formula : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Formula class.
        /// </summary>
        public Formula() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Formula class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Formula(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "f");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formula>(deep);
    }

    /// <summary>
    /// <para>Layout.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:layout.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ManualLayout &lt;c:manualLayout></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Layout : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Layout class.
        /// </summary>
        public Layout() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Layout class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Layout(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Layout class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Layout(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Layout class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Layout(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "layout");
            builder.AddChild<ManualLayout>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Manual Layout.</para>
        /// <para>Represents the following element tag in the schema: c:manualLayout.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ManualLayout ManualLayout
        {
            get => GetElement<ManualLayout>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Layout>(deep);
    }

    /// <summary>
    /// <para>Defines the ChartText Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:tx.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StringReference &lt;c:strRef></description></item>
    ///   <item><description>RichText &lt;c:rich></description></item>
    ///   <item><description>StringLiteral &lt;c:strLit></description></item>
    /// </list>
    /// </remark>
    public partial class ChartText : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartText class.
        /// </summary>
        public ChartText() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartText class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartText(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartText class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartText(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartText class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChartText(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "tx");
            builder.AddChild<StringReference>();
            builder.AddChild<RichText>();
            builder.AddChild<StringLiteral>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.RichText), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral), 1, 1)
                }
            };
        }

        /// <summary>
        /// <para>String Reference.</para>
        /// <para>Represents the following element tag in the schema: c:strRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public StringReference StringReference
        {
            get => GetElement<StringReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Rich Text.</para>
        /// <para>Represents the following element tag in the schema: c:rich.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public RichText RichText
        {
            get => GetElement<RichText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>String Literal.</para>
        /// <para>Represents the following element tag in the schema: c:strLit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public StringLiteral StringLiteral
        {
            get => GetElement<StringLiteral>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartText>(deep);
    }

    /// <summary>
    /// <para>Leader Lines.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:leaderLines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    /// </list>
    /// </remark>
    public partial class LeaderLines : ChartLinesType
    {
        /// <summary>
        /// Initializes a new instance of the LeaderLines class.
        /// </summary>
        public LeaderLines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LeaderLines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LeaderLines(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LeaderLines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LeaderLines(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LeaderLines class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LeaderLines(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "leaderLines");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LeaderLines>(deep);
    }

    /// <summary>
    /// <para>Drop Lines.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:dropLines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    /// </list>
    /// </remark>
    public partial class DropLines : ChartLinesType
    {
        /// <summary>
        /// Initializes a new instance of the DropLines class.
        /// </summary>
        public DropLines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropLines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DropLines(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropLines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DropLines(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropLines class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DropLines(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "dropLines");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropLines>(deep);
    }

    /// <summary>
    /// <para>Major Gridlines.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:majorGridlines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    /// </list>
    /// </remark>
    public partial class MajorGridlines : ChartLinesType
    {
        /// <summary>
        /// Initializes a new instance of the MajorGridlines class.
        /// </summary>
        public MajorGridlines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MajorGridlines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MajorGridlines(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MajorGridlines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MajorGridlines(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MajorGridlines class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MajorGridlines(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "majorGridlines");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MajorGridlines>(deep);
    }

    /// <summary>
    /// <para>Minor Gridlines.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:minorGridlines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    /// </list>
    /// </remark>
    public partial class MinorGridlines : ChartLinesType
    {
        /// <summary>
        /// Initializes a new instance of the MinorGridlines class.
        /// </summary>
        public MinorGridlines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MinorGridlines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MinorGridlines(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MinorGridlines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MinorGridlines(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MinorGridlines class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MinorGridlines(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "minorGridlines");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinorGridlines>(deep);
    }

    /// <summary>
    /// <para>Defines the SeriesLines Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:serLines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    /// </list>
    /// </remark>
    public partial class SeriesLines : ChartLinesType
    {
        /// <summary>
        /// Initializes a new instance of the SeriesLines class.
        /// </summary>
        public SeriesLines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesLines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SeriesLines(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesLines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SeriesLines(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesLines class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SeriesLines(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "serLines");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesLines>(deep);
    }

    /// <summary>
    /// <para>Defines the HighLowLines Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:hiLowLines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    /// </list>
    /// </remark>
    public partial class HighLowLines : ChartLinesType
    {
        /// <summary>
        /// Initializes a new instance of the HighLowLines class.
        /// </summary>
        public HighLowLines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HighLowLines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HighLowLines(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HighLowLines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HighLowLines(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HighLowLines class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HighLowLines(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "hiLowLines");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HighLowLines>(deep);
    }

    /// <summary>
    /// <para>Defines the ChartLinesType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    /// </list>
    /// </remark>
    public abstract partial class ChartLinesType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartLinesType class.
        /// </summary>
        protected ChartLinesType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartLinesType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected ChartLinesType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartLinesType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected ChartLinesType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartLinesType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected ChartLinesType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<ChartShapeProperties>();
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Index.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:idx.</para>
    /// </summary>
    public partial class Index : UnsignedIntegerType
    {
        /// <summary>
        /// Initializes a new instance of the Index class.
        /// </summary>
        public Index() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "idx");
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*:val*/, true, double.NegativeInfinity, true, 2147483647, true));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Index>(deep);
    }

    /// <summary>
    /// <para>Order.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:order.</para>
    /// </summary>
    public partial class Order : UnsignedIntegerType
    {
        /// <summary>
        /// Initializes a new instance of the Order class.
        /// </summary>
        public Order() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "order");
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*:val*/, true, double.NegativeInfinity, true, 2147483647, true));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Order>(deep);
    }

    /// <summary>
    /// <para>Axis ID.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:axId.</para>
    /// </summary>
    public partial class AxisId : UnsignedIntegerType
    {
        /// <summary>
        /// Initializes a new instance of the AxisId class.
        /// </summary>
        public AxisId() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "axId");
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*:val*/, true, double.NegativeInfinity, true, 2147483647, true));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisId>(deep);
    }

    /// <summary>
    /// <para>Crossing Axis ID.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:crossAx.</para>
    /// </summary>
    public partial class CrossingAxis : UnsignedIntegerType
    {
        /// <summary>
        /// Initializes a new instance of the CrossingAxis class.
        /// </summary>
        public CrossingAxis() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "crossAx");
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*:val*/, true, double.NegativeInfinity, true, 2147483647, true));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CrossingAxis>(deep);
    }

    /// <summary>
    /// <para>Point Count.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ptCount.</para>
    /// </summary>
    public partial class PointCount : UnsignedIntegerType
    {
        /// <summary>
        /// Initializes a new instance of the PointCount class.
        /// </summary>
        public PointCount() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ptCount");
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*:val*/, true, double.NegativeInfinity, true, 2147483647, true));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PointCount>(deep);
    }

    /// <summary>
    /// <para>Second Pie Point.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:secondPiePt.</para>
    /// </summary>
    public partial class SecondPiePoint : UnsignedIntegerType
    {
        /// <summary>
        /// Initializes a new instance of the SecondPiePoint class.
        /// </summary>
        public SecondPiePoint() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "secondPiePt");
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*:val*/, true, double.NegativeInfinity, true, 2147483647, true));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SecondPiePoint>(deep);
    }

    /// <summary>
    /// <para>Explosion.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:explosion.</para>
    /// </summary>
    public partial class Explosion : UnsignedIntegerType
    {
        /// <summary>
        /// Initializes a new instance of the Explosion class.
        /// </summary>
        public Explosion() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "explosion");
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*:val*/, true, double.NegativeInfinity, true, 2147483647, true));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Explosion>(deep);
    }

    /// <summary>
    /// <para>Format ID.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:fmtId.</para>
    /// </summary>
    public partial class FormatId : UnsignedIntegerType
    {
        /// <summary>
        /// Initializes a new instance of the FormatId class.
        /// </summary>
        public FormatId() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "fmtId");
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*:val*/, true, double.NegativeInfinity, true, 2147483647, true));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormatId>(deep);
    }

    /// <summary>
    /// <para>Defines the UnsignedIntegerType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class UnsignedIntegerType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsignedIntegerType class.
        /// </summary>
        protected UnsignedIntegerType() : base()
        {
        }

        /// <summary>
        /// <para>Integer Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public UInt32Value Val
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<UnsignedIntegerType>()
                           .AddAttribute(0, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>Series Text.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:tx.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StringReference &lt;c:strRef></description></item>
    ///   <item><description>NumericValue &lt;c:v></description></item>
    /// </list>
    /// </remark>
    public partial class SeriesText : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SeriesText class.
        /// </summary>
        public SeriesText() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesText class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SeriesText(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesText class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SeriesText(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesText class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SeriesText(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "tx");
            builder.AddChild<StringReference>();
            builder.AddChild<NumericValue>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumericValue), 1, 1)
                }
            };
        }

        /// <summary>
        /// <para>StringReference.</para>
        /// <para>Represents the following element tag in the schema: c:strRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public StringReference StringReference
        {
            get => GetElement<StringReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NumericValue.</para>
        /// <para>Represents the following element tag in the schema: c:v.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public NumericValue NumericValue
        {
            get => GetElement<NumericValue>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesText>(deep);
    }

    /// <summary>
    /// <para>Grouping.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:grouping.</para>
    /// </summary>
    public partial class Grouping : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Grouping class.
        /// </summary>
        public Grouping() : base()
        {
        }

        /// <summary>
        /// <para>Grouping Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "grouping");
            builder.AddElement<Grouping>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Grouping>(deep);
    }

    /// <summary>
    /// <para>Defines the LineChartSeries Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Index &lt;c:idx></description></item>
    ///   <item><description>Order &lt;c:order></description></item>
    ///   <item><description>SeriesText &lt;c:tx></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>Marker &lt;c:marker></description></item>
    ///   <item><description>PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>DataPoint &lt;c:dPt></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>Trendline &lt;c:trendline></description></item>
    ///   <item><description>ErrorBars &lt;c:errBars></description></item>
    ///   <item><description>CategoryAxisData &lt;c:cat></description></item>
    ///   <item><description>Values &lt;c:val></description></item>
    ///   <item><description>Smooth &lt;c:smooth></description></item>
    ///   <item><description>LineSerExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class LineChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LineChartSeries class.
        /// </summary>
        public LineChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LineChartSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ser");
            builder.AddChild<Index>();
            builder.AddChild<Order>();
            builder.AddChild<SeriesText>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<Marker>();
            builder.AddChild<PictureOptions>();
            builder.AddChild<DataPoint>();
            builder.AddChild<DataLabels>();
            builder.AddChild<Trendline>();
            builder.AddChild<ErrorBars>();
            builder.AddChild<CategoryAxisData>();
            builder.AddChild<Values>();
            builder.AddChild<Smooth>();
            builder.AddChild<LineSerExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Smooth), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Index Index
        {
            get => GetElement<Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Order Order
        {
            get => GetElement<Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public SeriesText SeriesText
        {
            get => GetElement<SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Marker.</para>
        /// <para>Represents the following element tag in the schema: c:marker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Marker Marker
        {
            get => GetElement<Marker>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PictureOptions PictureOptions
        {
            get => GetElement<PictureOptions>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineChartSeries>(deep);
    }

    /// <summary>
    /// <para>Data Labels.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:dLbls.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DataLabel &lt;c:dLbl></description></item>
    ///   <item><description>Delete &lt;c:delete></description></item>
    ///   <item><description>NumberingFormat &lt;c:numFmt></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>TextProperties &lt;c:txPr></description></item>
    ///   <item><description>DataLabelPosition &lt;c:dLblPos></description></item>
    ///   <item><description>ShowLegendKey &lt;c:showLegendKey></description></item>
    ///   <item><description>ShowValue &lt;c:showVal></description></item>
    ///   <item><description>ShowCategoryName &lt;c:showCatName></description></item>
    ///   <item><description>ShowSeriesName &lt;c:showSerName></description></item>
    ///   <item><description>ShowPercent &lt;c:showPercent></description></item>
    ///   <item><description>ShowBubbleSize &lt;c:showBubbleSize></description></item>
    ///   <item><description>Separator &lt;c:separator></description></item>
    ///   <item><description>ShowLeaderLines &lt;c:showLeaderLines></description></item>
    ///   <item><description>LeaderLines &lt;c:leaderLines></description></item>
    ///   <item><description>DLblsExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class DataLabels : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabels class.
        /// </summary>
        public DataLabels() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabels class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabels(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabels class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabels(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabels class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabels(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "dLbls");
            builder.AddChild<DataLabel>();
            builder.AddChild<Delete>();
            builder.AddChild<NumberingFormat>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<TextProperties>();
            builder.AddChild<DataLabelPosition>();
            builder.AddChild<ShowLegendKey>();
            builder.AddChild<ShowValue>();
            builder.AddChild<ShowCategoryName>();
            builder.AddChild<ShowSeriesName>();
            builder.AddChild<ShowPercent>();
            builder.AddChild<ShowBubbleSize>();
            builder.AddChild<Separator>();
            builder.AddChild<ShowLeaderLines>();
            builder.AddChild<LeaderLines>();
            builder.AddChild<DLblsExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabel), 0, 0),
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Delete), 1, 1),
                    new CompositeParticle(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Sequence, 1, 1)
                        {
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
                            },
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowLeaderLines), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LeaderLines), 0, 1)
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabels>(deep);
    }

    /// <summary>
    /// <para>Bar Direction.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:barDir.</para>
    /// </summary>
    public partial class BarDirection : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BarDirection class.
        /// </summary>
        public BarDirection() : base()
        {
        }

        /// <summary>
        /// <para>Bar Direction Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "barDir");
            builder.AddElement<BarDirection>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarDirection>(deep);
    }

    /// <summary>
    /// <para>Bar Grouping.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:grouping.</para>
    /// </summary>
    public partial class BarGrouping : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BarGrouping class.
        /// </summary>
        public BarGrouping() : base()
        {
        }

        /// <summary>
        /// <para>Bar Grouping Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "grouping");
            builder.AddElement<BarGrouping>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarGrouping>(deep);
    }

    /// <summary>
    /// <para>Bar Chart Series.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Index &lt;c:idx></description></item>
    ///   <item><description>Order &lt;c:order></description></item>
    ///   <item><description>SeriesText &lt;c:tx></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>InvertIfNegative &lt;c:invertIfNegative></description></item>
    ///   <item><description>PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>DataPoint &lt;c:dPt></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>Trendline &lt;c:trendline></description></item>
    ///   <item><description>ErrorBars &lt;c:errBars></description></item>
    ///   <item><description>CategoryAxisData &lt;c:cat></description></item>
    ///   <item><description>Values &lt;c:val></description></item>
    ///   <item><description>Shape &lt;c:shape></description></item>
    ///   <item><description>BarSerExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class BarChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BarChartSeries class.
        /// </summary>
        public BarChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BarChartSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ser");
            builder.AddChild<Index>();
            builder.AddChild<Order>();
            builder.AddChild<SeriesText>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<InvertIfNegative>();
            builder.AddChild<PictureOptions>();
            builder.AddChild<DataPoint>();
            builder.AddChild<DataLabels>();
            builder.AddChild<Trendline>();
            builder.AddChild<ErrorBars>();
            builder.AddChild<CategoryAxisData>();
            builder.AddChild<Values>();
            builder.AddChild<Shape>();
            builder.AddChild<BarSerExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Shape), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarSerExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Index Index
        {
            get => GetElement<Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Order Order
        {
            get => GetElement<Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public SeriesText SeriesText
        {
            get => GetElement<SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>InvertIfNegative.</para>
        /// <para>Represents the following element tag in the schema: c:invertIfNegative.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public InvertIfNegative InvertIfNegative
        {
            get => GetElement<InvertIfNegative>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PictureOptions PictureOptions
        {
            get => GetElement<PictureOptions>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarChartSeries>(deep);
    }

    /// <summary>
    /// <para>Area Chart Series.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Index &lt;c:idx></description></item>
    ///   <item><description>Order &lt;c:order></description></item>
    ///   <item><description>SeriesText &lt;c:tx></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>DataPoint &lt;c:dPt></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>Trendline &lt;c:trendline></description></item>
    ///   <item><description>ErrorBars &lt;c:errBars></description></item>
    ///   <item><description>CategoryAxisData &lt;c:cat></description></item>
    ///   <item><description>Values &lt;c:val></description></item>
    ///   <item><description>AreaSerExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class AreaChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AreaChartSeries class.
        /// </summary>
        public AreaChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AreaChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AreaChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AreaChartSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ser");
            builder.AddChild<Index>();
            builder.AddChild<Order>();
            builder.AddChild<SeriesText>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<PictureOptions>();
            builder.AddChild<DataPoint>();
            builder.AddChild<DataLabels>();
            builder.AddChild<Trendline>();
            builder.AddChild<ErrorBars>();
            builder.AddChild<CategoryAxisData>();
            builder.AddChild<Values>();
            builder.AddChild<AreaSerExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars), 0, 2),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Index Index
        {
            get => GetElement<Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Order Order
        {
            get => GetElement<Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public SeriesText SeriesText
        {
            get => GetElement<SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PictureOptions PictureOptions
        {
            get => GetElement<PictureOptions>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AreaChartSeries>(deep);
    }

    /// <summary>
    /// <para>Pie Chart Series.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Index &lt;c:idx></description></item>
    ///   <item><description>Order &lt;c:order></description></item>
    ///   <item><description>SeriesText &lt;c:tx></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>Explosion &lt;c:explosion></description></item>
    ///   <item><description>DataPoint &lt;c:dPt></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>CategoryAxisData &lt;c:cat></description></item>
    ///   <item><description>Values &lt;c:val></description></item>
    ///   <item><description>PieSerExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class PieChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PieChartSeries class.
        /// </summary>
        public PieChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PieChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PieChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PieChartSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ser");
            builder.AddChild<Index>();
            builder.AddChild<Order>();
            builder.AddChild<SeriesText>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<PictureOptions>();
            builder.AddChild<Explosion>();
            builder.AddChild<DataPoint>();
            builder.AddChild<DataLabels>();
            builder.AddChild<CategoryAxisData>();
            builder.AddChild<Values>();
            builder.AddChild<PieSerExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Explosion), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Index Index
        {
            get => GetElement<Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Order Order
        {
            get => GetElement<Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public SeriesText SeriesText
        {
            get => GetElement<SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PictureOptions PictureOptions
        {
            get => GetElement<PictureOptions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Explosion.</para>
        /// <para>Represents the following element tag in the schema: c:explosion.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Explosion Explosion
        {
            get => GetElement<Explosion>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PieChartSeries>(deep);
    }

    /// <summary>
    /// <para>Surface Chart Series.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Index &lt;c:idx></description></item>
    ///   <item><description>Order &lt;c:order></description></item>
    ///   <item><description>SeriesText &lt;c:tx></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>CategoryAxisData &lt;c:cat></description></item>
    ///   <item><description>Values &lt;c:val></description></item>
    ///   <item><description>Bubble3D &lt;c:bubble3D></description></item>
    ///   <item><description>SurfaceSerExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class SurfaceChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SurfaceChartSeries class.
        /// </summary>
        public SurfaceChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurfaceChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurfaceChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SurfaceChartSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ser");
            builder.AddChild<Index>();
            builder.AddChild<Order>();
            builder.AddChild<SeriesText>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<PictureOptions>();
            builder.AddChild<CategoryAxisData>();
            builder.AddChild<Values>();
            builder.AddChild<Bubble3D>();
            builder.AddChild<SurfaceSerExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bubble3D), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Index Index
        {
            get => GetElement<Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Order Order
        {
            get => GetElement<Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public SeriesText SeriesText
        {
            get => GetElement<SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PictureOptions PictureOptions
        {
            get => GetElement<PictureOptions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CategoryAxisData.</para>
        /// <para>Represents the following element tag in the schema: c:cat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public CategoryAxisData CategoryAxisData
        {
            get => GetElement<CategoryAxisData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Values.</para>
        /// <para>Represents the following element tag in the schema: c:val.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Values Values
        {
            get => GetElement<Values>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Bubble3D.</para>
        /// <para>Represents the following element tag in the schema: c:bubble3D.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Bubble3D Bubble3D
        {
            get => GetElement<Bubble3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SurfaceSerExtensionList.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public SurfaceSerExtensionList SurfaceSerExtensionList
        {
            get => GetElement<SurfaceSerExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurfaceChartSeries>(deep);
    }

    /// <summary>
    /// <para>Band Formats.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:bandFmts.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BandFormat &lt;c:bandFmt></description></item>
    /// </list>
    /// </remark>
    public partial class BandFormats : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BandFormats class.
        /// </summary>
        public BandFormats() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BandFormats class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BandFormats(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BandFormats class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BandFormats(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BandFormats class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BandFormats(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "bandFmts");
            builder.AddChild<BandFormat>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BandFormat), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BandFormats>(deep);
    }

    /// <summary>
    /// <para>Scaling.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:scaling.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LogBase &lt;c:logBase></description></item>
    ///   <item><description>Orientation &lt;c:orientation></description></item>
    ///   <item><description>MaxAxisValue &lt;c:max></description></item>
    ///   <item><description>MinAxisValue &lt;c:min></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Scaling : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Scaling class.
        /// </summary>
        public Scaling() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scaling class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Scaling(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scaling class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Scaling(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scaling class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Scaling(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "scaling");
            builder.AddChild<LogBase>();
            builder.AddChild<Orientation>();
            builder.AddChild<MaxAxisValue>();
            builder.AddChild<MinAxisValue>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LogBase), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Orientation), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MaxAxisValue), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MinAxisValue), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Logarithmic Base.</para>
        /// <para>Represents the following element tag in the schema: c:logBase.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public LogBase LogBase
        {
            get => GetElement<LogBase>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Axis Orientation.</para>
        /// <para>Represents the following element tag in the schema: c:orientation.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Orientation Orientation
        {
            get => GetElement<Orientation>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Maximum.</para>
        /// <para>Represents the following element tag in the schema: c:max.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MaxAxisValue MaxAxisValue
        {
            get => GetElement<MaxAxisValue>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Minimum.</para>
        /// <para>Represents the following element tag in the schema: c:min.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MinAxisValue MinAxisValue
        {
            get => GetElement<MinAxisValue>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Scaling>(deep);
    }

    /// <summary>
    /// <para>Axis Position.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:axPos.</para>
    /// </summary>
    public partial class AxisPosition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the AxisPosition class.
        /// </summary>
        public AxisPosition() : base()
        {
        }

        /// <summary>
        /// <para>Axis Position Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "axPos");
            builder.AddElement<AxisPosition>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
 aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisPosition>(deep);
    }

    /// <summary>
    /// <para>Title.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:title.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartText &lt;c:tx></description></item>
    ///   <item><description>Layout &lt;c:layout></description></item>
    ///   <item><description>Overlay &lt;c:overlay></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>TextProperties &lt;c:txPr></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Title : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Title class.
        /// </summary>
        public Title() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Title class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Title(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Title class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Title(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Title class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Title(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "title");
            builder.AddChild<ChartText>();
            builder.AddChild<Layout>();
            builder.AddChild<Overlay>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<TextProperties>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartText), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Layout), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Overlay), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Chart Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartText ChartText
        {
            get => GetElement<ChartText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Layout.</para>
        /// <para>Represents the following element tag in the schema: c:layout.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Layout Layout
        {
            get => GetElement<Layout>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Overlay.</para>
        /// <para>Represents the following element tag in the schema: c:overlay.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Overlay Overlay
        {
            get => GetElement<Overlay>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TextProperties.</para>
        /// <para>Represents the following element tag in the schema: c:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public TextProperties TextProperties
        {
            get => GetElement<TextProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Title>(deep);
    }

    /// <summary>
    /// <para>Major Tick Mark.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:majorTickMark.</para>
    /// </summary>
    public partial class MajorTickMark : TickMarkType
    {
        /// <summary>
        /// Initializes a new instance of the MajorTickMark class.
        /// </summary>
        public MajorTickMark() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "majorTickMark");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MajorTickMark>(deep);
    }

    /// <summary>
    /// <para>Minor Tick Mark.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:minorTickMark.</para>
    /// </summary>
    public partial class MinorTickMark : TickMarkType
    {
        /// <summary>
        /// Initializes a new instance of the MinorTickMark class.
        /// </summary>
        public MinorTickMark() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "minorTickMark");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinorTickMark>(deep);
    }

    /// <summary>
    /// <para>Defines the TickMarkType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class TickMarkType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TickMarkType class.
        /// </summary>
        protected TickMarkType() : base()
        {
        }

        /// <summary>
        /// <para>Tick Mark Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<TickMarkType>()
                           .AddAttribute(0, "val", a => a.Val);
        }
    }

    /// <summary>
    /// <para>Tick Label Position.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:tickLblPos.</para>
    /// </summary>
    public partial class TickLabelPosition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TickLabelPosition class.
        /// </summary>
        public TickLabelPosition() : base()
        {
        }

        /// <summary>
        /// <para>Tick Label Position Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "tickLblPos");
            builder.AddElement<TickLabelPosition>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TickLabelPosition>(deep);
    }

    /// <summary>
    /// <para>Crosses.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:crosses.</para>
    /// </summary>
    public partial class Crosses : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Crosses class.
        /// </summary>
        public Crosses() : base()
        {
        }

        /// <summary>
        /// <para>Crosses Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "crosses");
            builder.AddElement<Crosses>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Crosses>(deep);
    }

    /// <summary>
    /// <para>Crossing Value.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:crossesAt.</para>
    /// </summary>
    public partial class CrossesAt : DoubleType
    {
        /// <summary>
        /// Initializes a new instance of the CrossesAt class.
        /// </summary>
        public CrossesAt() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "crossesAt");
            builder.AddConstraint(new AttributeValueSetConstraint(0 /*:val*/, false, new string[] { "INF", "-INF", "NaN" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CrossesAt>(deep);
    }

    /// <summary>
    /// <para>Left.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:x.</para>
    /// </summary>
    public partial class Left : DoubleType
    {
        /// <summary>
        /// Initializes a new instance of the Left class.
        /// </summary>
        public Left() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "x");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Left>(deep);
    }

    /// <summary>
    /// <para>Top.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:y.</para>
    /// </summary>
    public partial class Top : DoubleType
    {
        /// <summary>
        /// Initializes a new instance of the Top class.
        /// </summary>
        public Top() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "y");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Top>(deep);
    }

    /// <summary>
    /// <para>Width.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:w.</para>
    /// </summary>
    public partial class Width : DoubleType
    {
        /// <summary>
        /// Initializes a new instance of the Width class.
        /// </summary>
        public Width() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "w");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Width>(deep);
    }

    /// <summary>
    /// <para>Height.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:h.</para>
    /// </summary>
    public partial class Height : DoubleType
    {
        /// <summary>
        /// Initializes a new instance of the Height class.
        /// </summary>
        public Height() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "h");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Height>(deep);
    }

    /// <summary>
    /// <para>Forward.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:forward.</para>
    /// </summary>
    public partial class Forward : DoubleType
    {
        /// <summary>
        /// Initializes a new instance of the Forward class.
        /// </summary>
        public Forward() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "forward");
            builder.AddConstraint(new AttributeValueSetConstraint(0 /*:val*/, false, new string[] { "INF", "-INF", "NaN" }));
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*:val*/, true, 0, true, double.PositiveInfinity, true));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Forward>(deep);
    }

    /// <summary>
    /// <para>Backward.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:backward.</para>
    /// </summary>
    public partial class Backward : DoubleType
    {
        /// <summary>
        /// Initializes a new instance of the Backward class.
        /// </summary>
        public Backward() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "backward");
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*:val*/, true, 0, true, double.PositiveInfinity, true));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Backward>(deep);
    }

    /// <summary>
    /// <para>Intercept.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:intercept.</para>
    /// </summary>
    public partial class Intercept : DoubleType
    {
        /// <summary>
        /// Initializes a new instance of the Intercept class.
        /// </summary>
        public Intercept() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "intercept");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Intercept>(deep);
    }

    /// <summary>
    /// <para>Error Bar Value.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:val.</para>
    /// </summary>
    public partial class ErrorBarValue : DoubleType
    {
        /// <summary>
        /// Initializes a new instance of the ErrorBarValue class.
        /// </summary>
        public ErrorBarValue() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "val");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ErrorBarValue>(deep);
    }

    /// <summary>
    /// <para>Split Position.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:splitPos.</para>
    /// </summary>
    public partial class SplitPosition : DoubleType
    {
        /// <summary>
        /// Initializes a new instance of the SplitPosition class.
        /// </summary>
        public SplitPosition() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "splitPos");
            builder.AddConstraint(new AttributeValueSetConstraint(0 /*:val*/, false, new string[] { "INF", "-INF", "NaN" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitPosition>(deep);
    }

    /// <summary>
    /// <para>Custom Display Unit.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:custUnit.</para>
    /// </summary>
    public partial class CustomDisplayUnit : DoubleType
    {
        /// <summary>
        /// Initializes a new instance of the CustomDisplayUnit class.
        /// </summary>
        public CustomDisplayUnit() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "custUnit");
            builder.AddConstraint(new AttributeValueSetConstraint(0 /*:val*/, false, new string[] { "INF", "-INF", "NaN" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomDisplayUnit>(deep);
    }

    /// <summary>
    /// <para>Maximum.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:max.</para>
    /// </summary>
    public partial class MaxAxisValue : DoubleType
    {
        /// <summary>
        /// Initializes a new instance of the MaxAxisValue class.
        /// </summary>
        public MaxAxisValue() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "max");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MaxAxisValue>(deep);
    }

    /// <summary>
    /// <para>Minimum.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:min.</para>
    /// </summary>
    public partial class MinAxisValue : DoubleType
    {
        /// <summary>
        /// Initializes a new instance of the MinAxisValue class.
        /// </summary>
        public MinAxisValue() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "min");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinAxisValue>(deep);
    }

    /// <summary>
    /// <para>Defines the DoubleType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class DoubleType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DoubleType class.
        /// </summary>
        protected DoubleType() : base()
        {
        }

        /// <summary>
        /// <para>Floating Point Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public DoubleValue Val
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<DoubleType>()
                           .AddAttribute(0, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>Chart Space.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:chartSpace.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Date1904 &lt;c:date1904></description></item>
    ///   <item><description>EditingLanguage &lt;c:lang></description></item>
    ///   <item><description>RoundedCorners &lt;c:roundedCorners></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Drawing.Charts.Style &lt;c14:style></description></item>
    ///   <item><description>Style &lt;c:style></description></item>
    ///   <item><description>ColorMapOverride &lt;c:clrMapOvr></description></item>
    ///   <item><description>PivotSource &lt;c:pivotSource></description></item>
    ///   <item><description>Protection &lt;c:protection></description></item>
    ///   <item><description>Chart &lt;c:chart></description></item>
    ///   <item><description>ShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>TextProperties &lt;c:txPr></description></item>
    ///   <item><description>ExternalData &lt;c:externalData></description></item>
    ///   <item><description>PrintSettings &lt;c:printSettings></description></item>
    ///   <item><description>UserShapesReference &lt;c:userShapes></description></item>
    ///   <item><description>ChartSpaceExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ChartSpace : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartSpace class.
        /// </summary>
        public ChartSpace() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartSpace class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartSpace(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartSpace class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartSpace(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartSpace class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChartSpace(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "chartSpace");
            builder.AddChild<Date1904>();
            builder.AddChild<EditingLanguage>();
            builder.AddChild<RoundedCorners>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.Style>();
            builder.AddChild<Style>();
            builder.AddChild<ColorMapOverride>();
            builder.AddChild<PivotSource>();
            builder.AddChild<Protection>();
            builder.AddChild<Chart>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<TextProperties>();
            builder.AddChild<ExternalData>();
            builder.AddChild<PrintSettings>();
            builder.AddChild<UserShapesReference>();
            builder.AddChild<ChartSpaceExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Date1904), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.EditingLanguage), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.RoundedCorners), 0, 1),
                new CompositeParticle(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.Style), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Style), 1, 1)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ColorMapOverride), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PivotSource), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Protection), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Chart), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExternalData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PrintSettings), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.UserShapesReference), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Date1904.</para>
        /// <para>Represents the following element tag in the schema: c:date1904.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Date1904 Date1904
        {
            get => GetElement<Date1904>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EditingLanguage.</para>
        /// <para>Represents the following element tag in the schema: c:lang.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public EditingLanguage EditingLanguage
        {
            get => GetElement<EditingLanguage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RoundedCorners.</para>
        /// <para>Represents the following element tag in the schema: c:roundedCorners.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public RoundedCorners RoundedCorners
        {
            get => GetElement<RoundedCorners>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartSpace>(deep);

        internal ChartSpace(ChartPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the ChartPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(ChartPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the ChartPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(ChartPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the ChartPart associated with this element.
        /// </summary>
        public ChartPart ChartPart
        {
            get => OpenXmlPart as ChartPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>User Shapes.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:userShapes.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize &lt;cdr:relSizeAnchor></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize &lt;cdr:absSizeAnchor></description></item>
    /// </list>
    /// </remark>
    public partial class UserShapes : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the UserShapes class.
        /// </summary>
        public UserShapes() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UserShapes class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UserShapes(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UserShapes class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UserShapes(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UserShapes class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public UserShapes(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "userShapes");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UserShapes>(deep);

        internal UserShapes(ChartDrawingPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the ChartDrawingPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(ChartDrawingPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the ChartDrawingPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(ChartDrawingPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the ChartDrawingPart associated with this element.
        /// </summary>
        public ChartDrawingPart ChartDrawingPart
        {
            get => OpenXmlPart as ChartDrawingPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Reference to Chart Part.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:chart.</para>
    /// </summary>
    public partial class ChartReference : RelationshipIdType
    {
        /// <summary>
        /// Initializes a new instance of the ChartReference class.
        /// </summary>
        public ChartReference() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "chart");
            builder.AddConstraint(new RelationshipExistConstraint(0 /*r:id*/));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartReference>(deep);
    }

    /// <summary>
    /// <para>Legacy Drawing for Headers and Footers.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:legacyDrawingHF.</para>
    /// </summary>
    public partial class LegacyDrawingHeaderFooter : RelationshipIdType
    {
        /// <summary>
        /// Initializes a new instance of the LegacyDrawingHeaderFooter class.
        /// </summary>
        public LegacyDrawingHeaderFooter() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "legacyDrawingHF");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LegacyDrawingHeaderFooter>(deep);
    }

    /// <summary>
    /// <para>Defines the UserShapesReference Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:userShapes.</para>
    /// </summary>
    public partial class UserShapesReference : RelationshipIdType
    {
        /// <summary>
        /// Initializes a new instance of the UserShapesReference class.
        /// </summary>
        public UserShapesReference() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "userShapes");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UserShapesReference>(deep);
    }

    /// <summary>
    /// <para>Defines the RelationshipIdType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class RelationshipIdType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RelationshipIdType class.
        /// </summary>
        protected RelationshipIdType() : base()
        {
        }

        /// <summary>
        /// <para>Relationship Reference</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<RelationshipIdType>()
                           .AddAttribute(19, "id", a => a.Id, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>Extension.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    public partial class Extension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Extension class.
        /// </summary>
        public Extension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Extension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Extension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Extension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Extension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Extension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Extension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Uniform Resource Identifier</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddElement<Extension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
   aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Extension>(deep);
    }

    /// <summary>
    /// <para>Numeric Value.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:v.</para>
    /// </summary>
    public partial class NumericValue : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the NumericValue class.
        /// </summary>
        public NumericValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumericValue class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public NumericValue(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "v");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumericValue>(deep);
    }

    /// <summary>
    /// <para>Format Code.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:formatCode.</para>
    /// </summary>
    public partial class FormatCode : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FormatCode class.
        /// </summary>
        public FormatCode() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormatCode class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FormatCode(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "formatCode");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormatCode>(deep);
    }

    /// <summary>
    /// <para>Odd Header.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:oddHeader.</para>
    /// </summary>
    public partial class OddHeader : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the OddHeader class.
        /// </summary>
        public OddHeader() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OddHeader class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public OddHeader(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "oddHeader");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OddHeader>(deep);
    }

    /// <summary>
    /// <para>Odd Footer.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:oddFooter.</para>
    /// </summary>
    public partial class OddFooter : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the OddFooter class.
        /// </summary>
        public OddFooter() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OddFooter class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public OddFooter(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "oddFooter");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OddFooter>(deep);
    }

    /// <summary>
    /// <para>Even Header.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:evenHeader.</para>
    /// </summary>
    public partial class EvenHeader : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EvenHeader class.
        /// </summary>
        public EvenHeader() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EvenHeader class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EvenHeader(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "evenHeader");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EvenHeader>(deep);
    }

    /// <summary>
    /// <para>Even Footer.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:evenFooter.</para>
    /// </summary>
    public partial class EvenFooter : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EvenFooter class.
        /// </summary>
        public EvenFooter() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EvenFooter class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EvenFooter(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "evenFooter");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EvenFooter>(deep);
    }

    /// <summary>
    /// <para>First Header.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:firstHeader.</para>
    /// </summary>
    public partial class FirstHeader : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FirstHeader class.
        /// </summary>
        public FirstHeader() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FirstHeader class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FirstHeader(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "firstHeader");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstHeader>(deep);
    }

    /// <summary>
    /// <para>First Footer.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:firstFooter.</para>
    /// </summary>
    public partial class FirstFooter : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FirstFooter class.
        /// </summary>
        public FirstFooter() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FirstFooter class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FirstFooter(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "firstFooter");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstFooter>(deep);
    }

    /// <summary>
    /// <para>Pivot Name.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:name.</para>
    /// </summary>
    public partial class PivotTableName : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotTableName class.
        /// </summary>
        public PivotTableName() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableName class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public PivotTableName(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "name");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableName>(deep);
    }

    /// <summary>
    /// <para>Numeric Point.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:pt.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NumericValue &lt;c:v></description></item>
    /// </list>
    /// </remark>
    public partial class NumericPoint : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NumericPoint class.
        /// </summary>
        public NumericPoint() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumericPoint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumericPoint(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumericPoint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumericPoint(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumericPoint class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NumericPoint(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Index</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        public UInt32Value Index
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Number Format</para>
        /// <para>Represents the following attribute in the schema: formatCode</para>
        /// </summary>
        public StringValue FormatCode
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "pt");
            builder.AddChild<NumericValue>();
            builder.AddElement<NumericPoint>()
.AddAttribute(0, "idx", a => a.Index, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "formatCode", a => a.FormatCode);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumericValue), 1, 1)
            };
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*:idx*/, true, double.NegativeInfinity, true, 2147483647, true));
        }

        /// <summary>
        /// <para>Numeric Value.</para>
        /// <para>Represents the following element tag in the schema: c:v.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public NumericValue NumericValue
        {
            get => GetElement<NumericValue>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumericPoint>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Extension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class ExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ExtensionList class.
        /// </summary>
        public ExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<Extension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Extension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }

    /// <summary>
    /// <para>Number Reference.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:numRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Formula &lt;c:f></description></item>
    ///   <item><description>NumberingCache &lt;c:numCache></description></item>
    ///   <item><description>NumRefExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class NumberReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NumberReference class.
        /// </summary>
        public NumberReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumberReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumberReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NumberReference(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "numRef");
            builder.AddChild<Formula>();
            builder.AddChild<NumberingCache>();
            builder.AddChild<NumRefExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Formula), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberingCache), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Formula.</para>
        /// <para>Represents the following element tag in the schema: c:f.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Formula Formula
        {
            get => GetElement<Formula>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NumberingCache.</para>
        /// <para>Represents the following element tag in the schema: c:numCache.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public NumberingCache NumberingCache
        {
            get => GetElement<NumberingCache>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NumRefExtensionList.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public NumRefExtensionList NumRefExtensionList
        {
            get => GetElement<NumRefExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberReference>(deep);
    }

    /// <summary>
    /// <para>Number Literal.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:numLit.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>FormatCode &lt;c:formatCode></description></item>
    ///   <item><description>PointCount &lt;c:ptCount></description></item>
    ///   <item><description>NumericPoint &lt;c:pt></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class NumberLiteral : NumberDataType
    {
        /// <summary>
        /// Initializes a new instance of the NumberLiteral class.
        /// </summary>
        public NumberLiteral() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberLiteral class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumberLiteral(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberLiteral class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumberLiteral(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberLiteral class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NumberLiteral(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "numLit");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.FormatCode), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumericPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberLiteral>(deep);
    }

    /// <summary>
    /// <para>Defines the NumberingCache Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:numCache.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>FormatCode &lt;c:formatCode></description></item>
    ///   <item><description>PointCount &lt;c:ptCount></description></item>
    ///   <item><description>NumericPoint &lt;c:pt></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class NumberingCache : NumberDataType
    {
        /// <summary>
        /// Initializes a new instance of the NumberingCache class.
        /// </summary>
        public NumberingCache() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberingCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumberingCache(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberingCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumberingCache(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberingCache class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NumberingCache(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "numCache");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.FormatCode), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumericPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberingCache>(deep);
    }

    /// <summary>
    /// <para>Defines the NumberDataType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>FormatCode &lt;c:formatCode></description></item>
    ///   <item><description>PointCount &lt;c:ptCount></description></item>
    ///   <item><description>NumericPoint &lt;c:pt></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public abstract partial class NumberDataType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NumberDataType class.
        /// </summary>
        protected NumberDataType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberDataType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected NumberDataType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberDataType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected NumberDataType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberDataType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected NumberDataType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<FormatCode>();
            builder.AddChild<PointCount>();
            builder.AddChild<NumericPoint>();
            builder.AddChild<ExtensionList>();
        }

        /// <summary>
        /// <para>Format Code.</para>
        /// <para>Represents the following element tag in the schema: c:formatCode.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public FormatCode FormatCode
        {
            get => GetElement<FormatCode>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Point Count.</para>
        /// <para>Represents the following element tag in the schema: c:ptCount.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PointCount PointCount
        {
            get => GetElement<PointCount>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Level.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:lvl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StringPoint &lt;c:pt></description></item>
    /// </list>
    /// </remark>
    public partial class Level : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Level class.
        /// </summary>
        public Level() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Level class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Level(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Level class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Level(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Level class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Level(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "lvl");
            builder.AddChild<StringPoint>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringPoint), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Level>(deep);
    }

    /// <summary>
    /// <para>Multi Level String Reference.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:multiLvlStrRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Formula &lt;c:f></description></item>
    ///   <item><description>MultiLevelStringCache &lt;c:multiLvlStrCache></description></item>
    ///   <item><description>MultiLvlStrRefExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class MultiLevelStringReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MultiLevelStringReference class.
        /// </summary>
        public MultiLevelStringReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLevelStringReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MultiLevelStringReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLevelStringReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MultiLevelStringReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLevelStringReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MultiLevelStringReference(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "multiLvlStrRef");
            builder.AddChild<Formula>();
            builder.AddChild<MultiLevelStringCache>();
            builder.AddChild<MultiLvlStrRefExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Formula), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Formula.</para>
        /// <para>Represents the following element tag in the schema: c:f.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Formula Formula
        {
            get => GetElement<Formula>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>MultiLevelStringCache.</para>
        /// <para>Represents the following element tag in the schema: c:multiLvlStrCache.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MultiLevelStringCache MultiLevelStringCache
        {
            get => GetElement<MultiLevelStringCache>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>MultiLvlStrRefExtensionList.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MultiLvlStrRefExtensionList MultiLvlStrRefExtensionList
        {
            get => GetElement<MultiLvlStrRefExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLevelStringReference>(deep);
    }

    /// <summary>
    /// <para>Defines the StringReference Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:strRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Formula &lt;c:f></description></item>
    ///   <item><description>StringCache &lt;c:strCache></description></item>
    ///   <item><description>StrRefExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class StringReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StringReference class.
        /// </summary>
        public StringReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StringReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StringReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StringReference(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "strRef");
            builder.AddChild<Formula>();
            builder.AddChild<StringCache>();
            builder.AddChild<StrRefExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Formula), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringCache), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Formula.</para>
        /// <para>Represents the following element tag in the schema: c:f.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Formula Formula
        {
            get => GetElement<Formula>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>StringCache.</para>
        /// <para>Represents the following element tag in the schema: c:strCache.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public StringCache StringCache
        {
            get => GetElement<StringCache>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>StrRefExtensionList.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public StrRefExtensionList StrRefExtensionList
        {
            get => GetElement<StrRefExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringReference>(deep);
    }

    /// <summary>
    /// <para>String Literal.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:strLit.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PointCount &lt;c:ptCount></description></item>
    ///   <item><description>StringPoint &lt;c:pt></description></item>
    ///   <item><description>StrDataExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class StringLiteral : StringDataType
    {
        /// <summary>
        /// Initializes a new instance of the StringLiteral class.
        /// </summary>
        public StringLiteral() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringLiteral class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StringLiteral(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringLiteral class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StringLiteral(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringLiteral class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StringLiteral(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "strLit");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringLiteral>(deep);
    }

    /// <summary>
    /// <para>Defines the StringCache Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:strCache.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PointCount &lt;c:ptCount></description></item>
    ///   <item><description>StringPoint &lt;c:pt></description></item>
    ///   <item><description>StrDataExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class StringCache : StringDataType
    {
        /// <summary>
        /// Initializes a new instance of the StringCache class.
        /// </summary>
        public StringCache() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StringCache(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StringCache(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringCache class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StringCache(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "strCache");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringCache>(deep);
    }

    /// <summary>
    /// <para>Defines the StringDataType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PointCount &lt;c:ptCount></description></item>
    ///   <item><description>StringPoint &lt;c:pt></description></item>
    ///   <item><description>StrDataExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public abstract partial class StringDataType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StringDataType class.
        /// </summary>
        protected StringDataType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringDataType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected StringDataType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringDataType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected StringDataType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringDataType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected StringDataType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<PointCount>();
            builder.AddChild<StringPoint>();
            builder.AddChild<StrDataExtensionList>();
        }

        /// <summary>
        /// <para>PointCount.</para>
        /// <para>Represents the following element tag in the schema: c:ptCount.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PointCount PointCount
        {
            get => GetElement<PointCount>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Layout Target.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:layoutTarget.</para>
    /// </summary>
    public partial class LayoutTarget : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the LayoutTarget class.
        /// </summary>
        public LayoutTarget() : base()
        {
        }

        /// <summary>
        /// <para>Layout Target Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "layoutTarget");
            builder.AddElement<LayoutTarget>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LayoutTarget>(deep);
    }

    /// <summary>
    /// <para>Left Mode.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:xMode.</para>
    /// </summary>
    public partial class LeftMode : LayoutModeType
    {
        /// <summary>
        /// Initializes a new instance of the LeftMode class.
        /// </summary>
        public LeftMode() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "xMode");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LeftMode>(deep);
    }

    /// <summary>
    /// <para>Top Mode.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:yMode.</para>
    /// </summary>
    public partial class TopMode : LayoutModeType
    {
        /// <summary>
        /// Initializes a new instance of the TopMode class.
        /// </summary>
        public TopMode() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "yMode");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TopMode>(deep);
    }

    /// <summary>
    /// <para>Width Mode.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:wMode.</para>
    /// </summary>
    public partial class WidthMode : LayoutModeType
    {
        /// <summary>
        /// Initializes a new instance of the WidthMode class.
        /// </summary>
        public WidthMode() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "wMode");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WidthMode>(deep);
    }

    /// <summary>
    /// <para>Height Mode.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:hMode.</para>
    /// </summary>
    public partial class HeightMode : LayoutModeType
    {
        /// <summary>
        /// Initializes a new instance of the HeightMode class.
        /// </summary>
        public HeightMode() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "hMode");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HeightMode>(deep);
    }

    /// <summary>
    /// <para>Defines the LayoutModeType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class LayoutModeType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the LayoutModeType class.
        /// </summary>
        protected LayoutModeType() : base()
        {
        }

        /// <summary>
        /// <para>Layout Mode Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<LayoutModeType>()
                           .AddAttribute(0, "val", a => a.Val);
        }
    }

    /// <summary>
    /// <para>Manual Layout.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:manualLayout.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LayoutTarget &lt;c:layoutTarget></description></item>
    ///   <item><description>LeftMode &lt;c:xMode></description></item>
    ///   <item><description>TopMode &lt;c:yMode></description></item>
    ///   <item><description>WidthMode &lt;c:wMode></description></item>
    ///   <item><description>HeightMode &lt;c:hMode></description></item>
    ///   <item><description>Left &lt;c:x></description></item>
    ///   <item><description>Top &lt;c:y></description></item>
    ///   <item><description>Width &lt;c:w></description></item>
    ///   <item><description>Height &lt;c:h></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ManualLayout : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ManualLayout class.
        /// </summary>
        public ManualLayout() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ManualLayout class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ManualLayout(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ManualLayout class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ManualLayout(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ManualLayout class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ManualLayout(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "manualLayout");
            builder.AddChild<LayoutTarget>();
            builder.AddChild<LeftMode>();
            builder.AddChild<TopMode>();
            builder.AddChild<WidthMode>();
            builder.AddChild<HeightMode>();
            builder.AddChild<Left>();
            builder.AddChild<Top>();
            builder.AddChild<Width>();
            builder.AddChild<Height>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LayoutTarget), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LeftMode), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TopMode), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.WidthMode), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.HeightMode), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Left), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Top), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Width), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Height), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Layout Target.</para>
        /// <para>Represents the following element tag in the schema: c:layoutTarget.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public LayoutTarget LayoutTarget
        {
            get => GetElement<LayoutTarget>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Left Mode.</para>
        /// <para>Represents the following element tag in the schema: c:xMode.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public LeftMode LeftMode
        {
            get => GetElement<LeftMode>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Top Mode.</para>
        /// <para>Represents the following element tag in the schema: c:yMode.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public TopMode TopMode
        {
            get => GetElement<TopMode>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Width Mode.</para>
        /// <para>Represents the following element tag in the schema: c:wMode.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public WidthMode WidthMode
        {
            get => GetElement<WidthMode>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Height Mode.</para>
        /// <para>Represents the following element tag in the schema: c:hMode.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public HeightMode HeightMode
        {
            get => GetElement<HeightMode>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Left.</para>
        /// <para>Represents the following element tag in the schema: c:x.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Left Left
        {
            get => GetElement<Left>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Top.</para>
        /// <para>Represents the following element tag in the schema: c:y.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Top Top
        {
            get => GetElement<Top>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Width.</para>
        /// <para>Represents the following element tag in the schema: c:w.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Width Width
        {
            get => GetElement<Width>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Height.</para>
        /// <para>Represents the following element tag in the schema: c:h.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Height Height
        {
            get => GetElement<Height>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ManualLayout>(deep);
    }

    /// <summary>
    /// <para>X Rotation.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:rotX.</para>
    /// </summary>
    public partial class RotateX : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RotateX class.
        /// </summary>
        public RotateX() : base()
        {
        }

        /// <summary>
        /// <para>X Rotation Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public SByteValue Val
        {
            get => GetAttribute<SByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "rotX");
            builder.AddElement<RotateX>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
  aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-90L), MaxInclusive = (90L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RotateX>(deep);
    }

    /// <summary>
    /// <para>Height Percent.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:hPercent.</para>
    /// </summary>
    public partial class HeightPercent : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the HeightPercent class.
        /// </summary>
        public HeightPercent() : base()
        {
        }

        /// <summary>
        /// <para>Height Percent Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public UInt16Value Val
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "hPercent");
            builder.AddElement<HeightPercent>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (5L), MaxInclusive = (500L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HeightPercent>(deep);
    }

    /// <summary>
    /// <para>Y Rotation.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:rotY.</para>
    /// </summary>
    public partial class RotateY : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RotateY class.
        /// </summary>
        public RotateY() : base()
        {
        }

        /// <summary>
        /// <para>Y Rotation Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public UInt16Value Val
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "rotY");
            builder.AddElement<RotateY>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
  aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (360L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RotateY>(deep);
    }

    /// <summary>
    /// <para>Depth Percent.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:depthPercent.</para>
    /// </summary>
    public partial class DepthPercent : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DepthPercent class.
        /// </summary>
        public DepthPercent() : base()
        {
        }

        /// <summary>
        /// <para>Depth Percent Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public UInt16Value Val
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "depthPercent");
            builder.AddElement<DepthPercent>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (20L), MaxInclusive = (2000L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DepthPercent>(deep);
    }

    /// <summary>
    /// <para>Perspective.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:perspective.</para>
    /// </summary>
    public partial class Perspective : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Perspective class.
        /// </summary>
        public Perspective() : base()
        {
        }

        /// <summary>
        /// <para>Perspective Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public ByteValue Val
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "perspective");
            builder.AddElement<Perspective>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (240L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Perspective>(deep);
    }

    /// <summary>
    /// <para>Symbol.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:symbol.</para>
    /// </summary>
    public partial class Symbol : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Symbol class.
        /// </summary>
        public Symbol() : base()
        {
        }

        /// <summary>
        /// <para>Marker Style Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "symbol");
            builder.AddElement<Symbol>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Symbol>(deep);
    }

    /// <summary>
    /// <para>Size.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:size.</para>
    /// </summary>
    public partial class Size : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Size class.
        /// </summary>
        public Size() : base()
        {
        }

        /// <summary>
        /// <para>Marker Size Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public ByteValue Val
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "size");
            builder.AddElement<Size>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
  aBuilder.AddValidator(new NumberValidator() { MinInclusive = (2L), MaxInclusive = (72L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Size>(deep);
    }

    /// <summary>
    /// <para>Marker.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:marker.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Symbol &lt;c:symbol></description></item>
    ///   <item><description>Size &lt;c:size></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Marker : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Marker class.
        /// </summary>
        public Marker() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Marker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Marker(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public Marker(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "marker");
            builder.AddChild<Symbol>();
            builder.AddChild<Size>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Symbol), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Size), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Symbol.</para>
        /// <para>Represents the following element tag in the schema: c:symbol.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Symbol Symbol
        {
            get => GetElement<Symbol>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Size.</para>
        /// <para>Represents the following element tag in the schema: c:size.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Size Size
        {
            get => GetElement<Size>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Marker>(deep);
    }

    /// <summary>
    /// <para>Defines the PictureOptions Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:pictureOptions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ApplyToFront &lt;c:applyToFront></description></item>
    ///   <item><description>ApplyToSides &lt;c:applyToSides></description></item>
    ///   <item><description>ApplyToEnd &lt;c:applyToEnd></description></item>
    ///   <item><description>PictureFormat &lt;c:pictureFormat></description></item>
    ///   <item><description>PictureStackUnit &lt;c:pictureStackUnit></description></item>
    /// </list>
    /// </remark>
    public partial class PictureOptions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PictureOptions class.
        /// </summary>
        public PictureOptions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PictureOptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PictureOptions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PictureOptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PictureOptions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PictureOptions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PictureOptions(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "pictureOptions");
            builder.AddChild<ApplyToFront>();
            builder.AddChild<ApplyToSides>();
            builder.AddChild<ApplyToEnd>();
            builder.AddChild<PictureFormat>();
            builder.AddChild<PictureStackUnit>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ApplyToFront), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ApplyToSides), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ApplyToEnd), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureFormat), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureStackUnit), 0, 1)
            };
        }

        /// <summary>
        /// <para>Apply To Front.</para>
        /// <para>Represents the following element tag in the schema: c:applyToFront.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ApplyToFront ApplyToFront
        {
            get => GetElement<ApplyToFront>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Apply To Sides.</para>
        /// <para>Represents the following element tag in the schema: c:applyToSides.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ApplyToSides ApplyToSides
        {
            get => GetElement<ApplyToSides>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Apply to End.</para>
        /// <para>Represents the following element tag in the schema: c:applyToEnd.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ApplyToEnd ApplyToEnd
        {
            get => GetElement<ApplyToEnd>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Picture Format.</para>
        /// <para>Represents the following element tag in the schema: c:pictureFormat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PictureFormat PictureFormat
        {
            get => GetElement<PictureFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Picture Stack Unit.</para>
        /// <para>Represents the following element tag in the schema: c:pictureStackUnit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PictureStackUnit PictureStackUnit
        {
            get => GetElement<PictureStackUnit>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PictureOptions>(deep);
    }

    /// <summary>
    /// <para>Trendline Type.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:trendlineType.</para>
    /// </summary>
    public partial class TrendlineType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TrendlineType class.
        /// </summary>
        public TrendlineType() : base()
        {
        }

        /// <summary>
        /// <para>Trendline Type Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "trendlineType");
            builder.AddElement<TrendlineType>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TrendlineType>(deep);
    }

    /// <summary>
    /// <para>Polynomial Trendline Order.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:order.</para>
    /// </summary>
    public partial class PolynomialOrder : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PolynomialOrder class.
        /// </summary>
        public PolynomialOrder() : base()
        {
        }

        /// <summary>
        /// <para>Order Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public ByteValue Val
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "order");
            builder.AddElement<PolynomialOrder>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
 aBuilder.AddValidator(RequiredValidator.Instance);
 aBuilder.AddValidator(new NumberValidator() { MinInclusive = (2L), MaxInclusive = (6L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PolynomialOrder>(deep);
    }

    /// <summary>
    /// <para>Period.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:period.</para>
    /// </summary>
    public partial class Period : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Period class.
        /// </summary>
        public Period() : base()
        {
        }

        /// <summary>
        /// <para>Period Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public UInt32Value Val
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "period");
            builder.AddElement<Period>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (2L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Period>(deep);
    }

    /// <summary>
    /// <para>Trendline Label.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:trendlineLbl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Layout &lt;c:layout></description></item>
    ///   <item><description>ChartText &lt;c:tx></description></item>
    ///   <item><description>NumberingFormat &lt;c:numFmt></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>TextProperties &lt;c:txPr></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class TrendlineLabel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TrendlineLabel class.
        /// </summary>
        public TrendlineLabel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TrendlineLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TrendlineLabel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TrendlineLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TrendlineLabel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TrendlineLabel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TrendlineLabel(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "trendlineLbl");
            builder.AddChild<Layout>();
            builder.AddChild<ChartText>();
            builder.AddChild<NumberingFormat>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<TextProperties>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Layout), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartText), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Layout.</para>
        /// <para>Represents the following element tag in the schema: c:layout.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Layout Layout
        {
            get => GetElement<Layout>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartText.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartText ChartText
        {
            get => GetElement<ChartText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number Format.</para>
        /// <para>Represents the following element tag in the schema: c:numFmt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public NumberingFormat NumberingFormat
        {
            get => GetElement<NumberingFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TextProperties.</para>
        /// <para>Represents the following element tag in the schema: c:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public TextProperties TextProperties
        {
            get => GetElement<TextProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TrendlineLabel>(deep);
    }

    /// <summary>
    /// <para>Error Bar Direction.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:errDir.</para>
    /// </summary>
    public partial class ErrorDirection : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ErrorDirection class.
        /// </summary>
        public ErrorDirection() : base()
        {
        }

        /// <summary>
        /// <para>Error Bar Direction Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "errDir");
            builder.AddElement<ErrorDirection>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ErrorDirection>(deep);
    }

    /// <summary>
    /// <para>Error Bar Type.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:errBarType.</para>
    /// </summary>
    public partial class ErrorBarType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ErrorBarType class.
        /// </summary>
        public ErrorBarType() : base()
        {
        }

        /// <summary>
        /// <para>Error Bar Type Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "errBarType");
            builder.AddElement<ErrorBarType>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ErrorBarType>(deep);
    }

    /// <summary>
    /// <para>Error Bar Value Type.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:errValType.</para>
    /// </summary>
    public partial class ErrorBarValueType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ErrorBarValueType class.
        /// </summary>
        public ErrorBarValueType() : base()
        {
        }

        /// <summary>
        /// <para>Error Bar Type Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "errValType");
            builder.AddElement<ErrorBarValueType>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ErrorBarValueType>(deep);
    }

    /// <summary>
    /// <para>Plus.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:plus.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NumberReference &lt;c:numRef></description></item>
    ///   <item><description>NumberLiteral &lt;c:numLit></description></item>
    /// </list>
    /// </remark>
    public partial class Plus : NumberDataSourceType
    {
        /// <summary>
        /// Initializes a new instance of the Plus class.
        /// </summary>
        public Plus() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Plus class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Plus(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Plus class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Plus(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Plus class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Plus(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "plus");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Plus>(deep);
    }

    /// <summary>
    /// <para>Minus.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:minus.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NumberReference &lt;c:numRef></description></item>
    ///   <item><description>NumberLiteral &lt;c:numLit></description></item>
    /// </list>
    /// </remark>
    public partial class Minus : NumberDataSourceType
    {
        /// <summary>
        /// Initializes a new instance of the Minus class.
        /// </summary>
        public Minus() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Minus class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Minus(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Minus class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Minus(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Minus class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Minus(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "minus");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Minus>(deep);
    }

    /// <summary>
    /// <para>Defines the Values Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:val.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NumberReference &lt;c:numRef></description></item>
    ///   <item><description>NumberLiteral &lt;c:numLit></description></item>
    /// </list>
    /// </remark>
    public partial class Values : NumberDataSourceType
    {
        /// <summary>
        /// Initializes a new instance of the Values class.
        /// </summary>
        public Values() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Values class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Values(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Values class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Values(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Values class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Values(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "val");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Values>(deep);
    }

    /// <summary>
    /// <para>Defines the YValues Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:yVal.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NumberReference &lt;c:numRef></description></item>
    ///   <item><description>NumberLiteral &lt;c:numLit></description></item>
    /// </list>
    /// </remark>
    public partial class YValues : NumberDataSourceType
    {
        /// <summary>
        /// Initializes a new instance of the YValues class.
        /// </summary>
        public YValues() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the YValues class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public YValues(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the YValues class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public YValues(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the YValues class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public YValues(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "yVal");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<YValues>(deep);
    }

    /// <summary>
    /// <para>Defines the BubbleSize Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:bubbleSize.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NumberReference &lt;c:numRef></description></item>
    ///   <item><description>NumberLiteral &lt;c:numLit></description></item>
    /// </list>
    /// </remark>
    public partial class BubbleSize : NumberDataSourceType
    {
        /// <summary>
        /// Initializes a new instance of the BubbleSize class.
        /// </summary>
        public BubbleSize() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleSize class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleSize(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleSize class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleSize(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleSize class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BubbleSize(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "bubbleSize");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleSize>(deep);
    }

    /// <summary>
    /// <para>Defines the NumberDataSourceType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NumberReference &lt;c:numRef></description></item>
    ///   <item><description>NumberLiteral &lt;c:numLit></description></item>
    /// </list>
    /// </remark>
    public abstract partial class NumberDataSourceType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NumberDataSourceType class.
        /// </summary>
        protected NumberDataSourceType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberDataSourceType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected NumberDataSourceType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberDataSourceType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected NumberDataSourceType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberDataSourceType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected NumberDataSourceType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<NumberReference>();
            builder.AddChild<NumberLiteral>();
        }

        /// <summary>
        /// <para>Number Reference.</para>
        /// <para>Represents the following element tag in the schema: c:numRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public NumberReference NumberReference
        {
            get => GetElement<NumberReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number Literal.</para>
        /// <para>Represents the following element tag in the schema: c:numLit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public NumberLiteral NumberLiteral
        {
            get => GetElement<NumberLiteral>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Gap Width.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:gapWidth.</para>
    /// </summary>
    public partial class GapWidth : GapAmountType
    {
        /// <summary>
        /// Initializes a new instance of the GapWidth class.
        /// </summary>
        public GapWidth() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "gapWidth");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GapWidth>(deep);
    }

    /// <summary>
    /// <para>Defines the GapDepth Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:gapDepth.</para>
    /// </summary>
    public partial class GapDepth : GapAmountType
    {
        /// <summary>
        /// Initializes a new instance of the GapDepth class.
        /// </summary>
        public GapDepth() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "gapDepth");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GapDepth>(deep);
    }

    /// <summary>
    /// <para>Defines the GapAmountType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class GapAmountType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the GapAmountType class.
        /// </summary>
        protected GapAmountType() : base()
        {
        }

        /// <summary>
        /// <para>Gap Size Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public UInt16Value Val
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<GapAmountType>()
                           .AddAttribute(0, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (500L) });
                           });
        }
    }

    /// <summary>
    /// <para>Up Bars.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:upBars.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    /// </list>
    /// </remark>
    public partial class UpBars : UpDownBarType
    {
        /// <summary>
        /// Initializes a new instance of the UpBars class.
        /// </summary>
        public UpBars() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UpBars class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UpBars(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UpBars class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UpBars(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UpBars class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public UpBars(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "upBars");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UpBars>(deep);
    }

    /// <summary>
    /// <para>Down Bars.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:downBars.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    /// </list>
    /// </remark>
    public partial class DownBars : UpDownBarType
    {
        /// <summary>
        /// Initializes a new instance of the DownBars class.
        /// </summary>
        public DownBars() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DownBars class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DownBars(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DownBars class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DownBars(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DownBars class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DownBars(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "downBars");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DownBars>(deep);
    }

    /// <summary>
    /// <para>Defines the UpDownBarType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    /// </list>
    /// </remark>
    public abstract partial class UpDownBarType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the UpDownBarType class.
        /// </summary>
        protected UpDownBarType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UpDownBarType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected UpDownBarType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UpDownBarType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected UpDownBarType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UpDownBarType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected UpDownBarType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<ChartShapeProperties>();
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Pie of Pie or Bar of Pie Type.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ofPieType.</para>
    /// </summary>
    public partial class OfPieType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OfPieType class.
        /// </summary>
        public OfPieType() : base()
        {
        }

        /// <summary>
        /// <para>Pie of Pie or Bar of Pie Type Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.OfPieValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.OfPieValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ofPieType");
            builder.AddElement<OfPieType>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfPieType>(deep);
    }

    /// <summary>
    /// <para>Split Type.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:splitType.</para>
    /// </summary>
    public partial class SplitType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SplitType class.
        /// </summary>
        public SplitType() : base()
        {
        }

        /// <summary>
        /// <para>Split Type Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.SplitValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.SplitValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "splitType");
            builder.AddElement<SplitType>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitType>(deep);
    }

    /// <summary>
    /// <para>Custom Split.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:custSplit.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SecondPiePoint &lt;c:secondPiePt></description></item>
    /// </list>
    /// </remark>
    public partial class CustomSplit : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomSplit class.
        /// </summary>
        public CustomSplit() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomSplit class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomSplit(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomSplit class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomSplit(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomSplit class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CustomSplit(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "custSplit");
            builder.AddChild<SecondPiePoint>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SecondPiePoint), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomSplit>(deep);
    }

    /// <summary>
    /// <para>Second Pie Size.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:secondPieSize.</para>
    /// </summary>
    public partial class SecondPieSize : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SecondPieSize class.
        /// </summary>
        public SecondPieSize() : base()
        {
        }

        /// <summary>
        /// <para>Second Pie Size Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public UInt16Value Val
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "secondPieSize");
            builder.AddElement<SecondPieSize>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (5L), MaxInclusive = (200L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SecondPieSize>(deep);
    }

    /// <summary>
    /// <para>Band Format.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:bandFmt.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Index &lt;c:idx></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    /// </list>
    /// </remark>
    public partial class BandFormat : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BandFormat class.
        /// </summary>
        public BandFormat() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BandFormat class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BandFormat(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BandFormat class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BandFormat(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BandFormat class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BandFormat(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "bandFmt");
            builder.AddChild<Index>();
            builder.AddChild<ChartShapeProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Index Index
        {
            get => GetElement<Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BandFormat>(deep);
    }

    /// <summary>
    /// <para>Picture Format.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:pictureFormat.</para>
    /// </summary>
    public partial class PictureFormat : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PictureFormat class.
        /// </summary>
        public PictureFormat() : base()
        {
        }

        /// <summary>
        /// <para>Picture Format Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "pictureFormat");
            builder.AddElement<PictureFormat>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PictureFormat>(deep);
    }

    /// <summary>
    /// <para>Picture Stack Unit.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:pictureStackUnit.</para>
    /// </summary>
    public partial class PictureStackUnit : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PictureStackUnit class.
        /// </summary>
        public PictureStackUnit() : base()
        {
        }

        /// <summary>
        /// <para>Picture Stack Unit</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public DoubleValue Val
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "pictureStackUnit");
            builder.AddElement<PictureStackUnit>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PictureStackUnit>(deep);
    }

    /// <summary>
    /// <para>Built in Display Unit Value.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:builtInUnit.</para>
    /// </summary>
    public partial class BuiltInUnit : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BuiltInUnit class.
        /// </summary>
        public BuiltInUnit() : base()
        {
        }

        /// <summary>
        /// <para>Built In Unit Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "builtInUnit");
            builder.AddElement<BuiltInUnit>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BuiltInUnit>(deep);
    }

    /// <summary>
    /// <para>Display Units Label.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:dispUnitsLbl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Layout &lt;c:layout></description></item>
    ///   <item><description>ChartText &lt;c:tx></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>TextProperties &lt;c:txPr></description></item>
    /// </list>
    /// </remark>
    public partial class DisplayUnitsLabel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DisplayUnitsLabel class.
        /// </summary>
        public DisplayUnitsLabel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DisplayUnitsLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DisplayUnitsLabel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DisplayUnitsLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DisplayUnitsLabel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DisplayUnitsLabel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DisplayUnitsLabel(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "dispUnitsLbl");
            builder.AddChild<Layout>();
            builder.AddChild<ChartText>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<TextProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Layout), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartText), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Layout.</para>
        /// <para>Represents the following element tag in the schema: c:layout.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Layout Layout
        {
            get => GetElement<Layout>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartText.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartText ChartText
        {
            get => GetElement<ChartText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TextProperties.</para>
        /// <para>Represents the following element tag in the schema: c:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public TextProperties TextProperties
        {
            get => GetElement<TextProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DisplayUnitsLabel>(deep);
    }

    /// <summary>
    /// <para>Logarithmic Base.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:logBase.</para>
    /// </summary>
    public partial class LogBase : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the LogBase class.
        /// </summary>
        public LogBase() : base()
        {
        }

        /// <summary>
        /// <para>Logarithmic Base Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public DoubleValue Val
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "logBase");
            builder.AddElement<LogBase>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (2L), MaxInclusive = (1000L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LogBase>(deep);
    }

    /// <summary>
    /// <para>Axis Orientation.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:orientation.</para>
    /// </summary>
    public partial class Orientation : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Orientation class.
        /// </summary>
        public Orientation() : base()
        {
        }

        /// <summary>
        /// <para>Orientation Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "orientation");
            builder.AddElement<Orientation>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Orientation>(deep);
    }

    /// <summary>
    /// <para>Pivot Format.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:pivotFmt.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Index &lt;c:idx></description></item>
    ///   <item><description>ShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>Marker &lt;c:marker></description></item>
    ///   <item><description>DataLabel &lt;c:dLbl></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class PivotFormat : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotFormat class.
        /// </summary>
        public PivotFormat() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotFormat class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotFormat(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotFormat class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotFormat(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotFormat class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotFormat(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "pivotFmt");
            builder.AddChild<Index>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<Marker>();
            builder.AddChild<DataLabel>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabel), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Index Index
        {
            get => GetElement<Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Marker.</para>
        /// <para>Represents the following element tag in the schema: c:marker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Marker Marker
        {
            get => GetElement<Marker>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Data Label.</para>
        /// <para>Represents the following element tag in the schema: c:dLbl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DataLabel DataLabel
        {
            get => GetElement<DataLabel>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotFormat>(deep);
    }

    /// <summary>
    /// <para>Legend Position.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:legendPos.</para>
    /// </summary>
    public partial class LegendPosition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the LegendPosition class.
        /// </summary>
        public LegendPosition() : base()
        {
        }

        /// <summary>
        /// <para>Legend Position Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "legendPos");
            builder.AddElement<LegendPosition>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LegendPosition>(deep);
    }

    /// <summary>
    /// <para>Legend Entry.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:legendEntry.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Index &lt;c:idx></description></item>
    ///   <item><description>Delete &lt;c:delete></description></item>
    ///   <item><description>TextProperties &lt;c:txPr></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class LegendEntry : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LegendEntry class.
        /// </summary>
        public LegendEntry() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LegendEntry class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LegendEntry(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LegendEntry class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LegendEntry(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LegendEntry class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LegendEntry(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "legendEntry");
            builder.AddChild<Index>();
            builder.AddChild<Delete>();
            builder.AddChild<TextProperties>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Delete), 1, 1),
                    new CompositeParticle(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle(ParticleType.Sequence, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties), 0, 1)
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Index Index
        {
            get => GetElement<Index>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LegendEntry>(deep);
    }

    /// <summary>
    /// <para>Pivot Formats.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:pivotFmts.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PivotFormat &lt;c:pivotFmt></description></item>
    /// </list>
    /// </remark>
    public partial class PivotFormats : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotFormats class.
        /// </summary>
        public PivotFormats() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotFormats class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotFormats(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotFormats class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotFormats(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotFormats class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotFormats(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "pivotFmts");
            builder.AddChild<PivotFormat>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PivotFormat), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotFormats>(deep);
    }

    /// <summary>
    /// <para>View In 3D.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:view3D.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RotateX &lt;c:rotX></description></item>
    ///   <item><description>HeightPercent &lt;c:hPercent></description></item>
    ///   <item><description>RotateY &lt;c:rotY></description></item>
    ///   <item><description>DepthPercent &lt;c:depthPercent></description></item>
    ///   <item><description>RightAngleAxes &lt;c:rAngAx></description></item>
    ///   <item><description>Perspective &lt;c:perspective></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class View3D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the View3D class.
        /// </summary>
        public View3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the View3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public View3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the View3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public View3D(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the View3D class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public View3D(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "view3D");
            builder.AddChild<RotateX>();
            builder.AddChild<HeightPercent>();
            builder.AddChild<RotateY>();
            builder.AddChild<DepthPercent>();
            builder.AddChild<RightAngleAxes>();
            builder.AddChild<Perspective>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.RotateX), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.HeightPercent), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.RotateY), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DepthPercent), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.RightAngleAxes), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Perspective), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>X Rotation.</para>
        /// <para>Represents the following element tag in the schema: c:rotX.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public RotateX RotateX
        {
            get => GetElement<RotateX>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Height Percent.</para>
        /// <para>Represents the following element tag in the schema: c:hPercent.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public HeightPercent HeightPercent
        {
            get => GetElement<HeightPercent>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Y Rotation.</para>
        /// <para>Represents the following element tag in the schema: c:rotY.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public RotateY RotateY
        {
            get => GetElement<RotateY>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Depth Percent.</para>
        /// <para>Represents the following element tag in the schema: c:depthPercent.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DepthPercent DepthPercent
        {
            get => GetElement<DepthPercent>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Right Angle Axes.</para>
        /// <para>Represents the following element tag in the schema: c:rAngAx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public RightAngleAxes RightAngleAxes
        {
            get => GetElement<RightAngleAxes>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Perspective.</para>
        /// <para>Represents the following element tag in the schema: c:perspective.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Perspective Perspective
        {
            get => GetElement<Perspective>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<View3D>(deep);
    }

    /// <summary>
    /// <para>Floor.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:floor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Thickness &lt;c:thickness></description></item>
    ///   <item><description>ShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Floor : SurfaceType
    {
        /// <summary>
        /// Initializes a new instance of the Floor class.
        /// </summary>
        public Floor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Floor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Floor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Floor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Floor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Floor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Floor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "floor");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Thickness), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Floor>(deep);
    }

    /// <summary>
    /// <para>Side Wall.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:sideWall.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Thickness &lt;c:thickness></description></item>
    ///   <item><description>ShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class SideWall : SurfaceType
    {
        /// <summary>
        /// Initializes a new instance of the SideWall class.
        /// </summary>
        public SideWall() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SideWall class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SideWall(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SideWall class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SideWall(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SideWall class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SideWall(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "sideWall");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Thickness), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SideWall>(deep);
    }

    /// <summary>
    /// <para>Back Wall.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:backWall.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Thickness &lt;c:thickness></description></item>
    ///   <item><description>ShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class BackWall : SurfaceType
    {
        /// <summary>
        /// Initializes a new instance of the BackWall class.
        /// </summary>
        public BackWall() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackWall class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackWall(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackWall class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackWall(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackWall class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackWall(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "backWall");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Thickness), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackWall>(deep);
    }

    /// <summary>
    /// <para>Defines the SurfaceType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Thickness &lt;c:thickness></description></item>
    ///   <item><description>ShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public abstract partial class SurfaceType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SurfaceType class.
        /// </summary>
        protected SurfaceType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected SurfaceType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected SurfaceType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected SurfaceType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<Thickness>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<PictureOptions>();
            builder.AddChild<ExtensionList>();
        }

        /// <summary>
        /// <para>Thickness.</para>
        /// <para>Represents the following element tag in the schema: c:thickness.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Thickness Thickness
        {
            get => GetElement<Thickness>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Picture Options.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PictureOptions PictureOptions
        {
            get => GetElement<PictureOptions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Plot Area.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:plotArea.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Layout &lt;c:layout></description></item>
    ///   <item><description>AreaChart &lt;c:areaChart></description></item>
    ///   <item><description>Area3DChart &lt;c:area3DChart></description></item>
    ///   <item><description>LineChart &lt;c:lineChart></description></item>
    ///   <item><description>Line3DChart &lt;c:line3DChart></description></item>
    ///   <item><description>StockChart &lt;c:stockChart></description></item>
    ///   <item><description>RadarChart &lt;c:radarChart></description></item>
    ///   <item><description>ScatterChart &lt;c:scatterChart></description></item>
    ///   <item><description>PieChart &lt;c:pieChart></description></item>
    ///   <item><description>Pie3DChart &lt;c:pie3DChart></description></item>
    ///   <item><description>DoughnutChart &lt;c:doughnutChart></description></item>
    ///   <item><description>BarChart &lt;c:barChart></description></item>
    ///   <item><description>Bar3DChart &lt;c:bar3DChart></description></item>
    ///   <item><description>OfPieChart &lt;c:ofPieChart></description></item>
    ///   <item><description>SurfaceChart &lt;c:surfaceChart></description></item>
    ///   <item><description>Surface3DChart &lt;c:surface3DChart></description></item>
    ///   <item><description>BubbleChart &lt;c:bubbleChart></description></item>
    ///   <item><description>ValueAxis &lt;c:valAx></description></item>
    ///   <item><description>CategoryAxis &lt;c:catAx></description></item>
    ///   <item><description>DateAxis &lt;c:dateAx></description></item>
    ///   <item><description>SeriesAxis &lt;c:serAx></description></item>
    ///   <item><description>DataTable &lt;c:dTable></description></item>
    ///   <item><description>ShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class PlotArea : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PlotArea class.
        /// </summary>
        public PlotArea() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotArea class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PlotArea(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotArea class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PlotArea(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotArea class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PlotArea(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "plotArea");
            builder.AddChild<Layout>();
            builder.AddChild<AreaChart>();
            builder.AddChild<Area3DChart>();
            builder.AddChild<LineChart>();
            builder.AddChild<Line3DChart>();
            builder.AddChild<StockChart>();
            builder.AddChild<RadarChart>();
            builder.AddChild<ScatterChart>();
            builder.AddChild<PieChart>();
            builder.AddChild<Pie3DChart>();
            builder.AddChild<DoughnutChart>();
            builder.AddChild<BarChart>();
            builder.AddChild<Bar3DChart>();
            builder.AddChild<OfPieChart>();
            builder.AddChild<SurfaceChart>();
            builder.AddChild<Surface3DChart>();
            builder.AddChild<BubbleChart>();
            builder.AddChild<ValueAxis>();
            builder.AddChild<CategoryAxis>();
            builder.AddChild<DateAxis>();
            builder.AddChild<SeriesAxis>();
            builder.AddChild<DataTable>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Layout), 0, 1),
                new CompositeParticle(ParticleType.Choice, 1, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AreaChart), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Area3DChart), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LineChart), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StockChart), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.RadarChart), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PieChart), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DoughnutChart), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarChart), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Surface3DChart), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart), 1, 1)
                },
                new CompositeParticle(ParticleType.Choice, 0, 4)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DateAxis), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesAxis), 1, 1)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataTable), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Layout.</para>
        /// <para>Represents the following element tag in the schema: c:layout.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Layout Layout
        {
            get => GetElement<Layout>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotArea>(deep);
    }

    /// <summary>
    /// <para>Legend.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:legend.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LegendPosition &lt;c:legendPos></description></item>
    ///   <item><description>LegendEntry &lt;c:legendEntry></description></item>
    ///   <item><description>Layout &lt;c:layout></description></item>
    ///   <item><description>Overlay &lt;c:overlay></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>TextProperties &lt;c:txPr></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Legend : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Legend class.
        /// </summary>
        public Legend() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Legend class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Legend(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Legend class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Legend(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Legend class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Legend(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "legend");
            builder.AddChild<LegendPosition>();
            builder.AddChild<LegendEntry>();
            builder.AddChild<Layout>();
            builder.AddChild<Overlay>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<TextProperties>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LegendPosition), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LegendEntry), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Layout), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Overlay), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Legend Position.</para>
        /// <para>Represents the following element tag in the schema: c:legendPos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public LegendPosition LegendPosition
        {
            get => GetElement<LegendPosition>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Legend>(deep);
    }

    /// <summary>
    /// <para>Display Blanks As.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:dispBlanksAs.</para>
    /// </summary>
    public partial class DisplayBlanksAs : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DisplayBlanksAs class.
        /// </summary>
        public DisplayBlanksAs() : base()
        {
        }

        /// <summary>
        /// <para>Display Blanks As Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "dispBlanksAs");
            builder.AddElement<DisplayBlanksAs>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DisplayBlanksAs>(deep);
    }

    /// <summary>
    /// <para>Header and Footer.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:headerFooter.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OddHeader &lt;c:oddHeader></description></item>
    ///   <item><description>OddFooter &lt;c:oddFooter></description></item>
    ///   <item><description>EvenHeader &lt;c:evenHeader></description></item>
    ///   <item><description>EvenFooter &lt;c:evenFooter></description></item>
    ///   <item><description>FirstHeader &lt;c:firstHeader></description></item>
    ///   <item><description>FirstFooter &lt;c:firstFooter></description></item>
    /// </list>
    /// </remark>
    public partial class HeaderFooter : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the HeaderFooter class.
        /// </summary>
        public HeaderFooter() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HeaderFooter class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HeaderFooter(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HeaderFooter class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HeaderFooter(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HeaderFooter class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HeaderFooter(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Align With Margins</para>
        /// <para>Represents the following attribute in the schema: alignWithMargins</para>
        /// </summary>
        public BooleanValue AlignWithMargins
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Different Odd Even</para>
        /// <para>Represents the following attribute in the schema: differentOddEven</para>
        /// </summary>
        public BooleanValue DifferentOddEven
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Different First</para>
        /// <para>Represents the following attribute in the schema: differentFirst</para>
        /// </summary>
        public BooleanValue DifferentFirst
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "headerFooter");
            builder.AddChild<OddHeader>();
            builder.AddChild<OddFooter>();
            builder.AddChild<EvenHeader>();
            builder.AddChild<EvenFooter>();
            builder.AddChild<FirstHeader>();
            builder.AddChild<FirstFooter>();
            builder.AddElement<HeaderFooter>()
.AddAttribute(0, "alignWithMargins", a => a.AlignWithMargins)
.AddAttribute(0, "differentOddEven", a => a.DifferentOddEven)
.AddAttribute(0, "differentFirst", a => a.DifferentFirst);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.OddHeader), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.OddFooter), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.EvenHeader), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.EvenFooter), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.FirstHeader), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.FirstFooter), 0, 1)
            };
        }

        /// <summary>
        /// <para>Odd Header.</para>
        /// <para>Represents the following element tag in the schema: c:oddHeader.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public OddHeader OddHeader
        {
            get => GetElement<OddHeader>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Odd Footer.</para>
        /// <para>Represents the following element tag in the schema: c:oddFooter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public OddFooter OddFooter
        {
            get => GetElement<OddFooter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Even Header.</para>
        /// <para>Represents the following element tag in the schema: c:evenHeader.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public EvenHeader EvenHeader
        {
            get => GetElement<EvenHeader>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Even Footer.</para>
        /// <para>Represents the following element tag in the schema: c:evenFooter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public EvenFooter EvenFooter
        {
            get => GetElement<EvenFooter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>First Header.</para>
        /// <para>Represents the following element tag in the schema: c:firstHeader.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public FirstHeader FirstHeader
        {
            get => GetElement<FirstHeader>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>First Footer.</para>
        /// <para>Represents the following element tag in the schema: c:firstFooter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public FirstFooter FirstFooter
        {
            get => GetElement<FirstFooter>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HeaderFooter>(deep);
    }

    /// <summary>
    /// <para>Page Margins.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:pageMargins.</para>
    /// </summary>
    public partial class PageMargins : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PageMargins class.
        /// </summary>
        public PageMargins() : base()
        {
        }

        /// <summary>
        /// <para>Left</para>
        /// <para>Represents the following attribute in the schema: l</para>
        /// </summary>
        public DoubleValue Left
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Right</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        public DoubleValue Right
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Top</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        public DoubleValue Top
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom</para>
        /// <para>Represents the following attribute in the schema: b</para>
        /// </summary>
        public DoubleValue Bottom
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Header</para>
        /// <para>Represents the following attribute in the schema: header</para>
        /// </summary>
        public DoubleValue Header
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Footer</para>
        /// <para>Represents the following attribute in the schema: footer</para>
        /// </summary>
        public DoubleValue Footer
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "pageMargins");
            builder.AddElement<PageMargins>()
.AddAttribute(0, "l", a => a.Left, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "r", a => a.Right, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "t", a => a.Top, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "b", a => a.Bottom, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "header", a => a.Header, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "footer", a => a.Footer, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.AddConstraint(new AttributeValueRangeConstraint(3 /*:b*/, true, 0, true, 49, false));
            builder.AddConstraint(new AttributeValueRangeConstraint(5 /*:footer*/, true, 0, true, 49, false));
            builder.AddConstraint(new AttributeValueRangeConstraint(4 /*:header*/, true, 0, true, 49, false));
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*:l*/, true, 0, true, 49, false));
            builder.AddConstraint(new AttributeValueRangeConstraint(1 /*:r*/, true, 0, true, 49, false));
            builder.AddConstraint(new AttributeValueRangeConstraint(2 /*:t*/, true, 0, true, 49, false));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PageMargins>(deep);
    }

    /// <summary>
    /// <para>Page Setup.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:pageSetup.</para>
    /// </summary>
    public partial class PageSetup : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PageSetup class.
        /// </summary>
        public PageSetup() : base()
        {
        }

        /// <summary>
        /// <para>Page Size</para>
        /// <para>Represents the following attribute in the schema: paperSize</para>
        /// </summary>
        public UInt32Value PaperSize
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>First Page Number</para>
        /// <para>Represents the following attribute in the schema: firstPageNumber</para>
        /// </summary>
        public Int32Value FirstPageNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Orientation</para>
        /// <para>Represents the following attribute in the schema: orientation</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.PageSetupOrientationValues> Orientation
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.PageSetupOrientationValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black and White</para>
        /// <para>Represents the following attribute in the schema: blackAndWhite</para>
        /// </summary>
        public BooleanValue BlackAndWhite
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Draft</para>
        /// <para>Represents the following attribute in the schema: draft</para>
        /// </summary>
        public BooleanValue Draft
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Use First Page Number</para>
        /// <para>Represents the following attribute in the schema: useFirstPageNumber</para>
        /// </summary>
        public BooleanValue UseFirstPageNumber
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal DPI</para>
        /// <para>Represents the following attribute in the schema: horizontalDpi</para>
        /// </summary>
        public Int32Value HorizontalDpi
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Vertical DPI</para>
        /// <para>Represents the following attribute in the schema: verticalDpi</para>
        /// </summary>
        public Int32Value VerticalDpi
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Copies</para>
        /// <para>Represents the following attribute in the schema: copies</para>
        /// </summary>
        public UInt32Value Copies
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "pageSetup");
            builder.AddElement<PageSetup>()
.AddAttribute(0, "paperSize", a => a.PaperSize)
.AddAttribute(0, "firstPageNumber", a => a.FirstPageNumber)
.AddAttribute(0, "orientation", a => a.Orientation)
.AddAttribute(0, "blackAndWhite", a => a.BlackAndWhite)
.AddAttribute(0, "draft", a => a.Draft)
.AddAttribute(0, "useFirstPageNumber", a => a.UseFirstPageNumber)
.AddAttribute(0, "horizontalDpi", a => a.HorizontalDpi)
.AddAttribute(0, "verticalDpi", a => a.VerticalDpi)
.AddAttribute(0, "copies", a => a.Copies);
            builder.AddConstraint(new AttributeValueRangeConstraint(8 /*:copies*/, true, double.NegativeInfinity, true, 2147483647, true));
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*:paperSize*/, true, double.NegativeInfinity, true, 2147483647, true) { Application = ApplicationType.Excel });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PageSetup>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:spPr.</para>
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
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "spPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Transform2D>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Outline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList>();
            builder.AddElement<ShapeProperties>()
.AddAttribute(0, "bwMode", a => a.BlackWhiteMode, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
        }

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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Data Label.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:dLbl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Index &lt;c:idx></description></item>
    ///   <item><description>Delete &lt;c:delete></description></item>
    ///   <item><description>Layout &lt;c:layout></description></item>
    ///   <item><description>ChartText &lt;c:tx></description></item>
    ///   <item><description>NumberingFormat &lt;c:numFmt></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>TextProperties &lt;c:txPr></description></item>
    ///   <item><description>DataLabelPosition &lt;c:dLblPos></description></item>
    ///   <item><description>ShowLegendKey &lt;c:showLegendKey></description></item>
    ///   <item><description>ShowValue &lt;c:showVal></description></item>
    ///   <item><description>ShowCategoryName &lt;c:showCatName></description></item>
    ///   <item><description>ShowSeriesName &lt;c:showSerName></description></item>
    ///   <item><description>ShowPercent &lt;c:showPercent></description></item>
    ///   <item><description>ShowBubbleSize &lt;c:showBubbleSize></description></item>
    ///   <item><description>Separator &lt;c:separator></description></item>
    ///   <item><description>DLblExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class DataLabel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabel class.
        /// </summary>
        public DataLabel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabel(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "dLbl");
            builder.AddChild<Index>();
            builder.AddChild<Delete>();
            builder.AddChild<Layout>();
            builder.AddChild<ChartText>();
            builder.AddChild<NumberingFormat>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<TextProperties>();
            builder.AddChild<DataLabelPosition>();
            builder.AddChild<ShowLegendKey>();
            builder.AddChild<ShowValue>();
            builder.AddChild<ShowCategoryName>();
            builder.AddChild<ShowSeriesName>();
            builder.AddChild<ShowPercent>();
            builder.AddChild<ShowBubbleSize>();
            builder.AddChild<Separator>();
            builder.AddChild<DLblExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
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
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Index Index
        {
            get => GetElement<Index>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabel>(deep);
    }

    /// <summary>
    /// <para>Area Charts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:areaChart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Grouping &lt;c:grouping></description></item>
    ///   <item><description>VaryColors &lt;c:varyColors></description></item>
    ///   <item><description>AreaChartSeries &lt;c:ser></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>DropLines &lt;c:dropLines></description></item>
    ///   <item><description>AxisId &lt;c:axId></description></item>
    ///   <item><description>AreaChartExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class AreaChart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AreaChart class.
        /// </summary>
        public AreaChart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AreaChart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AreaChart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AreaChart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "areaChart");
            builder.AddChild<Grouping>();
            builder.AddChild<VaryColors>();
            builder.AddChild<AreaChartSeries>();
            builder.AddChild<DataLabels>();
            builder.AddChild<DropLines>();
            builder.AddChild<AxisId>();
            builder.AddChild<AreaChartExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Grouping), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.VaryColors), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AreaChartSeries), 0, 0),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DropLines), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisId), 2, 2),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Grouping.</para>
        /// <para>Represents the following element tag in the schema: c:grouping.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Grouping Grouping
        {
            get => GetElement<Grouping>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>VaryColors.</para>
        /// <para>Represents the following element tag in the schema: c:varyColors.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public VaryColors VaryColors
        {
            get => GetElement<VaryColors>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AreaChart>(deep);
    }

    /// <summary>
    /// <para>3D Area Charts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:area3DChart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Grouping &lt;c:grouping></description></item>
    ///   <item><description>VaryColors &lt;c:varyColors></description></item>
    ///   <item><description>AreaChartSeries &lt;c:ser></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>DropLines &lt;c:dropLines></description></item>
    ///   <item><description>GapDepth &lt;c:gapDepth></description></item>
    ///   <item><description>AxisId &lt;c:axId></description></item>
    ///   <item><description>Area3DChartExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Area3DChart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Area3DChart class.
        /// </summary>
        public Area3DChart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Area3DChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Area3DChart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Area3DChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Area3DChart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Area3DChart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Area3DChart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "area3DChart");
            builder.AddChild<Grouping>();
            builder.AddChild<VaryColors>();
            builder.AddChild<AreaChartSeries>();
            builder.AddChild<DataLabels>();
            builder.AddChild<DropLines>();
            builder.AddChild<GapDepth>();
            builder.AddChild<AxisId>();
            builder.AddChild<Area3DChartExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Grouping), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.VaryColors), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AreaChartSeries), 0, 0),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DropLines), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.GapDepth), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisId), 2, 3),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Grouping.</para>
        /// <para>Represents the following element tag in the schema: c:grouping.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Grouping Grouping
        {
            get => GetElement<Grouping>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>VaryColors.</para>
        /// <para>Represents the following element tag in the schema: c:varyColors.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public VaryColors VaryColors
        {
            get => GetElement<VaryColors>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Area3DChart>(deep);
    }

    /// <summary>
    /// <para>Line Charts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:lineChart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Grouping &lt;c:grouping></description></item>
    ///   <item><description>VaryColors &lt;c:varyColors></description></item>
    ///   <item><description>LineChartSeries &lt;c:ser></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>DropLines &lt;c:dropLines></description></item>
    ///   <item><description>HighLowLines &lt;c:hiLowLines></description></item>
    ///   <item><description>UpDownBars &lt;c:upDownBars></description></item>
    ///   <item><description>ShowMarker &lt;c:marker></description></item>
    ///   <item><description>Smooth &lt;c:smooth></description></item>
    ///   <item><description>AxisId &lt;c:axId></description></item>
    ///   <item><description>LineChartExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class LineChart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LineChart class.
        /// </summary>
        public LineChart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineChart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineChart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LineChart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "lineChart");
            builder.AddChild<Grouping>();
            builder.AddChild<VaryColors>();
            builder.AddChild<LineChartSeries>();
            builder.AddChild<DataLabels>();
            builder.AddChild<DropLines>();
            builder.AddChild<HighLowLines>();
            builder.AddChild<UpDownBars>();
            builder.AddChild<ShowMarker>();
            builder.AddChild<Smooth>();
            builder.AddChild<AxisId>();
            builder.AddChild<LineChartExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Grouping), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.VaryColors), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries), 0, 0),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DropLines), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.HighLowLines), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.UpDownBars), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowMarker), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Smooth), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisId), 2, 2),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LineChartExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Grouping.</para>
        /// <para>Represents the following element tag in the schema: c:grouping.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Grouping Grouping
        {
            get => GetElement<Grouping>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>VaryColors.</para>
        /// <para>Represents the following element tag in the schema: c:varyColors.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public VaryColors VaryColors
        {
            get => GetElement<VaryColors>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineChart>(deep);
    }

    /// <summary>
    /// <para>3D Line Charts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:line3DChart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Grouping &lt;c:grouping></description></item>
    ///   <item><description>VaryColors &lt;c:varyColors></description></item>
    ///   <item><description>LineChartSeries &lt;c:ser></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>DropLines &lt;c:dropLines></description></item>
    ///   <item><description>GapDepth &lt;c:gapDepth></description></item>
    ///   <item><description>AxisId &lt;c:axId></description></item>
    ///   <item><description>Line3DChartExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Line3DChart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Line3DChart class.
        /// </summary>
        public Line3DChart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line3DChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Line3DChart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line3DChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Line3DChart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line3DChart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Line3DChart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "line3DChart");
            builder.AddChild<Grouping>();
            builder.AddChild<VaryColors>();
            builder.AddChild<LineChartSeries>();
            builder.AddChild<DataLabels>();
            builder.AddChild<DropLines>();
            builder.AddChild<GapDepth>();
            builder.AddChild<AxisId>();
            builder.AddChild<Line3DChartExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Grouping), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.VaryColors), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries), 0, 0),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DropLines), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.GapDepth), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisId), 3, 3),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Grouping.</para>
        /// <para>Represents the following element tag in the schema: c:grouping.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Grouping Grouping
        {
            get => GetElement<Grouping>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>VaryColors.</para>
        /// <para>Represents the following element tag in the schema: c:varyColors.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public VaryColors VaryColors
        {
            get => GetElement<VaryColors>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Line3DChart>(deep);
    }

    /// <summary>
    /// <para>Stock Charts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:stockChart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineChartSeries &lt;c:ser></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>DropLines &lt;c:dropLines></description></item>
    ///   <item><description>HighLowLines &lt;c:hiLowLines></description></item>
    ///   <item><description>UpDownBars &lt;c:upDownBars></description></item>
    ///   <item><description>AxisId &lt;c:axId></description></item>
    ///   <item><description>StockChartExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class StockChart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StockChart class.
        /// </summary>
        public StockChart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StockChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StockChart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StockChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StockChart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StockChart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StockChart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "stockChart");
            builder.AddChild<LineChartSeries>();
            builder.AddChild<DataLabels>();
            builder.AddChild<DropLines>();
            builder.AddChild<HighLowLines>();
            builder.AddChild<UpDownBars>();
            builder.AddChild<AxisId>();
            builder.AddChild<StockChartExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries), 3, 4),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DropLines), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.HighLowLines), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.UpDownBars), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisId), 2, 2),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StockChartExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StockChart>(deep);
    }

    /// <summary>
    /// <para>Radar Charts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:radarChart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RadarStyle &lt;c:radarStyle></description></item>
    ///   <item><description>VaryColors &lt;c:varyColors></description></item>
    ///   <item><description>RadarChartSeries &lt;c:ser></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>AxisId &lt;c:axId></description></item>
    ///   <item><description>RadarChartExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class RadarChart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RadarChart class.
        /// </summary>
        public RadarChart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadarChart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadarChart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RadarChart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "radarChart");
            builder.AddChild<RadarStyle>();
            builder.AddChild<VaryColors>();
            builder.AddChild<RadarChartSeries>();
            builder.AddChild<DataLabels>();
            builder.AddChild<AxisId>();
            builder.AddChild<RadarChartExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.RadarStyle), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.VaryColors), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.RadarChartSeries), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisId), 2, 2),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>RadarStyle.</para>
        /// <para>Represents the following element tag in the schema: c:radarStyle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public RadarStyle RadarStyle
        {
            get => GetElement<RadarStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>VaryColors.</para>
        /// <para>Represents the following element tag in the schema: c:varyColors.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public VaryColors VaryColors
        {
            get => GetElement<VaryColors>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarChart>(deep);
    }

    /// <summary>
    /// <para>Scatter Charts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:scatterChart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ScatterStyle &lt;c:scatterStyle></description></item>
    ///   <item><description>VaryColors &lt;c:varyColors></description></item>
    ///   <item><description>ScatterChartSeries &lt;c:ser></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>AxisId &lt;c:axId></description></item>
    ///   <item><description>ScatterChartExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ScatterChart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ScatterChart class.
        /// </summary>
        public ScatterChart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScatterChart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScatterChart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ScatterChart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "scatterChart");
            builder.AddChild<ScatterStyle>();
            builder.AddChild<VaryColors>();
            builder.AddChild<ScatterChartSeries>();
            builder.AddChild<DataLabels>();
            builder.AddChild<AxisId>();
            builder.AddChild<ScatterChartExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ScatterStyle), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.VaryColors), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisId), 2, 2),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>ScatterStyle.</para>
        /// <para>Represents the following element tag in the schema: c:scatterStyle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ScatterStyle ScatterStyle
        {
            get => GetElement<ScatterStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>VaryColors.</para>
        /// <para>Represents the following element tag in the schema: c:varyColors.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public VaryColors VaryColors
        {
            get => GetElement<VaryColors>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterChart>(deep);
    }

    /// <summary>
    /// <para>Pie Charts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:pieChart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>VaryColors &lt;c:varyColors></description></item>
    ///   <item><description>PieChartSeries &lt;c:ser></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>FirstSliceAngle &lt;c:firstSliceAng></description></item>
    ///   <item><description>PieChartExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class PieChart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PieChart class.
        /// </summary>
        public PieChart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PieChart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PieChart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PieChart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "pieChart");
            builder.AddChild<VaryColors>();
            builder.AddChild<PieChartSeries>();
            builder.AddChild<DataLabels>();
            builder.AddChild<FirstSliceAngle>();
            builder.AddChild<PieChartExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.VaryColors), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries), 0, 0),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.FirstSliceAngle), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PieChartExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>VaryColors.</para>
        /// <para>Represents the following element tag in the schema: c:varyColors.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public VaryColors VaryColors
        {
            get => GetElement<VaryColors>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PieChart>(deep);
    }

    /// <summary>
    /// <para>3D Pie Charts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:pie3DChart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>VaryColors &lt;c:varyColors></description></item>
    ///   <item><description>PieChartSeries &lt;c:ser></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>Pie3DChartExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Pie3DChart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Pie3DChart class.
        /// </summary>
        public Pie3DChart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Pie3DChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Pie3DChart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Pie3DChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Pie3DChart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Pie3DChart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Pie3DChart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "pie3DChart");
            builder.AddChild<VaryColors>();
            builder.AddChild<PieChartSeries>();
            builder.AddChild<DataLabels>();
            builder.AddChild<Pie3DChartExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.VaryColors), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries), 0, 0),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>VaryColors.</para>
        /// <para>Represents the following element tag in the schema: c:varyColors.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public VaryColors VaryColors
        {
            get => GetElement<VaryColors>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Pie3DChart>(deep);
    }

    /// <summary>
    /// <para>Doughnut Charts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:doughnutChart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>VaryColors &lt;c:varyColors></description></item>
    ///   <item><description>PieChartSeries &lt;c:ser></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>FirstSliceAngle &lt;c:firstSliceAng></description></item>
    ///   <item><description>HoleSize &lt;c:holeSize></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class DoughnutChart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DoughnutChart class.
        /// </summary>
        public DoughnutChart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DoughnutChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DoughnutChart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DoughnutChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DoughnutChart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DoughnutChart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DoughnutChart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "doughnutChart");
            builder.AddChild<VaryColors>();
            builder.AddChild<PieChartSeries>();
            builder.AddChild<DataLabels>();
            builder.AddChild<FirstSliceAngle>();
            builder.AddChild<HoleSize>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.VaryColors), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries), 0, 0),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.FirstSliceAngle), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.HoleSize), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>VaryColors.</para>
        /// <para>Represents the following element tag in the schema: c:varyColors.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public VaryColors VaryColors
        {
            get => GetElement<VaryColors>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DoughnutChart>(deep);
    }

    /// <summary>
    /// <para>Bar Charts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:barChart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BarDirection &lt;c:barDir></description></item>
    ///   <item><description>BarGrouping &lt;c:grouping></description></item>
    ///   <item><description>VaryColors &lt;c:varyColors></description></item>
    ///   <item><description>BarChartSeries &lt;c:ser></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>GapWidth &lt;c:gapWidth></description></item>
    ///   <item><description>Overlap &lt;c:overlap></description></item>
    ///   <item><description>SeriesLines &lt;c:serLines></description></item>
    ///   <item><description>AxisId &lt;c:axId></description></item>
    ///   <item><description>BarChartExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class BarChart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BarChart class.
        /// </summary>
        public BarChart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarChart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarChart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BarChart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "barChart");
            builder.AddChild<BarDirection>();
            builder.AddChild<BarGrouping>();
            builder.AddChild<VaryColors>();
            builder.AddChild<BarChartSeries>();
            builder.AddChild<DataLabels>();
            builder.AddChild<GapWidth>();
            builder.AddChild<Overlap>();
            builder.AddChild<SeriesLines>();
            builder.AddChild<AxisId>();
            builder.AddChild<BarChartExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarDirection), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarGrouping), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.VaryColors), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries), 0, 0),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.GapWidth), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Overlap), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesLines), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisId), 2, 2),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarChartExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Bar Direction.</para>
        /// <para>Represents the following element tag in the schema: c:barDir.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public BarDirection BarDirection
        {
            get => GetElement<BarDirection>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Bar Grouping.</para>
        /// <para>Represents the following element tag in the schema: c:grouping.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public BarGrouping BarGrouping
        {
            get => GetElement<BarGrouping>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>VaryColors.</para>
        /// <para>Represents the following element tag in the schema: c:varyColors.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public VaryColors VaryColors
        {
            get => GetElement<VaryColors>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarChart>(deep);
    }

    /// <summary>
    /// <para>3D Bar Charts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:bar3DChart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BarDirection &lt;c:barDir></description></item>
    ///   <item><description>BarGrouping &lt;c:grouping></description></item>
    ///   <item><description>VaryColors &lt;c:varyColors></description></item>
    ///   <item><description>BarChartSeries &lt;c:ser></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>GapWidth &lt;c:gapWidth></description></item>
    ///   <item><description>GapDepth &lt;c:gapDepth></description></item>
    ///   <item><description>Shape &lt;c:shape></description></item>
    ///   <item><description>AxisId &lt;c:axId></description></item>
    ///   <item><description>Bar3DChartExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Bar3DChart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Bar3DChart class.
        /// </summary>
        public Bar3DChart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Bar3DChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Bar3DChart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Bar3DChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Bar3DChart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Bar3DChart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Bar3DChart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "bar3DChart");
            builder.AddChild<BarDirection>();
            builder.AddChild<BarGrouping>();
            builder.AddChild<VaryColors>();
            builder.AddChild<BarChartSeries>();
            builder.AddChild<DataLabels>();
            builder.AddChild<GapWidth>();
            builder.AddChild<GapDepth>();
            builder.AddChild<Shape>();
            builder.AddChild<AxisId>();
            builder.AddChild<Bar3DChartExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarDirection), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarGrouping), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.VaryColors), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarChartSeries), 0, 0),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.GapWidth), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.GapDepth), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Shape), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisId), 2, 3),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Bar Direction.</para>
        /// <para>Represents the following element tag in the schema: c:barDir.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public BarDirection BarDirection
        {
            get => GetElement<BarDirection>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Bar Grouping.</para>
        /// <para>Represents the following element tag in the schema: c:grouping.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public BarGrouping BarGrouping
        {
            get => GetElement<BarGrouping>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>VaryColors.</para>
        /// <para>Represents the following element tag in the schema: c:varyColors.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public VaryColors VaryColors
        {
            get => GetElement<VaryColors>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bar3DChart>(deep);
    }

    /// <summary>
    /// <para>Pie of Pie or Bar of Pie Charts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ofPieChart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OfPieType &lt;c:ofPieType></description></item>
    ///   <item><description>VaryColors &lt;c:varyColors></description></item>
    ///   <item><description>PieChartSeries &lt;c:ser></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>GapWidth &lt;c:gapWidth></description></item>
    ///   <item><description>SplitType &lt;c:splitType></description></item>
    ///   <item><description>SplitPosition &lt;c:splitPos></description></item>
    ///   <item><description>CustomSplit &lt;c:custSplit></description></item>
    ///   <item><description>SecondPieSize &lt;c:secondPieSize></description></item>
    ///   <item><description>SeriesLines &lt;c:serLines></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class OfPieChart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfPieChart class.
        /// </summary>
        public OfPieChart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfPieChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfPieChart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfPieChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfPieChart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfPieChart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OfPieChart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ofPieChart");
            builder.AddChild<OfPieType>();
            builder.AddChild<VaryColors>();
            builder.AddChild<PieChartSeries>();
            builder.AddChild<DataLabels>();
            builder.AddChild<GapWidth>();
            builder.AddChild<SplitType>();
            builder.AddChild<SplitPosition>();
            builder.AddChild<CustomSplit>();
            builder.AddChild<SecondPieSize>();
            builder.AddChild<SeriesLines>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.OfPieType), 1, 1),
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.VaryColors), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries), 0, 0),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.GapWidth), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SplitType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SplitPosition), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CustomSplit), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SecondPieSize), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesLines), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Pie of Pie or Bar of Pie Type.</para>
        /// <para>Represents the following element tag in the schema: c:ofPieType.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public OfPieType OfPieType
        {
            get => GetElement<OfPieType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>VaryColors.</para>
        /// <para>Represents the following element tag in the schema: c:varyColors.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public VaryColors VaryColors
        {
            get => GetElement<VaryColors>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfPieChart>(deep);
    }

    /// <summary>
    /// <para>Surface Charts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:surfaceChart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Wireframe &lt;c:wireframe></description></item>
    ///   <item><description>SurfaceChartSeries &lt;c:ser></description></item>
    ///   <item><description>BandFormats &lt;c:bandFmts></description></item>
    ///   <item><description>AxisId &lt;c:axId></description></item>
    ///   <item><description>SurfaceChartExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class SurfaceChart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SurfaceChart class.
        /// </summary>
        public SurfaceChart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurfaceChart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurfaceChart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SurfaceChart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "surfaceChart");
            builder.AddChild<Wireframe>();
            builder.AddChild<SurfaceChartSeries>();
            builder.AddChild<BandFormats>();
            builder.AddChild<AxisId>();
            builder.AddChild<SurfaceChartExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Wireframe), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries), 0, 0),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BandFormats), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisId), 2, 3),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Wireframe.</para>
        /// <para>Represents the following element tag in the schema: c:wireframe.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Wireframe Wireframe
        {
            get => GetElement<Wireframe>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurfaceChart>(deep);
    }

    /// <summary>
    /// <para>3D Surface Charts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:surface3DChart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Wireframe &lt;c:wireframe></description></item>
    ///   <item><description>VaryColors &lt;c:varyColors></description></item>
    ///   <item><description>SurfaceChartSeries &lt;c:ser></description></item>
    ///   <item><description>BandFormats &lt;c:bandFmts></description></item>
    ///   <item><description>AxisId &lt;c:axId></description></item>
    ///   <item><description>Surface3DChartExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Surface3DChart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Surface3DChart class.
        /// </summary>
        public Surface3DChart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Surface3DChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Surface3DChart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Surface3DChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Surface3DChart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Surface3DChart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Surface3DChart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "surface3DChart");
            builder.AddChild<Wireframe>();
            builder.AddChild<VaryColors>();
            builder.AddChild<SurfaceChartSeries>();
            builder.AddChild<BandFormats>();
            builder.AddChild<AxisId>();
            builder.AddChild<Surface3DChartExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Wireframe), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.VaryColors), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BandFormats), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisId), 3, 3),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Wireframe.</para>
        /// <para>Represents the following element tag in the schema: c:wireframe.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Wireframe Wireframe
        {
            get => GetElement<Wireframe>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>VaryColors.</para>
        /// <para>Represents the following element tag in the schema: c:varyColors.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public VaryColors VaryColors
        {
            get => GetElement<VaryColors>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Surface3DChart>(deep);
    }

    /// <summary>
    /// <para>Bubble Charts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:bubbleChart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>VaryColors &lt;c:varyColors></description></item>
    ///   <item><description>BubbleChartSeries &lt;c:ser></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>Bubble3D &lt;c:bubble3D></description></item>
    ///   <item><description>BubbleScale &lt;c:bubbleScale></description></item>
    ///   <item><description>ShowNegativeBubbles &lt;c:showNegBubbles></description></item>
    ///   <item><description>SizeRepresents &lt;c:sizeRepresents></description></item>
    ///   <item><description>AxisId &lt;c:axId></description></item>
    ///   <item><description>BubbleChartExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class BubbleChart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BubbleChart class.
        /// </summary>
        public BubbleChart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleChart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleChart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BubbleChart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "bubbleChart");
            builder.AddChild<VaryColors>();
            builder.AddChild<BubbleChartSeries>();
            builder.AddChild<DataLabels>();
            builder.AddChild<Bubble3D>();
            builder.AddChild<BubbleScale>();
            builder.AddChild<ShowNegativeBubbles>();
            builder.AddChild<SizeRepresents>();
            builder.AddChild<AxisId>();
            builder.AddChild<BubbleChartExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.VaryColors), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleChartSeries), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bubble3D), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleScale), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowNegativeBubbles), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SizeRepresents), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisId), 2, 2),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>VaryColors.</para>
        /// <para>Represents the following element tag in the schema: c:varyColors.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public VaryColors VaryColors
        {
            get => GetElement<VaryColors>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleChart>(deep);
    }

    /// <summary>
    /// <para>Value Axis.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:valAx.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AxisId &lt;c:axId></description></item>
    ///   <item><description>Scaling &lt;c:scaling></description></item>
    ///   <item><description>Delete &lt;c:delete></description></item>
    ///   <item><description>AxisPosition &lt;c:axPos></description></item>
    ///   <item><description>MajorGridlines &lt;c:majorGridlines></description></item>
    ///   <item><description>MinorGridlines &lt;c:minorGridlines></description></item>
    ///   <item><description>Title &lt;c:title></description></item>
    ///   <item><description>NumberingFormat &lt;c:numFmt></description></item>
    ///   <item><description>MajorTickMark &lt;c:majorTickMark></description></item>
    ///   <item><description>MinorTickMark &lt;c:minorTickMark></description></item>
    ///   <item><description>TickLabelPosition &lt;c:tickLblPos></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>TextProperties &lt;c:txPr></description></item>
    ///   <item><description>CrossingAxis &lt;c:crossAx></description></item>
    ///   <item><description>Crosses &lt;c:crosses></description></item>
    ///   <item><description>CrossesAt &lt;c:crossesAt></description></item>
    ///   <item><description>CrossBetween &lt;c:crossBetween></description></item>
    ///   <item><description>MajorUnit &lt;c:majorUnit></description></item>
    ///   <item><description>MinorUnit &lt;c:minorUnit></description></item>
    ///   <item><description>DisplayUnits &lt;c:dispUnits></description></item>
    ///   <item><description>ValAxExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ValueAxis : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ValueAxis class.
        /// </summary>
        public ValueAxis() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValueAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ValueAxis(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValueAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ValueAxis(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValueAxis class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ValueAxis(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "valAx");
            builder.AddChild<AxisId>();
            builder.AddChild<Scaling>();
            builder.AddChild<Delete>();
            builder.AddChild<AxisPosition>();
            builder.AddChild<MajorGridlines>();
            builder.AddChild<MinorGridlines>();
            builder.AddChild<Title>();
            builder.AddChild<NumberingFormat>();
            builder.AddChild<MajorTickMark>();
            builder.AddChild<MinorTickMark>();
            builder.AddChild<TickLabelPosition>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<TextProperties>();
            builder.AddChild<CrossingAxis>();
            builder.AddChild<Crosses>();
            builder.AddChild<CrossesAt>();
            builder.AddChild<CrossBetween>();
            builder.AddChild<MajorUnit>();
            builder.AddChild<MinorUnit>();
            builder.AddChild<DisplayUnits>();
            builder.AddChild<ValAxExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisId), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Scaling), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Delete), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisPosition), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Title), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MajorTickMark), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MinorTickMark), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TickLabelPosition), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CrossingAxis), 1, 1),
                        new CompositeParticle(ParticleType.Choice, 0, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Crosses), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CrossesAt), 1, 1)
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CrossBetween), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MajorUnit), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MinorUnit), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ValAxExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Axis ID.</para>
        /// <para>Represents the following element tag in the schema: c:axId.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public AxisId AxisId
        {
            get => GetElement<AxisId>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scaling.</para>
        /// <para>Represents the following element tag in the schema: c:scaling.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Scaling Scaling
        {
            get => GetElement<Scaling>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Delete.</para>
        /// <para>Represents the following element tag in the schema: c:delete.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Delete Delete
        {
            get => GetElement<Delete>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Axis Position.</para>
        /// <para>Represents the following element tag in the schema: c:axPos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public AxisPosition AxisPosition
        {
            get => GetElement<AxisPosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Major Gridlines.</para>
        /// <para>Represents the following element tag in the schema: c:majorGridlines.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MajorGridlines MajorGridlines
        {
            get => GetElement<MajorGridlines>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Minor Gridlines.</para>
        /// <para>Represents the following element tag in the schema: c:minorGridlines.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MinorGridlines MinorGridlines
        {
            get => GetElement<MinorGridlines>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Title.</para>
        /// <para>Represents the following element tag in the schema: c:title.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Title Title
        {
            get => GetElement<Title>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number Format.</para>
        /// <para>Represents the following element tag in the schema: c:numFmt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public NumberingFormat NumberingFormat
        {
            get => GetElement<NumberingFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Major Tick Mark.</para>
        /// <para>Represents the following element tag in the schema: c:majorTickMark.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MajorTickMark MajorTickMark
        {
            get => GetElement<MajorTickMark>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Minor Tick Mark.</para>
        /// <para>Represents the following element tag in the schema: c:minorTickMark.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MinorTickMark MinorTickMark
        {
            get => GetElement<MinorTickMark>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Tick Label Position.</para>
        /// <para>Represents the following element tag in the schema: c:tickLblPos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public TickLabelPosition TickLabelPosition
        {
            get => GetElement<TickLabelPosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TextProperties.</para>
        /// <para>Represents the following element tag in the schema: c:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public TextProperties TextProperties
        {
            get => GetElement<TextProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Crossing Axis ID.</para>
        /// <para>Represents the following element tag in the schema: c:crossAx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public CrossingAxis CrossingAxis
        {
            get => GetElement<CrossingAxis>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ValueAxis>(deep);
    }

    /// <summary>
    /// <para>Category Axis Data.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:catAx.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AxisId &lt;c:axId></description></item>
    ///   <item><description>Scaling &lt;c:scaling></description></item>
    ///   <item><description>Delete &lt;c:delete></description></item>
    ///   <item><description>AxisPosition &lt;c:axPos></description></item>
    ///   <item><description>MajorGridlines &lt;c:majorGridlines></description></item>
    ///   <item><description>MinorGridlines &lt;c:minorGridlines></description></item>
    ///   <item><description>Title &lt;c:title></description></item>
    ///   <item><description>NumberingFormat &lt;c:numFmt></description></item>
    ///   <item><description>MajorTickMark &lt;c:majorTickMark></description></item>
    ///   <item><description>MinorTickMark &lt;c:minorTickMark></description></item>
    ///   <item><description>TickLabelPosition &lt;c:tickLblPos></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>TextProperties &lt;c:txPr></description></item>
    ///   <item><description>CrossingAxis &lt;c:crossAx></description></item>
    ///   <item><description>Crosses &lt;c:crosses></description></item>
    ///   <item><description>CrossesAt &lt;c:crossesAt></description></item>
    ///   <item><description>AutoLabeled &lt;c:auto></description></item>
    ///   <item><description>LabelAlignment &lt;c:lblAlgn></description></item>
    ///   <item><description>LabelOffset &lt;c:lblOffset></description></item>
    ///   <item><description>TickLabelSkip &lt;c:tickLblSkip></description></item>
    ///   <item><description>TickMarkSkip &lt;c:tickMarkSkip></description></item>
    ///   <item><description>NoMultiLevelLabels &lt;c:noMultiLvlLbl></description></item>
    ///   <item><description>CatAxExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class CategoryAxis : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CategoryAxis class.
        /// </summary>
        public CategoryAxis() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryAxis(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryAxis(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryAxis class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CategoryAxis(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "catAx");
            builder.AddChild<AxisId>();
            builder.AddChild<Scaling>();
            builder.AddChild<Delete>();
            builder.AddChild<AxisPosition>();
            builder.AddChild<MajorGridlines>();
            builder.AddChild<MinorGridlines>();
            builder.AddChild<Title>();
            builder.AddChild<NumberingFormat>();
            builder.AddChild<MajorTickMark>();
            builder.AddChild<MinorTickMark>();
            builder.AddChild<TickLabelPosition>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<TextProperties>();
            builder.AddChild<CrossingAxis>();
            builder.AddChild<Crosses>();
            builder.AddChild<CrossesAt>();
            builder.AddChild<AutoLabeled>();
            builder.AddChild<LabelAlignment>();
            builder.AddChild<LabelOffset>();
            builder.AddChild<TickLabelSkip>();
            builder.AddChild<TickMarkSkip>();
            builder.AddChild<NoMultiLevelLabels>();
            builder.AddChild<CatAxExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisId), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Scaling), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Delete), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisPosition), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Title), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MajorTickMark), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MinorTickMark), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TickLabelPosition), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CrossingAxis), 1, 1),
                        new CompositeParticle(ParticleType.Choice, 0, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Crosses), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CrossesAt), 1, 1)
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AutoLabeled), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LabelAlignment), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LabelOffset), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TickLabelSkip), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TickMarkSkip), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NoMultiLevelLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Axis ID.</para>
        /// <para>Represents the following element tag in the schema: c:axId.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public AxisId AxisId
        {
            get => GetElement<AxisId>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scaling.</para>
        /// <para>Represents the following element tag in the schema: c:scaling.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Scaling Scaling
        {
            get => GetElement<Scaling>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Delete.</para>
        /// <para>Represents the following element tag in the schema: c:delete.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Delete Delete
        {
            get => GetElement<Delete>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Axis Position.</para>
        /// <para>Represents the following element tag in the schema: c:axPos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public AxisPosition AxisPosition
        {
            get => GetElement<AxisPosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Major Gridlines.</para>
        /// <para>Represents the following element tag in the schema: c:majorGridlines.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MajorGridlines MajorGridlines
        {
            get => GetElement<MajorGridlines>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Minor Gridlines.</para>
        /// <para>Represents the following element tag in the schema: c:minorGridlines.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MinorGridlines MinorGridlines
        {
            get => GetElement<MinorGridlines>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Title.</para>
        /// <para>Represents the following element tag in the schema: c:title.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Title Title
        {
            get => GetElement<Title>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number Format.</para>
        /// <para>Represents the following element tag in the schema: c:numFmt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public NumberingFormat NumberingFormat
        {
            get => GetElement<NumberingFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Major Tick Mark.</para>
        /// <para>Represents the following element tag in the schema: c:majorTickMark.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MajorTickMark MajorTickMark
        {
            get => GetElement<MajorTickMark>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Minor Tick Mark.</para>
        /// <para>Represents the following element tag in the schema: c:minorTickMark.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MinorTickMark MinorTickMark
        {
            get => GetElement<MinorTickMark>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Tick Label Position.</para>
        /// <para>Represents the following element tag in the schema: c:tickLblPos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public TickLabelPosition TickLabelPosition
        {
            get => GetElement<TickLabelPosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TextProperties.</para>
        /// <para>Represents the following element tag in the schema: c:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public TextProperties TextProperties
        {
            get => GetElement<TextProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Crossing Axis ID.</para>
        /// <para>Represents the following element tag in the schema: c:crossAx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public CrossingAxis CrossingAxis
        {
            get => GetElement<CrossingAxis>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryAxis>(deep);
    }

    /// <summary>
    /// <para>Date Axis.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:dateAx.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AxisId &lt;c:axId></description></item>
    ///   <item><description>Scaling &lt;c:scaling></description></item>
    ///   <item><description>Delete &lt;c:delete></description></item>
    ///   <item><description>AxisPosition &lt;c:axPos></description></item>
    ///   <item><description>MajorGridlines &lt;c:majorGridlines></description></item>
    ///   <item><description>MinorGridlines &lt;c:minorGridlines></description></item>
    ///   <item><description>Title &lt;c:title></description></item>
    ///   <item><description>NumberingFormat &lt;c:numFmt></description></item>
    ///   <item><description>MajorTickMark &lt;c:majorTickMark></description></item>
    ///   <item><description>MinorTickMark &lt;c:minorTickMark></description></item>
    ///   <item><description>TickLabelPosition &lt;c:tickLblPos></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>TextProperties &lt;c:txPr></description></item>
    ///   <item><description>CrossingAxis &lt;c:crossAx></description></item>
    ///   <item><description>Crosses &lt;c:crosses></description></item>
    ///   <item><description>CrossesAt &lt;c:crossesAt></description></item>
    ///   <item><description>AutoLabeled &lt;c:auto></description></item>
    ///   <item><description>LabelOffset &lt;c:lblOffset></description></item>
    ///   <item><description>BaseTimeUnit &lt;c:baseTimeUnit></description></item>
    ///   <item><description>MajorUnit &lt;c:majorUnit></description></item>
    ///   <item><description>MajorTimeUnit &lt;c:majorTimeUnit></description></item>
    ///   <item><description>MinorUnit &lt;c:minorUnit></description></item>
    ///   <item><description>MinorTimeUnit &lt;c:minorTimeUnit></description></item>
    ///   <item><description>DateAxExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class DateAxis : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DateAxis class.
        /// </summary>
        public DateAxis() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DateAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DateAxis(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DateAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DateAxis(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DateAxis class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DateAxis(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "dateAx");
            builder.AddChild<AxisId>();
            builder.AddChild<Scaling>();
            builder.AddChild<Delete>();
            builder.AddChild<AxisPosition>();
            builder.AddChild<MajorGridlines>();
            builder.AddChild<MinorGridlines>();
            builder.AddChild<Title>();
            builder.AddChild<NumberingFormat>();
            builder.AddChild<MajorTickMark>();
            builder.AddChild<MinorTickMark>();
            builder.AddChild<TickLabelPosition>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<TextProperties>();
            builder.AddChild<CrossingAxis>();
            builder.AddChild<Crosses>();
            builder.AddChild<CrossesAt>();
            builder.AddChild<AutoLabeled>();
            builder.AddChild<LabelOffset>();
            builder.AddChild<BaseTimeUnit>();
            builder.AddChild<MajorUnit>();
            builder.AddChild<MajorTimeUnit>();
            builder.AddChild<MinorUnit>();
            builder.AddChild<MinorTimeUnit>();
            builder.AddChild<DateAxExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisId), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Scaling), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Delete), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisPosition), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Title), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MajorTickMark), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MinorTickMark), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TickLabelPosition), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CrossingAxis), 1, 1),
                        new CompositeParticle(ParticleType.Choice, 0, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Crosses), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CrossesAt), 1, 1)
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AutoLabeled), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LabelOffset), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BaseTimeUnit), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MajorUnit), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MajorTimeUnit), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MinorUnit), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MinorTimeUnit), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Axis ID.</para>
        /// <para>Represents the following element tag in the schema: c:axId.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public AxisId AxisId
        {
            get => GetElement<AxisId>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scaling.</para>
        /// <para>Represents the following element tag in the schema: c:scaling.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Scaling Scaling
        {
            get => GetElement<Scaling>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Delete.</para>
        /// <para>Represents the following element tag in the schema: c:delete.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Delete Delete
        {
            get => GetElement<Delete>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Axis Position.</para>
        /// <para>Represents the following element tag in the schema: c:axPos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public AxisPosition AxisPosition
        {
            get => GetElement<AxisPosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Major Gridlines.</para>
        /// <para>Represents the following element tag in the schema: c:majorGridlines.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MajorGridlines MajorGridlines
        {
            get => GetElement<MajorGridlines>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Minor Gridlines.</para>
        /// <para>Represents the following element tag in the schema: c:minorGridlines.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MinorGridlines MinorGridlines
        {
            get => GetElement<MinorGridlines>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Title.</para>
        /// <para>Represents the following element tag in the schema: c:title.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Title Title
        {
            get => GetElement<Title>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number Format.</para>
        /// <para>Represents the following element tag in the schema: c:numFmt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public NumberingFormat NumberingFormat
        {
            get => GetElement<NumberingFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Major Tick Mark.</para>
        /// <para>Represents the following element tag in the schema: c:majorTickMark.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MajorTickMark MajorTickMark
        {
            get => GetElement<MajorTickMark>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Minor Tick Mark.</para>
        /// <para>Represents the following element tag in the schema: c:minorTickMark.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MinorTickMark MinorTickMark
        {
            get => GetElement<MinorTickMark>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Tick Label Position.</para>
        /// <para>Represents the following element tag in the schema: c:tickLblPos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public TickLabelPosition TickLabelPosition
        {
            get => GetElement<TickLabelPosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TextProperties.</para>
        /// <para>Represents the following element tag in the schema: c:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public TextProperties TextProperties
        {
            get => GetElement<TextProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Crossing Axis ID.</para>
        /// <para>Represents the following element tag in the schema: c:crossAx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public CrossingAxis CrossingAxis
        {
            get => GetElement<CrossingAxis>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DateAxis>(deep);
    }

    /// <summary>
    /// <para>Series Axis.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:serAx.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AxisId &lt;c:axId></description></item>
    ///   <item><description>Scaling &lt;c:scaling></description></item>
    ///   <item><description>Delete &lt;c:delete></description></item>
    ///   <item><description>AxisPosition &lt;c:axPos></description></item>
    ///   <item><description>MajorGridlines &lt;c:majorGridlines></description></item>
    ///   <item><description>MinorGridlines &lt;c:minorGridlines></description></item>
    ///   <item><description>Title &lt;c:title></description></item>
    ///   <item><description>NumberingFormat &lt;c:numFmt></description></item>
    ///   <item><description>MajorTickMark &lt;c:majorTickMark></description></item>
    ///   <item><description>MinorTickMark &lt;c:minorTickMark></description></item>
    ///   <item><description>TickLabelPosition &lt;c:tickLblPos></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>TextProperties &lt;c:txPr></description></item>
    ///   <item><description>CrossingAxis &lt;c:crossAx></description></item>
    ///   <item><description>Crosses &lt;c:crosses></description></item>
    ///   <item><description>CrossesAt &lt;c:crossesAt></description></item>
    ///   <item><description>TickLabelSkip &lt;c:tickLblSkip></description></item>
    ///   <item><description>TickMarkSkip &lt;c:tickMarkSkip></description></item>
    ///   <item><description>SerAxExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class SeriesAxis : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SeriesAxis class.
        /// </summary>
        public SeriesAxis() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SeriesAxis(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SeriesAxis(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesAxis class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SeriesAxis(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "serAx");
            builder.AddChild<AxisId>();
            builder.AddChild<Scaling>();
            builder.AddChild<Delete>();
            builder.AddChild<AxisPosition>();
            builder.AddChild<MajorGridlines>();
            builder.AddChild<MinorGridlines>();
            builder.AddChild<Title>();
            builder.AddChild<NumberingFormat>();
            builder.AddChild<MajorTickMark>();
            builder.AddChild<MinorTickMark>();
            builder.AddChild<TickLabelPosition>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<TextProperties>();
            builder.AddChild<CrossingAxis>();
            builder.AddChild<Crosses>();
            builder.AddChild<CrossesAt>();
            builder.AddChild<TickLabelSkip>();
            builder.AddChild<TickMarkSkip>();
            builder.AddChild<SerAxExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisId), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Scaling), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Delete), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AxisPosition), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Title), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MajorTickMark), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MinorTickMark), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TickLabelPosition), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CrossingAxis), 1, 1),
                        new CompositeParticle(ParticleType.Choice, 0, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Crosses), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CrossesAt), 1, 1)
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TickLabelSkip), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TickMarkSkip), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SerAxExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Axis ID.</para>
        /// <para>Represents the following element tag in the schema: c:axId.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public AxisId AxisId
        {
            get => GetElement<AxisId>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scaling.</para>
        /// <para>Represents the following element tag in the schema: c:scaling.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Scaling Scaling
        {
            get => GetElement<Scaling>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Delete.</para>
        /// <para>Represents the following element tag in the schema: c:delete.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Delete Delete
        {
            get => GetElement<Delete>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Axis Position.</para>
        /// <para>Represents the following element tag in the schema: c:axPos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public AxisPosition AxisPosition
        {
            get => GetElement<AxisPosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Major Gridlines.</para>
        /// <para>Represents the following element tag in the schema: c:majorGridlines.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MajorGridlines MajorGridlines
        {
            get => GetElement<MajorGridlines>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Minor Gridlines.</para>
        /// <para>Represents the following element tag in the schema: c:minorGridlines.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MinorGridlines MinorGridlines
        {
            get => GetElement<MinorGridlines>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Title.</para>
        /// <para>Represents the following element tag in the schema: c:title.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Title Title
        {
            get => GetElement<Title>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number Format.</para>
        /// <para>Represents the following element tag in the schema: c:numFmt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public NumberingFormat NumberingFormat
        {
            get => GetElement<NumberingFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Major Tick Mark.</para>
        /// <para>Represents the following element tag in the schema: c:majorTickMark.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MajorTickMark MajorTickMark
        {
            get => GetElement<MajorTickMark>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Minor Tick Mark.</para>
        /// <para>Represents the following element tag in the schema: c:minorTickMark.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MinorTickMark MinorTickMark
        {
            get => GetElement<MinorTickMark>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Tick Label Position.</para>
        /// <para>Represents the following element tag in the schema: c:tickLblPos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public TickLabelPosition TickLabelPosition
        {
            get => GetElement<TickLabelPosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TextProperties.</para>
        /// <para>Represents the following element tag in the schema: c:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public TextProperties TextProperties
        {
            get => GetElement<TextProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Crossing Axis ID.</para>
        /// <para>Represents the following element tag in the schema: c:crossAx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public CrossingAxis CrossingAxis
        {
            get => GetElement<CrossingAxis>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesAxis>(deep);
    }

    /// <summary>
    /// <para>Data Table.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:dTable.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ShowHorizontalBorder &lt;c:showHorzBorder></description></item>
    ///   <item><description>ShowVerticalBorder &lt;c:showVertBorder></description></item>
    ///   <item><description>ShowOutlineBorder &lt;c:showOutline></description></item>
    ///   <item><description>ShowKeys &lt;c:showKeys></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>TextProperties &lt;c:txPr></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class DataTable : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataTable class.
        /// </summary>
        public DataTable() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataTable class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataTable(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataTable class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataTable(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataTable class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataTable(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "dTable");
            builder.AddChild<ShowHorizontalBorder>();
            builder.AddChild<ShowVerticalBorder>();
            builder.AddChild<ShowOutlineBorder>();
            builder.AddChild<ShowKeys>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<TextProperties>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowHorizontalBorder), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowVerticalBorder), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowOutlineBorder), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowKeys), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Show Horizontal Border.</para>
        /// <para>Represents the following element tag in the schema: c:showHorzBorder.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ShowHorizontalBorder ShowHorizontalBorder
        {
            get => GetElement<ShowHorizontalBorder>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Show Vertical Border.</para>
        /// <para>Represents the following element tag in the schema: c:showVertBorder.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ShowVerticalBorder ShowVerticalBorder
        {
            get => GetElement<ShowVerticalBorder>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Show Outline Border.</para>
        /// <para>Represents the following element tag in the schema: c:showOutline.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ShowOutlineBorder ShowOutlineBorder
        {
            get => GetElement<ShowOutlineBorder>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Show Legend Keys.</para>
        /// <para>Represents the following element tag in the schema: c:showKeys.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ShowKeys ShowKeys
        {
            get => GetElement<ShowKeys>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text Properties.</para>
        /// <para>Represents the following element tag in the schema: c:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public TextProperties TextProperties
        {
            get => GetElement<TextProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataTable>(deep);
    }

    /// <summary>
    /// <para>First Slice Angle.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:firstSliceAng.</para>
    /// </summary>
    public partial class FirstSliceAngle : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the FirstSliceAngle class.
        /// </summary>
        public FirstSliceAngle() : base()
        {
        }

        /// <summary>
        /// <para>First Slice Angle Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public UInt16Value Val
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "firstSliceAng");
            builder.AddElement<FirstSliceAngle>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (360L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstSliceAngle>(deep);
    }

    /// <summary>
    /// <para>Hole Size.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:holeSize.</para>
    /// </summary>
    public partial class HoleSize : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the HoleSize class.
        /// </summary>
        public HoleSize() : base()
        {
        }

        /// <summary>
        /// <para>Hole Size Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public ByteValue Val
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "holeSize");
            builder.AddElement<HoleSize>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (90L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HoleSize>(deep);
    }

    /// <summary>
    /// <para>String Point.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:pt.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NumericValue &lt;c:v></description></item>
    /// </list>
    /// </remark>
    public partial class StringPoint : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StringPoint class.
        /// </summary>
        public StringPoint() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringPoint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StringPoint(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringPoint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StringPoint(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringPoint class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StringPoint(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Index</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        public UInt32Value Index
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "pt");
            builder.AddChild<NumericValue>();
            builder.AddElement<StringPoint>()
.AddAttribute(0, "idx", a => a.Index, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumericValue), 1, 1)
            };
            builder.AddConstraint(new AttributeValueRangeConstraint(0 /*:idx*/, true, 0, true, 2147483647, true));
        }

        /// <summary>
        /// <para>Text Value.</para>
        /// <para>Represents the following element tag in the schema: c:v.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public NumericValue NumericValue
        {
            get => GetElement<NumericValue>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringPoint>(deep);
    }

    /// <summary>
    /// <para>Thickness.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:thickness.</para>
    /// </summary>
    public partial class Thickness : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Thickness class.
        /// </summary>
        public Thickness() : base()
        {
        }

        /// <summary>
        /// <para>val</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public ByteValue Val
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "thickness");
            builder.AddElement<Thickness>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Thickness>(deep);
    }

    /// <summary>
    /// <para>Defines the StockChartExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension &lt;c15:filteredLineSeries></description></item>
    /// </list>
    /// </remark>
    public partial class StockChartExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StockChartExtension class.
        /// </summary>
        public StockChartExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StockChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StockChartExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StockChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StockChartExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StockChartExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StockChartExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension>();
            builder.AddElement<StockChartExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StockChartExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the PieChartExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries &lt;c15:filteredPieSeries></description></item>
    /// </list>
    /// </remark>
    public partial class PieChartExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PieChartExtension class.
        /// </summary>
        public PieChartExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PieChartExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PieChartExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChartExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PieChartExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries>();
            builder.AddElement<PieChartExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PieChartExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the Pie3DChartExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries &lt;c15:filteredPieSeries></description></item>
    /// </list>
    /// </remark>
    public partial class Pie3DChartExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Pie3DChartExtension class.
        /// </summary>
        public Pie3DChartExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Pie3DChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Pie3DChartExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Pie3DChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Pie3DChartExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Pie3DChartExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Pie3DChartExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries>();
            builder.AddElement<Pie3DChartExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Pie3DChartExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the NumRefExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference &lt;c15:fullRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference &lt;c15:levelRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference &lt;c15:formulaRef></description></item>
    /// </list>
    /// </remark>
    public partial class NumRefExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NumRefExtension class.
        /// </summary>
        public NumRefExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumRefExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumRefExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumRefExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumRefExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumRefExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NumRefExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference>();
            builder.AddElement<NumRefExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumRefExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the StrDataExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.AutoGeneneratedCategories &lt;c15:autoCat></description></item>
    /// </list>
    /// </remark>
    public partial class StrDataExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StrDataExtension class.
        /// </summary>
        public StrDataExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StrDataExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StrDataExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StrDataExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StrDataExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StrDataExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StrDataExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AutoGeneneratedCategories>();
            builder.AddElement<StrDataExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.AutoGeneneratedCategories), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrDataExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the StrRefExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference &lt;c15:fullRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference &lt;c15:levelRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference &lt;c15:formulaRef></description></item>
    /// </list>
    /// </remark>
    public partial class StrRefExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StrRefExtension class.
        /// </summary>
        public StrRefExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StrRefExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StrRefExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StrRefExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StrRefExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StrRefExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StrRefExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference>();
            builder.AddElement<StrRefExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrRefExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the MultiLvlStrRefExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference &lt;c15:fullRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference &lt;c15:levelRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference &lt;c15:formulaRef></description></item>
    /// </list>
    /// </remark>
    public partial class MultiLvlStrRefExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MultiLvlStrRefExtension class.
        /// </summary>
        public MultiLvlStrRefExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLvlStrRefExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MultiLvlStrRefExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLvlStrRefExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MultiLvlStrRefExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLvlStrRefExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MultiLvlStrRefExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference>();
            builder.AddElement<MultiLvlStrRefExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLvlStrRefExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the DLblExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable &lt;c15:dlblFieldTable></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.ExceptionForSave &lt;c15:xForSave></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowDataLabelsRange &lt;c15:showDataLabelsRange></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties &lt;c15:spPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout &lt;c15:layout></description></item>
    /// </list>
    /// </remark>
    public partial class DLblExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DLblExtension class.
        /// </summary>
        public DLblExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DLblExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DLblExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DLblExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DLblExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DLblExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DLblExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ExceptionForSave>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowDataLabelsRange>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout>();
            builder.AddElement<DLblExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ExceptionForSave), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowDataLabelsRange), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DLblExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the DLblsExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText &lt;c15:tx></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable &lt;c15:dlblFieldTable></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowDataLabelsRange &lt;c15:showDataLabelsRange></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties &lt;c15:spPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout &lt;c15:layout></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowLeaderLines &lt;c15:showLeaderLines></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines &lt;c15:leaderLines></description></item>
    /// </list>
    /// </remark>
    public partial class DLblsExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DLblsExtension class.
        /// </summary>
        public DLblsExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DLblsExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DLblsExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DLblsExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DLblsExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DLblsExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DLblsExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowDataLabelsRange>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowLeaderLines>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines>();
            builder.AddElement<DLblsExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTable), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowDataLabelsRange), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShapeProperties), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Layout), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.ShowLeaderLines), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.LeaderLines), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DLblsExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the LineSerExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle &lt;c15:filteredSeriesTitle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle &lt;c15:filteredCategoryTitle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange &lt;c15:datalabelsRange></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions &lt;c15:categoryFilterExceptions></description></item>
    /// </list>
    /// </remark>
    public partial class LineSerExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LineSerExtension class.
        /// </summary>
        public LineSerExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSerExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineSerExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSerExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineSerExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSerExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LineSerExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
            builder.AddElement<LineSerExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSerExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the ScatterSerExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle &lt;c15:filteredSeriesTitle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle &lt;c15:filteredCategoryTitle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange &lt;c15:datalabelsRange></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions &lt;c15:categoryFilterExceptions></description></item>
    /// </list>
    /// </remark>
    public partial class ScatterSerExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ScatterSerExtension class.
        /// </summary>
        public ScatterSerExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterSerExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScatterSerExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterSerExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScatterSerExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterSerExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ScatterSerExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
            builder.AddElement<ScatterSerExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterSerExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the RadarSerExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle &lt;c15:filteredSeriesTitle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle &lt;c15:filteredCategoryTitle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange &lt;c15:datalabelsRange></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions &lt;c15:categoryFilterExceptions></description></item>
    /// </list>
    /// </remark>
    public partial class RadarSerExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RadarSerExtension class.
        /// </summary>
        public RadarSerExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarSerExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadarSerExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarSerExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadarSerExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarSerExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RadarSerExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
            builder.AddElement<RadarSerExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarSerExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the AreaSerExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle &lt;c15:filteredSeriesTitle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle &lt;c15:filteredCategoryTitle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange &lt;c15:datalabelsRange></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions &lt;c15:categoryFilterExceptions></description></item>
    /// </list>
    /// </remark>
    public partial class AreaSerExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AreaSerExtension class.
        /// </summary>
        public AreaSerExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaSerExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AreaSerExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaSerExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AreaSerExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaSerExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AreaSerExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
            builder.AddElement<AreaSerExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AreaSerExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the PieSerExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle &lt;c15:filteredSeriesTitle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle &lt;c15:filteredCategoryTitle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange &lt;c15:datalabelsRange></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions &lt;c15:categoryFilterExceptions></description></item>
    /// </list>
    /// </remark>
    public partial class PieSerExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PieSerExtension class.
        /// </summary>
        public PieSerExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieSerExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PieSerExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieSerExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PieSerExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieSerExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PieSerExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
            builder.AddElement<PieSerExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PieSerExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the SurfaceSerExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle &lt;c15:filteredSeriesTitle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle &lt;c15:filteredCategoryTitle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions &lt;c15:categoryFilterExceptions></description></item>
    /// </list>
    /// </remark>
    public partial class SurfaceSerExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SurfaceSerExtension class.
        /// </summary>
        public SurfaceSerExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceSerExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurfaceSerExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceSerExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurfaceSerExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceSerExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SurfaceSerExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
            builder.AddElement<SurfaceSerExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurfaceSerExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the LineChartExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension &lt;c15:filteredLineSeries></description></item>
    /// </list>
    /// </remark>
    public partial class LineChartExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LineChartExtension class.
        /// </summary>
        public LineChartExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineChartExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineChartExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChartExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LineChartExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension>();
            builder.AddElement<LineChartExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineChartExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the Line3DChartExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension &lt;c15:filteredLineSeries></description></item>
    /// </list>
    /// </remark>
    public partial class Line3DChartExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Line3DChartExtension class.
        /// </summary>
        public Line3DChartExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line3DChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Line3DChartExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line3DChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Line3DChartExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line3DChartExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Line3DChartExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension>();
            builder.AddElement<Line3DChartExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Line3DChartExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the ScatterChartExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries &lt;c15:filteredScatterSeries></description></item>
    /// </list>
    /// </remark>
    public partial class ScatterChartExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ScatterChartExtension class.
        /// </summary>
        public ScatterChartExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScatterChartExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScatterChartExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChartExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ScatterChartExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries>();
            builder.AddElement<ScatterChartExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterChartExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the RadarChartExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries &lt;c15:filteredRadarSeries></description></item>
    /// </list>
    /// </remark>
    public partial class RadarChartExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RadarChartExtension class.
        /// </summary>
        public RadarChartExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadarChartExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadarChartExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChartExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RadarChartExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries>();
            builder.AddElement<RadarChartExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredRadarSeries), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarChartExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the BarChartExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries &lt;c15:filteredBarSeries></description></item>
    /// </list>
    /// </remark>
    public partial class BarChartExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BarChartExtension class.
        /// </summary>
        public BarChartExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarChartExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarChartExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChartExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BarChartExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries>();
            builder.AddElement<BarChartExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarChartExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the Bar3DChartExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries &lt;c15:filteredBarSeries></description></item>
    /// </list>
    /// </remark>
    public partial class Bar3DChartExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Bar3DChartExtension class.
        /// </summary>
        public Bar3DChartExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Bar3DChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Bar3DChartExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Bar3DChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Bar3DChartExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Bar3DChartExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Bar3DChartExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries>();
            builder.AddElement<Bar3DChartExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bar3DChartExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the AreaChartExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries &lt;c15:filteredAreaSeries></description></item>
    /// </list>
    /// </remark>
    public partial class AreaChartExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AreaChartExtension class.
        /// </summary>
        public AreaChartExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AreaChartExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AreaChartExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChartExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AreaChartExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries>();
            builder.AddElement<AreaChartExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AreaChartExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the Area3DChartExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries &lt;c15:filteredAreaSeries></description></item>
    /// </list>
    /// </remark>
    public partial class Area3DChartExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Area3DChartExtension class.
        /// </summary>
        public Area3DChartExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Area3DChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Area3DChartExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Area3DChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Area3DChartExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Area3DChartExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Area3DChartExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries>();
            builder.AddElement<Area3DChartExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Area3DChartExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the BubbleChartExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries &lt;c15:filteredBubbleSeries></description></item>
    /// </list>
    /// </remark>
    public partial class BubbleChartExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BubbleChartExtension class.
        /// </summary>
        public BubbleChartExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleChartExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleChartExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChartExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BubbleChartExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries>();
            builder.AddElement<BubbleChartExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBubbleSeries), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleChartExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the SurfaceChartExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries &lt;c15:filteredSurfaceSeries></description></item>
    /// </list>
    /// </remark>
    public partial class SurfaceChartExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SurfaceChartExtension class.
        /// </summary>
        public SurfaceChartExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurfaceChartExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurfaceChartExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChartExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SurfaceChartExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries>();
            builder.AddElement<SurfaceChartExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurfaceChartExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the Surface3DChartExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries &lt;c15:filteredSurfaceSeries></description></item>
    /// </list>
    /// </remark>
    public partial class Surface3DChartExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Surface3DChartExtension class.
        /// </summary>
        public Surface3DChartExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Surface3DChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Surface3DChartExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Surface3DChartExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Surface3DChartExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Surface3DChartExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Surface3DChartExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries>();
            builder.AddElement<Surface3DChartExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSurfaceSeries), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Surface3DChartExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the CatAxExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat &lt;c15:numFmt></description></item>
    /// </list>
    /// </remark>
    public partial class CatAxExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CatAxExtension class.
        /// </summary>
        public CatAxExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CatAxExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CatAxExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CatAxExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CatAxExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CatAxExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CatAxExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat>();
            builder.AddElement<CatAxExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CatAxExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the DateAxExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat &lt;c15:numFmt></description></item>
    /// </list>
    /// </remark>
    public partial class DateAxExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DateAxExtension class.
        /// </summary>
        public DateAxExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DateAxExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DateAxExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DateAxExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DateAxExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DateAxExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DateAxExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat>();
            builder.AddElement<DateAxExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DateAxExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the SerAxExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat &lt;c15:numFmt></description></item>
    /// </list>
    /// </remark>
    public partial class SerAxExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SerAxExtension class.
        /// </summary>
        public SerAxExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerAxExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SerAxExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerAxExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SerAxExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerAxExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SerAxExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat>();
            builder.AddElement<SerAxExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SerAxExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the ValAxExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat &lt;c15:numFmt></description></item>
    /// </list>
    /// </remark>
    public partial class ValAxExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ValAxExtension class.
        /// </summary>
        public ValAxExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValAxExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ValAxExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValAxExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ValAxExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValAxExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ValAxExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat>();
            builder.AddElement<ValAxExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.NumberingFormat), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ValAxExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the UpDownBars Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:upDownBars.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>GapWidth &lt;c:gapWidth></description></item>
    ///   <item><description>UpBars &lt;c:upBars></description></item>
    ///   <item><description>DownBars &lt;c:downBars></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class UpDownBars : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the UpDownBars class.
        /// </summary>
        public UpDownBars() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UpDownBars class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UpDownBars(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UpDownBars class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UpDownBars(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UpDownBars class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public UpDownBars(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "upDownBars");
            builder.AddChild<GapWidth>();
            builder.AddChild<UpBars>();
            builder.AddChild<DownBars>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.GapWidth), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.UpBars), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DownBars), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Gap Width.</para>
        /// <para>Represents the following element tag in the schema: c:gapWidth.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public GapWidth GapWidth
        {
            get => GetElement<GapWidth>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Up Bars.</para>
        /// <para>Represents the following element tag in the schema: c:upBars.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public UpBars UpBars
        {
            get => GetElement<UpBars>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Down Bars.</para>
        /// <para>Represents the following element tag in the schema: c:downBars.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DownBars DownBars
        {
            get => GetElement<DownBars>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UpDownBars>(deep);
    }

    /// <summary>
    /// <para>Defines the StockChartExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StockChartExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class StockChartExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StockChartExtensionList class.
        /// </summary>
        public StockChartExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StockChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StockChartExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StockChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StockChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StockChartExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StockChartExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<StockChartExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StockChartExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StockChartExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the PieChartExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PieChartExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class PieChartExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PieChartExtensionList class.
        /// </summary>
        public PieChartExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PieChartExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PieChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieChartExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PieChartExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<PieChartExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PieChartExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PieChartExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the Pie3DChartExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Pie3DChartExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class Pie3DChartExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Pie3DChartExtensionList class.
        /// </summary>
        public Pie3DChartExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Pie3DChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Pie3DChartExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Pie3DChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Pie3DChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Pie3DChartExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Pie3DChartExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<Pie3DChartExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Pie3DChartExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the NumRefExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NumRefExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class NumRefExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NumRefExtensionList class.
        /// </summary>
        public NumRefExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumRefExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumRefExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumRefExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumRefExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumRefExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NumRefExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<NumRefExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumRefExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the StrDataExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StrDataExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class StrDataExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StrDataExtensionList class.
        /// </summary>
        public StrDataExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StrDataExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StrDataExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StrDataExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StrDataExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StrDataExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StrDataExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<StrDataExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrDataExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the StrRefExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StrRefExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class StrRefExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StrRefExtensionList class.
        /// </summary>
        public StrRefExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StrRefExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StrRefExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StrRefExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StrRefExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StrRefExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StrRefExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<StrRefExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrRefExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the MultiLevelStringCache Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:multiLvlStrCache.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PointCount &lt;c:ptCount></description></item>
    ///   <item><description>Level &lt;c:lvl></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class MultiLevelStringCache : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MultiLevelStringCache class.
        /// </summary>
        public MultiLevelStringCache() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLevelStringCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MultiLevelStringCache(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLevelStringCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MultiLevelStringCache(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLevelStringCache class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MultiLevelStringCache(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "multiLvlStrCache");
            builder.AddChild<PointCount>();
            builder.AddChild<Level>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Level), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>PointCount.</para>
        /// <para>Represents the following element tag in the schema: c:ptCount.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PointCount PointCount
        {
            get => GetElement<PointCount>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLevelStringCache>(deep);
    }

    /// <summary>
    /// <para>Defines the MultiLvlStrRefExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>MultiLvlStrRefExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class MultiLvlStrRefExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MultiLvlStrRefExtensionList class.
        /// </summary>
        public MultiLvlStrRefExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLvlStrRefExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MultiLvlStrRefExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLvlStrRefExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MultiLvlStrRefExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLvlStrRefExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MultiLvlStrRefExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<MultiLvlStrRefExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLvlStrRefExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the DLblExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DLblExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class DLblExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DLblExtensionList class.
        /// </summary>
        public DLblExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DLblExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DLblExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DLblExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DLblExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DLblExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DLblExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<DLblExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DLblExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DLblExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the DLblsExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DLblsExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class DLblsExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DLblsExtensionList class.
        /// </summary>
        public DLblsExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DLblsExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DLblsExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DLblsExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DLblsExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DLblsExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DLblsExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<DLblsExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DLblsExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the DataPoint Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:dPt.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Index &lt;c:idx></description></item>
    ///   <item><description>InvertIfNegative &lt;c:invertIfNegative></description></item>
    ///   <item><description>Marker &lt;c:marker></description></item>
    ///   <item><description>Bubble3D &lt;c:bubble3D></description></item>
    ///   <item><description>Explosion &lt;c:explosion></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class DataPoint : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataPoint class.
        /// </summary>
        public DataPoint() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPoint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPoint(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPoint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPoint(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPoint class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataPoint(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "dPt");
            builder.AddChild<Index>();
            builder.AddChild<InvertIfNegative>();
            builder.AddChild<Marker>();
            builder.AddChild<Bubble3D>();
            builder.AddChild<Explosion>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<PictureOptions>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bubble3D), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Explosion), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Index Index
        {
            get => GetElement<Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Invert if Negative.</para>
        /// <para>Represents the following element tag in the schema: c:invertIfNegative.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public InvertIfNegative InvertIfNegative
        {
            get => GetElement<InvertIfNegative>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Marker.</para>
        /// <para>Represents the following element tag in the schema: c:marker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Marker Marker
        {
            get => GetElement<Marker>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>3D Bubble.</para>
        /// <para>Represents the following element tag in the schema: c:bubble3D.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Bubble3D Bubble3D
        {
            get => GetElement<Bubble3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Explosion.</para>
        /// <para>Represents the following element tag in the schema: c:explosion.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Explosion Explosion
        {
            get => GetElement<Explosion>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PictureOptions PictureOptions
        {
            get => GetElement<PictureOptions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPoint>(deep);
    }

    /// <summary>
    /// <para>Defines the Trendline Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:trendline.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TrendlineName &lt;c:name></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>TrendlineType &lt;c:trendlineType></description></item>
    ///   <item><description>PolynomialOrder &lt;c:order></description></item>
    ///   <item><description>Period &lt;c:period></description></item>
    ///   <item><description>Forward &lt;c:forward></description></item>
    ///   <item><description>Backward &lt;c:backward></description></item>
    ///   <item><description>Intercept &lt;c:intercept></description></item>
    ///   <item><description>DisplayRSquaredValue &lt;c:dispRSqr></description></item>
    ///   <item><description>DisplayEquation &lt;c:dispEq></description></item>
    ///   <item><description>TrendlineLabel &lt;c:trendlineLbl></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Trendline : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Trendline class.
        /// </summary>
        public Trendline() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Trendline class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Trendline(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Trendline class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Trendline(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Trendline class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Trendline(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "trendline");
            builder.AddChild<TrendlineName>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<TrendlineType>();
            builder.AddChild<PolynomialOrder>();
            builder.AddChild<Period>();
            builder.AddChild<Forward>();
            builder.AddChild<Backward>();
            builder.AddChild<Intercept>();
            builder.AddChild<DisplayRSquaredValue>();
            builder.AddChild<DisplayEquation>();
            builder.AddChild<TrendlineLabel>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TrendlineName), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TrendlineType), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PolynomialOrder), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Period), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Forward), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Backward), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Intercept), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DisplayRSquaredValue), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DisplayEquation), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TrendlineLabel), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Trendline Name.</para>
        /// <para>Represents the following element tag in the schema: c:name.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public TrendlineName TrendlineName
        {
            get => GetElement<TrendlineName>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Trendline Type.</para>
        /// <para>Represents the following element tag in the schema: c:trendlineType.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public TrendlineType TrendlineType
        {
            get => GetElement<TrendlineType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Polynomial Trendline Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PolynomialOrder PolynomialOrder
        {
            get => GetElement<PolynomialOrder>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Period.</para>
        /// <para>Represents the following element tag in the schema: c:period.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Period Period
        {
            get => GetElement<Period>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Forward.</para>
        /// <para>Represents the following element tag in the schema: c:forward.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Forward Forward
        {
            get => GetElement<Forward>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Backward.</para>
        /// <para>Represents the following element tag in the schema: c:backward.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Backward Backward
        {
            get => GetElement<Backward>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Intercept.</para>
        /// <para>Represents the following element tag in the schema: c:intercept.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Intercept Intercept
        {
            get => GetElement<Intercept>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Display R Squared Value.</para>
        /// <para>Represents the following element tag in the schema: c:dispRSqr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DisplayRSquaredValue DisplayRSquaredValue
        {
            get => GetElement<DisplayRSquaredValue>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Display Equation.</para>
        /// <para>Represents the following element tag in the schema: c:dispEq.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DisplayEquation DisplayEquation
        {
            get => GetElement<DisplayEquation>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Trendline Label.</para>
        /// <para>Represents the following element tag in the schema: c:trendlineLbl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public TrendlineLabel TrendlineLabel
        {
            get => GetElement<TrendlineLabel>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Trendline>(deep);
    }

    /// <summary>
    /// <para>Defines the ErrorBars Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:errBars.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ErrorDirection &lt;c:errDir></description></item>
    ///   <item><description>ErrorBarType &lt;c:errBarType></description></item>
    ///   <item><description>ErrorBarValueType &lt;c:errValType></description></item>
    ///   <item><description>NoEndCap &lt;c:noEndCap></description></item>
    ///   <item><description>Plus &lt;c:plus></description></item>
    ///   <item><description>Minus &lt;c:minus></description></item>
    ///   <item><description>ErrorBarValue &lt;c:val></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ErrorBars : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ErrorBars class.
        /// </summary>
        public ErrorBars() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorBars class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ErrorBars(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorBars class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ErrorBars(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorBars class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ErrorBars(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "errBars");
            builder.AddChild<ErrorDirection>();
            builder.AddChild<ErrorBarType>();
            builder.AddChild<ErrorBarValueType>();
            builder.AddChild<NoEndCap>();
            builder.AddChild<Plus>();
            builder.AddChild<Minus>();
            builder.AddChild<ErrorBarValue>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorDirection), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBarType), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValueType), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NoEndCap), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Plus), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Minus), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValue), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Error Bar Direction.</para>
        /// <para>Represents the following element tag in the schema: c:errDir.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ErrorDirection ErrorDirection
        {
            get => GetElement<ErrorDirection>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Error Bar Type.</para>
        /// <para>Represents the following element tag in the schema: c:errBarType.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ErrorBarType ErrorBarType
        {
            get => GetElement<ErrorBarType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Error Bar Value Type.</para>
        /// <para>Represents the following element tag in the schema: c:errValType.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ErrorBarValueType ErrorBarValueType
        {
            get => GetElement<ErrorBarValueType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>No End Cap.</para>
        /// <para>Represents the following element tag in the schema: c:noEndCap.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public NoEndCap NoEndCap
        {
            get => GetElement<NoEndCap>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Plus.</para>
        /// <para>Represents the following element tag in the schema: c:plus.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Plus Plus
        {
            get => GetElement<Plus>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Minus.</para>
        /// <para>Represents the following element tag in the schema: c:minus.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Minus Minus
        {
            get => GetElement<Minus>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Error Bar Value.</para>
        /// <para>Represents the following element tag in the schema: c:val.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ErrorBarValue ErrorBarValue
        {
            get => GetElement<ErrorBarValue>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ErrorBars>(deep);
    }

    /// <summary>
    /// <para>Defines the CategoryAxisData Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:cat.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>MultiLevelStringReference &lt;c:multiLvlStrRef></description></item>
    ///   <item><description>NumberReference &lt;c:numRef></description></item>
    ///   <item><description>NumberLiteral &lt;c:numLit></description></item>
    ///   <item><description>StringReference &lt;c:strRef></description></item>
    ///   <item><description>StringLiteral &lt;c:strLit></description></item>
    /// </list>
    /// </remark>
    public partial class CategoryAxisData : AxisDataSourceType
    {
        /// <summary>
        /// Initializes a new instance of the CategoryAxisData class.
        /// </summary>
        public CategoryAxisData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryAxisData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryAxisData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryAxisData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryAxisData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryAxisData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CategoryAxisData(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "cat");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryAxisData>(deep);
    }

    /// <summary>
    /// <para>Defines the XValues Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:xVal.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>MultiLevelStringReference &lt;c:multiLvlStrRef></description></item>
    ///   <item><description>NumberReference &lt;c:numRef></description></item>
    ///   <item><description>NumberLiteral &lt;c:numLit></description></item>
    ///   <item><description>StringReference &lt;c:strRef></description></item>
    ///   <item><description>StringLiteral &lt;c:strLit></description></item>
    /// </list>
    /// </remark>
    public partial class XValues : AxisDataSourceType
    {
        /// <summary>
        /// Initializes a new instance of the XValues class.
        /// </summary>
        public XValues() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the XValues class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public XValues(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the XValues class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public XValues(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the XValues class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public XValues(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "xVal");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringReference), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<XValues>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisDataSourceType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>MultiLevelStringReference &lt;c:multiLvlStrRef></description></item>
    ///   <item><description>NumberReference &lt;c:numRef></description></item>
    ///   <item><description>NumberLiteral &lt;c:numLit></description></item>
    ///   <item><description>StringReference &lt;c:strRef></description></item>
    ///   <item><description>StringLiteral &lt;c:strLit></description></item>
    /// </list>
    /// </remark>
    public abstract partial class AxisDataSourceType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AxisDataSourceType class.
        /// </summary>
        protected AxisDataSourceType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisDataSourceType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected AxisDataSourceType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisDataSourceType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected AxisDataSourceType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisDataSourceType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected AxisDataSourceType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<MultiLevelStringReference>();
            builder.AddChild<NumberReference>();
            builder.AddChild<NumberLiteral>();
            builder.AddChild<StringReference>();
            builder.AddChild<StringLiteral>();
        }

        /// <summary>
        /// <para>Multi Level String Reference.</para>
        /// <para>Represents the following element tag in the schema: c:multiLvlStrRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public MultiLevelStringReference MultiLevelStringReference
        {
            get => GetElement<MultiLevelStringReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number Reference.</para>
        /// <para>Represents the following element tag in the schema: c:numRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public NumberReference NumberReference
        {
            get => GetElement<NumberReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number Literal.</para>
        /// <para>Represents the following element tag in the schema: c:numLit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public NumberLiteral NumberLiteral
        {
            get => GetElement<NumberLiteral>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>StringReference.</para>
        /// <para>Represents the following element tag in the schema: c:strRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public StringReference StringReference
        {
            get => GetElement<StringReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>String Literal.</para>
        /// <para>Represents the following element tag in the schema: c:strLit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public StringLiteral StringLiteral
        {
            get => GetElement<StringLiteral>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Defines the LineSerExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineSerExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class LineSerExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LineSerExtensionList class.
        /// </summary>
        public LineSerExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSerExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineSerExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSerExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineSerExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineSerExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LineSerExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<LineSerExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineSerExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the ScatterSerExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ScatterSerExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class ScatterSerExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ScatterSerExtensionList class.
        /// </summary>
        public ScatterSerExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterSerExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScatterSerExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterSerExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScatterSerExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterSerExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ScatterSerExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<ScatterSerExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterSerExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the RadarSerExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RadarSerExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class RadarSerExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RadarSerExtensionList class.
        /// </summary>
        public RadarSerExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarSerExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadarSerExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarSerExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadarSerExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarSerExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RadarSerExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<RadarSerExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarSerExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the Shape Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:shape.</para>
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
        /// <para>Shape Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "shape");
            builder.AddElement<Shape>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);
    }

    /// <summary>
    /// <para>Defines the BarSerExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BarSerExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class BarSerExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BarSerExtensionList class.
        /// </summary>
        public BarSerExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarSerExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarSerExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarSerExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarSerExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarSerExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BarSerExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<BarSerExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarSerExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarSerExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the BarSerExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat &lt;c14:invertSolidFillFmt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle &lt;c15:filteredSeriesTitle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle &lt;c15:filteredCategoryTitle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange &lt;c15:datalabelsRange></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions &lt;c15:categoryFilterExceptions></description></item>
    /// </list>
    /// </remark>
    public partial class BarSerExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BarSerExtension class.
        /// </summary>
        public BarSerExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarSerExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarSerExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarSerExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarSerExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarSerExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BarSerExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
            builder.AddElement<BarSerExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarSerExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the AreaSerExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AreaSerExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class AreaSerExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AreaSerExtensionList class.
        /// </summary>
        public AreaSerExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaSerExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AreaSerExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaSerExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AreaSerExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaSerExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AreaSerExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<AreaSerExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AreaSerExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AreaSerExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the PieSerExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PieSerExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class PieSerExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PieSerExtensionList class.
        /// </summary>
        public PieSerExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieSerExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PieSerExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieSerExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PieSerExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PieSerExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PieSerExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<PieSerExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PieSerExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PieSerExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the BubbleSerExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BubbleSerExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class BubbleSerExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BubbleSerExtensionList class.
        /// </summary>
        public BubbleSerExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleSerExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleSerExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleSerExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleSerExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleSerExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BubbleSerExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<BubbleSerExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleSerExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the BubbleSerExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat &lt;c14:invertSolidFillFmt></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle &lt;c15:filteredCategoryTitle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange &lt;c15:datalabelsRange></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions &lt;c15:categoryFilterExceptions></description></item>
    /// </list>
    /// </remark>
    public partial class BubbleSerExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BubbleSerExtension class.
        /// </summary>
        public BubbleSerExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleSerExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleSerExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleSerExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleSerExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleSerExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BubbleSerExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
            builder.AddElement<BubbleSerExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleSerExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the SurfaceSerExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SurfaceSerExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class SurfaceSerExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SurfaceSerExtensionList class.
        /// </summary>
        public SurfaceSerExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceSerExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurfaceSerExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceSerExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurfaceSerExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceSerExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SurfaceSerExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<SurfaceSerExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurfaceSerExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the LineChartExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LineChartExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class LineChartExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LineChartExtensionList class.
        /// </summary>
        public LineChartExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineChartExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineChartExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LineChartExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<LineChartExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineChartExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the Line3DChartExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Line3DChartExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class Line3DChartExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Line3DChartExtensionList class.
        /// </summary>
        public Line3DChartExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line3DChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Line3DChartExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line3DChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Line3DChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line3DChartExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Line3DChartExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<Line3DChartExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Line3DChartExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the ScatterStyle Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:scatterStyle.</para>
    /// </summary>
    public partial class ScatterStyle : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ScatterStyle class.
        /// </summary>
        public ScatterStyle() : base()
        {
        }

        /// <summary>
        /// <para>Scatter Style Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "scatterStyle");
            builder.AddElement<ScatterStyle>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the ScatterChartSeries Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Index &lt;c:idx></description></item>
    ///   <item><description>Order &lt;c:order></description></item>
    ///   <item><description>SeriesText &lt;c:tx></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>Marker &lt;c:marker></description></item>
    ///   <item><description>DataPoint &lt;c:dPt></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>Trendline &lt;c:trendline></description></item>
    ///   <item><description>ErrorBars &lt;c:errBars></description></item>
    ///   <item><description>XValues &lt;c:xVal></description></item>
    ///   <item><description>YValues &lt;c:yVal></description></item>
    ///   <item><description>Smooth &lt;c:smooth></description></item>
    ///   <item><description>ScatterSerExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ScatterChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ScatterChartSeries class.
        /// </summary>
        public ScatterChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScatterChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScatterChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ScatterChartSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ser");
            builder.AddChild<Index>();
            builder.AddChild<Order>();
            builder.AddChild<SeriesText>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<Marker>();
            builder.AddChild<DataPoint>();
            builder.AddChild<DataLabels>();
            builder.AddChild<Trendline>();
            builder.AddChild<ErrorBars>();
            builder.AddChild<XValues>();
            builder.AddChild<YValues>();
            builder.AddChild<Smooth>();
            builder.AddChild<ScatterSerExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars), 0, 2),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.XValues), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.YValues), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Smooth), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Index Index
        {
            get => GetElement<Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Order Order
        {
            get => GetElement<Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public SeriesText SeriesText
        {
            get => GetElement<SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Marker.</para>
        /// <para>Represents the following element tag in the schema: c:marker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Marker Marker
        {
            get => GetElement<Marker>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the ScatterChartExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ScatterChartExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class ScatterChartExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ScatterChartExtensionList class.
        /// </summary>
        public ScatterChartExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScatterChartExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ScatterChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScatterChartExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ScatterChartExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<ScatterChartExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScatterChartExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the RadarStyle Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:radarStyle.</para>
    /// </summary>
    public partial class RadarStyle : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RadarStyle class.
        /// </summary>
        public RadarStyle() : base()
        {
        }

        /// <summary>
        /// <para>Radar Style Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "radarStyle");
            builder.AddElement<RadarStyle>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the RadarChartSeries Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Index &lt;c:idx></description></item>
    ///   <item><description>Order &lt;c:order></description></item>
    ///   <item><description>SeriesText &lt;c:tx></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>Marker &lt;c:marker></description></item>
    ///   <item><description>DataPoint &lt;c:dPt></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>CategoryAxisData &lt;c:cat></description></item>
    ///   <item><description>Values &lt;c:val></description></item>
    ///   <item><description>RadarSerExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class RadarChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RadarChartSeries class.
        /// </summary>
        public RadarChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadarChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadarChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RadarChartSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ser");
            builder.AddChild<Index>();
            builder.AddChild<Order>();
            builder.AddChild<SeriesText>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<PictureOptions>();
            builder.AddChild<Marker>();
            builder.AddChild<DataPoint>();
            builder.AddChild<DataLabels>();
            builder.AddChild<CategoryAxisData>();
            builder.AddChild<Values>();
            builder.AddChild<RadarSerExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Marker), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Values), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Index Index
        {
            get => GetElement<Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Order Order
        {
            get => GetElement<Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public SeriesText SeriesText
        {
            get => GetElement<SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PictureOptions PictureOptions
        {
            get => GetElement<PictureOptions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Marker.</para>
        /// <para>Represents the following element tag in the schema: c:marker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Marker Marker
        {
            get => GetElement<Marker>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the RadarChartExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RadarChartExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class RadarChartExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RadarChartExtensionList class.
        /// </summary>
        public RadarChartExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadarChartExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadarChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadarChartExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RadarChartExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<RadarChartExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadarChartExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the Overlap Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:overlap.</para>
    /// </summary>
    public partial class Overlap : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Overlap class.
        /// </summary>
        public Overlap() : base()
        {
        }

        /// <summary>
        /// <para>Overlap Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public SByteValue Val
        {
            get => GetAttribute<SByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "overlap");
            builder.AddElement<Overlap>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-100L), MaxInclusive = (100L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Overlap>(deep);
    }

    /// <summary>
    /// <para>Defines the BarChartExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BarChartExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class BarChartExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BarChartExtensionList class.
        /// </summary>
        public BarChartExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarChartExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarChartExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BarChartExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<BarChartExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BarChartExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarChartExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the Bar3DChartExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Bar3DChartExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class Bar3DChartExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Bar3DChartExtensionList class.
        /// </summary>
        public Bar3DChartExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Bar3DChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Bar3DChartExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Bar3DChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Bar3DChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Bar3DChartExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Bar3DChartExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<Bar3DChartExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChartExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bar3DChartExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the AreaChartExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AreaChartExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class AreaChartExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AreaChartExtensionList class.
        /// </summary>
        public AreaChartExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AreaChartExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AreaChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AreaChartExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AreaChartExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<AreaChartExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AreaChartExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the Area3DChartExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Area3DChartExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class Area3DChartExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Area3DChartExtensionList class.
        /// </summary>
        public Area3DChartExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Area3DChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Area3DChartExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Area3DChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Area3DChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Area3DChartExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Area3DChartExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<Area3DChartExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Area3DChartExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the BubbleChartSeries Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ser.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Index &lt;c:idx></description></item>
    ///   <item><description>Order &lt;c:order></description></item>
    ///   <item><description>SeriesText &lt;c:tx></description></item>
    ///   <item><description>ChartShapeProperties &lt;c:spPr></description></item>
    ///   <item><description>PictureOptions &lt;c:pictureOptions></description></item>
    ///   <item><description>InvertIfNegative &lt;c:invertIfNegative></description></item>
    ///   <item><description>DataPoint &lt;c:dPt></description></item>
    ///   <item><description>DataLabels &lt;c:dLbls></description></item>
    ///   <item><description>Trendline &lt;c:trendline></description></item>
    ///   <item><description>ErrorBars &lt;c:errBars></description></item>
    ///   <item><description>XValues &lt;c:xVal></description></item>
    ///   <item><description>YValues &lt;c:yVal></description></item>
    ///   <item><description>BubbleSize &lt;c:bubbleSize></description></item>
    ///   <item><description>Bubble3D &lt;c:bubble3D></description></item>
    ///   <item><description>BubbleSerExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class BubbleChartSeries : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BubbleChartSeries class.
        /// </summary>
        public BubbleChartSeries() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleChartSeries(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChartSeries class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleChartSeries(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChartSeries class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BubbleChartSeries(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ser");
            builder.AddChild<Index>();
            builder.AddChild<Order>();
            builder.AddChild<SeriesText>();
            builder.AddChild<ChartShapeProperties>();
            builder.AddChild<PictureOptions>();
            builder.AddChild<InvertIfNegative>();
            builder.AddChild<DataPoint>();
            builder.AddChild<DataLabels>();
            builder.AddChild<Trendline>();
            builder.AddChild<ErrorBars>();
            builder.AddChild<XValues>();
            builder.AddChild<YValues>();
            builder.AddChild<BubbleSize>();
            builder.AddChild<Bubble3D>();
            builder.AddChild<BubbleSerExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Order), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SeriesText), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.InvertIfNegative), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabels), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Trendline), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ErrorBars), 0, 2),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.XValues), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.YValues), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleSize), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Bubble3D), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Index Index
        {
            get => GetElement<Index>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Order.</para>
        /// <para>Represents the following element tag in the schema: c:order.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Order Order
        {
            get => GetElement<Order>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Series Text.</para>
        /// <para>Represents the following element tag in the schema: c:tx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public SeriesText SeriesText
        {
            get => GetElement<SeriesText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartShapeProperties ChartShapeProperties
        {
            get => GetElement<ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PictureOptions.</para>
        /// <para>Represents the following element tag in the schema: c:pictureOptions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PictureOptions PictureOptions
        {
            get => GetElement<PictureOptions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>InvertIfNegative.</para>
        /// <para>Represents the following element tag in the schema: c:invertIfNegative.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public InvertIfNegative InvertIfNegative
        {
            get => GetElement<InvertIfNegative>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleChartSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the BubbleScale Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:bubbleScale.</para>
    /// </summary>
    public partial class BubbleScale : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BubbleScale class.
        /// </summary>
        public BubbleScale() : base()
        {
        }

        /// <summary>
        /// <para>Bubble Scale Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public UInt32Value Val
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "bubbleScale");
            builder.AddElement<BubbleScale>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (300L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleScale>(deep);
    }

    /// <summary>
    /// <para>Defines the SizeRepresents Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:sizeRepresents.</para>
    /// </summary>
    public partial class SizeRepresents : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SizeRepresents class.
        /// </summary>
        public SizeRepresents() : base()
        {
        }

        /// <summary>
        /// <para>Size Represents Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "sizeRepresents");
            builder.AddElement<SizeRepresents>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SizeRepresents>(deep);
    }

    /// <summary>
    /// <para>Defines the BubbleChartExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BubbleChartExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class BubbleChartExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BubbleChartExtensionList class.
        /// </summary>
        public BubbleChartExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleChartExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BubbleChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BubbleChartExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BubbleChartExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<BubbleChartExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BubbleChartExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BubbleChartExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the SurfaceChartExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SurfaceChartExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class SurfaceChartExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SurfaceChartExtensionList class.
        /// </summary>
        public SurfaceChartExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurfaceChartExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurfaceChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurfaceChartExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SurfaceChartExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<SurfaceChartExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurfaceChartExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the Surface3DChartExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Surface3DChartExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class Surface3DChartExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Surface3DChartExtensionList class.
        /// </summary>
        public Surface3DChartExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Surface3DChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Surface3DChartExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Surface3DChartExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Surface3DChartExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Surface3DChartExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Surface3DChartExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<Surface3DChartExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Surface3DChartExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Surface3DChartExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the LabelAlignment Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:lblAlgn.</para>
    /// </summary>
    public partial class LabelAlignment : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the LabelAlignment class.
        /// </summary>
        public LabelAlignment() : base()
        {
        }

        /// <summary>
        /// <para>Label Alignment Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LabelAlignmentValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.LabelAlignmentValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "lblAlgn");
            builder.AddElement<LabelAlignment>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LabelAlignment>(deep);
    }

    /// <summary>
    /// <para>Defines the LabelOffset Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:lblOffset.</para>
    /// </summary>
    public partial class LabelOffset : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the LabelOffset class.
        /// </summary>
        public LabelOffset() : base()
        {
        }

        /// <summary>
        /// <para>Label Offset Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public UInt16Value Val
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "lblOffset");
            builder.AddElement<LabelOffset>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (1000L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LabelOffset>(deep);
    }

    /// <summary>
    /// <para>Defines the TickLabelSkip Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:tickLblSkip.</para>
    /// </summary>
    public partial class TickLabelSkip : SkipType
    {
        /// <summary>
        /// Initializes a new instance of the TickLabelSkip class.
        /// </summary>
        public TickLabelSkip() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "tickLblSkip");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TickLabelSkip>(deep);
    }

    /// <summary>
    /// <para>Defines the TickMarkSkip Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:tickMarkSkip.</para>
    /// </summary>
    public partial class TickMarkSkip : SkipType
    {
        /// <summary>
        /// Initializes a new instance of the TickMarkSkip class.
        /// </summary>
        public TickMarkSkip() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "tickMarkSkip");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TickMarkSkip>(deep);
    }

    /// <summary>
    /// <para>Defines the SkipType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class SkipType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SkipType class.
        /// </summary>
        protected SkipType() : base()
        {
        }

        /// <summary>
        /// <para>Tick Skip Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public Int32Value Val
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<SkipType>()
                           .AddAttribute(0, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L) });
                           });
        }
    }

    /// <summary>
    /// <para>Defines the CatAxExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CatAxExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class CatAxExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CatAxExtensionList class.
        /// </summary>
        public CatAxExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CatAxExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CatAxExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CatAxExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CatAxExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CatAxExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CatAxExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<CatAxExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CatAxExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CatAxExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the BaseTimeUnit Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:baseTimeUnit.</para>
    /// </summary>
    public partial class BaseTimeUnit : TimeUnitType
    {
        /// <summary>
        /// Initializes a new instance of the BaseTimeUnit class.
        /// </summary>
        public BaseTimeUnit() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "baseTimeUnit");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BaseTimeUnit>(deep);
    }

    /// <summary>
    /// <para>Defines the MajorTimeUnit Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:majorTimeUnit.</para>
    /// </summary>
    public partial class MajorTimeUnit : TimeUnitType
    {
        /// <summary>
        /// Initializes a new instance of the MajorTimeUnit class.
        /// </summary>
        public MajorTimeUnit() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "majorTimeUnit");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MajorTimeUnit>(deep);
    }

    /// <summary>
    /// <para>Defines the MinorTimeUnit Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:minorTimeUnit.</para>
    /// </summary>
    public partial class MinorTimeUnit : TimeUnitType
    {
        /// <summary>
        /// Initializes a new instance of the MinorTimeUnit class.
        /// </summary>
        public MinorTimeUnit() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "minorTimeUnit");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinorTimeUnit>(deep);
    }

    /// <summary>
    /// <para>Defines the TimeUnitType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class TimeUnitType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimeUnitType class.
        /// </summary>
        protected TimeUnitType() : base()
        {
        }

        /// <summary>
        /// <para>Time Unit Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<TimeUnitType>()
                           .AddAttribute(0, "val", a => a.Val);
        }
    }

    /// <summary>
    /// <para>Defines the MajorUnit Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:majorUnit.</para>
    /// </summary>
    public partial class MajorUnit : AxisUnitType
    {
        /// <summary>
        /// Initializes a new instance of the MajorUnit class.
        /// </summary>
        public MajorUnit() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "majorUnit");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MajorUnit>(deep);
    }

    /// <summary>
    /// <para>Defines the MinorUnit Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:minorUnit.</para>
    /// </summary>
    public partial class MinorUnit : AxisUnitType
    {
        /// <summary>
        /// Initializes a new instance of the MinorUnit class.
        /// </summary>
        public MinorUnit() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "minorUnit");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MinorUnit>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisUnitType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class AxisUnitType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the AxisUnitType class.
        /// </summary>
        protected AxisUnitType() : base()
        {
        }

        /// <summary>
        /// <para>Major Unit Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public DoubleValue Val
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<AxisUnitType>()
                           .AddAttribute(0, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new NumberValidator() { MinExclusive = (0L) });
                           });
        }
    }

    /// <summary>
    /// <para>Defines the DateAxExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DateAxExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class DateAxExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DateAxExtensionList class.
        /// </summary>
        public DateAxExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DateAxExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DateAxExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DateAxExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DateAxExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DateAxExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DateAxExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<DateAxExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DateAxExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the SerAxExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SerAxExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class SerAxExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SerAxExtensionList class.
        /// </summary>
        public SerAxExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerAxExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SerAxExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerAxExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SerAxExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerAxExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SerAxExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<SerAxExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SerAxExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SerAxExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the CrossBetween Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:crossBetween.</para>
    /// </summary>
    public partial class CrossBetween : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CrossBetween class.
        /// </summary>
        public CrossBetween() : base()
        {
        }

        /// <summary>
        /// <para>Cross Between Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "crossBetween");
            builder.AddElement<CrossBetween>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CrossBetween>(deep);
    }

    /// <summary>
    /// <para>Defines the DisplayUnits Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:dispUnits.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CustomDisplayUnit &lt;c:custUnit></description></item>
    ///   <item><description>BuiltInUnit &lt;c:builtInUnit></description></item>
    ///   <item><description>DisplayUnitsLabel &lt;c:dispUnitsLbl></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class DisplayUnits : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DisplayUnits class.
        /// </summary>
        public DisplayUnits() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DisplayUnits class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DisplayUnits(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DisplayUnits class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DisplayUnits(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DisplayUnits class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DisplayUnits(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "dispUnits");
            builder.AddChild<CustomDisplayUnit>();
            builder.AddChild<BuiltInUnit>();
            builder.AddChild<DisplayUnitsLabel>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.CustomDisplayUnit), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnit), 1, 1)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DisplayUnits>(deep);
    }

    /// <summary>
    /// <para>Defines the ValAxExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ValAxExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class ValAxExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ValAxExtensionList class.
        /// </summary>
        public ValAxExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValAxExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ValAxExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValAxExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ValAxExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValAxExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ValAxExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<ValAxExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ValAxExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the EditingLanguage Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:lang.</para>
    /// </summary>
    public partial class EditingLanguage : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the EditingLanguage class.
        /// </summary>
        public EditingLanguage() : base()
        {
        }

        /// <summary>
        /// <para>Language Code</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "lang");
            builder.AddElement<EditingLanguage>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EditingLanguage>(deep);
    }

    /// <summary>
    /// <para>Defines the Style Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:style.</para>
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
        /// <para>Style Type</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public ByteValue Val
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "style");
            builder.AddElement<Style>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
 aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (48L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Style>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorMapOverride Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:clrMapOvr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ColorMapOverride : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorMapOverride class.
        /// </summary>
        public ColorMapOverride() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorMapOverride class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorMapOverride(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorMapOverride class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorMapOverride(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorMapOverride class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorMapOverride(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Background 1</para>
        /// <para>Represents the following attribute in the schema: bg1</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Background1
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text 1</para>
        /// <para>Represents the following attribute in the schema: tx1</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Text1
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Background 2</para>
        /// <para>Represents the following attribute in the schema: bg2</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Background2
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text 2</para>
        /// <para>Represents the following attribute in the schema: tx2</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Text2
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 1</para>
        /// <para>Represents the following attribute in the schema: accent1</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent1
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 2</para>
        /// <para>Represents the following attribute in the schema: accent2</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent2
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 3</para>
        /// <para>Represents the following attribute in the schema: accent3</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent3
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 4</para>
        /// <para>Represents the following attribute in the schema: accent4</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent4
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 5</para>
        /// <para>Represents the following attribute in the schema: accent5</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent5
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Accent 6</para>
        /// <para>Represents the following attribute in the schema: accent6</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Accent6
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink</para>
        /// <para>Represents the following attribute in the schema: hlink</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> Hyperlink
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Followed Hyperlink</para>
        /// <para>Represents the following attribute in the schema: folHlink</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues> FollowedHyperlink
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "clrMapOvr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddElement<ColorMapOverride>()
.AddAttribute(0, "bg1", a => a.Background1, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "tx1", a => a.Text1, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "bg2", a => a.Background2, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "tx2", a => a.Text2, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "accent1", a => a.Accent1, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "accent2", a => a.Accent2, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "accent3", a => a.Accent3, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "accent4", a => a.Accent4, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "accent5", a => a.Accent5, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "accent6", a => a.Accent6, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "hlink", a => a.Hyperlink, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "folHlink", a => a.FollowedHyperlink, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorMapOverride>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotSource Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:pivotSource.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PivotTableName &lt;c:name></description></item>
    ///   <item><description>FormatId &lt;c:fmtId></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class PivotSource : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotSource class.
        /// </summary>
        public PivotSource() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotSource class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotSource(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotSource class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotSource(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotSource class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotSource(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "pivotSource");
            builder.AddChild<PivotTableName>();
            builder.AddChild<FormatId>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PivotTableName), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.FormatId), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Pivot Name.</para>
        /// <para>Represents the following element tag in the schema: c:name.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PivotTableName PivotTableName
        {
            get => GetElement<PivotTableName>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Format ID.</para>
        /// <para>Represents the following element tag in the schema: c:fmtId.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public FormatId FormatId
        {
            get => GetElement<FormatId>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotSource>(deep);
    }

    /// <summary>
    /// <para>Defines the Protection Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:protection.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartObject &lt;c:chartObject></description></item>
    ///   <item><description>Data &lt;c:data></description></item>
    ///   <item><description>Formatting &lt;c:formatting></description></item>
    ///   <item><description>Selection &lt;c:selection></description></item>
    ///   <item><description>UserInterface &lt;c:userInterface></description></item>
    /// </list>
    /// </remark>
    public partial class Protection : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Protection class.
        /// </summary>
        public Protection() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Protection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Protection(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Protection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Protection(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Protection class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Protection(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "protection");
            builder.AddChild<ChartObject>();
            builder.AddChild<Data>();
            builder.AddChild<Formatting>();
            builder.AddChild<Selection>();
            builder.AddChild<UserInterface>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartObject), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Data), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Formatting), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Selection), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.UserInterface), 0, 1)
            };
        }

        /// <summary>
        /// <para>Chart Object.</para>
        /// <para>Represents the following element tag in the schema: c:chartObject.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ChartObject ChartObject
        {
            get => GetElement<ChartObject>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Data Cannot Be Changed.</para>
        /// <para>Represents the following element tag in the schema: c:data.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Data Data
        {
            get => GetElement<Data>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Formatting.</para>
        /// <para>Represents the following element tag in the schema: c:formatting.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Formatting Formatting
        {
            get => GetElement<Formatting>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Selection.</para>
        /// <para>Represents the following element tag in the schema: c:selection.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Selection Selection
        {
            get => GetElement<Selection>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>User Interface.</para>
        /// <para>Represents the following element tag in the schema: c:userInterface.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public UserInterface UserInterface
        {
            get => GetElement<UserInterface>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Protection>(deep);
    }

    /// <summary>
    /// <para>Defines the Chart Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:chart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Title &lt;c:title></description></item>
    ///   <item><description>AutoTitleDeleted &lt;c:autoTitleDeleted></description></item>
    ///   <item><description>PivotFormats &lt;c:pivotFmts></description></item>
    ///   <item><description>View3D &lt;c:view3D></description></item>
    ///   <item><description>Floor &lt;c:floor></description></item>
    ///   <item><description>SideWall &lt;c:sideWall></description></item>
    ///   <item><description>BackWall &lt;c:backWall></description></item>
    ///   <item><description>PlotArea &lt;c:plotArea></description></item>
    ///   <item><description>Legend &lt;c:legend></description></item>
    ///   <item><description>PlotVisibleOnly &lt;c:plotVisOnly></description></item>
    ///   <item><description>DisplayBlanksAs &lt;c:dispBlanksAs></description></item>
    ///   <item><description>ShowDataLabelsOverMaximum &lt;c:showDLblsOverMax></description></item>
    ///   <item><description>ExtensionList &lt;c:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Chart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Chart class.
        /// </summary>
        public Chart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Chart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Chart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Chart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Chart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Chart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Chart(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "chart");
            builder.AddChild<Title>();
            builder.AddChild<AutoTitleDeleted>();
            builder.AddChild<PivotFormats>();
            builder.AddChild<View3D>();
            builder.AddChild<Floor>();
            builder.AddChild<SideWall>();
            builder.AddChild<BackWall>();
            builder.AddChild<PlotArea>();
            builder.AddChild<Legend>();
            builder.AddChild<PlotVisibleOnly>();
            builder.AddChild<DisplayBlanksAs>();
            builder.AddChild<ShowDataLabelsOverMaximum>();
            builder.AddChild<ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Title), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AutoTitleDeleted), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PivotFormats), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.View3D), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Floor), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.SideWall), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.BackWall), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PlotArea), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Legend), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PlotVisibleOnly), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAs), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowDataLabelsOverMaximum), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Title.</para>
        /// <para>Represents the following element tag in the schema: c:title.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Title Title
        {
            get => GetElement<Title>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Auto Title Is Deleted.</para>
        /// <para>Represents the following element tag in the schema: c:autoTitleDeleted.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public AutoTitleDeleted AutoTitleDeleted
        {
            get => GetElement<AutoTitleDeleted>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Pivot Formats.</para>
        /// <para>Represents the following element tag in the schema: c:pivotFmts.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PivotFormats PivotFormats
        {
            get => GetElement<PivotFormats>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>View In 3D.</para>
        /// <para>Represents the following element tag in the schema: c:view3D.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public View3D View3D
        {
            get => GetElement<View3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Floor.</para>
        /// <para>Represents the following element tag in the schema: c:floor.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Floor Floor
        {
            get => GetElement<Floor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Side Wall.</para>
        /// <para>Represents the following element tag in the schema: c:sideWall.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public SideWall SideWall
        {
            get => GetElement<SideWall>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Back Wall.</para>
        /// <para>Represents the following element tag in the schema: c:backWall.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public BackWall BackWall
        {
            get => GetElement<BackWall>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Plot Area.</para>
        /// <para>Represents the following element tag in the schema: c:plotArea.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PlotArea PlotArea
        {
            get => GetElement<PlotArea>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Legend.</para>
        /// <para>Represents the following element tag in the schema: c:legend.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public Legend Legend
        {
            get => GetElement<Legend>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Plot Visible Only.</para>
        /// <para>Represents the following element tag in the schema: c:plotVisOnly.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PlotVisibleOnly PlotVisibleOnly
        {
            get => GetElement<PlotVisibleOnly>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Display Blanks As.</para>
        /// <para>Represents the following element tag in the schema: c:dispBlanksAs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DisplayBlanksAs DisplayBlanksAs
        {
            get => GetElement<DisplayBlanksAs>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Show Data Labels over Maximum.</para>
        /// <para>Represents the following element tag in the schema: c:showDLblsOverMax.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ShowDataLabelsOverMaximum ShowDataLabelsOverMaximum
        {
            get => GetElement<ShowDataLabelsOverMaximum>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Chart>(deep);
    }

    /// <summary>
    /// <para>Defines the ExternalData Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:externalData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AutoUpdate &lt;c:autoUpdate></description></item>
    /// </list>
    /// </remark>
    public partial class ExternalData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ExternalData class.
        /// </summary>
        public ExternalData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExternalData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExternalData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExternalData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExternalData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExternalData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ExternalData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Relationship Reference</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "externalData");
            builder.AddChild<AutoUpdate>();
            builder.AddElement<ExternalData>()
.AddAttribute(19, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.AutoUpdate), 0, 1)
            };
            builder.AddConstraint(new RelationshipExistConstraint(0 /*r:id*/));
        }

        /// <summary>
        /// <para>Update Automatically.</para>
        /// <para>Represents the following element tag in the schema: c:autoUpdate.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public AutoUpdate AutoUpdate
        {
            get => GetElement<AutoUpdate>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExternalData>(deep);
    }

    /// <summary>
    /// <para>Defines the PrintSettings Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:printSettings.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>HeaderFooter &lt;c:headerFooter></description></item>
    ///   <item><description>PageMargins &lt;c:pageMargins></description></item>
    ///   <item><description>PageSetup &lt;c:pageSetup></description></item>
    ///   <item><description>LegacyDrawingHeaderFooter &lt;c:legacyDrawingHF></description></item>
    /// </list>
    /// </remark>
    public partial class PrintSettings : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PrintSettings class.
        /// </summary>
        public PrintSettings() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PrintSettings class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PrintSettings(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PrintSettings class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PrintSettings(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PrintSettings class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PrintSettings(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "printSettings");
            builder.AddChild<HeaderFooter>();
            builder.AddChild<PageMargins>();
            builder.AddChild<PageSetup>();
            builder.AddChild<LegacyDrawingHeaderFooter>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.HeaderFooter), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PageMargins), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PageSetup), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.LegacyDrawingHeaderFooter), 0, 1)
            };
        }

        /// <summary>
        /// <para>Header and Footer.</para>
        /// <para>Represents the following element tag in the schema: c:headerFooter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public HeaderFooter HeaderFooter
        {
            get => GetElement<HeaderFooter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Page Margins.</para>
        /// <para>Represents the following element tag in the schema: c:pageMargins.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PageMargins PageMargins
        {
            get => GetElement<PageMargins>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Page Setup.</para>
        /// <para>Represents the following element tag in the schema: c:pageSetup.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public PageSetup PageSetup
        {
            get => GetElement<PageSetup>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Legacy Drawing for Headers and Footers.</para>
        /// <para>Represents the following element tag in the schema: c:legacyDrawingHF.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public LegacyDrawingHeaderFooter LegacyDrawingHeaderFooter
        {
            get => GetElement<LegacyDrawingHeaderFooter>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PrintSettings>(deep);
    }

    /// <summary>
    /// <para>Defines the ChartSpaceExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChartSpaceExtension &lt;c:ext></description></item>
    /// </list>
    /// </remark>
    public partial class ChartSpaceExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartSpaceExtensionList class.
        /// </summary>
        public ChartSpaceExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartSpaceExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartSpaceExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartSpaceExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartSpaceExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartSpaceExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChartSpaceExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "extLst");
            builder.AddChild<ChartSpaceExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartSpaceExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the ChartSpaceExtension Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions &lt;c14:pivotOptions></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions &lt;c14:sketchOptions></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource &lt;c15:pivotSource></description></item>
    /// </list>
    /// </remark>
    public partial class ChartSpaceExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartSpaceExtension class.
        /// </summary>
        public ChartSpaceExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartSpaceExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartSpaceExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartSpaceExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartSpaceExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartSpaceExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChartSpaceExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(11, "ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource>();
            builder.AddElement<ChartSpaceExtension>()
.AddAttribute(0, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource), 1, 1, version: FileFormatVersions.Office2013),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartSpaceExtension>(deep);
    }

    /// <summary>
    /// Layout Target
    /// </summary>
    public enum LayoutTargetValues
    {
        ///<summary>
        ///Inner.
        ///<para>When the item is serialized out as xml, its value is "inner".</para>
        ///</summary>
        [EnumString("inner")]
        Inner,
        ///<summary>
        ///Outer.
        ///<para>When the item is serialized out as xml, its value is "outer".</para>
        ///</summary>
        [EnumString("outer")]
        Outer,
    }

    /// <summary>
    /// Layout Mode
    /// </summary>
    public enum LayoutModeValues
    {
        ///<summary>
        ///Edge.
        ///<para>When the item is serialized out as xml, its value is "edge".</para>
        ///</summary>
        [EnumString("edge")]
        Edge,
        ///<summary>
        ///Factor.
        ///<para>When the item is serialized out as xml, its value is "factor".</para>
        ///</summary>
        [EnumString("factor")]
        Factor,
    }

    /// <summary>
    /// Size Represents
    /// </summary>
    public enum SizeRepresentsValues
    {
        ///<summary>
        ///Bubble Size Represents Area.
        ///<para>When the item is serialized out as xml, its value is "area".</para>
        ///</summary>
        [EnumString("area")]
        Area,
        ///<summary>
        ///Bubble Size Represents Width.
        ///<para>When the item is serialized out as xml, its value is "w".</para>
        ///</summary>
        [EnumString("w")]
        Width,
    }

    /// <summary>
    /// Label Alignment
    /// </summary>
    public enum LabelAlignmentValues
    {
        ///<summary>
        ///Center.
        ///<para>When the item is serialized out as xml, its value is "ctr".</para>
        ///</summary>
        [EnumString("ctr")]
        Center,
        ///<summary>
        ///Left.
        ///<para>When the item is serialized out as xml, its value is "l".</para>
        ///</summary>
        [EnumString("l")]
        Left,
        ///<summary>
        ///Right.
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        Right,
    }

    /// <summary>
    /// Data Label Position
    /// </summary>
    public enum DataLabelPositionValues
    {
        ///<summary>
        ///Best Fit.
        ///<para>When the item is serialized out as xml, its value is "bestFit".</para>
        ///</summary>
        [EnumString("bestFit")]
        BestFit,
        ///<summary>
        ///Bottom.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        Bottom,
        ///<summary>
        ///Center.
        ///<para>When the item is serialized out as xml, its value is "ctr".</para>
        ///</summary>
        [EnumString("ctr")]
        Center,
        ///<summary>
        ///Inside Base.
        ///<para>When the item is serialized out as xml, its value is "inBase".</para>
        ///</summary>
        [EnumString("inBase")]
        InsideBase,
        ///<summary>
        ///Inside End.
        ///<para>When the item is serialized out as xml, its value is "inEnd".</para>
        ///</summary>
        [EnumString("inEnd")]
        InsideEnd,
        ///<summary>
        ///Left.
        ///<para>When the item is serialized out as xml, its value is "l".</para>
        ///</summary>
        [EnumString("l")]
        Left,
        ///<summary>
        ///Outside End.
        ///<para>When the item is serialized out as xml, its value is "outEnd".</para>
        ///</summary>
        [EnumString("outEnd")]
        OutsideEnd,
        ///<summary>
        ///Right.
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        Right,
        ///<summary>
        ///Top.
        ///<para>When the item is serialized out as xml, its value is "t".</para>
        ///</summary>
        [EnumString("t")]
        Top,
    }

    /// <summary>
    /// Trendline Type
    /// </summary>
    public enum TrendlineValues
    {
        ///<summary>
        ///Exponential.
        ///<para>When the item is serialized out as xml, its value is "exp".</para>
        ///</summary>
        [EnumString("exp")]
        Exponential,
        ///<summary>
        ///Linear.
        ///<para>When the item is serialized out as xml, its value is "linear".</para>
        ///</summary>
        [EnumString("linear")]
        Linear,
        ///<summary>
        ///Logarithmic.
        ///<para>When the item is serialized out as xml, its value is "log".</para>
        ///</summary>
        [EnumString("log")]
        Logarithmic,
        ///<summary>
        ///Moving Average.
        ///<para>When the item is serialized out as xml, its value is "movingAvg".</para>
        ///</summary>
        [EnumString("movingAvg")]
        MovingAverage,
        ///<summary>
        ///Polynomial.
        ///<para>When the item is serialized out as xml, its value is "poly".</para>
        ///</summary>
        [EnumString("poly")]
        Polynomial,
        ///<summary>
        ///Power.
        ///<para>When the item is serialized out as xml, its value is "power".</para>
        ///</summary>
        [EnumString("power")]
        Power,
    }

    /// <summary>
    /// Error Bar Direction
    /// </summary>
    public enum ErrorBarDirectionValues
    {
        ///<summary>
        ///X.
        ///<para>When the item is serialized out as xml, its value is "x".</para>
        ///</summary>
        [EnumString("x")]
        X,
        ///<summary>
        ///Y.
        ///<para>When the item is serialized out as xml, its value is "y".</para>
        ///</summary>
        [EnumString("y")]
        Y,
    }

    /// <summary>
    /// Error Bar Type
    /// </summary>
    public enum ErrorBarValues
    {
        ///<summary>
        ///Both.
        ///<para>When the item is serialized out as xml, its value is "both".</para>
        ///</summary>
        [EnumString("both")]
        Both,
        ///<summary>
        ///Minus.
        ///<para>When the item is serialized out as xml, its value is "minus".</para>
        ///</summary>
        [EnumString("minus")]
        Minus,
        ///<summary>
        ///Plus.
        ///<para>When the item is serialized out as xml, its value is "plus".</para>
        ///</summary>
        [EnumString("plus")]
        Plus,
    }

    /// <summary>
    /// Error Value Type
    /// </summary>
    public enum ErrorValues
    {
        ///<summary>
        ///Custom Error Bars.
        ///<para>When the item is serialized out as xml, its value is "cust".</para>
        ///</summary>
        [EnumString("cust")]
        Custom,
        ///<summary>
        ///Fixed Value.
        ///<para>When the item is serialized out as xml, its value is "fixedVal".</para>
        ///</summary>
        [EnumString("fixedVal")]
        FixedValue,
        ///<summary>
        ///Percentage.
        ///<para>When the item is serialized out as xml, its value is "percentage".</para>
        ///</summary>
        [EnumString("percentage")]
        Percentage,
        ///<summary>
        ///Standard Deviation.
        ///<para>When the item is serialized out as xml, its value is "stdDev".</para>
        ///</summary>
        [EnumString("stdDev")]
        StandardDeviation,
        ///<summary>
        ///Standard Error.
        ///<para>When the item is serialized out as xml, its value is "stdErr".</para>
        ///</summary>
        [EnumString("stdErr")]
        StandardError,
    }

    /// <summary>
    /// Grouping
    /// </summary>
    public enum GroupingValues
    {
        ///<summary>
        ///100% Stacked.
        ///<para>When the item is serialized out as xml, its value is "percentStacked".</para>
        ///</summary>
        [EnumString("percentStacked")]
        PercentStacked,
        ///<summary>
        ///Standard.
        ///<para>When the item is serialized out as xml, its value is "standard".</para>
        ///</summary>
        [EnumString("standard")]
        Standard,
        ///<summary>
        ///Stacked.
        ///<para>When the item is serialized out as xml, its value is "stacked".</para>
        ///</summary>
        [EnumString("stacked")]
        Stacked,
    }

    /// <summary>
    /// Radar Style
    /// </summary>
    public enum RadarStyleValues
    {
        ///<summary>
        ///Standard.
        ///<para>When the item is serialized out as xml, its value is "standard".</para>
        ///</summary>
        [EnumString("standard")]
        Standard,
        ///<summary>
        ///Marker.
        ///<para>When the item is serialized out as xml, its value is "marker".</para>
        ///</summary>
        [EnumString("marker")]
        Marker,
        ///<summary>
        ///Filled.
        ///<para>When the item is serialized out as xml, its value is "filled".</para>
        ///</summary>
        [EnumString("filled")]
        Filled,
    }

    /// <summary>
    /// Bar Grouping
    /// </summary>
    public enum BarGroupingValues
    {
        ///<summary>
        ///100% Stacked.
        ///<para>When the item is serialized out as xml, its value is "percentStacked".</para>
        ///</summary>
        [EnumString("percentStacked")]
        PercentStacked,
        ///<summary>
        ///Clustered.
        ///<para>When the item is serialized out as xml, its value is "clustered".</para>
        ///</summary>
        [EnumString("clustered")]
        Clustered,
        ///<summary>
        ///Standard.
        ///<para>When the item is serialized out as xml, its value is "standard".</para>
        ///</summary>
        [EnumString("standard")]
        Standard,
        ///<summary>
        ///Stacked.
        ///<para>When the item is serialized out as xml, its value is "stacked".</para>
        ///</summary>
        [EnumString("stacked")]
        Stacked,
    }

    /// <summary>
    /// Bar Direction
    /// </summary>
    public enum BarDirectionValues
    {
        ///<summary>
        ///Bar.
        ///<para>When the item is serialized out as xml, its value is "bar".</para>
        ///</summary>
        [EnumString("bar")]
        Bar,
        ///<summary>
        ///Column.
        ///<para>When the item is serialized out as xml, its value is "col".</para>
        ///</summary>
        [EnumString("col")]
        Column,
    }

    /// <summary>
    /// Shape
    /// </summary>
    public enum ShapeValues
    {
        ///<summary>
        ///Cone.
        ///<para>When the item is serialized out as xml, its value is "cone".</para>
        ///</summary>
        [EnumString("cone")]
        Cone,
        ///<summary>
        ///Cone to Max.
        ///<para>When the item is serialized out as xml, its value is "coneToMax".</para>
        ///</summary>
        [EnumString("coneToMax")]
        ConeToMax,
        ///<summary>
        ///Box.
        ///<para>When the item is serialized out as xml, its value is "box".</para>
        ///</summary>
        [EnumString("box")]
        Box,
        ///<summary>
        ///Cylinder.
        ///<para>When the item is serialized out as xml, its value is "cylinder".</para>
        ///</summary>
        [EnumString("cylinder")]
        Cylinder,
        ///<summary>
        ///Pyramid.
        ///<para>When the item is serialized out as xml, its value is "pyramid".</para>
        ///</summary>
        [EnumString("pyramid")]
        Pyramid,
        ///<summary>
        ///Pyramid to Maximum.
        ///<para>When the item is serialized out as xml, its value is "pyramidToMax".</para>
        ///</summary>
        [EnumString("pyramidToMax")]
        PyramidToMaximum,
    }

    /// <summary>
    /// Pie of Pie or Bar of Pie Type
    /// </summary>
    public enum OfPieValues
    {
        ///<summary>
        ///Pie.
        ///<para>When the item is serialized out as xml, its value is "pie".</para>
        ///</summary>
        [EnumString("pie")]
        Pie,
        ///<summary>
        ///Bar.
        ///<para>When the item is serialized out as xml, its value is "bar".</para>
        ///</summary>
        [EnumString("bar")]
        Bar,
    }

    /// <summary>
    /// Axis Position
    /// </summary>
    public enum AxisPositionValues
    {
        ///<summary>
        ///Bottom.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        Bottom,
        ///<summary>
        ///Left.
        ///<para>When the item is serialized out as xml, its value is "l".</para>
        ///</summary>
        [EnumString("l")]
        Left,
        ///<summary>
        ///Right.
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        Right,
        ///<summary>
        ///Top.
        ///<para>When the item is serialized out as xml, its value is "t".</para>
        ///</summary>
        [EnumString("t")]
        Top,
    }

    /// <summary>
    /// Crosses
    /// </summary>
    public enum CrossesValues
    {
        ///<summary>
        ///Axis Crosses at Zero.
        ///<para>When the item is serialized out as xml, its value is "autoZero".</para>
        ///</summary>
        [EnumString("autoZero")]
        AutoZero,
        ///<summary>
        ///Maximum.
        ///<para>When the item is serialized out as xml, its value is "max".</para>
        ///</summary>
        [EnumString("max")]
        Maximum,
        ///<summary>
        ///Minimum.
        ///<para>When the item is serialized out as xml, its value is "min".</para>
        ///</summary>
        [EnumString("min")]
        Minimum,
    }

    /// <summary>
    /// Cross Between
    /// </summary>
    public enum CrossBetweenValues
    {
        ///<summary>
        ///Between.
        ///<para>When the item is serialized out as xml, its value is "between".</para>
        ///</summary>
        [EnumString("between")]
        Between,
        ///<summary>
        ///Midpoint of Category.
        ///<para>When the item is serialized out as xml, its value is "midCat".</para>
        ///</summary>
        [EnumString("midCat")]
        MidpointCategory,
    }

    /// <summary>
    /// Tick Mark
    /// </summary>
    public enum TickMarkValues
    {
        ///<summary>
        ///Cross.
        ///<para>When the item is serialized out as xml, its value is "cross".</para>
        ///</summary>
        [EnumString("cross")]
        Cross,
        ///<summary>
        ///Inside.
        ///<para>When the item is serialized out as xml, its value is "in".</para>
        ///</summary>
        [EnumString("in")]
        Inside,
        ///<summary>
        ///None.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Outside.
        ///<para>When the item is serialized out as xml, its value is "out".</para>
        ///</summary>
        [EnumString("out")]
        Outside,
    }

    /// <summary>
    /// Tick Label Position
    /// </summary>
    public enum TickLabelPositionValues
    {
        ///<summary>
        ///High.
        ///<para>When the item is serialized out as xml, its value is "high".</para>
        ///</summary>
        [EnumString("high")]
        High,
        ///<summary>
        ///Low.
        ///<para>When the item is serialized out as xml, its value is "low".</para>
        ///</summary>
        [EnumString("low")]
        Low,
        ///<summary>
        ///Next To.
        ///<para>When the item is serialized out as xml, its value is "nextTo".</para>
        ///</summary>
        [EnumString("nextTo")]
        NextTo,
        ///<summary>
        ///None.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
    }

    /// <summary>
    /// Time Unit
    /// </summary>
    public enum TimeUnitValues
    {
        ///<summary>
        ///Days.
        ///<para>When the item is serialized out as xml, its value is "days".</para>
        ///</summary>
        [EnumString("days")]
        Days,
        ///<summary>
        ///Months.
        ///<para>When the item is serialized out as xml, its value is "months".</para>
        ///</summary>
        [EnumString("months")]
        Months,
        ///<summary>
        ///Years.
        ///<para>When the item is serialized out as xml, its value is "years".</para>
        ///</summary>
        [EnumString("years")]
        Years,
    }

    /// <summary>
    /// Built-In Unit
    /// </summary>
    public enum BuiltInUnitValues
    {
        ///<summary>
        ///Hundreds.
        ///<para>When the item is serialized out as xml, its value is "hundreds".</para>
        ///</summary>
        [EnumString("hundreds")]
        Hundreds,
        ///<summary>
        ///Thousands.
        ///<para>When the item is serialized out as xml, its value is "thousands".</para>
        ///</summary>
        [EnumString("thousands")]
        Thousands,
        ///<summary>
        ///Ten Thousands.
        ///<para>When the item is serialized out as xml, its value is "tenThousands".</para>
        ///</summary>
        [EnumString("tenThousands")]
        TenThousands,
        ///<summary>
        ///Hundred Thousands.
        ///<para>When the item is serialized out as xml, its value is "hundredThousands".</para>
        ///</summary>
        [EnumString("hundredThousands")]
        HundredThousands,
        ///<summary>
        ///Millions.
        ///<para>When the item is serialized out as xml, its value is "millions".</para>
        ///</summary>
        [EnumString("millions")]
        Millions,
        ///<summary>
        ///Ten Millions.
        ///<para>When the item is serialized out as xml, its value is "tenMillions".</para>
        ///</summary>
        [EnumString("tenMillions")]
        TenMillions,
        ///<summary>
        ///Hundred Millions.
        ///<para>When the item is serialized out as xml, its value is "hundredMillions".</para>
        ///</summary>
        [EnumString("hundredMillions")]
        HundredMillions,
        ///<summary>
        ///Billions.
        ///<para>When the item is serialized out as xml, its value is "billions".</para>
        ///</summary>
        [EnumString("billions")]
        Billions,
        ///<summary>
        ///Trillions.
        ///<para>When the item is serialized out as xml, its value is "trillions".</para>
        ///</summary>
        [EnumString("trillions")]
        Trillions,
    }

    /// <summary>
    /// Picture Format
    /// </summary>
    public enum PictureFormatValues
    {
        ///<summary>
        ///Stretch.
        ///<para>When the item is serialized out as xml, its value is "stretch".</para>
        ///</summary>
        [EnumString("stretch")]
        Stretch,
        ///<summary>
        ///Stack.
        ///<para>When the item is serialized out as xml, its value is "stack".</para>
        ///</summary>
        [EnumString("stack")]
        Stack,
        ///<summary>
        ///Stack and Scale.
        ///<para>When the item is serialized out as xml, its value is "stackScale".</para>
        ///</summary>
        [EnumString("stackScale")]
        StackScale,
    }

    /// <summary>
    /// Orientation
    /// </summary>
    public enum OrientationValues
    {
        ///<summary>
        ///Maximum to Minimum.
        ///<para>When the item is serialized out as xml, its value is "maxMin".</para>
        ///</summary>
        [EnumString("maxMin")]
        MaxMin,
        ///<summary>
        ///Minimum to Maximum.
        ///<para>When the item is serialized out as xml, its value is "minMax".</para>
        ///</summary>
        [EnumString("minMax")]
        MinMax,
    }

    /// <summary>
    /// Legend Position
    /// </summary>
    public enum LegendPositionValues
    {
        ///<summary>
        ///Bottom.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        Bottom,
        ///<summary>
        ///Top Right.
        ///<para>When the item is serialized out as xml, its value is "tr".</para>
        ///</summary>
        [EnumString("tr")]
        TopRight,
        ///<summary>
        ///Left.
        ///<para>When the item is serialized out as xml, its value is "l".</para>
        ///</summary>
        [EnumString("l")]
        Left,
        ///<summary>
        ///Right.
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        Right,
        ///<summary>
        ///Top.
        ///<para>When the item is serialized out as xml, its value is "t".</para>
        ///</summary>
        [EnumString("t")]
        Top,
    }

    /// <summary>
    /// Display Blanks As
    /// </summary>
    public enum DisplayBlanksAsValues
    {
        ///<summary>
        ///Span.
        ///<para>When the item is serialized out as xml, its value is "span".</para>
        ///</summary>
        [EnumString("span")]
        Span,
        ///<summary>
        ///Gap.
        ///<para>When the item is serialized out as xml, its value is "gap".</para>
        ///</summary>
        [EnumString("gap")]
        Gap,
        ///<summary>
        ///Zero.
        ///<para>When the item is serialized out as xml, its value is "zero".</para>
        ///</summary>
        [EnumString("zero")]
        Zero,
    }

    /// <summary>
    /// Printed Page Orientation
    /// </summary>
    public enum PageSetupOrientationValues
    {
        ///<summary>
        ///Default Page Orientation.
        ///<para>When the item is serialized out as xml, its value is "default".</para>
        ///</summary>
        [EnumString("default")]
        Default,
        ///<summary>
        ///Portrait Page.
        ///<para>When the item is serialized out as xml, its value is "portrait".</para>
        ///</summary>
        [EnumString("portrait")]
        Portrait,
        ///<summary>
        ///Landscape Page.
        ///<para>When the item is serialized out as xml, its value is "landscape".</para>
        ///</summary>
        [EnumString("landscape")]
        Landscape,
    }

    /// <summary>
    /// Scatter Style
    /// </summary>
    public enum ScatterStyleValues
    {
        ///<summary>
        ///Line.
        ///<para>When the item is serialized out as xml, its value is "line".</para>
        ///</summary>
        [EnumString("line")]
        Line,
        ///<summary>
        ///Line with Markers.
        ///<para>When the item is serialized out as xml, its value is "lineMarker".</para>
        ///</summary>
        [EnumString("lineMarker")]
        LineMarker,
        ///<summary>
        ///Marker.
        ///<para>When the item is serialized out as xml, its value is "marker".</para>
        ///</summary>
        [EnumString("marker")]
        Marker,
        ///<summary>
        ///Smooth.
        ///<para>When the item is serialized out as xml, its value is "smooth".</para>
        ///</summary>
        [EnumString("smooth")]
        Smooth,
        ///<summary>
        ///Smooth with Markers.
        ///<para>When the item is serialized out as xml, its value is "smoothMarker".</para>
        ///</summary>
        [EnumString("smoothMarker")]
        SmoothMarker,
    }

    /// <summary>
    /// Marker Style
    /// </summary>
    public enum MarkerStyleValues
    {
        ///<summary>
        ///auto.
        ///<para>When the item is serialized out as xml, its value is "auto".</para>
        ///</summary>
        [EnumString("auto")]
        Auto,
        ///<summary>
        ///Circle.
        ///<para>When the item is serialized out as xml, its value is "circle".</para>
        ///</summary>
        [EnumString("circle")]
        Circle,
        ///<summary>
        ///Dash.
        ///<para>When the item is serialized out as xml, its value is "dash".</para>
        ///</summary>
        [EnumString("dash")]
        Dash,
        ///<summary>
        ///Diamond.
        ///<para>When the item is serialized out as xml, its value is "diamond".</para>
        ///</summary>
        [EnumString("diamond")]
        Diamond,
        ///<summary>
        ///Dot.
        ///<para>When the item is serialized out as xml, its value is "dot".</para>
        ///</summary>
        [EnumString("dot")]
        Dot,
        ///<summary>
        ///None.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Picture.
        ///<para>When the item is serialized out as xml, its value is "picture".</para>
        ///</summary>
        [EnumString("picture")]
        Picture,
        ///<summary>
        ///Plus.
        ///<para>When the item is serialized out as xml, its value is "plus".</para>
        ///</summary>
        [EnumString("plus")]
        Plus,
        ///<summary>
        ///Square.
        ///<para>When the item is serialized out as xml, its value is "square".</para>
        ///</summary>
        [EnumString("square")]
        Square,
        ///<summary>
        ///Star.
        ///<para>When the item is serialized out as xml, its value is "star".</para>
        ///</summary>
        [EnumString("star")]
        Star,
        ///<summary>
        ///Triangle.
        ///<para>When the item is serialized out as xml, its value is "triangle".</para>
        ///</summary>
        [EnumString("triangle")]
        Triangle,
        ///<summary>
        ///X.
        ///<para>When the item is serialized out as xml, its value is "x".</para>
        ///</summary>
        [EnumString("x")]
        X,
    }

    /// <summary>
    /// Split Type
    /// </summary>
    public enum SplitValues
    {
        ///<summary>
        ///Custom Split.
        ///<para>When the item is serialized out as xml, its value is "cust".</para>
        ///</summary>
        [EnumString("cust")]
        Custom,
        ///<summary>
        ///Split by Percentage.
        ///<para>When the item is serialized out as xml, its value is "percent".</para>
        ///</summary>
        [EnumString("percent")]
        Percent,
        ///<summary>
        ///Split by Position.
        ///<para>When the item is serialized out as xml, its value is "pos".</para>
        ///</summary>
        [EnumString("pos")]
        Position,
        ///<summary>
        ///Split by Value.
        ///<para>When the item is serialized out as xml, its value is "val".</para>
        ///</summary>
        [EnumString("val")]
        Value,
    }
}