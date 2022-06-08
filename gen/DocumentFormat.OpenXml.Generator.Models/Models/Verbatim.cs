// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Generator.Models;

internal readonly struct Verbatim
{
    public Verbatim(string value)
    {
        Value = value;
    }

    public string Value { get; }
}
