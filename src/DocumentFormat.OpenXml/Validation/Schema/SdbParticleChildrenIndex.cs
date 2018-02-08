// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

/**********************************************************
 * Define data struct for schema constraint binary database
 **********************************************************/

using System;
using System.Diagnostics;

using SdbIndex = System.UInt16;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Particle children index data.
    /// </summary>
    [DebuggerDisplay("ParticleIndex={ParticleIndex}")]
    internal class SdbParticleChildrenIndex : SdbData
    {
        /// <summary>
        /// Gets or sets the index of the particle in the SdbParticleConstraint data array.
        /// </summary>
        public SdbIndex ParticleIndex { get; set; }

        public SdbParticleChildrenIndex()
        {
            this.ParticleIndex = SdbData.InvalidId;
        }

        public SdbParticleChildrenIndex(SdbIndex index)
        {
            this.ParticleIndex = index;
        }

        public SdbParticleChildrenIndex(int index)
        {
            if (index >= SdbData.MaxSdbIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            this.ParticleIndex = (SdbIndex)index;
        }

        /// <summary>
        /// Gets the size in bytes of this data structure.
        /// </summary>
        public static int TypeSize => sizeof(SdbIndex);

        #region Override SdbData Members

        /// <summary>
        /// Gets the size in bytes of this data structure.
        /// </summary>
        public override int DataSize => TypeSize;

        /// <summary>
        /// Serialize the data into byte data.
        /// </summary>
        /// <returns>Byte data.</returns>
        public override byte[] GetBytes()
        {
            return this.ParticleIndex.Bytes();
        }

        /// <summary>
        /// Deserialize the data from byte data.
        /// </summary>
        /// <param name="value">The byte data.</param>
        /// <param name="startIndex">The offset the data begins at.</param>
        public override void LoadFromBytes(byte[] value, int startIndex)
        {
            this.ParticleIndex = LoadSdbIndex(value, ref startIndex);
        }

        #endregion
    }
}
