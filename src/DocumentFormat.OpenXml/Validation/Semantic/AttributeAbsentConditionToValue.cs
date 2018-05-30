// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Text;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.14 attribute should be absent if another attribute equals some value
    /// </summary>
    internal class AttributeAbsentConditionToValue : SemanticConstraint
    {
        private readonly byte _absentAttribute;
        private readonly byte _conditionAttribute;
        private readonly string[] _values;
        private readonly Lazy<string> _valueString;

        public AttributeAbsentConditionToValue(byte absentAttribute, byte conditionAttribute, params string[] values)
            : base(SemanticValidationLevel.Element)
        {
            _absentAttribute = absentAttribute;
            _conditionAttribute = conditionAttribute;
            _values = values;
            _valueString = new Lazy<string>(GetValueString);
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            var attributeValue = context.Element.Attributes[_absentAttribute];

            if (attributeValue == null)
            {
                return null;
            }

            var conditionAttributeValue = context.Element.Attributes[_conditionAttribute];

            if (conditionAttributeValue == null)
            {
                return null;
            }

            foreach (string value in _values)
            {
                if (AttributeValueEquals(conditionAttributeValue, value, false))
                {
                    return new ValidationErrorInfo()
                    {
                        Id = "Sem_AttributeAbsentConditionToValue",
                        ErrorType = ValidationErrorType.Semantic,
                        Node = context.Element,
                        Description = SR.Format(
                            ValidationResources.Sem_AttributeAbsentConditionToValue,
                            GetAttributeQualifiedName(context.Element, _absentAttribute),
                            GetAttributeQualifiedName(context.Element, _conditionAttribute),
                            valueString),
                    };
                }
            }

            return null;
        }

        private string GetValueString()
        {
            const char Quote = '\'';
            var sb = new StringBuilder();

            sb.Append(Quote);
            sb.Append(_values[0]);
            sb.Append(Quote);

            for (int i = 1; i < _values.Length; i++)
            {
                sb.Append(Quote);
                sb.Append(' ');
                sb.Append(_values[i]);
                sb.Append(Quote);
            }

            return sb.ToString();
        }
    }
}
