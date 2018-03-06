// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines a reference relationship. A reference relationship can be internal or external.
    /// </summary>
    public abstract class ReferenceRelationship
    {
        /// <summary>
        /// Initializes a new instance of the ReferenceRelationship.
        /// </summary>
        /// <remarks>
        /// Must call Initialize() after calling this constructor.
        /// </remarks>
        internal ReferenceRelationship()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ReferenceRelationship.
        /// </summary>
        /// <param name="packageRelationship">The source PackageRelationship.</param>
        internal protected ReferenceRelationship(PackageRelationship packageRelationship)
        {
            Debug.Assert(packageRelationship != null);

            RelationshipType = packageRelationship.RelationshipType;
            Uri = packageRelationship.TargetUri;
            IsExternal = packageRelationship.TargetMode == TargetMode.External;
            Id = packageRelationship.Id;
        }

        /// <summary>
        /// Initializes a new instance of the ReferenceRelationship.
        /// </summary>
        /// <param name="relationshipType">The relationship type of the relationship.</param>
        /// <param name="targetUri">The target uri of the relationship.</param>
        /// <param name="id">The relationship ID.</param>
        /// <param name="isExternal">A value that indicates whether the target of the relationship is Internal or External to the Package.</param>
        internal protected ReferenceRelationship(Uri targetUri, bool isExternal, string relationshipType, string id)
        {
            Debug.Assert(targetUri != null);
            Debug.Assert(!string.IsNullOrEmpty(relationshipType));
            Debug.Assert(!string.IsNullOrEmpty(id));

            RelationshipType = relationshipType;
            Uri = targetUri;
            Id = id;
            IsExternal = isExternal;
        }

        /// <summary>
        /// Gets the owner <see cref="OpenXmlPartContainer"/> that holds the <see cref="ReferenceRelationship"/>.
        /// </summary>
        public OpenXmlPartContainer Container { get; internal set; }

        /// <summary>
        /// Gets the relationship type.
        /// </summary>
        public virtual string RelationshipType { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the target of the relationship is Internal or External to the <see cref="OpenXmlPackage"/>.
        /// </summary>
        public virtual bool IsExternal { get; private set; }

        /// <summary>
        /// Gets the relationship ID.
        /// </summary>
        public virtual string Id { get; private set; }

        /// <summary>
        /// Gets the target URI of the relationship.
        /// </summary>
        public virtual Uri Uri { get; private set; }

        /// <summary>
        /// Initializes this instance of the ReferenceRelationship.
        /// </summary>
        /// <param name="relationshipType">The relationship type of the relationship.</param>
        /// <param name="targetUri">The target uri of the relationship.</param>
        /// <param name="id">The relationship ID.</param>
        /// <param name="isExternal">A value that indicates whether the target of the relationship is Internal or External to the Package.</param>
        internal void Initialize(Uri targetUri, bool isExternal, string relationshipType, string id)
        {
            Debug.Assert(targetUri != null);
            Debug.Assert(!string.IsNullOrEmpty(relationshipType));
            Debug.Assert(!string.IsNullOrEmpty(id));

            RelationshipType = relationshipType;
            Uri = targetUri;
            Id = id;
            IsExternal = isExternal;
        }
    }
}
