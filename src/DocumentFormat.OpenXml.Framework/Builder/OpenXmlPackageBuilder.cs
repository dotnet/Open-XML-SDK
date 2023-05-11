// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.IO;

namespace DocumentFormat.OpenXml.Builder;

internal abstract class OpenXmlPackageBuilder<TPackage>
    where TPackage : OpenXmlPackage
{
    private MiddlewareCollection? _middleware;

    private Action<TPackage>? _pipeline;

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
        // Reset pipeline if new middleware is added
        _pipeline = null;
        (_middleware ??= new()).Add(configure);
        return this;
    }

    internal abstract OpenXmlPackageBuilder<TPackage> New();

    internal abstract TPackage Create();

    private void Initialize(TPackage package)
    {
        GetPipeline()(package);
    }

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
        var package = Create();

        register.Register(package);

        Initialize(package);

        return package;
    }

    private Action<TPackage> GetPipeline()
    {
        if (_pipeline is { } p)
        {
            return p;
        }

        Action<TPackage> pipeline = null!;

        pipeline = (TPackage package) =>
        {
            package.Features.Set<IPackageFactoryFeature<TPackage>>(new InnerBuilder(this));
        };

        if (_middleware is not null)
        {
            for (int i = _middleware.Count - 1; i >= 0; i--)
            {
                pipeline = _middleware[i](pipeline);
            }
        }

        return _pipeline = pipeline;
    }

    private sealed class InnerBuilder : IPackageFactoryFeature<TPackage>
    {
        private readonly OpenXmlPackageBuilder<TPackage> _other;

        public InnerBuilder(OpenXmlPackageBuilder<TPackage> other)
        {
            _other = other;
        }

        public OpenXmlPackageBuilder<TPackage> Create()
            => _other.New();
    }

    private sealed class MiddlewareCollection : List<Func<Action<TPackage>, Action<TPackage>>>
    {
        public MiddlewareCollection()
        {
        }

        public MiddlewareCollection(MiddlewareCollection other)
            : base(other)
        {
        }

        public Action<TPackage> Build(Action<TPackage> pipeline)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                pipeline = this[i](pipeline);
            }

            return pipeline;
        }
    }
}
