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
        private readonly byte _absentAttribute;
        private readonly byte _conditionAttribute;
        private readonly string[] _values;

        public AttributeAbsentConditionToNonValue(byte absentAttribute, byte conditionAttribute, params string[] values)
            : base(SemanticValidationLevel.Element)
        {
            _absentAttribute = absentAttribute;
            _conditionAttribute = conditionAttribute;
            _values = values;
        }

        public override ValidationErrorInfo ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current.Element;
            var attribute = element.ParsedState.Attributes[_absentAttribute];

            if (!attribute.HasValue)
            {
                return null;
            }

            var conditionAttribute = element.ParsedState.Attributes[_conditionAttribute];

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
                Node = element,
                Description = SR.Format(
                    ValidationResources.Sem_AttributeAbsentConditionToNonValue,
                    GetAttributeQualifiedName(element, _absentAttribute),
                    GetAttributeQualifiedName(element, _conditionAttribute),
                    valueString),
            };
        }
    }
}
