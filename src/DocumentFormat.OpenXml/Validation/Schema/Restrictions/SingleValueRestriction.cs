// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Single (xsd:float) based value restriction.
    /// </summary>
    [DataContract(Name = "fl")]
    internal class SingleValueRestriction : SimpleValueRestriction<float, SingleValue>
    {
        protected override float MinValue => float.MinValue;

        protected override float MaxValue => float.MaxValue;

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
