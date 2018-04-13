// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Byte ( xsd:unsignedByte ) based value restriction.
    /// </summary>
    [DataContract(Name = "b")]
    internal class ByteValueRestriction : SimpleValueRestriction<byte, ByteValue>
    {
        protected override byte MinValue => byte.MinValue;

        protected override byte MaxValue => byte.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.UnsignedByte;
    }
}
