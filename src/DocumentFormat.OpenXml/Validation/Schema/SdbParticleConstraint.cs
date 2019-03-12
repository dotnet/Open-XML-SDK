// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Particle constraint data.
    /// </summary>
    /// <remarks>
    /// We cannot use auto-properties here due to failure in .NET Native to compile them. For further details, https://github.com/OfficeDev/Open-XML-SDK/issues/567.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [DebuggerDisplay("ParticleType={ParticleType}")]
    internal readonly struct SdbParticleConstraint
    {
        private readonly ParticleType _particleType;
        private readonly ushort _elementTypeId;
        private readonly ushort _minOccurs;
        private readonly int _maxOccurs;
        private readonly ushort _childrenCount;
        private readonly ushort _childrenStartIndex;

        public SdbParticleConstraint(
            ParticleType particleType,
            ushort elementTypeId,
            ushort minOccurs,
            int maxOccurs,
            ushort childrenCount,
            ushort childrenStartIndex)
        {
            _particleType = particleType;
            _elementTypeId = elementTypeId;
            _minOccurs = minOccurs;
            _maxOccurs = maxOccurs;
            _childrenCount = childrenCount;
            _childrenStartIndex = childrenStartIndex;
        }

        /// <summary>
        /// Gets the particle type of this particle.
        /// </summary>
        public ParticleType ParticleType => _particleType;

        /// <summary>
        /// Gets the element type ID (class ID).
        /// </summary>
        public ushort ElementTypeId => _elementTypeId;

        /// <summary>
        /// Gets the xsd:minOccurs value of this particle.
        /// Just use ushort at now. throw exceptions if there are numbers > ushort.MaxValue.
        /// </summary>
        public ushort MinOccurs => _minOccurs;

        /// <summary>
        /// Gets the xsd:maxOccurs value of this particle.
        /// ushort is not enough.
        /// </summary>
        public int MaxOccurs => _maxOccurs;

        /// <summary>
        /// Gets count of children particles.
        /// </summary>
        public ushort ChildrenCount => _childrenCount;

        /// <summary>
        /// Gets the index of the first child particle index in the SdbParticleChildrenIndex data array.
        /// </summary>
        public ushort ChildrenStartIndex => _childrenStartIndex;

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
