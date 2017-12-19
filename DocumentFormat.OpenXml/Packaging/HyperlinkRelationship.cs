// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
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
