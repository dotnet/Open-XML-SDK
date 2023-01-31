// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

#if !NET5_0_OR_GREATER
using DocumentFormat.OpenXml.Framework;
#endif

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// Represents a (RelationshipId, OpenXmlPart) pair.
/// </summary>
public readonly struct IdPartPair : IEquatable<IdPartPair>
{
    /// <summary>
    /// Initializes a new instance of the IdPartPair with the specified id and part.
    /// </summary>
    /// <param name="id">The relationship ID.</param>
    /// <param name="part">The OpenXmlPart.</param>
    public IdPartPair(string id, OpenXmlPart part)
    {
        RelationshipId = id;
        OpenXmlPart = part;
    }

    /// <summary>
    /// Gets the relationship ID in the pair.
    /// </summary>
    public string RelationshipId { get; }

    /// <summary>
    /// Gets the OpenXmlPart in the pair.
    /// </summary>
    public OpenXmlPart OpenXmlPart { get; }

    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is IdPartPair other && Equals(other);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var code = default(HashCode);

        code.Add(RelationshipId, StringComparer.Ordinal);

        return code.ToHashCode();
    }

    /// <inheritdoc/>
    public bool Equals(IdPartPair other)
        => string.Equals(RelationshipId, other.RelationshipId, StringComparison.Ordinal) && Equals(OpenXmlPart, other.OpenXmlPart);

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static bool operator ==(IdPartPair left, IdPartPair right) => left.Equals(right);

    public static bool operator !=(IdPartPair left, IdPartPair right) => !(left == right);
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
