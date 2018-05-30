// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Text;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.15 attribute should be absent if another attribute not equals some value
    /// </summary>
    internal class AttributeAbsentConditionToNonValue : SemanticConstraint
    {
        private readonly byte _absentAttribute;
        private readonly byte _conditionAttribute;
        private readonly string[] _values;

        public AttributeAbsentConditionToNonValue(byte absentAttribute, byte conditionAttribute, params string[] values)
            : base(SemanticValidationLevel.Element, values)
        {
            _absentAttribute = absentAttribute;
            _conditionAttribute = conditionAttribute;
            _values = values;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            var attributeValue = context.Element.Attributes[_absentAttribute];

            if (attributeValue == null)
            {
                return null;
            }

            var conditionAttributeValue = context.Element.Attributes[_conditionAttribute];

            if (conditionAttributeValue == null)
            {
                return null;
            }

            foreach (string value in _values)
            {
                if (AttributeValueEquals(conditionAttributeValue, value, false))
                {
                    return null;
                }
            }

            return new ValidationErrorInfo()
            {
                Id = "Sem_AttributeAbsentConditionToNonValue",
                ErrorType = ValidationErrorType.Semantic,
                Node = context.Element,
                Description = SR.Format(
                    ValidationResources.Sem_AttributeAbsentConditionToNonValue,
                    GetAttributeQualifiedName(context.Element, _absentAttribute),
                    GetAttributeQualifiedName(context.Element, _conditionAttribute),
                    ValuesString),
            };
        }
    }
}
