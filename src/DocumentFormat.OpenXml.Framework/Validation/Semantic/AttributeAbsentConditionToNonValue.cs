// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.15 attribute should be absent if another attribute not equals some value
    /// </summary>
    internal class AttributeAbsentConditionToNonValue : SemanticConstraint
    {
        private readonly OpenXmlQualifiedName _absentAttribute;
        private readonly OpenXmlQualifiedName _conditionAttribute;
        private readonly string[] _values;

        public AttributeAbsentConditionToNonValue(OpenXmlQualifiedName absentAttribute, OpenXmlQualifiedName conditionAttribute, params string[] values)
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
                    absentAttribute.Property.QName,
                    conditionAttribute.Property.QName,
                    valueString),
            };
        }
    }
}
