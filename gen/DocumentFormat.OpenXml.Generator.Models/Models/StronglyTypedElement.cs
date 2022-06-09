// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Models;

public class StronglyTypedElement
{
    public TypedQName Name { get; set; } = null!;

    public string ClassName { get; set; } = null!;

    public string? PartClassName { get; set; }
}
