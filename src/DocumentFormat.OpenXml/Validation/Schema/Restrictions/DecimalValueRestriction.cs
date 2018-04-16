// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Decimal (xsd:decimal) based value restriction.
    /// </summary>
    /// <remarks>
    /// decimal represents a subset of the real numbers, which can be represented by decimal numerals.
    /// The ·value space· of decimal is the set of numbers that can be obtained by multiplying an integer by a non-positive power of ten,
    /// i.e., expressible as i × 10^-n where i and n are integers and n >= 0.
    /// Precision is not reflected in this value space; the number 2.0 is not distinct from the number 2.00.
    /// The ·order-relation· on decimal is the order relation on real numbers, restricted to this subset.
    /// </remarks>
    [DataContract(Name = "dec")]
    internal class DecimalValueRestriction : SimpleValueRestriction<decimal, DecimalValue>
    {
        protected override decimal MinValue => decimal.MinValue;

        protected override decimal MaxValue => decimal.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Decimal;
    }
}
