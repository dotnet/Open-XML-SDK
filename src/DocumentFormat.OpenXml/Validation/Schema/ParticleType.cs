// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Particle type.
    /// </summary>
    internal enum ParticleType : byte
    {
        Element = 0,
        All, // xsd:any which use predefined value: ##any, ##other, ##local, ##targetNamespace.
        Any,
        Choice,
        Group,
        Sequence,
        AnyWithUri, // xsd:any which has specified namespace
        Invalid = byte.MaxValue,
    }
}
