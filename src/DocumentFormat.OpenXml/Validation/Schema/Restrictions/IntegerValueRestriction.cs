// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Integer (xsd:integer) based value restriction.
    /// </summary>
    /// <remarks>
    ///  integer is ·derived· from decimal by fixing the value of ·fractionDigits· to be 0 and disallowing the trailing decimal point.
    ///  This results in the standard mathematical concept of the integer numbers.
    ///  The ·value space· of integer is the infinite set {...,-2,-1,0,1,2,...}. The ·base type· of integer is decimal.
    ///
    /// !******************** TODO: at current, the CodeGen generate int for xsd:integer
    /// </remarks>
    [DataContract(Name = "i")]
    internal class IntegerValueRestriction : SimpleValueRestriction<long, IntegerValue>
    {
        protected override long MinValue => long.MinValue;

        protected override long MaxValue => long.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Integer;

        /// <inheritdoc />
        public override string ClrTypeName => ValidationResources.TypeName_Integer;
    }
}
