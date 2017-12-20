// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Byte ( xsd:unsignedByte ) based value restriction.
    /// </summary>
    [DataContract]
    internal class ByteValueRestriction : SimpleValueRestriction<Byte, ByteValue>
    {
        protected override Byte MinValue => Byte.MinValue;

        protected override Byte MaxValue => Byte.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.UnsignedByte;
    }
}
