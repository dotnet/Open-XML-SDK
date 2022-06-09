// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Models;

public class QName
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

    public override bool Equals(object? obj)
    {
        if (obj is QName other)
        {
            return string.Equals(Prefix, other.Prefix, StringComparison.Ordinal)
                && string.Equals(Name, other.Name, StringComparison.Ordinal);
        }

        return false;
    }

    public override int GetHashCode()
        => Prefix.GetHashCode() ^ (Name?.GetHashCode() ?? 0);

    public static QName Parse(string input)
    {
        var idx = input.IndexOf(':');

        if (idx < 0)
        {
            return new(string.Empty, input);
        }

        return new(input.Substring(0, idx), input.Substring(idx + 1));
    }

    public static implicit operator string(QName qname) => qname.ToString();
}
