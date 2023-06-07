// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace DocumentFormat.OpenXml.Builder;

internal abstract class OpenXmlPackageBuilder<TPackage>
    where TPackage : OpenXmlPackage
{
    private List<Func<Action<TPackage>, Action<TPackage>>>? _middleware;
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

    public OpenXmlPackageBuilder<TPackage> Configure(Func<Action<TPackage>, Action<TPackage>> configure)
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

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Disposable is registered with package")]
    public virtual TPackage Open(Stream stream, PackageOpenMode mode)
       => Open(new StreamPackageFeature(stream, mode));

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Disposable is registered with package")]
    public virtual TPackage Open(string file, PackageOpenMode mode)
        => Open(new FilePackageFeature(file, mode));

    public virtual TPackage Open(System.IO.Packaging.Package package)
        => Open(new PackageFeature(package));

    public virtual TPackage Open(IPackageInitializer register)
    {
        Build();

        var package = Create();

        register.Register(package);

        _pipeline(package);

        return package;
    }

    [MemberNotNull(nameof(_pipeline))]
    internal void Build()
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
}
