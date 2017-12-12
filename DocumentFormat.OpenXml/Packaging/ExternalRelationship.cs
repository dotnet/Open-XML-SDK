// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
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
}
