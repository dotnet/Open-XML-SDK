// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// PositiveInteger (xsd:positiveInteger, ) based value restriction.
    /// </summary>
    /// <remarks>
    /// positiveInteger is ·derived· from nonNegativeInteger by setting the value of ·minInclusive· to be 1.
    /// This results in the standard mathematical concept of the positive integer numbers.
    /// The ·value space· of positiveInteger is the infinite set {1,2,...}.
    /// The ·base type· of positiveInteger is nonNegativeInteger.
    ///
    /// !******************** TODO: at current, the CodeGen generate int for xsd:integer
    /// </remarks>
    [DataContract(Name = "pi")]
    internal class PositiveIntegerValueRestriction : IntegerValueRestriction
    {
        protected override long MinValue => 1;

        public PositiveIntegerValueRestriction()
        {
            RestrictionField = RestrictionField.MinInclusive;
            MinInclusive = 1;
        }

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.PositiveInteger;

        /// <inheritdoc />
        public override string ClrTypeName => ValidationResources.TypeName_positiveInteger;
    }
}
