// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// UInt16 ( xsd:unsignedShort ) based value restriction.
    /// </summary>
    [DataContract]
    internal class UInt16ValueRestriction : SimpleValueRestriction<UInt16, UInt16Value>
    {
        protected override UInt16 MinValue => UInt16.MinValue;

        protected override UInt16 MaxValue => UInt16.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.UnsignedShort;
    }
}
