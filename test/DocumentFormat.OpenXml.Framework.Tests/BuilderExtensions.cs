// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Builder;
using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Framework.Tests;

internal static class BuilderExtensions
{
    public static TPackage Build<TPackage>(this OpenXmlPackageBuilder<TPackage> builder)
        where TPackage : OpenXmlPackage
    {
        return builder.Open(new EmptyInitializer());
    }

    private sealed class EmptyInitializer : IPackageInitializer
    {
        public void Register(OpenXmlPackage package)
        {
        }
    }
}
