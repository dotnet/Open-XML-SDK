// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.12 Attribute value length must be in specified range.
    /// </summary>
    internal class AttributeValueLengthConstraint : SemanticConstraint
    {
        private readonly byte _attribute;
        private readonly int _minLength;
        private readonly int _maxLength;

        public AttributeValueLengthConstraint(byte attribute, int minLength, int maxLength)
            : base(SemanticValidationLevel.Element)
        {
            Debug.Assert(minLength >= 0);
            Debug.Assert(maxLength >= 0);
            Debug.Assert(maxLength >= minLength);

            _attribute = attribute;
            _maxLength = maxLength;
            _minLength = minLength;
        }

        public override ValidationErrorInfo ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current.Element;
            var attribute = element.ParsedState.Attributes[_attribute];

            //if the attribute is omitted, semantic validation will do nothing
            if (!attribute.HasValue)
            {
                return null;
            }

            string attributeValue = attribute.Value.InnerText ?? string.Empty;
            string subMsg = null;

            if (attributeValue.Length < _minLength)
            {
                subMsg = SR.Format(ValidationResources.Sem_MinLengthConstraintFailed, _minLength);
            }
            else if (attributeValue.Length > _maxLength)
            {
                subMsg = SR.Format(ValidationResources.Sem_MaxLengthConstraintFailed, _maxLength);
            }

            if (subMsg == null)
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
                    GetAttributeQualifiedName(element, _attribute),
                    attributeValue,
                    subMsg),
            };
        }
    }
}
