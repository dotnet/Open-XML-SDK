// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Features;

internal static class PackageStorageExtensions
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Disposable is registered with package")]
    public static TPackage WithStorage<TPackage>(this TPackage package, Stream stream, PackageOpenMode mode)
        where TPackage : OpenXmlPackage
        => package.SetPackageFeatures(new StreamPackageFeature(stream, mode));

    public static TPackage WithStorage<TPackage>(this TPackage oPackage, Package package)
        where TPackage : OpenXmlPackage
        => oPackage.SetPackageFeatures(new PackageFeature(package));

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Disposable is registered with package")]
    public static TPackage WithStorage<TPackage>(this TPackage package, string path, PackageOpenMode mode)
        where TPackage : OpenXmlPackage
        => package.SetPackageFeatures(new FilePackageFeature(path, mode));

    private static TPackage SetPackageFeatures<TPackage>(this TPackage package, PackageFeatureBase packageFeature)
        where TPackage : OpenXmlPackage
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

        return package;
    }

    internal static TPackage DefaultInitialize<TPackage>(this TPackage package)
        where TPackage : OpenXmlPackage
    {
        package.ConvertStrictRelationshipToTransitional();

        return package;
    }

    internal static TPackage WithSettings<TPackage>(this TPackage package, OpenSettings settings)
        where TPackage : OpenXmlPackage
    {
        if (settings is not null &&
             settings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess &&
             !settings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions.Any())
        {
            throw new ArgumentException(ExceptionMessages.InvalidMCMode);
        }

        package.OpenSettings = new(settings);
        return package;
    }

    internal static TPackage WithAutosave<TPackage>(this TPackage package, bool autoSave)
        where TPackage : OpenXmlPackage
    {
        package.OpenSettings.AutoSave = autoSave;
        return package;
    }

    internal static TPackage AddAction<TPackage>(this TPackage package, Action<TPackage> action)
        where TPackage : OpenXmlPackage
    {
        action(package);
        return package;
    }
}
