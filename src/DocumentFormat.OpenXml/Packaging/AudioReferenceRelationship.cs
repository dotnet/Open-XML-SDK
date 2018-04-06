// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents an internal audio reference relationship to a MediaDataPart element.
    /// </summary>
    public class AudioReferenceRelationship : DataPartReferenceRelationship
    {
        /// <summary>
        /// Represents the fixed value of the RelationshipType.
        /// </summary>
        internal const string RelationshipTypeConst = @"http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio";

        /// <summary>
        /// Gets the source relationship type for an audio reference.
        /// </summary>
        public static string AudioReferenceRelationshipType
        {
            get { return RelationshipTypeConst; }
        }

        /// <summary>
        /// Initializes a new instance of the AudioReferenceRelationship.
        /// </summary>
        /// <remarks>
        /// A call to Initialize() must be made after calling this constructor.
        /// </remarks>
        internal AudioReferenceRelationship()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AudioReferenceRelationship using the supplied
        /// MediaDataPart and relationship ID.
        /// </summary>
        /// <param name="mediaDataPart">The target DataPart of the reference relationship.</param>
        /// <param name="id">The relationship ID.</param>
        internal protected AudioReferenceRelationship(MediaDataPart mediaDataPart, string id)
            : base(mediaDataPart, RelationshipTypeConst, id)
        {
        }

        /// <summary>
        /// Gets the relationship type for an audio reference.
        /// </summary>
        public override string RelationshipType
        {
            get { return RelationshipTypeConst; }
        }
    }
}
