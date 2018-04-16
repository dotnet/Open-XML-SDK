// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Particle constraint data.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [DebuggerDisplay("ParticleType={ParticleType}")]
    internal readonly struct SdbParticleConstraint
    {
        public SdbParticleConstraint(
            ParticleType particleType,
            ushort elementTypeId,
            ushort minOccurs,
            int maxOccurs,
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
    }
}
