// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents an internal video reference relationship to a MediaDataPart element.
    /// </summary>
    public class VideoReferenceRelationship : DataPartReferenceRelationship
    {
        /// <summary>
        /// Represents the fixed value of the RelationshipType.
        /// </summary>
        internal const string RelationshipTypeConst = @"http://schemas.openxmlformats.org/officeDocument/2006/relationships/video";

        /// <summary>
        /// Gets the source relationship type for an audio reference.
        /// </summary>
        public static string VideoReferenceRelationshipType
        {
            get { return RelationshipTypeConst; }
        }

        /// <summary>
        /// Initializes a new instance of the VideoReferenceRelationship class.
        /// </summary>
        /// <remarks>
        /// A call to Initialize() must be made after calling this constructor.
        /// </remarks>
        internal VideoReferenceRelationship()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VideoReferenceRelationship class using the supplied
        /// MediaDataPart and relationship ID.
        /// </summary>
        /// <param name="mediaDataPart">The target DataPart of the reference relationship.</param>
        /// <param name="id">The relationship ID.</param>
        internal protected VideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
            : base(mediaDataPart, RelationshipTypeConst, id)
        {
        }

        /// <summary>
        /// Gets the relationship type for a video reference.
        /// </summary>
        public override string RelationshipType
        {
            get { return RelationshipTypeConst; }
        }
    }
}
