// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Int16 ( xsd:short ) based value restriction.
    /// </summary>
    [DataContract(Name = "i16")]
    internal class Int16ValueRestriction : SimpleValueRestriction<short, Int16Value>
    {
        protected override short MinValue => short.MinValue;

        protected override short MaxValue => short.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Short;
    }
}
