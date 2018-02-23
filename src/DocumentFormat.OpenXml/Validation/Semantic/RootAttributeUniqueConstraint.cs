// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
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
            OpenXmlSimpleType attributeValue = context.Element.Attributes[_attribute];

            //if the attribute is omited, semantic validation will do nothing
            if (attributeValue == null || string.IsNullOrEmpty(attributeValue.InnerText))
            {
                return null;
            }

            bool err = false;

            if (_values.Where(v => string.Equals(v, attributeValue.InnerText, _caseSensitive ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal)).Any())
            {
                err = true;
            }
            else
            {
                _values.Add(attributeValue.InnerText);
            }

            if (err)
            {
                string errorDescription = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeValueUniqueInDocument,
                                                        GetAttributeQualifiedName(context.Element, _attribute), attributeValue);

                return new ValidationErrorInfo()
                {
                    Id = "Sem_AttributeValueUniqueInDocument",
                    ErrorType = ValidationErrorType.Semantic,
                    Node = context.Element,
                    Description = errorDescription
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
