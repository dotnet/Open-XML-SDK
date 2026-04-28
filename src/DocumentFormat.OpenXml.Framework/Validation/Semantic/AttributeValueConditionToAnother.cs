// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.19 attribute should be of some value if another attribute is of some value
    /// </summary>
    internal class AttributeValueConditionToAnother : SemanticConstraint
    {
        private readonly OpenXmlQualifiedName _attribute;
        private readonly OpenXmlQualifiedName _conditionAttribute;
        private readonly string[] _values;
        private readonly string[] _otherValues;

        public AttributeValueConditionToAnother(OpenXmlQualifiedName attribute, OpenXmlQualifiedName conditionAttribute, string[] values, string[] otherValues)
            : base(SemanticValidationLevel.Element)
        {
            _attribute = attribute;
            _conditionAttribute = conditionAttribute;
            _values = values;
            _otherValues = otherValues;
        }

        public override ValidationErrorInfo? ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current?.Element;

            if (element is null)
            {
                return null;
            }

            if (!TryFindAttribute(element, _attribute, out var attribute))
            {
                return null;
            }

            if (attribute.Value is null)
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

            if (!TryFindAttribute(element, _conditionAttribute, out var conditionAttribute))
            {
                return null;
            }

            if (conditionAttribute.Value is null)
            {
                return null;
            }

            foreach (string value in _otherValues)
            {
                if (AttributeValueEquals(conditionAttribute.Value, value, false))
                {
                    var sb = StringBuilderPool.Acquire();
                    sb.Append('\'').Append(_values[0]).Append('\'');
                    if (_values.Length > 1)
                    {
                        for (int i = 1; i < _values.Length - 1; i++)
                        {
                            sb.Append(", '").Append(_values[i]).Append('\'');
                        }

                        sb.Append(" or '").Append(_values[_values.Length - 1]).Append('\'');
                    }

                    string attributeValueString = StringBuilderPool.GetValueAndRelease(sb);

                    var otherSb = StringBuilderPool.Acquire();
                    otherSb.Append('\'').Append(_otherValues[0]).Append('\'');
                    if (_otherValues.Length > 1)
                    {
                        for (int i = 1; i < _otherValues.Length - 1; i++)
                        {
                            otherSb.Append(", '").Append(_otherValues[i]).Append('\'');
                        }

                        otherSb.Append(" or '").Append(_otherValues[_otherValues.Length - 1]).Append('\'');
                    }

                    string otherAttributeValueString = StringBuilderPool.GetValueAndRelease(otherSb);

                    return new ValidationErrorInfo()
                    {
                        Id = "Sem_AttributeValueConditionToAnother",
                        ErrorType = ValidationErrorType.Semantic,
                        Node = element,
                        Description = SR.Format(
                            ValidationResources.Sem_AttributeValueConditionToAnother,
                            attribute.Property.QName, attributeValueString,
                            conditionAttribute.Property.QName, otherAttributeValueString,
                            attribute.Property.QName, attribute.Value),
                    };
                }
            }

            return null;
        }
    }
}
