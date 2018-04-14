// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.InteropServices;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal readonly struct SdbSchemaType
    {
        public SdbSchemaType(ushort particleIndex, ushort simpleTypeIndex, ushort attributesCount, ushort startIndexOfAttributes)
        {
            ParticleIndex = particleIndex;
            SimpleTypeIndex = simpleTypeIndex;
            AttributesCount = attributesCount;
            StartIndexOfAttributes = startIndexOfAttributes;
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
    }
}
