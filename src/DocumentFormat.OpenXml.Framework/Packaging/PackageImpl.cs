// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Packaging;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging;

internal sealed class PackageImpl : IPackage, IContainerFeature<Package>, IPackageFeature
{
    private readonly Dictionary<Uri, PackagePartImpl> _parts = new();
    private readonly Dictionary<Uri, PackageRelationshipImpl> _relationships = new();

    private readonly Package _package;

    public PackageImpl(Package package)
    {
        _package = package;
    }

    private IPackagePart GetOrCreatePart(PackagePart part)
    {
        if (_parts.TryGetValue(part.Uri, out var existing))
        {
            Debug.Assert(existing.Part == part);
            return existing;
        }

        var newItem = new PackagePartImpl(this, part);
        _parts[part.Uri] = newItem;
        return newItem;
    }

    FileAccess IPackage.FileOpenAccess => _package.FileOpenAccess;

    IPackage IPackageFeature.Package => this;

    Package IContainerFeature<Package>.Value => _package;

    public PackageProperties PackageProperties => _package.PackageProperties;

    IEnumerable<IPackagePart> IPackage.GetParts()
    {
        foreach (var part in _package.GetParts())
        {
            yield return GetOrCreatePart(part);
        }
    }

    IPackagePart IPackage.GetPart(Uri uriTarget) => GetOrCreatePart(_package.GetPart(uriTarget));

    bool IPackage.PartExists(Uri partUri) => _package.PartExists(partUri);

    void IPackage.Save() => _package.Flush();

    public IPackageRelationship GetOrCreate(PackageRelationship relationship) => new PackageRelationshipImpl(this, relationship);

    public IPackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string? relationshipType, string? id)
    {
        return GetOrCreate(_package.CreateRelationship(targetUri, targetMode, relationshipType, id));
    }

    void IPackage.DeleteRelationship(string id) => _package.DeleteRelationship(id);

    public IEnumerable<IPackageRelationship> GetRelationships() => _package.GetRelationships().Select(GetOrCreate);

    public IPackagePart CreatePart(Uri partUri, string contentType, CompressionOption compressionOption) => GetOrCreatePart(_package.CreatePart(partUri, contentType, compressionOption));

    public bool RelationshipExists(string relationship) => _package.RelationshipExists(relationship);

    public void DeletePart(Uri uri)
    {
        _parts.Remove(uri);
        _package.DeletePart(uri);
    }
}
