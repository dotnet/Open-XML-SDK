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
    /// 1.19 attribute should be of some value if another attribute is of some value
    /// </summary>
    internal class AttributeValueConditionToAnother : SemanticConstraint
    {
        private byte _attribute;
        private byte _conditionAttribute;
        private string[] _values;
        private string[] _otherValues;

        public AttributeValueConditionToAnother(byte attribute, byte conditionAttribute, string[] values, string[] otherValues)
            : base(SemanticValidationLevel.Element)
        {
            _attribute = attribute;
            _conditionAttribute = conditionAttribute;
            _values = values;
            _otherValues = otherValues;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            OpenXmlSimpleType attributeValue = context.Element.Attributes[_attribute];

            if (attributeValue == null)
            {
                return null;
            }

            foreach (string value in _values)
            {
                if (AttributeValueEquals(attributeValue, value, false))
                {
                    return null;
                }
            }


            OpenXmlSimpleType conditionAttributeValue = context.Element.Attributes[_conditionAttribute];

            if (conditionAttributeValue == null)
            {
                return null;
            }

            foreach (string value in _otherValues)
            {
                if (AttributeValueEquals(conditionAttributeValue, value, false))
                {
                    string attributeValueString = "'" + _values[0] + "'";
                    if (_values.Length > 1)
                    {
                        for (int i = 1; i < _values.Length -1; i++)
                        {
                            attributeValueString += ", '" + _values[i] + "'";
                        }

                        attributeValueString += " or '" + _values[_values.Length - 1] + "'";
                    }

                    string otherAttributeValueString = "'" + _otherValues[0] + "'";
                    if (_otherValues.Length > 1)
                    {
                        for (int i = 1; i < _otherValues.Length -1 ; i++)
                        {
                            otherAttributeValueString += ", '" + _otherValues[i] + "'";
                        }

                        otherAttributeValueString += " or '" + _otherValues[_otherValues.Length - 1] + "'";
                    }

                    return new ValidationErrorInfo()
                    {
                        Id = "Sem_AttributeValueConditionToAnother",
                        ErrorType = ValidationErrorType.Semantic,
                        Node = context.Element,
                        Description = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeValueConditionToAnother,
                                                    GetAttributeQualifiedName(context.Element, _attribute), attributeValueString,
                                                    GetAttributeQualifiedName(context.Element, _conditionAttribute), otherAttributeValueString,
                                                    GetAttributeQualifiedName(context.Element, _attribute), attributeValue)
                    };
                }
            }

            return null;
        }
    }
}
