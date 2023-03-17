// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Models;

public sealed record class TypedQName
{
    public TypedQName(QName type, QName name)
    {
        Type = type;
        QName = name;
    }

    public QName Type { get; }

    public QName QName { get; }

    public override string ToString() => $"{Type}/{QName}";
}
