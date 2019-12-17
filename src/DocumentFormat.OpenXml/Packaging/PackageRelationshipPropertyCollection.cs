// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents a collection of relationships that are obtained from the package.
    /// </summary>
    internal class PackageRelationshipPropertyCollection : RelationshipCollection
    {
        private readonly Package _package;

        private protected override PackageRelationshipCollection Relationships
            => _package.GetRelationships();

        public PackageRelationshipPropertyCollection(Package package)
        {
            if (package is null)
            {
                throw new ArgumentNullException(nameof(package));
            }

            _package = package;
        }

        private protected override void ReplaceRelationship(Uri targetUri, TargetMode targetMode, string strRelationshipType, string strId)
        {
            _package.DeleteRelationship(strId);
            _package.CreateRelationship(targetUri, targetMode, strRelationshipType, strId);
        }

        private protected override Package Package => _package;
    }
}
