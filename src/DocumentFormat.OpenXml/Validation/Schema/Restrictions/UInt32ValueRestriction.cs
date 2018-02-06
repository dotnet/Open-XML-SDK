// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// UInt32 (xsd:unsignedInt) based value restriction.
    /// </summary>
    [DataContract]
    internal class UInt32ValueRestriction : SimpleValueRestriction<UInt32, UInt32Value>
    {
        protected override UInt32 MinValue => UInt32.MinValue;

        protected override UInt32 MaxValue => UInt32.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.UnsignedInt;
    }
}
