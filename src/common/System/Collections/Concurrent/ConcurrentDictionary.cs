// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace System.Collections.Concurrent
{
    internal class ConcurrentDictionary<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _dictionary;

        public ConcurrentDictionary()
        {
            _dictionary = new Dictionary<TKey, TValue>();
        }

        public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> values)
        {
            _dictionary = new Dictionary<TKey, TValue>();

            foreach (var value in values)
            {
                _dictionary.Add(value.Key, value.Value);
            }
        }

        public TValue GetOrAdd(TKey type, Func<TKey, TValue> create)
        {
            lock (_dictionary)
            {
                if (!_dictionary.TryGetValue(type, out var result))
                {
                    result = create(type);
                    _dictionary[type] = result;
                }

                return result;
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            lock (_dictionary)
            {
                return _dictionary.TryGetValue(key, out value);
            }
        }

        public void TryAdd(TKey key, TValue value)
        {
            lock (_dictionary)
            {
                if (!_dictionary.ContainsKey(key))
                {
                    _dictionary.Add(key, value);
                }
            }
        }
    }
}
