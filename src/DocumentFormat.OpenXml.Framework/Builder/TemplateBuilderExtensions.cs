// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Builder;

internal static class TemplateBuilderExtensions
{
    public static OpenXmlPackageBuilder<TPackage> ConfigureTemplate<TPackage, TType>(this OpenXmlPackageBuilder<TPackage> builder, string path, TType type)
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

    private static OpenXmlPackageBuilder<TPackage> CreateTemplateBuilder<TPackage>(this OpenXmlPackageBuilder<TPackage> builder, Func<OpenXmlPackageBuilder<TPackage>, TPackage> templateFactory, Action<TPackage>? onLoad = null)
        where TPackage : OpenXmlPackage
        => new TemplateBuilder<TPackage>(builder, templateFactory, onLoad);

    private sealed class TemplateBuilder<TPackage> : OpenXmlPackageBuilder<TPackage>
      where TPackage : OpenXmlPackage
    {
        private readonly OpenXmlPackageBuilder<TPackage> _other;
        private readonly OpenXmlPackageBuilder<TPackage> _templateBuilder;
        private readonly Func<OpenXmlPackageBuilder<TPackage>, TPackage> _templateFactory;
        private readonly Action<TPackage>? _onLoad;

        public TemplateBuilder(
            OpenXmlPackageBuilder<TPackage> other,
            Func<OpenXmlPackageBuilder<TPackage>, TPackage> templateFactory,
            Action<TPackage>? onLoad)
            : base(other)
        {
            _other = other;
            _templateBuilder = other.New();
            _templateFactory = templateFactory;
            _onLoad = onLoad;
        }

        internal override TPackage Create() => _other.Create();

        internal override OpenXmlPackageBuilder<TPackage> New() => _other.New();

        public override TPackage Open(IPackageInitializer register)
        {
            void Combined(OpenXmlPackage package)
            {
                register.Initialize(package);
                LoadTemplate((TPackage)package);
            }

            return base.Open(new WrappedRegistration(Combined));
        }

        private sealed class WrappedRegistration : IPackageInitializer
        {
            private readonly Action<OpenXmlPackage> _wrapped;

            public WrappedRegistration(Action<OpenXmlPackage> wrapped)
            {
                _wrapped = wrapped;
            }

            public void Initialize(OpenXmlPackage package) => _wrapped(package);
        }

        private void LoadTemplate(TPackage package)
        {
            using var template = _templateFactory(_templateBuilder);

            template.Clone(package);

            _onLoad?.Invoke(package);
        }
    }
}
