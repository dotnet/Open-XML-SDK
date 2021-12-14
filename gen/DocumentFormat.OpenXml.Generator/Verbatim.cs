// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator;

internal readonly struct Verbatim
{
    public Verbatim(string value)
    {
        Value = value;
    }

    public string Value { get; }
}
