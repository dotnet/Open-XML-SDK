// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging.Builder;

/// <summary>
/// A mutable instance of a package relationship used while building the final relationship
/// </summary>
internal sealed class PackageRelationshipBuilder : IPackageRelationship
{
    internal PackageRelationshipBuilder(Uri partUri, PackageRelationship relationship)
    {
        Id = relationship.Id;
        RelationshipType = relationship.RelationshipType;
        SourceUri = relationship.SourceUri;
        TargetMode = relationship.TargetMode;
        TargetUri = relationship.TargetUri;
        PartUri = partUri;
    }

    public Uri PartUri { get; }

    /// <summary>
    /// Gets or sets the id of the relationship.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the relationship type.
    /// </summary>
    public string RelationshipType { get; set; }

    /// <summary>
    /// Gets or sets the source URI.
    /// </summary>
    public Uri SourceUri { get; set; }

    /// <summary>
    /// Gets or sets the target mode.
    /// </summary>
    public TargetMode TargetMode { get; set; }

    /// <summary>
    /// Gets or sets the target uri.
    /// </summary>
    public Uri TargetUri { get; set; }

    internal bool IsRemoved { get; set; }
}
