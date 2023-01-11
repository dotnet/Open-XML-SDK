// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging;

internal sealed class PackagePartImpl : IPackagePart, IPackagePartFeature
{
    private readonly PackageImpl _package;

    public PackagePartImpl(PackageImpl package, PackagePart part)
    {
        _package = package;
        Part = part;
    }

    public PackagePart Part { get; }

    public IPackage Package => _package;

    public Uri Uri => Part.Uri;

    public string ContentType => Part.ContentType;

    IPackagePart IPackagePartFeature.Part => this;

    public void DeleteRelationship(string id) => Part.DeleteRelationship(id);

    public IEnumerable<IPackageRelationship> GetRelationships() => Part.GetRelationships().Select(_package.GetOrCreate);

    public Stream GetStream(FileMode open, FileAccess write) => Part.GetStream(open, write);

    public IPackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType, string? id)
        => _package.GetOrCreate(Part.CreateRelationship(targetUri, targetMode, relationshipType, id));

    public bool RelationshipExists(string relationship) => Part.RelationshipExists(relationship);

    public IPackageRelationship GetRelationship(string id) => _package.GetOrCreate(Part.GetRelationship(id));
}
