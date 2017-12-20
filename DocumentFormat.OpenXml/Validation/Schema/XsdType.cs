// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// All simple types built in to xml schema.
    /// </summary>
    internal enum XsdType : byte
    {
        AnySimpleType, // xsd:anySimpleType
        String,
        NormalizedString,
        Token,
        Base64Binary,
        HexBinary,
        Integer,
        PositiveInteger,
        NegativeInteger,
        NonNegativeInteger,
        NonPositiveInteger,
        Long,
        UnsignedLong,
        Int,
        UnsignedInt,
        Short,
        UnsignedShort,
        Byte,
        UnsignedByte,
        Decimal,
        Float,
        Double,
        Boolean,
        Duration,
        DateTime,
        Date,
        Time,
        GYear,
        GYearMonth,
        GMonth,
        GMonthDay,
        GDay,
        Name,
        QName,
        NCName,
        AnyURI,
        Language,
        ID,
        IDREF,
        IDREFS,
        ENTITY,
        ENTITIES,
        NOTATION,
        NMTOKEN,
        NMTOKENS,

        // below items are not in schema
        Enum,
        List,
        Union,
        Redirected,

        // special for TrueFalseValue, TrueFalseBlankValue, OnOffValue
        SpecialBoolean,
    }

#region TrueFalse / OnOff
#if false
    /// <summary>
    /// TrueFalseValue (ST_TrueFalse) based simple type constraint.
    /// </summary>
    [DataContract]
    internal class TrueFalseValueRestriction : SimpleTypeRestriction
    {
        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.TrueFalseValue; }
            set { Debug.Assert(value == XsdType.TrueFalseValue); }
        }

#if DEBUG
        public override void Verify()
        {
            Debug.Assert(this.XsdType == XsdType.TrueFalseValue);
            Debug.Assert(this.IsEnum == false);
            Debug.Assert(this.IsList == false);
            Debug.Assert(this.Pattern == null);
        }
#endif
    }

    /// <summary>
    /// TrueFalseBlankValue (ST_TrueFalseBlank) based simple type constraint.
    /// </summary>
    [DataContract]
    internal class TrueFalseBlankValueRestriction : SimpleTypeRestriction
    {
        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.TrueFalseBlankValue; }
            set { Debug.Assert(value == XsdType.TrueFalseBlankValue); }
        }

#if DEBUG
        public override void Verify()
        {
            Debug.Assert(this.XsdType == XsdType.TrueFalseBlankValue);
            Debug.Assert(this.IsEnum == false);
            Debug.Assert(this.IsList == false);
            Debug.Assert(this.Pattern == null);
        }
#endif
    }

    /// <summary>
    /// OnOffValue (ST_OnOff) based simple type constraint.
    /// </summary>
    [DataContract]
    internal class OnOffValueRestriction : SimpleTypeRestriction
    {
        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return XsdType.OnOffValue; }
            set { Debug.Assert(value == XsdType.OnOffValue); }
        }

#if DEBUG
        public override void Verify()
        {
            Debug.Assert(this.XsdType == XsdType.OnOffValue);
            Debug.Assert(this.IsEnum == false);
            Debug.Assert(this.IsList == false);
            Debug.Assert(this.Pattern == null);
        }
#endif
    }

#endif
    #endregion

#if false
    /// <summary>
    /// Other simple type.
    /// </summary>
    /// <remarks>
    /// TODO: this type should be removed when finished all the simple types.
    /// </remarks>
    [DataContract]
    internal class OtherSimpleTypeRestriction : SimpleTypeRestriction
    {
        private XsdType _xsdType;

        public OtherSimpleTypeRestriction()
            : base()
        {
            Debug.Assert(false);
        }

        /// <summary>
        /// Gets the XsdType - type defined in schema.
        /// </summary>
        public override XsdType XsdType
        {
            get { return this._xsdType; }
            set { this._xsdType = value; }
        }

        [DataMember]
        public string MinInclusive { get; set; }

        [DataMember]
        public string MaxInclusive { get; set; }

        [DataMember]
        public string MinExclusive { get; set; }

        [DataMember]
        public string MaxExclusive { get; set; }
    }
#endif

}
