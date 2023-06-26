// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// Represents a collection of features.
/// </summary>
[DebuggerDisplay("Count = {GetCount()}")]
[DebuggerTypeProxy(typeof(FeatureCollectionDebugView))]
public class FeatureCollection : IFeatureCollection
{
    private readonly IFeatureCollection? _defaults;

    private FeatureContainer _container;

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
        _container = new FeatureContainer(initialCapacity);
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
    public virtual int Revision => _container.Revision + (_defaults?.Revision ?? 0);

    /// <inheritdoc/>
    public bool IsReadOnly { get; }

    /// <inheritdoc/>
    public TFeature? Get<TFeature>()
    {
        if (_container.Get<TFeature>() is { } t)
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
    public void Set<TFeature>(TFeature? instance) => this[typeof(TFeature)] = instance;

    /// <inheritdoc/>
    public IEnumerator<KeyValuePair<Type, object>> GetEnumerator() => CreateEnumerator(this, Enumerable.Empty<Type>(), _container, _defaults);

    private int GetCount() => this.Count();

    internal static IEnumerator<KeyValuePair<Type, object>> CreateEnumerator(IFeatureCollection features, IEnumerable<Type> types, FeatureContainer container, params IFeatureCollection?[] others)
    {
        var visited = new HashSet<Type>();

        foreach (var type in types)
        {
            if (visited.Add(type) && features[type] is { } result)
            {
                yield return new(type, result);
            }
        }

        foreach (var type in container.Types)
        {
            if (visited.Add(type) && features[type] is { } result)
            {
                yield return new(type, result);
            }
        }

        foreach (var other in others)
        {
            if (other is not null)
            {
                foreach (var result in other)
                {
                    if (visited.Add(result.Key))
                    {
                        yield return result;
                    }
                }
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    internal static IFeatureCollection Default => DefaultFeatures.Shared;

    /// <inheritdoc/>
    public object? this[Type key]
    {
        get => _container[key] ?? _defaults?[key];
        set
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();
            }

            _container[key] = value;
        }
    }
}
