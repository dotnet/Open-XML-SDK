// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Builder;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Disposable is registered with package")]
internal static class StorageBuilderExtensions
{
    public static TPackage WithStorage<TPackage>(this TPackage package, Stream stream, PackageOpenMode mode)
        where TPackage : OpenXmlPackage
    {
        package.SetPackageFeatures(new StreamPackageFeature(stream, mode));
        return package;
    }

    public static TPackage WithStorage<TPackage>(this TPackage oPackage, Package package)
        where TPackage : OpenXmlPackage
    {
        oPackage.SetPackageFeatures(new PackageFeature(package));
        return oPackage;
    }

    public static TPackage WithStorage<TPackage>(this TPackage package, string path, PackageOpenMode mode)
        where TPackage : OpenXmlPackage
    {
        package.SetPackageFeatures(new FilePackageFeature(path, mode));
        return package;
    }

    internal static TPackage Open<TPackage>(this OpenXmlPackageBuilder<TPackage> builder, string path, bool isEditable)
        where TPackage : OpenXmlPackage
        => builder.Open(path, isEditable ? PackageOpenMode.ReadWrite : PackageOpenMode.Read);

    public static TPackage Open<TPackage>(this OpenXmlPackageBuilder<TPackage> builder, Stream stream, bool isEditable)
        where TPackage : OpenXmlPackage
        => builder.Open(stream, isEditable ? PackageOpenMode.ReadWrite : PackageOpenMode.Read);

    private static void SetPackageFeatures(this OpenXmlPackage package, PackageFeatureBase packageFeature)
    {
        var features = package.Features;

        features.Set<IPackageFeature>(packageFeature);
        features.Set<IRelationshipFilterFeature>(packageFeature);

        if (packageFeature is IDisposable disposable)
        {
            features.GetRequired<IDisposableFeature>().Register(disposable);
        }

        if (packageFeature is IPackageStreamFeature streamFeature)
        {
            features.Set<IPackageStreamFeature>(streamFeature);
        }
    }
}
