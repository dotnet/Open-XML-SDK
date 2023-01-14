// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging.Builder;

internal abstract class DelegatePackage : IPackage, IPackageFeature
{
    protected DelegatePackage(IPackageFeature package)
    {
        Feature = package;
    }

    protected IPackage Package => Feature.Package;

    protected IPackageFeature Feature { get; }

    public virtual FileAccess FileOpenAccess => Package.FileOpenAccess;

    public virtual PackageProperties PackageProperties => Package.PackageProperties;

    IPackage IPackageFeature.Package => this;

    public virtual IPackagePart CreatePart(Uri partUri, string contentType, CompressionOption compressionOption)
        => Package.CreatePart(partUri, contentType, compressionOption);

    public virtual IPackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType, string? id = null)
        => Package.CreateRelationship(targetUri, targetMode, relationshipType, id);

    public virtual void DeletePart(Uri uri) => Package.DeletePart(uri);

    public virtual void DeleteRelationship(string id) => Package.DeleteRelationship(id);

    public virtual IPackagePart GetPart(Uri uriTarget) => Package.GetPart(uriTarget);

    public virtual IEnumerable<IPackagePart> GetParts() => Package.GetParts();

    public virtual IPackageRelationship GetRelationship(string id)
        => Package.GetRelationship(id);

    public virtual IEnumerable<IPackageRelationship> GetRelationships() => Package.GetRelationships();

    public virtual bool PartExists(Uri partUri) => Package.PartExists(partUri);

    public virtual bool RelationshipExists(string id) => Package.RelationshipExists(id);

    public virtual void Save() => Package.Save();

    public virtual PackageCapabilities Capabilities => Feature.Capabilities;

    public void Reload(FileMode? mode = null, FileAccess? access = null)
        => Feature.Reload(mode, access);
}
