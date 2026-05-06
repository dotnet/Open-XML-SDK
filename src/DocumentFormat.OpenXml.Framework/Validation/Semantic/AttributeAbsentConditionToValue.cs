// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System.Text;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.14 attribute should be absent if another attribute equals some value
    /// </summary>
    internal class AttributeAbsentConditionToValue : SemanticConstraint
    {
        private readonly OpenXmlQualifiedName _absentAttribute;
        private readonly OpenXmlQualifiedName _conditionAttribute;
        private readonly string[] _values;

        public AttributeAbsentConditionToValue(OpenXmlQualifiedName absentAttribute, OpenXmlQualifiedName conditionAttribute, params string[] values)
            : base(SemanticValidationLevel.Element)
        {
            _absentAttribute = absentAttribute;
            _conditionAttribute = conditionAttribute;
            _values = values;
        }

        public override ValidationErrorInfo? ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current?.Element;

            if (element is null)
            {
                return null;
            }

            if (!TryFindAttribute(element, _absentAttribute, out var absentAttribute))
            {
                return null;
            }

            if (absentAttribute.Value is null)
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

            foreach (string value in _values)
            {
                if (AttributeValueEquals(conditionAttribute.Value, value, false))
                {
                    var sb = new StringBuilder();
                    sb.Append('\'').Append(_values[0]).Append('\'');
                    if (_values.Length > 1)
                    {
                        for (int i = 1; i < _values.Length - 1; i++)
                        {
                            sb.Append(", '").Append(_values[i]).Append('\'');
                        }

                        sb.Append(" or '").Append(_values[_values.Length - 1]).Append('\'');
                    }

                    string valueString = sb.ToString();

                    return new ValidationErrorInfo()
                    {
                        Id = "Sem_AttributeAbsentConditionToValue",
                        ErrorType = ValidationErrorType.Semantic,
                        Node = element,
                        Description = SR.Format(
                            ValidationResources.Sem_AttributeAbsentConditionToValue,
                            absentAttribute.Property.QName,
                            conditionAttribute.Property.QName,
                            valueString),
                    };
                }
            }

            return null;
        }
    }
}
