// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Represents a collection of features.
    /// </summary>
    public class FeatureCollection : IFeatureCollection
    {
        private readonly int _initialCapacity = 2;
        private readonly IFeatureCollection? _defaults;
        private Dictionary<Type, object>? _features;
        private volatile int _containerRevision;

        private FeatureCollection? _readOnly;

        /// <summary>
        /// Initializes a new instance of <see cref="FeatureCollection"/>.
        /// </summary>
        public FeatureCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="FeatureCollection"/> with the specified initial capacity.
        /// </summary>
        /// <param name="initialCapacity">The initial number of elements that the collection can contain.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"><paramref name="initialCapacity"/> is less than 0</exception>
        public FeatureCollection(int initialCapacity)
        {
            if (initialCapacity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(initialCapacity));
            }

            _initialCapacity = initialCapacity;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="FeatureCollection"/> with the specified defaults.
        /// </summary>
        /// <param name="defaults">The feature defaults.</param>
        /// <param name="isReadOnly">Marks the collection as readonly or not.</param>
        public FeatureCollection(IFeatureCollection defaults, bool isReadOnly = false)
        {
            _defaults = defaults;
            IsReadOnly = isReadOnly;
        }

        /// <inheritdoc/>
        public virtual int Revision => _containerRevision + (_defaults?.Revision ?? 0);

        /// <inheritdoc/>
        public bool IsReadOnly { get; }

        /// <inheritdoc/>
        public TFeature? Get<TFeature>()
        {
            if (_features is not null && _features.TryGetValue(typeof(TFeature), out var feature) && feature is TFeature t)
            {
                return t;
            }
            else if (_defaults is not null)
            {
                return _defaults.Get<TFeature>();
            }

            return default;
        }

        /// <inheritdoc/>
        public void Set<TFeature>(TFeature? instance)
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }

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

        internal static IFeatureCollection Empty { get; } = new EmptyFeatures();

        internal FeatureCollection AsReadOnly()
        {
            if (_readOnly is null)
            {
                _readOnly = new(this, true);
            }

            return _readOnly;
        }

        internal static IFeatureCollection Default => DefaultFeatures.Shared;

        internal static IFeatureCollection TypedOrDefault => TypedFeatures.Shared;

        private class EmptyFeatures : IFeatureCollection
        {
            public bool IsReadOnly => true;

            public int Revision => 0;

            public TFeature? Get<TFeature>() => default;

            public void Set<TFeature>(TFeature? instance)
            {
                throw new NotSupportedException();
            }
        }
    }
}
