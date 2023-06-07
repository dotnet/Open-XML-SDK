// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Packaging.Builder;
using System;

namespace DocumentFormat.OpenXml.Builder;

internal static class OpenXmlPackageBuilderExtensions
{
    public static OpenXmlPackageBuilder<TPackage> Configure<TPackage>(this OpenXmlPackageBuilder<TPackage> builder, Action<TPackage> action)
        where TPackage : OpenXmlPackage
        => builder.Configure((package, next) =>
        {
            action(package);
            next(package);
        });

    public static OpenXmlPackageBuilder<TPackage> Configure<TPackage>(this OpenXmlPackageBuilder<TPackage> builder, Action<TPackage, Action<TPackage>> middleware)
        where TPackage : OpenXmlPackage
        => builder.Configure(next => package => middleware(package, next));

    internal static OpenXmlPackageBuilder<TPackage> ConfigureSettings<TPackage>(this OpenXmlPackageBuilder<TPackage> builder, OpenSettings settings)
       where TPackage : OpenXmlPackage
       => builder.Configure(package => package.OpenSettings = settings);

    internal static OpenXmlPackageBuilder<TPackage> ConfigureDefaults<TPackage>(this OpenXmlPackageBuilder<TPackage> builder)
        where TPackage : OpenXmlPackage
    => builder.Configure((package, next) =>
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

    internal static TPackage UseDefaultBehavior<TPackage>(this TPackage package)
        where TPackage : OpenXmlPackage
    {
        var compatLevel = package.OpenSettings.CompatibilityLevel;

        package.UseTransitionalRelationshipNamespaces();
        package.IgnoreRelationship("http://schemas.microsoft.com/office/2006/relationships/recovered");

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

        return package;
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
