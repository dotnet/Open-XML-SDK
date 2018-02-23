// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

/**********************************************************
 * Define data struct for schema constraint binary database
 **********************************************************/

using System.Diagnostics;

using SdbIndex = System.UInt16;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Particle constraint data.
    /// </summary>
    [DebuggerDisplay("ParticleType={ParticleType}")]
    internal class SdbParticleConstraint : SdbData
    {
        /// <summary>
        /// Represent maxOccurs="unbounded" by "0".
        /// </summary>
        public const ushort UnboundedMaxOccurs = 0;

        /// <summary>
        /// Gets or sets the particle type of this particle.
        /// </summary>
        public ParticleType ParticleType { get; set; }

        /// <summary>
        /// Gets or sets the element type ID (class ID).
        /// </summary>
        public SdbIndex ElementTypeId { get; set; }

        /// <summary>
        /// Gets or sets the xsd:minOccurs value of this particle.
        /// Just use ushort at now. throw exceptions if thera are numbers > ushort.MaxValue.
        /// </summary>
        public ushort MinOccurs { get; set; }

        /// <summary>
        /// Gets or sets the xsd:maxOccurs value of this particle.
        /// ushort is not enough.
        /// </summary>
        public int MaxOccurs { get; set; }

        /// <summary>
        /// Gets or sets count of children particles.
        /// </summary>
        public SdbIndex ChildrenCount { get; set; }

        /// <summary>
        /// Gets or sets the index of the first child particle index in the SdbParticleChildrenIndex data array.
        /// </summary>
        public SdbIndex ChildrenStartIndex { get; set; }

        /// <summary>
        /// Gets the namespace ID defiend in "xsd:any" when the particle type is ParticleType.Any or ParticleType.AnyWithUri
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public SdbIndex XsdAnyNamespaceId
        {
            get
            {
                // Valid only when the particle is "xsd:any".
                Debug.Assert(this.ParticleType == ParticleType.Any || this.ParticleType == ParticleType.AnyWithUri);

                // The ID data saved in the .ElementTypeId field.
                return this.ElementTypeId;
            }
        }

        /// <summary>
        /// Gets the size in bytes of this data structure.
        /// </summary>
        public static int TypeSize
        {
            get
            {
                return sizeof(ParticleType) +
                        sizeof(SdbIndex) +
                        sizeof(ushort) +
                        sizeof(int) +
                        sizeof(SdbIndex) +
                        sizeof(SdbIndex);
            }
        }

        /// <inheritdoc/>
        public override int DataSize => TypeSize;

        /// <inheritdoc/>
        public override byte[] GetBytes()
        {
            // !!!!Caution: keep the order of the following code lines!!!!
            return this.GetBytes(this.ParticleType.Bytes(),
                this.ElementTypeId.Bytes(),
                this.MinOccurs.Bytes(),
                this.MaxOccurs.Bytes(),
                this.ChildrenCount.Bytes(),
                this.ChildrenStartIndex.Bytes());
        }

        /// <inheritdoc/>
        public override void LoadFromBytes(byte[] value, int startIndex)
        {
            // !!!!Caution: keep the order of the following code lines!!!!
            this.ParticleType = (ParticleType)LoadByte(value, ref startIndex);
            this.ElementTypeId = LoadSdbIndex(value, ref startIndex);
            this.MinOccurs = LoadUInt16(value, ref startIndex);
            this.MaxOccurs = LoadInt(value, ref startIndex);
            this.ChildrenCount = LoadSdbIndex(value, ref startIndex);
            this.ChildrenStartIndex = LoadSdbIndex(value, ref startIndex);
        }
    }
}
