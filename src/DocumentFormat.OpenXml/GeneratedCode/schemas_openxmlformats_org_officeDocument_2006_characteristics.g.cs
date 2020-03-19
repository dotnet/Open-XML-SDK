// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.AdditionalCharacteristics
{
    /// <summary>
    /// <para>Set of Additional Characteristics.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ac:additionalCharacteristics.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Characteristic &lt;ac:characteristic></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Characteristic))]
    [SchemaAttr(8, "additionalCharacteristics")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.AdditionalCharacteristics.Characteristic), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AdditionalCharacteristicsInfo>(deep);
    }

    /// <summary>
    /// <para>Single Characteristic.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ac:characteristic.</para>
    /// </summary>
    [SchemaAttr(8, "characteristic")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
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
        [RequiredValidator()]
        [SchemaAttr(0, "name")]
        [Index(0)]
        public StringValue Name { get; set; }

        /// <summary>
        /// <para>Relationship of Value to Name</para>
        /// <para>Represents the following attribute in the schema: relation</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "relation")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.AdditionalCharacteristics.RelationValues> Relation { get; set; }

        /// <summary>
        /// <para>Characteristic Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [RequiredValidator()]
        [SchemaAttr(0, "val")]
        [Index(2)]
        public StringValue Val { get; set; }

        /// <summary>
        /// <para>Characteristic Grammar</para>
        /// <para>Represents the following attribute in the schema: vocabulary</para>
        /// </summary>
        [StringValidator(IsUri = true)]
        [SchemaAttr(0, "vocabulary")]
        [Index(3)]
        public StringValue Vocabulary { get; set; }

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