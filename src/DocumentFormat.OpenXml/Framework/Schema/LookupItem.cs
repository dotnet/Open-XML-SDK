// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Schema;
using System;

namespace DocumentFormat.OpenXml.Framework
{
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

#if DEBUG
        public override string ToString() => $"[{Type}] - {Path.Path}";
#endif
    }
}
