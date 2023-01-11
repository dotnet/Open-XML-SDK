// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// An abstraction for <see cref="System.IO.Packaging.PackagePart"/> that is easier to override.
/// </summary>
public interface IPackagePart
{
    /// <summary>
    /// Gets a reference to the containing package.
    /// </summary>
    IPackage Package { get; }

    /// <summary>
    /// Gets the URI for the current part.
    /// </summary>
    Uri Uri { get; }

    /// <summary>
    /// Gets the MIME type of the content stream.
    /// </summary>
    string ContentType { get; }

    /// <summary>
    /// Gets a relationship with the given id.
    /// </summary>
    /// <param name="id">Id of relationship to get.</param>
    /// <returns>The specified relationship.</returns>
    IPackageRelationship GetRelationship(string id);

    /// <summary>
    /// Gets the data stream for the part.
    /// </summary>
    /// <param name="open">Mode in which to open the stream.</param>
    /// <param name="write">Access mode in which to open the stream.</param>
    /// <returns>A stream for the data of the part.</returns>
    Stream GetStream(FileMode open, FileAccess write);

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
    /// Gets the relationships of the package.
    /// </summary>
    /// <returns>The relationships for package.</returns>
    IEnumerable<IPackageRelationship> GetRelationships();

    /// <summary>
    /// Indicates whether a relationship with a given ID is defined.
    /// </summary>
    /// <param name="id">The id of the relationship</param>
    /// <returns>true if a relationship exists; otherwise, no.</returns>
    bool RelationshipExists(string id);
}
