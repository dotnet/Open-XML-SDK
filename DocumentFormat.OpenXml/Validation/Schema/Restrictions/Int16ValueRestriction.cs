// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Int16 ( xsd:short ) based value restriction.
    /// </summary>
    [DataContract]
    internal class Int16ValueRestriction : SimpleValueRestriction<Int16, Int16Value>
    {
        protected override Int16 MinValue => Int16.MinValue;

        protected override Int16 MaxValue => Int16.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Short;
    }
}
