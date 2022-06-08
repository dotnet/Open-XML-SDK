// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using NSubstitute;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features.Tests
{
    internal class TestFeatureCollection : IFeatureCollection
    {
        private readonly Dictionary<Type, object?> _types = new();

        public object? this[Type key]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public bool IsReadOnly => false;

        public int Revision => throw new NotImplementedException();

        public TFeature? Get<TFeature>()
        {
            if (_types.TryGetValue(typeof(TFeature), out var result) && result is TFeature t)
            {
                return t;
            }

            return default;
        }

        public void AddMock<T>()
            where T : class => Set(Substitute.For<T>());

        public void Set<TFeature>(TFeature? instance)
        {
            _types[typeof(TFeature)] = instance;
        }
    }
}
