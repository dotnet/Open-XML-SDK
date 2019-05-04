// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    internal class IntegerMultivalueCollection<TValue>
    {
        private readonly Dictionary<int, HashSet<TValue>> _registry = new Dictionary<int, HashSet<TValue>>();

        public void Add(int key, TValue item)
        {
            if (key < 0)
            {
                return;
            }

            if (!_registry.TryGetValue(key, out var value))
            {
                value = new HashSet<TValue>();
                _registry.Add(key, value);
            }

            value.Add(item);
        }

        public bool TryGetValue(int key, out IEnumerable<TValue> values)
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
