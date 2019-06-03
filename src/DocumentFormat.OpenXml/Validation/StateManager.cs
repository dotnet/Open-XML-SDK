// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Validation
{
    internal class StateManager
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
    }
}
