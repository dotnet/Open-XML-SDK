// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using SdbIndex = System.UInt16;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Schema type data.
    /// </summary>
    internal class SdbSchemaType : SdbData
    {
        // TODO: the ParticleIndex and SimpleTypeIndex can share one field.

        /// <summary>
        /// Gets or sets the index of the particle in the SdbParticleConstraint data array.
        /// Will be "SdbData.InvalidId" if the schema type is NOT composite type.
        /// </summary>
        /// <remarks>This field can be eliminated.</remarks>
        public SdbIndex ParticleIndex { get; set; }

        /// <summary>
        /// Gets or sets the index of the simple data in the SdbSimpleTypeRestriction data array.
        /// Will be "SdbData.InvalidId" if the schema type is NOT simple content only.
        /// </summary>
        public SdbIndex SimpleTypeIndex { get; set; }

        /// <summary>
        /// Gets or sets the count of attributes.
        /// </summary>
        public SdbIndex AttributesCount { get; set; }

        /// <summary>
        /// Gets or sets the index of the first attribute data in the SdbAttributeConstraint data array.
        /// </summary>
        public SdbIndex StartIndexOfAttributes { get; set; }

        /// <summary>
        /// Initializes a new instance of the SdbSchemaType.
        /// </summary>
        public SdbSchemaType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SdbSchemaType.
        /// </summary>
        /// <param name="particleIndex"></param>
        /// <param name="simpleTypeIndex"></param>
        /// <param name="attributeCount"></param>
        /// <param name="startAttribute"></param>
        public SdbSchemaType(SdbIndex particleIndex, SdbIndex simpleTypeIndex, SdbIndex attributeCount, SdbIndex startAttribute)
        {
            this.ParticleIndex = particleIndex;
            this.SimpleTypeIndex = simpleTypeIndex;
            this.AttributesCount = attributeCount;
            this.StartIndexOfAttributes = startAttribute;
        }

        /// <summary>
        /// Gets a value indicating whether the schema type is a schema type which contains particles.
        /// </summary>
        public bool IsCompositeType => this.ParticleIndex != SdbData.InvalidId;

        /// <summary>
        /// Gets a value indicating whether the schema type contains simple content only.
        /// </summary>
        public bool IsSimpleContent => this.SimpleTypeIndex != SdbData.InvalidId;

        /// <summary>
        /// Gets the size in bytes of this data structure
        /// </summary>
        public static int TypeSize => sizeof(SdbIndex) * 4;

        /// <inheritdoc/>
        public override int DataSize => TypeSize;

        /// <inheritdoc/>
        public override byte[] GetBytes()
        {
            // !!!!Caution: keep the order of the following code lines!!!!
            return this.GetBytes(this.ParticleIndex.Bytes(),
                                this.SimpleTypeIndex.Bytes(),
                                this.AttributesCount.Bytes(),
                                this.StartIndexOfAttributes.Bytes());
        }

        /// <inheritdoc/>
        public override void LoadFromBytes(byte[] value, int startIndex)
        {
            // !!!!Caution: keep the order of the following code lines!!!!
            this.ParticleIndex = LoadSdbIndex(value, ref startIndex);
            this.SimpleTypeIndex = LoadSdbIndex(value, ref startIndex);
            this.AttributesCount = LoadSdbIndex(value, ref startIndex);
            this.StartIndexOfAttributes = LoadSdbIndex(value, ref startIndex);
        }
    }
}
