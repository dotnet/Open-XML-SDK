// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging;

internal interface IRelationshipCollection : IEnumerable<IPackageRelationship>, IReadOnlyCollection<IPackageRelationship>
{
    /// <summary>
    /// Creates a relationship to a part with a given URI, target mode, relationship type, and (optional) identifier.
    /// </summary>
    /// <param name="targetUri">The URI of the target part</param>
    /// <param name="targetMode">Indicates if the target part is internal or external to the package.</param>
    /// <param name="relationshipType">A URI that uniquely defines the role of the relationship</param>
    /// <param name="id">A unique XML identifier</param>
    /// <returns>The relationship to the specified part.</returns>
    IPackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType, string? id = null);

    /// <summary>
    /// Deletes the specified relationship.
    /// </summary>
    /// <param name="id">The id of the relationship.</param>
    void DeleteRelationship(string id);

    /// <summary>
    /// Gets a relationship by id.
    /// </summary>
    /// <param name="id">Id of relationship</param>
    /// <returns>A package relationship</returns>
    IPackageRelationship GetRelationship(string id);

    /// <summary>
    /// Indicates whether a relationship with a given ID is defined.
    /// </summary>
    /// <param name="id">The id of the relationship</param>
    /// <returns>true if a relationship exists; otherwise, no.</returns>
    bool RelationshipExists(string id);
}

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
