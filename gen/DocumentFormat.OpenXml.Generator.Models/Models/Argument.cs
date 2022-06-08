// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Generator.Models;

public class Argument
{
    public ArgumentType Type { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;
}
