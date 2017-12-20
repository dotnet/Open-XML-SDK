// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.14 attribute should be absent if another attribute equals some value
    /// </summary>
    internal class AttributeAbsentConditionToValue : SemanticConstraint
    {
        private byte _absentAttribute;
        private byte _conditionAttribute;
        private string[] _values;

        public AttributeAbsentConditionToValue(byte absentAttribute, byte conditionAttribute, params string[] values)
            : base(SemanticValidationLevel.Element)
        {
            _absentAttribute = absentAttribute;
            _conditionAttribute = conditionAttribute;
            _values = values;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            OpenXmlSimpleType attributeValue = context.Element.Attributes[_absentAttribute];

            if (attributeValue == null)
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
                        Id = "Sem_AttributeAbsentConditionToValue",
                        ErrorType = ValidationErrorType.Semantic,
                        Node = context.Element,
                        Description = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeAbsentConditionToValue,
                                                    GetAttributeQualifiedName(context.Element, _absentAttribute),
                                                    GetAttributeQualifiedName(context.Element, _conditionAttribute),
                                                    valueString)
                    };
                }
            }

            return null;
        }
    }
}
