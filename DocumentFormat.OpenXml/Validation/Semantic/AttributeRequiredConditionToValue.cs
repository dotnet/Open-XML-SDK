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
        private string[] _values;
        private byte _requiredAttribute;
        private byte _conditionAttribute;

        public AttributeRequiredConditionToValue(byte requiredAttribute, byte conditionAttribute, params string[] values)
            : base(SemanticValidationLevel.Element)
        {
            _requiredAttribute = requiredAttribute;
            _conditionAttribute = conditionAttribute;
            _values = values;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            OpenXmlSimpleType attributeValue = context.Element.Attributes[_requiredAttribute];

            if (attributeValue != null)
            {
                return null;
            }

            OpenXmlSimpleType conditionAttributeValue = context.Element.Attributes[_conditionAttribute];

            if (conditionAttributeValue == null)
            {
                return null;
            }

            foreach (string value in _values)
            {
                if (AttributeValueEquals(conditionAttributeValue, value, false))
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
                        Node = context.Element,
                        Description = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeRequiredConditionToValue,
                                                    GetAttributeQualifiedName(context.Element, _requiredAttribute),
                                                    GetAttributeQualifiedName(context.Element, _conditionAttribute),
                                                    valueString)
                    };
                }
            }

            return null;
        }
    }
}
