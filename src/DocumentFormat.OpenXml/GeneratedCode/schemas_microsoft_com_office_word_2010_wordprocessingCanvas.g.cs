// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Pictures;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Office2010.Word.DrawingGroup;
using DocumentFormat.OpenXml.Office2010.Word.DrawingShape;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas
{
    /// <summary>
    /// <para>Defines the WordprocessingCanvas Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wpc:wpc.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BackgroundFormatting &lt;wpc:bg></description></item>
    ///   <item><description>WholeFormatting &lt;wpc:whole></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingShape.WordprocessingShape &lt;wps:wsp></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Pictures.Picture &lt;pic:pic></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.ContentPart &lt;w14:contentPart></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroup &lt;wpg:wgp></description></item>
    ///   <item><description>GraphicFrameType &lt;wpc:graphicFrame></description></item>
    ///   <item><description>OfficeArtExtensionList &lt;wpc:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class WordprocessingCanvas : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WordprocessingCanvas class.
        /// </summary>
        public WordprocessingCanvas() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WordprocessingCanvas class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WordprocessingCanvas(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WordprocessingCanvas class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WordprocessingCanvas(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WordprocessingCanvas class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WordprocessingCanvas(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(59, "wpc");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<BackgroundFormatting>();
            builder.AddChild<WholeFormatting>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.WordprocessingShape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Pictures.Picture>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.ContentPart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroup>();
            builder.AddChild<GraphicFrameType>();
            builder.AddChild<OfficeArtExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.BackgroundFormatting), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.WholeFormatting), 0, 1, version: FileFormatVersions.Office2010),
                new CompositeParticle(ParticleType.Choice, 0, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.WordprocessingShape), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Pictures.Picture), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.ContentPart), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroup), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.GraphicFrameType), 1, 1, version: FileFormatVersions.Office2010)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>BackgroundFormatting.</para>
        /// <para>Represents the following element tag in the schema: wpc:bg.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wpc = http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas
        /// </remark>
        public BackgroundFormatting BackgroundFormatting
        {
            get => GetElement<BackgroundFormatting>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>WholeFormatting.</para>
        /// <para>Represents the following element tag in the schema: wpc:whole.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wpc = http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas
        /// </remark>
        public WholeFormatting WholeFormatting
        {
            get => GetElement<WholeFormatting>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WordprocessingCanvas>(deep);
    }

    /// <summary>
    /// <para>Defines the BackgroundFormatting Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wpc:bg.</para>
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
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
    /// </list>
    /// </remark>
    public partial class BackgroundFormatting : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackgroundFormatting class.
        /// </summary>
        public BackgroundFormatting() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundFormatting class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackgroundFormatting(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundFormatting class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackgroundFormatting(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundFormatting class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackgroundFormatting(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(59, "bg");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
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
                new CompositeParticle(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundFormatting>(deep);
    }

    /// <summary>
    /// <para>Defines the WholeFormatting Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wpc:whole.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
    /// </list>
    /// </remark>
    public partial class WholeFormatting : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WholeFormatting class.
        /// </summary>
        public WholeFormatting() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WholeFormatting class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WholeFormatting(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WholeFormatting class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WholeFormatting(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WholeFormatting class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WholeFormatting(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(59, "whole");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Outline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
                new CompositeParticle(ParticleType.Group, 0, 1)
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
        /// <para>Outline.</para>
        /// <para>Represents the following element tag in the schema: a:ln.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Outline Outline
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Outline>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WholeFormatting>(deep);
    }

    /// <summary>
    /// <para>Defines the GraphicFrameType Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wpc:graphicFrame.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties &lt;wpg:cNvPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties &lt;wpg:cNvFrPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D &lt;wpg:xfrm></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Graphic &lt;a:graphic></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList &lt;wpg:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class GraphicFrameType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GraphicFrameType class.
        /// </summary>
        public GraphicFrameType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrameType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicFrameType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrameType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicFrameType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrameType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GraphicFrameType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(59, "graphicFrame");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Graphic>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Graphic), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>NonVisualDrawingProperties.</para>
        /// <para>Represents the following element tag in the schema: wpg:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wpg = http://schemas.microsoft.com/office/word/2010/wordprocessingGroup
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties NonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualGraphicFrameProperties.</para>
        /// <para>Represents the following element tag in the schema: wpg:cNvFrPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wpg = http://schemas.microsoft.com/office/word/2010/wordprocessingGroup
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties NonVisualGraphicFrameProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Transform2D.</para>
        /// <para>Represents the following element tag in the schema: wpg:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wpg = http://schemas.microsoft.com/office/word/2010/wordprocessingGroup
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Graphic.</para>
        /// <para>Represents the following element tag in the schema: a:graphic.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Graphic Graphic
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Graphic>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: wpg:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wpg = http://schemas.microsoft.com/office/word/2010/wordprocessingGroup
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GraphicFrameType>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wpc:extLst.</para>
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
            builder.SetSchema(59, "extLst");
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
}