// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System.Net.NetworkInformation;

namespace DocumentFormat.OpenXml.Generator.Models;

public sealed record class QName : IComparable<QName>
{
    public QName(string prefix, string name)
    {
        Prefix = prefix;
        Name = name;
    }

    public string Prefix { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool IsEmpty => string.IsNullOrEmpty(Name);

    public override string ToString() => (Prefix, Name) switch
    {
        (string p, string n) when string.IsNullOrEmpty(p) => n,
        (string p, string n) => $"{p}:{n}",
        (string p, null) => p,
        _ => string.Empty,
    };

    public bool Equals(QName other)
    {
        return string.Equals(Prefix, other.Prefix, StringComparison.Ordinal)
            && string.Equals(Name, other.Name, StringComparison.Ordinal);
    }

    public override int GetHashCode()
    {
        var hash = default(HashCode);

        hash.Add(Prefix, StringComparer.Ordinal);
        hash.Add(Name, StringComparer.Ordinal);

        return hash.ToHashCode();
    }

    public static QName Parse(string input)
    {
        var idx = input.IndexOf(':');

        if (idx < 0)
        {
            return new(string.Empty, input);
        }

        return new(input.Substring(0, idx), input.Substring(idx + 1));
    }

    public int CompareTo(QName other)
    {
        var prefix = Prefix.CompareTo(other.Prefix);

        if (prefix != 0)
        {
            return prefix;
        }

        return Name.CompareTo(other.Name);
    }

    public static implicit operator string(QName qname) => qname.ToString();

    public static implicit operator QName(string qname) => Parse(qname);
}
