// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Validation;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
    /// <summary>
    /// One attribute value must no bigger than another's.
    /// Attribute value should be number.
    /// </summary>
    internal class AttributeMinMaxConstraint : SemanticConstraint
    {
        private string _minAttributeLocalName;
        private string _minAttributeNamesapce;
        private string _maxAttributeLocalName;
        private string _maxAttributeNamesapce;

        public AttributeMinMaxConstraint(string minAttributeNamespace, string minAttributeLocalName, string maxAttributeNamespace, string maxAttributeLocalName)
            :base(SemanticValidationLevel.Element) //todo: add error message for this class
        {
            Debug.Assert(minAttributeNamespace != null);
            Debug.Assert(maxAttributeNamespace != null);
            Debug.Assert(!string.IsNullOrEmpty(minAttributeLocalName));
            Debug.Assert(!string.IsNullOrEmpty(maxAttributeLocalName));

            _minAttributeNamesapce = minAttributeNamespace;
            _minAttributeLocalName = minAttributeLocalName;
            _maxAttributeNamesapce = maxAttributeNamespace;
            _maxAttributeLocalName = maxAttributeLocalName;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            string minAttributeValue = context.Element.GetAttributeValueEx(_minAttributeLocalName, _minAttributeNamesapce);

            double minValue;

            //If value cannot be converted into double, that means attribute type is not correct.
            //That's job of schema validation, semantic validation will do nothing to avoid throw duplicated error.
            if (!double.TryParse(minAttributeValue, out minValue))
            {
                return null;
            }

            string maxAttributeValue = context.Element.GetAttributeValueEx(_maxAttributeLocalName, _maxAttributeNamesapce);

            double maxValue;

            //If value cannot be converted into double, that means attribute type is not correct.
            //That's job of schema validation, semantic validation will do nothing to avoid throw duplicated error.
            if (!double.TryParse(maxAttributeValue, out maxValue))
            {
                return null;
            }

            if (minValue <= maxValue)
            {
                return null;
            }

            string errorId = ""; //todo: add error id
            string errorMessage = ""; //todo: add error message

            return new ValidationErrorInfo() { Id = errorId, ErrorType = ValidationErrorType.Semantic, Node = context.Element, Description = errorMessage };
        }
    }
}
