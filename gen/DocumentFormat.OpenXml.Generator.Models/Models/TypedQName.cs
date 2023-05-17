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

    public override string ToString() => $"{Type}/{QName}";
}
