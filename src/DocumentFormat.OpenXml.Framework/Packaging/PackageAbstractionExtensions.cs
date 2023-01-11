// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable SA1649 // File name should match first type name
#pragma warning disable SA1402 // File may only contain a single type

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class PackageAbstractionExtensions
    {
        public static Stream GetStream(this IPackagePart part)
            => part.GetStream(FileMode.OpenOrCreate);

        public static Stream GetStream(this IPackagePart part, FileMode mode)
            => part.GetStream(mode, part.Package.FileOpenAccess);
    }
}
