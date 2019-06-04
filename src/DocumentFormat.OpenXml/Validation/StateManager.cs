// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Validation
{
    internal class StateManager : IValidationContextEvents
    {
        private Dictionary<Key, object> _state;

        public T Get<T>(Type type, int attributeIdx, Func<T> factory)
        {
            var key = new Key(type, attributeIdx);

            if (_state is null)
            {
                _state = new Dictionary<Key, object>();
            }
            else if (_state.TryGetValue(key, out var value))
            {
                if (value is T t)
                {
                    return t;
                }
                else
                {
                    throw new InvalidOperationException(SR.Format("Value of incorrect type: '{0}'. Expecting '{1}'", value.GetType(), typeof(T)));
                }
            }

            var result = factory();

            _state.Add(key, result);

            return result;
        }

        public void Clear() => _state = null;

        void IValidationContextEvents.OnContextValidationFinished(ValidationContext context)
        {
            if (_state is null)
            {
                return;
            }

            var type = context.Element.GetType();

            foreach (var state in _state)
            {
                if (state.Key.Type == type && state.Value is IValidationContextEvents events)
                {
                    events.OnContextValidationFinished(context);
                }
            }
        }

        private readonly struct Key
        {
            public Key(Type type, int attribute)
            {
                Type = type;
                Attribute = attribute;
            }

            public int Attribute { get; }

            public Type Type { get; }
        }
    }
}
