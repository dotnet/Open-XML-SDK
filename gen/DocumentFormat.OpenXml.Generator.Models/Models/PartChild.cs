// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Generator.Models;

public class PartChild
{
    public bool MinOccursIsNonZero { get; set; }

    public bool MaxOccursGreatThanOne { get; set; }

    public bool IsDataPartReference { get; set; }

    public string ApiName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool HasFixedContent { get; set; }

    public bool IsSpecialEmbeddedPart { get; set; }
}
