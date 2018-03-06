// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the base class for PackageRelationshipPropertyCollection and PackagePartRelationshipPropertyCollection objects.
    /// </summary>
    abstract internal class RelationshipCollection : List<RelationshipProperty>
    {
        protected PackageRelationshipCollection BasePackageRelationshipCollection { get; set; }

        internal bool StrictTranslation { get; set; }

        /// <summary>
        /// This method fills the collection with PackageRels from the PackageRelationshipCollection that is given in the sub class.
        /// </summary>
        protected void Build()
        {
            foreach (PackageRelationship relationship in BasePackageRelationshipCollection)
            {
                bool found;
                string transitionalNamespace;
                RelationshipProperty relationshipProperty;

                relationshipProperty.TargetUri = relationship.TargetUri;
                relationshipProperty.TargetMode = relationship.TargetMode;
                relationshipProperty.Id = relationship.Id;
                relationshipProperty.RelationshipType = relationship.RelationshipType;

                // If packageRel.RelationshipType is something for Strict, it tries to get the equivalent in Transitional.
                found = NamespaceIdMap.TryGetTransitionalRelationship(relationshipProperty.RelationshipType, out transitionalNamespace);
                if (found)
                {
                    relationshipProperty.RelationshipType = transitionalNamespace;
                    StrictTranslation = true;
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

        abstract internal void ReplaceRelationship(Uri targetUri, TargetMode targetMode, string strRelationshipType, string strId);

        abstract internal Package GetPackage();
    }
}
