// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;

namespace DocumentFormat.OpenXml.Packaging.Builder;

internal abstract class DelegatingPackagePart : IPackagePart
{
    protected DelegatingPackagePart(IPackage package, IPackagePart part)
    {
        OriginalPart = part;
        Package = package;
    }

    public IPackagePart OriginalPart { get; }

    public IPackage Package { get; }

    public virtual Uri Uri => OriginalPart.Uri;

    public virtual string ContentType => OriginalPart.ContentType;

    public virtual IRelationshipCollection Relationships => OriginalPart.Relationships;

    public virtual Stream GetStream(FileMode open, FileAccess write)
        => OriginalPart.GetStream(open, write);
}
