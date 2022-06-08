// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Generator.Models;

internal readonly struct TypeOf
{
    public TypeOf(string type)
    {
        Type = type;
    }

    public string Type { get; }
}
