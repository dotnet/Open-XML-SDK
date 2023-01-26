// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Features;

internal static class PackageStorageExtensions
{
    public static TPackage WithStorage<TPackage>(this TPackage package, Stream stream, PackageOpenMode mode)
        where TPackage : OpenXmlPackage
    {
        if (package.Features.Get<IPackageStreamFeature>() is { } streamFeature)
        {
            streamFeature.Stream = stream;
        }
        else
        {
            var streamPackage = new StreamPackageFeature(stream, mode);
            package.Features.Set<IPackageFeature>(streamPackage);
            package.Features.Set<IPackageStreamFeature>(streamPackage);
            package.Features.GetRequired<IDisposableFeature>().Register(streamPackage);
        }

        return package;
    }

    public static TPackage WithStorage<TPackage>(this TPackage oPackage, Package package)
        where TPackage : OpenXmlPackage
    {
        oPackage.Features.Set<IPackageFeature>(new PackageFeature(package));
        return oPackage;
    }

    public static TPackage WithStorage<TPackage>(this TPackage package, string path, PackageOpenMode mode)
        where TPackage : OpenXmlPackage
    {
        var streamPackage = new FilePackageFeature(path, mode);

        package.Features.Set<IPackageFeature>(streamPackage);
        package.Features.Set<IPackageStreamFeature>(streamPackage);
        package.Features.GetRequired<IDisposableFeature>().Register(streamPackage);

        return package;
    }

    internal static TPackage DefaultInitialize<TPackage>(this TPackage package)
        where TPackage : OpenXmlPackage
    {
        package.Load();
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
