// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework
{
    internal readonly struct PartConstraintRule
    {
        public PartConstraintRule(
            string relationship,
            string name,
            string? contentType,
            bool minOccursIsNonZero,
            bool maxOccursGreatThanOne,
            FileFormatVersions version)
        {
            RelationshipType = relationship;
#pragma warning disable CS0618 // Type or member is obsolete
            PartClassName = name;
#pragma warning restore CS0618 // Type or member is obsolete
            PartContentType = contentType;
            MinOccursIsNonZero = minOccursIsNonZero;
            MaxOccursGreatThanOne = maxOccursGreatThanOne;
            FileFormat = version;
        }

        /// <summary>
        /// Gets the relationship type.
        /// </summary>
        public string RelationshipType { get; }

        /// <summary>
        /// Gets the class name for the relationship type.
        /// </summary>
        [Obsolete(ObsoleteAttributeMessages.ObsoleteV1ValidationFunctionality, false)]
        public string PartClassName { get; }

        /// <summary>
        /// Gets the content type of the part. Some types with fixed content types have
        /// same relationship type but different content type.
        /// </summary>
        /// <remarks>This value is null for non-fixed content type.</remarks>
        public string? PartContentType { get; }

        /// <summary>
        /// Gets a value indicating whether the min occurs > 0, (i.e. is required).
        /// </summary>
        public bool MinOccursIsNonZero { get; }

        /// <summary>
        /// Gets a value indicating whether max occurs > 1, (i.e. has multiple occurrences).
        /// </summary>
        public bool MaxOccursGreatThanOne { get; }

        /// <summary>
        /// Gets the file format version information.
        /// </summary>
        public FileFormatVersions FileFormat { get; }
    }
}
