// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

using static DocumentFormat.OpenXml.Validation.Schema.SdbData;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Particle constraint data.
    /// </summary>
    [DebuggerDisplay("ParticleType={ParticleType}")]
    internal readonly struct SdbParticleConstraint
    {
        /// <summary>
        /// Gets the size in bytes of this data structure.
        /// </summary>
        public static readonly int TypeSize =
            sizeof(ParticleType) +
            sizeof(ushort) +
            sizeof(ushort) +
            sizeof(int) +
            sizeof(ushort) +
            sizeof(ushort);

        public SdbParticleConstraint(
            ParticleType particleType,
            ushort elementTypeId,
            ushort minOccurs,
            ushort maxOccurs,
            ushort childrenCount,
            ushort childrenStartIndex)
        {
            ParticleType = particleType;
            ElementTypeId = elementTypeId;
            MinOccurs = minOccurs;
            MaxOccurs = maxOccurs;
            ChildrenCount = childrenCount;
            ChildrenStartIndex = childrenStartIndex;
        }

        /// <summary>
        /// Initializes an instance of <see cref="SdbParticleConstraint"/> that deserializes from data
        /// </summary>
        /// <remarks>
        /// The order of <see cref="SdbParticleConstraint(byte[], int)"/> and <see cref="GetBytes"/> must remain
        /// in sync to facilitate serialization and deserialization of binary data
        /// </remarks>
        private SdbParticleConstraint(byte[] data, int startIndex)
        {
            ParticleType = (ParticleType)LoadByte(data, ref startIndex);
            ElementTypeId = LoadSdbIndex(data, ref startIndex);
            MinOccurs = LoadUInt16(data, ref startIndex);
            MaxOccurs = LoadInt(data, ref startIndex);
            ChildrenCount = LoadSdbIndex(data, ref startIndex);
            ChildrenStartIndex = LoadSdbIndex(data, ref startIndex);
        }

        /// <summary>
        /// Gets the particle type of this particle.
        /// </summary>
        public ParticleType ParticleType { get; }

        /// <summary>
        /// Gets the element type ID (class ID).
        /// </summary>
        public ushort ElementTypeId { get; }

        /// <summary>
        /// Gets the xsd:minOccurs value of this particle.
        /// Just use ushort at now. throw exceptions if there are numbers > ushort.MaxValue.
        /// </summary>
        public ushort MinOccurs { get; }

        /// <summary>
        /// Gets the xsd:maxOccurs value of this particle.
        /// ushort is not enough.
        /// </summary>
        public int MaxOccurs { get; }

        /// <summary>
        /// Gets count of children particles.
        /// </summary>
        public ushort ChildrenCount { get; }

        /// <summary>
        /// Gets the index of the first child particle index in the SdbParticleChildrenIndex data array.
        /// </summary>
        public ushort ChildrenStartIndex { get; }

#if DEBUG
        /// <summary>
        /// Gets the namespace ID defined in "xsd:any" when the particle type is ParticleType.Any or ParticleType.AnyWithUri
        /// </summary>
        public ushort XsdAnyNamespaceId
        {
            get
            {
                // Valid only when the particle is "xsd:any".
                Debug.Assert(ParticleType == ParticleType.Any || ParticleType == ParticleType.AnyWithUri);

                // The ID data saved in the .ElementTypeId field.
                return ElementTypeId;
            }
        }
#endif

        public static SdbParticleConstraint Deserialize(byte[] data, int startIndex) => new SdbParticleConstraint(data, startIndex);

        /// <summary>
        /// Serializes the instance data to a byte array
        /// </summary>
        /// <remarks>
        /// The order of <see cref="SdbParticleConstraint(byte[], int)"/> and <see cref="GetBytes"/> must remain
        /// in sync to facilitate serialization and deserialization of binary data
        /// </remarks>
        public byte[] GetBytes()
        {
            return SdbData.GetBytes(TypeSize, ParticleType.Bytes(),
                ElementTypeId.Bytes(),
                MinOccurs.Bytes(),
                MaxOccurs.Bytes(),
                ChildrenCount.Bytes(),
                ChildrenStartIndex.Bytes());
        }
    }
}
