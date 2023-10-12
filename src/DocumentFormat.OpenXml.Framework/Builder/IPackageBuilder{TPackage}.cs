// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Builder;

internal delegate void PackageInitializerDelegate<TPackage>(TPackage package);

internal interface IPackageBuilder<TPackage>
    where TPackage : OpenXmlPackage
{
    /// <summary>
    /// Create an instance of the <typeparamref name="TPackage"/> package.
    /// </summary>
    /// <returns>A <typeparamref name="TPackage"/> instance.</returns>
    TPackage Create();

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
    /// <returns>The pipeline to initialize a package.</returns>
    PackageInitializerDelegate<TPackage> Build();
}
