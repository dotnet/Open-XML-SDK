// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Builder;

internal static class TemplateBuilderExtensions
{
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

        private Action<TPackage>? _pipeline;

        public TemplateBuilder(
            IPackageBuilder<TPackage> other,
            Func<IPackageBuilder<TPackage>, TPackage> templateFactory,
            Action<TPackage>? onLoad)
        {
            _otherBuilder = other;
            _templateBuilder = other.New();
            _templateFactory = templateFactory;
            _onLoad = onLoad;
        }

        public IDictionary<string, object?> Properties => _otherBuilder.Properties;

        public Action<TPackage> Build()
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

        public IPackageBuilder<TPackage> New() => new TemplateBuilder<TPackage>(_otherBuilder.New(), _templateFactory, _onLoad);

        public IPackageBuilder<TPackage> Use(Func<Action<TPackage>, Action<TPackage>> configure)
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
