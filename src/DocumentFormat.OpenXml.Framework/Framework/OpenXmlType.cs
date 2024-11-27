// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Framework;

internal readonly struct OpenXmlType(OpenXmlQualifiedName name, OpenXmlQualifiedName type) : IComparable<OpenXmlType>, IEquatable<OpenXmlType>
{
    public OpenXmlQualifiedName Name => name;

    public OpenXmlQualifiedName Type => type;

    public int CompareTo(OpenXmlType other)
    {
        var nameCompare = Name.CompareTo(other.Name);

        if (nameCompare != 0)
        {
            return nameCompare;
        }

        return Type.CompareTo(other.Type);
    }

    public bool Equals(OpenXmlType other) => Equals(Name, other.Name) && Equals(Type, other.Type);

    public override bool Equals(object? obj) => obj is OpenXmlType t && Equals(t);

    public override string ToString() => $"{Type}/{Name}";

    public override int GetHashCode()
    {
        var hc = default(HashCode);

        hc.Add(Name);
        hc.Add(Type);

        return hc.ToHashCode();
    }

    public static bool operator ==(OpenXmlType left, OpenXmlType right) => left.Equals(right);

    public static bool operator !=(OpenXmlType left, OpenXmlType right) => !left.Equals(right);

    public static bool operator <(OpenXmlType left, OpenXmlType right) => left.CompareTo(right) < 0;

    public static bool operator >(OpenXmlType left, OpenXmlType right) => left.CompareTo(right) > 0;

    public static bool operator <=(OpenXmlType left, OpenXmlType right) => left.CompareTo(right) <= 0;

    public static bool operator >=(OpenXmlType left, OpenXmlType right) => left.CompareTo(right) >= 0;
}
