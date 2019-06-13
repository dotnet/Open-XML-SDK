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
        private readonly Type _parent;
        private readonly StringComparer _comparer;

        public UniqueAttributeValueConstraint(byte attribute, bool caseSensitive, Type parent)
            : base(SemanticValidationLevel.Part)
        {
            _attribute = attribute;
            _parent = parent;
            _comparer = caseSensitive ? StringComparer.Ordinal : StringComparer.OrdinalIgnoreCase;
        }

        private State GetState(ValidationContext context) => context.State.Get(context.Element.GetType(), _attribute, _parent, () => new State(_comparer));

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            if (_parent != null)
            {
                return null;
            }

            var attribute = context.Element.Attributes[_attribute];

            //if the attribute is omitted, semantic validation will do nothing
            if (!attribute.HasValue || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            if (GetState(context).Add(attribute.Value.InnerText))
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

        private class State : IValidationContextEvents
        {
            private readonly Stack<HashSet<string>> _stateStack;
            private readonly StringComparer _comparer;

            /// <summary>
            /// We must track the count because there are more calls to <see cref="IValidationContextEvents.OnElementValidationFinished(ValidationContext)"/>
            /// than there are to <see cref="IValidationContextEvents.OnElementValidationStarted(ValidationContext)"/>
            /// </summary>
            private int count = 0;

            public State(StringComparer comparer)
            {
                _stateStack = new Stack<HashSet<string>>();
                _comparer = comparer;

                Push();
            }

            public void Push() => _stateStack.Push(new HashSet<string>(_comparer));

            public bool Add(string str)
            {
                if (_stateStack.Count == 0)
                {
                    return false;
                }
                else
                {
                    return _stateStack.Peek().Add(str);
                }
            }

            void IValidationContextEvents.OnElementValidationStarted(ValidationContext context)
            {
                count++;
                Push();
            }

            void IValidationContextEvents.OnElementValidationFinished(ValidationContext context)
            {
                while (count-- > 0)
                {
                    if (_stateStack.Any())
                    {
                        _stateStack.Pop();
                    }
                }
            }

            void IValidationContextEvents.OnPartValidationStarted(ValidationContext context)
            {
            }
        }
    }
}
