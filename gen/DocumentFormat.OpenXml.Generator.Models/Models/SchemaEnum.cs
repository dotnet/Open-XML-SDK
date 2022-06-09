// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Models;

public class SchemaEnum
{
    private string? _summary;

    public QName Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Summary
    {
        get => _summary ?? $"Defines the {Name} enumeration.";
        set => _summary = value;
    }

    public IEnumerable<SchemaEnumFacet> Facets { get; set; } = Enumerable.Empty<SchemaEnumFacet>();

    public OfficeVersion Version { get; set; }
}
