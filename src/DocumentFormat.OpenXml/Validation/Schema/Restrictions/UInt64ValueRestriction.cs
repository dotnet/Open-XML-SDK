// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// UInt64 (xsd:unsignedLong) based value restriction.
    /// </summary>
    [DataContract(Name = "ui64")]
    internal class UInt64ValueRestriction : SimpleValueRestriction<ulong, UInt64Value>
    {
        protected override ulong MinValue => ulong.MinValue;

        protected override ulong MaxValue => ulong.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.UnsignedLong;
    }
}
