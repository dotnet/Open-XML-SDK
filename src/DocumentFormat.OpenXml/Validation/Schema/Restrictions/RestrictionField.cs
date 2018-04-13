// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Schema simple type restriction facets.
    /// </summary>
    [DataContract]
    [Flags]
    internal enum RestrictionField : byte
    {
        [EnumMember(Value = "n")]
        None = 0,

        [EnumMember(Value = "l")]
        Length = 1,

        [EnumMember(Value = "nl")]
        MinLength = 1 << 1,

        [EnumMember(Value = "xl")]
        MaxLength = 1 << 2,

        [EnumMember(Value = "ni")]
        MinInclusive = 1 << 3,

        [EnumMember(Value = "xi")]
        MaxInclusive = 1 << 4,

        [EnumMember(Value = "ne")]
        MinExclusive = 1 << 5,

        [EnumMember(Value = "xe")]
        MaxExclusive = 1 << 6,

        [EnumMember(Value = "p")]
        Pattern = 1 << 7,

        [EnumMember(Value = "nxi")]
        MinMaxInclusive = MinInclusive | MaxInclusive,

        [EnumMember(Value = "nxe")]
        MinMaxExclusive = MinExclusive | MaxExclusive,

        [EnumMember(Value = "nxie")]
        MinMaxRestriction = MinMaxInclusive | MinMaxExclusive,

        [EnumMember(Value = "lnxl")]
        LengthRestriction = Length | MinLength | MaxLength,
    }
}
