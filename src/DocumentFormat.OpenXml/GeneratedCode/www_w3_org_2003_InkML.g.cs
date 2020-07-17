// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.InkML
{
    /// <summary>
    /// <para>Defines the Ink Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:ink.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Annotation &lt;inkml:annotation></description></item>
    ///   <item><description>AnnotationXml &lt;inkml:annotationXML></description></item>
    ///   <item><description>Definitions &lt;inkml:definitions></description></item>
    ///   <item><description>Context &lt;inkml:context></description></item>
    ///   <item><description>Trace &lt;inkml:trace></description></item>
    ///   <item><description>TraceGroup &lt;inkml:traceGroup></description></item>
    ///   <item><description>TraceView &lt;inkml:traceView></description></item>
    /// </list>
    /// </remark>
    public partial class Ink : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Ink class.
        /// </summary>
        public Ink() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Ink class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Ink(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Ink class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Ink(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Ink class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Ink(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>documentID</para>
        /// <para>Represents the following attribute in the schema: documentID</para>
        /// </summary>
        public StringValue DocumentId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "ink");
            builder.AddChild<Annotation>();
            builder.AddChild<AnnotationXml>();
            builder.AddChild<Definitions>();
            builder.AddChild<Context>();
            builder.AddChild<Trace>();
            builder.AddChild<TraceGroup>();
            builder.AddChild<TraceView>();
            builder.AddElement<Ink>()
.AddAttribute(0, "documentID", a => a.DocumentId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Annotation), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.AnnotationXml), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Definitions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Context), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Trace), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceGroup), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceView), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Ink>(deep);
    }

    /// <summary>
    /// <para>Defines the Bind Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:bind.</para>
    /// </summary>
    public partial class Bind : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Bind class.
        /// </summary>
        public Bind() : base()
        {
        }

        /// <summary>
        /// <para>source</para>
        /// <para>Represents the following attribute in the schema: source</para>
        /// </summary>
        public StringValue Source
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
        /// <para>column</para>
        /// <para>Represents the following attribute in the schema: column</para>
        /// </summary>
        public StringValue Column
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>variable</para>
        /// <para>Represents the following attribute in the schema: variable</para>
        /// </summary>
        public StringValue Variable
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "bind");
            builder.AddElement<Bind>()
.AddAttribute(0, "source", a => a.Source)
.AddAttribute(0, "target", a => a.Target)
.AddAttribute(0, "column", a => a.Column)
.AddAttribute(0, "variable", a => a.Variable);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bind>(deep);
    }

    /// <summary>
    /// <para>Defines the Table Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:table.</para>
    /// </summary>
    public partial class Table : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        public Table() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Table class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Table(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>apply</para>
        /// <para>Represents the following attribute in the schema: apply</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.InkML.TableApplyValues> Apply
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.InkML.TableApplyValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>interpolation</para>
        /// <para>Represents the following attribute in the schema: interpolation</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.InkML.TableInterpolationValues> Interpolation
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.InkML.TableInterpolationValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "table");
            builder.AddElement<Table>()
.AddAttribute(1, "id", a => a.Id)
.AddAttribute(0, "apply", a => a.Apply)
.AddAttribute(0, "interpolation", a => a.Interpolation);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Table>(deep);
    }

    /// <summary>
    /// <para>Defines the Matrix Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:matrix.</para>
    /// </summary>
    public partial class Matrix : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Matrix class.
        /// </summary>
        public Matrix() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Matrix class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Matrix(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "matrix");
            builder.AddElement<Matrix>()
.AddAttribute(1, "id", a => a.Id);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Matrix>(deep);
    }

    /// <summary>
    /// <para>Defines the Mapping Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:mapping.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Bind &lt;inkml:bind></description></item>
    ///   <item><description>Table &lt;inkml:table></description></item>
    ///   <item><description>Matrix &lt;inkml:matrix></description></item>
    ///   <item><description>Mapping &lt;inkml:mapping></description></item>
    /// </list>
    /// </remark>
    public partial class Mapping : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Mapping class.
        /// </summary>
        public Mapping() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Mapping class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Mapping(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Mapping class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Mapping(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Mapping class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Mapping(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.InkML.MappingTypeValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.InkML.MappingTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mappingRef</para>
        /// <para>Represents the following attribute in the schema: mappingRef</para>
        /// </summary>
        public StringValue MappingRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "mapping");
            builder.AddChild<Bind>();
            builder.AddChild<Table>();
            builder.AddChild<Matrix>();
            builder.AddChild<Mapping>();
            builder.AddElement<Mapping>()
.AddAttribute(1, "id", a => a.Id)
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "mappingRef", a => a.MappingRef, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Bind), 0, 0),
                    new CompositeParticle(ParticleType.Choice, 0, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Table), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Matrix), 1, 1)
                    }
                },
                new CompositeParticle(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Mapping), 0, 0)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Mapping>(deep);
    }

    /// <summary>
    /// <para>Defines the Channel Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:channel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Mapping &lt;inkml:mapping></description></item>
    /// </list>
    /// </remark>
    public partial class Channel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Channel class.
        /// </summary>
        public Channel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Channel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Channel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Channel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Channel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Channel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Channel(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
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
        /// <para>type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.InkML.ChannelDataTypeValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.InkML.ChannelDataTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>default</para>
        /// <para>Represents the following attribute in the schema: default</para>
        /// </summary>
        public StringValue Default
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>min</para>
        /// <para>Represents the following attribute in the schema: min</para>
        /// </summary>
        public DecimalValue Min
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>max</para>
        /// <para>Represents the following attribute in the schema: max</para>
        /// </summary>
        public DecimalValue Max
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>orientation</para>
        /// <para>Represents the following attribute in the schema: orientation</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.InkML.ChannelValueOrientationValues> Orientation
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.InkML.ChannelValueOrientationValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>respectTo</para>
        /// <para>Represents the following attribute in the schema: respectTo</para>
        /// </summary>
        public StringValue RespectTo
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>units</para>
        /// <para>Represents the following attribute in the schema: units</para>
        /// </summary>
        public StringValue Units
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "channel");
            builder.AddChild<Mapping>();
            builder.AddElement<Channel>()
.AddAttribute(1, "id", a => a.Id)
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardChannelNameValues>>(EnumValidator.Instance);
union.AddValidator(StringValidator.Instance);
});
})
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "default", a => a.Default, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<DecimalValue>(NumberValidator.Instance);
union.AddValidator<BooleanValue>(NumberValidator.Instance);
});
})
.AddAttribute(0, "min", a => a.Min)
.AddAttribute(0, "max", a => a.Max)
.AddAttribute(0, "orientation", a => a.Orientation)
.AddAttribute(0, "respectTo", a => a.RespectTo, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "units", a => a.Units, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardLengthUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerLengthUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardTimeUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerTimeUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardMassForceUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerMassForceUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardAngleUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerAngleUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardOtherUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerOtherUnitsValues>>(EnumValidator.Instance);
union.AddValidator(StringValidator.Instance);
});
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Mapping), 0, 0)
            };
            builder.AddConstraint(new AttributeValueSetConstraint(8 /*:units*/, true, new string[] { "dev", "in", "cm", "deg", "rad", "s", "lb", "g" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Channel>(deep);
    }

    /// <summary>
    /// <para>Defines the IntermittentChannels Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:intermittentChannels.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Channel &lt;inkml:channel></description></item>
    /// </list>
    /// </remark>
    public partial class IntermittentChannels : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the IntermittentChannels class.
        /// </summary>
        public IntermittentChannels() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the IntermittentChannels class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public IntermittentChannels(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the IntermittentChannels class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public IntermittentChannels(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the IntermittentChannels class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public IntermittentChannels(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "intermittentChannels");
            builder.AddChild<Channel>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Channel), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IntermittentChannels>(deep);
    }

    /// <summary>
    /// <para>Defines the ChannelProperty Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:channelProperty.</para>
    /// </summary>
    public partial class ChannelProperty : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ChannelProperty class.
        /// </summary>
        public ChannelProperty() : base()
        {
        }

        /// <summary>
        /// <para>channel</para>
        /// <para>Represents the following attribute in the schema: channel</para>
        /// </summary>
        public StringValue Channel
        {
            get => GetAttribute<StringValue>();
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
        /// <para>value</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        public DecimalValue Value
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>units</para>
        /// <para>Represents the following attribute in the schema: units</para>
        /// </summary>
        public StringValue Units
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "channelProperty");
            builder.AddElement<ChannelProperty>()
.AddAttribute(0, "channel", a => a.Channel, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardChannelNameValues>>(EnumValidator.Instance);
union.AddValidator(StringValidator.Instance);
});
})
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardChannelPropertyNameValues>>(EnumValidator.Instance);
union.AddValidator(StringValidator.Instance);
});
})
.AddAttribute(0, "value", a => a.Value, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "units", a => a.Units, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardLengthUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerLengthUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardTimeUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerTimeUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardMassForceUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerMassForceUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardAngleUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerAngleUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardOtherUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerOtherUnitsValues>>(EnumValidator.Instance);
union.AddValidator(StringValidator.Instance);
});
});
            builder.AddConstraint(new AttributeValueSetConstraint(3 /*:units*/, true, new string[] { "dev", "in", "cm", "deg", "rad", "s", "lb", "g" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChannelProperty>(deep);
    }

    /// <summary>
    /// <para>Defines the TraceFormat Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:traceFormat.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Channel &lt;inkml:channel></description></item>
    ///   <item><description>IntermittentChannels &lt;inkml:intermittentChannels></description></item>
    /// </list>
    /// </remark>
    public partial class TraceFormat : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TraceFormat class.
        /// </summary>
        public TraceFormat() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceFormat class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TraceFormat(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceFormat class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TraceFormat(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceFormat class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TraceFormat(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "traceFormat");
            builder.AddChild<Channel>();
            builder.AddChild<IntermittentChannels>();
            builder.AddElement<TraceFormat>()
.AddAttribute(1, "id", a => a.Id);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Channel), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.IntermittentChannels), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TraceFormat>(deep);
    }

    /// <summary>
    /// <para>Defines the SampleRate Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:sampleRate.</para>
    /// </summary>
    public partial class SampleRate : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SampleRate class.
        /// </summary>
        public SampleRate() : base()
        {
        }

        /// <summary>
        /// <para>uniform</para>
        /// <para>Represents the following attribute in the schema: uniform</para>
        /// </summary>
        public BooleanValue Uniform
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>value</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        public DecimalValue Value
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "sampleRate");
            builder.AddElement<SampleRate>()
.AddAttribute(0, "uniform", a => a.Uniform)
.AddAttribute(0, "value", a => a.Value, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SampleRate>(deep);
    }

    /// <summary>
    /// <para>Defines the Latency Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:latency.</para>
    /// </summary>
    public partial class Latency : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Latency class.
        /// </summary>
        public Latency() : base()
        {
        }

        /// <summary>
        /// <para>value</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        public DecimalValue Value
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "latency");
            builder.AddElement<Latency>()
.AddAttribute(0, "value", a => a.Value, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Latency>(deep);
    }

    /// <summary>
    /// <para>Defines the ActiveArea Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:activeArea.</para>
    /// </summary>
    public partial class ActiveArea : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ActiveArea class.
        /// </summary>
        public ActiveArea() : base()
        {
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        public StringValue Size
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>height</para>
        /// <para>Represents the following attribute in the schema: height</para>
        /// </summary>
        public DecimalValue Height
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>width</para>
        /// <para>Represents the following attribute in the schema: width</para>
        /// </summary>
        public DecimalValue Width
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>units</para>
        /// <para>Represents the following attribute in the schema: units</para>
        /// </summary>
        public StringValue Units
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "activeArea");
            builder.AddElement<ActiveArea>()
.AddAttribute(0, "size", a => a.Size)
.AddAttribute(0, "height", a => a.Height)
.AddAttribute(0, "width", a => a.Width)
.AddAttribute(0, "units", a => a.Units, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardLengthUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerLengthUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardTimeUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerTimeUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardMassForceUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerMassForceUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardAngleUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerAngleUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardOtherUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerOtherUnitsValues>>(EnumValidator.Instance);
union.AddValidator(StringValidator.Instance);
});
});
            builder.AddConstraint(new AttributeValueSetConstraint(3 /*:units*/, true, new string[] { "dev", "in", "cm", "deg", "rad", "s", "lb", "g" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ActiveArea>(deep);
    }

    /// <summary>
    /// <para>Defines the SourceProperty Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:srcProperty.</para>
    /// </summary>
    public partial class SourceProperty : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SourceProperty class.
        /// </summary>
        public SourceProperty() : base()
        {
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
        /// <para>value</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        public DecimalValue Value
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>units</para>
        /// <para>Represents the following attribute in the schema: units</para>
        /// </summary>
        public StringValue Units
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "srcProperty");
            builder.AddElement<SourceProperty>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "value", a => a.Value, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "units", a => a.Units, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardLengthUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerLengthUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardTimeUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerTimeUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardMassForceUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerMassForceUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardAngleUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerAngleUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardOtherUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerOtherUnitsValues>>(EnumValidator.Instance);
union.AddValidator(StringValidator.Instance);
});
});
            builder.AddConstraint(new AttributeValueSetConstraint(2 /*:units*/, true, new string[] { "dev", "in", "cm", "deg", "rad", "s", "lb", "g" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SourceProperty>(deep);
    }

    /// <summary>
    /// <para>Defines the ChannelProperties Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:channelProperties.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ChannelProperty &lt;inkml:channelProperty></description></item>
    /// </list>
    /// </remark>
    public partial class ChannelProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ChannelProperties class.
        /// </summary>
        public ChannelProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChannelProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChannelProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChannelProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChannelProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChannelProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChannelProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "channelProperties");
            builder.AddChild<ChannelProperty>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.ChannelProperty), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChannelProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the Annotation Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:annotation.</para>
    /// </summary>
    public partial class Annotation : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Annotation class.
        /// </summary>
        public Annotation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Annotation class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Annotation(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public StringValue Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>encoding</para>
        /// <para>Represents the following attribute in the schema: encoding</para>
        /// </summary>
        public StringValue Encoding
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "annotation");
            builder.AddElement<Annotation>()
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "encoding", a => a.Encoding);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Annotation>(deep);
    }

    /// <summary>
    /// <para>Defines the AnnotationXml Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:annotationXML.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.EMMA.Emma &lt;emma:emma></description></item>
    /// </list>
    /// </remark>
    public partial class AnnotationXml : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AnnotationXml class.
        /// </summary>
        public AnnotationXml() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnnotationXml class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnnotationXml(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnnotationXml class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnnotationXml(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnnotationXml class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AnnotationXml(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public StringValue Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>encoding</para>
        /// <para>Represents the following attribute in the schema: encoding</para>
        /// </summary>
        public StringValue Encoding
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "annotationXML");
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Emma>();
            builder.AddElement<AnnotationXml>()
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "encoding", a => a.Encoding)
.AddAttribute(0, "href", a => a.Href, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Emma), 0, 1)
            };
        }

        /// <summary>
        /// <para>Emma.</para>
        /// <para>Represents the following element tag in the schema: emma:emma.</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma = http://www.w3.org/2003/04/emma
        /// </remark>
        public DocumentFormat.OpenXml.EMMA.Emma Emma
        {
            get => GetElement<DocumentFormat.OpenXml.EMMA.Emma>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnnotationXml>(deep);
    }

    /// <summary>
    /// <para>Defines the BrushProperty Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:brushProperty.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Annotation &lt;inkml:annotation></description></item>
    ///   <item><description>AnnotationXml &lt;inkml:annotationXML></description></item>
    /// </list>
    /// </remark>
    public partial class BrushProperty : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BrushProperty class.
        /// </summary>
        public BrushProperty() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BrushProperty class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BrushProperty(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BrushProperty class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BrushProperty(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BrushProperty class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BrushProperty(string outerXml) : base(outerXml)
        {
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
        /// <para>value</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        public StringValue Value
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>units</para>
        /// <para>Represents the following attribute in the schema: units</para>
        /// </summary>
        public StringValue Units
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "brushProperty");
            builder.AddChild<Annotation>();
            builder.AddChild<AnnotationXml>();
            builder.AddElement<BrushProperty>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardBrushPropertyNameValues>>(EnumValidator.Instance);
union.AddValidator(StringValidator.Instance);
});
})
.AddAttribute(0, "value", a => a.Value, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<DecimalValue>(NumberValidator.Instance);
union.AddValidator<BooleanValue>(NumberValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.PenTipShapeValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.RasterOperationValues>>(EnumValidator.Instance);
union.AddValidator(StringValidator.Instance);
});
})
.AddAttribute(0, "units", a => a.Units, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardLengthUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerLengthUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardTimeUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerTimeUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardMassForceUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerMassForceUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardAngleUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerAngleUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardOtherUnitsValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerOtherUnitsValues>>(EnumValidator.Instance);
union.AddValidator(StringValidator.Instance);
});
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Annotation), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.AnnotationXml), 0, 0)
            };
            builder.AddConstraint(new AttributeValueSetConstraint(2 /*:units*/, true, new string[] { "dev", "in", "cm", "deg", "rad", "s", "lb", "g" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BrushProperty>(deep);
    }

    /// <summary>
    /// <para>Defines the Canvas Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:canvas.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TraceFormat &lt;inkml:traceFormat></description></item>
    /// </list>
    /// </remark>
    public partial class Canvas : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Canvas class.
        /// </summary>
        public Canvas() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Canvas class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Canvas(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Canvas class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Canvas(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Canvas class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Canvas(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>traceFormatRef</para>
        /// <para>Represents the following attribute in the schema: traceFormatRef</para>
        /// </summary>
        public StringValue TraceFormatRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "canvas");
            builder.AddChild<TraceFormat>();
            builder.AddElement<Canvas>()
.AddAttribute(1, "id", a => a.Id)
.AddAttribute(0, "traceFormatRef", a => a.TraceFormatRef, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceFormat), 0, 1)
            };
        }

        /// <summary>
        /// <para>TraceFormat.</para>
        /// <para>Represents the following element tag in the schema: inkml:traceFormat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public TraceFormat TraceFormat
        {
            get => GetElement<TraceFormat>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Canvas>(deep);
    }

    /// <summary>
    /// <para>Defines the CanvasTransform Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:canvasTransform.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Mapping &lt;inkml:mapping></description></item>
    /// </list>
    /// </remark>
    public partial class CanvasTransform : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CanvasTransform class.
        /// </summary>
        public CanvasTransform() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CanvasTransform class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CanvasTransform(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CanvasTransform class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CanvasTransform(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CanvasTransform class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CanvasTransform(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invertible</para>
        /// <para>Represents the following attribute in the schema: invertible</para>
        /// </summary>
        public BooleanValue Invertible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "canvasTransform");
            builder.AddChild<Mapping>();
            builder.AddElement<CanvasTransform>()
.AddAttribute(1, "id", a => a.Id)
.AddAttribute(0, "invertible", a => a.Invertible);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Mapping), 1, 2)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CanvasTransform>(deep);
    }

    /// <summary>
    /// <para>Defines the InkSource Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:inkSource.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>TraceFormat &lt;inkml:traceFormat></description></item>
    ///   <item><description>SampleRate &lt;inkml:sampleRate></description></item>
    ///   <item><description>Latency &lt;inkml:latency></description></item>
    ///   <item><description>ActiveArea &lt;inkml:activeArea></description></item>
    ///   <item><description>SourceProperty &lt;inkml:srcProperty></description></item>
    ///   <item><description>ChannelProperties &lt;inkml:channelProperties></description></item>
    /// </list>
    /// </remark>
    public partial class InkSource : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the InkSource class.
        /// </summary>
        public InkSource() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the InkSource class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public InkSource(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the InkSource class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public InkSource(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the InkSource class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public InkSource(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>manufacturer</para>
        /// <para>Represents the following attribute in the schema: manufacturer</para>
        /// </summary>
        public StringValue Manufacturer
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>model</para>
        /// <para>Represents the following attribute in the schema: model</para>
        /// </summary>
        public StringValue Model
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>serialNo</para>
        /// <para>Represents the following attribute in the schema: serialNo</para>
        /// </summary>
        public StringValue SerialNo
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>specificationRef</para>
        /// <para>Represents the following attribute in the schema: specificationRef</para>
        /// </summary>
        public StringValue SpecificationRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        public StringValue Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "inkSource");
            builder.AddChild<TraceFormat>();
            builder.AddChild<SampleRate>();
            builder.AddChild<Latency>();
            builder.AddChild<ActiveArea>();
            builder.AddChild<SourceProperty>();
            builder.AddChild<ChannelProperties>();
            builder.AddElement<InkSource>()
.AddAttribute(1, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "manufacturer", a => a.Manufacturer)
.AddAttribute(0, "model", a => a.Model)
.AddAttribute(0, "serialNo", a => a.SerialNo)
.AddAttribute(0, "specificationRef", a => a.SpecificationRef, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "description", a => a.Description);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceFormat), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.SampleRate), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Latency), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.ActiveArea), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.SourceProperty), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.ChannelProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>TraceFormat.</para>
        /// <para>Represents the following element tag in the schema: inkml:traceFormat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public TraceFormat TraceFormat
        {
            get => GetElement<TraceFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SampleRate.</para>
        /// <para>Represents the following element tag in the schema: inkml:sampleRate.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public SampleRate SampleRate
        {
            get => GetElement<SampleRate>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Latency.</para>
        /// <para>Represents the following element tag in the schema: inkml:latency.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public Latency Latency
        {
            get => GetElement<Latency>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ActiveArea.</para>
        /// <para>Represents the following element tag in the schema: inkml:activeArea.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public ActiveArea ActiveArea
        {
            get => GetElement<ActiveArea>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InkSource>(deep);
    }

    /// <summary>
    /// <para>Defines the Brush Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:brush.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Annotation &lt;inkml:annotation></description></item>
    ///   <item><description>AnnotationXml &lt;inkml:annotationXML></description></item>
    ///   <item><description>BrushProperty &lt;inkml:brushProperty></description></item>
    /// </list>
    /// </remark>
    public partial class Brush : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Brush class.
        /// </summary>
        public Brush() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Brush class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Brush(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Brush class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Brush(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Brush class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Brush(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>brushRef</para>
        /// <para>Represents the following attribute in the schema: brushRef</para>
        /// </summary>
        public StringValue BrushRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "brush");
            builder.AddChild<Annotation>();
            builder.AddChild<AnnotationXml>();
            builder.AddChild<BrushProperty>();
            builder.AddElement<Brush>()
.AddAttribute(1, "id", a => a.Id)
.AddAttribute(0, "brushRef", a => a.BrushRef, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Annotation), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.AnnotationXml), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.BrushProperty), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Brush>(deep);
    }

    /// <summary>
    /// <para>Defines the Timestamp Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:timestamp.</para>
    /// </summary>
    public partial class Timestamp : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Timestamp class.
        /// </summary>
        public Timestamp() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time</para>
        /// <para>Represents the following attribute in the schema: time</para>
        /// </summary>
        public DecimalValue Time
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>timestampRef</para>
        /// <para>Represents the following attribute in the schema: timestampRef</para>
        /// </summary>
        public StringValue TimestampRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>timeString</para>
        /// <para>Represents the following attribute in the schema: timeString</para>
        /// </summary>
        public DateTimeValue TimeString
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>timeOffset</para>
        /// <para>Represents the following attribute in the schema: timeOffset</para>
        /// </summary>
        public DecimalValue TimeOffset
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "timestamp");
            builder.AddElement<Timestamp>()
.AddAttribute(1, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "time", a => a.Time)
.AddAttribute(0, "timestampRef", a => a.TimestampRef, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "timeString", a => a.TimeString)
.AddAttribute(0, "timeOffset", a => a.TimeOffset);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Timestamp>(deep);
    }

    /// <summary>
    /// <para>Defines the Trace Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:trace.</para>
    /// </summary>
    public partial class Trace : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Trace class.
        /// </summary>
        public Trace() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Trace class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Trace(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.InkML.TraceTypeValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.InkML.TraceTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>continuation</para>
        /// <para>Represents the following attribute in the schema: continuation</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.InkML.TraceContinuationValues> Continuation
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.InkML.TraceContinuationValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>priorRef</para>
        /// <para>Represents the following attribute in the schema: priorRef</para>
        /// </summary>
        public StringValue PriorRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contextRef</para>
        /// <para>Represents the following attribute in the schema: contextRef</para>
        /// </summary>
        public StringValue ContextRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>brushRef</para>
        /// <para>Represents the following attribute in the schema: brushRef</para>
        /// </summary>
        public StringValue BrushRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>duration</para>
        /// <para>Represents the following attribute in the schema: duration</para>
        /// </summary>
        public DecimalValue Duration
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>timeOffset</para>
        /// <para>Represents the following attribute in the schema: timeOffset</para>
        /// </summary>
        public DecimalValue TimeOffset
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "trace");
            builder.AddElement<Trace>()
.AddAttribute(1, "id", a => a.Id)
.AddAttribute(0, "type", a => a.Type)
.AddAttribute(0, "continuation", a => a.Continuation)
.AddAttribute(0, "priorRef", a => a.PriorRef, aBuilder =>
{
 aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "contextRef", a => a.ContextRef, aBuilder =>
{
 aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "brushRef", a => a.BrushRef, aBuilder =>
{
 aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "duration", a => a.Duration)
.AddAttribute(0, "timeOffset", a => a.TimeOffset);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Trace>(deep);
    }

    /// <summary>
    /// <para>Defines the TraceGroup Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:traceGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Annotation &lt;inkml:annotation></description></item>
    ///   <item><description>AnnotationXml &lt;inkml:annotationXML></description></item>
    ///   <item><description>Trace &lt;inkml:trace></description></item>
    ///   <item><description>TraceGroup &lt;inkml:traceGroup></description></item>
    /// </list>
    /// </remark>
    public partial class TraceGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TraceGroup class.
        /// </summary>
        public TraceGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TraceGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TraceGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TraceGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contextRef</para>
        /// <para>Represents the following attribute in the schema: contextRef</para>
        /// </summary>
        public StringValue ContextRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>brushRef</para>
        /// <para>Represents the following attribute in the schema: brushRef</para>
        /// </summary>
        public StringValue BrushRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "traceGroup");
            builder.AddChild<Annotation>();
            builder.AddChild<AnnotationXml>();
            builder.AddChild<Trace>();
            builder.AddChild<TraceGroup>();
            builder.AddElement<TraceGroup>()
.AddAttribute(1, "id", a => a.Id)
.AddAttribute(0, "contextRef", a => a.ContextRef, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "brushRef", a => a.BrushRef, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Annotation), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.AnnotationXml), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Trace), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceGroup), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TraceGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the TraceView Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:traceView.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Annotation &lt;inkml:annotation></description></item>
    ///   <item><description>AnnotationXml &lt;inkml:annotationXML></description></item>
    ///   <item><description>TraceView &lt;inkml:traceView></description></item>
    /// </list>
    /// </remark>
    public partial class TraceView : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TraceView class.
        /// </summary>
        public TraceView() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceView class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TraceView(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceView class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TraceView(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceView class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TraceView(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contextRef</para>
        /// <para>Represents the following attribute in the schema: contextRef</para>
        /// </summary>
        public StringValue ContextRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>traceDataRef</para>
        /// <para>Represents the following attribute in the schema: traceDataRef</para>
        /// </summary>
        public StringValue TraceDataRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>from</para>
        /// <para>Represents the following attribute in the schema: from</para>
        /// </summary>
        public StringValue From
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>to</para>
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
            builder.SetSchema(43, "traceView");
            builder.AddChild<Annotation>();
            builder.AddChild<AnnotationXml>();
            builder.AddChild<TraceView>();
            builder.AddElement<TraceView>()
.AddAttribute(1, "id", a => a.Id)
.AddAttribute(0, "contextRef", a => a.ContextRef, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "traceDataRef", a => a.TraceDataRef, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "from", a => a.From)
.AddAttribute(0, "to", a => a.To);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Annotation), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.AnnotationXml), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceView), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TraceView>(deep);
    }

    /// <summary>
    /// <para>Defines the Context Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:context.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Canvas &lt;inkml:canvas></description></item>
    ///   <item><description>CanvasTransform &lt;inkml:canvasTransform></description></item>
    ///   <item><description>TraceFormat &lt;inkml:traceFormat></description></item>
    ///   <item><description>InkSource &lt;inkml:inkSource></description></item>
    ///   <item><description>Brush &lt;inkml:brush></description></item>
    ///   <item><description>Timestamp &lt;inkml:timestamp></description></item>
    /// </list>
    /// </remark>
    public partial class Context : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Context class.
        /// </summary>
        public Context() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Context class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Context(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Context class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Context(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Context class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Context(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contextRef</para>
        /// <para>Represents the following attribute in the schema: contextRef</para>
        /// </summary>
        public StringValue ContextRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>canvasRef</para>
        /// <para>Represents the following attribute in the schema: canvasRef</para>
        /// </summary>
        public StringValue CanvasRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>canvasTransformRef</para>
        /// <para>Represents the following attribute in the schema: canvasTransformRef</para>
        /// </summary>
        public StringValue CanvasTransformRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>traceFormatRef</para>
        /// <para>Represents the following attribute in the schema: traceFormatRef</para>
        /// </summary>
        public StringValue TraceFromatRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>inkSourceRef</para>
        /// <para>Represents the following attribute in the schema: inkSourceRef</para>
        /// </summary>
        public StringValue InkSourceRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>brushRef</para>
        /// <para>Represents the following attribute in the schema: brushRef</para>
        /// </summary>
        public StringValue BrushRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>timestampRef</para>
        /// <para>Represents the following attribute in the schema: timestampRef</para>
        /// </summary>
        public StringValue TimestampRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "context");
            builder.AddChild<Canvas>();
            builder.AddChild<CanvasTransform>();
            builder.AddChild<TraceFormat>();
            builder.AddChild<InkSource>();
            builder.AddChild<Brush>();
            builder.AddChild<Timestamp>();
            builder.AddElement<Context>()
.AddAttribute(1, "id", a => a.Id)
.AddAttribute(0, "contextRef", a => a.ContextRef, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "canvasRef", a => a.CanvasRef, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "canvasTransformRef", a => a.CanvasTransformRef, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "traceFormatRef", a => a.TraceFromatRef, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "inkSourceRef", a => a.InkSourceRef, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "brushRef", a => a.BrushRef, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "timestampRef", a => a.TimestampRef, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Canvas), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.CanvasTransform), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceFormat), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.InkSource), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Brush), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Timestamp), 0, 1)
            };
        }

        /// <summary>
        /// <para>Canvas.</para>
        /// <para>Represents the following element tag in the schema: inkml:canvas.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public Canvas Canvas
        {
            get => GetElement<Canvas>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CanvasTransform.</para>
        /// <para>Represents the following element tag in the schema: inkml:canvasTransform.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public CanvasTransform CanvasTransform
        {
            get => GetElement<CanvasTransform>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TraceFormat.</para>
        /// <para>Represents the following element tag in the schema: inkml:traceFormat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public TraceFormat TraceFormat
        {
            get => GetElement<TraceFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>InkSource.</para>
        /// <para>Represents the following element tag in the schema: inkml:inkSource.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public InkSource InkSource
        {
            get => GetElement<InkSource>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Brush.</para>
        /// <para>Represents the following element tag in the schema: inkml:brush.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public Brush Brush
        {
            get => GetElement<Brush>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Timestamp.</para>
        /// <para>Represents the following element tag in the schema: inkml:timestamp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public Timestamp Timestamp
        {
            get => GetElement<Timestamp>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Context>(deep);
    }

    /// <summary>
    /// <para>Defines the Definitions Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:definitions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Brush &lt;inkml:brush></description></item>
    ///   <item><description>Canvas &lt;inkml:canvas></description></item>
    ///   <item><description>CanvasTransform &lt;inkml:canvasTransform></description></item>
    ///   <item><description>Context &lt;inkml:context></description></item>
    ///   <item><description>InkSource &lt;inkml:inkSource></description></item>
    ///   <item><description>Mapping &lt;inkml:mapping></description></item>
    ///   <item><description>Timestamp &lt;inkml:timestamp></description></item>
    ///   <item><description>Trace &lt;inkml:trace></description></item>
    ///   <item><description>TraceFormat &lt;inkml:traceFormat></description></item>
    ///   <item><description>TraceGroup &lt;inkml:traceGroup></description></item>
    ///   <item><description>TraceView &lt;inkml:traceView></description></item>
    /// </list>
    /// </remark>
    public partial class Definitions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Definitions class.
        /// </summary>
        public Definitions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Definitions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Definitions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Definitions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Definitions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Definitions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Definitions(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(43, "definitions");
            builder.AddChild<Brush>();
            builder.AddChild<Canvas>();
            builder.AddChild<CanvasTransform>();
            builder.AddChild<Context>();
            builder.AddChild<InkSource>();
            builder.AddChild<Mapping>();
            builder.AddChild<Timestamp>();
            builder.AddChild<Trace>();
            builder.AddChild<TraceFormat>();
            builder.AddChild<TraceGroup>();
            builder.AddChild<TraceView>();
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Brush), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Canvas), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.CanvasTransform), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Context), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.InkSource), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Mapping), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Timestamp), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Trace), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceFormat), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceGroup), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceView), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Definitions>(deep);
    }

    /// <summary>
    /// Defines the ChannelDataTypeValues enumeration.
    /// </summary>
    public enum ChannelDataTypeValues
    {
        ///<summary>
        ///integer.
        ///<para>When the item is serialized out as xml, its value is "integer".</para>
        ///</summary>
        [EnumString("integer")]
        Integer,
        ///<summary>
        ///decimal.
        ///<para>When the item is serialized out as xml, its value is "decimal".</para>
        ///</summary>
        [EnumString("decimal")]
        Decimal,
        ///<summary>
        ///boolean.
        ///<para>When the item is serialized out as xml, its value is "boolean".</para>
        ///</summary>
        [EnumString("boolean")]
        Boolean,
    }

    /// <summary>
    /// Defines the ChannelValueOrientationValues enumeration.
    /// </summary>
    public enum ChannelValueOrientationValues
    {
        ///<summary>
        ///+ve.
        ///<para>When the item is serialized out as xml, its value is "+ve".</para>
        ///</summary>
        [EnumString("+ve")]
        PlusVe,
        ///<summary>
        ///-ve.
        ///<para>When the item is serialized out as xml, its value is "-ve".</para>
        ///</summary>
        [EnumString("-ve")]
        MinusVe,
    }

    /// <summary>
    /// Defines the StandardChannelPropertyNameValues enumeration.
    /// </summary>
    public enum StandardChannelPropertyNameValues
    {
        ///<summary>
        ///threshold.
        ///<para>When the item is serialized out as xml, its value is "threshold".</para>
        ///</summary>
        [EnumString("threshold")]
        Threshold,
        ///<summary>
        ///resolution.
        ///<para>When the item is serialized out as xml, its value is "resolution".</para>
        ///</summary>
        [EnumString("resolution")]
        Resolution,
        ///<summary>
        ///quantization.
        ///<para>When the item is serialized out as xml, its value is "quantization".</para>
        ///</summary>
        [EnumString("quantization")]
        Quantization,
        ///<summary>
        ///noise.
        ///<para>When the item is serialized out as xml, its value is "noise".</para>
        ///</summary>
        [EnumString("noise")]
        Noise,
        ///<summary>
        ///accuracy.
        ///<para>When the item is serialized out as xml, its value is "accuracy".</para>
        ///</summary>
        [EnumString("accuracy")]
        Accuracy,
        ///<summary>
        ///crossCoupling.
        ///<para>When the item is serialized out as xml, its value is "crossCoupling".</para>
        ///</summary>
        [EnumString("crossCoupling")]
        CrossCoupling,
        ///<summary>
        ///skew.
        ///<para>When the item is serialized out as xml, its value is "skew".</para>
        ///</summary>
        [EnumString("skew")]
        Skew,
        ///<summary>
        ///minBandwidth.
        ///<para>When the item is serialized out as xml, its value is "minBandwidth".</para>
        ///</summary>
        [EnumString("minBandwidth")]
        MinBandwidth,
        ///<summary>
        ///peakRate.
        ///<para>When the item is serialized out as xml, its value is "peakRate".</para>
        ///</summary>
        [EnumString("peakRate")]
        PeakRate,
        ///<summary>
        ///distortion.
        ///<para>When the item is serialized out as xml, its value is "distortion".</para>
        ///</summary>
        [EnumString("distortion")]
        Distortion,
    }

    /// <summary>
    /// Defines the StandardBrushPropertyNameValues enumeration.
    /// </summary>
    public enum StandardBrushPropertyNameValues
    {
        ///<summary>
        ///width.
        ///<para>When the item is serialized out as xml, its value is "width".</para>
        ///</summary>
        [EnumString("width")]
        Width,
        ///<summary>
        ///height.
        ///<para>When the item is serialized out as xml, its value is "height".</para>
        ///</summary>
        [EnumString("height")]
        Height,
        ///<summary>
        ///color.
        ///<para>When the item is serialized out as xml, its value is "color".</para>
        ///</summary>
        [EnumString("color")]
        Color,
        ///<summary>
        ///transparency.
        ///<para>When the item is serialized out as xml, its value is "transparency".</para>
        ///</summary>
        [EnumString("transparency")]
        Transparency,
        ///<summary>
        ///tip.
        ///<para>When the item is serialized out as xml, its value is "tip".</para>
        ///</summary>
        [EnumString("tip")]
        Tip,
        ///<summary>
        ///rasterOp.
        ///<para>When the item is serialized out as xml, its value is "rasterOp".</para>
        ///</summary>
        [EnumString("rasterOp")]
        RasterOp,
        ///<summary>
        ///antiAliased.
        ///<para>When the item is serialized out as xml, its value is "antiAliased".</para>
        ///</summary>
        [EnumString("antiAliased")]
        AntiAliased,
        ///<summary>
        ///fitToCurve.
        ///<para>When the item is serialized out as xml, its value is "fitToCurve".</para>
        ///</summary>
        [EnumString("fitToCurve")]
        FitToCurve,
        ///<summary>
        ///ignorePressure.
        ///<para>When the item is serialized out as xml, its value is "ignorePressure".</para>
        ///</summary>
        [EnumString("ignorePressure")]
        IgnorePressure,
    }

    /// <summary>
    /// Defines the StandardChannelNameValues enumeration.
    /// </summary>
    public enum StandardChannelNameValues
    {
        ///<summary>
        ///X.
        ///<para>When the item is serialized out as xml, its value is "X".</para>
        ///</summary>
        [EnumString("X")]
        XCoordinate,
        ///<summary>
        ///Y.
        ///<para>When the item is serialized out as xml, its value is "Y".</para>
        ///</summary>
        [EnumString("Y")]
        YCoordinate,
        ///<summary>
        ///Z.
        ///<para>When the item is serialized out as xml, its value is "Z".</para>
        ///</summary>
        [EnumString("Z")]
        ZCoordinate,
        ///<summary>
        ///F.
        ///<para>When the item is serialized out as xml, its value is "F".</para>
        ///</summary>
        [EnumString("F")]
        PenTipForce,
        ///<summary>
        ///TP.
        ///<para>When the item is serialized out as xml, its value is "TP".</para>
        ///</summary>
        [EnumString("TP")]
        TangentPressure,
        ///<summary>
        ///BP.
        ///<para>When the item is serialized out as xml, its value is "BP".</para>
        ///</summary>
        [EnumString("BP")]
        ButtonPressure,
        ///<summary>
        ///S.
        ///<para>When the item is serialized out as xml, its value is "S".</para>
        ///</summary>
        [EnumString("S")]
        TipSwitchState,
        ///<summary>
        ///B1.
        ///<para>When the item is serialized out as xml, its value is "B1".</para>
        ///</summary>
        [EnumString("B1")]
        SideButton1State,
        ///<summary>
        ///B2.
        ///<para>When the item is serialized out as xml, its value is "B2".</para>
        ///</summary>
        [EnumString("B2")]
        SideButton2State,
        ///<summary>
        ///B3.
        ///<para>When the item is serialized out as xml, its value is "B3".</para>
        ///</summary>
        [EnumString("B3")]
        SideButton3State,
        ///<summary>
        ///B4.
        ///<para>When the item is serialized out as xml, its value is "B4".</para>
        ///</summary>
        [EnumString("B4")]
        SideButton4State,
        ///<summary>
        ///E.
        ///<para>When the item is serialized out as xml, its value is "E".</para>
        ///</summary>
        [EnumString("E")]
        PenInverted,
        ///<summary>
        ///OTx.
        ///<para>When the item is serialized out as xml, its value is "OTx".</para>
        ///</summary>
        [EnumString("OTx")]
        TiltAlongXAxis,
        ///<summary>
        ///OTy.
        ///<para>When the item is serialized out as xml, its value is "OTy".</para>
        ///</summary>
        [EnumString("OTy")]
        TiltAlongYAxis,
        ///<summary>
        ///OA.
        ///<para>When the item is serialized out as xml, its value is "OA".</para>
        ///</summary>
        [EnumString("OA")]
        PenAzimuthAngle,
        ///<summary>
        ///OE.
        ///<para>When the item is serialized out as xml, its value is "OE".</para>
        ///</summary>
        [EnumString("OE")]
        PenElevationAngle,
        ///<summary>
        ///OR.
        ///<para>When the item is serialized out as xml, its value is "OR".</para>
        ///</summary>
        [EnumString("OR")]
        PexAxisRotation,
        ///<summary>
        ///RP.
        ///<para>When the item is serialized out as xml, its value is "RP".</para>
        ///</summary>
        [EnumString("RP")]
        PitchRotation,
        ///<summary>
        ///RR.
        ///<para>When the item is serialized out as xml, its value is "RR".</para>
        ///</summary>
        [EnumString("RR")]
        RollRotation,
        ///<summary>
        ///RY.
        ///<para>When the item is serialized out as xml, its value is "RY".</para>
        ///</summary>
        [EnumString("RY")]
        YawRotation,
        ///<summary>
        ///C.
        ///<para>When the item is serialized out as xml, its value is "C".</para>
        ///</summary>
        [EnumString("C")]
        ColorValue,
        ///<summary>
        ///CR.
        ///<para>When the item is serialized out as xml, its value is "CR".</para>
        ///</summary>
        [EnumString("CR")]
        RedColorValue,
        ///<summary>
        ///CG.
        ///<para>When the item is serialized out as xml, its value is "CG".</para>
        ///</summary>
        [EnumString("CG")]
        GreenColorValue,
        ///<summary>
        ///CB.
        ///<para>When the item is serialized out as xml, its value is "CB".</para>
        ///</summary>
        [EnumString("CB")]
        BlueColorValue,
        ///<summary>
        ///CC.
        ///<para>When the item is serialized out as xml, its value is "CC".</para>
        ///</summary>
        [EnumString("CC")]
        CyanColorValue,
        ///<summary>
        ///CM.
        ///<para>When the item is serialized out as xml, its value is "CM".</para>
        ///</summary>
        [EnumString("CM")]
        MegentaColorValue,
        ///<summary>
        ///CY.
        ///<para>When the item is serialized out as xml, its value is "CY".</para>
        ///</summary>
        [EnumString("CY")]
        YellowColorValue,
        ///<summary>
        ///CK.
        ///<para>When the item is serialized out as xml, its value is "CK".</para>
        ///</summary>
        [EnumString("CK")]
        BlackColorValue,
        ///<summary>
        ///W.
        ///<para>When the item is serialized out as xml, its value is "W".</para>
        ///</summary>
        [EnumString("W")]
        StrokesWidth,
        ///<summary>
        ///T.
        ///<para>When the item is serialized out as xml, its value is "T".</para>
        ///</summary>
        [EnumString("T")]
        Time,
        ///<summary>
        ///SN.
        ///<para>When the item is serialized out as xml, its value is "SN".</para>
        ///</summary>
        [EnumString("SN")]
        SerialNumber,
        ///<summary>
        ///TW.
        ///<para>When the item is serialized out as xml, its value is "TW".</para>
        ///</summary>
        [EnumString("TW")]
        TouchWidth,
        ///<summary>
        ///TH.
        ///<para>When the item is serialized out as xml, its value is "TH".</para>
        ///</summary>
        [EnumString("TH")]
        TouchHeight,
        ///<summary>
        ///TC.
        ///<para>When the item is serialized out as xml, its value is "TC".</para>
        ///</summary>
        [EnumString("TC")]
        FingerTouch,
    }

    /// <summary>
    /// Defines the StandardLengthUnitsValues enumeration.
    /// </summary>
    public enum StandardLengthUnitsValues
    {
        ///<summary>
        ///m.
        ///<para>When the item is serialized out as xml, its value is "m".</para>
        ///</summary>
        [EnumString("m")]
        Meter,
        ///<summary>
        ///cm.
        ///<para>When the item is serialized out as xml, its value is "cm".</para>
        ///</summary>
        [EnumString("cm")]
        Centimeter,
        ///<summary>
        ///mm.
        ///<para>When the item is serialized out as xml, its value is "mm".</para>
        ///</summary>
        [EnumString("mm")]
        Millimeter,
        ///<summary>
        ///in.
        ///<para>When the item is serialized out as xml, its value is "in".</para>
        ///</summary>
        [EnumString("in")]
        Inche,
        ///<summary>
        ///pt.
        ///<para>When the item is serialized out as xml, its value is "pt".</para>
        ///</summary>
        [EnumString("pt")]
        Point,
        ///<summary>
        ///pc.
        ///<para>When the item is serialized out as xml, its value is "pc".</para>
        ///</summary>
        [EnumString("pc")]
        Pica,
        ///<summary>
        ///em.
        ///<para>When the item is serialized out as xml, its value is "em".</para>
        ///</summary>
        [EnumString("em")]
        Em,
        ///<summary>
        ///ex.
        ///<para>When the item is serialized out as xml, its value is "ex".</para>
        ///</summary>
        [EnumString("ex")]
        Ex,
    }

    /// <summary>
    /// Defines the StandardPerLengthUnitsValues enumeration.
    /// </summary>
    public enum StandardPerLengthUnitsValues
    {
        ///<summary>
        ///1/m.
        ///<para>When the item is serialized out as xml, its value is "1/m".</para>
        ///</summary>
        [EnumString("1/m")]
        PerMeter,
        ///<summary>
        ///1/cm.
        ///<para>When the item is serialized out as xml, its value is "1/cm".</para>
        ///</summary>
        [EnumString("1/cm")]
        PerCentimeter,
        ///<summary>
        ///1/mm.
        ///<para>When the item is serialized out as xml, its value is "1/mm".</para>
        ///</summary>
        [EnumString("1/mm")]
        PerMillimeter,
        ///<summary>
        ///1/in.
        ///<para>When the item is serialized out as xml, its value is "1/in".</para>
        ///</summary>
        [EnumString("1/in")]
        PerInche,
        ///<summary>
        ///1/pt.
        ///<para>When the item is serialized out as xml, its value is "1/pt".</para>
        ///</summary>
        [EnumString("1/pt")]
        PerPoint,
        ///<summary>
        ///1/pc.
        ///<para>When the item is serialized out as xml, its value is "1/pc".</para>
        ///</summary>
        [EnumString("1/pc")]
        PerPica,
        ///<summary>
        ///1/em.
        ///<para>When the item is serialized out as xml, its value is "1/em".</para>
        ///</summary>
        [EnumString("1/em")]
        PerEm,
        ///<summary>
        ///1/ex.
        ///<para>When the item is serialized out as xml, its value is "1/ex".</para>
        ///</summary>
        [EnumString("1/ex")]
        PerEx,
    }

    /// <summary>
    /// Defines the StandardTimeUnitsValues enumeration.
    /// </summary>
    public enum StandardTimeUnitsValues
    {
        ///<summary>
        ///s.
        ///<para>When the item is serialized out as xml, its value is "s".</para>
        ///</summary>
        [EnumString("s")]
        Second,
        ///<summary>
        ///ms.
        ///<para>When the item is serialized out as xml, its value is "ms".</para>
        ///</summary>
        [EnumString("ms")]
        Millisecond,
    }

    /// <summary>
    /// Defines the StandardPerTimeUnitsValues enumeration.
    /// </summary>
    public enum StandardPerTimeUnitsValues
    {
        ///<summary>
        ///1/s.
        ///<para>When the item is serialized out as xml, its value is "1/s".</para>
        ///</summary>
        [EnumString("1/s")]
        PerSecond,
        ///<summary>
        ///1/ms.
        ///<para>When the item is serialized out as xml, its value is "1/ms".</para>
        ///</summary>
        [EnumString("1/ms")]
        PerMillisecond,
    }

    /// <summary>
    /// Defines the StandardMassForceUnitsValues enumeration.
    /// </summary>
    public enum StandardMassForceUnitsValues
    {
        ///<summary>
        ///Kg.
        ///<para>When the item is serialized out as xml, its value is "Kg".</para>
        ///</summary>
        [EnumString("Kg")]
        Kilogram,
        ///<summary>
        ///g.
        ///<para>When the item is serialized out as xml, its value is "g".</para>
        ///</summary>
        [EnumString("g")]
        Gram,
        ///<summary>
        ///mg.
        ///<para>When the item is serialized out as xml, its value is "mg".</para>
        ///</summary>
        [EnumString("mg")]
        Milligram,
        ///<summary>
        ///N.
        ///<para>When the item is serialized out as xml, its value is "N".</para>
        ///</summary>
        [EnumString("N")]
        Newton,
        ///<summary>
        ///lb.
        ///<para>When the item is serialized out as xml, its value is "lb".</para>
        ///</summary>
        [EnumString("lb")]
        Pond,
    }

    /// <summary>
    /// Defines the StandardPerMassForceUnitsValues enumeration.
    /// </summary>
    public enum StandardPerMassForceUnitsValues
    {
        ///<summary>
        ///1/Kg.
        ///<para>When the item is serialized out as xml, its value is "1/Kg".</para>
        ///</summary>
        [EnumString("1/Kg")]
        PerKilogram,
        ///<summary>
        ///1/g.
        ///<para>When the item is serialized out as xml, its value is "1/g".</para>
        ///</summary>
        [EnumString("1/g")]
        PerGram,
        ///<summary>
        ///1/mg.
        ///<para>When the item is serialized out as xml, its value is "1/mg".</para>
        ///</summary>
        [EnumString("1/mg")]
        PerMilligram,
        ///<summary>
        ///1/N.
        ///<para>When the item is serialized out as xml, its value is "1/N".</para>
        ///</summary>
        [EnumString("1/N")]
        PerNewton,
        ///<summary>
        ///1/lb.
        ///<para>When the item is serialized out as xml, its value is "1/lb".</para>
        ///</summary>
        [EnumString("1/lb")]
        PerPond,
    }

    /// <summary>
    /// Defines the StandardAngleUnitsValues enumeration.
    /// </summary>
    public enum StandardAngleUnitsValues
    {
        ///<summary>
        ///deg.
        ///<para>When the item is serialized out as xml, its value is "deg".</para>
        ///</summary>
        [EnumString("deg")]
        Degree,
        ///<summary>
        ///rad.
        ///<para>When the item is serialized out as xml, its value is "rad".</para>
        ///</summary>
        [EnumString("rad")]
        Radian,
    }

    /// <summary>
    /// Defines the StandardPerAngleUnitsValues enumeration.
    /// </summary>
    public enum StandardPerAngleUnitsValues
    {
        ///<summary>
        ///1/deg.
        ///<para>When the item is serialized out as xml, its value is "1/deg".</para>
        ///</summary>
        [EnumString("1/deg")]
        PerDegree,
        ///<summary>
        ///1/rad.
        ///<para>When the item is serialized out as xml, its value is "1/rad".</para>
        ///</summary>
        [EnumString("1/rad")]
        PerRadian,
    }

    /// <summary>
    /// Defines the StandardOtherUnitsValues enumeration.
    /// </summary>
    public enum StandardOtherUnitsValues
    {
        ///<summary>
        ///%.
        ///<para>When the item is serialized out as xml, its value is "%".</para>
        ///</summary>
        [EnumString("%")]
        Percentage,
        ///<summary>
        ///dev.
        ///<para>When the item is serialized out as xml, its value is "dev".</para>
        ///</summary>
        [EnumString("dev")]
        DeviceResolution,
        ///<summary>
        ///none.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
    }

    /// <summary>
    /// Defines the StandardPerOtherUnitsValues enumeration.
    /// </summary>
    public enum StandardPerOtherUnitsValues
    {
        ///<summary>
        ///1/%.
        ///<para>When the item is serialized out as xml, its value is "1/%".</para>
        ///</summary>
        [EnumString("1/%")]
        PerPercentage,
        ///<summary>
        ///1/dev.
        ///<para>When the item is serialized out as xml, its value is "1/dev".</para>
        ///</summary>
        [EnumString("1/dev")]
        PerDeviceResolution,
    }

    /// <summary>
    /// Defines the TraceTypeValues enumeration.
    /// </summary>
    public enum TraceTypeValues
    {
        ///<summary>
        ///penDown.
        ///<para>When the item is serialized out as xml, its value is "penDown".</para>
        ///</summary>
        [EnumString("penDown")]
        PenDown,
        ///<summary>
        ///penUp.
        ///<para>When the item is serialized out as xml, its value is "penUp".</para>
        ///</summary>
        [EnumString("penUp")]
        PenUp,
        ///<summary>
        ///indeterminate.
        ///<para>When the item is serialized out as xml, its value is "indeterminate".</para>
        ///</summary>
        [EnumString("indeterminate")]
        Indeterminate,
    }

    /// <summary>
    /// Defines the TraceContinuationValues enumeration.
    /// </summary>
    public enum TraceContinuationValues
    {
        ///<summary>
        ///begin.
        ///<para>When the item is serialized out as xml, its value is "begin".</para>
        ///</summary>
        [EnumString("begin")]
        Begin,
        ///<summary>
        ///end.
        ///<para>When the item is serialized out as xml, its value is "end".</para>
        ///</summary>
        [EnumString("end")]
        End,
        ///<summary>
        ///middle.
        ///<para>When the item is serialized out as xml, its value is "middle".</para>
        ///</summary>
        [EnumString("middle")]
        Middle,
    }

    /// <summary>
    /// Defines the RasterOperationValues enumeration.
    /// </summary>
    public enum RasterOperationValues
    {
        ///<summary>
        ///black.
        ///<para>When the item is serialized out as xml, its value is "black".</para>
        ///</summary>
        [EnumString("black")]
        Black,
        ///<summary>
        ///notMergePen.
        ///<para>When the item is serialized out as xml, its value is "notMergePen".</para>
        ///</summary>
        [EnumString("notMergePen")]
        NotMergePen,
        ///<summary>
        ///maskNotPen.
        ///<para>When the item is serialized out as xml, its value is "maskNotPen".</para>
        ///</summary>
        [EnumString("maskNotPen")]
        MaskNotPen,
        ///<summary>
        ///notCopyPen.
        ///<para>When the item is serialized out as xml, its value is "notCopyPen".</para>
        ///</summary>
        [EnumString("notCopyPen")]
        NotCopyPen,
        ///<summary>
        ///maskPenNot.
        ///<para>When the item is serialized out as xml, its value is "maskPenNot".</para>
        ///</summary>
        [EnumString("maskPenNot")]
        MaskPenNot,
        ///<summary>
        ///not.
        ///<para>When the item is serialized out as xml, its value is "not".</para>
        ///</summary>
        [EnumString("not")]
        Not,
        ///<summary>
        ///xOrPen.
        ///<para>When the item is serialized out as xml, its value is "xOrPen".</para>
        ///</summary>
        [EnumString("xOrPen")]
        XOrPen,
        ///<summary>
        ///notMaskPen.
        ///<para>When the item is serialized out as xml, its value is "notMaskPen".</para>
        ///</summary>
        [EnumString("notMaskPen")]
        NotMaskPen,
        ///<summary>
        ///maskPen.
        ///<para>When the item is serialized out as xml, its value is "maskPen".</para>
        ///</summary>
        [EnumString("maskPen")]
        MaskPen,
        ///<summary>
        ///notXOrPen.
        ///<para>When the item is serialized out as xml, its value is "notXOrPen".</para>
        ///</summary>
        [EnumString("notXOrPen")]
        NotXOrPen,
        ///<summary>
        ///noOperation.
        ///<para>When the item is serialized out as xml, its value is "noOperation".</para>
        ///</summary>
        [EnumString("noOperation")]
        NoOperation,
        ///<summary>
        ///mergeNotPen.
        ///<para>When the item is serialized out as xml, its value is "mergeNotPen".</para>
        ///</summary>
        [EnumString("mergeNotPen")]
        MergeNotPen,
        ///<summary>
        ///copyPen.
        ///<para>When the item is serialized out as xml, its value is "copyPen".</para>
        ///</summary>
        [EnumString("copyPen")]
        CopyPen,
        ///<summary>
        ///mergePenNot.
        ///<para>When the item is serialized out as xml, its value is "mergePenNot".</para>
        ///</summary>
        [EnumString("mergePenNot")]
        MergePenNot,
        ///<summary>
        ///mergePen.
        ///<para>When the item is serialized out as xml, its value is "mergePen".</para>
        ///</summary>
        [EnumString("mergePen")]
        MergePen,
        ///<summary>
        ///white.
        ///<para>When the item is serialized out as xml, its value is "white".</para>
        ///</summary>
        [EnumString("white")]
        White,
    }

    /// <summary>
    /// Defines the PenTipShapeValues enumeration.
    /// </summary>
    public enum PenTipShapeValues
    {
        ///<summary>
        ///ellipse.
        ///<para>When the item is serialized out as xml, its value is "ellipse".</para>
        ///</summary>
        [EnumString("ellipse")]
        Ellipse,
        ///<summary>
        ///rectangle.
        ///<para>When the item is serialized out as xml, its value is "rectangle".</para>
        ///</summary>
        [EnumString("rectangle")]
        Rectangle,
        ///<summary>
        ///drop.
        ///<para>When the item is serialized out as xml, its value is "drop".</para>
        ///</summary>
        [EnumString("drop")]
        Drop,
    }

    /// <summary>
    /// Defines the MappingTypeValues enumeration.
    /// </summary>
    public enum MappingTypeValues
    {
        ///<summary>
        ///identity.
        ///<para>When the item is serialized out as xml, its value is "identity".</para>
        ///</summary>
        [EnumString("identity")]
        Identity,
        ///<summary>
        ///lookup.
        ///<para>When the item is serialized out as xml, its value is "lookup".</para>
        ///</summary>
        [EnumString("lookup")]
        Lookup,
        ///<summary>
        ///affine.
        ///<para>When the item is serialized out as xml, its value is "affine".</para>
        ///</summary>
        [EnumString("affine")]
        Affine,
        ///<summary>
        ///mathml.
        ///<para>When the item is serialized out as xml, its value is "mathml".</para>
        ///</summary>
        [EnumString("mathml")]
        MathML,
        ///<summary>
        ///product.
        ///<para>When the item is serialized out as xml, its value is "product".</para>
        ///</summary>
        [EnumString("product")]
        Product,
        ///<summary>
        ///unknown.
        ///<para>When the item is serialized out as xml, its value is "unknown".</para>
        ///</summary>
        [EnumString("unknown")]
        Unknown,
    }

    /// <summary>
    /// Defines the TableApplyValues enumeration.
    /// </summary>
    public enum TableApplyValues
    {
        ///<summary>
        ///absolute.
        ///<para>When the item is serialized out as xml, its value is "absolute".</para>
        ///</summary>
        [EnumString("absolute")]
        Absolute,
        ///<summary>
        ///relative.
        ///<para>When the item is serialized out as xml, its value is "relative".</para>
        ///</summary>
        [EnumString("relative")]
        Relative,
    }

    /// <summary>
    /// Defines the TableInterpolationValues enumeration.
    /// </summary>
    public enum TableInterpolationValues
    {
        ///<summary>
        ///floor.
        ///<para>When the item is serialized out as xml, its value is "floor".</para>
        ///</summary>
        [EnumString("floor")]
        Floor,
        ///<summary>
        ///middle.
        ///<para>When the item is serialized out as xml, its value is "middle".</para>
        ///</summary>
        [EnumString("middle")]
        Middle,
        ///<summary>
        ///ceiling.
        ///<para>When the item is serialized out as xml, its value is "ceiling".</para>
        ///</summary>
        [EnumString("ceiling")]
        Ceiling,
        ///<summary>
        ///linear.
        ///<para>When the item is serialized out as xml, its value is "linear".</para>
        ///</summary>
        [EnumString("linear")]
        Linear,
        ///<summary>
        ///cubic.
        ///<para>When the item is serialized out as xml, its value is "cubic".</para>
        ///</summary>
        [EnumString("cubic")]
        Cubic,
    }
}