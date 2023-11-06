﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Packaging.Builder;
using System;
using System.IO;

namespace DocumentFormat.OpenXml.Builder;

/// <summary>
/// A collection of extension methods for opening packages
/// </summary>
public static class OpenXmlPackageBuilderExtensions
{
    /// <summary>
    /// Opens the <paramref name="stream"/> with the given <paramref name="mode"/>.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Disposable is registered with package")]
    public static TPackage Open<TPackage>(this IPackageBuilder<TPackage> builder, Stream stream, PackageOpenMode mode)
        where TPackage : OpenXmlPackage
    {
        if (builder is null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        return builder.Open(new StreamPackageFeature(stream, mode));
    }

    /// <summary>
    /// Opens the <paramref name="file"/> with the given <paramref name="mode"/>.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Disposable is registered with package")]
    public static TPackage Open<TPackage>(this IPackageBuilder<TPackage> builder, string file, PackageOpenMode mode)
        where TPackage : OpenXmlPackage
    {
        if (builder is null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        return builder.Open(new FilePackageFeature(file, mode));
    }

    /// <summary>
    /// Opens the <paramref name="package"/>.
    /// </summary>
    public static TPackage Open<TPackage>(this IPackageBuilder<TPackage> builder, System.IO.Packaging.Package package)
        where TPackage : OpenXmlPackage
    {
        if (builder is null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        return builder.Open(new PackageFeature(package));
    }

    internal static TPackage Open<TPackage>(this IPackageBuilder<TPackage> builder, string file, bool isEditing)
        where TPackage : OpenXmlPackage
        => builder.Open(file, isEditing ? PackageOpenMode.ReadWrite : PackageOpenMode.Read);

    internal static TPackage Open<TPackage>(this IPackageBuilder<TPackage> builder, Stream stream, bool isEditing)
        where TPackage : OpenXmlPackage
        => builder.Open(stream, isEditing ? PackageOpenMode.ReadWrite : PackageOpenMode.Read);

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Disposable is registered with package")]
    internal static TPackage Open<TPackage>(this IPackageBuilder<TPackage> builder)
        where TPackage : OpenXmlPackage
        => builder.Open(new StreamPackageFeature(new MemoryStream(), PackageOpenMode.Create));

    private static TPackage Open<TPackage>(this IPackageBuilder<TPackage> builder, IPackageInitializer initializer)
        where TPackage : OpenXmlPackage
    {
        var pipeline = builder.Build();
        var package = builder.Create();

        initializer.Initialize(package);
        pipeline(package);

        return package;
    }

    internal static IPackageBuilder<TPackage> Use<TPackage>(this IPackageBuilder<TPackage> builder, PackageInitializerDelegate<TPackage> action)
        where TPackage : OpenXmlPackage
        => builder.Use((package, next) =>
        {
            action(package);
            next(package);
        });

    /// <summary>
    /// Adds the <paramref name="middleware"/> to the builder for initializing a package.
    /// </summary>
    public static IPackageBuilder<TPackage> Use<TPackage>(this IPackageBuilder<TPackage> builder, Action<TPackage, PackageInitializerDelegate<TPackage>> middleware)
        where TPackage : OpenXmlPackage
    {
        if (builder is null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        if (middleware is null)
        {
            throw new ArgumentNullException(nameof(middleware));
        }

        return builder.Use(next => package => middleware(package, next));
    }

    internal static IPackageBuilder<TPackage> UseSettings<TPackage>(this IPackageBuilder<TPackage> builder, OpenSettings settings)
       where TPackage : OpenXmlPackage
       => builder.Use(package => package.OpenSettings = settings);

    internal static IPackageBuilder<TPackage> UseDefaultBehaviorAndLockBuilder<TPackage>(this IPackageBuilder<TPackage> builder)
        where TPackage : OpenXmlPackage
    {
        builder.Use((package, next) =>
        {
            package.UseTransitionalRelationshipNamespaces();
            package.IgnoreRelationship("http://schemas.microsoft.com/office/2006/relationships/recovered");

            next(package);

            ValidateSettings(package);

            var compatLevel = package.OpenSettings.CompatibilityLevel;

            if (compatLevel >= CompatibilityLevel.Version_3_0)
            {
                package.EnableSavePackage();
                package.EnableUriHandling();
            }

            if (compatLevel == CompatibilityLevel.Version_2_20)
            {
                // Before v3.0, all parts were eagerly loaded
                package.LoadAllParts();
            }
        });

        // Eagerly build
        _ = builder.Build();

        return builder;
    }

    private static void ValidateSettings(OpenXmlPackage package)
    {
        if (package.OpenSettings is { } settings &&
             settings.MarkupCompatibilityProcessSettings.ProcessMode != MarkupCompatibilityProcessMode.NoProcess &&
             !settings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions.Any())
        {
            throw new ArgumentException(ExceptionMessages.InvalidMCMode);
        }
    }
}
