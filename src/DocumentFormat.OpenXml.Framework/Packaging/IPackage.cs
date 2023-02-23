// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// An abstraction similar to <see cref="System.IO.Packaging.Package"/> that allows for pass through implementations
/// </summary>
internal interface IPackage
{
    /// <summary>
    /// Gets the file access of the package
    /// </summary>
    FileAccess FileOpenAccess { get; }

    /// <summary>
    /// Gets the core properties of the package
    /// </summary>
    PackageProperties PackageProperties { get; }

    /// <summary>
    /// Returns a collection of parts for the package
    /// </summary>
    /// <returns>A collection of parts.</returns>
    IEnumerable<IPackagePart> GetParts();

    /// <summary>
    /// Gets a part for the given <paramref name="uriTarget"/>.
    /// </summary>
    /// <param name="uriTarget">Uri of target</param>
    /// <returns>Part for given uri.</returns>
    IPackagePart GetPart(Uri uriTarget);

    /// <summary>
    /// Indicates whether a part with a given URI is in the package
    /// </summary>
    /// <param name="partUri">The uri of the part.</param>
    /// <returns>true if a part with the specified <paramref name="partUri"/> exists in the package; otherwise, false.</returns>
    bool PartExists(Uri partUri);

    /// <summary>
    /// Saves the package
    /// </summary>
    void Save();

    /// <summary>
    /// Creates a new part with a given URI, content type, and compression option.
    /// </summary>
    /// <param name="partUri">The URI of the new part.</param>
    /// <param name="contentType">The content type of the data stream.</param>
    /// <param name="compressionOption">The compression option for the data stream.</param>
    /// <returns>The new created part.</returns>
    IPackagePart CreatePart(Uri partUri, string contentType, CompressionOption compressionOption);

    /// <summary>
    /// Deletes a part with a given URI from the package.
    /// </summary>
    /// <param name="uri">The URI fo the part to delete.</param>
    void DeletePart(Uri uri);

    /// <summary>
    /// Gets the relationships of the package.
    /// </summary>
    IRelationshipCollection Relationships { get; }
}
