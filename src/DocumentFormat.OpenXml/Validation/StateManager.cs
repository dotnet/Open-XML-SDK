// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Validation
{
    internal class StateManager
    {
        private readonly ValidationContext _context;

        private Dictionary<object, object>? _state;

        public StateManager(ValidationContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Method to get or create a cached value. To minimize allocations, the key should track everything that is
        /// required to generate the item in the factory. If so, then a static lambda can be used to ensure nothing
        /// else is required and that the key will be correct.
        /// </summary>
        /// <typeparam name="TValue">Type of the value produced.</typeparam>
        /// <typeparam name="TKey">Type of the key provided.</typeparam>
        /// <param name="key">Provided key that should identify the cached value uniquely.</param>
        /// <param name="factory">A factory method to create the value.</param>
        /// <returns>The created or cached value.</returns>
        public TValue GetOrCreate<TValue, TKey>(TKey key, Func<TKey, ValidationContext, TValue> factory)
            where TValue : notnull
            where TKey : notnull
        {
            if (_state is null)
            {
                _state = new Dictionary<object, object>();
            }
            else if (_state.TryGetValue(key, out var value))
            {
                if (value is TValue t)
                {
                    return t;
                }
                else
                {
                    throw new InvalidOperationException(SR.Format("Value of incorrect type: '{0}'. Expecting '{1}'", value.GetType(), typeof(TValue)));
                }
            }

            var result = factory(key, _context);

            _state.Add(key, result);

            return result;
        }
    }
}
