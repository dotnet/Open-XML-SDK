// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Double (xsd:double) based value restriction.
    /// </summary>
    [DataContract]
    internal class DoubleValueRestriction : SimpleValueRestriction<Double, DoubleValue>
    {
        protected override Double MinValue => Double.MinValue;

        protected override Double MaxValue => Double.MaxValue;

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Double;

        /// <inheritdoc />
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (attributeValue.HasValue)
            {
                return true;

                // TODO: is NaN valid?
                //double value = ((DoubleValue)attributeValue).Value;
                //return !double.IsNaN(value);
            }
            return false;
        }
    }
}
