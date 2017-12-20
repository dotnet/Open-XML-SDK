// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Schema simple type restrictin facets.
    /// </summary>
    [Flags]
    internal enum RestrictionField : byte
    {
        None = 0x0,

        Length = 0x1,
        MinLength = 0x2,
        MaxLength = 0x4,

        MinInclusive = 0x8,
        MaxInclusive = 0x10,

        MinExclusive = 0x20,
        MaxExclusive = 0x40,

        Pattern = 0x80,

        /// <summary>
        /// MinInclusive | MaxInclusive
        /// </summary>
        MinMaxInclusive = MinInclusive | MaxInclusive,

        /// <summary>
        /// MinExclusive | MaxExclusive
        /// </summary>
        MinMaxExclusive = MinExclusive | MaxExclusive,

        /// <summary>
        /// MinInclusive | MaxInclusive | MinExclusive | MaxExclusive
        /// </summary>
        MinMaxRestriction = MinMaxInclusive | MinMaxExclusive,

        /// <summary>
        /// Length | MinLength | MaxLength
        /// </summary>
        LengthRestriction = Length | MinLength | MaxLength,
    }
}
