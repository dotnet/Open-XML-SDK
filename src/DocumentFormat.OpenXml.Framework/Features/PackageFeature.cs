// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging;

internal sealed class PackageFeature : PackageBase, IPackageFeature
{
    public PackageFeature(Package package)
    {
        Package = package;
        Capabilities = GetDefaultCapabilities(!package.FileOpenAccess.HasFlagFast(FileAccess.Write));
    }

    protected override Package Package { get; }

    IPackage IPackageFeature.Package => this;

    void IPackageFeature.Reload(FileMode? mode, FileAccess? access)
        => throw new NotImplementedException();

    public PackageCapabilities Capabilities { get; }

    // ZipArchive.Flush only exists on .NET Framework (https://github.com/dotnet/runtime/issues/24149)
    internal static PackageCapabilities GetDefaultCapabilities(bool isReadOnly)
#if NETFRAMEWORK
        => (isReadOnly ? PackageCapabilities.None : PackageCapabilities.Save) & PackageCapabilities.Cached;
#else
        => PackageCapabilities.Cached;
#endif
}
