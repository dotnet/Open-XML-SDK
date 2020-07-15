// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Validation
{
    internal class StateManager : IValidationContextEvents
    {
        private Dictionary<object, object> _state;

        public T Get<T>(object key, Func<T> factory)
        {
            if (_state is null)
            {
                _state = new Dictionary<object, object>();
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

        public T Get<T>(Type type, int attributeIdx, Type parent, Func<T> factory)
        {
            var key = new Key(type, attributeIdx, parent);

            return Get(key, factory);
        }

        void IValidationContextEvents.OnPartValidationStarted(ValidationContext context)
        {
            _state = null;
        }

        void IValidationContextEvents.OnElementValidationStarted(ValidationContext context)
        {
            if (_state is null)
            {
                return;
            }

            var type = context.Stack.Current.Element.GetType();

            foreach (var state in _state)
            {
                if (state.Key is Key key && key.Parent == type && state.Value is IValidationContextEvents events)
                {
                    events.OnElementValidationStarted(context);
                }
            }
        }

        void IValidationContextEvents.OnElementValidationFinished(ValidationContext context)
        {
            if (_state is null)
            {
                return;
            }

            var type = context.Stack.Current.Element.GetType();

            foreach (var state in _state)
            {
                if (state.Key is Key key && key.Type == type && state.Value is IValidationContextEvents events)
                {
                    events.OnElementValidationFinished(context);
                }
            }
        }

        private readonly struct Key
        {
            public Key(Type type, int attribute, Type parent)
            {
                Type = type;
                Attribute = attribute;
                Parent = parent;
            }

            public int Attribute { get; }

            public Type Type { get; }

            public Type Parent { get; }
        }
    }
}
