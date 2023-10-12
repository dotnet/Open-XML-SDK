// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

#if NET6_0_OR_GREATER
using System.Collections.Immutable;
#endif

namespace DocumentFormat.OpenXml.Builder;

internal abstract class OpenXmlPackageBuilder<TPackage> : IPackageBuilder<TPackage>
    where TPackage : OpenXmlPackage
{
    private CopyOnWrite<Func<Action<TPackage>, Action<TPackage>>>? _middleware;
    private Dictionary<string, object?>? _properties;
    private Action<TPackage>? _pipeline;

    public IDictionary<string, object?> Properties => _properties ??= new();

    internal OpenXmlPackageBuilder(OpenXmlPackageBuilder<TPackage>? parent)
    {
        if (parent is not null)
        {
            _pipeline = parent._pipeline;

            if (parent._middleware is not null)
            {
                _middleware = new(parent._middleware);
            }

            if (parent._properties is not null)
            {
                _properties = new(parent._properties);
            }
        }
    }

    public IPackageBuilder<TPackage> Use(Func<Action<TPackage>, Action<TPackage>> configure)
    {
        if (_pipeline is not null)
        {
            throw new InvalidOperationException("Middleware cannot be added after pipeline has been built. Call `.New()` to create a copy that can be added to.");
        }

        (_middleware ??= new()).Add(configure);

        return this;
    }

    public abstract IPackageBuilder<TPackage> Clone();

    public abstract TPackage Create();

    public Action<TPackage> Build()
    {
        if (_pipeline is { })
        {
            return _pipeline;
        }

        var factory = new Factory(Clone());
        var pipeline = factory.PipelineTerminator;

        if (_middleware is not null)
        {
            for (int i = _middleware.Count - 1; i >= 0; i--)
            {
                pipeline = _middleware[i](pipeline);
            }
        }

        return _pipeline = pipeline;
    }

    private sealed class Factory : IPackageFactoryFeature<TPackage>
    {
        private readonly IPackageBuilder<TPackage> _builder;

        public Factory(IPackageBuilder<TPackage> builder) => _builder = builder;

        public IPackageBuilder<TPackage> Create() => _builder.Clone();

        public void PipelineTerminator(TPackage package)
        {
            package.Features.Set<IPackageFactoryFeature<TPackage>>(this);
        }
    }

    private sealed class CopyOnWrite<T>
        where T : class
    {
#if NET6_0_OR_GREATER
        private ImmutableList<T> _list;

        public CopyOnWrite(CopyOnWrite<T>? other = null)
        {
            _list = other is not null ? other._list : ImmutableList<T>.Empty;
        }

        public int Count => _list.Count;

        public T this[int index] => _list[index];

        public void Add(T item) => _list = _list.Add(item);
#else
        private List<T>? _list;
        private bool _owned;

        public CopyOnWrite(CopyOnWrite<T>? other = null)
        {
            _list = other?._list;
        }

        public void Add(T item)
        {
            EnsureOwnership();
            _list.Add(item);
        }

        public int Count => _list?.Count ?? 0;

        public T this[int index] => _list?[index] ?? throw new ArgumentOutOfRangeException(nameof(index));

        [MemberNotNull(nameof(_list))]
        private void EnsureOwnership()
        {
            if (!_owned)
            {
                if (_list is not null)
                {
                    _list = new(_list);
                }

                _owned = true;
            }

            _list ??= new();
        }
#endif
    }
}
