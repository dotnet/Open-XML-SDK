// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.18 attribute is required if another attribute equals some value
    /// </summary>
    internal class AttributeRequiredConditionToValue : SemanticConstraint
    {
        private readonly string _value;
        private readonly byte _requiredAttribute;
        private readonly byte _conditionAttribute;

        public AttributeRequiredConditionToValue(byte requiredAttribute, byte conditionAttribute, string value)
            : base(SemanticValidationLevel.Element)
        {
            _requiredAttribute = requiredAttribute;
            _conditionAttribute = conditionAttribute;
            _value = value;
        }

        public override ValidationErrorInfo ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current.Element;
            var requiredAttribute = element.ParsedState.Attributes[_requiredAttribute];

            if (requiredAttribute.HasValue)
            {
                return null;
            }

            var conditionAttribute = element.ParsedState.Attributes[_conditionAttribute];

            if (!conditionAttribute.HasValue)
            {
                return null;
            }

            if (AttributeValueEquals(conditionAttribute.Value, _value, false))
            {
                return new ValidationErrorInfo()
                {
                    Id = "Sem_AttributeRequiredConditionToValue",
                    ErrorType = ValidationErrorType.Semantic,
                    Node = element,
                    Description = SR.Format(
                        ValidationResources.Sem_AttributeRequiredConditionToValue,
                        GetAttributeQualifiedName(element, _requiredAttribute),
                        GetAttributeQualifiedName(element, _conditionAttribute),
                        _value),
                };
            }

            return null;
        }
    }
}
