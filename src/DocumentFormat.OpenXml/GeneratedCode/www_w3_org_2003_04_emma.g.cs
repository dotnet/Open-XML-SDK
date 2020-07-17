// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2010.Ink;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.EMMA
{
    /// <summary>
    /// <para>Defines the DerivedFrom Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:derived-from.</para>
    /// </summary>
    public partial class DerivedFrom : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DerivedFrom class.
        /// </summary>
        public DerivedFrom() : base()
        {
        }

        /// <summary>
        /// <para>resource</para>
        /// <para>Represents the following attribute in the schema: resource</para>
        /// </summary>
        public StringValue Resource
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>composite</para>
        /// <para>Represents the following attribute in the schema: composite</para>
        /// </summary>
        public BooleanValue Composite
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "derived-from");
            builder.AddElement<DerivedFrom>()
.AddAttribute(0, "resource", a => a.Resource, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "composite", a => a.Composite);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DerivedFrom>(deep);
    }

    /// <summary>
    /// <para>Defines the Info Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:info.</para>
    /// </summary>
    public partial class Info : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Info class.
        /// </summary>
        public Info() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Info class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Info(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Info class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Info(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Info class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Info(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "info");
            builder.AddElement<Info>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
  aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(XsdAny.Other, 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Info>(deep);
    }

    /// <summary>
    /// <para>Defines the Lattice Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:lattice.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Arc &lt;emma:arc></description></item>
    ///   <item><description>Node &lt;emma:node></description></item>
    /// </list>
    /// </remark>
    public partial class Lattice : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Lattice class.
        /// </summary>
        public Lattice() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Lattice class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Lattice(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Lattice class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Lattice(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Lattice class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Lattice(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>initial</para>
        /// <para>Represents the following attribute in the schema: initial</para>
        /// </summary>
        public IntegerValue Initial
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>final</para>
        /// <para>Represents the following attribute in the schema: final</para>
        /// </summary>
        public ListValue<DecimalValue> Final
        {
            get => GetAttribute<ListValue<DecimalValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-uri</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-uri</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue TimeReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-anchor-point</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues> TimeReferenceAnchorPoint
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "lattice");
            builder.AddChild<Arc>();
            builder.AddChild<Node>();
            builder.AddElement<Lattice>()
.AddAttribute(0, "initial", a => a.Initial, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { IsNonNegative = (true) });
})
.AddAttribute(0, "final", a => a.Final, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(44, "time-ref-uri", a => a.TimeReference)
.AddAttribute(44, "time-ref-anchor-point", a => a.TimeReferenceAnchorPoint);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Arc), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Node), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Lattice>(deep);
    }

    /// <summary>
    /// <para>Defines the Literal Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:literal.</para>
    /// </summary>
    public partial class Literal : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Literal class.
        /// </summary>
        public Literal() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Literal class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Literal(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "literal");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Literal>(deep);
    }

    /// <summary>
    /// <para>Defines the Interpretation Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:interpretation.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DerivedFrom &lt;emma:derived-from></description></item>
    ///   <item><description>Info &lt;emma:info></description></item>
    ///   <item><description>Lattice &lt;emma:lattice></description></item>
    ///   <item><description>Literal &lt;emma:literal></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Office2010.Ink.ContextNode &lt;msink:context></description></item>
    /// </list>
    /// </remark>
    public partial class Interpretation : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Interpretation class.
        /// </summary>
        public Interpretation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Interpretation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Interpretation(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Interpretation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Interpretation(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Interpretation class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Interpretation(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tokens</para>
        /// <para>Represents the following attribute in the schema: emma:tokens</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Tokens
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>process</para>
        /// <para>Represents the following attribute in the schema: emma:process</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Process
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lang</para>
        /// <para>Represents the following attribute in the schema: emma:lang</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signal</para>
        /// <para>Represents the following attribute in the schema: emma:signal</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Signal
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signal-size</para>
        /// <para>Represents the following attribute in the schema: emma:signal-size</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public IntegerValue SignalSize
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>media-type</para>
        /// <para>Represents the following attribute in the schema: emma:media-type</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue MediaType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>confidence</para>
        /// <para>Represents the following attribute in the schema: emma:confidence</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public DecimalValue Confidence
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>source</para>
        /// <para>Represents the following attribute in the schema: emma:source</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>start</para>
        /// <para>Represents the following attribute in the schema: emma:start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public UInt64Value Start
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>end</para>
        /// <para>Represents the following attribute in the schema: emma:end</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public UInt64Value End
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-uri</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-uri</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue TimeReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-anchor-point</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues> TimeReferenceAnchorPoint
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>offset-to-start</para>
        /// <para>Represents the following attribute in the schema: emma:offset-to-start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public IntegerValue OffsetToStart
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>duration</para>
        /// <para>Represents the following attribute in the schema: emma:duration</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public IntegerValue Duration
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>medium</para>
        /// <para>Represents the following attribute in the schema: emma:medium</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mode</para>
        /// <para>Represents the following attribute in the schema: emma:mode</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public ListValue<StringValue> Mode
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>function</para>
        /// <para>Represents the following attribute in the schema: emma:function</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Function
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>verbal</para>
        /// <para>Represents the following attribute in the schema: emma:verbal</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public BooleanValue Verbal
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cost</para>
        /// <para>Represents the following attribute in the schema: emma:cost</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public DecimalValue Cost
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>grammar-ref</para>
        /// <para>Represents the following attribute in the schema: emma:grammar-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue GrammarRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endpoint-info-ref</para>
        /// <para>Represents the following attribute in the schema: emma:endpoint-info-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue EndpointInfoRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>model-ref</para>
        /// <para>Represents the following attribute in the schema: emma:model-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue ModelRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dialog-turn</para>
        /// <para>Represents the following attribute in the schema: emma:dialog-turn</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue DialogTurn
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>no-input</para>
        /// <para>Represents the following attribute in the schema: emma:no-input</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public BooleanValue NoInput
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uninterpreted</para>
        /// <para>Represents the following attribute in the schema: emma:uninterpreted</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public BooleanValue Uninterpreted
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "interpretation");
            builder.AddChild<DerivedFrom>();
            builder.AddChild<Info>();
            builder.AddChild<Lattice>();
            builder.AddChild<Literal>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Ink.ContextNode>();
            builder.AddElement<Interpretation>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
})
.AddAttribute(44, "tokens", a => a.Tokens)
.AddAttribute(44, "process", a => a.Process)
.AddAttribute(44, "lang", a => a.Language)
.AddAttribute(44, "signal", a => a.Signal)
.AddAttribute(44, "signal-size", a => a.SignalSize)
.AddAttribute(44, "media-type", a => a.MediaType)
.AddAttribute(44, "confidence", a => a.Confidence, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (1L) });
})
.AddAttribute(44, "source", a => a.Source)
.AddAttribute(44, "start", a => a.Start)
.AddAttribute(44, "end", a => a.End)
.AddAttribute(44, "time-ref-uri", a => a.TimeReference)
.AddAttribute(44, "time-ref-anchor-point", a => a.TimeReferenceAnchorPoint)
.AddAttribute(44, "offset-to-start", a => a.OffsetToStart)
.AddAttribute(44, "duration", a => a.Duration)
.AddAttribute(44, "medium", a => a.Medium)
.AddAttribute(44, "mode", a => a.Mode)
.AddAttribute(44, "function", a => a.Function)
.AddAttribute(44, "verbal", a => a.Verbal)
.AddAttribute(44, "cost", a => a.Cost, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10000000L) });
})
.AddAttribute(44, "grammar-ref", a => a.GrammarRef)
.AddAttribute(44, "endpoint-info-ref", a => a.EndpointInfoRef)
.AddAttribute(44, "model-ref", a => a.ModelRef)
.AddAttribute(44, "dialog-turn", a => a.DialogTurn)
.AddAttribute(44, "no-input", a => a.NoInput)
.AddAttribute(44, "uninterpreted", a => a.Uninterpreted);
            builder.Particle = new CompositeParticle(ParticleType.Group, 0, 0)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.DerivedFrom), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Info), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Lattice), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Literal), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Ink.ContextNode), 0, 1)
                }
            };
            builder.AddConstraint(new AttributeValuePatternConstraint(0 /*:id*/, @"[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueSetConstraint(16 /*emma:mode*/, true, new string[] { "ink" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Interpretation>(deep);
    }

    /// <summary>
    /// <para>Defines the OneOf Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:one-of.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DerivedFrom &lt;emma:derived-from></description></item>
    ///   <item><description>Info &lt;emma:info></description></item>
    ///   <item><description>Interpretation &lt;emma:interpretation></description></item>
    ///   <item><description>OneOf &lt;emma:one-of></description></item>
    ///   <item><description>Group &lt;emma:group></description></item>
    ///   <item><description>Sequence &lt;emma:sequence></description></item>
    /// </list>
    /// </remark>
    public partial class OneOf : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OneOf class.
        /// </summary>
        public OneOf() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OneOf class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OneOf(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OneOf class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OneOf(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OneOf class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OneOf(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>disjunction-type</para>
        /// <para>Represents the following attribute in the schema: disjunction-type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.EMMA.DisjunctionTypeValues> DisjunctionType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.EMMA.DisjunctionTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tokens</para>
        /// <para>Represents the following attribute in the schema: emma:tokens</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Tokens
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>process</para>
        /// <para>Represents the following attribute in the schema: emma:process</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Process
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lang</para>
        /// <para>Represents the following attribute in the schema: emma:lang</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signal</para>
        /// <para>Represents the following attribute in the schema: emma:signal</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Signal
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signal-size</para>
        /// <para>Represents the following attribute in the schema: emma:signal-size</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public IntegerValue SignalSize
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>media-type</para>
        /// <para>Represents the following attribute in the schema: emma:media-type</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue MediaType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>confidence</para>
        /// <para>Represents the following attribute in the schema: emma:confidence</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public DecimalValue Confidence
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>source</para>
        /// <para>Represents the following attribute in the schema: emma:source</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>start</para>
        /// <para>Represents the following attribute in the schema: emma:start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public UInt64Value Start
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>end</para>
        /// <para>Represents the following attribute in the schema: emma:end</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public UInt64Value End
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-uri</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-uri</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue TimeReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-anchor-point</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues> TimeReferenceAnchorPoint
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>offset-to-start</para>
        /// <para>Represents the following attribute in the schema: emma:offset-to-start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public IntegerValue OffsetToStart
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>duration</para>
        /// <para>Represents the following attribute in the schema: emma:duration</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public IntegerValue Duration
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>medium</para>
        /// <para>Represents the following attribute in the schema: emma:medium</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mode</para>
        /// <para>Represents the following attribute in the schema: emma:mode</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public ListValue<StringValue> Mode
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>function</para>
        /// <para>Represents the following attribute in the schema: emma:function</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Function
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>verbal</para>
        /// <para>Represents the following attribute in the schema: emma:verbal</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public BooleanValue Verbal
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cost</para>
        /// <para>Represents the following attribute in the schema: emma:cost</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public DecimalValue Cost
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>grammar-ref</para>
        /// <para>Represents the following attribute in the schema: emma:grammar-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue GrammarRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endpoint-info-ref</para>
        /// <para>Represents the following attribute in the schema: emma:endpoint-info-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue EndpointInfoRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>model-ref</para>
        /// <para>Represents the following attribute in the schema: emma:model-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue ModelRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dialog-turn</para>
        /// <para>Represents the following attribute in the schema: emma:dialog-turn</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue DialogTurn
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "one-of");
            builder.AddChild<DerivedFrom>();
            builder.AddChild<Info>();
            builder.AddChild<Interpretation>();
            builder.AddChild<OneOf>();
            builder.AddChild<Group>();
            builder.AddChild<Sequence>();
            builder.AddElement<OneOf>()
.AddAttribute(0, "disjunction-type", a => a.DisjunctionType)
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
})
.AddAttribute(44, "tokens", a => a.Tokens)
.AddAttribute(44, "process", a => a.Process)
.AddAttribute(44, "lang", a => a.Language)
.AddAttribute(44, "signal", a => a.Signal)
.AddAttribute(44, "signal-size", a => a.SignalSize)
.AddAttribute(44, "media-type", a => a.MediaType)
.AddAttribute(44, "confidence", a => a.Confidence, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (1L) });
})
.AddAttribute(44, "source", a => a.Source)
.AddAttribute(44, "start", a => a.Start)
.AddAttribute(44, "end", a => a.End)
.AddAttribute(44, "time-ref-uri", a => a.TimeReference)
.AddAttribute(44, "time-ref-anchor-point", a => a.TimeReferenceAnchorPoint)
.AddAttribute(44, "offset-to-start", a => a.OffsetToStart)
.AddAttribute(44, "duration", a => a.Duration)
.AddAttribute(44, "medium", a => a.Medium)
.AddAttribute(44, "mode", a => a.Mode)
.AddAttribute(44, "function", a => a.Function)
.AddAttribute(44, "verbal", a => a.Verbal)
.AddAttribute(44, "cost", a => a.Cost, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10000000L) });
})
.AddAttribute(44, "grammar-ref", a => a.GrammarRef)
.AddAttribute(44, "endpoint-info-ref", a => a.EndpointInfoRef)
.AddAttribute(44, "model-ref", a => a.ModelRef)
.AddAttribute(44, "dialog-turn", a => a.DialogTurn);
            builder.Particle = new CompositeParticle(ParticleType.Group, 0, 0)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.DerivedFrom), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Info), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Interpretation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.OneOf), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Group), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Sequence), 1, 1)
                }
            };
            builder.AddConstraint(new AttributeValueSetConstraint(0 /*:disjunction-type*/, true, new string[] { "recognition" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OneOf>(deep);
    }

    /// <summary>
    /// <para>Defines the Group Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:group.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DerivedFrom &lt;emma:derived-from></description></item>
    ///   <item><description>GroupInfo &lt;emma:group-info></description></item>
    ///   <item><description>Info &lt;emma:info></description></item>
    ///   <item><description>Interpretation &lt;emma:interpretation></description></item>
    ///   <item><description>OneOf &lt;emma:one-of></description></item>
    ///   <item><description>Group &lt;emma:group></description></item>
    ///   <item><description>Sequence &lt;emma:sequence></description></item>
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
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tokens</para>
        /// <para>Represents the following attribute in the schema: emma:tokens</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Tokens
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>process</para>
        /// <para>Represents the following attribute in the schema: emma:process</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Process
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lang</para>
        /// <para>Represents the following attribute in the schema: emma:lang</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signal</para>
        /// <para>Represents the following attribute in the schema: emma:signal</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Signal
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signal-size</para>
        /// <para>Represents the following attribute in the schema: emma:signal-size</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public IntegerValue SignalSize
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>media-type</para>
        /// <para>Represents the following attribute in the schema: emma:media-type</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue MediaType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>confidence</para>
        /// <para>Represents the following attribute in the schema: emma:confidence</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public DecimalValue Confidence
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>source</para>
        /// <para>Represents the following attribute in the schema: emma:source</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>start</para>
        /// <para>Represents the following attribute in the schema: emma:start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public UInt64Value Start
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>end</para>
        /// <para>Represents the following attribute in the schema: emma:end</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public UInt64Value End
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-uri</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-uri</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue TimeReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-anchor-point</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues> TimeReferenceAnchorPoint
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>offset-to-start</para>
        /// <para>Represents the following attribute in the schema: emma:offset-to-start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public IntegerValue OffsetToStart
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>duration</para>
        /// <para>Represents the following attribute in the schema: emma:duration</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public IntegerValue Duration
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>medium</para>
        /// <para>Represents the following attribute in the schema: emma:medium</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mode</para>
        /// <para>Represents the following attribute in the schema: emma:mode</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public ListValue<StringValue> Mode
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>function</para>
        /// <para>Represents the following attribute in the schema: emma:function</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Function
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>verbal</para>
        /// <para>Represents the following attribute in the schema: emma:verbal</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public BooleanValue Verbal
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cost</para>
        /// <para>Represents the following attribute in the schema: emma:cost</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public DecimalValue Cost
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>grammar-ref</para>
        /// <para>Represents the following attribute in the schema: emma:grammar-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue GrammarRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endpoint-info-ref</para>
        /// <para>Represents the following attribute in the schema: emma:endpoint-info-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue EndpointInfoRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>model-ref</para>
        /// <para>Represents the following attribute in the schema: emma:model-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue ModelRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dialog-turn</para>
        /// <para>Represents the following attribute in the schema: emma:dialog-turn</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue DialogTurn
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "group");
            builder.AddChild<DerivedFrom>();
            builder.AddChild<GroupInfo>();
            builder.AddChild<Info>();
            builder.AddChild<Interpretation>();
            builder.AddChild<OneOf>();
            builder.AddChild<Group>();
            builder.AddChild<Sequence>();
            builder.AddElement<Group>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
})
.AddAttribute(44, "tokens", a => a.Tokens)
.AddAttribute(44, "process", a => a.Process)
.AddAttribute(44, "lang", a => a.Language)
.AddAttribute(44, "signal", a => a.Signal)
.AddAttribute(44, "signal-size", a => a.SignalSize)
.AddAttribute(44, "media-type", a => a.MediaType)
.AddAttribute(44, "confidence", a => a.Confidence, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (1L) });
})
.AddAttribute(44, "source", a => a.Source)
.AddAttribute(44, "start", a => a.Start)
.AddAttribute(44, "end", a => a.End)
.AddAttribute(44, "time-ref-uri", a => a.TimeReference)
.AddAttribute(44, "time-ref-anchor-point", a => a.TimeReferenceAnchorPoint)
.AddAttribute(44, "offset-to-start", a => a.OffsetToStart)
.AddAttribute(44, "duration", a => a.Duration)
.AddAttribute(44, "medium", a => a.Medium)
.AddAttribute(44, "mode", a => a.Mode)
.AddAttribute(44, "function", a => a.Function)
.AddAttribute(44, "verbal", a => a.Verbal)
.AddAttribute(44, "cost", a => a.Cost, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10000000L) });
})
.AddAttribute(44, "grammar-ref", a => a.GrammarRef)
.AddAttribute(44, "endpoint-info-ref", a => a.EndpointInfoRef)
.AddAttribute(44, "model-ref", a => a.ModelRef)
.AddAttribute(44, "dialog-turn", a => a.DialogTurn);
            builder.Particle = new CompositeParticle(ParticleType.Group, 0, 0)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.DerivedFrom), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.GroupInfo), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Info), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Interpretation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.OneOf), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Group), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Sequence), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Group>(deep);
    }

    /// <summary>
    /// <para>Defines the Sequence Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:sequence.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DerivedFrom &lt;emma:derived-from></description></item>
    ///   <item><description>Info &lt;emma:info></description></item>
    ///   <item><description>Interpretation &lt;emma:interpretation></description></item>
    ///   <item><description>OneOf &lt;emma:one-of></description></item>
    ///   <item><description>Group &lt;emma:group></description></item>
    ///   <item><description>Sequence &lt;emma:sequence></description></item>
    /// </list>
    /// </remark>
    public partial class Sequence : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Sequence class.
        /// </summary>
        public Sequence() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Sequence class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Sequence(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Sequence class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Sequence(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Sequence class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Sequence(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tokens</para>
        /// <para>Represents the following attribute in the schema: emma:tokens</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Tokens
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>process</para>
        /// <para>Represents the following attribute in the schema: emma:process</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Process
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lang</para>
        /// <para>Represents the following attribute in the schema: emma:lang</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signal</para>
        /// <para>Represents the following attribute in the schema: emma:signal</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Signal
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signal-size</para>
        /// <para>Represents the following attribute in the schema: emma:signal-size</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public IntegerValue SignalSize
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>media-type</para>
        /// <para>Represents the following attribute in the schema: emma:media-type</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue MediaType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>confidence</para>
        /// <para>Represents the following attribute in the schema: emma:confidence</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public DecimalValue Confidence
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>source</para>
        /// <para>Represents the following attribute in the schema: emma:source</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>start</para>
        /// <para>Represents the following attribute in the schema: emma:start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public UInt64Value Start
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>end</para>
        /// <para>Represents the following attribute in the schema: emma:end</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public UInt64Value End
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-uri</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-uri</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue TimeReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-anchor-point</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues> TimeReferenceAnchorPoint
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>offset-to-start</para>
        /// <para>Represents the following attribute in the schema: emma:offset-to-start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public IntegerValue OffsetToStart
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>duration</para>
        /// <para>Represents the following attribute in the schema: emma:duration</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public IntegerValue Duration
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>medium</para>
        /// <para>Represents the following attribute in the schema: emma:medium</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mode</para>
        /// <para>Represents the following attribute in the schema: emma:mode</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public ListValue<StringValue> Mode
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>function</para>
        /// <para>Represents the following attribute in the schema: emma:function</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Function
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>verbal</para>
        /// <para>Represents the following attribute in the schema: emma:verbal</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public BooleanValue Verbal
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cost</para>
        /// <para>Represents the following attribute in the schema: emma:cost</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public DecimalValue Cost
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>grammar-ref</para>
        /// <para>Represents the following attribute in the schema: emma:grammar-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue GrammarRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endpoint-info-ref</para>
        /// <para>Represents the following attribute in the schema: emma:endpoint-info-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue EndpointInfoRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>model-ref</para>
        /// <para>Represents the following attribute in the schema: emma:model-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue ModelRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dialog-turn</para>
        /// <para>Represents the following attribute in the schema: emma:dialog-turn</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue DialogTurn
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "sequence");
            builder.AddChild<DerivedFrom>();
            builder.AddChild<Info>();
            builder.AddChild<Interpretation>();
            builder.AddChild<OneOf>();
            builder.AddChild<Group>();
            builder.AddChild<Sequence>();
            builder.AddElement<Sequence>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
})
.AddAttribute(44, "tokens", a => a.Tokens)
.AddAttribute(44, "process", a => a.Process)
.AddAttribute(44, "lang", a => a.Language)
.AddAttribute(44, "signal", a => a.Signal)
.AddAttribute(44, "signal-size", a => a.SignalSize)
.AddAttribute(44, "media-type", a => a.MediaType)
.AddAttribute(44, "confidence", a => a.Confidence, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (1L) });
})
.AddAttribute(44, "source", a => a.Source)
.AddAttribute(44, "start", a => a.Start)
.AddAttribute(44, "end", a => a.End)
.AddAttribute(44, "time-ref-uri", a => a.TimeReference)
.AddAttribute(44, "time-ref-anchor-point", a => a.TimeReferenceAnchorPoint)
.AddAttribute(44, "offset-to-start", a => a.OffsetToStart)
.AddAttribute(44, "duration", a => a.Duration)
.AddAttribute(44, "medium", a => a.Medium)
.AddAttribute(44, "mode", a => a.Mode)
.AddAttribute(44, "function", a => a.Function)
.AddAttribute(44, "verbal", a => a.Verbal)
.AddAttribute(44, "cost", a => a.Cost, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10000000L) });
})
.AddAttribute(44, "grammar-ref", a => a.GrammarRef)
.AddAttribute(44, "endpoint-info-ref", a => a.EndpointInfoRef)
.AddAttribute(44, "model-ref", a => a.ModelRef)
.AddAttribute(44, "dialog-turn", a => a.DialogTurn);
            builder.Particle = new CompositeParticle(ParticleType.Group, 0, 0)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.DerivedFrom), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Info), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Interpretation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.OneOf), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Group), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Sequence), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Sequence>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupInfo Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:group-info.</para>
    /// </summary>
    public partial class GroupInfo : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupInfo class.
        /// </summary>
        public GroupInfo() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupInfo(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupInfo(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupInfo class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupInfo(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>ref</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        public StringValue Reference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "group-info");
            builder.AddElement<GroupInfo>()
.AddAttribute(0, "ref", a => a.Reference, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(XsdAny.Other, 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the Derivation Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:derivation.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Interpretation &lt;emma:interpretation></description></item>
    ///   <item><description>OneOf &lt;emma:one-of></description></item>
    ///   <item><description>Sequence &lt;emma:sequence></description></item>
    ///   <item><description>Group &lt;emma:group></description></item>
    /// </list>
    /// </remark>
    public partial class Derivation : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Derivation class.
        /// </summary>
        public Derivation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Derivation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Derivation(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Derivation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Derivation(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Derivation class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Derivation(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "derivation");
            builder.AddChild<Interpretation>();
            builder.AddChild<OneOf>();
            builder.AddChild<Sequence>();
            builder.AddChild<Group>();
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Interpretation), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.OneOf), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Sequence), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Group), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Derivation>(deep);
    }

    /// <summary>
    /// <para>Defines the Grammar Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:grammar.</para>
    /// </summary>
    public partial class Grammar : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Grammar class.
        /// </summary>
        public Grammar() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ref</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        public StringValue Reference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "grammar");
            builder.AddElement<Grammar>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
})
.AddAttribute(0, "ref", a => a.Reference, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Grammar>(deep);
    }

    /// <summary>
    /// <para>Defines the Model Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:model.</para>
    /// </summary>
    public partial class Model : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Model class.
        /// </summary>
        public Model() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Model(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ref</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        public StringValue Reference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "model");
            builder.AddElement<Model>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
 aBuilder.AddValidator(RequiredValidator.Instance);
 aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
})
.AddAttribute(0, "ref", a => a.Reference, aBuilder =>
{
 aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(XsdAny.Other, 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model>(deep);
    }

    /// <summary>
    /// <para>Defines the EndPointInfo Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:endpoint-info.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>EndPoint &lt;emma:endpoint></description></item>
    /// </list>
    /// </remark>
    public partial class EndPointInfo : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the EndPointInfo class.
        /// </summary>
        public EndPointInfo() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndPointInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EndPointInfo(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndPointInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EndPointInfo(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndPointInfo class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EndPointInfo(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "endpoint-info");
            builder.AddChild<EndPoint>();
            builder.AddElement<EndPointInfo>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.EndPoint), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EndPointInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the EndPoint Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:endpoint.</para>
    /// </summary>
    public partial class EndPoint : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the EndPoint class.
        /// </summary>
        public EndPoint() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndPoint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EndPoint(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndPoint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EndPoint(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndPoint class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EndPoint(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endpoint-role</para>
        /// <para>Represents the following attribute in the schema: emma:endpoint-role</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.EMMA.EndPointRoleValues> EndpointRole
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.EMMA.EndPointRoleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endpoint-address</para>
        /// <para>Represents the following attribute in the schema: emma:endpoint-address</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue EndPointAddress
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>message-id</para>
        /// <para>Represents the following attribute in the schema: emma:message-id</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue MessageId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>port-num</para>
        /// <para>Represents the following attribute in the schema: emma:port-num</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public IntegerValue PortNumber
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>port-type</para>
        /// <para>Represents the following attribute in the schema: emma:port-type</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue PortType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endpoint-pair-ref</para>
        /// <para>Represents the following attribute in the schema: emma:endpoint-pair-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue EndpointPairRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>service-name</para>
        /// <para>Represents the following attribute in the schema: emma:service-name</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue ServiceName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>media-type</para>
        /// <para>Represents the following attribute in the schema: emma:media-type</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue MediaType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>medium</para>
        /// <para>Represents the following attribute in the schema: emma:medium</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mode</para>
        /// <para>Represents the following attribute in the schema: emma:mode</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public ListValue<StringValue> Mode
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "endpoint");
            builder.AddElement<EndPoint>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
})
.AddAttribute(44, "endpoint-role", a => a.EndpointRole)
.AddAttribute(44, "endpoint-address", a => a.EndPointAddress)
.AddAttribute(44, "message-id", a => a.MessageId)
.AddAttribute(44, "port-num", a => a.PortNumber)
.AddAttribute(44, "port-type", a => a.PortType)
.AddAttribute(44, "endpoint-pair-ref", a => a.EndpointPairRef)
.AddAttribute(44, "service-name", a => a.ServiceName)
.AddAttribute(44, "media-type", a => a.MediaType)
.AddAttribute(44, "medium", a => a.Medium)
.AddAttribute(44, "mode", a => a.Mode);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(XsdAny.Other, 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EndPoint>(deep);
    }

    /// <summary>
    /// <para>Defines the Node Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:node.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Info &lt;emma:info></description></item>
    /// </list>
    /// </remark>
    public partial class Node : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Node class.
        /// </summary>
        public Node() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Node class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Node(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Node class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Node(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Node class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Node(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>node-number</para>
        /// <para>Represents the following attribute in the schema: node-number</para>
        /// </summary>
        public IntegerValue NodeNumber
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>confidence</para>
        /// <para>Represents the following attribute in the schema: emma:confidence</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public DecimalValue Confidence
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cost</para>
        /// <para>Represents the following attribute in the schema: emma:cost</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public DecimalValue Cost
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "node");
            builder.AddChild<Info>();
            builder.AddElement<Node>()
.AddAttribute(0, "node-number", a => a.NodeNumber, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { IsNonNegative = (true) });
})
.AddAttribute(44, "confidence", a => a.Confidence, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (1L) });
})
.AddAttribute(44, "cost", a => a.Cost, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10000000L) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Info), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Node>(deep);
    }

    /// <summary>
    /// <para>Defines the Arc Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:arc.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Info &lt;emma:info></description></item>
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
        /// <para>from</para>
        /// <para>Represents the following attribute in the schema: from</para>
        /// </summary>
        public IntegerValue From
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>to</para>
        /// <para>Represents the following attribute in the schema: to</para>
        /// </summary>
        public IntegerValue To
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>start</para>
        /// <para>Represents the following attribute in the schema: emma:start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public UInt64Value Start
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>end</para>
        /// <para>Represents the following attribute in the schema: emma:end</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public UInt64Value End
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>offset-to-start</para>
        /// <para>Represents the following attribute in the schema: emma:offset-to-start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public IntegerValue OffsetToStart
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>duration</para>
        /// <para>Represents the following attribute in the schema: emma:duration</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public IntegerValue Duration
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>confidence</para>
        /// <para>Represents the following attribute in the schema: emma:confidence</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public DecimalValue Confidence
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cost</para>
        /// <para>Represents the following attribute in the schema: emma:cost</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public DecimalValue Cost
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lang</para>
        /// <para>Represents the following attribute in the schema: emma:lang</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>medium</para>
        /// <para>Represents the following attribute in the schema: emma:medium</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>> Medium
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mode</para>
        /// <para>Represents the following attribute in the schema: emma:mode</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public ListValue<StringValue> Mode
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>source</para>
        /// <para>Represents the following attribute in the schema: emma:source</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        public StringValue Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "arc");
            builder.AddChild<Info>();
            builder.AddElement<Arc>()
.AddAttribute(0, "from", a => a.From, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { IsNonNegative = (true) });
})
.AddAttribute(0, "to", a => a.To, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new NumberValidator() { IsNonNegative = (true) });
})
.AddAttribute(44, "start", a => a.Start)
.AddAttribute(44, "end", a => a.End)
.AddAttribute(44, "offset-to-start", a => a.OffsetToStart)
.AddAttribute(44, "duration", a => a.Duration)
.AddAttribute(44, "confidence", a => a.Confidence, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (1L) });
})
.AddAttribute(44, "cost", a => a.Cost, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10000000L) });
})
.AddAttribute(44, "lang", a => a.Language)
.AddAttribute(44, "medium", a => a.Medium)
.AddAttribute(44, "mode", a => a.Mode)
.AddAttribute(44, "source", a => a.Source);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Info), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Arc>(deep);
    }

    /// <summary>
    /// <para>Defines the Emma Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:emma.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Derivation &lt;emma:derivation></description></item>
    ///   <item><description>Grammar &lt;emma:grammar></description></item>
    ///   <item><description>Model &lt;emma:model></description></item>
    ///   <item><description>EndPointInfo &lt;emma:endpoint-info></description></item>
    ///   <item><description>Info &lt;emma:info></description></item>
    ///   <item><description>Interpretation &lt;emma:interpretation></description></item>
    ///   <item><description>OneOf &lt;emma:one-of></description></item>
    ///   <item><description>Group &lt;emma:group></description></item>
    ///   <item><description>Sequence &lt;emma:sequence></description></item>
    /// </list>
    /// </remark>
    public partial class Emma : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Emma class.
        /// </summary>
        public Emma() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Emma class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Emma(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Emma class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Emma(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Emma class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Emma(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>version</para>
        /// <para>Represents the following attribute in the schema: version</para>
        /// </summary>
        public StringValue Version
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(44, "emma");
            builder.AddChild<Derivation>();
            builder.AddChild<Grammar>();
            builder.AddChild<Model>();
            builder.AddChild<EndPointInfo>();
            builder.AddChild<Info>();
            builder.AddChild<Interpretation>();
            builder.AddChild<OneOf>();
            builder.AddChild<Group>();
            builder.AddChild<Sequence>();
            builder.AddElement<Emma>()
.AddAttribute(0, "version", a => a.Version, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Group, 0, 0)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Derivation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Grammar), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Model), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.EndPointInfo), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Info), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Interpretation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.OneOf), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Group), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Sequence), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Emma>(deep);
    }

    /// <summary>
    /// Defines the EndPointRoleValues enumeration.
    /// </summary>
    public enum EndPointRoleValues
    {
        ///<summary>
        ///source.
        ///<para>When the item is serialized out as xml, its value is "source".</para>
        ///</summary>
        [EnumString("source")]
        Source,
        ///<summary>
        ///sink.
        ///<para>When the item is serialized out as xml, its value is "sink".</para>
        ///</summary>
        [EnumString("sink")]
        Sink,
        ///<summary>
        ///reply-to.
        ///<para>When the item is serialized out as xml, its value is "reply-to".</para>
        ///</summary>
        [EnumString("reply-to")]
        Replyto,
        ///<summary>
        ///router.
        ///<para>When the item is serialized out as xml, its value is "router".</para>
        ///</summary>
        [EnumString("router")]
        Router,
    }

    /// <summary>
    /// Defines the MediumValues enumeration.
    /// </summary>
    public enum MediumValues
    {
        ///<summary>
        ///acoustic.
        ///<para>When the item is serialized out as xml, its value is "acoustic".</para>
        ///</summary>
        [EnumString("acoustic")]
        Acoustic,
        ///<summary>
        ///tactile.
        ///<para>When the item is serialized out as xml, its value is "tactile".</para>
        ///</summary>
        [EnumString("tactile")]
        Tactile,
        ///<summary>
        ///visual.
        ///<para>When the item is serialized out as xml, its value is "visual".</para>
        ///</summary>
        [EnumString("visual")]
        Visual,
    }

    /// <summary>
    /// Defines the AnchorPointValues enumeration.
    /// </summary>
    public enum AnchorPointValues
    {
        ///<summary>
        ///start.
        ///<para>When the item is serialized out as xml, its value is "start".</para>
        ///</summary>
        [EnumString("start")]
        Start,
        ///<summary>
        ///end.
        ///<para>When the item is serialized out as xml, its value is "end".</para>
        ///</summary>
        [EnumString("end")]
        End,
    }

    /// <summary>
    /// Defines the DisjunctionTypeValues enumeration.
    /// </summary>
    public enum DisjunctionTypeValues
    {
        ///<summary>
        ///recognition.
        ///<para>When the item is serialized out as xml, its value is "recognition".</para>
        ///</summary>
        [EnumString("recognition")]
        Recognition,
        ///<summary>
        ///understanding.
        ///<para>When the item is serialized out as xml, its value is "understanding".</para>
        ///</summary>
        [EnumString("understanding")]
        Understanding,
        ///<summary>
        ///multi-device.
        ///<para>When the item is serialized out as xml, its value is "multi-device".</para>
        ///</summary>
        [EnumString("multi-device")]
        Multidevice,
        ///<summary>
        ///multi-process.
        ///<para>When the item is serialized out as xml, its value is "multi-process".</para>
        ///</summary>
        [EnumString("multi-process")]
        Multiprocess,
    }
}