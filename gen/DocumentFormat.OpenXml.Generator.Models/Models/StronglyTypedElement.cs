// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Generator.Models;

public class StronglyTypedElement
{
    public TypedQName Name { get; set; } = null!;

    public string ClassName { get; set; } = null!;

    public string? PartClassName { get; set; }
}
