﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.12 Attribute value length must be in specified range.
    /// </summary>
    internal class AttributeValueLengthConstraint : SemanticConstraint
    {
        private byte _attribute;
        private int _minLength;
        private int _maxLength;

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

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            OpenXmlSimpleType attribute = context.Element.Attributes[_attribute];

            //if the attribute is omited, semantic validation will do nothing
            if (attribute == null)
            {
                return null;
            }

            string attributeValue = attribute.InnerText == null ? string.Empty : attribute.InnerText;

            string subMsg = null;

            if (attributeValue.Length < this._minLength)
            {
                subMsg = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sem_MinLengthConstraintFailed, _minLength);
            }
            else if (attributeValue.Length > this._maxLength)
            {
                subMsg = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sem_MaxLengthConstraintFailed, _maxLength);
            }

            if (subMsg == null)
            {
                return null;
            }

            return new ValidationErrorInfo()
            {
                Id = "Sem_AttributeValueDataTypeDetailed",
                ErrorType = ValidationErrorType.Schema,
                Node = context.Element,
                Description = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeValueDataTypeDetailed,
                                            GetAttributeQualifiedName(context.Element, _attribute), attributeValue, subMsg)
            };
        }
    }
}
