// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework;

internal readonly struct OpenXmlSchemaType(OpenXmlQualifiedName name, OpenXmlQualifiedName type) : IComparable<OpenXmlSchemaType>, IEquatable<OpenXmlSchemaType>
{
    public OpenXmlQualifiedName Name => name;

    public OpenXmlQualifiedName Type => type;

    public int CompareTo(OpenXmlSchemaType other)
    {
        var nameCompare = Name.CompareTo(other.Name);

        if (nameCompare != 0)
        {
            return nameCompare;
        }

        return Type.CompareTo(other.Type);
    }

    // Call the IEquatable<OpenXmlQualifiedName> overload directly: the static object.Equals(object, object) would box both
    // structs on every comparison, and this runs for every child in the typed child-property getters and setters.
    public bool Equals(OpenXmlSchemaType other) => Name.Equals(other.Name) && Type.Equals(other.Type);

    public override bool Equals(object? obj) => obj is OpenXmlSchemaType t && Equals(t);

    public override string ToString() => $"{Type}/{Name}";

    public override int GetHashCode()
    {
        var hc = default(HashCode);

        hc.Add(Name);
        hc.Add(Type);

        return hc.ToHashCode();
    }

    public static bool operator ==(OpenXmlSchemaType left, OpenXmlSchemaType right) => left.Equals(right);

    public static bool operator !=(OpenXmlSchemaType left, OpenXmlSchemaType right) => !left.Equals(right);

    public static bool operator <(OpenXmlSchemaType left, OpenXmlSchemaType right) => left.CompareTo(right) < 0;

    public static bool operator >(OpenXmlSchemaType left, OpenXmlSchemaType right) => left.CompareTo(right) > 0;

    public static bool operator <=(OpenXmlSchemaType left, OpenXmlSchemaType right) => left.CompareTo(right) <= 0;

    public static bool operator >=(OpenXmlSchemaType left, OpenXmlSchemaType right) => left.CompareTo(right) >= 0;
}
