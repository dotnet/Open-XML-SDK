// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 1.2 Attribute value should follow specified regular expression
    /// </summary>
    internal class AttributeValuePatternConstraint : SemanticConstraint
    {
        private readonly byte _attribute;
        private readonly Regex _pattern;

        public AttributeValuePatternConstraint(byte attribute, string pattern)
            : base(SemanticValidationLevel.Element)
        {
            Debug.Assert(!string.IsNullOrEmpty(pattern));

            _attribute = attribute;

            if (!pattern.StartsWith("^", StringComparison.Ordinal) || !pattern.EndsWith("$", StringComparison.Ordinal))
            {
                pattern = string.Concat("^", pattern, "$");
            }

            _pattern = new Regex(pattern, RegexOptions.Compiled);
        }

        public override ValidationErrorInfo ValidateCore(ValidationContext context)
        {
            var element = context.Stack.Current.Element;
            var attribute = element.ParsedState.Attributes[_attribute];

            //if the attribute is omitted, semantic validation will do nothing
            if (!attribute.HasValue || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            if (_pattern.IsMatch(attribute.Value.InnerText))
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
                    attribute.Value.InnerText,
                    SR.Format(ValidationResources.Sch_PatternConstraintFailed, _pattern)),
            };
        }
    }
}
