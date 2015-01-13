// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;
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

            this.RelationshipType = packageRelationship.RelationshipType;
            this.Uri = packageRelationship.TargetUri;
            this.IsExternal = packageRelationship.TargetMode == TargetMode.External;
            this.Id = packageRelationship.Id;
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

            this.RelationshipType = relationshipType;
            this.Uri = targetUri;
            this.Id = id;
            this.IsExternal = isExternal;
        }

        /// <summary>
        /// Gets the owner <see cref="OpenXmlPartContainer"/> that holds the <see cref="ReferenceRelationship"/>.
        /// </summary>
        public OpenXmlPartContainer Container
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the relationship type.
        /// </summary>
        public virtual string RelationshipType
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a value that indicates whether the target of the relationship is Internal or External to the <see cref="OpenXmlPackage"/>.
        /// </summary>
        public virtual bool IsExternal
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the relationship ID.
        /// </summary>
        public virtual string Id
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the target URI of the relationship.
        /// </summary>
        public virtual Uri Uri
        {
            get;
            private set;
        }

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

            this.RelationshipType = relationshipType;
            this.Uri = targetUri;
            this.Id = id;
            this.IsExternal = isExternal;
        }
         
    }

    /// <summary>
    /// Represents an external relationship.
    /// </summary>
    public class ExternalRelationship : ReferenceRelationship
    {
        /// <summary>
        /// Initializes a new instance of the ExternalRelationship.
        /// </summary>
        /// <param name="externalUri">The target uri of the relationship.</param>
        /// <param name="relationshipType">The relationship type.</param>
        /// <param name="id">The relationship ID.</param>
        internal protected ExternalRelationship(Uri externalUri, string relationshipType, string id)
            : base(externalUri, true, relationshipType, id)
        {
        }
    }

    /// <summary>
    /// Represents a hyperlink relationship.
    /// </summary>
    public class HyperlinkRelationship : ReferenceRelationship
    {
        /// <summary>
        /// The source relationship type for hyperlink. Defined as "http://schemas.openxmlformats.org/officeDocument/2006/relationships/hyperlink".
        /// </summary>
        internal const string RelationshipTypeConst = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/hyperlink";

        /// <summary>
        /// Initializes a new instance of the HyperlinkRelationship.
        /// </summary>
        /// <param name="hyperlinkUri">The target uri of the hyperlink relationship.</param>
        /// <param name="id">The relationship ID.</param>
        /// <param name="isExternal">Is the URI external.</param>
        internal protected HyperlinkRelationship(Uri hyperlinkUri, bool isExternal, string id)
            : base(hyperlinkUri, isExternal, RelationshipTypeConst, id)
        {
        }

        /// <summary>
        /// Gets the relationship type.
        /// </summary>
        public override string RelationshipType
        {
            get { return RelationshipTypeConst; }
        }
    }
}
