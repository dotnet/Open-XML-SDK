// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Models;

public class Argument
{
    public ArgumentType Type { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;
}
