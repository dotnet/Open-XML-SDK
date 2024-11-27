// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Schema;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Framework;

[DebuggerDisplay("[{Type}] - {Path}")]
internal readonly record struct LookupItem
{
    public LookupItem(OpenXmlSchemaType type, ParticlePath path)
    {
        Type = type;
        Path = path;
    }

    public OpenXmlSchemaType Type { get; }

    public ParticlePath Path { get; }

    public void Deconstruct(out OpenXmlSchemaType type, out ParticlePath path)
    {
        type = Type;
        path = Path;
    }
}
