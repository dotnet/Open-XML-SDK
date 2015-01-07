// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Validation;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
    /// <summary>
    /// 1.4/1.10 Attribute value must (or must not) in specified value set.
    /// If valid/invalid values are numbers and contiguous, AttributeValueRangeConstraint should be used.
    /// </summary>
    internal class AttributeValueSetConstraint : SemanticConstraint
    {
        private byte _attribute;
        private bool _isValidValueSet; //"true" means attribute value must in range. And the meaning of "false" is opposite.
        private string[] _valueSet;

        public AttributeValueSetConstraint(byte attribute, bool isValid, string[] valueSet)
            : base(SemanticValidationLevel.Element)
        {
            Debug.Assert(valueSet.Length > 0);

            _attribute = attribute;
            _isValidValueSet = isValid;
            _valueSet = valueSet;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            OpenXmlSimpleType attributeValue = context.Element.Attributes[_attribute];

            //if the attribute is omited, semantic validation will do nothing 
            if (attributeValue == null || string.IsNullOrEmpty(attributeValue.InnerText))
            {
                return null;
            }

            bool valueSetContains = false;

            foreach (string value in _valueSet)
            {
                if (AttributeValueEquals(attributeValue, value, false))
                {
                    valueSetContains = true;
                }
            }

            if (!this._isValidValueSet ^ valueSetContains)
            {
                return null;
            }

            string subMsg = ValidationResources.Sch_EnumerationConstraintFailed;
            string errorDescription = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeValueDataTypeDetailed,
                                                    GetAttributeQualifiedName(context.Element, _attribute), attributeValue, subMsg);

            return new ValidationErrorInfo()
            {
                Id = "Sem_AttributeValueDataTypeDetailed",
                ErrorType = ValidationErrorType.Schema,
                Node = context.Element,
                Description = errorDescription
            };
        }
    }
}
