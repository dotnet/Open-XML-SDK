// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using DocumentFormat.OpenXml.Framework.Schema;
using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Framework
{
    [DebuggerDisplay("[{Type}] - {Path}")]
    internal readonly struct LookupItem
    {
        public LookupItem(Type type, ParticlePath path)
        {
            Type = type;
            Path = path;
        }

        public Type Type { get; }

        public ParticlePath Path { get; }

        public void Deconstruct(out Type type, out ParticlePath path)
        {
            type = Type;
            path = Path;
        }
    }
}
