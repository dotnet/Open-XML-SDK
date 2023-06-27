// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using NSubstitute;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features.Tests
{
    internal class TestFeatureCollection : IFeatureCollection
    {
        private readonly Dictionary<Type, object?> _types = new();

        public object? this[Type key]
        {
            get => _types.TryGetValue(key, out var result) ? result : null;
            set => _types[key] = value;
        }

        public bool IsReadOnly => false;

        public int Revision => 0;

        public TFeature? Get<TFeature>() => (TFeature?)this[typeof(TFeature)];

        public void AddMock<T>()
            where T : class => Set(Substitute.For<T>());

        public void Set<TFeature>(TFeature? instance) => this[typeof(TFeature)] = instance;

        public IEnumerator<KeyValuePair<Type, object>> GetEnumerator() => _types.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
