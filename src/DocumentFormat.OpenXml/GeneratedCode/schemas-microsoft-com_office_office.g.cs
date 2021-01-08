// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using DocumentFormat.OpenXml.Vml;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Vml.Office
{
    /// <summary>
    /// <para>New Shape Defaults.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:shapedefaults.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Vml.Fill &lt;v:fill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.ImageData &lt;v:imagedata></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Stroke &lt;v:stroke></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.TextBox &lt;v:textbox></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Vml.Shadow &lt;v:shadow></description></item>
    ///   <item><description>Skew &lt;o:skew></description></item>
    ///   <item><description>Extrusion &lt;o:extrusion></description></item>
    ///   <item><description>Callout &lt;o:callout></description></item>
    ///   <item><description>Lock &lt;o:lock></description></item>
    ///   <item><description>ColorMostRecentlyUsed &lt;o:colormru></description></item>
    ///   <item><description>ColorMenu &lt;o:colormenu></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "shapedefaults")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShapeDefaults : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeDefaults class.
        /// </summary>
        public ShapeDefaults() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeDefaults class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeDefaults(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeDefaults class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeDefaults(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeDefaults class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeDefaults(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape ID Optional Storage</para>
        /// <para>Represents the following attribute in the schema: spidmax</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "spidmax")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue MaxShapeId
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>style</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "style")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Fill Toggle</para>
        /// <para>Represents the following attribute in the schema: fill</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "fill")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue BeFilled
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Default Fill Color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "fillcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: stroke</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "stroke")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue IsStroke
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Stroke Color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "strokecolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Allow in Table Cell</para>
        /// <para>Represents the following attribute in the schema: o:allowincell</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(27, "allowincell")]
#pragma warning restore CS0618 // Type or member is obsolete

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

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(27, "allowoverlap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue AllowOverlap
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insetmode</para>
        /// <para>Represents the following attribute in the schema: o:insetmode</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(27, "insetmode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues> InsetMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.InsetMarginValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "shapedefaults");
            builder.AddChild<DocumentFormat.OpenXml.Vml.Fill>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.ImageData>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Stroke>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.TextBox>();
            builder.AddChild<DocumentFormat.OpenXml.Vml.Shadow>();
            builder.AddChild<Skew>();
            builder.AddChild<Extrusion>();
            builder.AddChild<Callout>();
            builder.AddChild<Lock>();
            builder.AddChild<ColorMostRecentlyUsed>();
            builder.AddChild<ColorMenu>();
            builder.AddElement<ShapeDefaults>()
.AddAttribute(26, "ext", a => a.Extension)
.AddAttribute(0, "spidmax", a => a.MaxShapeId)
.AddAttribute(0, "style", a => a.Style)
.AddAttribute(0, "fill", a => a.BeFilled)
.AddAttribute(0, "fillcolor", a => a.FillColor)
.AddAttribute(0, "stroke", a => a.IsStroke)
.AddAttribute(0, "strokecolor", a => a.StrokeColor)
.AddAttribute(27, "allowincell", a => a.AllowInCell)
.AddAttribute(27, "allowoverlap", a => a.AllowOverlap)
.AddAttribute(27, "insetmode", a => a.InsetMode);
            builder.Particle = new CompositeParticle.Builder(ParticleType.All, 0, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Fill), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.ImageData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Stroke), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.TextBox), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Shadow), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Skew), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Extrusion), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Callout), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Lock), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ColorMenu), 0, 1)
            };
        }

        /// <summary>
        /// <para>Fill.</para>
        /// <para>Represents the following element tag in the schema: v:fill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:v = urn:schemas-microsoft-com:vml
        /// </remark>
        public DocumentFormat.OpenXml.Vml.Fill Fill
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.Fill>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ImageData.</para>
        /// <para>Represents the following element tag in the schema: v:imagedata.</para>
        /// </summary>
        /// <remark>
        /// xmlns:v = urn:schemas-microsoft-com:vml
        /// </remark>
        public DocumentFormat.OpenXml.Vml.ImageData ImageData
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.ImageData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Stroke.</para>
        /// <para>Represents the following element tag in the schema: v:stroke.</para>
        /// </summary>
        /// <remark>
        /// xmlns:v = urn:schemas-microsoft-com:vml
        /// </remark>
        public DocumentFormat.OpenXml.Vml.Stroke Stroke
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.Stroke>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TextBox.</para>
        /// <para>Represents the following element tag in the schema: v:textbox.</para>
        /// </summary>
        /// <remark>
        /// xmlns:v = urn:schemas-microsoft-com:vml
        /// </remark>
        public DocumentFormat.OpenXml.Vml.TextBox TextBox
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.TextBox>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shadow.</para>
        /// <para>Represents the following element tag in the schema: v:shadow.</para>
        /// </summary>
        /// <remark>
        /// xmlns:v = urn:schemas-microsoft-com:vml
        /// </remark>
        public DocumentFormat.OpenXml.Vml.Shadow Shadow
        {
            get => GetElement<DocumentFormat.OpenXml.Vml.Shadow>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Skew.</para>
        /// <para>Represents the following element tag in the schema: o:skew.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public Skew Skew
        {
            get => GetElement<Skew>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Extrusion.</para>
        /// <para>Represents the following element tag in the schema: o:extrusion.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public Extrusion Extrusion
        {
            get => GetElement<Extrusion>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Callout.</para>
        /// <para>Represents the following element tag in the schema: o:callout.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public Callout Callout
        {
            get => GetElement<Callout>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Protections.</para>
        /// <para>Represents the following element tag in the schema: o:lock.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public Lock Lock
        {
            get => GetElement<Lock>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Most Recently Used Colors.</para>
        /// <para>Represents the following element tag in the schema: o:colormru.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public ColorMostRecentlyUsed ColorMostRecentlyUsed
        {
            get => GetElement<ColorMostRecentlyUsed>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>UI Default Colors.</para>
        /// <para>Represents the following element tag in the schema: o:colormenu.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public ColorMenu ColorMenu
        {
            get => GetElement<ColorMenu>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeDefaults>(deep);
    }

    /// <summary>
    /// <para>Shape Layout Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:shapelayout.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ShapeIdMap &lt;o:idmap></description></item>
    ///   <item><description>RegroupTable &lt;o:regrouptable></description></item>
    ///   <item><description>Rules &lt;o:rules></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "shapelayout")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShapeLayout : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeLayout class.
        /// </summary>
        public ShapeLayout() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeLayout class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeLayout(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeLayout class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeLayout(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeLayout class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeLayout(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "shapelayout");
            builder.AddChild<ShapeIdMap>();
            builder.AddChild<RegroupTable>();
            builder.AddChild<Rules>();
            builder.AddElement<ShapeLayout>()
.AddAttribute(26, "ext", a => a.Extension);
            builder.Particle = new CompositeParticle.Builder(ParticleType.All, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.ShapeIdMap), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.RegroupTable), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Rules), 0, 1)
            };
        }

        /// <summary>
        /// <para>Shape ID Map.</para>
        /// <para>Represents the following element tag in the schema: o:idmap.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public ShapeIdMap ShapeIdMap
        {
            get => GetElement<ShapeIdMap>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Grouping History.</para>
        /// <para>Represents the following element tag in the schema: o:regrouptable.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public RegroupTable RegroupTable
        {
            get => GetElement<RegroupTable>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Rule Set.</para>
        /// <para>Represents the following element tag in the schema: o:rules.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public Rules Rules
        {
            get => GetElement<Rules>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeLayout>(deep);
    }

    /// <summary>
    /// <para>Digital Signature Line.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:signatureline.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "signatureline")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SignatureLine : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SignatureLine class.
        /// </summary>
        public SignatureLine() : base()
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Signature Line Flag</para>
        /// <para>Represents the following attribute in the schema: issignatureline</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "issignatureline")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue IsSignatureLine
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Unique ID</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Signature Provider ID</para>
        /// <para>Represents the following attribute in the schema: provid</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "provid")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue ProviderId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Use Signing Instructions Flag</para>
        /// <para>Represents the following attribute in the schema: signinginstructionsset</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "signinginstructionsset")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue SigningInstructionsSet
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>User-specified Comments Flag</para>
        /// <para>Represents the following attribute in the schema: allowcomments</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "allowcomments")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue AllowComments
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Show Signed Date Flag</para>
        /// <para>Represents the following attribute in the schema: showsigndate</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "showsigndate")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue ShowSignDate
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Suggested Signer Line 1</para>
        /// <para>Represents the following attribute in the schema: o:suggestedsigner</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(27, "suggestedsigner")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue SuggestedSigner
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Suggested Signer Line 2</para>
        /// <para>Represents the following attribute in the schema: o:suggestedsigner2</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(27, "suggestedsigner2")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue SuggestedSigner2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Suggested Signer E-mail Address</para>
        /// <para>Represents the following attribute in the schema: o:suggestedsigneremail</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(27, "suggestedsigneremail")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue SuggestedSignerEmail
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Instructions for Signing</para>
        /// <para>Represents the following attribute in the schema: signinginstructions</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "signinginstructions")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue SigningInstructions
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Additional Signature Information</para>
        /// <para>Represents the following attribute in the schema: addlxml</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "addlxml")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue AdditionalXml
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Signature Provider Download URL</para>
        /// <para>Represents the following attribute in the schema: sigprovurl</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "sigprovurl")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue SignatureProviderUrl
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "signatureline");
            builder.AddElement<SignatureLine>()
.AddAttribute(26, "ext", a => a.Extension)
.AddAttribute(0, "issignatureline", a => a.IsSignatureLine)
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "provid", a => a.ProviderId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "signinginstructionsset", a => a.SigningInstructionsSet)
.AddAttribute(0, "allowcomments", a => a.AllowComments)
.AddAttribute(0, "showsigndate", a => a.ShowSignDate)
.AddAttribute(27, "suggestedsigner", a => a.SuggestedSigner)
.AddAttribute(27, "suggestedsigner2", a => a.SuggestedSigner2)
.AddAttribute(27, "suggestedsigneremail", a => a.SuggestedSignerEmail)
.AddAttribute(0, "signinginstructions", a => a.SigningInstructions)
.AddAttribute(0, "addlxml", a => a.AdditionalXml)
.AddAttribute(0, "sigprovurl", a => a.SignatureProviderUrl);
            builder.AddConstraint(new UniqueAttributeValueConstraint(2 /*:id*/, true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SignatureLine>(deep);
    }

    /// <summary>
    /// <para>Ink.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:ink.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "ink")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Ink : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Ink class.
        /// </summary>
        public Ink() : base()
        {
        }

        /// <summary>
        /// <para>Ink Data</para>
        /// <para>Represents the following attribute in the schema: i</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "i")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Base64BinaryValue InkData
        {
            get => GetAttribute<Base64BinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Annotation Flag</para>
        /// <para>Represents the following attribute in the schema: annotation</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "annotation")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue AnnotationFlag
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "ink");
            builder.AddElement<Ink>()
.AddAttribute(0, "i", a => a.InkData)
.AddAttribute(0, "annotation", a => a.AnnotationFlag);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Ink>(deep);
    }

    /// <summary>
    /// <para>VML Diagram.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:diagram.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RelationTable &lt;o:relationtable></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "diagram")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Diagram : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Diagram class.
        /// </summary>
        public Diagram() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Diagram class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Diagram(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Diagram class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Diagram(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Diagram class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Diagram(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Style Options</para>
        /// <para>Represents the following attribute in the schema: dgmstyle</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "dgmstyle")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue Style
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Automatic Format</para>
        /// <para>Represents the following attribute in the schema: autoformat</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "autoformat")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue AutoFormat
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Reverse Direction</para>
        /// <para>Represents the following attribute in the schema: reverse</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "reverse")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue Reverse
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Automatic Layout</para>
        /// <para>Represents the following attribute in the schema: autolayout</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "autolayout")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue AutoLayout
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Layout X Scale</para>
        /// <para>Represents the following attribute in the schema: dgmscalex</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "dgmscalex")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue ScaleX
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Layout Y Scale</para>
        /// <para>Represents the following attribute in the schema: dgmscaley</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "dgmscaley")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue ScaleY
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Font Size</para>
        /// <para>Represents the following attribute in the schema: dgmfontsize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "dgmfontsize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue FontSize
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Layout Extents</para>
        /// <para>Represents the following attribute in the schema: constrainbounds</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "constrainbounds")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue ConstrainBounds
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Base Font Size</para>
        /// <para>Represents the following attribute in the schema: dgmbasetextscale</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "dgmbasetextscale")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue BaseTextScale
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "diagram");
            builder.AddChild<RelationTable>();
            builder.AddElement<Diagram>()
.AddAttribute(26, "ext", a => a.Extension)
.AddAttribute(0, "dgmstyle", a => a.Style)
.AddAttribute(0, "autoformat", a => a.AutoFormat)
.AddAttribute(0, "reverse", a => a.Reverse)
.AddAttribute(0, "autolayout", a => a.AutoLayout)
.AddAttribute(0, "dgmscalex", a => a.ScaleX)
.AddAttribute(0, "dgmscaley", a => a.ScaleY)
.AddAttribute(0, "dgmfontsize", a => a.FontSize)
.AddAttribute(0, "constrainbounds", a => a.ConstrainBounds)
.AddAttribute(0, "dgmbasetextscale", a => a.BaseTextScale);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.RelationTable), 0, 1)
            };
        }

        /// <summary>
        /// <para>Diagram Relationship Table.</para>
        /// <para>Represents the following element tag in the schema: o:relationtable.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public RelationTable RelationTable
        {
            get => GetElement<RelationTable>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Diagram>(deep);
    }

    /// <summary>
    /// <para>Skew Transform.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:skew.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "skew")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Skew : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Skew class.
        /// </summary>
        public Skew() : base()
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Skew ID</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Skew Toggle</para>
        /// <para>Represents the following attribute in the schema: on</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "on")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue On
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Skew Offset</para>
        /// <para>Represents the following attribute in the schema: offset</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "offset")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Offset
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Skew Origin</para>
        /// <para>Represents the following attribute in the schema: origin</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "origin")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Origin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Skew Perspective Matrix</para>
        /// <para>Represents the following attribute in the schema: matrix</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "matrix")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Matrix
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "skew");
            builder.AddElement<Skew>()
.AddAttribute(26, "ext", a => a.Extension)
.AddAttribute(0, "id", a => a.Id)
.AddAttribute(0, "on", a => a.On)
.AddAttribute(0, "offset", a => a.Offset)
.AddAttribute(0, "origin", a => a.Origin)
.AddAttribute(0, "matrix", a => a.Matrix);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Skew>(deep);
    }

    /// <summary>
    /// <para>3D Extrusion.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:extrusion.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "extrusion")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Extrusion : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Extrusion class.
        /// </summary>
        public Extrusion() : base()
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extrusion Toggle</para>
        /// <para>Represents the following attribute in the schema: on</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "on")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue On
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extrusion Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extrusion Render Mode</para>
        /// <para>Represents the following attribute in the schema: render</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "render")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues> Render
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extrusion Viewpoint Origin</para>
        /// <para>Represents the following attribute in the schema: viewpointorigin</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "viewpointorigin")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue ViewpointOrigin
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extrusion Viewpoint</para>
        /// <para>Represents the following attribute in the schema: viewpoint</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "viewpoint")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Viewpoint
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extrusion Skew Angle</para>
        /// <para>Represents the following attribute in the schema: skewangle</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "skewangle")]
#pragma warning restore CS0618 // Type or member is obsolete

        public SingleValue SkewAngle
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extrusion Skew</para>
        /// <para>Represents the following attribute in the schema: skewamt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "skewamt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue SkewAmount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Forward Extrusion</para>
        /// <para>Represents the following attribute in the schema: foredepth</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "foredepth")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue ForceDepth
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Backward Extrusion Depth</para>
        /// <para>Represents the following attribute in the schema: backdepth</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "backdepth")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue BackDepth
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Rotation Axis</para>
        /// <para>Represents the following attribute in the schema: orientation</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "orientation")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Orientation
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Rotation Around Axis</para>
        /// <para>Represents the following attribute in the schema: orientationangle</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "orientationangle")]
#pragma warning restore CS0618 // Type or member is obsolete

        public SingleValue OrientationAngle
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Rotation Toggle</para>
        /// <para>Represents the following attribute in the schema: lockrotationcenter</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "lockrotationcenter")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue LockRotationCenter
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Center of Rotation Toggle</para>
        /// <para>Represents the following attribute in the schema: autorotationcenter</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "autorotationcenter")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue AutoRotationCenter
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Rotation Center</para>
        /// <para>Represents the following attribute in the schema: rotationcenter</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "rotationcenter")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue RotationCenter
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>X-Y Rotation Angle</para>
        /// <para>Represents the following attribute in the schema: rotationangle</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "rotationangle")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue RotationAngle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extrusion Color</para>
        /// <para>Represents the following attribute in the schema: color</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "color")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Color
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shininess</para>
        /// <para>Represents the following attribute in the schema: shininess</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "shininess")]
#pragma warning restore CS0618 // Type or member is obsolete

        public SingleValue Shininess
        {
            get => GetAttribute<SingleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Specularity</para>
        /// <para>Represents the following attribute in the schema: specularity</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "specularity")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Specularity
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diffuse Reflection</para>
        /// <para>Represents the following attribute in the schema: diffusity</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "diffusity")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Diffusity
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Metallic Surface Toggle</para>
        /// <para>Represents the following attribute in the schema: metal</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "metal")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue Metal
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Simulated Bevel</para>
        /// <para>Represents the following attribute in the schema: edge</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "edge")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Edge
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Faceting Quality</para>
        /// <para>Represents the following attribute in the schema: facet</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "facet")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Facet
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Face Lighting Toggle</para>
        /// <para>Represents the following attribute in the schema: lightface</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "lightface")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue LightFace
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Brightness</para>
        /// <para>Represents the following attribute in the schema: brightness</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "brightness")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Brightness
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Primary Light Position</para>
        /// <para>Represents the following attribute in the schema: lightposition</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "lightposition")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue LightPosition
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Primary Light Intensity</para>
        /// <para>Represents the following attribute in the schema: lightlevel</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "lightlevel")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue LightLevel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Primary Light Harshness Toggle</para>
        /// <para>Represents the following attribute in the schema: lightharsh</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "lightharsh")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue LightHarsh
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Secondary Light Position</para>
        /// <para>Represents the following attribute in the schema: lightposition2</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "lightposition2")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue LightPosition2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Secondary Light Intensity</para>
        /// <para>Represents the following attribute in the schema: lightlevel2</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "lightlevel2")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue LightLevel2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Secondary Light Harshness Toggle</para>
        /// <para>Represents the following attribute in the schema: lightharsh2</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "lightharsh2")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue LightHarsh2
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "extrusion");
            builder.AddElement<Extrusion>()
.AddAttribute(26, "ext", a => a.Extension)
.AddAttribute(0, "on", a => a.On)
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "render", a => a.Render)
.AddAttribute(0, "viewpointorigin", a => a.ViewpointOrigin)
.AddAttribute(0, "viewpoint", a => a.Viewpoint)
.AddAttribute(0, "skewangle", a => a.SkewAngle)
.AddAttribute(0, "skewamt", a => a.SkewAmount)
.AddAttribute(0, "foredepth", a => a.ForceDepth)
.AddAttribute(0, "backdepth", a => a.BackDepth)
.AddAttribute(0, "orientation", a => a.Orientation)
.AddAttribute(0, "orientationangle", a => a.OrientationAngle)
.AddAttribute(0, "lockrotationcenter", a => a.LockRotationCenter)
.AddAttribute(0, "autorotationcenter", a => a.AutoRotationCenter)
.AddAttribute(0, "rotationcenter", a => a.RotationCenter)
.AddAttribute(0, "rotationangle", a => a.RotationAngle)
.AddAttribute(0, "color", a => a.Color)
.AddAttribute(0, "shininess", a => a.Shininess)
.AddAttribute(0, "specularity", a => a.Specularity)
.AddAttribute(0, "diffusity", a => a.Diffusity)
.AddAttribute(0, "metal", a => a.Metal)
.AddAttribute(0, "edge", a => a.Edge)
.AddAttribute(0, "facet", a => a.Facet)
.AddAttribute(0, "lightface", a => a.LightFace)
.AddAttribute(0, "brightness", a => a.Brightness)
.AddAttribute(0, "lightposition", a => a.LightPosition)
.AddAttribute(0, "lightlevel", a => a.LightLevel)
.AddAttribute(0, "lightharsh", a => a.LightHarsh)
.AddAttribute(0, "lightposition2", a => a.LightPosition2)
.AddAttribute(0, "lightlevel2", a => a.LightLevel2)
.AddAttribute(0, "lightharsh2", a => a.LightHarsh2);
            builder.AddConstraint(new AttributeValueRangeConstraint(22 /*:facet*/, true, 1, true, 65536, true));
            builder.AddConstraint(new AttributeValuePatternConstraint(21 /*:edge*/, @"(\d{1,5}|1[0-6][0-8]\d{3}|1690[0-8]\d|16909[0-3])pt"));
            builder.AddConstraint(new AttributeValueRangeConstraint(11 /*:orientationangle*/, true, -32767, true, 32767, true));
            builder.AddConstraint(new AttributeValueRangeConstraint(6 /*:skewangle*/, true, -32767, true, 32767, true));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Extrusion>(deep);
    }

    /// <summary>
    /// <para>Defines the Callout Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:callout.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "callout")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Callout : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Callout class.
        /// </summary>
        public Callout() : base()
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Callout toggle</para>
        /// <para>Represents the following attribute in the schema: on</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "on")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue On
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Callout type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Callout gap</para>
        /// <para>Represents the following attribute in the schema: gap</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "gap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Gap
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Callout angle</para>
        /// <para>Represents the following attribute in the schema: angle</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "angle")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.AngleValues> Angle
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.AngleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Callout automatic drop toggle</para>
        /// <para>Represents the following attribute in the schema: dropauto</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "dropauto")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue DropAuto
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Callout drop position</para>
        /// <para>Represents the following attribute in the schema: drop</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "drop")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Drop
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Callout drop distance</para>
        /// <para>Represents the following attribute in the schema: distance</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "distance")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Distance
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Callout length toggle</para>
        /// <para>Represents the following attribute in the schema: lengthspecified</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "lengthspecified")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue LengthSpecified
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Callout length</para>
        /// <para>Represents the following attribute in the schema: length</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "length")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Length
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Callout accent bar toggle</para>
        /// <para>Represents the following attribute in the schema: accentbar</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "accentbar")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue AccentBar
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Callout text border toggle</para>
        /// <para>Represents the following attribute in the schema: textborder</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "textborder")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue TextBorder
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Callout flip x</para>
        /// <para>Represents the following attribute in the schema: minusx</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "minusx")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue MinusX
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Callout flip y</para>
        /// <para>Represents the following attribute in the schema: minusy</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "minusy")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue MinusY
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "callout");
            builder.AddElement<Callout>()
.AddAttribute(26, "ext", a => a.Extension)
.AddAttribute(0, "on", a => a.On)
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "gap", a => a.Gap)
.AddAttribute(0, "angle", a => a.Angle)
.AddAttribute(0, "dropauto", a => a.DropAuto)
.AddAttribute(0, "drop", a => a.Drop)
.AddAttribute(0, "distance", a => a.Distance)
.AddAttribute(0, "lengthspecified", a => a.LengthSpecified)
.AddAttribute(0, "length", a => a.Length)
.AddAttribute(0, "accentbar", a => a.AccentBar)
.AddAttribute(0, "textborder", a => a.TextBorder)
.AddAttribute(0, "minusx", a => a.MinusX)
.AddAttribute(0, "minusy", a => a.MinusY);
            builder.AddConstraint(new AttributeValueSetConstraint(2 /*:type*/, true, new string[] { "rightAngle", "oneSegment", "twoSegment", "threeSegment" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Callout>(deep);
    }

    /// <summary>
    /// <para>Defines the Lock Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:lock.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "lock")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Lock : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Lock class.
        /// </summary>
        public Lock() : base()
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Position Lock</para>
        /// <para>Represents the following attribute in the schema: position</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "position")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue Position
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Selection Lock</para>
        /// <para>Represents the following attribute in the schema: selection</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "selection")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue Selection
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Grouping Lock</para>
        /// <para>Represents the following attribute in the schema: grouping</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "grouping")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue Grouping
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Ungrouping Lock</para>
        /// <para>Represents the following attribute in the schema: ungrouping</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "ungrouping")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue Ungrouping
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Rotation Lock</para>
        /// <para>Represents the following attribute in the schema: rotation</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "rotation")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue Rotation
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Cropping Lock</para>
        /// <para>Represents the following attribute in the schema: cropping</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "cropping")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue Cropping
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Vertices Lock</para>
        /// <para>Represents the following attribute in the schema: verticies</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "verticies")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue Verticies
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Handles Lock</para>
        /// <para>Represents the following attribute in the schema: adjusthandles</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "adjusthandles")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue AdjustHandles
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Lock</para>
        /// <para>Represents the following attribute in the schema: text</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "text")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue TextLock
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Aspect Ratio Lock</para>
        /// <para>Represents the following attribute in the schema: aspectratio</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "aspectratio")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue AspectRatio
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>AutoShape Type Lock</para>
        /// <para>Represents the following attribute in the schema: shapetype</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "shapetype")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue ShapeType
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "lock");
            builder.AddElement<Lock>()
.AddAttribute(26, "ext", a => a.Extension)
.AddAttribute(0, "position", a => a.Position)
.AddAttribute(0, "selection", a => a.Selection)
.AddAttribute(0, "grouping", a => a.Grouping)
.AddAttribute(0, "ungrouping", a => a.Ungrouping)
.AddAttribute(0, "rotation", a => a.Rotation)
.AddAttribute(0, "cropping", a => a.Cropping)
.AddAttribute(0, "verticies", a => a.Verticies)
.AddAttribute(0, "adjusthandles", a => a.AdjustHandles)
.AddAttribute(0, "text", a => a.TextLock)
.AddAttribute(0, "aspectratio", a => a.AspectRatio)
.AddAttribute(0, "shapetype", a => a.ShapeType);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Lock>(deep);
    }

    /// <summary>
    /// <para>Embedded OLE Object.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:OLEObject.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LinkType &lt;o:LinkType></description></item>
    ///   <item><description>LockedField &lt;o:LockedField></description></item>
    ///   <item><description>FieldCodes &lt;o:FieldCodes></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "OLEObject")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class OleObject : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OleObject class.
        /// </summary>
        public OleObject() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleObject class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OleObject(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleObject class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OleObject(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleObject class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OleObject(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>OLE Object Type</para>
        /// <para>Represents the following attribute in the schema: Type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "Type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.OleValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.OleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>OLE Object Application</para>
        /// <para>Represents the following attribute in the schema: ProgID</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "ProgID")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue ProgId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>OLE Object Shape</para>
        /// <para>Represents the following attribute in the schema: ShapeID</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "ShapeID")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue ShapeId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>OLE Object Representation</para>
        /// <para>Represents the following attribute in the schema: DrawAspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "DrawAspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues> DrawAspect
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>OLE Object Unique ID</para>
        /// <para>Represents the following attribute in the schema: ObjectID</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "ObjectID")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue ObjectId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relationship</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(19, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>OLE Update Mode</para>
        /// <para>Represents the following attribute in the schema: UpdateMode</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "UpdateMode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues> UpdateMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "OLEObject");
            builder.AddChild<LinkType>();
            builder.AddChild<LockedField>();
            builder.AddChild<FieldCodes>();
            builder.AddElement<OleObject>()
.AddAttribute(0, "Type", a => a.Type)
.AddAttribute(0, "ProgID", a => a.ProgId)
.AddAttribute(0, "ShapeID", a => a.ShapeId)
.AddAttribute(0, "DrawAspect", a => a.DrawAspect)
.AddAttribute(0, "ObjectID", a => a.ObjectId)
.AddAttribute(19, "id", a => a.Id)
.AddAttribute(0, "UpdateMode", a => a.UpdateMode);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.LinkType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.LockedField), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.FieldCodes), 0, 1)
            };
            builder.AddConstraint(new AttributeValuePatternConstraint(4 /*:ObjectID*/, @"_(\d{1,9}|1\d{9}|20\d{8}|21[0-3]\d{7}|214[0-6]\d{6}|2147[0-3]\d{5}|21474[0-7]\d{4}|214748[0-2]\d{3}|2147483[0-5]\d{2}|21474836[0-3]\d|214748364[0-7])"));
            builder.AddConstraint(new ReferenceExistConstraint(2 /*:ShapeID*/, ".", typeof(DocumentFormat.OpenXml.Vml.Shape), "DocumentFormat.OpenXml.Vml.Shape", 0 /*:id*/));
        }

        /// <summary>
        /// <para>Embedded Object Alternate Image Request.</para>
        /// <para>Represents the following element tag in the schema: o:LinkType.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public LinkType LinkType
        {
            get => GetElement<LinkType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Embedded Object Cannot Be Refreshed.</para>
        /// <para>Represents the following element tag in the schema: o:LockedField.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public LockedField LockedField
        {
            get => GetElement<LockedField>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>WordprocessingML Field Switches.</para>
        /// <para>Represents the following element tag in the schema: o:FieldCodes.</para>
        /// </summary>
        /// <remark>
        /// xmlns:o = urn:schemas-microsoft-com:office:office
        /// </remark>
        public FieldCodes FieldCodes
        {
            get => GetElement<FieldCodes>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OleObject>(deep);
    }

    /// <summary>
    /// <para>Complex.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:complex.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "complex")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Complex : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Complex class.
        /// </summary>
        public Complex() : base()
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "complex");
            builder.AddElement<Complex>()
.AddAttribute(26, "ext", a => a.Extension);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Complex>(deep);
    }

    /// <summary>
    /// <para>Text Box Left Stroke.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:left.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "left")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LeftStroke : StrokeChildType
    {
        /// <summary>
        /// Initializes a new instance of the LeftStroke class.
        /// </summary>
        public LeftStroke() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "left");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LeftStroke>(deep);
    }

    /// <summary>
    /// <para>Text Box Top Stroke.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:top.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "top")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TopStroke : StrokeChildType
    {
        /// <summary>
        /// Initializes a new instance of the TopStroke class.
        /// </summary>
        public TopStroke() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "top");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TopStroke>(deep);
    }

    /// <summary>
    /// <para>Text Box Right Stroke.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:right.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "right")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RightStroke : StrokeChildType
    {
        /// <summary>
        /// Initializes a new instance of the RightStroke class.
        /// </summary>
        public RightStroke() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "right");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RightStroke>(deep);
    }

    /// <summary>
    /// <para>Text Box Bottom Stroke.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:bottom.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "bottom")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BottomStroke : StrokeChildType
    {
        /// <summary>
        /// Initializes a new instance of the BottomStroke class.
        /// </summary>
        public BottomStroke() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "bottom");
            builder.AddConstraint(new AttributeValueRangeConstraint(2 /*:weight*/, true, 0, true, 20116800, true));
            builder.AddConstraint(new AttributeValueRangeConstraint(7 /*:miterlimit*/, true, double.NegativeInfinity, true, 32767, true));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BottomStroke>(deep);
    }

    /// <summary>
    /// <para>Text Box Interior Stroke.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:column.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "column")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColumnStroke : StrokeChildType
    {
        /// <summary>
        /// Initializes a new instance of the ColumnStroke class.
        /// </summary>
        public ColumnStroke() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "column");
            builder.AddConstraint(new AttributeValueSetConstraint(10 /*:dashstyle*/, true, new string[] { "solid", "shortdash", "shortdot", "shortdashdot", "shortdashdotdot", "dot", "dash", "longdash", "longdashdotdot", "dashdot" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnStroke>(deep);
    }

    /// <summary>
    /// <para>Defines the StrokeChildType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class StrokeChildType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the StrokeChildType class.
        /// </summary>
        protected StrokeChildType() : base()
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Toggle</para>
        /// <para>Represents the following attribute in the schema: on</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "on")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue On
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Weight</para>
        /// <para>Represents the following attribute in the schema: weight</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "weight")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Weight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Color</para>
        /// <para>Represents the following attribute in the schema: color</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "color")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Color
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Alternate Pattern Color</para>
        /// <para>Represents the following attribute in the schema: color2</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "color2")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Color2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Opacity</para>
        /// <para>Represents the following attribute in the schema: opacity</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "opacity")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Opacity
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Line Style</para>
        /// <para>Represents the following attribute in the schema: linestyle</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "linestyle")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues> LineStyle
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeLineStyleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Miter Joint Limit</para>
        /// <para>Represents the following attribute in the schema: miterlimit</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "miterlimit")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DecimalValue MiterLimit
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Join Style)</para>
        /// <para>Represents the following attribute in the schema: joinstyle</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "joinstyle")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues> JoinStyle
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeJoinStyleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Cap</para>
        /// <para>Represents the following attribute in the schema: endcap</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "endcap")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues> EndCap
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeEndCapValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Dash Pattern</para>
        /// <para>Represents the following attribute in the schema: dashstyle</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "dashstyle")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue DashStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Inset Border From Path</para>
        /// <para>Represents the following attribute in the schema: insetpen</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "insetpen")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue InsetPen
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Image Style</para>
        /// <para>Represents the following attribute in the schema: filltype</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "filltype")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues> FillType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.FillTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Image Location</para>
        /// <para>Represents the following attribute in the schema: src</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "src")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Image Aspect Ratio</para>
        /// <para>Represents the following attribute in the schema: imageaspect</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "imageaspect")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues> ImageAspect
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ImageAspectValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stroke Image Size</para>
        /// <para>Represents the following attribute in the schema: imagesize</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "imagesize")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue ImageSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Stoke Image Alignment</para>
        /// <para>Represents the following attribute in the schema: imagealignshape</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "imagealignshape")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue ImageAlignShape
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line Start Arrowhead</para>
        /// <para>Represents the following attribute in the schema: startarrow</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "startarrow")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues> StartArrow
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line Start Arrowhead Width</para>
        /// <para>Represents the following attribute in the schema: startarrowwidth</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "startarrowwidth")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues> StartArrowWidth
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line Start Arrowhead Length</para>
        /// <para>Represents the following attribute in the schema: startarrowlength</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "startarrowlength")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues> StartArrowLength
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowLengthValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Arrowhead</para>
        /// <para>Represents the following attribute in the schema: endarrow</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "endarrow")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues> EndArrow
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Arrowhead Width</para>
        /// <para>Represents the following attribute in the schema: endarrowwidth</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "endarrowwidth")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues> EndArrowWidth
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.StrokeArrowWidthValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Line End Arrowhead Length</para>
        /// <para>Represents the following attribute in the schema: endarrowlength</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "endarrowlength")]
#pragma warning restore CS0618 // Type or member is obsolete

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

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(27, "href")]
#pragma warning restore CS0618 // Type or member is obsolete

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

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(27, "althref")]
#pragma warning restore CS0618 // Type or member is obsolete

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

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(27, "title")]
#pragma warning restore CS0618 // Type or member is obsolete

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

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(27, "forcedash")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseValue ForceDash
        {
            get => GetAttribute<TrueFalseValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<StrokeChildType>()
                           .AddAttribute(26, "ext", a => a.Extension)
                           .AddAttribute(0, "on", a => a.On)
                           .AddAttribute(0, "weight", a => a.Weight)
                           .AddAttribute(0, "color", a => a.Color)
                           .AddAttribute(0, "color2", a => a.Color2)
                           .AddAttribute(0, "opacity", a => a.Opacity)
                           .AddAttribute(0, "linestyle", a => a.LineStyle)
                           .AddAttribute(0, "miterlimit", a => a.MiterLimit)
                           .AddAttribute(0, "joinstyle", a => a.JoinStyle)
                           .AddAttribute(0, "endcap", a => a.EndCap)
                           .AddAttribute(0, "dashstyle", a => a.DashStyle)
                           .AddAttribute(0, "insetpen", a => a.InsetPen)
                           .AddAttribute(0, "filltype", a => a.FillType)
                           .AddAttribute(0, "src", a => a.Source)
                           .AddAttribute(0, "imageaspect", a => a.ImageAspect)
                           .AddAttribute(0, "imagesize", a => a.ImageSize)
                           .AddAttribute(0, "imagealignshape", a => a.ImageAlignShape)
                           .AddAttribute(0, "startarrow", a => a.StartArrow)
                           .AddAttribute(0, "startarrowwidth", a => a.StartArrowWidth)
                           .AddAttribute(0, "startarrowlength", a => a.StartArrowLength)
                           .AddAttribute(0, "endarrow", a => a.EndArrow)
                           .AddAttribute(0, "endarrowwidth", a => a.EndArrowWidth)
                           .AddAttribute(0, "endarrowlength", a => a.EndArrowLength)
                           .AddAttribute(27, "href", a => a.Href)
                           .AddAttribute(27, "althref", a => a.AlternateImageReference)
                           .AddAttribute(27, "title", a => a.Title)
                           .AddAttribute(27, "forcedash", a => a.ForceDash);
        }
    }

    /// <summary>
    /// <para>Shape Clipping Path.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:clippath.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "clippath")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ClipPath : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ClipPath class.
        /// </summary>
        public ClipPath() : base()
        {
        }

        /// <summary>
        /// <para>Path Definition</para>
        /// <para>Represents the following attribute in the schema: o:v</para>
        /// </summary>
        /// <remark>
        /// xmlns:o=urn:schemas-microsoft-com:office:office
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(27, "v")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Value
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "clippath");
            builder.AddElement<ClipPath>()
.AddAttribute(27, "v", a => a.Value, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ClipPath>(deep);
    }

    /// <summary>
    /// <para>Shape Fill Extended Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:fill.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "fill")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FillExtendedProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the FillExtendedProperties class.
        /// </summary>
        public FillExtendedProperties() : base()
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fill Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.FillValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.FillValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "fill");
            builder.AddElement<FillExtendedProperties>()
.AddAttribute(26, "ext", a => a.Extension)
.AddAttribute(0, "type", a => a.Type);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillExtendedProperties>(deep);
    }

    /// <summary>
    /// <para>Shape ID Map.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:idmap.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "idmap")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShapeIdMap : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeIdMap class.
        /// </summary>
        public ShapeIdMap() : base()
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape IDs</para>
        /// <para>Represents the following attribute in the schema: data</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "data")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Data
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "idmap");
            builder.AddElement<ShapeIdMap>()
.AddAttribute(26, "ext", a => a.Extension)
.AddAttribute(0, "data", a => a.Data);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeIdMap>(deep);
    }

    /// <summary>
    /// <para>Shape Grouping History.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:regrouptable.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Entry &lt;o:entry></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "regrouptable")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RegroupTable : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RegroupTable class.
        /// </summary>
        public RegroupTable() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RegroupTable class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RegroupTable(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RegroupTable class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RegroupTable(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RegroupTable class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RegroupTable(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "regrouptable");
            builder.AddChild<Entry>();
            builder.AddElement<RegroupTable>()
.AddAttribute(26, "ext", a => a.Extension);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Entry), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RegroupTable>(deep);
    }

    /// <summary>
    /// <para>Rule Set.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:rules.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Rule &lt;o:r></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "rules")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Rules : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Rules class.
        /// </summary>
        public Rules() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rules class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Rules(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rules class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Rules(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rules class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Rules(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "rules");
            builder.AddChild<Rule>();
            builder.AddElement<Rules>()
.AddAttribute(26, "ext", a => a.Extension);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Rule), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Rules>(deep);
    }

    /// <summary>
    /// <para>Regroup Entry.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:entry.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "entry")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Entry : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Entry class.
        /// </summary>
        public Entry() : base()
        {
        }

        /// <summary>
        /// <para>New Group ID</para>
        /// <para>Represents the following attribute in the schema: new</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "new")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value New
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Old Group ID</para>
        /// <para>Represents the following attribute in the schema: old</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "old")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value Old
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "entry");
            builder.AddElement<Entry>()
.AddAttribute(0, "new", a => a.New)
.AddAttribute(0, "old", a => a.Old);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Entry>(deep);
    }

    /// <summary>
    /// <para>Rule.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:r.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Proxy &lt;o:proxy></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "r")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Rule : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Rule class.
        /// </summary>
        public Rule() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rule class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Rule(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rule class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Rule(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rule class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Rule(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rule ID</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "id")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Rule Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.RuleValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.RuleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Alignment Rule Type</para>
        /// <para>Represents the following attribute in the schema: how</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "how")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues> How
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.Office.AlignmentValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Rule Shape Reference</para>
        /// <para>Represents the following attribute in the schema: idref</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "idref")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue ShapeReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "r");
            builder.AddChild<Proxy>();
            builder.AddElement<Rule>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "how", a => a.How)
.AddAttribute(0, "idref", a => a.ShapeReference, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Proxy), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Rule>(deep);
    }

    /// <summary>
    /// <para>Diagram Relationship Table.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:relationtable.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Relation &lt;o:rel></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "relationtable")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RelationTable : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RelationTable class.
        /// </summary>
        public RelationTable() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RelationTable class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RelationTable(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RelationTable class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RelationTable(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RelationTable class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RelationTable(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "relationtable");
            builder.AddChild<Relation>();
            builder.AddElement<RelationTable>()
.AddAttribute(26, "ext", a => a.Extension);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Vml.Office.Relation), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RelationTable>(deep);
    }

    /// <summary>
    /// <para>Diagram Relationship.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:rel.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "rel")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Relation : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Relation class.
        /// </summary>
        public Relation() : base()
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Relationship Source Shape</para>
        /// <para>Represents the following attribute in the schema: idsrc</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "idsrc")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue SourceId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Relationship Destination Shape</para>
        /// <para>Represents the following attribute in the schema: iddest</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "iddest")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue DestinationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Diagram Relationship Center Shape</para>
        /// <para>Represents the following attribute in the schema: idcntr</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "idcntr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue CenterShapeId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "rel");
            builder.AddElement<Relation>()
.AddAttribute(26, "ext", a => a.Extension)
.AddAttribute(0, "idsrc", a => a.SourceId, aBuilder =>
{
   aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "iddest", a => a.DestinationId, aBuilder =>
{
   aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "idcntr", a => a.CenterShapeId, aBuilder =>
{
   aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Relation>(deep);
    }

    /// <summary>
    /// <para>Embedded Object Alternate Image Request.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:LinkType.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "LinkType")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LinkType : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the LinkType class.
        /// </summary>
        public LinkType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LinkType class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public LinkType(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Vml.Office.OleLinkValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Vml.Office.OleLinkValues>>(EnumValidator.Instance);
            builder.SetSchema(27, "LinkType");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LinkType>(deep);
    }

    /// <summary>
    /// <para>Embedded Object Cannot Be Refreshed.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:LockedField.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "LockedField")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LockedField : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the LockedField class.
        /// </summary>
        public LockedField() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LockedField class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public LockedField(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new TrueFalseBlankValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<TrueFalseBlankValue>(NumberValidator.Instance);
            builder.SetSchema(27, "LockedField");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LockedField>(deep);
    }

    /// <summary>
    /// <para>WordprocessingML Field Switches.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:FieldCodes.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "FieldCodes")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FieldCodes : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FieldCodes class.
        /// </summary>
        public FieldCodes() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FieldCodes class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FieldCodes(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "FieldCodes");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FieldCodes>(deep);
    }

    /// <summary>
    /// <para>Shape Reference.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:proxy.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "proxy")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Proxy : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Proxy class.
        /// </summary>
        public Proxy() : base()
        {
        }

        /// <summary>
        /// <para>Start Point Connection Flag</para>
        /// <para>Represents the following attribute in the schema: start</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "start")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseBlankValue Start
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>End Point Connection Flag</para>
        /// <para>Represents the following attribute in the schema: end</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "end")]
#pragma warning restore CS0618 // Type or member is obsolete

        public TrueFalseBlankValue End
        {
            get => GetAttribute<TrueFalseBlankValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Proxy Shape Reference</para>
        /// <para>Represents the following attribute in the schema: idref</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "idref")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue ShapeReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Connection Location</para>
        /// <para>Represents the following attribute in the schema: connectloc</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "connectloc")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value ConnectionLocation
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "proxy");
            builder.AddElement<Proxy>()
.AddAttribute(0, "start", a => a.Start)
.AddAttribute(0, "end", a => a.End)
.AddAttribute(0, "idref", a => a.ShapeReference, aBuilder =>
{
 aBuilder.AddValidator(RequiredValidator.Instance);
 aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "connectloc", a => a.ConnectionLocation, aBuilder =>
{
 aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Proxy>(deep);
    }

    /// <summary>
    /// <para>Most Recently Used Colors.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:colormru.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "colormru")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColorMostRecentlyUsed : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorMostRecentlyUsed class.
        /// </summary>
        public ColorMostRecentlyUsed() : base()
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Recent colors</para>
        /// <para>Represents the following attribute in the schema: colors</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "colors")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue Colors
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "colormru");
            builder.AddElement<ColorMostRecentlyUsed>()
.AddAttribute(26, "ext", a => a.Extension)
.AddAttribute(0, "colors", a => a.Colors);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorMostRecentlyUsed>(deep);
    }

    /// <summary>
    /// <para>UI Default Colors.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is o:colormenu.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(27, "colormenu")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColorMenu : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorMenu class.
        /// </summary>
        public ColorMenu() : base()
        {
        }

        /// <summary>
        /// <para>VML Extension Handling Behavior</para>
        /// <para>Represents the following attribute in the schema: v:ext</para>
        /// </summary>
        /// <remark>
        /// xmlns:v=urn:schemas-microsoft-com:vml
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(26, "ext")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues> Extension
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Default stroke color</para>
        /// <para>Represents the following attribute in the schema: strokecolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "strokecolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue StrokeColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Default fill color</para>
        /// <para>Represents the following attribute in the schema: fillcolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "fillcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue FillColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Default shadow color</para>
        /// <para>Represents the following attribute in the schema: shadowcolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "shadowcolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue ShadowColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Default extrusion color</para>
        /// <para>Represents the following attribute in the schema: extrusioncolor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "extrusioncolor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue ExtrusionColor
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(27, "colormenu");
            builder.AddElement<ColorMenu>()
.AddAttribute(26, "ext", a => a.Extension)
.AddAttribute(0, "strokecolor", a => a.StrokeColor)
.AddAttribute(0, "fillcolor", a => a.FillColor)
.AddAttribute(0, "shadowcolor", a => a.ShadowColor)
.AddAttribute(0, "extrusioncolor", a => a.ExtrusionColor);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorMenu>(deep);
    }

    /// <summary>
    /// Alignment Type
    /// </summary>
    public enum AlignmentValues
    {
        ///<summary>
        ///Top Alignment.
        ///<para>When the item is serialized out as xml, its value is "top".</para>
        ///</summary>
        [EnumString("top")]
        Top,
        ///<summary>
        ///Middle Alignment.
        ///<para>When the item is serialized out as xml, its value is "middle".</para>
        ///</summary>
        [EnumString("middle")]
        Middle,
        ///<summary>
        ///Bottom Alignment.
        ///<para>When the item is serialized out as xml, its value is "bottom".</para>
        ///</summary>
        [EnumString("bottom")]
        Bottom,
        ///<summary>
        ///Left Alignment.
        ///<para>When the item is serialized out as xml, its value is "left".</para>
        ///</summary>
        [EnumString("left")]
        Left,
        ///<summary>
        ///Center Alignment.
        ///<para>When the item is serialized out as xml, its value is "center".</para>
        ///</summary>
        [EnumString("center")]
        Center,
        ///<summary>
        ///Right Alignment.
        ///<para>When the item is serialized out as xml, its value is "right".</para>
        ///</summary>
        [EnumString("right")]
        Right,
    }

    /// <summary>
    /// Screen Sizes Type
    /// </summary>
    public enum ScreenSizeValues
    {
        ///<summary>
        ///544x376 pixels.
        ///<para>When the item is serialized out as xml, its value is "544,376".</para>
        ///</summary>
        [EnumString("544,376")]
        Sz544x376,
        ///<summary>
        ///640x480 pixels.
        ///<para>When the item is serialized out as xml, its value is "640,480".</para>
        ///</summary>
        [EnumString("640,480")]
        Sz640x480,
        ///<summary>
        ///720x512 pixels.
        ///<para>When the item is serialized out as xml, its value is "720,512".</para>
        ///</summary>
        [EnumString("720,512")]
        Sz720x512,
        ///<summary>
        ///800x600 pixels.
        ///<para>When the item is serialized out as xml, its value is "800,600".</para>
        ///</summary>
        [EnumString("800,600")]
        Sz800x600,
        ///<summary>
        ///1024x768 pixels.
        ///<para>When the item is serialized out as xml, its value is "1024,768".</para>
        ///</summary>
        [EnumString("1024,768")]
        Sz1024x768,
        ///<summary>
        ///1152x862 pixels.
        ///<para>When the item is serialized out as xml, its value is "1152,862".</para>
        ///</summary>
        [EnumString("1152,862")]
        Sz1152x862,
    }

    /// <summary>
    /// Inset Margin Type
    /// </summary>
    public enum InsetMarginValues
    {
        ///<summary>
        ///Automatic Margins.
        ///<para>When the item is serialized out as xml, its value is "auto".</para>
        ///</summary>
        [EnumString("auto")]
        Auto,
        ///<summary>
        ///Custom Margins.
        ///<para>When the item is serialized out as xml, its value is "custom".</para>
        ///</summary>
        [EnumString("custom")]
        Custom,
    }

    /// <summary>
    /// Extrusion Color Types
    /// </summary>
    public enum ColorModeValues
    {
        ///<summary>
        ///Use Shape Fill Color.
        ///<para>When the item is serialized out as xml, its value is "auto".</para>
        ///</summary>
        [EnumString("auto")]
        Auto,
        ///<summary>
        ///Use Custom Color.
        ///<para>When the item is serialized out as xml, its value is "custom".</para>
        ///</summary>
        [EnumString("custom")]
        Custom,
    }

    /// <summary>
    /// Extrusion Type
    /// </summary>
    public enum ExtrusionValues
    {
        ///<summary>
        ///Perspective Projection.
        ///<para>When the item is serialized out as xml, its value is "perspective".</para>
        ///</summary>
        [EnumString("perspective")]
        Perspective,
        ///<summary>
        ///Parallel Projection.
        ///<para>When the item is serialized out as xml, its value is "parallel".</para>
        ///</summary>
        [EnumString("parallel")]
        Parallel,
    }

    /// <summary>
    /// Extrusion Rendering Types
    /// </summary>
    public enum ExtrusionRenderValues
    {
        ///<summary>
        ///Solid.
        ///<para>When the item is serialized out as xml, its value is "solid".</para>
        ///</summary>
        [EnumString("solid")]
        Solid,
        ///<summary>
        ///Wireframe.
        ///<para>When the item is serialized out as xml, its value is "wireFrame".</para>
        ///</summary>
        [EnumString("wireFrame")]
        WireFrame,
        ///<summary>
        ///Bounding Cube.
        ///<para>When the item is serialized out as xml, its value is "boundingCube".</para>
        ///</summary>
        [EnumString("boundingCube")]
        BoundingCube,
    }

    /// <summary>
    /// Extrusion Planes
    /// </summary>
    public enum ExtrusionPlaneValues
    {
        ///<summary>
        ///XY Plane.
        ///<para>When the item is serialized out as xml, its value is "XY".</para>
        ///</summary>
        [EnumString("XY")]
        XY,
        ///<summary>
        ///ZX Plane.
        ///<para>When the item is serialized out as xml, its value is "ZX".</para>
        ///</summary>
        [EnumString("ZX")]
        ZX,
        ///<summary>
        ///YZ Plane.
        ///<para>When the item is serialized out as xml, its value is "YZ".</para>
        ///</summary>
        [EnumString("YZ")]
        YZ,
    }

    /// <summary>
    /// Callout Angles
    /// </summary>
    public enum AngleValues
    {
        ///<summary>
        ///Any Angle.
        ///<para>When the item is serialized out as xml, its value is "any".</para>
        ///</summary>
        [EnumString("any")]
        Any,
        ///<summary>
        ///30 degrees.
        ///<para>When the item is serialized out as xml, its value is "30".</para>
        ///</summary>
        [EnumString("30")]
        Degree30,
        ///<summary>
        ///45 degrees.
        ///<para>When the item is serialized out as xml, its value is "45".</para>
        ///</summary>
        [EnumString("45")]
        Degree45,
        ///<summary>
        ///60 degrees.
        ///<para>When the item is serialized out as xml, its value is "60".</para>
        ///</summary>
        [EnumString("60")]
        Degree60,
        ///<summary>
        ///90 degrees.
        ///<para>When the item is serialized out as xml, its value is "90".</para>
        ///</summary>
        [EnumString("90")]
        Degree90,
        ///<summary>
        ///Automatic Angle.
        ///<para>When the item is serialized out as xml, its value is "auto".</para>
        ///</summary>
        [EnumString("auto")]
        Auto,
    }

    /// <summary>
    /// Callout Placement
    /// </summary>
    public enum CalloutPlacementValues
    {
        ///<summary>
        ///Top placement.
        ///<para>When the item is serialized out as xml, its value is "top".</para>
        ///</summary>
        [EnumString("top")]
        Top,
        ///<summary>
        ///Center placement.
        ///<para>When the item is serialized out as xml, its value is "center".</para>
        ///</summary>
        [EnumString("center")]
        Center,
        ///<summary>
        ///Bottom placement.
        ///<para>When the item is serialized out as xml, its value is "bottom".</para>
        ///</summary>
        [EnumString("bottom")]
        Bottom,
        ///<summary>
        ///User-defined placement.
        ///<para>When the item is serialized out as xml, its value is "user".</para>
        ///</summary>
        [EnumString("user")]
        User,
    }

    /// <summary>
    /// Connector Type
    /// </summary>
    public enum ConnectorValues
    {
        ///<summary>
        ///No Connector.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Straight Connector.
        ///<para>When the item is serialized out as xml, its value is "straight".</para>
        ///</summary>
        [EnumString("straight")]
        Straight,
        ///<summary>
        ///Elbow Connector.
        ///<para>When the item is serialized out as xml, its value is "elbow".</para>
        ///</summary>
        [EnumString("elbow")]
        Elbow,
        ///<summary>
        ///Curved Connector.
        ///<para>When the item is serialized out as xml, its value is "curved".</para>
        ///</summary>
        [EnumString("curved")]
        Curved,
    }

    /// <summary>
    /// Alignment Type
    /// </summary>
    public enum HorizontalRuleAlignmentValues
    {
        ///<summary>
        ///Left Alignment.
        ///<para>When the item is serialized out as xml, its value is "left".</para>
        ///</summary>
        [EnumString("left")]
        Left,
        ///<summary>
        ///Right Alignment.
        ///<para>When the item is serialized out as xml, its value is "right".</para>
        ///</summary>
        [EnumString("right")]
        Right,
        ///<summary>
        ///Center Alignment.
        ///<para>When the item is serialized out as xml, its value is "center".</para>
        ///</summary>
        [EnumString("center")]
        Center,
    }

    /// <summary>
    /// Connection Locations Type
    /// </summary>
    public enum ConnectValues
    {
        ///<summary>
        ///No.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Four Connections.
        ///<para>When the item is serialized out as xml, its value is "rect".</para>
        ///</summary>
        [EnumString("rect")]
        Rectangle,
        ///<summary>
        ///Edit Point Connections.
        ///<para>When the item is serialized out as xml, its value is "segments".</para>
        ///</summary>
        [EnumString("segments")]
        Segments,
        ///<summary>
        ///Custom Connections.
        ///<para>When the item is serialized out as xml, its value is "custom".</para>
        ///</summary>
        [EnumString("custom")]
        Custom,
    }

    /// <summary>
    /// Embedded Object Alternate Image Request Types
    /// </summary>
    public enum OleLinkValues
    {
        ///<summary>
        ///Other Image.
        ///<para>When the item is serialized out as xml, its value is "Picture".</para>
        ///</summary>
        [EnumString("Picture")]
        Picture,
        ///<summary>
        ///Bitmap Image.
        ///<para>When the item is serialized out as xml, its value is "Bitmap".</para>
        ///</summary>
        [EnumString("Bitmap")]
        Bitmap,
        ///<summary>
        ///Enhanced Metafile Image.
        ///<para>When the item is serialized out as xml, its value is "EnhancedMetaFile".</para>
        ///</summary>
        [EnumString("EnhancedMetaFile")]
        EnhancedMetaFile,
    }

    /// <summary>
    /// OLE Connection Type
    /// </summary>
    public enum OleValues
    {
        ///<summary>
        ///Embedded Object.
        ///<para>When the item is serialized out as xml, its value is "Embed".</para>
        ///</summary>
        [EnumString("Embed")]
        Embed,
        ///<summary>
        ///Linked Object.
        ///<para>When the item is serialized out as xml, its value is "Link".</para>
        ///</summary>
        [EnumString("Link")]
        Link,
    }

    /// <summary>
    /// OLE Object Representations
    /// </summary>
    public enum OleDrawAspectValues
    {
        ///<summary>
        ///Snapshot.
        ///<para>When the item is serialized out as xml, its value is "Content".</para>
        ///</summary>
        [EnumString("Content")]
        Content,
        ///<summary>
        ///Icon.
        ///<para>When the item is serialized out as xml, its value is "Icon".</para>
        ///</summary>
        [EnumString("Icon")]
        Icon,
    }

    /// <summary>
    /// OLE Update Method Type
    /// </summary>
    public enum OleUpdateModeValues
    {
        ///<summary>
        ///Server Application Update.
        ///<para>When the item is serialized out as xml, its value is "Always".</para>
        ///</summary>
        [EnumString("Always")]
        Always,
        ///<summary>
        ///User Update.
        ///<para>When the item is serialized out as xml, its value is "OnCall".</para>
        ///</summary>
        [EnumString("OnCall")]
        OnCall,
    }

    /// <summary>
    /// Shape Fill Type
    /// </summary>
    public enum FillValues
    {
        ///<summary>
        ///Centered Radial Gradient.
        ///<para>When the item is serialized out as xml, its value is "gradientCenter".</para>
        ///</summary>
        [EnumString("gradientCenter")]
        GradientCenter,
        ///<summary>
        ///Solid Fill.
        ///<para>When the item is serialized out as xml, its value is "solid".</para>
        ///</summary>
        [EnumString("solid")]
        Solid,
        ///<summary>
        ///Image Pattern.
        ///<para>When the item is serialized out as xml, its value is "pattern".</para>
        ///</summary>
        [EnumString("pattern")]
        Pattern,
        ///<summary>
        ///Tiled Image.
        ///<para>When the item is serialized out as xml, its value is "tile".</para>
        ///</summary>
        [EnumString("tile")]
        Tile,
        ///<summary>
        ///Stretch Image to Fit.
        ///<para>When the item is serialized out as xml, its value is "frame".</para>
        ///</summary>
        [EnumString("frame")]
        Frame,
        ///<summary>
        ///Unscaled Gradient.
        ///<para>When the item is serialized out as xml, its value is "gradientUnscaled".</para>
        ///</summary>
        [EnumString("gradientUnscaled")]
        GradientUnscaled,
        ///<summary>
        ///Radial Gradient.
        ///<para>When the item is serialized out as xml, its value is "gradientRadial".</para>
        ///</summary>
        [EnumString("gradientRadial")]
        GradientRadial,
        ///<summary>
        ///Linear Gradient.
        ///<para>When the item is serialized out as xml, its value is "gradient".</para>
        ///</summary>
        [EnumString("gradient")]
        Gradient,
        ///<summary>
        ///Use Background Fill.
        ///<para>When the item is serialized out as xml, its value is "background".</para>
        ///</summary>
        [EnumString("background")]
        Background,
    }

    /// <summary>
    /// Rule Type
    /// </summary>
    public enum RuleValues
    {
        ///<summary>
        ///Arc Rule.
        ///<para>When the item is serialized out as xml, its value is "arc".</para>
        ///</summary>
        [EnumString("arc")]
        Arc,
        ///<summary>
        ///Callout Rule.
        ///<para>When the item is serialized out as xml, its value is "callout".</para>
        ///</summary>
        [EnumString("callout")]
        Callout,
        ///<summary>
        ///Connector Rule.
        ///<para>When the item is serialized out as xml, its value is "connector".</para>
        ///</summary>
        [EnumString("connector")]
        Connector,
    }

    /// <summary>
    /// Black And White Modes
    /// </summary>
    public enum BlackAndWhiteModeValues
    {
        ///<summary>
        ///Color.
        ///<para>When the item is serialized out as xml, its value is "color".</para>
        ///</summary>
        [EnumString("color")]
        Color,
        ///<summary>
        ///Automatic.
        ///<para>When the item is serialized out as xml, its value is "auto".</para>
        ///</summary>
        [EnumString("auto")]
        Auto,
        ///<summary>
        ///Grayscale.
        ///<para>When the item is serialized out as xml, its value is "grayScale".</para>
        ///</summary>
        [EnumString("grayScale")]
        GrayScale,
        ///<summary>
        ///Light grayscale.
        ///<para>When the item is serialized out as xml, its value is "lightGrayScale".</para>
        ///</summary>
        [EnumString("lightGrayScale")]
        LightGrayScale,
        ///<summary>
        ///Inverse Grayscale.
        ///<para>When the item is serialized out as xml, its value is "inverseGray".</para>
        ///</summary>
        [EnumString("inverseGray")]
        InverseGray,
        ///<summary>
        ///Gray Outlines.
        ///<para>When the item is serialized out as xml, its value is "grayOutline".</para>
        ///</summary>
        [EnumString("grayOutline")]
        GrayOutline,
        ///<summary>
        ///Black And White.
        ///<para>When the item is serialized out as xml, its value is "highContrast".</para>
        ///</summary>
        [EnumString("highContrast")]
        HighContrast,
        ///<summary>
        ///Black.
        ///<para>When the item is serialized out as xml, its value is "black".</para>
        ///</summary>
        [EnumString("black")]
        Black,
        ///<summary>
        ///White.
        ///<para>When the item is serialized out as xml, its value is "white".</para>
        ///</summary>
        [EnumString("white")]
        White,
        ///<summary>
        ///Do Not Show.
        ///<para>When the item is serialized out as xml, its value is "undrawn".</para>
        ///</summary>
        [EnumString("undrawn")]
        Undrawn,
        ///<summary>
        ///Black Text And Lines.
        ///<para>When the item is serialized out as xml, its value is "blackTextAndLines".</para>
        ///</summary>
        [EnumString("blackTextAndLines")]
        BlackTextAndLines,
    }
}