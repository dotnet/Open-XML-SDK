// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Particle children index data.
    /// </summary>
    /// <remarks>
    /// We cannot use auto-properties here due to failure in .NET Native to compile them. For further details, https://github.com/OfficeDev/Open-XML-SDK/issues/567.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [DebuggerDisplay("ParticleIndex={ParticleIndex}")]
    internal readonly struct SdbParticleChildrenIndex
    {
        private readonly ushort _particleIndex;

        public SdbParticleChildrenIndex(ushort particleIndex)
        {
            _particleIndex = particleIndex;
        }

        /// <summary>
        /// Gets the index of the particle in the SdbParticleConstraint data array.
        /// </summary>
        public ushort ParticleIndex => _particleIndex;
    }
}
