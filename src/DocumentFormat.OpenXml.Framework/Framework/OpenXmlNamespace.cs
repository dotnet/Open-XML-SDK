// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Framework;

/// <summary>
/// A structure that defines a namespace.
/// </summary>
[Obsolete(ExperimentalApis.Message, DiagnosticId = ExperimentalApis.Framework, UrlFormat = ExperimentalApis.UrlFormat)]
public readonly partial struct OpenXmlNamespace : IComparable<OpenXmlNamespace>, IEquatable<OpenXmlNamespace>
{
    private readonly string? _uri;

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenXmlNamespace"/> struct.
    /// </summary>
    public OpenXmlNamespace(string nsUri)
    {
        _uri = nsUri;
    }

    /// <summary>
    /// Gets the URI of the namespace
    /// </summary>
    public string Uri => _uri ?? string.Empty;

    /// <summary>
    /// Gets a value indicating whether <see cref="Uri"/> is empty or not.
    /// </summary>
    public bool IsEmpty => string.IsNullOrEmpty(Uri);

    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is OpenXmlNamespace ns && Equals(ns);

    /// <inheritdoc/>
    public bool Equals(OpenXmlNamespace other)
        => string.Equals(Uri, other.Uri, StringComparison.Ordinal);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hashcode = default(HashCode);

        hashcode.Add(Uri, StringComparer.Ordinal);

        return hashcode.ToHashCode();
    }

    /// <inheritdoc/>
    public override string ToString() => Uri;

    /// <inheritdoc/>
    public int CompareTo(OpenXmlNamespace other)
        => string.CompareOrdinal(Uri, other.Uri);

    /// <summary>
    /// Implicitly convert a string to a namespace.
    /// </summary>
    public static implicit operator OpenXmlNamespace(string nsUri) => new(nsUri);

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static bool operator ==(OpenXmlNamespace left, OpenXmlNamespace right) => left.Equals(right);

    public static bool operator !=(OpenXmlNamespace left, OpenXmlNamespace right) => !(left == right);

    public static bool operator <(OpenXmlNamespace left, OpenXmlNamespace right) => left.CompareTo(right) < 0;

    public static bool operator <=(OpenXmlNamespace left, OpenXmlNamespace right) => left.CompareTo(right) <= 0;

    public static bool operator >(OpenXmlNamespace left, OpenXmlNamespace right) => left.CompareTo(right) > 0;

    public static bool operator >=(OpenXmlNamespace left, OpenXmlNamespace right) => left.CompareTo(right) >= 0;
}
