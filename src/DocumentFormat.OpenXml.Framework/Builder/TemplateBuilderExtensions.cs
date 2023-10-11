// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Builder;

internal static class TemplateBuilderExtensions
{
    public static IPackageBuilder<TPackage> ConfigureTemplate<TPackage, TType>(this IPackageBuilder<TPackage> builder, string path, TType type)
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

    private static IPackageBuilder<TPackage> CreateTemplateBuilder<TPackage>(this IPackageBuilder<TPackage> builder, Func<IPackageBuilder<TPackage>, TPackage> templateFactory, Action<TPackage>? onLoad = null)
        where TPackage : OpenXmlPackage
        => new TemplateBuilder<TPackage>(builder, templateFactory, onLoad);

    private sealed class TemplateBuilder<TPackage> : OpenXmlPackageBuilder<TPackage>
      where TPackage : OpenXmlPackage
    {
        private readonly IPackageBuilder<TPackage> _other;
        private readonly IPackageBuilder<TPackage> _templateBuilder;
        private readonly Func<IPackageBuilder<TPackage>, TPackage> _templateFactory;
        private readonly Action<TPackage>? _onLoad;

        public TemplateBuilder(
            IPackageBuilder<TPackage> other,
            Func<IPackageBuilder<TPackage>, TPackage> templateFactory,
            Action<TPackage>? onLoad)
            : base((OpenXmlPackageBuilder<TPackage>)other)
        {
            _other = other;
            _templateBuilder = other.New();
            _templateFactory = templateFactory;
            _onLoad = onLoad;
        }

        public override TPackage Create()
        {
            var package = _other.Create();
            LoadTemplate(package);
            return package;
        }

        public override IPackageBuilder<TPackage> New() => _other.New();

        private void LoadTemplate(TPackage package)
        {
            using var template = _templateFactory(_templateBuilder);

            template.Clone(package);

            _onLoad?.Invoke(package);
        }
    }
}
