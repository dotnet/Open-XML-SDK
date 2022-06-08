// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Generator;

public record OpenXmlGeneratorOptions
{
    public bool GenerateNamespaces { get; init; }

    public bool GenerateParts { get; init; }

    public bool GenerateSchema { get; init; }
}
