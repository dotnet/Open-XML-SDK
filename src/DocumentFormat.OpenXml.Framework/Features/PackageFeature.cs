// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging;

internal sealed class PackageFeature : PackageFeatureBase, IPackageFeature
{
    public PackageFeature(Package package)
    {
        Package = package;
    }

    protected override Package Package { get; }
}
