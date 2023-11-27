// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Framework;

/// <summary>
/// A structure that defines a fully qualified name with a namespace and name.
/// </summary>
[Experimental(ExperimentalApis.Framework, UrlFormat = ExperimentalApis.UrlFormat)]
[Obsolete(ExperimentalApis.Message, DiagnosticId = ExperimentalApis.Framework, UrlFormat = ExperimentalApis.UrlFormat)]
public readonly struct OpenXmlQualifiedName : IComparable<OpenXmlQualifiedName>, IEquatable<OpenXmlQualifiedName>
{
    internal OpenXmlQualifiedName(in OpenXmlNamespace ns, string name)
    {
        Namespace = ns;
        Name = name;
    }

    /// <summary>
    /// Gets the namespace of the qualified name.
    /// </summary>
    public OpenXmlNamespace Namespace { get; }

    /// <summary>
    /// Gets the name of the qualified name.
    /// </summary>
    public string Name { get; }

    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is OpenXmlQualifiedName qname && Equals(qname);

    /// <inheritdoc/>
    public int CompareTo(OpenXmlQualifiedName other)
    {
        var nsCompare = Namespace.CompareTo(other.Namespace);

        if (nsCompare != 0)
        {
            return nsCompare;
        }

        return string.CompareOrdinal(Name, other.Name);
    }

    /// <inheritdoc/>
    public override string ToString() => Namespace.IsEmpty ? Name : string.Concat(Namespace.ToString(), ":", Name);

    /// <inheritdoc/>
    public bool Equals(OpenXmlQualifiedName other)
        => Namespace.Equals(other.Namespace)
        && string.Equals(Name, other.Name, StringComparison.Ordinal);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hashcode = default(HashCode);

        hashcode.Add(Namespace);
        hashcode.Add(Name, StringComparer.Ordinal);

        return hashcode.ToHashCode();
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static bool operator ==(OpenXmlQualifiedName left, OpenXmlQualifiedName right) => left.Equals(right);

    public static bool operator !=(OpenXmlQualifiedName left, OpenXmlQualifiedName right) => !(left == right);

    public static bool operator <(OpenXmlQualifiedName left, OpenXmlQualifiedName right) => left.CompareTo(right) < 0;

    public static bool operator <=(OpenXmlQualifiedName left, OpenXmlQualifiedName right) => left.CompareTo(right) <= 0;

    public static bool operator >(OpenXmlQualifiedName left, OpenXmlQualifiedName right) => left.CompareTo(right) > 0;

    public static bool operator >=(OpenXmlQualifiedName left, OpenXmlQualifiedName right) => left.CompareTo(right) >= 0;
}
