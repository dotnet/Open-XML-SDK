// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml.Vml.Presentation;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using DocumentFormat.OpenXml.Vml.Wordprocessing;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Vml
{
    /// <summary>
    /// <para>Defines the Path Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:path.</para>
    /// </summary>
    public partial class Path : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Path class.
        /// </summary>
        public Path() : base()
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Path Definition</para>
        /// <para>Represents the following attribute in the schema: v</para>
        /// </summary>
        public StringValue Value
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Limo Stretch Point</para>
        /// <para>Represents the following attribute in the schema: limo</para>
        /// </summary>
        public StringValue Limo
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Box Bounding Box</para>
        /// <para>Represents the following attribute in the schema: textboxrect</para>
        /// </summary>
        public StringValue TextboxRectangle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: fillok</para>
        /// </summary>
        public TrueFalseValue AllowFill
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: strokeok</para>
        /// </summary>
        public TrueFalseValue AllowStroke
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Toggle</para>
        /// <para>Represents the following attribute in the schema: shadowok</para>
        /// </summary>
        public TrueFalseValue AllowShading
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Arrowhead Display Toggle</para>
        /// <para>Represents the following attribute in the schema: arrowok</para>
        /// </summary>
        public TrueFalseValue ShowArrowhead
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Gradient Shape Toggle</para>
        /// <para>Represents the following attribute in the schema: gradientshapeok</para>
        /// </summary>
        public TrueFalseValue AllowGradientShape
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Path Toggle</para>
        /// <para>Represents the following attribute in the schema: textpathok</para>
        /// </summary>
        public TrueFalseValue AllowTextPath
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Stroke From Path Flag</para>
        /// <para>Represents the following attribute in the schema: insetpenok</para>
        /// </summary>
        public TrueFalseValue AllowInsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Connection Point Type</para>
        /// <para>Represents the following attribute in the schema: o:connecttype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues> ConnectionPointType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Connection Points</para>
        /// <para>Represents the following attribute in the schema: o:connectlocs</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue ConnectionPoints
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Connection Point Connect Angles</para>
        /// <para>Represents the following attribute in the schema: o:connectangles</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue ConnectAngles
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extrusion Toggle</para>
        /// <para>Represents the following attribute in the schema: o:extrusionok</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowExtrusion
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "path");
            builder.AddElement<Path>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "v", a => a.Value)
.AddAttribute(0, "limo", a => a.Limo)
.AddAttribute(0, "textboxrect", a => a.TextboxRectangle)
.AddAttribute(0, "fillok", a => a.AllowFill)
.AddAttribute(0, "strokeok", a => a.AllowStroke)
.AddAttribute(0, "shadowok", a => a.AllowShading)
.AddAttribute(0, "arrowok", a => a.ShowArrowhead)
.AddAttribute(0, "gradientshapeok", a => a.AllowGradientShape)
.AddAttribute(0, "textpathok", a => a.AllowTextPath)
.AddAttribute(0, "insetpenok", a => a.AllowInsetPen)
.AddAttribute(27, "connecttype", a => a.ConnectionPointType)
.AddAttribute(27, "connectlocs", a => a.ConnectionPoints)
.AddAttribute(27, "connectangles", a => a.ConnectAngles)
.AddAttribute(27, "extrusionok", a => a.AllowExtrusion);
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Path>(deep);
    }

    /// <summary>
    /// <para>Defines the Formulas Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:formulas.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Formula &lt;v:f></description></item>
    /// </list>
    /// </remark>
    public partial class Formulas : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Formulas class.
        /// </summary>
        public Formulas() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Formulas class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Formulas(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Formulas class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Formulas(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Formulas class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Formulas(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "formulas");
            builder.AddChild<Formula>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formula), 0, 128)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formulas>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeHandles Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:handles.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ShapeHandle &lt;v:h></description></item>
    /// </list>
    /// </remark>
    public partial class ShapeHandles : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeHandles class.
        /// </summary>
        public ShapeHandles() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeHandles class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeHandles(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeHandles class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeHandles(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeHandles class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeHandles(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "handles");
            builder.AddChild<ShapeHandle>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandle), 0, 4)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeHandles>(deep);
    }

    /// <summary>
    /// <para>Defines the Fill Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:fill.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties &lt;o:fill></description></item>
    /// </list>
    /// </remark>
    public partial class Fill : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Fill class.
        /// </summary>
        public Fill() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Fill class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Fill(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Fill class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Fill(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Fill class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Fill(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: on</para>
        /// </summary>
        public TrueFalseValue On
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Primary Color</para>
        /// <para>Represents the following attribute in the schema: color</para>
        /// </summary>
        public StringValue Color
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Primary Color Opacity</para>
        /// <para>Represents the following attribute in the schema: opacity</para>
        /// </summary>
        public StringValue Opacity
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Secondary Color</para>
        /// <para>Represents the following attribute in the schema: color2</para>
        /// </summary>
        public StringValue Color2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Image Source</para>
        /// <para>Represents the following attribute in the schema: src</para>
        /// </summary>
        public StringValue Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: o:href</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alternate Image Reference Location</para>
        /// <para>Represents the following attribute in the schema: o:althref</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue AlternateImageReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Image Size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        public StringValue Size
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Image Origin</para>
        /// <para>Represents the following attribute in the schema: origin</para>
        /// </summary>
        public StringValue Origin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Image Position</para>
        /// <para>Represents the following attribute in the schema: position</para>
        /// </summary>
        public StringValue Position
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Aspect Ratio</para>
        /// <para>Represents the following attribute in the schema: aspect</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues> Aspect
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Intermediate Colors</para>
        /// <para>Represents the following attribute in the schema: colors</para>
        /// </summary>
        public StringValue Colors
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Gradient Angle</para>
        /// <para>Represents the following attribute in the schema: angle</para>
        /// </summary>
        public DecimalValue Angle
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Align Image With Shape</para>
        /// <para>Represents the following attribute in the schema: alignshape</para>
        /// </summary>
        public TrueFalseValue AlignShape
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Gradient Center</para>
        /// <para>Represents the following attribute in the schema: focus</para>
        /// </summary>
        public StringValue Focus
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Radial Gradient Size</para>
        /// <para>Represents the following attribute in the schema: focussize</para>
        /// </summary>
        public StringValue FocusSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Radial Gradient Center</para>
        /// <para>Represents the following attribute in the schema: focusposition</para>
        /// </summary>
        public StringValue FocusPosition
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Gradient Fill Method</para>
        /// <para>Represents the following attribute in the schema: method</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.FillMethodValues> Method
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.FillMethodValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Detect Mouse Click</para>
        /// <para>Represents the following attribute in the schema: o:detectmouseclick</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue DetectMouseClick
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Title</para>
        /// <para>Represents the following attribute in the schema: o:title</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Secondary Color Opacity</para>
        /// <para>Represents the following attribute in the schema: o:opacity2</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue Opacity2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Recolor Fill as Picture</para>
        /// <para>Represents the following attribute in the schema: recolor</para>
        /// </summary>
        public TrueFalseValue Recolor
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Rotate Fill with Shape</para>
        /// <para>Represents the following attribute in the schema: rotate</para>
        /// </summary>
        public TrueFalseValue Rotate
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relationship to Part</para>
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
            builder.SetSchema(26, "fill");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties>();
            builder.AddElement<Fill>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "on", a => a.On)
.AddAttribute(0, "color", a => a.Color)
.AddAttribute(0, "opacity", a => a.Opacity)
.AddAttribute(0, "color2", a => a.Color2)
.AddAttribute(0, "src", a => a.Source)
.AddAttribute(27, "href", a => a.Href)
.AddAttribute(27, "althref", a => a.AlternateImageReference)
.AddAttribute(0, "size", a => a.Size)
.AddAttribute(0, "origin", a => a.Origin)
.AddAttribute(0, "position", a => a.Position)
.AddAttribute(0, "aspect", a => a.Aspect)
.AddAttribute(0, "colors", a => a.Colors)
.AddAttribute(0, "angle", a => a.Angle)
.AddAttribute(0, "alignshape", a => a.AlignShape)
.AddAttribute(0, "focus", a => a.Focus)
.AddAttribute(0, "focussize", a => a.FocusSize)
.AddAttribute(0, "focusposition", a => a.FocusPosition)
.AddAttribute(0, "method", a => a.Method)
.AddAttribute(27, "detectmouseclick", a => a.DetectMouseClick)
.AddAttribute(27, "title", a => a.Title)
.AddAttribute(27, "opacity2", a => a.Opacity2)
.AddAttribute(0, "recolor", a => a.Recolor)
.AddAttribute(0, "rotate", a => a.Rotate)
.AddAttribute(19, "id", a => a.RelationshipId);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties), 0, 1)
            };
            builder.AddConstraint(new RelationshipTypeConstraint(25 /*r:id*/, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image"));
            builder.AddConstraint(new AttributeValuePatternConstraint(16 /*:focus*/, @"-?(\d{1,2}|100)%"));
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, false, null));
            builder.AddConstraint(new AttributeValueRangeConstraint(14 /*:angle*/, true, -32767, true, 32767, true));
            builder.AddConstraint(new AttributeValueRangeConstraint(10 /*:origin*/, true, -32767, true, 32767, true));
            builder.AddConstraint(new AttributeValueSetConstraint(21 /*ovml:title*/, false, new string[] { "slashes", "colons" }));
            builder.AddConstraint(new RelationshipExistConstraint(25 /*r:id*/));
        }

        /// <summary>
        /// <para>FillExtendedProperties.</para>
        /// <para>Represents the following element tag in the schema: o:fill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties FillExtendedProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Fill>(deep);
    }

    /// <summary>
    /// <para>Defines the Stroke Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:stroke.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.LeftStroke &lt;o:left></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.TopStroke &lt;o:top></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.RightStroke &lt;o:right></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.BottomStroke &lt;o:bottom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.ColumnStroke &lt;o:column></description></item>
    /// </list>
    /// </remark>
    public partial class Stroke : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Stroke class.
        /// </summary>
        public Stroke() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Stroke class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Stroke(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Stroke class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Stroke(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Stroke class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Stroke(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: on</para>
        /// </summary>
        public TrueFalseValue On
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: weight</para>
        /// </summary>
        public StringValue Weight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Color</para>
        /// <para>Represents the following attribute in the schema: color</para>
        /// </summary>
        public StringValue Color
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Opacity</para>
        /// <para>Represents the following attribute in the schema: opacity</para>
        /// </summary>
        public StringValue Opacity
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Line Style</para>
        /// <para>Represents the following attribute in the schema: linestyle</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues> LineStyle
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Miter Joint Limit</para>
        /// <para>Represents the following attribute in the schema: miterlimit</para>
        /// </summary>
        public StringValue Miterlimit
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Join Style</para>
        /// <para>Represents the following attribute in the schema: joinstyle</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues> JoinStyle
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Cap</para>
        /// <para>Represents the following attribute in the schema: endcap</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues> EndCap
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Dash Pattern</para>
        /// <para>Represents the following attribute in the schema: dashstyle</para>
        /// </summary>
        public StringValue DashStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Image Style</para>
        /// <para>Represents the following attribute in the schema: filltype</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues> FillType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeFillTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Image Location</para>
        /// <para>Represents the following attribute in the schema: src</para>
        /// </summary>
        public StringValue Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Image Aspect Ratio</para>
        /// <para>Represents the following attribute in the schema: imageaspect</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues> ImageAspect
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Image Size</para>
        /// <para>Represents the following attribute in the schema: imagesize</para>
        /// </summary>
        public StringValue ImageSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stoke Image Alignment</para>
        /// <para>Represents the following attribute in the schema: imagealignshape</para>
        /// </summary>
        public TrueFalseValue ImageAlignShape
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Alternate Pattern Color</para>
        /// <para>Represents the following attribute in the schema: color2</para>
        /// </summary>
        public StringValue Color2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line Start Arrowhead</para>
        /// <para>Represents the following attribute in the schema: startarrow</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues> StartArrow
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line Start Arrowhead Width</para>
        /// <para>Represents the following attribute in the schema: startarrowwidth</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues> StartArrowWidth
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line Start Arrowhead Length</para>
        /// <para>Represents the following attribute in the schema: startarrowlength</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues> StartArrowLength
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Arrowhead</para>
        /// <para>Represents the following attribute in the schema: endarrow</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues> EndArrow
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Arrowhead Width</para>
        /// <para>Represents the following attribute in the schema: endarrowwidth</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues> EndArrowWidth
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Arrowhead Length</para>
        /// <para>Represents the following attribute in the schema: endarrowlength</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues> EndArrowLength
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Original Image Reference</para>
        /// <para>Represents the following attribute in the schema: o:href</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alternate Image Reference</para>
        /// <para>Represents the following attribute in the schema: o:althref</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue AlternateImageReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Title</para>
        /// <para>Represents the following attribute in the schema: o:title</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relationship</para>
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

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>
        public TrueFalseValue Insetpen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "stroke");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.LeftStroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.TopStroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.RightStroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.BottomStroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ColumnStroke>();
            builder.AddElement<Stroke>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "on", a => a.On)
.AddAttribute(0, "weight", a => a.Weight)
.AddAttribute(0, "color", a => a.Color)
.AddAttribute(0, "opacity", a => a.Opacity)
.AddAttribute(0, "linestyle", a => a.LineStyle)
.AddAttribute(0, "miterlimit", a => a.Miterlimit)
.AddAttribute(0, "joinstyle", a => a.JoinStyle)
.AddAttribute(0, "endcap", a => a.EndCap)
.AddAttribute(0, "dashstyle", a => a.DashStyle)
.AddAttribute(0, "filltype", a => a.FillType)
.AddAttribute(0, "src", a => a.Source)
.AddAttribute(0, "imageaspect", a => a.ImageAspect)
.AddAttribute(0, "imagesize", a => a.ImageSize)
.AddAttribute(0, "imagealignshape", a => a.ImageAlignShape)
.AddAttribute(0, "color2", a => a.Color2)
.AddAttribute(0, "startarrow", a => a.StartArrow)
.AddAttribute(0, "startarrowwidth", a => a.StartArrowWidth)
.AddAttribute(0, "startarrowlength", a => a.StartArrowLength)
.AddAttribute(0, "endarrow", a => a.EndArrow)
.AddAttribute(0, "endarrowwidth", a => a.EndArrowWidth)
.AddAttribute(0, "endarrowlength", a => a.EndArrowLength)
.AddAttribute(27, "href", a => a.Href)
.AddAttribute(27, "althref", a => a.AlternateImageReference)
.AddAttribute(27, "title", a => a.Title)
.AddAttribute(27, "forcedash", a => a.ForceDash)
.AddAttribute(19, "id", a => a.RelationshipId)
.AddAttribute(0, "insetpen", a => a.Insetpen);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.LeftStroke), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.TopStroke), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.RightStroke), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.BottomStroke), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ColumnStroke), 0, 1)
            };
            builder.AddConstraint(new RelationshipTypeConstraint(26 /*r:id*/, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image"));
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, false, null));
            builder.AddConstraint(new AttributeValueRangeConstraint(6 /*:miterlimit*/, true, double.NegativeInfinity, true, 32767, true));
            builder.AddConstraint(new AttributeValueRangeConstraint(2 /*:weight*/, true, 0, true, 20116800, true));
            builder.AddConstraint(new RelationshipExistConstraint(26 /*r:id*/));
        }

        /// <summary>
        /// <para>LeftStroke.</para>
        /// <para>Represents the following element tag in the schema: o:left.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public DocumentFormat.OpenXml.Vml.Office.LeftStroke LeftStroke
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.Office.LeftStroke>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TopStroke.</para>
        /// <para>Represents the following element tag in the schema: o:top.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public DocumentFormat.OpenXml.Vml.Office.TopStroke TopStroke
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.Office.TopStroke>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RightStroke.</para>
        /// <para>Represents the following element tag in the schema: o:right.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public DocumentFormat.OpenXml.Vml.Office.RightStroke RightStroke
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.Office.RightStroke>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BottomStroke.</para>
        /// <para>Represents the following element tag in the schema: o:bottom.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public DocumentFormat.OpenXml.Vml.Office.BottomStroke BottomStroke
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.Office.BottomStroke>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ColumnStroke.</para>
        /// <para>Represents the following element tag in the schema: o:column.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public DocumentFormat.OpenXml.Vml.Office.ColumnStroke ColumnStroke
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.Office.ColumnStroke>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Stroke>(deep);
    }

    /// <summary>
    /// <para>Defines the Shadow Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:shadow.</para>
    /// </summary>
    public partial class Shadow : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Shadow class.
        /// </summary>
        public Shadow() : base()
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Toggle</para>
        /// <para>Represents the following attribute in the schema: on</para>
        /// </summary>
        public TrueFalseValue On
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.ShadowValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ShadowValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Transparency</para>
        /// <para>Represents the following attribute in the schema: obscured</para>
        /// </summary>
        public TrueFalseValue Obscured
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Primary Color</para>
        /// <para>Represents the following attribute in the schema: color</para>
        /// </summary>
        public StringValue Color
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Opacity</para>
        /// <para>Represents the following attribute in the schema: opacity</para>
        /// </summary>
        public StringValue Opacity
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Primary Offset</para>
        /// <para>Represents the following attribute in the schema: offset</para>
        /// </summary>
        public StringValue Offset
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Secondary Color</para>
        /// <para>Represents the following attribute in the schema: color2</para>
        /// </summary>
        public StringValue Color2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Secondary Offset</para>
        /// <para>Represents the following attribute in the schema: offset2</para>
        /// </summary>
        public StringValue Offset2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Origin</para>
        /// <para>Represents the following attribute in the schema: origin</para>
        /// </summary>
        public StringValue Origin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shadow Perspective Matrix</para>
        /// <para>Represents the following attribute in the schema: matrix</para>
        /// </summary>
        public StringValue Matrix
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "shadow");
            builder.AddElement<Shadow>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "on", a => a.On)
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "obscured", a => a.Obscured)
.AddAttribute(0, "color", a => a.Color)
.AddAttribute(0, "opacity", a => a.Opacity)
.AddAttribute(0, "offset", a => a.Offset)
.AddAttribute(0, "color2", a => a.Color2)
.AddAttribute(0, "offset2", a => a.Offset2)
.AddAttribute(0, "origin", a => a.Origin)
.AddAttribute(0, "matrix", a => a.Matrix);
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shadow>(deep);
    }

    /// <summary>
    /// <para>Defines the TextBox Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:textbox.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Wordprocessing.TextBoxContent &lt;w:txbxContent></description></item>
    /// </list>
    /// </remark>
    public partial class TextBox : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBox class.
        /// </summary>
        public TextBox() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBox(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBox(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBox class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBox(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public StringValue Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Box Inset</para>
        /// <para>Represents the following attribute in the schema: inset</para>
        /// </summary>
        public StringValue Inset
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Box Single-Click Selection Toggle</para>
        /// <para>Represents the following attribute in the schema: o:singleclick</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue SingleClick
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "textbox");
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxContent>();
            builder.AddElement<TextBox>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "inset", a => a.Inset)
.AddAttribute(27, "singleclick", a => a.SingleClick);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.TextBoxContent), 0, 1),
                new AnyParticle(XsdAny.Local, 1, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBox>(deep);
    }

    /// <summary>
    /// <para>Defines the TextPath Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:textpath.</para>
    /// </summary>
    public partial class TextPath : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TextPath class.
        /// </summary>
        public TextPath() : base()
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public StringValue Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Path Toggle</para>
        /// <para>Represents the following attribute in the schema: on</para>
        /// </summary>
        public TrueFalseValue On
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fit Toggle</para>
        /// <para>Represents the following attribute in the schema: fitshape</para>
        /// </summary>
        public TrueFalseValue FitShape
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Path Fit Toggle</para>
        /// <para>Represents the following attribute in the schema: fitpath</para>
        /// </summary>
        public TrueFalseValue FitPath
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Path Trim Toggle</para>
        /// <para>Represents the following attribute in the schema: trim</para>
        /// </summary>
        public TrueFalseValue Trim
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text X-Scaling</para>
        /// <para>Represents the following attribute in the schema: xscale</para>
        /// </summary>
        public TrueFalseValue XScale
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Path Text</para>
        /// <para>Represents the following attribute in the schema: string</para>
        /// </summary>
        public StringValue String
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "textpath");
            builder.AddElement<TextPath>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "on", a => a.On)
.AddAttribute(0, "fitshape", a => a.FitShape)
.AddAttribute(0, "fitpath", a => a.FitPath)
.AddAttribute(0, "trim", a => a.Trim)
.AddAttribute(0, "xscale", a => a.XScale)
.AddAttribute(0, "string", a => a.String);
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextPath>(deep);
    }

    /// <summary>
    /// <para>Defines the ImageData Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:imagedata.</para>
    /// </summary>
    public partial class ImageData : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ImageData class.
        /// </summary>
        public ImageData() : base()
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Transparency Color</para>
        /// <para>Represents the following attribute in the schema: chromakey</para>
        /// </summary>
        public StringValue ChromAKey
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Left Crop</para>
        /// <para>Represents the following attribute in the schema: cropleft</para>
        /// </summary>
        public StringValue CropLeft
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Top Crop</para>
        /// <para>Represents the following attribute in the schema: croptop</para>
        /// </summary>
        public StringValue CropTop
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Right Crop</para>
        /// <para>Represents the following attribute in the schema: cropright</para>
        /// </summary>
        public StringValue CropRight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Bottom Crop</para>
        /// <para>Represents the following attribute in the schema: cropbottom</para>
        /// </summary>
        public StringValue CropBottom
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Intensity</para>
        /// <para>Represents the following attribute in the schema: gain</para>
        /// </summary>
        public StringValue Gain
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Brightness</para>
        /// <para>Represents the following attribute in the schema: blacklevel</para>
        /// </summary>
        public StringValue BlackLevel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Gamma Correction</para>
        /// <para>Represents the following attribute in the schema: gamma</para>
        /// </summary>
        public StringValue Gamma
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Grayscale Toggle</para>
        /// <para>Represents the following attribute in the schema: grayscale</para>
        /// </summary>
        public TrueFalseValue Grayscale
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Bilevel Toggle</para>
        /// <para>Represents the following attribute in the schema: bilevel</para>
        /// </summary>
        public TrueFalseValue BiLevel
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embossed Color</para>
        /// <para>Represents the following attribute in the schema: embosscolor</para>
        /// </summary>
        public StringValue EmbossColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black Recoloring Color</para>
        /// <para>Represents the following attribute in the schema: recolortarget</para>
        /// </summary>
        public StringValue RecolorTarget
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Data Title</para>
        /// <para>Represents the following attribute in the schema: o:title</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Detect Mouse Click</para>
        /// <para>Represents the following attribute in the schema: o:detectmouseclick</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue DetectMouseClick
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relationship to Part</para>
        /// <para>Represents the following attribute in the schema: o:relid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue RelId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Explicit Relationship to Image Data</para>
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

        /// <summary>
        /// <para>Explicit Relationship to Alternate Image Data</para>
        /// <para>Represents the following attribute in the schema: r:pict</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue Picture
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Explicit Relationship to Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: r:href</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue RelHref
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "imagedata");
            builder.AddElement<ImageData>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "chromakey", a => a.ChromAKey)
.AddAttribute(0, "cropleft", a => a.CropLeft)
.AddAttribute(0, "croptop", a => a.CropTop)
.AddAttribute(0, "cropright", a => a.CropRight)
.AddAttribute(0, "cropbottom", a => a.CropBottom)
.AddAttribute(0, "gain", a => a.Gain)
.AddAttribute(0, "blacklevel", a => a.BlackLevel)
.AddAttribute(0, "gamma", a => a.Gamma)
.AddAttribute(0, "grayscale", a => a.Grayscale)
.AddAttribute(0, "bilevel", a => a.BiLevel)
.AddAttribute(0, "embosscolor", a => a.EmbossColor)
.AddAttribute(0, "recolortarget", a => a.RecolorTarget)
.AddAttribute(27, "title", a => a.Title)
.AddAttribute(27, "detectmouseclick", a => a.DetectMouseClick)
.AddAttribute(27, "relid", a => a.RelId)
.AddAttribute(19, "id", a => a.RelationshipId)
.AddAttribute(19, "pict", a => a.Picture)
.AddAttribute(19, "href", a => a.RelHref);
            builder.AddConstraint(new RelationshipTypeConstraint(18 /*r:href*/, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image"));
            builder.AddConstraint(new RelationshipTypeConstraint(16 /*r:id*/, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image"));
            builder.AddConstraint(new RelationshipTypeConstraint(17 /*r:pict*/, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image"));
            builder.AddConstraint(new RelationshipTypeConstraint(15 /*ovml:relid*/, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image"));
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, false, null));
            builder.AddConstraint(new AttributeValueRangeConstraint(7 /*:blacklevel*/, true, -0.5, true, 0.5, true));
            builder.AddConstraint(new RelationshipExistConstraint(16 /*r:id*/));
            builder.AddConstraint(new RelationshipExistConstraint(18 /*r:href*/));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageData>(deep);
    }

    /// <summary>
    /// <para>Shape Definition.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:shape.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Path &lt;v:path></description></item>
    ///   <item><description>Formulas &lt;v:formulas></description></item>
    ///   <item><description>ShapeHandles &lt;v:handles></description></item>
    ///   <item><description>Fill &lt;v:fill></description></item>
    ///   <item><description>Stroke &lt;v:stroke></description></item>
    ///   <item><description>Shadow &lt;v:shadow></description></item>
    ///   <item><description>TextBox &lt;v:textbox></description></item>
    ///   <item><description>TextPath &lt;v:textpath></description></item>
    ///   <item><description>ImageData &lt;v:imagedata></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Ink &lt;o:ink></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Presentation.InkAnnotationFlag &lt;pvml:iscomment></description></item>
    /// </list>
    /// </remark>
    public partial class Shape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Shape class.
        /// </summary>
        public Shape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Shape(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public StringValue Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>
        public StringValue Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>
        public StringValue Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>CSS Reference</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>
        public StringValue Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>
        public StringValue Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>
        public StringValue CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>
        public StringValue CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>
        public StringValue WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>
        public TrueFalseValue Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public SingleValue HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>
        public TrueFalseValue Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>
        public StringValue FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>
        public TrueFalseValue Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>
        public StringValue StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>
        public StringValue StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>
        public TrueFalseValue InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Int32Value OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseBlankValue Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Type Reference</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public StringValue Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Adjustment Parameters</para>
        /// <para>Represents the following attribute in the schema: adj</para>
        /// </summary>
        public StringValue Adjustment
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Edge Path</para>
        /// <para>Represents the following attribute in the schema: path</para>
        /// </summary>
        public StringValue EdgePath
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Base64BinaryValue EncodedPackage
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Storage for Alternate Math Content</para>
        /// <para>Represents the following attribute in the schema: equationxml</para>
        /// </summary>
        public StringValue EquationXml
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "shape");
            builder.AddChild<Path>();
            builder.AddChild<Formulas>();
            builder.AddChild<ShapeHandles>();
            builder.AddChild<Fill>();
            builder.AddChild<Stroke>();
            builder.AddChild<Shadow>();
            builder.AddChild<TextBox>();
            builder.AddChild<TextPath>();
            builder.AddChild<ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Ink>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.InkAnnotationFlag>();
            builder.AddElement<Shape>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "href", a => a.Href)
.AddAttribute(0, "target", a => a.Target)
.AddAttribute(0, "class", a => a.Class)
.AddAttribute(0, "title", a => a.Title)
.AddAttribute(0, "alt", a => a.Alternate)
.AddAttribute(0, "coordsize", a => a.CoordinateSize)
.AddAttribute(0, "coordorigin", a => a.CoordinateOrigin)
.AddAttribute(0, "wrapcoords", a => a.WrapCoordinates)
.AddAttribute(0, "print", a => a.Print)
.AddAttribute(27, "spid", a => a.OptionalString)
.AddAttribute(27, "oned", a => a.Oned)
.AddAttribute(27, "regroupid", a => a.RegroupId)
.AddAttribute(27, "doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute(27, "button", a => a.Button)
.AddAttribute(27, "userhidden", a => a.UserHidden)
.AddAttribute(27, "bullet", a => a.Bullet)
.AddAttribute(27, "hr", a => a.Horizontal)
.AddAttribute(27, "hrstd", a => a.HorizontalStandard)
.AddAttribute(27, "hrnoshade", a => a.HorizontalNoShade)
.AddAttribute(27, "hrpct", a => a.HorizontalPercentage)
.AddAttribute(27, "hralign", a => a.HorizontalAlignment)
.AddAttribute(27, "allowincell", a => a.AllowInCell)
.AddAttribute(27, "allowoverlap", a => a.AllowOverlap)
.AddAttribute(27, "userdrawn", a => a.UserDrawn)
.AddAttribute(27, "bordertopcolor", a => a.BorderTopColor)
.AddAttribute(27, "borderleftcolor", a => a.BorderLeftColor)
.AddAttribute(27, "borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute(27, "borderrightcolor", a => a.BorderRightColor)
.AddAttribute(27, "dgmlayout", a => a.DiagramLayout)
.AddAttribute(27, "dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute(27, "dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute(27, "insetmode", a => a.InsetMode)
.AddAttribute(0, "filled", a => a.Filled)
.AddAttribute(0, "fillcolor", a => a.FillColor)
.AddAttribute(0, "stroked", a => a.Stroked)
.AddAttribute(0, "strokecolor", a => a.StrokeColor)
.AddAttribute(0, "strokeweight", a => a.StrokeWeight)
.AddAttribute(0, "insetpen", a => a.InsetPen)
.AddAttribute(27, "spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute(27, "connectortype", a => a.ConnectorType)
.AddAttribute(27, "bwmode", a => a.BlackWhiteMode)
.AddAttribute(27, "bwpure", a => a.PureBlackWhiteMode)
.AddAttribute(27, "bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute(27, "forcedash", a => a.ForceDash)
.AddAttribute(27, "oleicon", a => a.OleIcon)
.AddAttribute(27, "ole", a => a.Ole)
.AddAttribute(27, "preferrelative", a => a.PreferRelative)
.AddAttribute(27, "cliptowrap", a => a.ClipToWrap)
.AddAttribute(27, "clip", a => a.Clip)
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "adj", a => a.Adjustment)
.AddAttribute(0, "path", a => a.EdgePath)
.AddAttribute(27, "gfxdata", a => a.EncodedPackage)
.AddAttribute(0, "equationxml", a => a.EquationXml);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 0)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Ink), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.InkAnnotationFlag), 1, 1)
            };
            builder.AddConstraint(new AttributeValueSetConstraint(30 /*ovml:dgmlayout*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint(32 /*ovml:dgmlayoutmru*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);
    }

    /// <summary>
    /// <para>Shape Template.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:shapetype.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Path &lt;v:path></description></item>
    ///   <item><description>Formulas &lt;v:formulas></description></item>
    ///   <item><description>ShapeHandles &lt;v:handles></description></item>
    ///   <item><description>Fill &lt;v:fill></description></item>
    ///   <item><description>Stroke &lt;v:stroke></description></item>
    ///   <item><description>Shadow &lt;v:shadow></description></item>
    ///   <item><description>TextBox &lt;v:textbox></description></item>
    ///   <item><description>TextPath &lt;v:textpath></description></item>
    ///   <item><description>ImageData &lt;v:imagedata></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Complex &lt;o:complex></description></item>
    /// </list>
    /// </remark>
    public partial class Shapetype : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Shapetype class.
        /// </summary>
        public Shapetype() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shapetype class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shapetype(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shapetype class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shapetype(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shapetype class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Shapetype(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public StringValue Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>
        public StringValue Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>
        public StringValue Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>CSS Reference</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>
        public StringValue Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>
        public StringValue Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>
        public StringValue CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>
        public StringValue CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>
        public StringValue WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>
        public TrueFalseValue Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public SingleValue HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>
        public TrueFalseValue Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>
        public StringValue FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>
        public TrueFalseValue Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>
        public StringValue StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>
        public StringValue StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>
        public TrueFalseValue InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Int32Value OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseBlankValue Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Adjustment Parameters</para>
        /// <para>Represents the following attribute in the schema: adj</para>
        /// </summary>
        public StringValue Adjustment
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Edge Path</para>
        /// <para>Represents the following attribute in the schema: path</para>
        /// </summary>
        public StringValue EdgePath
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Master Element Toggle</para>
        /// <para>Represents the following attribute in the schema: o:master</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue Master
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "shapetype");
            builder.AddChild<Path>();
            builder.AddChild<Formulas>();
            builder.AddChild<ShapeHandles>();
            builder.AddChild<Fill>();
            builder.AddChild<Stroke>();
            builder.AddChild<Shadow>();
            builder.AddChild<TextBox>();
            builder.AddChild<TextPath>();
            builder.AddChild<ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Complex>();
            builder.AddElement<Shapetype>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "href", a => a.Href)
.AddAttribute(0, "target", a => a.Target)
.AddAttribute(0, "class", a => a.Class)
.AddAttribute(0, "title", a => a.Title)
.AddAttribute(0, "alt", a => a.Alternate)
.AddAttribute(0, "coordsize", a => a.CoordinateSize)
.AddAttribute(0, "coordorigin", a => a.CoordinateOrigin)
.AddAttribute(0, "wrapcoords", a => a.WrapCoordinates)
.AddAttribute(0, "print", a => a.Print)
.AddAttribute(27, "spid", a => a.OptionalString)
.AddAttribute(27, "oned", a => a.Oned)
.AddAttribute(27, "regroupid", a => a.RegroupId)
.AddAttribute(27, "doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute(27, "button", a => a.Button)
.AddAttribute(27, "userhidden", a => a.UserHidden)
.AddAttribute(27, "bullet", a => a.Bullet)
.AddAttribute(27, "hr", a => a.Horizontal)
.AddAttribute(27, "hrstd", a => a.HorizontalStandard)
.AddAttribute(27, "hrnoshade", a => a.HorizontalNoShade)
.AddAttribute(27, "hrpct", a => a.HorizontalPercentage)
.AddAttribute(27, "hralign", a => a.HorizontalAlignment)
.AddAttribute(27, "allowincell", a => a.AllowInCell)
.AddAttribute(27, "allowoverlap", a => a.AllowOverlap)
.AddAttribute(27, "userdrawn", a => a.UserDrawn)
.AddAttribute(27, "bordertopcolor", a => a.BorderTopColor)
.AddAttribute(27, "borderleftcolor", a => a.BorderLeftColor)
.AddAttribute(27, "borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute(27, "borderrightcolor", a => a.BorderRightColor)
.AddAttribute(27, "dgmlayout", a => a.DiagramLayout)
.AddAttribute(27, "dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute(27, "dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute(27, "insetmode", a => a.InsetMode)
.AddAttribute(0, "filled", a => a.Filled)
.AddAttribute(0, "fillcolor", a => a.FillColor)
.AddAttribute(0, "stroked", a => a.Stroked)
.AddAttribute(0, "strokecolor", a => a.StrokeColor)
.AddAttribute(0, "strokeweight", a => a.StrokeWeight)
.AddAttribute(0, "insetpen", a => a.InsetPen)
.AddAttribute(27, "spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute(27, "connectortype", a => a.ConnectorType)
.AddAttribute(27, "bwmode", a => a.BlackWhiteMode)
.AddAttribute(27, "bwpure", a => a.PureBlackWhiteMode)
.AddAttribute(27, "bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute(27, "forcedash", a => a.ForceDash)
.AddAttribute(27, "oleicon", a => a.OleIcon)
.AddAttribute(27, "ole", a => a.Ole)
.AddAttribute(27, "preferrelative", a => a.PreferRelative)
.AddAttribute(27, "cliptowrap", a => a.ClipToWrap)
.AddAttribute(27, "clip", a => a.Clip)
.AddAttribute(0, "adj", a => a.Adjustment)
.AddAttribute(0, "path", a => a.EdgePath)
.AddAttribute(27, "master", a => a.Master);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Complex), 0, 1)
            };
            builder.AddConstraint(new AttributeValueSetConstraint(30 /*ovml:dgmlayout*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint(32 /*ovml:dgmlayoutmru*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shapetype>(deep);
    }

    /// <summary>
    /// <para>Shape Group.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:group.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Group &lt;v:group></description></item>
    ///   <item><description>Shape &lt;v:shape></description></item>
    ///   <item><description>Shapetype &lt;v:shapetype></description></item>
    ///   <item><description>Arc &lt;v:arc></description></item>
    ///   <item><description>Curve &lt;v:curve></description></item>
    ///   <item><description>ImageFile &lt;v:image></description></item>
    ///   <item><description>Line &lt;v:line></description></item>
    ///   <item><description>Oval &lt;v:oval></description></item>
    ///   <item><description>PolyLine &lt;v:polyline></description></item>
    ///   <item><description>Rectangle &lt;v:rect></description></item>
    ///   <item><description>RoundRectangle &lt;v:roundrect></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Diagram &lt;o:diagram></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
    /// </list>
    /// </remark>
    public partial class Group : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Group class.
        /// </summary>
        public Group() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Group class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Group(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Group class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Group(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Group class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Group(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public StringValue Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>
        public StringValue Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>
        public StringValue Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>CSS Reference</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>
        public StringValue Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>
        public StringValue Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>
        public StringValue CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>
        public StringValue CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>
        public StringValue WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>
        public TrueFalseValue Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>spid</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>oned</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>regroupid</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>doubleclicknotify</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>button</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>userhidden</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hr</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hrstd</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hrnoshade</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hrpct</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public SingleValue HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hralign</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>allowincell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>allowoverlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>userdrawn</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dgmlayout</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dgmnodekind</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dgmlayoutmru</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insetmode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Base64BinaryValue Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Group Diagram Type</para>
        /// <para>Represents the following attribute in the schema: editas</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Vml.EditAsValues> EditAs
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.EditAsValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Table Properties</para>
        /// <para>Represents the following attribute in the schema: o:tableproperties</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue TableProperties
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Table Row Height Limits</para>
        /// <para>Represents the following attribute in the schema: o:tablelimits</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue TableLimits
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "group");
            builder.AddChild<Group>();
            builder.AddChild<Shape>();
            builder.AddChild<Shapetype>();
            builder.AddChild<Arc>();
            builder.AddChild<Curve>();
            builder.AddChild<ImageFile>();
            builder.AddChild<Line>();
            builder.AddChild<Oval>();
            builder.AddChild<PolyLine>();
            builder.AddChild<Rectangle>();
            builder.AddChild<RoundRectangle>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Diagram>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddElement<Group>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "href", a => a.Href)
.AddAttribute(0, "target", a => a.Target)
.AddAttribute(0, "class", a => a.Class)
.AddAttribute(0, "title", a => a.Title)
.AddAttribute(0, "alt", a => a.Alternate)
.AddAttribute(0, "coordsize", a => a.CoordinateSize)
.AddAttribute(0, "coordorigin", a => a.CoordinateOrigin)
.AddAttribute(0, "wrapcoords", a => a.WrapCoordinates)
.AddAttribute(0, "print", a => a.Print)
.AddAttribute(27, "spid", a => a.OptionalString)
.AddAttribute(27, "oned", a => a.Oned)
.AddAttribute(27, "regroupid", a => a.RegroupId)
.AddAttribute(27, "doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute(27, "button", a => a.Button)
.AddAttribute(27, "userhidden", a => a.UserHidden)
.AddAttribute(27, "bullet", a => a.Bullet)
.AddAttribute(27, "hr", a => a.Horizontal)
.AddAttribute(27, "hrstd", a => a.HorizontalStandard)
.AddAttribute(27, "hrnoshade", a => a.HorizontalNoShade)
.AddAttribute(27, "hrpct", a => a.HorizontalPercentage)
.AddAttribute(27, "hralign", a => a.HorizontalAlignment)
.AddAttribute(27, "allowincell", a => a.AllowInCell)
.AddAttribute(27, "allowoverlap", a => a.AllowOverlap)
.AddAttribute(27, "userdrawn", a => a.UserDrawn)
.AddAttribute(27, "dgmlayout", a => a.DiagramLayout)
.AddAttribute(27, "dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute(27, "dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute(27, "insetmode", a => a.InsetMode)
.AddAttribute(27, "gfxdata", a => a.Gfxdata)
.AddAttribute(0, "editas", a => a.EditAs)
.AddAttribute(27, "tableproperties", a => a.TableProperties)
.AddAttribute(27, "tablelimits", a => a.TableLimits);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Group), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shape), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shapetype), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Arc), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Curve), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageFile), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Line), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Oval), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.PolyLine), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Rectangle), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.RoundRectangle), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Diagram), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1)
            };
            builder.AddConstraint(new AttributeValueSetConstraint(32 /*ovml:tableproperties*/, true, new string[] { "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint(26 /*ovml:dgmlayout*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint(28 /*ovml:dgmlayoutmru*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Group>(deep);
    }

    /// <summary>
    /// <para>Document Background.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:background.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Fill &lt;v:fill></description></item>
    /// </list>
    /// </remark>
    public partial class Background : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Background class.
        /// </summary>
        public Background() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Background class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Background(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Background class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Background(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Background class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Background(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: fill</para>
        /// </summary>
        public TrueFalseValue Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>
        public StringValue Fillcolor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Target Screen Size</para>
        /// <para>Represents the following attribute in the schema: o:targetscreensize</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues> TargetScreenSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ScreenSizeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "background");
            builder.AddChild<Fill>();
            builder.AddElement<Background>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MaxLength = (255L) });
})
.AddAttribute(0, "fill", a => a.Filled)
.AddAttribute(0, "fillcolor", a => a.Fillcolor)
.AddAttribute(27, "bwmode", a => a.BlackWhiteMode)
.AddAttribute(27, "bwpure", a => a.PureBlackWhiteMode)
.AddAttribute(27, "bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute(27, "targetscreensize", a => a.TargetScreenSize);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, true, null));
        }

        /// <summary>
        /// <para>Fill.</para>
        /// <para>Represents the following element tag in the schema: v:fill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:v = urn:schemas-microsoft-com:vml
        /// </remark>
        public Fill Fill
        {
            get => GetElement<Fill>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Background>(deep);
    }

    /// <summary>
    /// <para>Arc Segment.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:arc.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Path &lt;v:path></description></item>
    ///   <item><description>Formulas &lt;v:formulas></description></item>
    ///   <item><description>ShapeHandles &lt;v:handles></description></item>
    ///   <item><description>Fill &lt;v:fill></description></item>
    ///   <item><description>Stroke &lt;v:stroke></description></item>
    ///   <item><description>Shadow &lt;v:shadow></description></item>
    ///   <item><description>TextBox &lt;v:textbox></description></item>
    ///   <item><description>TextPath &lt;v:textpath></description></item>
    ///   <item><description>ImageData &lt;v:imagedata></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
    /// </list>
    /// </remark>
    public partial class Arc : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Arc class.
        /// </summary>
        public Arc() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Arc class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Arc(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Arc class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Arc(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Arc class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Arc(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public SingleValue HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>
        public TrueFalseValue Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>
        public StringValue FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>
        public TrueFalseValue Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>
        public StringValue StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>
        public StringValue StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>
        public TrueFalseValue InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Int32Value OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseBlankValue Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Base64BinaryValue Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public StringValue Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>
        public StringValue Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>
        public StringValue Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>
        public StringValue Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>
        public StringValue CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>
        public StringValue CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>
        public StringValue Wrapcoords
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>
        public TrueFalseValue Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Starting Angle</para>
        /// <para>Represents the following attribute in the schema: startangle</para>
        /// </summary>
        public DecimalValue StartAngle
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Ending Angle</para>
        /// <para>Represents the following attribute in the schema: endangle</para>
        /// </summary>
        public DecimalValue EndAngle
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "arc");
            builder.AddChild<Path>();
            builder.AddChild<Formulas>();
            builder.AddChild<ShapeHandles>();
            builder.AddChild<Fill>();
            builder.AddChild<Stroke>();
            builder.AddChild<Shadow>();
            builder.AddChild<TextBox>();
            builder.AddChild<TextPath>();
            builder.AddChild<ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddElement<Arc>()
.AddAttribute(27, "spid", a => a.OptionalString)
.AddAttribute(27, "oned", a => a.Oned)
.AddAttribute(27, "regroupid", a => a.RegroupId)
.AddAttribute(27, "doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute(27, "button", a => a.Button)
.AddAttribute(27, "userhidden", a => a.UserHidden)
.AddAttribute(27, "bullet", a => a.Bullet)
.AddAttribute(27, "hr", a => a.Horizontal)
.AddAttribute(27, "hrstd", a => a.HorizontalStandard)
.AddAttribute(27, "hrnoshade", a => a.HorizontalNoShade)
.AddAttribute(27, "hrpct", a => a.HorizontalPercentage)
.AddAttribute(27, "hralign", a => a.HorizontalAlignment)
.AddAttribute(27, "allowincell", a => a.AllowInCell)
.AddAttribute(27, "allowoverlap", a => a.AllowOverlap)
.AddAttribute(27, "userdrawn", a => a.UserDrawn)
.AddAttribute(27, "bordertopcolor", a => a.BorderTopColor)
.AddAttribute(27, "borderleftcolor", a => a.BorderLeftColor)
.AddAttribute(27, "borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute(27, "borderrightcolor", a => a.BorderRightColor)
.AddAttribute(27, "dgmlayout", a => a.DiagramLayout)
.AddAttribute(27, "dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute(27, "dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute(27, "insetmode", a => a.InsetMode)
.AddAttribute(0, "filled", a => a.Filled)
.AddAttribute(0, "fillcolor", a => a.FillColor)
.AddAttribute(0, "stroked", a => a.Stroked)
.AddAttribute(0, "strokecolor", a => a.StrokeColor)
.AddAttribute(0, "strokeweight", a => a.StrokeWeight)
.AddAttribute(0, "insetpen", a => a.InsetPen)
.AddAttribute(27, "spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute(27, "connectortype", a => a.ConnectorType)
.AddAttribute(27, "bwmode", a => a.BlackWhiteMode)
.AddAttribute(27, "bwpure", a => a.PureBlackWhiteMode)
.AddAttribute(27, "bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute(27, "forcedash", a => a.ForceDash)
.AddAttribute(27, "oleicon", a => a.OleIcon)
.AddAttribute(27, "ole", a => a.Ole)
.AddAttribute(27, "preferrelative", a => a.PreferRelative)
.AddAttribute(27, "cliptowrap", a => a.ClipToWrap)
.AddAttribute(27, "clip", a => a.Clip)
.AddAttribute(27, "gfxdata", a => a.Gfxdata)
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MaxLength = (255L) });
})
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "href", a => a.Href)
.AddAttribute(0, "target", a => a.Target)
.AddAttribute(0, "title", a => a.Title)
.AddAttribute(0, "alt", a => a.Alternate)
.AddAttribute(0, "coordsize", a => a.CoordinateSize)
.AddAttribute(0, "coordorigin", a => a.CoordinateOrigin)
.AddAttribute(0, "wrapcoords", a => a.Wrapcoords)
.AddAttribute(0, "print", a => a.Print)
.AddAttribute(0, "startangle", a => a.StartAngle)
.AddAttribute(0, "endangle", a => a.EndAngle);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                }
            };
            builder.AddConstraint(new AttributeValueSetConstraint(19 /*ovml:dgmlayout*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint(21 /*ovml:dgmlayoutmru*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueRangeConstraint(10 /*ovml:hrpct*/, true, 0, true, 1000, true));
            builder.AddConstraint(new AttributeValueRangeConstraint(20 /*ovml:dgmnodekind*/, true, 0, true, 6, true));
            builder.AddConstraint(new AttributeValueSetConstraint(29 /*ovml:spt*/, true, new string[] { "19" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint(41 /*:id*/, true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Arc>(deep);
    }

    /// <summary>
    /// <para>Bezier Curve.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:curve.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Path &lt;v:path></description></item>
    ///   <item><description>Formulas &lt;v:formulas></description></item>
    ///   <item><description>ShapeHandles &lt;v:handles></description></item>
    ///   <item><description>Fill &lt;v:fill></description></item>
    ///   <item><description>Stroke &lt;v:stroke></description></item>
    ///   <item><description>Shadow &lt;v:shadow></description></item>
    ///   <item><description>TextBox &lt;v:textbox></description></item>
    ///   <item><description>TextPath &lt;v:textpath></description></item>
    ///   <item><description>ImageData &lt;v:imagedata></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
    /// </list>
    /// </remark>
    public partial class Curve : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Curve class.
        /// </summary>
        public Curve() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Curve class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Curve(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Curve class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Curve(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Curve class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Curve(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public StringValue Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>
        public StringValue Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>
        public StringValue Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>CSS Reference</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>
        public StringValue Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>
        public StringValue Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>
        public StringValue CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>
        public StringValue CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>
        public StringValue WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>
        public TrueFalseValue Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public SingleValue HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>
        public TrueFalseValue Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>
        public StringValue FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>
        public TrueFalseValue Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>
        public StringValue StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>
        public StringValue StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>
        public TrueFalseValue InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Int32Value OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseBlankValue Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Base64BinaryValue Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Curve Starting Point</para>
        /// <para>Represents the following attribute in the schema: from</para>
        /// </summary>
        public StringValue From
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>First Curve Control Point</para>
        /// <para>Represents the following attribute in the schema: control1</para>
        /// </summary>
        public StringValue Control1
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Second Curve Control Point</para>
        /// <para>Represents the following attribute in the schema: control2</para>
        /// </summary>
        public StringValue Control2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Curve Ending Point</para>
        /// <para>Represents the following attribute in the schema: to</para>
        /// </summary>
        public StringValue To
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "curve");
            builder.AddChild<Path>();
            builder.AddChild<Formulas>();
            builder.AddChild<ShapeHandles>();
            builder.AddChild<Fill>();
            builder.AddChild<Stroke>();
            builder.AddChild<Shadow>();
            builder.AddChild<TextBox>();
            builder.AddChild<TextPath>();
            builder.AddChild<ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddElement<Curve>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "href", a => a.Href)
.AddAttribute(0, "target", a => a.Target)
.AddAttribute(0, "class", a => a.Class)
.AddAttribute(0, "title", a => a.Title)
.AddAttribute(0, "alt", a => a.Alternate)
.AddAttribute(0, "coordsize", a => a.CoordinateSize)
.AddAttribute(0, "coordorigin", a => a.CoordinateOrigin)
.AddAttribute(0, "wrapcoords", a => a.WrapCoordinates)
.AddAttribute(0, "print", a => a.Print)
.AddAttribute(27, "spid", a => a.OptionalString)
.AddAttribute(27, "oned", a => a.Oned)
.AddAttribute(27, "regroupid", a => a.RegroupId)
.AddAttribute(27, "doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute(27, "button", a => a.Button)
.AddAttribute(27, "userhidden", a => a.UserHidden)
.AddAttribute(27, "bullet", a => a.Bullet)
.AddAttribute(27, "hr", a => a.Horizontal)
.AddAttribute(27, "hrstd", a => a.HorizontalStandard)
.AddAttribute(27, "hrnoshade", a => a.HorizontalNoShade)
.AddAttribute(27, "hrpct", a => a.HorizontalPercentage)
.AddAttribute(27, "hralign", a => a.HorizontalAlignment)
.AddAttribute(27, "allowincell", a => a.AllowInCell)
.AddAttribute(27, "allowoverlap", a => a.AllowOverlap)
.AddAttribute(27, "userdrawn", a => a.UserDrawn)
.AddAttribute(27, "bordertopcolor", a => a.BorderTopColor)
.AddAttribute(27, "borderleftcolor", a => a.BorderLeftColor)
.AddAttribute(27, "borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute(27, "borderrightcolor", a => a.BorderRightColor)
.AddAttribute(27, "dgmlayout", a => a.DiagramLayout)
.AddAttribute(27, "dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute(27, "dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute(27, "insetmode", a => a.InsetMode)
.AddAttribute(0, "filled", a => a.Filled)
.AddAttribute(0, "fillcolor", a => a.FillColor)
.AddAttribute(0, "stroked", a => a.Stroked)
.AddAttribute(0, "strokecolor", a => a.StrokeColor)
.AddAttribute(0, "strokeweight", a => a.StrokeWeight)
.AddAttribute(0, "insetpen", a => a.InsetPen)
.AddAttribute(27, "spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute(27, "connectortype", a => a.ConnectorType)
.AddAttribute(27, "bwmode", a => a.BlackWhiteMode)
.AddAttribute(27, "bwpure", a => a.PureBlackWhiteMode)
.AddAttribute(27, "bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute(27, "forcedash", a => a.ForceDash)
.AddAttribute(27, "oleicon", a => a.OleIcon)
.AddAttribute(27, "ole", a => a.Ole)
.AddAttribute(27, "preferrelative", a => a.PreferRelative)
.AddAttribute(27, "cliptowrap", a => a.ClipToWrap)
.AddAttribute(27, "clip", a => a.Clip)
.AddAttribute(27, "gfxdata", a => a.Gfxdata)
.AddAttribute(0, "from", a => a.From)
.AddAttribute(0, "control1", a => a.Control1)
.AddAttribute(0, "control2", a => a.Control2)
.AddAttribute(0, "to", a => a.To);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                }
            };
            builder.AddConstraint(new AttributeValueSetConstraint(30 /*ovml:dgmlayout*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint(32 /*ovml:dgmlayoutmru*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint(40 /*ovml:spt*/, true, new string[] { "0" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Curve>(deep);
    }

    /// <summary>
    /// <para>Image File.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:image.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Path &lt;v:path></description></item>
    ///   <item><description>Formulas &lt;v:formulas></description></item>
    ///   <item><description>ShapeHandles &lt;v:handles></description></item>
    ///   <item><description>Fill &lt;v:fill></description></item>
    ///   <item><description>Stroke &lt;v:stroke></description></item>
    ///   <item><description>Shadow &lt;v:shadow></description></item>
    ///   <item><description>TextBox &lt;v:textbox></description></item>
    ///   <item><description>TextPath &lt;v:textpath></description></item>
    ///   <item><description>ImageData &lt;v:imagedata></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
    /// </list>
    /// </remark>
    public partial class ImageFile : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ImageFile class.
        /// </summary>
        public ImageFile() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ImageFile class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ImageFile(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ImageFile class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ImageFile(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ImageFile class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ImageFile(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>style</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public StringValue Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>href</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>
        public StringValue Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>
        public StringValue Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>class</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>
        public StringValue Class
        {
            get => GetAttribute<StringValue>();
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

        /// <summary>
        /// <para>alt</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>
        public StringValue Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>coordsize</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>
        public StringValue CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>wrapcoords</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>
        public StringValue WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>print</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>
        public TrueFalseValue Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public SingleValue HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>
        public TrueFalseValue Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>
        public StringValue FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>
        public TrueFalseValue Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>
        public StringValue StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>
        public StringValue StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>
        public TrueFalseValue InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Int32Value OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseBlankValue Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Source</para>
        /// <para>Represents the following attribute in the schema: src</para>
        /// </summary>
        public StringValue Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Left Crop</para>
        /// <para>Represents the following attribute in the schema: cropleft</para>
        /// </summary>
        public StringValue CropLeft
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Top Crop</para>
        /// <para>Represents the following attribute in the schema: croptop</para>
        /// </summary>
        public StringValue CropTop
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Right Crop</para>
        /// <para>Represents the following attribute in the schema: cropright</para>
        /// </summary>
        public StringValue CropRight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Bottom Crop</para>
        /// <para>Represents the following attribute in the schema: cropbottom</para>
        /// </summary>
        public StringValue CropBottom
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Intensity</para>
        /// <para>Represents the following attribute in the schema: gain</para>
        /// </summary>
        public StringValue Gain
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Brightness</para>
        /// <para>Represents the following attribute in the schema: blacklevel</para>
        /// </summary>
        public StringValue BlackLevel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Gamma Correction</para>
        /// <para>Represents the following attribute in the schema: gamma</para>
        /// </summary>
        public StringValue Gamma
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Grayscale Toggle</para>
        /// <para>Represents the following attribute in the schema: grayscale</para>
        /// </summary>
        public TrueFalseValue GrayScale
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Bilevel Toggle</para>
        /// <para>Represents the following attribute in the schema: bilevel</para>
        /// </summary>
        public TrueFalseValue BiLevel
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Base64BinaryValue Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "image");
            builder.AddChild<Path>();
            builder.AddChild<Formulas>();
            builder.AddChild<ShapeHandles>();
            builder.AddChild<Fill>();
            builder.AddChild<Stroke>();
            builder.AddChild<Shadow>();
            builder.AddChild<TextBox>();
            builder.AddChild<TextPath>();
            builder.AddChild<ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddElement<ImageFile>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "href", a => a.Href)
.AddAttribute(0, "target", a => a.Target)
.AddAttribute(0, "class", a => a.Class)
.AddAttribute(0, "title", a => a.Title)
.AddAttribute(0, "alt", a => a.Alternate)
.AddAttribute(0, "coordsize", a => a.CoordinateSize)
.AddAttribute(0, "wrapcoords", a => a.WrapCoordinates)
.AddAttribute(0, "print", a => a.Print)
.AddAttribute(27, "spid", a => a.OptionalString)
.AddAttribute(27, "oned", a => a.Oned)
.AddAttribute(27, "regroupid", a => a.RegroupId)
.AddAttribute(27, "doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute(27, "button", a => a.Button)
.AddAttribute(27, "userhidden", a => a.UserHidden)
.AddAttribute(27, "bullet", a => a.Bullet)
.AddAttribute(27, "hr", a => a.Horizontal)
.AddAttribute(27, "hrstd", a => a.HorizontalStandard)
.AddAttribute(27, "hrnoshade", a => a.HorizontalNoShade)
.AddAttribute(27, "hrpct", a => a.HorizontalPercentage)
.AddAttribute(27, "hralign", a => a.HorizontalAlignment)
.AddAttribute(27, "allowincell", a => a.AllowInCell)
.AddAttribute(27, "allowoverlap", a => a.AllowOverlap)
.AddAttribute(27, "userdrawn", a => a.UserDrawn)
.AddAttribute(27, "bordertopcolor", a => a.BorderTopColor)
.AddAttribute(27, "borderleftcolor", a => a.BorderLeftColor)
.AddAttribute(27, "borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute(27, "borderrightcolor", a => a.BorderRightColor)
.AddAttribute(27, "dgmlayout", a => a.DiagramLayout)
.AddAttribute(27, "dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute(27, "dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute(27, "insetmode", a => a.InsetMode)
.AddAttribute(0, "filled", a => a.Filled)
.AddAttribute(0, "fillcolor", a => a.FillColor)
.AddAttribute(0, "stroked", a => a.Stroked)
.AddAttribute(0, "strokecolor", a => a.StrokeColor)
.AddAttribute(0, "strokeweight", a => a.StrokeWeight)
.AddAttribute(0, "insetpen", a => a.InsetPen)
.AddAttribute(27, "spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute(27, "connectortype", a => a.ConnectorType)
.AddAttribute(27, "bwmode", a => a.BlackWhiteMode)
.AddAttribute(27, "bwpure", a => a.PureBlackWhiteMode)
.AddAttribute(27, "bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute(27, "forcedash", a => a.ForceDash)
.AddAttribute(27, "oleicon", a => a.OleIcon)
.AddAttribute(27, "ole", a => a.Ole)
.AddAttribute(27, "preferrelative", a => a.PreferRelative)
.AddAttribute(27, "cliptowrap", a => a.ClipToWrap)
.AddAttribute(27, "clip", a => a.Clip)
.AddAttribute(0, "src", a => a.Source)
.AddAttribute(0, "cropleft", a => a.CropLeft)
.AddAttribute(0, "croptop", a => a.CropTop)
.AddAttribute(0, "cropright", a => a.CropRight)
.AddAttribute(0, "cropbottom", a => a.CropBottom)
.AddAttribute(0, "gain", a => a.Gain)
.AddAttribute(0, "blacklevel", a => a.BlackLevel)
.AddAttribute(0, "gamma", a => a.Gamma)
.AddAttribute(0, "grayscale", a => a.GrayScale)
.AddAttribute(0, "bilevel", a => a.BiLevel)
.AddAttribute(27, "gfxdata", a => a.Gfxdata);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                }
            };
            builder.AddConstraint(new AttributeValueSetConstraint(29 /*ovml:dgmlayout*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint(31 /*ovml:dgmlayoutmru*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, true, null));
            builder.AddConstraint(new AttributeValueSetConstraint(39 /*ovml:spt*/, true, new string[] { "75" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageFile>(deep);
    }

    /// <summary>
    /// <para>Line.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:line.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Path &lt;v:path></description></item>
    ///   <item><description>Formulas &lt;v:formulas></description></item>
    ///   <item><description>ShapeHandles &lt;v:handles></description></item>
    ///   <item><description>Fill &lt;v:fill></description></item>
    ///   <item><description>Stroke &lt;v:stroke></description></item>
    ///   <item><description>Shadow &lt;v:shadow></description></item>
    ///   <item><description>TextBox &lt;v:textbox></description></item>
    ///   <item><description>TextPath &lt;v:textpath></description></item>
    ///   <item><description>ImageData &lt;v:imagedata></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
    /// </list>
    /// </remark>
    public partial class Line : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Line class.
        /// </summary>
        public Line() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Line(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Line(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Line class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Line(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public StringValue Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>
        public StringValue Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>
        public StringValue Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>CSS Reference</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>
        public StringValue Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>
        public StringValue Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>
        public StringValue CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>
        public StringValue CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>
        public StringValue WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>
        public TrueFalseValue Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public SingleValue HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>
        public TrueFalseValue Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>
        public StringValue FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>
        public TrueFalseValue Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>
        public StringValue StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>
        public StringValue StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>
        public TrueFalseValue InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Int32Value OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseBlankValue Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Base64BinaryValue Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line Start</para>
        /// <para>Represents the following attribute in the schema: from</para>
        /// </summary>
        public StringValue From
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Point</para>
        /// <para>Represents the following attribute in the schema: to</para>
        /// </summary>
        public StringValue To
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "line");
            builder.AddChild<Path>();
            builder.AddChild<Formulas>();
            builder.AddChild<ShapeHandles>();
            builder.AddChild<Fill>();
            builder.AddChild<Stroke>();
            builder.AddChild<Shadow>();
            builder.AddChild<TextBox>();
            builder.AddChild<TextPath>();
            builder.AddChild<ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddElement<Line>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "href", a => a.Href)
.AddAttribute(0, "target", a => a.Target)
.AddAttribute(0, "class", a => a.Class)
.AddAttribute(0, "title", a => a.Title)
.AddAttribute(0, "alt", a => a.Alternate)
.AddAttribute(0, "coordsize", a => a.CoordinateSize)
.AddAttribute(0, "coordorigin", a => a.CoordinateOrigin)
.AddAttribute(0, "wrapcoords", a => a.WrapCoordinates)
.AddAttribute(0, "print", a => a.Print)
.AddAttribute(27, "spid", a => a.OptionalString)
.AddAttribute(27, "oned", a => a.Oned)
.AddAttribute(27, "regroupid", a => a.RegroupId)
.AddAttribute(27, "doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute(27, "button", a => a.Button)
.AddAttribute(27, "userhidden", a => a.UserHidden)
.AddAttribute(27, "bullet", a => a.Bullet)
.AddAttribute(27, "hr", a => a.Horizontal)
.AddAttribute(27, "hrstd", a => a.HorizontalStandard)
.AddAttribute(27, "hrnoshade", a => a.HorizontalNoShade)
.AddAttribute(27, "hrpct", a => a.HorizontalPercentage)
.AddAttribute(27, "hralign", a => a.HorizontalAlignment)
.AddAttribute(27, "allowincell", a => a.AllowInCell)
.AddAttribute(27, "allowoverlap", a => a.AllowOverlap)
.AddAttribute(27, "userdrawn", a => a.UserDrawn)
.AddAttribute(27, "bordertopcolor", a => a.BorderTopColor)
.AddAttribute(27, "borderleftcolor", a => a.BorderLeftColor)
.AddAttribute(27, "borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute(27, "borderrightcolor", a => a.BorderRightColor)
.AddAttribute(27, "dgmlayout", a => a.DiagramLayout)
.AddAttribute(27, "dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute(27, "dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute(27, "insetmode", a => a.InsetMode)
.AddAttribute(0, "filled", a => a.Filled)
.AddAttribute(0, "fillcolor", a => a.FillColor)
.AddAttribute(0, "stroked", a => a.Stroked)
.AddAttribute(0, "strokecolor", a => a.StrokeColor)
.AddAttribute(0, "strokeweight", a => a.StrokeWeight)
.AddAttribute(0, "insetpen", a => a.InsetPen)
.AddAttribute(27, "spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute(27, "connectortype", a => a.ConnectorType)
.AddAttribute(27, "bwmode", a => a.BlackWhiteMode)
.AddAttribute(27, "bwpure", a => a.PureBlackWhiteMode)
.AddAttribute(27, "bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute(27, "forcedash", a => a.ForceDash)
.AddAttribute(27, "oleicon", a => a.OleIcon)
.AddAttribute(27, "ole", a => a.Ole)
.AddAttribute(27, "preferrelative", a => a.PreferRelative)
.AddAttribute(27, "cliptowrap", a => a.ClipToWrap)
.AddAttribute(27, "clip", a => a.Clip)
.AddAttribute(27, "gfxdata", a => a.Gfxdata)
.AddAttribute(0, "from", a => a.From)
.AddAttribute(0, "to", a => a.To);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                }
            };
            builder.AddConstraint(new AttributeValueSetConstraint(30 /*ovml:dgmlayout*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint(40 /*ovml:spt*/, true, new string[] { "20" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Line>(deep);
    }

    /// <summary>
    /// <para>Oval.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:oval.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Path &lt;v:path></description></item>
    ///   <item><description>Formulas &lt;v:formulas></description></item>
    ///   <item><description>ShapeHandles &lt;v:handles></description></item>
    ///   <item><description>Fill &lt;v:fill></description></item>
    ///   <item><description>Stroke &lt;v:stroke></description></item>
    ///   <item><description>Shadow &lt;v:shadow></description></item>
    ///   <item><description>TextBox &lt;v:textbox></description></item>
    ///   <item><description>TextPath &lt;v:textpath></description></item>
    ///   <item><description>ImageData &lt;v:imagedata></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
    /// </list>
    /// </remark>
    public partial class Oval : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Oval class.
        /// </summary>
        public Oval() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Oval class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Oval(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Oval class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Oval(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Oval class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Oval(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public StringValue Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>
        public StringValue Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>
        public StringValue Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>CSS Reference</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>
        public StringValue Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>
        public StringValue Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>
        public StringValue CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>
        public StringValue CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>
        public StringValue WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>
        public TrueFalseValue Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public SingleValue HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>
        public TrueFalseValue Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>
        public StringValue FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>
        public TrueFalseValue Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>
        public StringValue StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>
        public StringValue StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>
        public TrueFalseValue InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Int32Value OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseBlankValue Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Base64BinaryValue Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "oval");
            builder.AddChild<Path>();
            builder.AddChild<Formulas>();
            builder.AddChild<ShapeHandles>();
            builder.AddChild<Fill>();
            builder.AddChild<Stroke>();
            builder.AddChild<Shadow>();
            builder.AddChild<TextBox>();
            builder.AddChild<TextPath>();
            builder.AddChild<ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddElement<Oval>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "href", a => a.Href)
.AddAttribute(0, "target", a => a.Target)
.AddAttribute(0, "class", a => a.Class)
.AddAttribute(0, "title", a => a.Title)
.AddAttribute(0, "alt", a => a.Alternate)
.AddAttribute(0, "coordsize", a => a.CoordinateSize)
.AddAttribute(0, "coordorigin", a => a.CoordinateOrigin)
.AddAttribute(0, "wrapcoords", a => a.WrapCoordinates)
.AddAttribute(0, "print", a => a.Print)
.AddAttribute(27, "spid", a => a.OptionalString)
.AddAttribute(27, "oned", a => a.Oned)
.AddAttribute(27, "regroupid", a => a.RegroupId)
.AddAttribute(27, "doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute(27, "button", a => a.Button)
.AddAttribute(27, "userhidden", a => a.UserHidden)
.AddAttribute(27, "bullet", a => a.Bullet)
.AddAttribute(27, "hr", a => a.Horizontal)
.AddAttribute(27, "hrstd", a => a.HorizontalStandard)
.AddAttribute(27, "hrnoshade", a => a.HorizontalNoShade)
.AddAttribute(27, "hrpct", a => a.HorizontalPercentage)
.AddAttribute(27, "hralign", a => a.HorizontalAlignment)
.AddAttribute(27, "allowincell", a => a.AllowInCell)
.AddAttribute(27, "allowoverlap", a => a.AllowOverlap)
.AddAttribute(27, "userdrawn", a => a.UserDrawn)
.AddAttribute(27, "bordertopcolor", a => a.BorderTopColor)
.AddAttribute(27, "borderleftcolor", a => a.BorderLeftColor)
.AddAttribute(27, "borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute(27, "borderrightcolor", a => a.BorderRightColor)
.AddAttribute(27, "dgmlayout", a => a.DiagramLayout)
.AddAttribute(27, "dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute(27, "dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute(27, "insetmode", a => a.InsetMode)
.AddAttribute(0, "filled", a => a.Filled)
.AddAttribute(0, "fillcolor", a => a.FillColor)
.AddAttribute(0, "stroked", a => a.Stroked)
.AddAttribute(0, "strokecolor", a => a.StrokeColor)
.AddAttribute(0, "strokeweight", a => a.StrokeWeight)
.AddAttribute(0, "insetpen", a => a.InsetPen)
.AddAttribute(27, "spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute(27, "connectortype", a => a.ConnectorType)
.AddAttribute(27, "bwmode", a => a.BlackWhiteMode)
.AddAttribute(27, "bwpure", a => a.PureBlackWhiteMode)
.AddAttribute(27, "bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute(27, "forcedash", a => a.ForceDash)
.AddAttribute(27, "oleicon", a => a.OleIcon)
.AddAttribute(27, "ole", a => a.Ole)
.AddAttribute(27, "preferrelative", a => a.PreferRelative)
.AddAttribute(27, "cliptowrap", a => a.ClipToWrap)
.AddAttribute(27, "clip", a => a.Clip)
.AddAttribute(27, "gfxdata", a => a.Gfxdata);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 0)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                }
            };
            builder.AddConstraint(new AttributeValueSetConstraint(30 /*ovml:dgmlayout*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint(32 /*ovml:dgmlayoutmru*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, true, null));
            builder.AddConstraint(new AttributeValueSetConstraint(40 /*ovml:spt*/, true, new string[] { "3" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Oval>(deep);
    }

    /// <summary>
    /// <para>Multiple Path Line.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:polyline.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Path &lt;v:path></description></item>
    ///   <item><description>Formulas &lt;v:formulas></description></item>
    ///   <item><description>ShapeHandles &lt;v:handles></description></item>
    ///   <item><description>Fill &lt;v:fill></description></item>
    ///   <item><description>Stroke &lt;v:stroke></description></item>
    ///   <item><description>Shadow &lt;v:shadow></description></item>
    ///   <item><description>TextBox &lt;v:textbox></description></item>
    ///   <item><description>TextPath &lt;v:textpath></description></item>
    ///   <item><description>ImageData &lt;v:imagedata></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Ink &lt;o:ink></description></item>
    /// </list>
    /// </remark>
    public partial class PolyLine : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PolyLine class.
        /// </summary>
        public PolyLine() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PolyLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PolyLine(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PolyLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PolyLine(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PolyLine class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PolyLine(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public StringValue Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>
        public StringValue Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>
        public StringValue Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>CSS Reference</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>
        public StringValue Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>
        public StringValue Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>
        public StringValue CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>
        public StringValue CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>
        public StringValue WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>
        public TrueFalseValue Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public SingleValue HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>
        public TrueFalseValue Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>
        public StringValue FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>
        public TrueFalseValue Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>
        public StringValue StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>
        public StringValue StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>
        public TrueFalseValue InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Int32Value OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseBlankValue Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Base64BinaryValue Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Points for Compound Line</para>
        /// <para>Represents the following attribute in the schema: points</para>
        /// </summary>
        public StringValue Points
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "polyline");
            builder.AddChild<Path>();
            builder.AddChild<Formulas>();
            builder.AddChild<ShapeHandles>();
            builder.AddChild<Fill>();
            builder.AddChild<Stroke>();
            builder.AddChild<Shadow>();
            builder.AddChild<TextBox>();
            builder.AddChild<TextPath>();
            builder.AddChild<ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Ink>();
            builder.AddElement<PolyLine>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "href", a => a.Href)
.AddAttribute(0, "target", a => a.Target)
.AddAttribute(0, "class", a => a.Class)
.AddAttribute(0, "title", a => a.Title)
.AddAttribute(0, "alt", a => a.Alternate)
.AddAttribute(0, "coordsize", a => a.CoordinateSize)
.AddAttribute(0, "coordorigin", a => a.CoordinateOrigin)
.AddAttribute(0, "wrapcoords", a => a.WrapCoordinates)
.AddAttribute(0, "print", a => a.Print)
.AddAttribute(27, "spid", a => a.OptionalString)
.AddAttribute(27, "oned", a => a.Oned)
.AddAttribute(27, "regroupid", a => a.RegroupId)
.AddAttribute(27, "doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute(27, "button", a => a.Button)
.AddAttribute(27, "userhidden", a => a.UserHidden)
.AddAttribute(27, "bullet", a => a.Bullet)
.AddAttribute(27, "hr", a => a.Horizontal)
.AddAttribute(27, "hrstd", a => a.HorizontalStandard)
.AddAttribute(27, "hrnoshade", a => a.HorizontalNoShade)
.AddAttribute(27, "hrpct", a => a.HorizontalPercentage)
.AddAttribute(27, "hralign", a => a.HorizontalAlignment)
.AddAttribute(27, "allowincell", a => a.AllowInCell)
.AddAttribute(27, "allowoverlap", a => a.AllowOverlap)
.AddAttribute(27, "userdrawn", a => a.UserDrawn)
.AddAttribute(27, "bordertopcolor", a => a.BorderTopColor)
.AddAttribute(27, "borderleftcolor", a => a.BorderLeftColor)
.AddAttribute(27, "borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute(27, "borderrightcolor", a => a.BorderRightColor)
.AddAttribute(27, "dgmlayout", a => a.DiagramLayout)
.AddAttribute(27, "dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute(27, "dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute(27, "insetmode", a => a.InsetMode)
.AddAttribute(0, "filled", a => a.Filled)
.AddAttribute(0, "fillcolor", a => a.FillColor)
.AddAttribute(0, "stroked", a => a.Stroked)
.AddAttribute(0, "strokecolor", a => a.StrokeColor)
.AddAttribute(0, "strokeweight", a => a.StrokeWeight)
.AddAttribute(0, "insetpen", a => a.InsetPen)
.AddAttribute(27, "spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute(27, "connectortype", a => a.ConnectorType)
.AddAttribute(27, "bwmode", a => a.BlackWhiteMode)
.AddAttribute(27, "bwpure", a => a.PureBlackWhiteMode)
.AddAttribute(27, "bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute(27, "forcedash", a => a.ForceDash)
.AddAttribute(27, "oleicon", a => a.OleIcon)
.AddAttribute(27, "ole", a => a.Ole)
.AddAttribute(27, "preferrelative", a => a.PreferRelative)
.AddAttribute(27, "cliptowrap", a => a.ClipToWrap)
.AddAttribute(27, "clip", a => a.Clip)
.AddAttribute(27, "gfxdata", a => a.Gfxdata)
.AddAttribute(0, "points", a => a.Points);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 0)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Ink), 1, 1)
            };
            builder.AddConstraint(new AttributeValueSetConstraint(30 /*ovml:dgmlayout*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint(32 /*ovml:dgmlayoutmru*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint(40 /*ovml:spt*/, true, new string[] { "0" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PolyLine>(deep);
    }

    /// <summary>
    /// <para>Rectangle.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:rect.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Path &lt;v:path></description></item>
    ///   <item><description>Formulas &lt;v:formulas></description></item>
    ///   <item><description>ShapeHandles &lt;v:handles></description></item>
    ///   <item><description>Fill &lt;v:fill></description></item>
    ///   <item><description>Stroke &lt;v:stroke></description></item>
    ///   <item><description>Shadow &lt;v:shadow></description></item>
    ///   <item><description>TextBox &lt;v:textbox></description></item>
    ///   <item><description>TextPath &lt;v:textpath></description></item>
    ///   <item><description>ImageData &lt;v:imagedata></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
    /// </list>
    /// </remark>
    public partial class Rectangle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Rectangle class.
        /// </summary>
        public Rectangle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rectangle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Rectangle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rectangle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Rectangle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rectangle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Rectangle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Styling Properties</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public StringValue Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Target</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>
        public StringValue Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hyperlink Display Target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>
        public StringValue Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>CSS Reference</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>
        public StringValue Class
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        public StringValue Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alternate Text</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>
        public StringValue Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Size</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>
        public StringValue CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coordinate Space Origin</para>
        /// <para>Represents the following attribute in the schema: coordorigin</para>
        /// </summary>
        public StringValue CoordinateOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Bounding Polygon</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>
        public StringValue WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Print Toggle</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>
        public TrueFalseValue Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public SingleValue HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>
        public TrueFalseValue Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>
        public StringValue FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>
        public TrueFalseValue Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>
        public StringValue StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>
        public StringValue StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>
        public TrueFalseValue InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Int32Value OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseBlankValue Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Base64BinaryValue Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "rect");
            builder.AddChild<Path>();
            builder.AddChild<Formulas>();
            builder.AddChild<ShapeHandles>();
            builder.AddChild<Fill>();
            builder.AddChild<Stroke>();
            builder.AddChild<Shadow>();
            builder.AddChild<TextBox>();
            builder.AddChild<TextPath>();
            builder.AddChild<ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddElement<Rectangle>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "href", a => a.Href)
.AddAttribute(0, "target", a => a.Target)
.AddAttribute(0, "class", a => a.Class)
.AddAttribute(0, "title", a => a.Title)
.AddAttribute(0, "alt", a => a.Alternate)
.AddAttribute(0, "coordsize", a => a.CoordinateSize)
.AddAttribute(0, "coordorigin", a => a.CoordinateOrigin)
.AddAttribute(0, "wrapcoords", a => a.WrapCoordinates)
.AddAttribute(0, "print", a => a.Print)
.AddAttribute(27, "spid", a => a.OptionalString)
.AddAttribute(27, "oned", a => a.Oned)
.AddAttribute(27, "regroupid", a => a.RegroupId)
.AddAttribute(27, "doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute(27, "button", a => a.Button)
.AddAttribute(27, "userhidden", a => a.UserHidden)
.AddAttribute(27, "bullet", a => a.Bullet)
.AddAttribute(27, "hr", a => a.Horizontal)
.AddAttribute(27, "hrstd", a => a.HorizontalStandard)
.AddAttribute(27, "hrnoshade", a => a.HorizontalNoShade)
.AddAttribute(27, "hrpct", a => a.HorizontalPercentage)
.AddAttribute(27, "hralign", a => a.HorizontalAlignment)
.AddAttribute(27, "allowincell", a => a.AllowInCell)
.AddAttribute(27, "allowoverlap", a => a.AllowOverlap)
.AddAttribute(27, "userdrawn", a => a.UserDrawn)
.AddAttribute(27, "bordertopcolor", a => a.BorderTopColor)
.AddAttribute(27, "borderleftcolor", a => a.BorderLeftColor)
.AddAttribute(27, "borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute(27, "borderrightcolor", a => a.BorderRightColor)
.AddAttribute(27, "dgmlayout", a => a.DiagramLayout)
.AddAttribute(27, "dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute(27, "dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute(27, "insetmode", a => a.InsetMode)
.AddAttribute(0, "filled", a => a.Filled)
.AddAttribute(0, "fillcolor", a => a.FillColor)
.AddAttribute(0, "stroked", a => a.Stroked)
.AddAttribute(0, "strokecolor", a => a.StrokeColor)
.AddAttribute(0, "strokeweight", a => a.StrokeWeight)
.AddAttribute(0, "insetpen", a => a.InsetPen)
.AddAttribute(27, "spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute(27, "connectortype", a => a.ConnectorType)
.AddAttribute(27, "bwmode", a => a.BlackWhiteMode)
.AddAttribute(27, "bwpure", a => a.PureBlackWhiteMode)
.AddAttribute(27, "bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute(27, "forcedash", a => a.ForceDash)
.AddAttribute(27, "oleicon", a => a.OleIcon)
.AddAttribute(27, "ole", a => a.Ole)
.AddAttribute(27, "preferrelative", a => a.PreferRelative)
.AddAttribute(27, "cliptowrap", a => a.ClipToWrap)
.AddAttribute(27, "clip", a => a.Clip)
.AddAttribute(27, "gfxdata", a => a.Gfxdata);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 0)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                }
            };
            builder.AddConstraint(new AttributeValueSetConstraint(30 /*ovml:dgmlayout*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint(32 /*ovml:dgmlayoutmru*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, true, null));
            builder.AddConstraint(new AttributeValueSetConstraint(40 /*ovml:spt*/, true, new string[] { "1" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Rectangle>(deep);
    }

    /// <summary>
    /// <para>Rounded Rectangle.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:roundrect.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Path &lt;v:path></description></item>
    ///   <item><description>Formulas &lt;v:formulas></description></item>
    ///   <item><description>ShapeHandles &lt;v:handles></description></item>
    ///   <item><description>Fill &lt;v:fill></description></item>
    ///   <item><description>Stroke &lt;v:stroke></description></item>
    ///   <item><description>Shadow &lt;v:shadow></description></item>
    ///   <item><description>TextBox &lt;v:textbox></description></item>
    ///   <item><description>TextPath &lt;v:textpath></description></item>
    ///   <item><description>ImageData &lt;v:imagedata></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Skew &lt;o:skew></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Extrusion &lt;o:extrusion></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Callout &lt;o:callout></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.Lock &lt;o:lock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.ClipPath &lt;o:clippath></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Office.SignatureLine &lt;o:signatureline></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap &lt;w10:wrap></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock &lt;w10:anchorlock></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder &lt;w10:bordertop></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder &lt;w10:borderbottom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder &lt;w10:borderleft></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder &lt;w10:borderright></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData &lt;xvml:ClientData></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Presentation.TextData &lt;pvml:textdata></description></item>
    /// </list>
    /// </remark>
    public partial class RoundRectangle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RoundRectangle class.
        /// </summary>
        public RoundRectangle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RoundRectangle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RoundRectangle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RoundRectangle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RoundRectangle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RoundRectangle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RoundRectangle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>style</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        public StringValue Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>href</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>
        public StringValue Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>
        public StringValue Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>class</para>
        /// <para>Represents the following attribute in the schema: class</para>
        /// </summary>
        public StringValue Class
        {
            get => GetAttribute<StringValue>();
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

        /// <summary>
        /// <para>alt</para>
        /// <para>Represents the following attribute in the schema: alt</para>
        /// </summary>
        public StringValue Alternate
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>coordsize</para>
        /// <para>Represents the following attribute in the schema: coordsize</para>
        /// </summary>
        public StringValue CoordinateSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>wrapcoords</para>
        /// <para>Represents the following attribute in the schema: wrapcoords</para>
        /// </summary>
        public StringValue WrapCoordinates
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>print</para>
        /// <para>Represents the following attribute in the schema: print</para>
        /// </summary>
        public TrueFalseValue Print
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional String</para>
        /// <para>Represents the following attribute in the schema: o:spid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue OptionalString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Handle Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oned</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Oned
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Regroup ID</para>
        /// <para>Represents the following attribute in the schema: o:regroupid</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue RegroupId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Double-click Notification Toggle</para>
        /// <para>Represents the following attribute in the schema: o:doubleclicknotify</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue DoubleClickNotify
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Button Behavior Toggle</para>
        /// <para>Represents the following attribute in the schema: o:button</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Button
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Script Anchors</para>
        /// <para>Represents the following attribute in the schema: o:userhidden</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserHidden
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Graphical Bullet</para>
        /// <para>Represents the following attribute in the schema: o:bullet</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Bullet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hr</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Horizontal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Standard Display Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrstd</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalStandard
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule 3D Shading Toggle</para>
        /// <para>Represents the following attribute in the schema: o:hrnoshade</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue HorizontalNoShade
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Length Percentage</para>
        /// <para>Represents the following attribute in the schema: o:hrpct</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public SingleValue HorizontalPercentage
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Horizontal Rule Alignment</para>
        /// <para>Represents the following attribute in the schema: o:hralign</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues> HorizontalAlignment
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowInCell
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow Shape Overlap</para>
        /// <para>Represents the following attribute in the schema: o:allowoverlap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Exists In Master Slide</para>
        /// <para>Represents the following attribute in the schema: o:userdrawn</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue UserDrawn
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Top Color</para>
        /// <para>Represents the following attribute in the schema: o:bordertopcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderTopColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Left Color</para>
        /// <para>Represents the following attribute in the schema: o:borderleftcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderLeftColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Border Color</para>
        /// <para>Represents the following attribute in the schema: o:borderbottomcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderBottomColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Border Right Color</para>
        /// <para>Represents the following attribute in the schema: o:borderrightcolor</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public StringValue BorderRightColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayout</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayout
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmnodekind</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramNodeKind
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Node Recent Layout Identifier</para>
        /// <para>Represents the following attribute in the schema: o:dgmlayoutmru</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public IntegerValue DiagramLayoutMostRecentUsed
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Inset Mode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: filled</para>
        /// </summary>
        public TrueFalseValue Filled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>
        public StringValue FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroked</para>
        /// </summary>
        public TrueFalseValue Stroked
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>
        public StringValue StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: strokeweight</para>
        /// </summary>
        public StringValue StrokeWeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>
        public TrueFalseValue InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Optional Number</para>
        /// <para>Represents the following attribute in the schema: o:spt</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Int32Value OptionalNumber
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Connector Type</para>
        /// <para>Represents the following attribute in the schema: o:connectortype</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues> ConnectorType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ConnectorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Pure Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwpure</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> PureBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Normal Black-and-White Mode</para>
        /// <para>Represents the following attribute in the schema: o:bwnormal</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues> NormalBlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Dashed Outline</para>
        /// <para>Represents the following attribute in the schema: o:forcedash</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Icon Toggle</para>
        /// <para>Represents the following attribute in the schema: o:oleicon</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue OleIcon
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Embedded Object Toggle</para>
        /// <para>Represents the following attribute in the schema: o:ole</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseBlankValue Ole
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relative Resize Toggle</para>
        /// <para>Represents the following attribute in the schema: o:preferrelative</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue PreferRelative
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clip to Wrapping Polygon</para>
        /// <para>Represents the following attribute in the schema: o:cliptowrap</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue ClipToWrap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Clipping Toggle</para>
        /// <para>Represents the following attribute in the schema: o:clip</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public TrueFalseValue Clip
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Encoded Package</para>
        /// <para>Represents the following attribute in the schema: o:gfxdata</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>
        public Base64BinaryValue Gfxdata
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Rounded Corner Arc Size</para>
        /// <para>Represents the following attribute in the schema: arcsize</para>
        /// </summary>
        public StringValue ArcSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "roundrect");
            builder.AddChild<Path>();
            builder.AddChild<Formulas>();
            builder.AddChild<ShapeHandles>();
            builder.AddChild<Fill>();
            builder.AddChild<Stroke>();
            builder.AddChild<Shadow>();
            builder.AddChild<TextBox>();
            builder.AddChild<TextPath>();
            builder.AddChild<ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.ClipPath>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Office.SignatureLine>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Presentation.TextData>();
            builder.AddElement<RoundRectangle>()
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "href", a => a.Href)
.AddAttribute(0, "target", a => a.Target)
.AddAttribute(0, "class", a => a.Class)
.AddAttribute(0, "title", a => a.Title)
.AddAttribute(0, "alt", a => a.Alternate)
.AddAttribute(0, "coordsize", a => a.CoordinateSize)
.AddAttribute(0, "wrapcoords", a => a.WrapCoordinates)
.AddAttribute(0, "print", a => a.Print)
.AddAttribute(27, "spid", a => a.OptionalString)
.AddAttribute(27, "oned", a => a.Oned)
.AddAttribute(27, "regroupid", a => a.RegroupId)
.AddAttribute(27, "doubleclicknotify", a => a.DoubleClickNotify)
.AddAttribute(27, "button", a => a.Button)
.AddAttribute(27, "userhidden", a => a.UserHidden)
.AddAttribute(27, "bullet", a => a.Bullet)
.AddAttribute(27, "hr", a => a.Horizontal)
.AddAttribute(27, "hrstd", a => a.HorizontalStandard)
.AddAttribute(27, "hrnoshade", a => a.HorizontalNoShade)
.AddAttribute(27, "hrpct", a => a.HorizontalPercentage)
.AddAttribute(27, "hralign", a => a.HorizontalAlignment)
.AddAttribute(27, "allowincell", a => a.AllowInCell)
.AddAttribute(27, "allowoverlap", a => a.AllowOverlap)
.AddAttribute(27, "userdrawn", a => a.UserDrawn)
.AddAttribute(27, "bordertopcolor", a => a.BorderTopColor)
.AddAttribute(27, "borderleftcolor", a => a.BorderLeftColor)
.AddAttribute(27, "borderbottomcolor", a => a.BorderBottomColor)
.AddAttribute(27, "borderrightcolor", a => a.BorderRightColor)
.AddAttribute(27, "dgmlayout", a => a.DiagramLayout)
.AddAttribute(27, "dgmnodekind", a => a.DiagramNodeKind)
.AddAttribute(27, "dgmlayoutmru", a => a.DiagramLayoutMostRecentUsed)
.AddAttribute(27, "insetmode", a => a.InsetMode)
.AddAttribute(0, "filled", a => a.Filled)
.AddAttribute(0, "fillcolor", a => a.FillColor)
.AddAttribute(0, "stroked", a => a.Stroked)
.AddAttribute(0, "strokecolor", a => a.StrokeColor)
.AddAttribute(0, "strokeweight", a => a.StrokeWeight)
.AddAttribute(0, "insetpen", a => a.InsetPen)
.AddAttribute(27, "spt", a => a.OptionalNumber, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (202L) });
})
.AddAttribute(27, "connectortype", a => a.ConnectorType)
.AddAttribute(27, "bwmode", a => a.BlackWhiteMode)
.AddAttribute(27, "bwpure", a => a.PureBlackWhiteMode)
.AddAttribute(27, "bwnormal", a => a.NormalBlackWhiteMode)
.AddAttribute(27, "forcedash", a => a.ForceDash)
.AddAttribute(27, "oleicon", a => a.OleIcon)
.AddAttribute(27, "ole", a => a.Ole)
.AddAttribute(27, "preferrelative", a => a.PreferRelative)
.AddAttribute(27, "cliptowrap", a => a.ClipToWrap)
.AddAttribute(27, "clip", a => a.Clip)
.AddAttribute(27, "gfxdata", a => a.Gfxdata)
.AddAttribute(0, "arcsize", a => a.ArcSize);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 0)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Path), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Formulas), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ShapeHandles), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ClipPath), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.SignatureLine), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.AnchorLock), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BottomBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.LeftBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.RightBorder), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Spreadsheet.ClientData), 0, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Presentation.TextData), 0, 1)
                    }
                }
            };
            builder.AddConstraint(new AttributeValueSetConstraint(29 /*ovml:dgmlayout*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new AttributeValueSetConstraint(31 /*ovml:dgmlayoutmru*/, true, new string[] { "0", "1", "2", "3" }));
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:id*/, true, null));
            builder.AddConstraint(new AttributeValueSetConstraint(39 /*ovml:spt*/, true, new string[] { "2" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RoundRectangle>(deep);
    }

    /// <summary>
    /// <para>Shape Handle.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:h.</para>
    /// </summary>
    public partial class ShapeHandle : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeHandle class.
        /// </summary>
        public ShapeHandle() : base()
        {
        }

        /// <summary>
        /// <para>Handle Position</para>
        /// <para>Represents the following attribute in the schema: position</para>
        /// </summary>
        public StringValue Position
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Handle Polar Center</para>
        /// <para>Represents the following attribute in the schema: polar</para>
        /// </summary>
        public StringValue Polar
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Handle Coordinate Mapping</para>
        /// <para>Represents the following attribute in the schema: map</para>
        /// </summary>
        public StringValue Map
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Invert Handle's X Position</para>
        /// <para>Represents the following attribute in the schema: invx</para>
        /// </summary>
        public TrueFalseBlankValue InvertX
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Invert Handle's Y Position</para>
        /// <para>Represents the following attribute in the schema: invy</para>
        /// </summary>
        public TrueFalseBlankValue InvertY
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Handle Inversion Toggle</para>
        /// <para>Represents the following attribute in the schema: switch</para>
        /// </summary>
        public TrueFalseBlankValue Switch
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Handle X Position Range</para>
        /// <para>Represents the following attribute in the schema: xrange</para>
        /// </summary>
        public StringValue XRange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Handle Y Position Range</para>
        /// <para>Represents the following attribute in the schema: yrange</para>
        /// </summary>
        public StringValue YRange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Handle Polar Radius Range</para>
        /// <para>Represents the following attribute in the schema: radiusrange</para>
        /// </summary>
        public StringValue RadiusRange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "h");
            builder.AddElement<ShapeHandle>()
 .AddAttribute(0, "position", a => a.Position)
 .AddAttribute(0, "polar", a => a.Polar)
 .AddAttribute(0, "map", a => a.Map)
 .AddAttribute(0, "invx", a => a.InvertX)
 .AddAttribute(0, "invy", a => a.InvertY)
 .AddAttribute(0, "switch", a => a.Switch)
 .AddAttribute(0, "xrange", a => a.XRange)
 .AddAttribute(0, "yrange", a => a.YRange)
 .AddAttribute(0, "radiusrange", a => a.RadiusRange);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeHandle>(deep);
    }

    /// <summary>
    /// <para>Single Formula.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is v:f.</para>
    /// </summary>
    public partial class Formula : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Formula class.
        /// </summary>
        public Formula() : base()
        {
        }

        /// <summary>
        /// <para>Equation</para>
        /// <para>Represents the following attribute in the schema: eqn</para>
        /// </summary>
        public StringValue Equation
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(26, "f");
            builder.AddElement<Formula>()
 .AddAttribute(0, "eqn", a => a.Equation);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formula>(deep);
    }

    /// <summary>
    /// VML Extension Handling Behaviors
    /// </summary>
    public enum ExtensionHandlingBehaviorValues
    {
        ///<summary>
        ///Not renderable.
        ///<para>When the item is serialized out as xml, its value is "view".</para>
        ///</summary>
        [EnumString("view")]
        View,
        ///<summary>
        ///Editable.
        ///<para>When the item is serialized out as xml, its value is "edit".</para>
        ///</summary>
        [EnumString("edit")]
        Edit,
        ///<summary>
        ///Renderable.
        ///<para>When the item is serialized out as xml, its value is "backwardCompatible".</para>
        ///</summary>
        [EnumString("backwardCompatible")]
        BackwardCompatible,
    }

    /// <summary>
    /// Shape Fill Type
    /// </summary>
    public enum FillTypeValues
    {
        ///<summary>
        ///Solid Fill.
        ///<para>When the item is serialized out as xml, its value is "solid".</para>
        ///</summary>
        [EnumString("solid")]
        Solid,
        ///<summary>
        ///Linear Gradient.
        ///<para>When the item is serialized out as xml, its value is "gradient".</para>
        ///</summary>
        [EnumString("gradient")]
        Gradient,
        ///<summary>
        ///Radial Gradient.
        ///<para>When the item is serialized out as xml, its value is "gradientRadial".</para>
        ///</summary>
        [EnumString("gradientRadial")]
        GradientRadial,
        ///<summary>
        ///Tiled Image.
        ///<para>When the item is serialized out as xml, its value is "tile".</para>
        ///</summary>
        [EnumString("tile")]
        Tile,
        ///<summary>
        ///Image Pattern.
        ///<para>When the item is serialized out as xml, its value is "pattern".</para>
        ///</summary>
        [EnumString("pattern")]
        Pattern,
        ///<summary>
        ///Stretch Image to Fit.
        ///<para>When the item is serialized out as xml, its value is "frame".</para>
        ///</summary>
        [EnumString("frame")]
        Frame,
    }

    /// <summary>
    /// Gradient Fill Computation Type
    /// </summary>
    public enum FillMethodValues
    {
        ///<summary>
        ///No Gradient Fill.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Linear Fill.
        ///<para>When the item is serialized out as xml, its value is "linear".</para>
        ///</summary>
        [EnumString("linear")]
        Linear,
        ///<summary>
        ///Sigma Fill.
        ///<para>When the item is serialized out as xml, its value is "sigma".</para>
        ///</summary>
        [EnumString("sigma")]
        Sigma,
        ///<summary>
        ///Application Default Fill.
        ///<para>When the item is serialized out as xml, its value is "any".</para>
        ///</summary>
        [EnumString("any")]
        Any,
        ///<summary>
        ///Linear Sigma Fill.
        ///<para>When the item is serialized out as xml, its value is "linear sigma".</para>
        ///</summary>
        [EnumString("linear sigma")]
        Linearsigma,
    }

    /// <summary>
    /// Stroke Line Style
    /// </summary>
    public enum StrokeLineStyleValues
    {
        ///<summary>
        ///Single Line.
        ///<para>When the item is serialized out as xml, its value is "single".</para>
        ///</summary>
        [EnumString("single")]
        Single,
        ///<summary>
        ///Two Thin Lines.
        ///<para>When the item is serialized out as xml, its value is "thinThin".</para>
        ///</summary>
        [EnumString("thinThin")]
        ThinThin,
        ///<summary>
        ///Thin Line Outside Thick Line.
        ///<para>When the item is serialized out as xml, its value is "thinThick".</para>
        ///</summary>
        [EnumString("thinThick")]
        ThinThick,
        ///<summary>
        ///Thick Line Outside Thin Line.
        ///<para>When the item is serialized out as xml, its value is "thickThin".</para>
        ///</summary>
        [EnumString("thickThin")]
        ThickThin,
        ///<summary>
        ///Thck Line Between Thin Lines.
        ///<para>When the item is serialized out as xml, its value is "thickBetweenThin".</para>
        ///</summary>
        [EnumString("thickBetweenThin")]
        ThickBetweenThin,
    }

    /// <summary>
    /// Line Join Type
    /// </summary>
    public enum StrokeJoinStyleValues
    {
        ///<summary>
        ///Round Joint.
        ///<para>When the item is serialized out as xml, its value is "round".</para>
        ///</summary>
        [EnumString("round")]
        Round,
        ///<summary>
        ///Bevel Joint.
        ///<para>When the item is serialized out as xml, its value is "bevel".</para>
        ///</summary>
        [EnumString("bevel")]
        Bevel,
        ///<summary>
        ///Miter Joint.
        ///<para>When the item is serialized out as xml, its value is "miter".</para>
        ///</summary>
        [EnumString("miter")]
        Miter,
    }

    /// <summary>
    /// Stroke End Cap Type
    /// </summary>
    public enum StrokeEndCapValues
    {
        ///<summary>
        ///Flat End.
        ///<para>When the item is serialized out as xml, its value is "flat".</para>
        ///</summary>
        [EnumString("flat")]
        Flat,
        ///<summary>
        ///Square End.
        ///<para>When the item is serialized out as xml, its value is "square".</para>
        ///</summary>
        [EnumString("square")]
        Square,
        ///<summary>
        ///Round End.
        ///<para>When the item is serialized out as xml, its value is "round".</para>
        ///</summary>
        [EnumString("round")]
        Round,
    }

    /// <summary>
    /// Stroke Arrowhead Length
    /// </summary>
    public enum StrokeArrowLengthValues
    {
        ///<summary>
        ///Short Arrowhead.
        ///<para>When the item is serialized out as xml, its value is "short".</para>
        ///</summary>
        [EnumString("short")]
        Short,
        ///<summary>
        ///Medium Arrowhead.
        ///<para>When the item is serialized out as xml, its value is "medium".</para>
        ///</summary>
        [EnumString("medium")]
        Medium,
        ///<summary>
        ///Long Arrowhead.
        ///<para>When the item is serialized out as xml, its value is "long".</para>
        ///</summary>
        [EnumString("long")]
        Long,
    }

    /// <summary>
    /// Stroke Arrowhead Width
    /// </summary>
    public enum StrokeArrowWidthValues
    {
        ///<summary>
        ///Narrow Arrowhead.
        ///<para>When the item is serialized out as xml, its value is "narrow".</para>
        ///</summary>
        [EnumString("narrow")]
        Narrow,
        ///<summary>
        ///Medium Arrowhead.
        ///<para>When the item is serialized out as xml, its value is "medium".</para>
        ///</summary>
        [EnumString("medium")]
        Medium,
        ///<summary>
        ///Wide Arrowhead.
        ///<para>When the item is serialized out as xml, its value is "wide".</para>
        ///</summary>
        [EnumString("wide")]
        Wide,
    }

    /// <summary>
    /// Stroke Arrowhead Type
    /// </summary>
    public enum StrokeArrowValues
    {
        ///<summary>
        ///No Arrowhead.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Block Arrowhead.
        ///<para>When the item is serialized out as xml, its value is "block".</para>
        ///</summary>
        [EnumString("block")]
        Block,
        ///<summary>
        ///Classic Arrowhead.
        ///<para>When the item is serialized out as xml, its value is "classic".</para>
        ///</summary>
        [EnumString("classic")]
        Classic,
        ///<summary>
        ///Oval Arrowhead.
        ///<para>When the item is serialized out as xml, its value is "oval".</para>
        ///</summary>
        [EnumString("oval")]
        Oval,
        ///<summary>
        ///Diamond Arrowhead.
        ///<para>When the item is serialized out as xml, its value is "diamond".</para>
        ///</summary>
        [EnumString("diamond")]
        Diamond,
        ///<summary>
        ///Open Arrowhead.
        ///<para>When the item is serialized out as xml, its value is "open".</para>
        ///</summary>
        [EnumString("open")]
        Open,
    }

    /// <summary>
    /// Image Scaling Behavior
    /// </summary>
    public enum ImageAspectValues
    {
        ///<summary>
        ///Ignore Aspect Ratio.
        ///<para>When the item is serialized out as xml, its value is "ignore".</para>
        ///</summary>
        [EnumString("ignore")]
        Ignore,
        ///<summary>
        ///At Most.
        ///<para>When the item is serialized out as xml, its value is "atMost".</para>
        ///</summary>
        [EnumString("atMost")]
        AtMost,
        ///<summary>
        ///At Least.
        ///<para>When the item is serialized out as xml, its value is "atLeast".</para>
        ///</summary>
        [EnumString("atLeast")]
        AtLeast,
    }

    /// <summary>
    /// Shape Grouping Types
    /// </summary>
    public enum EditAsValues
    {
        ///<summary>
        ///Shape Canvas.
        ///<para>When the item is serialized out as xml, its value is "canvas".</para>
        ///</summary>
        [EnumString("canvas")]
        Canvas,
        ///<summary>
        ///Organization Chart Diagram.
        ///<para>When the item is serialized out as xml, its value is "orgchart".</para>
        ///</summary>
        [EnumString("orgchart")]
        OrganizationChart,
        ///<summary>
        ///Radial Diagram.
        ///<para>When the item is serialized out as xml, its value is "radial".</para>
        ///</summary>
        [EnumString("radial")]
        Radial,
        ///<summary>
        ///Cycle Diagram.
        ///<para>When the item is serialized out as xml, its value is "cycle".</para>
        ///</summary>
        [EnumString("cycle")]
        Cycle,
        ///<summary>
        ///Pyramid Diagram.
        ///<para>When the item is serialized out as xml, its value is "stacked".</para>
        ///</summary>
        [EnumString("stacked")]
        Stacked,
        ///<summary>
        ///Venn Diagram.
        ///<para>When the item is serialized out as xml, its value is "venn".</para>
        ///</summary>
        [EnumString("venn")]
        Venn,
        ///<summary>
        ///Bullseye Diagram.
        ///<para>When the item is serialized out as xml, its value is "bullseye".</para>
        ///</summary>
        [EnumString("bullseye")]
        Bullseye,
    }

    /// <summary>
    /// Shadow Type
    /// </summary>
    public enum ShadowValues
    {
        ///<summary>
        ///Single Shadow.
        ///<para>When the item is serialized out as xml, its value is "single".</para>
        ///</summary>
        [EnumString("single")]
        Single,
        ///<summary>
        ///Double Shadow.
        ///<para>When the item is serialized out as xml, its value is "double".</para>
        ///</summary>
        [EnumString("double")]
        Double,
        ///<summary>
        ///Embossed Shadow.
        ///<para>When the item is serialized out as xml, its value is "emboss".</para>
        ///</summary>
        [EnumString("emboss")]
        Emboss,
        ///<summary>
        ///Perspective Shadow.
        ///<para>When the item is serialized out as xml, its value is "perspective".</para>
        ///</summary>
        [EnumString("perspective")]
        Perspective,
        ///<summary>
        ///shapeRelative.
        ///<para>When the item is serialized out as xml, its value is "shapeRelative".</para>
        ///</summary>
        [EnumString("shapeRelative")]
        ShapeRelative,
        ///<summary>
        ///drawingRelative.
        ///<para>When the item is serialized out as xml, its value is "drawingRelative".</para>
        ///</summary>
        [EnumString("drawingRelative")]
        DrawingRelative,
    }

    /// <summary>
    /// Defines the StrokeFillTypeValues enumeration.
    /// </summary>
    public enum StrokeFillTypeValues
    {
        ///<summary>
        ///solid.
        ///<para>When the item is serialized out as xml, its value is "solid".</para>
        ///</summary>
        [EnumString("solid")]
        Solid,
        ///<summary>
        ///tile.
        ///<para>When the item is serialized out as xml, its value is "tile".</para>
        ///</summary>
        [EnumString("tile")]
        Tile,
        ///<summary>
        ///pattern.
        ///<para>When the item is serialized out as xml, its value is "pattern".</para>
        ///</summary>
        [EnumString("pattern")]
        Pattern,
        ///<summary>
        ///frame.
        ///<para>When the item is serialized out as xml, its value is "frame".</para>
        ///</summary>
        [EnumString("frame")]
        Frame,
    }
}