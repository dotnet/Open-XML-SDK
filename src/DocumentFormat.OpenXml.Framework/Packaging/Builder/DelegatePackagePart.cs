// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging.Builder;

internal abstract class DelegatePackagePart : IPackagePart
{
    protected DelegatePackagePart(IPackage package, IPackagePart part)
    {
        OriginalPart = part;
        Package = package;
    }

    public IPackagePart OriginalPart { get; }

    public IPackage Package { get; }

    public virtual Uri Uri => OriginalPart.Uri;

    public virtual string ContentType => OriginalPart.ContentType;

    public virtual IPackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType, string? id = null)
        => OriginalPart.CreateRelationship(targetUri, targetMode, relationshipType, id);

    public virtual void DeleteRelationship(string id)
        => OriginalPart.DeleteRelationship(id);

    public virtual IPackageRelationship GetRelationship(string id)
        => OriginalPart.GetRelationship(id);

    public virtual IEnumerable<IPackageRelationship> GetRelationships()
        => OriginalPart.GetRelationships();

    public virtual Stream GetStream(FileMode open, FileAccess write)
        => OriginalPart.GetStream(open, write);

    public virtual bool RelationshipExists(string id)
        => OriginalPart.RelationshipExists(id);
}
