// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging;

internal sealed class PackagePartFeature : IPackagePartFeature
{
    public PackagePartFeature(IPackagePart part) => Part = part;

    public IPackagePart Part { get; }
}
