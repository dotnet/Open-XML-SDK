// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Int32 (xsd:int) based value restriction.
    /// </summary>
    [DataContract]
    internal class Int32ValueRestriction : SimpleValueRestriction<Int32, Int32Value>
    {
        protected override Int32 MinValue => Int32.MinValue;

        protected override Int32 MaxValue => Int32.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Int;
    }
}
