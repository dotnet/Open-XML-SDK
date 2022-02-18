// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Models;

public class Part
{
    public string Name { get; set; } = null!;

    public string Base { get; set; } = null!;

    public bool HasFixedContent => ContentType is not null;

    public string? ContentType { get; set; }

    public string RelationshipType { get; set; } = null!;

    public string Target { get; set; } = null!;

    public OfficeVersion Version { get; set; }

    public QName? Root { get; set; }

    public string RootElement { get; set; } = null!;

    public string? Extension { get; set; }

    public PartPaths Paths { get; set; } = null!;

    public IEnumerable<PartChild> Children { get; set; } = Enumerable.Empty<PartChild>();

    public IEnumerable<PartChild> GetPartConstraints() => Children.Where(c => !c.IsDataPartReference);

    public IEnumerable<PartChild> GetDataPartConstraints() => Children.Where(c => c.IsDataPartReference);
}
