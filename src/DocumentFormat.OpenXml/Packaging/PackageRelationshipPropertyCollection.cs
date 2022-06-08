// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents a collection of relationships that are obtained from the package.
    /// </summary>
    internal class PackageRelationshipPropertyCollection : RelationshipCollection
    {
        public Package Package { get; }

        public PackageRelationshipPropertyCollection(Package package)
            : base(package.GetRelationships())
        {
            Package = package;
        }

        internal override void ReplaceRelationship(Uri targetUri, TargetMode targetMode, string strRelationshipType, string strId)
        {
            Package.DeleteRelationship(strId);
            Package.CreateRelationship(targetUri, targetMode, strRelationshipType, strId);
        }

        internal override Package GetPackage()
        {
            return Package;
        }
    }
}
