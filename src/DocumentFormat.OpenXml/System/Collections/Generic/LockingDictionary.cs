// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml
{
    internal class LockingDictionary<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _dictionary = new Dictionary<TKey, TValue>();

        public TValue GetValue(TKey key, Func<TKey, TValue> factory)
        {
            lock (_dictionary)
            {
                if (_dictionary.TryGetValue(key, out var value))
                {
                    return value;
                }

                var created = factory(key);

                _dictionary[key] = created;

                return created;
            }
        }
    }
}
