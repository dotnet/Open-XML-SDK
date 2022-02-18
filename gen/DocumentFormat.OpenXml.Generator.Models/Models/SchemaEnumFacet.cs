// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Text;

namespace DocumentFormat.OpenXml.Generator.Models;

public class SchemaEnumFacet
{
    private string? _comments;
    private string? _name;

    public OfficeVersion Version { get; set; }

    public string Comments
    {
        get => _comments ?? Value;
        set => _comments = value;
    }

    public string Value { get; set; } = null!;

    public string Name
    {
        get => _name ?? CreateName(Value);
        set => _name = value;
    }

    private static string CreateName(string value)
    {
        var sb = new StringBuilder();

        sb.Append(char.ToUpper(value[0]));
        sb.Append(value, 1, value.Length - 1);
        sb.Replace(" ", string.Empty);
        sb.Replace("-", string.Empty);

        return sb.ToString();
    }
}
