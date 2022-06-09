// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
