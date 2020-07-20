// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.17 value of one attribute must be less than or equal another's
    /// </summary>
    internal class AttributeValueLessEqualToAnother : SemanticConstraint
    {
        private readonly byte _attribute;
        private readonly byte _otherAttribute;
        private readonly bool _canEqual;

        public AttributeValueLessEqualToAnother(byte attribute, byte otherAttribute, bool canEqual)
            : base(SemanticValidationLevel.Element)
        {
            _attribute = attribute;
            _otherAttribute = otherAttribute;
            _canEqual = canEqual;
        }

        public override ValidationErrorInfo ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current.Element;
            var attribute = element.ParsedState.Attributes[_attribute];

            if (!attribute.HasValue)
            {
                return null;
            }

            if (!GetAttrNumVal(attribute.Value, out double val))
            {
                return null;
            }

            var other = element.ParsedState.Attributes[_otherAttribute];

            if (!other.HasValue)
            {
                return null;
            }

            if (!GetAttrNumVal(other.Value, out double otherVal))
            {
                return null;
            }

            if (val < otherVal && !_canEqual || val <= otherVal && _canEqual)
            {
                return null;
            }

            string format = _canEqual ? ValidationResources.Sem_AttributeValueLessEqualToAnother : ValidationResources.Sem_AttributeValueLessEqualToAnotherEx;

            return new ValidationErrorInfo()
            {
                Id = "Sem_AttributeValueLessEqualToAnother",
                ErrorType = ValidationErrorType.Semantic,
                Node = element,
                Description = SR.Format(
                    format,
                    GetAttributeQualifiedName(element, _attribute),
                    attribute.Value.InnerText,
                    GetAttributeQualifiedName(element, _otherAttribute),
                    other.Value.InnerText),
            };
        }
    }
}
