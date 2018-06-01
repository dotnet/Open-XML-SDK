// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    /// <summary>
    /// 2.3 Element's attribute value should be unique within specified type of element.
    /// </summary>
    internal class UniqueAttributeValueConstraint : SemanticConstraint
    {
        private byte _attribute;
        private Stack<List<string>> _stateStack = new Stack<List<string>>();
        private List<string> _values = new List<string>();
        private SemanticConstraintRegistry _reg;
        private bool _caseSensitive;
        private bool _partLevel;

        public UniqueAttributeValueConstraint(byte attribute, bool caseSensitive, bool partLevel, SemanticConstraintRegistry reg)
            : base(SemanticValidationLevel.Part)
        {
            _attribute = attribute;
            _reg = reg;
            _caseSensitive = caseSensitive;
            _partLevel = partLevel;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            if (_values == null)
            {
                return null;
            }

            var attribute = context.Element.Attributes[_attribute];

            //if the attribute is omitted, semantic validation will do nothing
            if (!attribute.HasValue || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            if (!_values.Where(v => string.Equals(v, attribute.Value.InnerText, _caseSensitive ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal)).Any())
            {
                _values.Add(attribute.Value.InnerText);
                return null;
            }

            return new ValidationErrorInfo()
            {
                Id = "Sem_UniqueAttributeValue",
                ErrorType = ValidationErrorType.Semantic,
                Node = context.Element,
                Description = SR.Format(
                    ValidationResources.Sem_UniqueAttributeValue,
                    GetAttributeQualifiedName(context.Element, _attribute),
                    attribute.Value.InnerText),
            };
        }

        public void AdjustState()
        {
            if (_stateStack.Count() != 0)
            {
                _values = _stateStack.Pop();
            }
            else
            {
                _values = null;
            }
        }

        public override void ClearState(ValidationContext context)
        {
            if (context == null) //initialize before validating
            {
                _stateStack.Clear();
                _values = _partLevel ? new List<string>() : null;
            }
            else //unique scope element reached
            {
                if (_values != null)
                {
                    _stateStack.Push(_values);
                }

                _reg.AddCallBackMethod(context.Element, AdjustState);
                _values = new List<string>();
            }
        }
    }
}
