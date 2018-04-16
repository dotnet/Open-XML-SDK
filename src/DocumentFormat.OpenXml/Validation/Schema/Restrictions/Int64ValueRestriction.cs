// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Int64 (xsd:long) based value restriction.
    /// </summary>
    [DataContract(Name = "i64")]
    internal class Int64ValueRestriction : SimpleValueRestriction<long, Int64Value>
    {
        protected override long MinValue => long.MinValue;

        protected override long MaxValue => long.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Long;
    }
}
