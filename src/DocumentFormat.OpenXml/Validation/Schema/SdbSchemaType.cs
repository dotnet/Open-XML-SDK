// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using static DocumentFormat.OpenXml.Validation.Schema.SdbData;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    internal readonly struct SdbSchemaType
    {
        public static readonly int TypeSize = sizeof(ushort) * 4;

        public SdbSchemaType(ushort particleIndex, ushort simpleTypeIndex, ushort attributesCount, ushort startIndexOfAttributes)
        {
            ParticleIndex = particleIndex;
            SimpleTypeIndex = simpleTypeIndex;
            AttributesCount = attributesCount;
            StartIndexOfAttributes = startIndexOfAttributes;
        }

        /// <summary>
        /// Initializes an instance of <see cref="SdbSchemaType"/> that deserializes from data
        /// </summary>
        /// <remarks>
        /// The order of <see cref="SdbSchemaType(byte[], int)"/> and <see cref="Serialize"/> must remain
        /// in sync to facilitate serialization and deserialization of binary data
        /// </remarks>
        private SdbSchemaType(byte[] data, int startIndex)
        {
            ParticleIndex = LoadSdbIndex(data, ref startIndex);
            SimpleTypeIndex = LoadSdbIndex(data, ref startIndex);
            AttributesCount = LoadSdbIndex(data, ref startIndex);
            StartIndexOfAttributes = LoadSdbIndex(data, ref startIndex);
        }

        /// <summary>
        /// Gets the index of the particle in the SdbParticleConstraint data array.
        /// Will be "SdbData.InvalidId" if the schema type is NOT composite type.
        /// </summary>
        /// <remarks>This field can be eliminated.</remarks>
        public ushort ParticleIndex { get; }

        /// <summary>
        /// Gets the index of the simple data in the SdbSimpleTypeRestriction data array.
        /// Will be "SdbData.InvalidId" if the schema type is NOT simple content only.
        /// </summary>
        public ushort SimpleTypeIndex { get; }

        /// <summary>
        /// Gets the count of attributes.
        /// </summary>
        public ushort AttributesCount { get; }

        /// <summary>
        /// Gets the index of the first attribute data in the SdbAttributeConstraint data array.
        /// </summary>
        public ushort StartIndexOfAttributes { get; }

        /// <summary>
        /// Gets a value indicating whether the schema type is a schema type which contains particles.
        /// </summary>
        public bool IsCompositeType => ParticleIndex != SdbData.InvalidId;

        /// <summary>
        /// Gets a value indicating whether the schema type contains simple content only.
        /// </summary>
        public bool IsSimpleContent => SimpleTypeIndex != SdbData.InvalidId;

        public static SdbSchemaType Deserialize(byte[] data, int startIndex) => new SdbSchemaType(data, startIndex);

        /// <summary>
        /// Serializes the instance data to a byte array
        /// </summary>
        /// <remarks>
        /// The order of <see cref="SdbSchemaType(byte[], int)"/> and <see cref="Serialize"/> must remain
        /// in sync to facilitate serialization and deserialization of binary data
        /// </remarks>
        public byte[] Serialize()
        {
            return GetBytes(
                TypeSize,
                ParticleIndex.Bytes(),
                SimpleTypeIndex.Bytes(),
                AttributesCount.Bytes(),
                StartIndexOfAttributes.Bytes());
        }
    }
}
