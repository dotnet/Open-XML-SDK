// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace System.Collections.Generic
{
    internal interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>
    {
        TValue this[TKey key] { get; }

        IEnumerable<TKey> Keys { get; }

        IEnumerable<TValue> Values { get; }

        bool ContainsKey(TKey key);

        bool TryGetValue(TKey key, out TValue value);
    }
}
