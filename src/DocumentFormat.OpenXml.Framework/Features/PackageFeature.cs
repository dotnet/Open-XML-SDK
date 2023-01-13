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
    }

    protected override Package Package { get; }

    IPackage IPackageFeature.Package => this;

    bool IPackageFeature.CanReload => false;

    void IPackageFeature.Reload(FileMode? mode, FileAccess? access)
        => throw new NotSupportedException();
}
