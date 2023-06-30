// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

#if NET6_0_OR_GREATER
using System.Collections.Immutable;
#endif

namespace DocumentFormat.OpenXml.Builder;

internal abstract class OpenXmlPackageBuilder<TPackage>
    where TPackage : OpenXmlPackage
{
    private List<Func<Action<TPackage>, Action<TPackage>>>? _middleware;
    private CopyOnWrite? _startups;
    private Action<TPackage>? _pipeline;
    private bool _isLocked;

    internal OpenXmlPackageBuilder(OpenXmlPackageBuilder<TPackage>? parent)
    {
        if (parent is not null)
        {
            _pipeline = parent._pipeline;

            if (parent._middleware is not null)
            {
                _middleware = new(parent._middleware);
            }
        }
    }

    public void AddStartup(IPackageInitializer startup)
    {
        (_startups ??= new()).Add(startup);
    }

    public OpenXmlPackageBuilder<TPackage> Use(Func<Action<TPackage>, Action<TPackage>> configure)
    {
        if (_isLocked)
        {
            throw new InvalidOperationException("Middleware cannot be added after pipeline has been built. Call `.New()` to create a copy that can be added to.");
        }

        _pipeline = null;
        (_middleware ??= new()).Add(configure);

        return this;
    }

    internal abstract OpenXmlPackageBuilder<TPackage> New();

    internal abstract TPackage Create();

    public virtual TPackage Open(IPackageInitializer register)
    {
        BuildPipeline();

        var package = Create();

        register.Initialize(package);

        _pipeline(package);

        if (_startups is { } startups)
        {
            foreach (var startup in startups)
            {
                startup.Initialize(package);
            }
        }

        return package;
    }

    [MemberNotNull(nameof(_pipeline))]
    internal void BuildPipeline()
    {
        if (_pipeline is { })
        {
            return;
        }

        _isLocked = true;

        var packageFactoryFeature = new PackageFactory(New());
        var pipeline = packageFactoryFeature.Process;

        if (_middleware is not null)
        {
            for (int i = _middleware.Count - 1; i >= 0; i--)
            {
                pipeline = _middleware[i](pipeline);
            }
        }

        _pipeline = pipeline;
    }

    private sealed class PackageFactory : IPackageFactoryFeature<TPackage>
    {
        private readonly OpenXmlPackageBuilder<TPackage> _other;

        public PackageFactory(OpenXmlPackageBuilder<TPackage> other)
        {
            _other = other;
        }

        public OpenXmlPackageBuilder<TPackage> Create()
            => _other.New();

        public void Process(TPackage package)
        {
            package.Features.Set<IPackageFactoryFeature<TPackage>>(this);
        }
    }

    private sealed class CopyOnWrite
    {
#if NET6_0_OR_GREATER
        private ImmutableList<IPackageInitializer> _list;

        public CopyOnWrite(CopyOnWrite? other = null)
        {
            if (other is not null)
            {
                _list = other._list;
            }
            else
            {
                _list = ImmutableList<IPackageInitializer>.Empty;
            }
        }

        public void Add(IPackageInitializer package)
        {
            _list = _list.Add(package);
        }

        public ImmutableList<IPackageInitializer>.Enumerator GetEnumerator() => _list.GetEnumerator();
#else
        private List<IPackageInitializer>? _list;
        private bool _owned;

        public CopyOnWrite(CopyOnWrite? other = null)
        {
            _list = other?._list;
        }

        public void Add(IPackageInitializer package)
        {
            EnsureOwnership();
            _list.Add(package);
        }

        [MemberNotNull(nameof(_list))]
        private void EnsureOwnership()
        {
            if (!_owned)
            {
                _owned = true;

                if (_list is not null)
                {
                    _list = new(_list);
                }
            }

            if (_list is null)
            {
                _list = new();
            }
        }

        public List<IPackageInitializer>.Enumerator GetEnumerator() => _list?.GetEnumerator() ?? default;
#endif
    }
}
