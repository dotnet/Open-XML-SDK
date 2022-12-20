// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.17 value of one attribute must be less than or equal another's
    /// </summary>
    internal class AttributeValueLessEqualToAnother : SemanticConstraint
    {
        private readonly OpenXmlQualifiedName _attribute;
        private readonly OpenXmlQualifiedName _otherAttribute;
        private readonly bool _canEqual;

        public AttributeValueLessEqualToAnother(OpenXmlQualifiedName attribute, OpenXmlQualifiedName otherAttribute, bool canEqual)
            : base(SemanticValidationLevel.Element)
        {
            _attribute = attribute;
            _otherAttribute = otherAttribute;
            _canEqual = canEqual;
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

            if (!GetAttrNumVal(attribute.Value, out double val))
            {
                return null;
            }

            if (!TryFindAttribute(element, _otherAttribute, out var other))
            {
                return null;
            }

            if (other.Value is null)
            {
                return null;
            }

            if (!GetAttrNumVal(other.Value, out double otherVal))
            {
                return null;
            }

            if ((val < otherVal && !_canEqual) || (val <= otherVal && _canEqual))
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
                    attribute.Property.QName,
                    attribute.Value.InnerText,
                    other.Property.QName,
                    other.Value.InnerText),
            };
        }
    }
}
