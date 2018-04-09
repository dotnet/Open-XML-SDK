// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

using static DocumentFormat.OpenXml.Validation.Schema.SdbData;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Particle children index data.
    /// </summary>
    [DebuggerDisplay("ParticleIndex={ParticleIndex}")]
    internal readonly struct SdbParticleChildrenIndex
    {
        public static readonly int TypeSize = sizeof(ushort);

        public SdbParticleChildrenIndex(ushort particleIndex)
        {
            ParticleIndex = particleIndex;
        }

        /// <summary>
        /// Initializes an instance of <see cref="SdbParticleChildrenIndex"/> that deserializes from data
        /// </summary>
        /// <remarks>
        /// The order of <see cref="SdbParticleChildrenIndex(byte[], int)"/> and <see cref="Serialize"/> must remain
        /// in sync to facilitate serialization and deserialization of binary data
        /// </remarks>
        private SdbParticleChildrenIndex(byte[] data, int startIndex)
        {
            ParticleIndex = LoadSdbIndex(data, ref startIndex);
        }

        /// <summary>
        /// Gets the index of the particle in the SdbParticleConstraint data array.
        /// </summary>
        public ushort ParticleIndex { get; }

        public static SdbParticleChildrenIndex Deserialize(byte[] data, int startIndex) => new SdbParticleChildrenIndex(data, startIndex);

        /// <summary>
        /// Serializes the instance data to a byte array
        /// </summary>
        /// <remarks>
        /// The order of <see cref="SdbParticleChildrenIndex(byte[], int)"/> and <see cref="Serialize"/> must remain
        /// in sync to facilitate serialization and deserialization of binary data
        /// </remarks>
        public byte[] Serialize()
        {
            return ParticleIndex.Bytes();
        }
    }
}
