// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    internal class PartConstraintCollection : IReadOnlyDictionary<string, PartConstraintRule>
    {
        private readonly Dictionary<string, PartConstraintRule> _dictionary = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal);

        private bool _writeable;

        public PartConstraintCollection()
            : this(true)
        {
        }

        public static PartConstraintCollection Instance { get; } = new PartConstraintCollection(false);

        public int Count => _dictionary.Count;

        public PartConstraintCollection(bool writeable)
        {
            _writeable = writeable;
        }

        public void Add(string key, PartConstraintRule value)
        {
            if (!_writeable)
            {
                throw new InvalidOperationException();
            }

            _dictionary.Add(key, value);
        }

        public bool TryGetValue(string key, out PartConstraintRule rule) => _dictionary.TryGetValue(key, out rule);

        public bool ContainsRelationship(string relationship) => _dictionary.ContainsKey(relationship);

        bool IReadOnlyDictionary<string, PartConstraintRule>.ContainsKey(string key) => _dictionary.ContainsKey(key);

        IEnumerable<string> IReadOnlyDictionary<string, PartConstraintRule>.Keys => _dictionary.Keys;

        IEnumerable<PartConstraintRule> IReadOnlyDictionary<string, PartConstraintRule>.Values => _dictionary.Values;

        PartConstraintRule IReadOnlyDictionary<string, PartConstraintRule>.this[string key] => _dictionary[key];

        IEnumerator<KeyValuePair<string, PartConstraintRule>> IEnumerable<KeyValuePair<string, PartConstraintRule>>.GetEnumerator() => _dictionary.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _dictionary.GetEnumerator();
    }
}
