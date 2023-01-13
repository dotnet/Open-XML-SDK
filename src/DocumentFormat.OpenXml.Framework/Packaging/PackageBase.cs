// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Packaging;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging;

internal abstract class PackageBase : IPackage
{
    private readonly Dictionary<Uri, PackagePart> _parts = new();

    protected abstract Package Package { get; }

    private IPackagePart GetOrCreatePart(System.IO.Packaging.PackagePart part)
    {
        if (_parts.TryGetValue(part.Uri, out var existing))
        {
            Debug.Assert(existing.Part == part);
            return existing;
        }

        var newItem = new PackagePart(this, part);
        _parts[part.Uri] = newItem;
        return newItem;
    }

    FileAccess IPackage.FileOpenAccess => Package.FileOpenAccess;

    public PackageProperties PackageProperties => Package.PackageProperties;

    IEnumerable<IPackagePart> IPackage.GetParts()
    {
        foreach (var part in Package.GetParts())
        {
            yield return GetOrCreatePart(part);
        }
    }

    IPackagePart IPackage.GetPart(Uri uriTarget) => GetOrCreatePart(Package.GetPart(uriTarget));

    bool IPackage.PartExists(Uri partUri) => Package.PartExists(partUri);

    void IPackage.Save() => Package.Flush();

    public IPackageRelationship GetOrCreate(PackageRelationship relationship) => new PackageRelationshipImpl(this, relationship);

    public IPackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string? relationshipType, string? id)
    {
        return GetOrCreate(Package.CreateRelationship(targetUri, targetMode, relationshipType, id));
    }

    void IPackage.DeleteRelationship(string id) => Package.DeleteRelationship(id);

    public IEnumerable<IPackageRelationship> GetRelationships()
    {
        foreach (var relationship in Package.GetRelationships())
        {
            yield return GetOrCreate(relationship);
        }
    }

    public IPackagePart CreatePart(Uri partUri, string contentType, CompressionOption compressionOption) => GetOrCreatePart(Package.CreatePart(partUri, contentType, compressionOption));

    public bool RelationshipExists(string relationship) => Package.RelationshipExists(relationship);

    public void DeletePart(Uri uri)
    {
        _parts.Remove(uri);
        Package.DeletePart(uri);
    }

    private sealed class PackagePart : IPackagePart
    {
        private readonly PackageBase _package;

        public PackagePart(PackageBase package, System.IO.Packaging.PackagePart part)
        {
            _package = package;
            Part = part;
        }

        public System.IO.Packaging.PackagePart Part { get; }

        public IPackage Package => _package;

        public Uri Uri => Part.Uri;

        public string ContentType => Part.ContentType;

        public void DeleteRelationship(string id) => Part.DeleteRelationship(id);

        public IEnumerable<IPackageRelationship> GetRelationships() => Part.GetRelationships().Select(_package.GetOrCreate);

        public Stream GetStream(FileMode open, FileAccess write) => Part.GetStream(open, write);

        public IPackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType, string? id)
            => _package.GetOrCreate(Part.CreateRelationship(targetUri, targetMode, relationshipType, id));

        public bool RelationshipExists(string relationship) => Part.RelationshipExists(relationship);

        public IPackageRelationship GetRelationship(string id) => _package.GetOrCreate(Part.GetRelationship(id));
    }
}
