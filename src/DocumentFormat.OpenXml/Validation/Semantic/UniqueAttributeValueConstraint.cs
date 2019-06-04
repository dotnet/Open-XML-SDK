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
        private readonly SemanticConstraintRegistry _reg;
        private readonly bool _partLevel;
        private readonly StringComparer _comparer;

        public UniqueAttributeValueConstraint(byte attribute, bool caseSensitive, bool partLevel, SemanticConstraintRegistry reg)
            : base(SemanticValidationLevel.Part)
        {
            _attribute = attribute;
            _reg = reg;
            _partLevel = partLevel;
            _comparer = caseSensitive ? StringComparer.Ordinal : StringComparer.OrdinalIgnoreCase;
        }

        private State GetState(ValidationContext context) => context.State.Get(context.Element.GetType(), _attribute, () => new State(_comparer));

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            var state = GetState(context);

            if (state.Values is null || !_partLevel)
            {
                return null;
            }

            var attribute = context.Element.Attributes[_attribute];

            //if the attribute is omitted, semantic validation will do nothing
            if (!attribute.HasValue || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            if (state.Values.Add(attribute.Value.InnerText))
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
            if (context is null)
            {
                return;
            }

            GetState(context).Clear(context);
        }

        private class State : IValidationContextEvents
        {
            private readonly Stack<HashSet<string>> _stateStack;
            private readonly StringComparer _comparer;

            private int count = 0;

            public State(StringComparer comparer)
            {
                _stateStack = new Stack<HashSet<string>>();
                _comparer = comparer;

                Push();
            }

            public void Push() => _stateStack.Push(new HashSet<string>(_comparer));

            public void Clear(ValidationContext context)
            {
                count++;
                Push();
            }

            public void OnContextValidationFinished(ValidationContext context)
            {
                while (count-- > 0)
                {
                    if (_stateStack.Any())
                    {
                        _stateStack.Pop();
                    }
                }
            }

            public HashSet<string> Values => _stateStack.Count > 0 ? _stateStack.Peek() : null;
        }
    }
}
