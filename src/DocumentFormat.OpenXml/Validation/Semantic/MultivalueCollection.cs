// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal class MultivalueCollection<TKey, TValue>
    {
        private readonly Dictionary<TKey, HashSet<TValue>> _registry = new Dictionary<TKey, HashSet<TValue>>();

        public void Add(TKey key, TValue item)
        {
            if (!_registry.TryGetValue(key, out var value))
            {
                value = new HashSet<TValue>();
                _registry.Add(key, value);
            }

            value.Add(item);
        }

        public bool TryGetValue(TKey key, out IEnumerable<TValue> values)
        {
            var result = _registry.TryGetValue(key, out var hashset);

            if (result)
            {
                values = hashset;
                return true;
            }
            else
            {
                values = null;
                return false;
            }
        }

        public IEnumerable<TValue> GetValues()
        {
            foreach (var value in _registry.Values)
            {
                foreach (var item in value)
                {
                    yield return item;
                }
            }
        }
    }
}
