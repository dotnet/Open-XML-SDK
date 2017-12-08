// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents a collection of relationships that are obtained from the package part.
    /// </summary>
    internal class PackagePartRelationshipPropertyCollection : RelationshipCollection
    {
        public PackagePart BasePackagePart { get; set; }

        public PackagePartRelationshipPropertyCollection(PackagePart packagePart)
        {
            this.BasePackagePart = packagePart;
            if (this.BasePackagePart == null)
            {
                throw new ArgumentNullException(nameof(BasePackagePart));
            }

            this.BasePackageRelationshipCollection = this.BasePackagePart.GetRelationships();
            this.Build();
        }

        internal override void ReplaceRelationship(Uri targetUri, TargetMode targetMode, string strRelationshipType, string strId)
        {
            this.BasePackagePart.DeleteRelationship(strId);
            this.BasePackagePart.CreateRelationship(targetUri, targetMode, strRelationshipType, strId);
        }

        internal override Package GetPackage()
        {
            return this.BasePackagePart.Package;
        }
    }
}
