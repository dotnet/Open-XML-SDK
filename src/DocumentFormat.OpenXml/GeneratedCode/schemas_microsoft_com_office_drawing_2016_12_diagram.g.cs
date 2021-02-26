// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Drawing.Diagram12
{
    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm1612:spPr.</para>
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
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(104, "spPr")]
#pragma warning restore CS0618 // Type or member is obsolete
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

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "bwMode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(104, "spPr");
            builder.Availability = FileFormatVersions.Office2019;
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
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Transform2D), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
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
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
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
        public DocumentFormat.OpenXml.Drawing.Transform2D? Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the TextListStyleType Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm1612:lstStyle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties &lt;a:defPPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties &lt;a:lvl1pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties &lt;a:lvl2pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties &lt;a:lvl3pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties &lt;a:lvl4pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties &lt;a:lvl5pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties &lt;a:lvl6pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties &lt;a:lvl7pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties &lt;a:lvl8pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties &lt;a:lvl9pPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(104, "lstStyle")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextListStyleType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextListStyleType class.
        /// </summary>
        public TextListStyleType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextListStyleType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextListStyleType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextListStyleType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextListStyleType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextListStyleType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextListStyleType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(104, "lstStyle");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Default Paragraph Style.</para>
        /// <para>Represents the following element tag in the schema: a:defPPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties? DefaultParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 1 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl1pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties? Level1ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 2 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl2pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties? Level2ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 3 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl3pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties? Level3ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 4 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl4pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties? Level4ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 5 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl5pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? Level5ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 6 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl6pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties? Level6ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 7 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl7pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties? Level7ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 8 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl8pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties? Level8ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 9 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl9pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties? Level9ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties>();
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextListStyleType>(deep);
    }
}