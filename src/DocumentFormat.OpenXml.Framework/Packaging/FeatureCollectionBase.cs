// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging;

[DebuggerDisplay("Count = {GetCount()}")]
[DebuggerTypeProxy(typeof(FeatureCollectionDebugView))]
internal abstract class FeatureCollectionBase : IFeatureCollection
{
    private static readonly HashSet<Type> Ignored = new HashSet<Type>(new[]
    {
        typeof(IFeatureCollection),
        typeof(IEnumerable),
        typeof(IEnumerable<KeyValuePair<Type, object>>),
    });

    private FeatureContainer _container;

    public FeatureCollectionBase(IFeatureCollection? parent = null)
    {
        Parent = parent;
    }

    protected virtual IFeatureCollection? Parent { get; }

    public object? this[Type key]
    {
        get
        {
            if (_container[key] is { } value)
            {
                return value;
            }

            if (GetKnown(key) is { } known)
            {
                return known;
            }

            if (GetType().GetInterfaces().Contains(key) && !Ignored.Contains(key))
            {
                return this;
            }

            return Parent?[key];
        }

        set
        {
            _container[key] = value;
        }
    }

    protected virtual object? GetKnown(Type key) => null;

    protected virtual IEnumerable<Type> KnownTypes => Enumerable.Empty<Type>();

    public bool IsReadOnly => false;

    public int Revision => (Parent?.Revision ?? 0) + _container.Revision;

    public TFeature? Get<TFeature>() => (TFeature?)this[typeof(TFeature)];

    public IEnumerator<KeyValuePair<Type, object>> GetEnumerator()
        => FeatureCollection.CreateEnumerator(this, FeatureTypes, _container, Parent);

    public void Set<TFeature>(TFeature? instance) => this[typeof(TFeature)] = instance;

    private IEnumerable<Type> FeatureTypes
    {
        get
        {
            foreach (var known in KnownTypes)
            {
                yield return known;
            }

            foreach (var @interface in GetType().GetInterfaces())
            {
                if (!Ignored.Contains(@interface))
                {
                    yield return @interface;
                }
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private int GetCount() => this.Count();
}
