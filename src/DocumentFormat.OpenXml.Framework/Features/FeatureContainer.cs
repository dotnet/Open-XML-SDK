// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features
{
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

        public TFeature? Get<TFeature>()
        {
            if (_features is not null && _features.TryGetValue(typeof(TFeature), out var feature) && feature is TFeature t)
            {
                return t;
            }

            return default;
        }

        public void Set<TFeature>(TFeature? instance)
        {
            if (instance is null)
            {
                if (_features is not null && _features.Remove(typeof(TFeature)))
                {
                    _containerRevision++;
                }

                return;
            }

            if (_features is null)
            {
                _features = new(_initialCapacity);
            }

            _features[typeof(TFeature)] = instance;
            _containerRevision++;
        }
    }
}
