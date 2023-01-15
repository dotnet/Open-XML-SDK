// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// An interface that defines the relationship between a source and a target part. Similar to <see cref="PackageRelationship"/> but allows full overriding.
/// </summary>
internal interface IPackageRelationship
{
    /// <summary>
    /// Gets a unique identifier across relationships for the given source.
    /// </summary>
    string Id { get; }

    /// <summary>
    /// Gets the type of the relationship used to uniquely define the role of the relationship.
    /// </summary>
    string RelationshipType { get; }

    /// <summary>
    /// Gets a reference to the parent PackagePart to which this relationship belongs.
    /// </summary>
    Uri SourceUri { get; }

    /// <summary>
    /// Gets a value indicating the interpretations of the "base" of the target uri.
    /// </summary>
    TargetMode TargetMode { get; }

    /// <summary>
    /// Gets the uri of the part that this relationship points to.
    /// </summary>
    Uri TargetUri { get; }
}
