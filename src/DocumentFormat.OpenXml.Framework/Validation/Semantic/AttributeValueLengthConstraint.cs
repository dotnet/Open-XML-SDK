// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.12 Attribute value length must be in specified range.
    /// </summary>
    internal class AttributeValueLengthConstraint : SemanticConstraint
    {
        private readonly OpenXmlQualifiedName _attribute;
        private readonly int _minLength;
        private readonly int _maxLength;

        public AttributeValueLengthConstraint(OpenXmlQualifiedName attribute, int minLength, int maxLength)
            : base(SemanticValidationLevel.Element)
        {
            Debug.Assert(minLength >= 0);
            Debug.Assert(maxLength >= 0);
            Debug.Assert(maxLength >= minLength);

            _attribute = attribute;
            _maxLength = maxLength;
            _minLength = minLength;
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

            // if the attribute is omitted, semantic validation will do nothing
            if (attribute.Value is null)
            {
                return null;
            }

            var attributeValue = attribute.Value.InnerText ?? string.Empty;
            var subMsg = default(string);

            if (attributeValue.Length < _minLength)
            {
                subMsg = SR.Format(ValidationResources.Sem_MinLengthConstraintFailed, _minLength);
            }
            else if (attributeValue.Length > _maxLength)
            {
                subMsg = SR.Format(ValidationResources.Sem_MaxLengthConstraintFailed, _maxLength);
            }

            if (subMsg is null)
            {
                return null;
            }

            return new ValidationErrorInfo()
            {
                Id = "Sem_AttributeValueDataTypeDetailed",
                ErrorType = ValidationErrorType.Schema,
                Node = element,
                Description = SR.Format(
                    ValidationResources.Sem_AttributeValueDataTypeDetailed,
                    attribute.Property.QName,
                    attributeValue,
                    subMsg),
            };
        }
    }
}
