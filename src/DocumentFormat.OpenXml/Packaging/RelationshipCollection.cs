// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
    abstract internal class RelationshipCollection
    {
        private readonly Lazy<Result> _parsed;

        public bool StrictTranslation => _parsed.Value.IsStrictTranslation;

        private protected abstract PackageRelationshipCollection Relationships { get; }

        private protected abstract Package Package { get; }

        public RelationshipCollection()
        {
            _parsed = new Lazy<Result>(Build, true);
        }

        /// <summary>
        /// This method fills the collection with PackageRels from the PackageRelationshipCollection that is given in the sub class.
        /// </summary>
        private Result Build()
        {
            var list = new List<RelationshipProperty>();
            var isStrictTranslation = false;

            foreach (var relationship in Relationships)
            {
                var relationshipProperty = new RelationshipProperty
                {
                    TargetUri = relationship.TargetUri,
                    TargetMode = relationship.TargetMode,
                    Id = relationship.Id,
                    RelationshipType = relationship.RelationshipType,
                };

                // If packageRel.RelationshipType is something for Strict, it tries to get the equivalent in Transitional.
                if (NamespaceIdMap.TryGetTransitionalRelationship(relationshipProperty.RelationshipType, out var transitionalNamespace))
                {
                    relationshipProperty.RelationshipType = transitionalNamespace;
                    isStrictTranslation = true;
                }

                list.Add(relationshipProperty);
            }

            return new Result(list, isStrictTranslation);
        }

        internal void UpdateRelationshipTypesInPackage()
        {
            // Update the relationshipTypes when editable.
            if (Package.FileOpenAccess != FileAccess.Read)
            {
                var list = _parsed.Value.Value;

                for (int index = 0; index < list.Count; index++)
                {
                    var relationshipProperty = list[index];
                    ReplaceRelationship(relationshipProperty.TargetUri, relationshipProperty.TargetMode, relationshipProperty.RelationshipType, relationshipProperty.Id);
                }
            }
        }

        private protected abstract void ReplaceRelationship(Uri targetUri, TargetMode targetMode, string strRelationshipType, string strId);

        public List<RelationshipProperty>.Enumerator GetEnumerator() => _parsed.Value.Value.GetEnumerator();

        private readonly struct Result
        {
            public Result(List<RelationshipProperty> value, bool isStrictTranslation)
            {
                Value = value;
                IsStrictTranslation = isStrictTranslation;
            }

            public List<RelationshipProperty> Value { get; }

            public bool IsStrictTranslation { get; }
        }
    }
}
