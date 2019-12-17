// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents a collection of relationships that are obtained from the package part.
    /// </summary>
    internal class PackagePartRelationshipPropertyCollection : RelationshipCollection
    {
        private readonly PackagePart _part;

        private protected override PackageRelationshipCollection Relationships
            => _part.GetRelationships();

        public PackagePartRelationshipPropertyCollection(PackagePart part)
        {
            if (part is null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            _part = part;
        }

        private protected override void ReplaceRelationship(Uri targetUri, TargetMode targetMode, string strRelationshipType, string strId)
        {
            _part.DeleteRelationship(strId);
            _part.CreateRelationship(targetUri, targetMode, strRelationshipType, strId);
        }

        private protected override Package Package => _part.Package;
    }
}
