// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// UInt64 (xsd:unsignedLong) based value restriction.
    /// </summary>
    [DataContract]
    internal class UInt64ValueRestriction : SimpleValueRestriction<UInt64, UInt64Value>
    {
        protected override UInt64 MinValue => UInt64.MinValue;

        protected override UInt64 MaxValue => UInt64.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.UnsignedLong;
    }
}
