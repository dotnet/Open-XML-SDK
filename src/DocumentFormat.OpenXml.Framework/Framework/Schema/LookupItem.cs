// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Schema;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Framework;

[DebuggerDisplay("[{Type}] - {Path}")]
internal readonly record struct LookupItem
{
    public LookupItem(OpenXmlType type, ParticlePath path)
    {
        Type = type;
        Path = path;
    }

    public OpenXmlType Type { get; }

    public ParticlePath Path { get; }

    public void Deconstruct(out OpenXmlType type, out ParticlePath path)
    {
        type = Type;
        path = Path;
    }
}
