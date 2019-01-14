﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal readonly struct PartConstraintRule
    {
        private readonly TypeConstraintInfo _info;

        private PartConstraintRule(
            TypeConstraintInfo info,
            bool minOccursIsNonZero,
            bool maxOccursGreatThanOne)
        {
            _info = info;

            MinOccursIsNonZero = minOccursIsNonZero;
            MaxOccursGreatThanOne = maxOccursGreatThanOne;
        }

        public static PartConstraintRule Create(Type type, bool minOccursIsNonZero, bool maxOccursGreatThanOne)
        {
            return new PartConstraintRule(TypeConstraintInfo.Get(type), minOccursIsNonZero, maxOccursGreatThanOne);
        }

        /// <summary>
        /// Gets the relationship type.
        /// </summary>
        public string RelationshipType => _info.RelationshipType;

        /// <summary>
        /// Gets the class name for the relationship type.
        /// </summary>
        public string PartClassName => _info.PartClassName;

        /// <summary>
        /// Gets the content type of the part. Some types with fixed content types have
        /// same relationship type but different content type.
        /// </summary>
        /// <remarks>This value is null for non-fixed content type.</remarks>
        public string PartContentType => _info.PartContentType;

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
        public FileFormatVersions FileFormat => _info.Availability;
    }
}
