// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Int64 (xsd:long) based value restriction.
    /// </summary>
    [DataContract]
    internal class Int64ValueRestriction : SimpleValueRestriction<Int64, Int64Value>
    {
        protected override Int64 MinValue => Int64.MinValue;

        protected override Int64 MaxValue => Int64.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Long;
    }
}
