// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2010.Drawing.Pictures;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Drawing.Pictures
{
    /// <summary>
    /// <para>Picture.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pic:pic.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualPictureProperties &lt;pic:nvPicPr></description></item>
    ///   <item><description>BlipFill &lt;pic:blipFill></description></item>
    ///   <item><description>ShapeProperties &lt;pic:spPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle &lt;pic14:style></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Drawing.Pictures.OfficeArtExtensionList &lt;pic14:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Picture : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Picture class.
        /// </summary>
        public Picture() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Picture class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Picture(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Picture class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Picture(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Picture class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Picture(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(17, "pic");
            builder.AddChild<NonVisualPictureProperties>();
            builder.AddChild<BlipFill>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.Pictures.OfficeArtExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Pictures.BlipFill), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Pictures.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>Non-Visual Picture Properties.</para>
        /// <para>Represents the following element tag in the schema: pic:nvPicPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:pic = http://schemas.openxmlformats.org/drawingml/2006/picture
        /// </remark>
        public NonVisualPictureProperties NonVisualPictureProperties
        {
            get => GetElement<NonVisualPictureProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Picture Fill.</para>
        /// <para>Represents the following element tag in the schema: pic:blipFill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:pic = http://schemas.openxmlformats.org/drawingml/2006/picture
        /// </remark>
        public BlipFill BlipFill
        {
            get => GetElement<BlipFill>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: pic:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:pic = http://schemas.openxmlformats.org/drawingml/2006/picture
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeStyle.</para>
        /// <para>Represents the following element tag in the schema: pic14:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:pic14 = http://schemas.microsoft.com/office/drawing/2010/picture
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle ShapeStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: pic14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:pic14 = http://schemas.microsoft.com/office/drawing/2010/picture
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.Pictures.OfficeArtExtensionList OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.Pictures.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Picture>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Drawing Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pic:cNvPr.</para>
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
            builder.SetSchema(17, "cNvPr");
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
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, true, typeof(DocumentFormat.OpenXml.Drawing.GraphicData)));
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
    /// <para>Non-Visual Picture Drawing Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pic:cNvPicPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PictureLocks &lt;a:picLocks></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class NonVisualPictureDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class.
        /// </summary>
        public NonVisualPictureDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualPictureDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>preferRelativeResize</para>
        /// <para>Represents the following attribute in the schema: preferRelativeResize</para>
        /// </summary>
        public BooleanValue PreferRelativeResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(17, "cNvPicPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PictureLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>();
            builder.AddElement<NonVisualPictureDrawingProperties>()
.AddAttribute(0, "preferRelativeResize", a => a.PreferRelativeResize);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PictureLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>PictureLocks.</para>
        /// <para>Represents the following element tag in the schema: a:picLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PictureLocks PictureLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PictureLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualPicturePropertiesExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList NonVisualPicturePropertiesExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualPictureDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Picture Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pic:nvPicPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>NonVisualDrawingProperties &lt;pic:cNvPr></description></item>
    ///   <item><description>NonVisualPictureDrawingProperties &lt;pic:cNvPicPr></description></item>
    /// </list>
    /// </remark>
    public partial class NonVisualPictureProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class.
        /// </summary>
        public NonVisualPictureProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualPictureProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(17, "nvPicPr");
            builder.AddChild<NonVisualDrawingProperties>();
            builder.AddChild<NonVisualPictureDrawingProperties>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Pictures.NonVisualDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureDrawingProperties), 1, 1)
            };
        }

        /// <summary>
        /// <para>Non-Visual Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: pic:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:pic = http://schemas.openxmlformats.org/drawingml/2006/picture
        /// </remark>
        public NonVisualDrawingProperties NonVisualDrawingProperties
        {
            get => GetElement<NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Picture Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: pic:cNvPicPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:pic = http://schemas.openxmlformats.org/drawingml/2006/picture
        /// </remark>
        public NonVisualPictureDrawingProperties NonVisualPictureDrawingProperties
        {
            get => GetElement<NonVisualPictureDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualPictureProperties>(deep);
    }

    /// <summary>
    /// <para>Picture Fill.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pic:blipFill.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Blip &lt;a:blip></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SourceRectangle &lt;a:srcRect></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Tile &lt;a:tile></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Stretch &lt;a:stretch></description></item>
    /// </list>
    /// </remark>
    public partial class BlipFill : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BlipFill class.
        /// </summary>
        public BlipFill() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFill class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BlipFill(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFill class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BlipFill(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFill class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BlipFill(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>DPI Setting</para>
        /// <para>Represents the following attribute in the schema: dpi</para>
        /// </summary>
        public UInt32Value Dpi
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Rotate With Shape</para>
        /// <para>Represents the following attribute in the schema: rotWithShape</para>
        /// </summary>
        public BooleanValue RotateWithShape
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(17, "blipFill");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Blip>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SourceRectangle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Tile>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Stretch>();
            builder.AddElement<BlipFill>()
.AddAttribute(0, "dpi", a => a.Dpi)
.AddAttribute(0, "rotWithShape", a => a.RotateWithShape);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Blip), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SourceRectangle), 0, 1),
                new CompositeParticle(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Tile), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Stretch), 1, 1)
                    }
                }
            };
        }

        /// <summary>
        /// <para>Blip.</para>
        /// <para>Represents the following element tag in the schema: a:blip.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Blip Blip
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Blip>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Source Rectangle.</para>
        /// <para>Represents the following element tag in the schema: a:srcRect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SourceRectangle SourceRectangle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SourceRectangle>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BlipFill>(deep);
    }

    /// <summary>
    /// <para>Shape Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pic:spPr.</para>
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
            builder.SetSchema(17, "spPr");
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
}