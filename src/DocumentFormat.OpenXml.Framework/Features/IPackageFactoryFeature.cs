// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Builder;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Features;

internal interface IPackageFactoryFeature<TPackage>
    where TPackage : OpenXmlPackage
{
    IPackageBuilder<TPackage> Create();
}
