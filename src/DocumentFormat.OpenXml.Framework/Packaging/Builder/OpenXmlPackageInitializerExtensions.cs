// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging.Builder;

internal static class OpenXmlPackageInitializerExtensions
{
    public static void InitializePackage(this OpenXmlPackage package) => package.Features
        .EnableSavePackage()
        .EnableUriHandling();
}
