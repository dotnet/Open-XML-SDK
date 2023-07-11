// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System;

namespace DocumentFormat.OpenXml.Builder;

internal interface IPackageBuilder<TPackage>
    where TPackage : OpenXmlPackage
{
    TPackage Create();

    IPackageBuilder<TPackage> Use(Func<Action<TPackage>, Action<TPackage>> configure);

    IPackageBuilder<TPackage> New();

    TPackage Open(IPackageInitializer initializer);
}
