// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// SByte (xsd:bye) based value restriction.
    /// </summary>
    [DataContract]
    internal class SByteValueRestriction : SimpleValueRestriction<SByte, SByteValue>
    {
        protected override SByte MinValue => SByte.MinValue;

        protected override SByte MaxValue => SByte.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Byte;
    }
}
