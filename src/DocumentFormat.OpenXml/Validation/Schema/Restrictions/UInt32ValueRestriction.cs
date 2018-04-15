// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// UInt32 (xsd:unsignedInt) based value restriction.
    /// </summary>
    [DataContract(Name = "ui32")]
    internal class UInt32ValueRestriction : SimpleValueRestriction<uint, UInt32Value>
    {
        protected override uint MinValue => uint.MinValue;

        protected override uint MaxValue => uint.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.UnsignedInt;
    }
}
