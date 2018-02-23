// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Single (xsd:float) based value restriction.
    /// </summary>
    [DataContract]
    internal class SingleValueRestriction : SimpleValueRestriction<Single, SingleValue>
    {
        protected override Single MinValue => Single.MinValue;

        protected override Single MaxValue => Single.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Float;

        /// <inheritdoc />
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (attributeValue.HasValue)
            {
                return true;

                // TODO: is NaN valid?
                //Single value = ((SingleValue)attributeValue).Value;
                //return !Single.IsNaN(value);
            }
            return false;
        }
    }
}
