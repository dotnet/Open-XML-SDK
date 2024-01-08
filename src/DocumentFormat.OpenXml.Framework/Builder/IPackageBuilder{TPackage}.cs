// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Builder;

/// <summary>
/// A delegate for initializing a package.
/// </summary>
internal delegate void PackageInitializerDelegate<TPackage>(TPackage package);

/// <summary>
/// Defines a builder to create an initialization pipeline for a <typeparamref name="TPackage"/>.
/// </summary>
/// <typeparam name="TPackage">Type of the <see cref="OpenXmlPackage"/>.</typeparam>
[Experimental(ExperimentalApis.PackageBuilder, UrlFormat = ExperimentalApis.UrlFormat)]
[Obsolete(ExperimentalApis.Message, DiagnosticId = ExperimentalApis.PackageBuilder, UrlFormat = ExperimentalApis.UrlFormat)]
internal interface IPackageBuilder<TPackage>
    where TPackage : OpenXmlPackage
{
    /// <summary>
    /// Gets a key/value collection that can be used to share data between middleware.
    /// </summary>
    IDictionary<string, object?> Properties { get; }

    /// <summary>
    /// Add middleware to the package builder.
    /// </summary>
    /// <param name="configure">The middleware to add.</param>
    /// <returns>The <see cref="IPackageBuilder{TPackage}"/>.</returns>
    IPackageBuilder<TPackage> Use(Func<PackageInitializerDelegate<TPackage>, PackageInitializerDelegate<TPackage>> configure);

    /// <summary>
    /// Create a copy of the builder that will be independent of the original, but retains the existing middleware and properties.
    /// </summary>
    /// <returns>A new <see cref="IPackageBuilder{TPackage}"/>.</returns>
    IPackageBuilder<TPackage> Clone();

    /// <summary>
    /// Builds the pipeline to initialize the package. Additional calls to this will return the cached pipeline unless
    /// more middleware has been added.
    /// </summary>
    /// <returns>The a <see cref="IPackageFactory{TPackage}"/> with the registered middleware.</returns>
    IPackageFactory<TPackage> Build();
}
