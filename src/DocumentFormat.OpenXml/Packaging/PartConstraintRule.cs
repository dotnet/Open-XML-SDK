// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal sealed class PartConstraintRule
    {
        /// <summary>
        /// Gets the class name for the relationship type.
        /// </summary>
        public string PartClassName { get; }

        /// <summary>
        /// Gets the content type of the part. Some types with fixed content types have
        /// same relationship type but different content type.
        /// </summary>
        /// <remarks>This value is null for non-fixed content type.</remarks>
        public string PartContentType { get; }

        /// <summary>
        /// Gets a value indicating whether the min occurs > 0, (i.e. is required).
        /// </summary>
        public bool MinOccursIsNonZero { get; }

        /// <summary>
        /// Gets a value indicating whether max occurs > 1, (i.e. has multiple occurances).
        /// </summary>
        public bool MaxOccursGreatThanOne { get; }

        /// <summary>
        /// Gets the file format version information.
        /// </summary>
        public FileFormatVersions FileFormat { get; }

        /// <summary>
        /// Initialize an instance of <see cref="PartConstraintRule"/>
        /// </summary>
        /// <param name="partClassName">The class name of the part.</param>
        /// <param name="partContentType">The content type of the part.</param>
        /// <param name="minOccursIsNonZero">The MinOccursIsNonZero data.</param>
        /// <param name="maxOccursGreatThanOne">The MaxOccursGreatThanOne data.</param>
        /// <param name="fileFormat">The file format version information.</param>
        public PartConstraintRule(
            string partClassName,
            string partContentType,
            bool minOccursIsNonZero,
            bool maxOccursGreatThanOne,
            FileFormatVersions fileFormat)
        {
            PartClassName = partClassName;
            PartContentType = partContentType;
            MinOccursIsNonZero = minOccursIsNonZero;
            MaxOccursGreatThanOne = maxOccursGreatThanOne;
            FileFormat = fileFormat;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is PartConstraintRule other)
            {
                return string.Equals(PartClassName, other.PartClassName, StringComparison.Ordinal)
                    && string.Equals(PartContentType, other.PartContentType, StringComparison.Ordinal)
                    && MinOccursIsNonZero == other.MinOccursIsNonZero
                    && MaxOccursGreatThanOne == other.MaxOccursGreatThanOne
                    && FileFormat == other.FileFormat;
            }

            return false;
        }

        public override int GetHashCode()
        {
            const int HashMultiplier = 31;

            unchecked
            {
                int hash = 17;
                hash = hash * HashMultiplier + StringComparer.Ordinal.GetHashCode(PartClassName);
                hash = hash * HashMultiplier + StringComparer.Ordinal.GetHashCode(PartContentType);
                hash = hash * HashMultiplier + MinOccursIsNonZero.GetHashCode();
                hash = hash * HashMultiplier + MaxOccursGreatThanOne.GetHashCode();
                hash = hash * HashMultiplier + FileFormat.GetHashCode();
                return hash;
            }
        }
    }
}
