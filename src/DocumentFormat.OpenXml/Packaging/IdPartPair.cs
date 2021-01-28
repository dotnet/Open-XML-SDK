// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

#if !NET5_0
using DocumentFormat.OpenXml.Framework;
#endif

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents a (RelationshipId, OpenXmlPart) pair.
    /// </summary>
    public class IdPartPair : IEquatable<IdPartPair>
    {
        /// <summary>
        /// Gets or sets the relationship ID in the pair.
        /// </summary>
        public string RelationshipId
        {
            get;
            [Obsolete("This object will be made immutable in a future release. Please use a new instance.")]
            set;
        }

        /// <summary>
        /// Gets or sets the OpenXmlPart in the pair.
        /// </summary>
        public OpenXmlPart OpenXmlPart
        {
            get;
            [Obsolete("This object will be made immutable in a future release. Please use a new instance.")]
            set;
        }

        /// <summary>
        /// Initializes a new instance of the IdPartPair with the specified id and part.
        /// </summary>
        /// <param name="id">The relationship ID.</param>
        /// <param name="part">The OpenXmlPart.</param>
        public IdPartPair(string id, OpenXmlPart part)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            RelationshipId = id;
            OpenXmlPart = part;
#pragma warning restore CS0618 // Type or member is obsolete
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj) => obj is IdPartPair other && Equals(other);

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            var code = new HashCode();

            code.Add(RelationshipId, StringComparer.Ordinal);

            return code.ToHashCode();
        }

        /// <inheritdoc/>
        public bool Equals(IdPartPair? value)
        {
            //Check for null
            if (value is null)
            {
                return false;
            }

            if (ReferenceEquals(this, value))
            {
                return true;
            }

            return string.Equals(RelationshipId, value.RelationshipId, StringComparison.Ordinal) && (OpenXmlPart == value.OpenXmlPart);
        }
    }
}
