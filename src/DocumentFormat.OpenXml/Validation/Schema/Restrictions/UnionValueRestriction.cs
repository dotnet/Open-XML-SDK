// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Class for all union simple types.
    /// </summary>
    [DataContract(Name = "un")]
    internal class UnionValueRestriction : SimpleTypeRestriction
    {
        [DataMember(Name = "unt")]
        public SimpleTypeRestriction[] UnionTypes { get; set; }

        /// <summary>
        /// Gets or sets an ID for union.
        /// </summary>
        [DataMember(Name = "uid")]
        public int UnionId { get; set; }

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Union;

        /// <inheritdoc />
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            StringValue stringValue = attributeValue.InnerText;

            var memberValues = UnionHelper.CreatePossibleMembers(this, FileFormat);

            int count = memberValues.Length;
            Debug.Assert(count == UnionTypes.Length);

            OpenXmlSimpleType simpleValue;
            SimpleTypeRestriction memberRestriction;

            for (int i = 0; i < count; i++)
            {
                simpleValue = memberValues[i];
                simpleValue.InnerText = stringValue;
                memberRestriction = UnionTypes[i];

                if (memberRestriction.ValidateValueType(simpleValue))
                {
                    if (memberRestriction.Validate(simpleValue) == RestrictionField.None)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
