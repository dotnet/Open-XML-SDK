// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Int32 (xsd:int) based value restriction.
    /// </summary>
    [DataContract(Name = "i32")]
    internal class Int32ValueRestriction : SimpleValueRestriction<int, Int32Value>
    {
        protected override int MinValue => int.MinValue;

        protected override int MaxValue => int.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Int;
    }
}
