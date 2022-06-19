// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents a collection of relationships that are obtained from the package part.
    /// </summary>
    internal class PackagePartRelationshipPropertyCollection : RelationshipCollection
    {
        public PackagePart PackagePart { get; }

        public PackagePartRelationshipPropertyCollection(PackagePart packagePart, IOpenXmlNamespaceResolver resolver)
            : base(packagePart.GetRelationships(), resolver)
        {
            PackagePart = packagePart;
        }

        internal override void ReplaceRelationship(Uri targetUri, TargetMode targetMode, string strRelationshipType, string strId)
        {
            PackagePart.DeleteRelationship(strId);
            PackagePart.CreateRelationship(targetUri, targetMode, strRelationshipType, strId);
        }

        internal override Package GetPackage()
        {
            return PackagePart.Package;
        }
    }
}
