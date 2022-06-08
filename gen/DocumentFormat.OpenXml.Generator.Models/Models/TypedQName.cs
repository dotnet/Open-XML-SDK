// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Generator.Models;

public class TypedQName
{
    public TypedQName(QName type, QName name)
    {
        Type = type;
        QName = name;
    }

    public QName Type { get; }

    public QName QName { get; }

    public override bool Equals(object? obj)
    {
        if (obj is TypedQName other)
        {
            return other.QName.Equals(QName) && other.Type.Equals(Type);
        }

        return false;
    }

    public override int GetHashCode() => QName.GetHashCode() ^ Type.GetHashCode();

    public override string ToString() => $"{Type}/{QName}";
}
