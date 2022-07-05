// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework;

internal readonly partial struct OpenXmlNamespace : IComparable<OpenXmlNamespace>, IEquatable<OpenXmlNamespace>
{
    private readonly string? _uri;

    public OpenXmlNamespace(string nsUri)
    {
        _uri = nsUri;
    }

    public string Uri => _uri ?? string.Empty;

    public bool IsEmpty => string.IsNullOrEmpty(Uri);

    public override bool Equals(object? obj) => obj is OpenXmlNamespace ns && Equals(ns);

    public bool Equals(OpenXmlNamespace other)
        => string.Equals(Uri, other.Uri, StringComparison.Ordinal);

    public override int GetHashCode()
    {
        var hashcode = default(HashCode);

        hashcode.Add(Uri, StringComparer.Ordinal);

        return hashcode.ToHashCode();
    }

    public override string ToString() => Uri;

    public int CompareTo(OpenXmlNamespace other)
        => string.CompareOrdinal(Uri, other.Uri);

    public static implicit operator OpenXmlNamespace(string nsUri) => new(nsUri);
}
