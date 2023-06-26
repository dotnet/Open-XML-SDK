// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Features;

internal struct FeatureContainer
{
    private readonly int _initialCapacity = 2;
    private Dictionary<Type, object>? _features;
    private volatile int _containerRevision;

    public FeatureContainer(int initialCapacity = 2)
    {
        if (initialCapacity < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(initialCapacity));
        }

        _initialCapacity = initialCapacity;
        _features = null;
        _containerRevision = 0;
    }

    public int Revision => _containerRevision;

    public IEnumerable<Type> Types => _features?.Keys ?? Enumerable.Empty<Type>();

    public object? this[Type key]
    {
        get
        {
            if (_features is null)
            {
                return null;
            }

            return _features.TryGetValue(key, out var value) ? value : null;
        }

        set
        {
            if (value is null)
            {
                if (_features is not null && _features.Remove(key))
                {
                    _containerRevision++;
                }

                return;
            }

            if (_features is null)
            {
                _features = new(_initialCapacity);
            }

            _features[key] = value;
            _containerRevision++;
        }
    }

    public TFeature? Get<TFeature>() => (TFeature?)this[typeof(TFeature)];

    public void Set<TFeature>(TFeature? instance) => this[typeof(TFeature)] = instance;
}
