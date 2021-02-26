// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.AdditionalCharacteristics
{
    /// <summary>
    /// <para>Set of Additional Characteristics.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ac:additionalCharacteristics.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Characteristic &lt;ac:characteristic></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(8, "additionalCharacteristics")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AdditionalCharacteristicsInfo : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the AdditionalCharacteristicsInfo class.
        /// </summary>
        public AdditionalCharacteristicsInfo() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AdditionalCharacteristicsInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AdditionalCharacteristicsInfo(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AdditionalCharacteristicsInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AdditionalCharacteristicsInfo(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AdditionalCharacteristicsInfo class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AdditionalCharacteristicsInfo(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(8, "additionalCharacteristics");
            builder.AddChild<Characteristic>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.AdditionalCharacteristics.Characteristic), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AdditionalCharacteristicsInfo>(deep);
    }

    /// <summary>
    /// <para>Single Characteristic.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ac:characteristic.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(8, "characteristic")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Characteristic : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Characteristic class.
        /// </summary>
        public Characteristic() : base()
        {
        }

        /// <summary>
        /// <para>Name of Characteristic</para>
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
        /// <para>Relationship of Value to Name</para>
        /// <para>Represents the following attribute in the schema: relation</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "relation")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.AdditionalCharacteristics.RelationValues>? Relation
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.AdditionalCharacteristics.RelationValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Characteristic Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Characteristic Grammar</para>
        /// <para>Represents the following attribute in the schema: vocabulary</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "vocabulary")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Vocabulary
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(8, "characteristic");
            builder.AddElement<Characteristic>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "relation", a => a.Relation, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "vocabulary", a => a.Vocabulary, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Characteristic>(deep);
    }

    /// <summary>
    /// Characteristic Relationship Types
    /// </summary>
    public enum RelationValues
    {
        ///<summary>
        ///Greater Than or Equal to.
        ///<para>When the item is serialized out as xml, its value is "ge".</para>
        ///</summary>
        [EnumString("ge")]
        GreaterThanOrEqualTo,
        ///<summary>
        ///Less Than or Equal To.
        ///<para>When the item is serialized out as xml, its value is "le".</para>
        ///</summary>
        [EnumString("le")]
        LessThanOrEqualTo,
        ///<summary>
        ///Greater Than.
        ///<para>When the item is serialized out as xml, its value is "gt".</para>
        ///</summary>
        [EnumString("gt")]
        GreaterThan,
        ///<summary>
        ///Less Than.
        ///<para>When the item is serialized out as xml, its value is "lt".</para>
        ///</summary>
        [EnumString("lt")]
        LessThan,
        ///<summary>
        ///Equal To.
        ///<para>When the item is serialized out as xml, its value is "eq".</para>
        ///</summary>
        [EnumString("eq")]
        EqualTo,
    }
}