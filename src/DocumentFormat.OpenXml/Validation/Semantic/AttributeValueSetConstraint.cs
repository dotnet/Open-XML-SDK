// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Semantic
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
            var attribute = context.Element.Attributes[_attribute];

            //if the attribute is omitted, semantic validation will do nothing
            if (!attribute.HasValue || string.IsNullOrEmpty(attribute.Value.InnerText))
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
                GetAttributeQualifiedName(context.Element, _attribute),
                attribute.Value,
                ValidationResources.Sch_EnumerationConstraintFailed);

            return new ValidationErrorInfo()
            {
                Id = "Sem_AttributeValueDataTypeDetailed",
                ErrorType = ValidationErrorType.Schema,
                Node = context.Element,
                Description = errorDescription,
            };
        }
    }
}
