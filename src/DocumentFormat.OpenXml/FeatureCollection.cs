// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace DocumentFormat.OpenXml.Framework
{
    /// <summary>
    /// Represents a collection of features.
    /// </summary>
    public class FeatureCollection : IFeatureCollection
    {
        private static IFeatureCollection? _default;

        private readonly int _initialCapacity;
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
        public object? this[Type key]
        {
            get
            {
                if (key == null)
                {
                    throw new ArgumentNullException(nameof(key));
                }

                return _features != null && _features.TryGetValue(key, out var result) ? result : _defaults?[key];
            }

            set
            {
                if (key == null)
                {
                    throw new ArgumentNullException(nameof(key));
                }

                if (IsReadOnly)
                {
                    throw new NotSupportedException();
                }

                if (value == null)
                {
                    if (_features != null && _features.Remove(key))
                    {
                        _containerRevision++;
                    }

                    return;
                }

                if (_features == null)
                {
                    _features = new Dictionary<Type, object>(_initialCapacity);
                }

                _features[key] = value;
                _containerRevision++;
            }
        }

        /// <inheritdoc/>
        public TFeature? Get<TFeature>()
        {
            return (TFeature?)this[typeof(TFeature)];
        }

        /// <inheritdoc/>
        public void Set<TFeature>(TFeature? instance)
        {
            this[typeof(TFeature)] = instance;
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

        internal static IFeatureCollection Default
        {
            get
            {
                if (_default is null)
                {
                    var defaultFeatures = new FeatureCollection
                    {
                        [typeof(IRootElementFactory)] = new ReflectionBasedRootElementFactory(typeof(ReflectionBasedRootElementFactory).GetTypeInfo().Assembly, ClassActivator<OpenXmlElement>.CreateActivator),
                        [typeof(IPartMetadataProvider)] = new CachedPartMetadataProvider(),
                    }.AsReadOnly();

                    Interlocked.CompareExchange(ref _default, defaultFeatures, null);
                }

                return _default;
            }
        }

        private class EmptyFeatures : IFeatureCollection
        {
            public object? this[Type key]
            {
                get => null;
                set { }
            }

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
