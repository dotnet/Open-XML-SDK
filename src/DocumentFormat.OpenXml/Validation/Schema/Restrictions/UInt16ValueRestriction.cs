// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// UInt16 ( xsd:unsignedShort ) based value restriction.
    /// </summary>
    [DataContract(Name = "ui16")]
    internal class UInt16ValueRestriction : SimpleValueRestriction<ushort, UInt16Value>
    {
        protected override ushort MinValue => ushort.MinValue;

        protected override ushort MaxValue => ushort.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.UnsignedShort;
    }
}
