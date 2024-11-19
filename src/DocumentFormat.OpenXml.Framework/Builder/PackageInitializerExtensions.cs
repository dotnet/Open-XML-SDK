// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Builder;

internal static class PackageInitializerExtensions
{
    private const string Key = "__RegisteredPackageTemplate";

    public static IPackageBuilder<TPackage> WithTemplate<TPackage>(this IPackageBuilder<TPackage> builder, PackageDelegate<TPackage> initializer)
        where TPackage : OpenXmlPackage
    {
        if (builder.Properties.TryGetValue(Key, out var existing) && existing is PackageDelegate<TPackage> initializers)
        {
            builder.Properties[Key] = initializers + initializer;
        }
        else
        {
            builder.Properties[Key] = initializer;
        }

        return builder;
    }

    public static PackageDelegate<TPackage>? GetTemplate<TPackage>(this IPackageBuilder<TPackage> builder)
       where TPackage : OpenXmlPackage
    {
        if (builder.Properties.TryGetValue(Key, out var existing) && existing is PackageDelegate<TPackage> initializers)
        {
            return initializers;
        }

        return null;
    }
}
