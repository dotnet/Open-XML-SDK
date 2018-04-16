// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Particle children index data.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [DebuggerDisplay("ParticleIndex={ParticleIndex}")]
    internal readonly struct SdbParticleChildrenIndex
    {
        public SdbParticleChildrenIndex(ushort particleIndex)
        {
            ParticleIndex = particleIndex;
        }

        /// <summary>
        /// Gets the index of the particle in the SdbParticleConstraint data array.
        /// </summary>
        public ushort ParticleIndex { get; }
    }
}
