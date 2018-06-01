// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.19 attribute should be of some value if another attribute is of some value
    /// </summary>
    internal class AttributeValueConditionToAnother : SemanticConstraint
    {
        private byte _attribute;
        private byte _conditionAttribute;
        private string[] _values;
        private string[] _otherValues;

        public AttributeValueConditionToAnother(byte attribute, byte conditionAttribute, string[] values, string[] otherValues)
            : base(SemanticValidationLevel.Element)
        {
            _attribute = attribute;
            _conditionAttribute = conditionAttribute;
            _values = values;
            _otherValues = otherValues;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            var attribute = context.Element.Attributes[_attribute];

            if (!attribute.HasValue)
            {
                return null;
            }

            foreach (string value in _values)
            {
                if (AttributeValueEquals(attribute.Value, value, false))
                {
                    return null;
                }
            }

            var conditionAttribute = context.Element.Attributes[_conditionAttribute];

            if (!conditionAttribute.HasValue)
            {
                return null;
            }

            foreach (string value in _otherValues)
            {
                if (AttributeValueEquals(conditionAttribute.Value, value, false))
                {
                    string attributeValueString = "'" + _values[0] + "'";
                    if (_values.Length > 1)
                    {
                        for (int i = 1; i < _values.Length - 1; i++)
                        {
                            attributeValueString += ", '" + _values[i] + "'";
                        }

                        attributeValueString += " or '" + _values[_values.Length - 1] + "'";
                    }

                    string otherAttributeValueString = "'" + _otherValues[0] + "'";
                    if (_otherValues.Length > 1)
                    {
                        for (int i = 1; i < _otherValues.Length - 1; i++)
                        {
                            otherAttributeValueString += ", '" + _otherValues[i] + "'";
                        }

                        otherAttributeValueString += " or '" + _otherValues[_otherValues.Length - 1] + "'";
                    }

                    return new ValidationErrorInfo()
                    {
                        Id = "Sem_AttributeValueConditionToAnother",
                        ErrorType = ValidationErrorType.Semantic,
                        Node = context.Element,
                        Description = SR.Format(
                            ValidationResources.Sem_AttributeValueConditionToAnother,
                            GetAttributeQualifiedName(context.Element, _attribute), attributeValueString,
                            GetAttributeQualifiedName(context.Element, _conditionAttribute), otherAttributeValueString,
                            GetAttributeQualifiedName(context.Element, _attribute), attribute.Value),
                    };
                }
            }

            return null;
        }
    }
}
