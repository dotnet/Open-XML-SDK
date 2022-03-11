// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator;

public record OpenXmlGeneratorOptions
{
    public bool GenerateNamespaces { get; init; }

    public bool GenerateParts { get; init; }

    public bool GenerateSchema { get; init; }
}
