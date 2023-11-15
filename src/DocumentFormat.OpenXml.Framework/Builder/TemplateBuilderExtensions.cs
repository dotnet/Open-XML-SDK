// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Builder;

/// <summary>
/// A collection of extensions to add a template as part of the <see cref="IPackageBuilder{TPackage}"/>.
/// </summary>
[Experimental(ExperimentalApis.PackageBuilder, UrlFormat = ExperimentalApis.UrlFormat)]
public static class TemplateBuilderExtensions
{
    /// <summary>
    /// Adds a template to the current <paramref name="builder"/>.
    /// </summary>
    public static IPackageBuilder<TPackage> UseTemplate<TPackage, TType>(this IPackageBuilder<TPackage> builder, string path, TType type)
        where TPackage : OpenXmlPackage
        where TType : struct
        => builder.CreateTemplateBuilder(
            builder => builder.Open(path, PackageOpenMode.Read),
            package =>
            {
                var typeFeature = package.Features.GetRequired<IDocumentTypeFeature<TType>>();

                if (!EqualityComparer<TType>.Default.Equals(typeFeature.Current, type))
                {
                    typeFeature.ChangeDocumentType(type);
                }
            });

    internal static IPackageBuilder<TPackage> CreateTemplateBuilder<TPackage>(this IPackageBuilder<TPackage> builder, Func<IPackageBuilder<TPackage>, TPackage> templateFactory, Action<TPackage>? onLoad = null)
        where TPackage : OpenXmlPackage
        => new TemplateBuilder<TPackage>(builder, templateFactory, onLoad);

    private sealed class TemplateBuilder<TPackage> : IPackageBuilder<TPackage>
      where TPackage : OpenXmlPackage
    {
        private readonly IPackageBuilder<TPackage> _otherBuilder;
        private readonly IPackageBuilder<TPackage> _templateBuilder;
        private readonly Func<IPackageBuilder<TPackage>, TPackage> _templateFactory;
        private readonly Action<TPackage>? _onLoad;

        private PackageInitializerDelegate<TPackage>? _pipeline;

        public TemplateBuilder(
            IPackageBuilder<TPackage> other,
            Func<IPackageBuilder<TPackage>, TPackage> templateFactory,
            Action<TPackage>? onLoad)
        {
            _otherBuilder = other;
            _templateBuilder = other.Clone();
            _templateFactory = templateFactory;
            _onLoad = onLoad;
        }

        public IDictionary<string, object?> Properties => _otherBuilder.Properties;

        public PackageInitializerDelegate<TPackage> Build()
        {
            if (_pipeline is null)
            {
                var built = _otherBuilder.Build();

                _pipeline = package =>
                {
                    LoadTemplate(package);
                    built(package);
                };
            }

            return _pipeline;
        }

        public TPackage Create() => _otherBuilder.Create();

        public IPackageBuilder<TPackage> Clone() => new TemplateBuilder<TPackage>(_otherBuilder.Clone(), _templateFactory, _onLoad);

        public IPackageBuilder<TPackage> Use(Func<PackageInitializerDelegate<TPackage>, PackageInitializerDelegate<TPackage>> configure)
        {
            _pipeline = null;
            _otherBuilder.Use(configure);
            return this;
        }

        private void LoadTemplate(TPackage package)
        {
            using var template = _templateFactory(_templateBuilder);

            template.Clone(package);

            _onLoad?.Invoke(package);
        }
    }
}
