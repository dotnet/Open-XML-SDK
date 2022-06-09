// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Models;

internal readonly struct TypeOf
{
    public TypeOf(string type)
    {
        Type = type;
    }

    public string Type { get; }
}
