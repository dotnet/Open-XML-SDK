// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// NonNegativeInteger (xsd:nonNegativeInteger, ) based value restriction.
    /// </summary>
    /// <remarks>
    /// nonNegativeInteger is ·derived· from integer by setting the value of ·minInclusive· to be 0.
    /// This results in the standard mathematical concept of the non-negative integers.
    /// The ·value space· of nonNegativeInteger is the infinite set {0,1,2,...}.
    /// The ·base type· of nonNegativeInteger is integer.
    ///
    /// !******************** TODO: at current, the CodeGen generate int for xsd:integer
    /// </remarks>
    [DataContract(Name = "ni")]
    internal class NonNegativeIntegerValueRestriction : IntegerValueRestriction
    {
        protected override long MinValue => 0;

        public NonNegativeIntegerValueRestriction()
        {
            RestrictionField = RestrictionField.MinInclusive;
            MinInclusive = 0;
        }

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.NonNegativeInteger;

        /// <inheritdoc />
        public override string ClrTypeName => ValidationResources.TypeName_nonNegativeInteger;
    }
}
