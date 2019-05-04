// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
        private readonly byte _attribute;
        private readonly Stack<HashSet<string>> _stateStack = new Stack<HashSet<string>>();
        private readonly SemanticConstraintRegistry _reg;
        private readonly bool _partLevel;
        private readonly StringComparer _comparer;

        private HashSet<string> _values;

        public UniqueAttributeValueConstraint(byte attribute, bool caseSensitive, bool partLevel, SemanticConstraintRegistry reg)
            : base(SemanticValidationLevel.Part)
        {
            _attribute = attribute;
            _reg = reg;
            _partLevel = partLevel;
            _comparer = caseSensitive ? StringComparer.Ordinal : StringComparer.OrdinalIgnoreCase;
            _values = new HashSet<string>(_comparer);
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            if (_values == null || !_partLevel)
            {
                return null;
            }

            var attribute = context.Element.Attributes[_attribute];

            //if the attribute is omitted, semantic validation will do nothing
            if (!attribute.HasValue || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            if (_values.Add(attribute.Value.InnerText))
            {
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

        public override void ClearState(ValidationContext context)
        {
            if (context == null) //initialize before validating
            {
                _stateStack.Clear();
                _values = _partLevel ? new HashSet<string>(_comparer) : null;
            }
            else //unique scope element reached
            {
                if (_values != null)
                {
                    _stateStack.Push(_values);
                }

                _reg.AddCallBackMethod(context.Element, () =>
                {
                    if (_stateStack.Any())
                    {
                        _values = _stateStack.Pop();
                    }
                    else
                    {
                        _values = null;
                    }
                });

                _values = new HashSet<string>(_comparer);
            }
        }
    }
}
