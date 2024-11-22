// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Models;

public sealed record class TypedQName : IComparable<TypedQName>
{
    public TypedQName(QName type, QName name)
    {
        Type = type;
        QName = name;
    }

    public QName Type { get; }

    public QName QName { get; }

    public int CompareTo(TypedQName other)
    {
        var first = Type.CompareTo(other.Type);

        if (first != 0)
        {
            return first;
        }

        return QName.CompareTo(other.QName);
    }

    public static TypedQName Parse(string input)
    {
        var split = input.Split('/');

        if (split.Length == 2)
        {
            return new(split[0], split[1]);
        }

        throw new FormatException("Invalid TypedQName");
    }

    public override string ToString() => $"{Type}/{QName}";

    public static implicit operator TypedQName(string typed) => Parse(typed);
}
