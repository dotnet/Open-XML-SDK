// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
            : base(SemanticValidationLevel.Element, values)
        {
            _requiredAttribute = requiredAttribute;
            _conditionAttribute = conditionAttribute;
            _values = values;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            var attribute = context.Element.Attributes[_requiredAttribute];

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
                    return new ValidationErrorInfo()
                    {
                        Id = "Sem_AttributeRequiredConditionToValue",
                        ErrorType = ValidationErrorType.Semantic,
                        Node = context.Element,
                        Description = SR.Format(
                            ValidationResources.Sem_AttributeRequiredConditionToValue,
                            GetAttributeQualifiedName(context.Element, _requiredAttribute),
                            GetAttributeQualifiedName(context.Element, _conditionAttribute),
                            ValuesString),
                    };
                }
            }

            return null;
        }
    }
}
