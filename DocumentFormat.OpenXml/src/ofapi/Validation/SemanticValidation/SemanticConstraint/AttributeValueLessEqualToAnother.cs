// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Validation;
using System.Xml;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
    /// <summary>
    /// 1.17 value of one attribute must be less than or equal another's
    /// </summary>
    internal class AttributeValueLessEqualToAnother : SemanticConstraint
    {
        private byte _attribute;
        private byte _otherAttribute;
        private bool _canEqual;

        public AttributeValueLessEqualToAnother(byte attribute, byte otherAttribute, bool canEqual)
            : base(SemanticValidationLevel.Element)
        {
            _attribute = attribute;
            _otherAttribute = otherAttribute;
            _canEqual = canEqual;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            OpenXmlSimpleType attributeValue = context.Element.Attributes[_attribute];

            if (attributeValue == null)
            {
                return null;
            }

            double val;
            if (!GetAttrNumVal(attributeValue, out val))
            {
                return null;
            }

            OpenXmlSimpleType otherAttributeValue = context.Element.Attributes[_otherAttribute];

            if (otherAttributeValue == null)
            {
                return null;
            }

            double otherVal;
            if (!GetAttrNumVal(otherAttributeValue, out otherVal))
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
                Node = context.Element,
                Description = string.Format(System.Globalization.CultureInfo.CurrentUICulture, format,
                                            GetAttributeQualifiedName(context.Element, _attribute), attributeValue.InnerText,
                                            GetAttributeQualifiedName(context.Element, _otherAttribute), otherAttributeValue.InnerText)
            };
        }
    }
}
