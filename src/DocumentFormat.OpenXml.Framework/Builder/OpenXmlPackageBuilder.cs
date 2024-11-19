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
    private PackageDelegate<TPackage>? _pipeline;
    private bool _isLocked;
    private List<Func<PackageDelegate<TPackage>, PackageDelegate<TPackage>>>? _middleware;

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

    public IPackageBuilder<TPackage> Use(Func<PackageDelegate<TPackage>, PackageDelegate<TPackage>> configure)
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
    private PackageDelegate<TPackage> BuildPipeline()
    {
        _isLocked = true;

        if (_pipeline is { })
        {
            return _pipeline;
        }

        var factory = new PackageFactoryFeature(Clone());
        var pipeline = new PackageDelegate<TPackage>(factory.PipelineTerminator);

        if (_middleware is not null)
        {
            for (var i = _middleware.Count - 1; i >= 0; i--)
            {
                pipeline = _middleware[i](pipeline);
            }
        }

        return _pipeline = pipeline;
    }

    private sealed class Factory : IPackageFactory<TPackage>
    {
        private readonly Func<TPackage> _package;
        private readonly PackageDelegate<TPackage> _pipeline;

        public Factory(Func<TPackage> package, PackageDelegate<TPackage> pipeline)
        {
            _package = package;
            _pipeline = pipeline;
        }

        public PackageDelegate<TPackage>? Template { get; set; }

        public IPackageFactory<TPackage> New() => new Factory(_package, _pipeline);

        public TPackage Create(IPackageInitializer initializer)
        {
            var package = _package();

            initializer.Initialize(package);

            package.Features.Set<TemplateFeature>(new TemplateFeature(Template));
            _pipeline(package);
            package.Features.Set<TemplateFeature>(null);

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

            if (package.Features.Get<TemplateFeature>() is { } feature)
            {
                feature.Initialize(package);
            }
        }
    }

    private sealed class TemplateFeature
    {
        private readonly PackageDelegate<TPackage>? _initializer;

        public TemplateFeature(PackageDelegate<TPackage>? initializer)
        {
            _initializer = initializer;
        }

        public void Initialize(TPackage package) => _initializer?.Invoke(package);
    }
}
