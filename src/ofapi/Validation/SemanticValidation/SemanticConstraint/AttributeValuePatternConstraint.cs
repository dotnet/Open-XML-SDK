// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml.Validation;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
    /// <summary>
    /// 1.2 Attribute value should follow specified regex
    /// </summary>
    internal class AttributeValuePatternConstraint : SemanticConstraint
    {
        private byte _attribute;
        private string _pattern;

        public AttributeValuePatternConstraint(byte attribute, string pattern)
            : base(SemanticValidationLevel.Element)
        {
            Debug.Assert(!string.IsNullOrEmpty(pattern));

            _attribute = attribute;

            if (pattern.StartsWith("^", StringComparison.Ordinal) && pattern.EndsWith("$", StringComparison.Ordinal))
            {
                _pattern = pattern;
            }
            else
            {
                _pattern = "^" + pattern + "$";
            }
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            OpenXmlSimpleType attributeValue = context.Element.Attributes[_attribute];

            //if the attribute is omited, semantic validation will do nothing 
            if (attributeValue == null || string.IsNullOrEmpty(attributeValue.InnerText))
            {
                return null;
            }

            Regex regex = new Regex(this._pattern);
            if (regex.IsMatch(attributeValue.InnerText))
            {
                return null;
            }

            string subMsg = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sch_PatternConstraintFailed, _pattern);
            return new ValidationErrorInfo()
            {
                Id = "Sem_AttributeValueDataTypeDetailed",
                ErrorType = ValidationErrorType.Schema,
                Node = context.Element,
                Description = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeValueDataTypeDetailed,
                                            GetAttributeQualifiedName(context.Element, _attribute), attributeValue.InnerText, subMsg)
            };
        }
    }
}
