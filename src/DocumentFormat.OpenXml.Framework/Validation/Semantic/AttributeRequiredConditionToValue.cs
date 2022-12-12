// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.18 attribute is required if another attribute equals some value
    /// </summary>
    internal class AttributeRequiredConditionToValue : SemanticConstraint
    {
        private readonly string _value;
        private readonly OpenXmlQualifiedName _requiredAttribute;
        private readonly OpenXmlQualifiedName _conditionAttribute;

        public AttributeRequiredConditionToValue(OpenXmlQualifiedName requiredAttribute, OpenXmlQualifiedName conditionAttribute, string value)
            : base(SemanticValidationLevel.Element)
        {
            _requiredAttribute = requiredAttribute;
            _conditionAttribute = conditionAttribute;
            _value = value;
        }

        public override ValidationErrorInfo? ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current?.Element;

            if (element is null)
            {
                return null;
            }

            if (!TryFindAttribute(element, _requiredAttribute, out var requiredAttribute))
            {
                return null;
            }

            if (requiredAttribute.Value is not null)
            {
                return null;
            }

            if (!TryFindAttribute(element, _conditionAttribute, out var conditionAttribute))
            {
                return null;
            }

            if (conditionAttribute.Value is null)
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
                        requiredAttribute.Property.QName,
                        conditionAttribute.Property.QName,
                        _value),
                };
            }

            return null;
        }
    }
}
