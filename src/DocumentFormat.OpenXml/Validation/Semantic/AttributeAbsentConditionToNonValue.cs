// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.15 attribute should be absent if another attribute not equals some value
    /// </summary>
    internal class AttributeAbsentConditionToNonValue : SemanticConstraint
    {
        private byte _absentAttribute;
        private byte _conditionAttribute;
        private string[] _values;

        public AttributeAbsentConditionToNonValue(byte absentAttribute, byte conditionAttribute, params string[] values)
            : base(SemanticValidationLevel.Element)
        {
            _absentAttribute = absentAttribute;
            _conditionAttribute = conditionAttribute;
            _values = values;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            var attribute = context.Element.Attributes[_absentAttribute];

            if (!attribute.HasValue)
            {
                return null;
            }

            var conditionAttribute = context.Element.Attributes[_conditionAttribute];

            if (!conditionAttribute.HasValue)
            {
                return null;
            }

            foreach (string value in _values)
            {
                if (AttributeValueEquals(conditionAttribute.Value, value, false))
                {
                    return null;
                }
            }

            string valueString = "'" + _values[0] + "'";
            if (_values.Length > 1)
            {
                for (int i = 1; i < _values.Length - 1; i++)
                {
                    valueString += ", '" + _values[i] + "'";
                }

                valueString += " and '" + _values[_values.Length - 1] + "'";
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
                    valueString),
            };
        }
    }
}
