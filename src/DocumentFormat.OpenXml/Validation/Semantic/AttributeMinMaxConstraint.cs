// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// One attribute value must no bigger than another's.
    /// Attribute value should be number.
    /// </summary>
    internal class AttributeMinMaxConstraint : SemanticConstraint
    {
        private readonly string _minAttributeLocalName;
        private readonly string _minAttributeNamesapce;
        private readonly string _maxAttributeLocalName;
        private readonly string _maxAttributeNamesapce;

        public AttributeMinMaxConstraint(string minAttributeNamespace, string minAttributeLocalName, string maxAttributeNamespace, string maxAttributeLocalName)
            : base(SemanticValidationLevel.Element) // TODO: add error message for this class
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

            // If value cannot be converted into double, that means attribute type is not correct.
            // That's the job of schema validation, semantic validation will do nothing to avoid throw duplicated error.
            if (!double.TryParse(minAttributeValue, out double minValue))
            {
                return null;
            }

            string maxAttributeValue = context.Element.GetAttributeValueEx(_maxAttributeLocalName, _maxAttributeNamesapce);

            // If value cannot be converted into double, that means attribute type is not correct.
            // That's the job of schema validation, semantic validation will do nothing to avoid throw duplicated error.
            if (!double.TryParse(maxAttributeValue, out double maxValue))
            {
                return null;
            }

            if (minValue <= maxValue)
            {
                return null;
            }

            string errorId = string.Empty; // TODO: add error id
            string errorMessage = string.Empty; // TODO: add error message

            return new ValidationErrorInfo() { Id = errorId, ErrorType = ValidationErrorType.Semantic, Node = context.Element, Description = errorMessage };
        }
    }
}
