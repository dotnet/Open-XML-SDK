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
[Obsolete(ExperimentalApis.Message, DiagnosticId = ExperimentalApis.PackageBuilder, UrlFormat = ExperimentalApis.UrlFormat)]
internal static class TemplateBuilderExtensions
{
    public static IPackageFactory<TPackage> WithTemplate<TPackage, TType>(this IPackageFactory<TPackage> packageFactory, string path, TType type)
        where TPackage : OpenXmlPackage
        where TType : struct
        => packageFactory.WithTemplate(templateFactory => templateFactory.Open(path, PackageOpenMode.Read), type);

    public static IPackageFactory<TPackage> WithTemplate<TPackage, TType>(this IPackageFactory<TPackage> factory, Func<IPackageFactory<TPackage>, TPackage> templateActivator, TType type)
        where TPackage : OpenXmlPackage
        where TType : struct
    {
        var templateFactory = factory.New();

        factory.Template += package =>
        {
            var template = templateActivator(templateFactory);
            template.Clone(package);

            var typeFeature = package.Features.GetRequired<IDocumentTypeFeature<TType>>();

            if (!EqualityComparer<TType>.Default.Equals(typeFeature.Current, type))
            {
                typeFeature.ChangeDocumentType(type);
            }
        };

        return factory;
    }
}
