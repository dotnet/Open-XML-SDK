// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Models;

public class SchemaNamespace
{
    public string TargetNamespace { get; set; } = null!;

    public IEnumerable<SchemaType> Types { get; set; } = Enumerable.Empty<SchemaType>();

    public IEnumerable<SchemaEnum> Enums { get; set; } = Enumerable.Empty<SchemaEnum>();
}
