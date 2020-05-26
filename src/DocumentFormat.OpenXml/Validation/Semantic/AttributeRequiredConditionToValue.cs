// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.18 attribute is required if another attribute equals some value
    /// </summary>
    internal class AttributeRequiredConditionToValue : SemanticConstraint
    {
        private readonly string[] _values;
        private readonly byte _requiredAttribute;
        private readonly byte _conditionAttribute;

        public AttributeRequiredConditionToValue(byte requiredAttribute, byte conditionAttribute, params string[] values)
            : base(SemanticValidationLevel.Element)
        {
            _requiredAttribute = requiredAttribute;
            _conditionAttribute = conditionAttribute;
            _values = values;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            var element = context.Stack.Current.Element;
            var attribute = element.EState.Attributes[_requiredAttribute];

            if (!attribute.HasValue)
            {
                return null;
            }

            var conditionAttribute = element.EState.Attributes[_conditionAttribute];

            if (!conditionAttribute.HasValue)
            {
                return null;
            }

            foreach (string value in _values)
            {
                if (AttributeValueEquals(conditionAttribute.Value, value, false))
                {
                    string valueString = "'" + _values[0] + "'";

                    if (_values.Length > 1)
                    {
                        for (int i = 1; i < _values.Length - 1; i++)
                        {
                            valueString += ", '" + _values[i] + "'";
                        }

                        valueString += " or '" + _values[_values.Length - 1] + "'";
                    }

                    return new ValidationErrorInfo()
                    {
                        Id = "Sem_AttributeRequiredConditionToValue",
                        ErrorType = ValidationErrorType.Semantic,
                        Node = element,
                        Description = SR.Format(
                            ValidationResources.Sem_AttributeRequiredConditionToValue,
                            GetAttributeQualifiedName(element, _requiredAttribute),
                            GetAttributeQualifiedName(element, _conditionAttribute),
                            valueString),
                    };
                }
            }

            return null;
        }
    }
}
