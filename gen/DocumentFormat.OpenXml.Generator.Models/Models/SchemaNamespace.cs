// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Generator.Models;

public class SchemaNamespace
{
    public string TargetNamespace { get; set; } = null!;

    public IEnumerable<SchemaType> Types { get; set; } = Enumerable.Empty<SchemaType>();

    public IEnumerable<SchemaEnum> Enums { get; set; } = Enumerable.Empty<SchemaEnum>();
}
