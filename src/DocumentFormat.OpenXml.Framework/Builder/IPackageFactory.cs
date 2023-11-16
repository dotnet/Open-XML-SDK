// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Builder;

/// <summary>
/// Defines a factory to create a <typeparamref name="TPackage"/>.
/// </summary>
/// <typeparam name="TPackage">Type of the <see cref="OpenXmlPackage"/>.</typeparam>
[Obsolete(ExperimentalApis.Message, DiagnosticId = ExperimentalApis.PackageBuilder, UrlFormat = ExperimentalApis.UrlFormat)]
public interface IPackageFactory<TPackage>
{
    /// <summary>
    /// Create an instance of <typeparamref name="TPackage"/>.
    /// </summary>
    /// <param name="initializer">Initializer for the package.</param>
    /// <returns>The created package.</returns>
    TPackage Create(IPackageInitializer initializer);
}
