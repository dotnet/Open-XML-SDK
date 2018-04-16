// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// SByte (xsd:bye) based value restriction.
    /// </summary>
    [DataContract(Name = "sb")]
    internal class SByteValueRestriction : SimpleValueRestriction<sbyte, SByteValue>
    {
        protected override sbyte MinValue => sbyte.MinValue;

        protected override sbyte MaxValue => sbyte.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Byte;
    }
}
