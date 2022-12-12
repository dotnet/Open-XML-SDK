// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the base class for PackageRelationshipPropertyCollection and PackagePartRelationshipPropertyCollection objects.
    /// </summary>
    internal abstract class RelationshipCollection : List<RelationshipProperty>
    {
        protected PackageRelationshipCollection BasePackageRelationshipCollection { get; }

        internal bool StrictRelationshipFound { get; set; }

        public RelationshipCollection(PackageRelationshipCollection collection, IOpenXmlNamespaceResolver resolver)
        {
            BasePackageRelationshipCollection = collection;

            Build(resolver);
        }

        /// <summary>
        /// This method fills the collection with PackageRels from the PackageRelationshipCollection that is given in the sub class.
        /// </summary>
        private void Build(IOpenXmlNamespaceResolver resolver)
        {
            foreach (PackageRelationship relationship in BasePackageRelationshipCollection)
            {
                RelationshipProperty relationshipProperty;

                relationshipProperty.TargetUri = relationship.TargetUri;
                relationshipProperty.TargetMode = relationship.TargetMode;
                relationshipProperty.Id = relationship.Id;
                relationshipProperty.RelationshipType = relationship.RelationshipType;

                var ns = new OpenXmlNamespace(relationshipProperty.RelationshipType);

                // If packageRel.RelationshipType is something for Strict, it tries to get the equivalent in Transitional.
                if (resolver.TryGetTransitionalRelationship(ns, out var transitionalNamespace))
                {
                    relationshipProperty.RelationshipType = transitionalNamespace.Uri;
                    StrictRelationshipFound = true;
                }

                Add(relationshipProperty);
            }
        }

        internal void UpdateRelationshipTypesInPackage()
        {
            // Update the relationshipTypes when editable.
            if (GetPackage().FileOpenAccess != FileAccess.Read)
            {
                for (int index = 0; index < Count; index++)
                {
                    RelationshipProperty relationshipProperty = this[index];
                    ReplaceRelationship(relationshipProperty.TargetUri, relationshipProperty.TargetMode, relationshipProperty.RelationshipType, relationshipProperty.Id);
                }
            }
        }

        internal abstract void ReplaceRelationship(Uri targetUri, TargetMode targetMode, string strRelationshipType, string strId);

        internal abstract Package GetPackage();
    }
}
