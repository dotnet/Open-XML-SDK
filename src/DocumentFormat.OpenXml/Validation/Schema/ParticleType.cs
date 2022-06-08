// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

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
