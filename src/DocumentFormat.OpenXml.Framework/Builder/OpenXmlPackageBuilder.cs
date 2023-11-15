// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Builder;

internal abstract class OpenXmlPackageBuilder<TPackage> : IPackageBuilder<TPackage>
    where TPackage : OpenXmlPackage
{
    private Dictionary<string, object?>? _properties;
    private PackageInitializerDelegate<TPackage>? _pipeline;
    private bool _isLocked;
    private List<Func<PackageInitializerDelegate<TPackage>, PackageInitializerDelegate<TPackage>>>? _middleware;

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

    public IPackageBuilder<TPackage> Use(Func<PackageInitializerDelegate<TPackage>, PackageInitializerDelegate<TPackage>> configure)
    {
        if (_isLocked)
        {
            throw new InvalidOperationException("Middleware cannot be added after pipeline has been built. Call `.New()` to create a copy that can be added to.");
        }

        // Any potentially stored pipeline from previous builders are no longer valid as we have added a new middleware
        _pipeline = null;
        (_middleware ??= new()).Add(configure);

        return this;
    }

    public abstract IPackageBuilder<TPackage> Clone();

    public abstract TPackage Create();

    public IPackageFactory<TPackage> Build() => new Factory(Create, BuildPipeline());

    [MemberNotNull(nameof(_pipeline))]
    private PackageInitializerDelegate<TPackage> BuildPipeline()
    {
        _isLocked = true;

        if (_pipeline is { })
        {
            return _pipeline;
        }

        var factory = new PackageFactoryFeature(Clone());
        var pipeline = new PackageInitializerDelegate<TPackage>(factory.PipelineTerminator);

        if (_middleware is not null)
        {
            for (int i = _middleware.Count - 1; i >= 0; i--)
            {
                pipeline = _middleware[i](pipeline);
            }
        }

        return _pipeline = pipeline;
    }

    private sealed class Factory : IPackageFactory<TPackage>
    {
        private readonly Func<TPackage> _package;
        private readonly PackageInitializerDelegate<TPackage> _pipeline;

        public Factory(Func<TPackage> package, PackageInitializerDelegate<TPackage> pipeline)
        {
            _package = package;
            _pipeline = pipeline;
        }

        public TPackage Create(IPackageInitializer initializer)
        {
            var package = _package();

            initializer.Initialize(package);
            _pipeline(package);

            return package;
        }
    }

    private sealed class PackageFactoryFeature : IPackageFactoryFeature<TPackage>
    {
        private readonly IPackageBuilder<TPackage> _builder;

        public PackageFactoryFeature(IPackageBuilder<TPackage> builder) => _builder = builder;

        public IPackageBuilder<TPackage> Create() => _builder.Clone();

        public void PipelineTerminator(TPackage package)
        {
            package.Features.Set<IPackageFactoryFeature<TPackage>>(this);
        }
    }
}
