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
        public Package BasePackage { get; set; }

        public PackageRelationshipPropertyCollection(Package package)
        {
            BasePackage = package;
            if (BasePackage == null)
            {
                throw new ArgumentNullException(nameof(BasePackage));
            }

            BasePackageRelationshipCollection = BasePackage.GetRelationships();
            Build();
        }

        internal override void ReplaceRelationship(Uri targetUri, TargetMode targetMode, string strRelationshipType, string strId)
        {
            BasePackage.DeleteRelationship(strId);
            BasePackage.CreateRelationship(targetUri, targetMode, strRelationshipType, strId);
        }

        internal override Package GetPackage()
        {
            return BasePackage;
        }
    }
}
