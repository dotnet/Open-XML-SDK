// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
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
    IPackageRelationship Create(Uri targetUri, TargetMode targetMode, string relationshipType, string? id = null);

    /// <summary>
    /// Deletes the specified relationship.
    /// </summary>
    /// <param name="id">The id of the relationship.</param>
    void Remove(string id);

    /// <summary>
    /// Gets a relationship by id.
    /// </summary>
    /// <param name="id">Id of relationship</param>
    /// <returns>A package relationship</returns>
    IPackageRelationship this[string id] { get; }

    /// <summary>
    /// Indicates whether a relationship with a given ID is defined.
    /// </summary>
    /// <param name="id">The id of the relationship</param>
    /// <returns>true if a relationship exists; otherwise, no.</returns>
    bool Contains(string id);
}
