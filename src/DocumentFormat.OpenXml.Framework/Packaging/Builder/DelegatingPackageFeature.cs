// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging.Builder;

internal abstract class DelegatingPackageFeature : IPackage, IPackageFeature
{
    protected DelegatingPackageFeature(IPackageFeature package)
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

    public virtual void DeletePart(Uri uri) => Package.DeletePart(uri);

    public virtual IPackagePart GetPart(Uri uriTarget) => Package.GetPart(uriTarget);

    public virtual IEnumerable<IPackagePart> GetParts() => Package.GetParts();

    public virtual bool PartExists(Uri partUri) => Package.PartExists(partUri);

    public virtual void Save() => Package.Save();

    public virtual PackageCapabilities Capabilities => Feature.Capabilities;

    public virtual IRelationshipCollection Relationships => Package.Relationships;

    public void Reload(FileMode? mode = null, FileAccess? access = null)
        => Feature.Reload(mode, access);
}
