// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;

namespace DocumentFormat.OpenXml.Packaging;

internal static class PackageAbstractionExtensions
{
    public static Stream GetStream(this IPackagePart part)
        => part.GetStream(FileMode.OpenOrCreate);

    public static Stream GetStream(this IPackagePart part, FileMode mode)
        => part.GetStream(mode, part.Package.FileOpenAccess);
}
