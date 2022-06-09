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
}
