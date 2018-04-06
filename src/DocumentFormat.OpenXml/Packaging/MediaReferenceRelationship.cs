// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents an internal media reference relationship to a MediaDataPart element.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public class MediaReferenceRelationship : DataPartReferenceRelationship
    {
        /// <summary>
        /// Represents the fixed value of the RelationshipType.
        /// </summary>
        internal const string RelationshipTypeConst = @"http://schemas.microsoft.com/office/2007/relationships/media";

        /// <summary>
        /// Gets the source relationship type for a media reference.
        /// </summary>
        public static string MediaReferenceRelationshipType
        {
            get { return RelationshipTypeConst; }
        }

        /// <summary>
        /// Initializes a new instance of the MediaReferenceRelationship class.
        /// </summary>
        /// <remarks>
        /// A call to Initialize() must be made after calling this constructor.
        /// </remarks>
        internal MediaReferenceRelationship()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MediaReferenceRelationship class using
        /// the supplied MediaDataPart and relationship ID.
        /// </summary>
        /// <param name="mediaDataPart">The target DataPart of the reference relationship.</param>
        /// <param name="id">The relationship ID.</param>
        internal protected MediaReferenceRelationship(MediaDataPart mediaDataPart, string id)
            : base(mediaDataPart, RelationshipTypeConst, id)
        {
        }

        /// <summary>
        /// Gets the relationship type for a media reference.
        /// </summary>
        public override string RelationshipType
        {
            get { return RelationshipTypeConst; }
        }
    }
}
