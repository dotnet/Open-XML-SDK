// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal class RootAttributeUniqueConstraint : SemanticConstraint
    {
        private byte _attribute;
        private bool _caseSensitive;
        private List<string> _values = new List<string>();

        public RootAttributeUniqueConstraint(byte attribute, bool caseSensitive)
            : base(SemanticValidationLevel.Package)
        {
            _attribute = attribute;
            _caseSensitive = caseSensitive;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            var attribute = context.Element.Attributes[_attribute];

            //if the attribute is omitted, semantic validation will do nothing
            if (!attribute.HasValue || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            bool err = false;

            if (_values.Where(v => string.Equals(v, attribute.Value.InnerText, _caseSensitive ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal)).Any())
            {
                err = true;
            }
            else
            {
                _values.Add(attribute.Value.InnerText);
            }

            if (err)
            {
                return new ValidationErrorInfo()
                {
                    Id = "Sem_AttributeValueUniqueInDocument",
                    ErrorType = ValidationErrorType.Semantic,
                    Node = context.Element,
                    Description = SR.Format(
                        ValidationResources.Sem_AttributeValueUniqueInDocument,
                        GetAttributeQualifiedName(context.Element, _attribute),
                        attribute.Value),
                };
            }
            else
            {
                return null;
            }
        }

        public override void ClearState(ValidationContext context)
        {
            _values.Clear();
        }
    }
}
