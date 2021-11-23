﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.4/1.10 Attribute value must (or must not) in specified value set.
    /// If valid/invalid values are numbers and contiguous, AttributeValueRangeConstraint should be used.
    /// </summary>
    internal class AttributeValueSetConstraint : SemanticConstraint
    {
        private readonly OpenXmlQualifiedName _attribute;
        private readonly bool _isValidValueSet; // "true" means attribute value must in range. And the meaning of "false" is opposite.
        private readonly string[] _valueSet;

        public AttributeValueSetConstraint(OpenXmlQualifiedName attribute, bool isValid, string[] valueSet)
            : base(SemanticValidationLevel.Element)
        {
            Debug.Assert(valueSet.Length > 0);

            _attribute = attribute;
            _isValidValueSet = isValid;
            _valueSet = valueSet;
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
            if (attribute.Value is null || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            bool valueSetContains = false;

            foreach (string value in _valueSet)
            {
                if (AttributeValueEquals(attribute.Value, value, false))
                {
                    valueSetContains = true;
                }
            }

            if (!_isValidValueSet ^ valueSetContains)
            {
                return null;
            }

            var errorDescription = SR.Format(
                ValidationResources.Sem_AttributeValueDataTypeDetailed,
                attribute.Property.QName,
                attribute.Value,
                ValidationResources.Sch_EnumerationConstraintFailed);

            return new ValidationErrorInfo()
            {
                Id = "Sem_AttributeValueDataTypeDetailed",
                ErrorType = ValidationErrorType.Schema,
                Node = element,
                Description = errorDescription,
            };
        }
    }
}
