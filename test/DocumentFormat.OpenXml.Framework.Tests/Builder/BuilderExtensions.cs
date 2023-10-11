// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Builder;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Framework.Tests.Builder;

internal static class BuilderExtensions
{
    public static TPackage Open<TPackage>(this IPackageBuilder<TPackage> builder)
        where TPackage : OpenXmlPackage
    {
        var package = builder.Create();

        builder.Build()(package);

        return package;
    }
}
