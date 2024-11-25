// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Schema;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Framework;

[DebuggerDisplay("[{QName}] - {Path}")]
internal readonly record struct LookupItem
{
    public LookupItem(OpenXmlQualifiedName qname, ParticlePath path)
    {
        QName = qname;
        Path = path;
    }

    public OpenXmlQualifiedName QName { get; }

    public ParticlePath Path { get; }

    public void Deconstruct(out OpenXmlQualifiedName qname, out ParticlePath path)
    {
        qname = QName;
        path = Path;
    }
}
