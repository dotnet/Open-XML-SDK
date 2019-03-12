// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.InteropServices;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <remarks>
    /// We cannot use auto-properties here due to failure in .NET Native to compile them. For further details, https://github.com/OfficeDev/Open-XML-SDK/issues/567.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal readonly struct SdbSchemaType
    {
        private readonly ushort _particleIndex;
        private readonly ushort _simpleTypeIndex;
        private readonly ushort _attributesCount;
        private readonly ushort _startIndexOfAttributes;

        public SdbSchemaType(ushort particleIndex, ushort simpleTypeIndex, ushort attributesCount, ushort startIndexOfAttributes)
        {
            _particleIndex = particleIndex;
            _simpleTypeIndex = simpleTypeIndex;
            _attributesCount = attributesCount;
            _startIndexOfAttributes = startIndexOfAttributes;
        }

        /// <summary>
        /// Gets the index of the particle in the SdbParticleConstraint data array.
        /// Will be "SdbData.InvalidId" if the schema type is NOT composite type.
        /// </summary>
        /// <remarks>This field can be eliminated.</remarks>
        public ushort ParticleIndex => _particleIndex;

        /// <summary>
        /// Gets the index of the simple data in the SdbSimpleTypeRestriction data array.
        /// Will be "SdbData.InvalidId" if the schema type is NOT simple content only.
        /// </summary>
        public ushort SimpleTypeIndex => _simpleTypeIndex;

        /// <summary>
        /// Gets the count of attributes.
        /// </summary>
        public ushort AttributesCount => _attributesCount;

        /// <summary>
        /// Gets the index of the first attribute data in the SdbAttributeConstraint data array.
        /// </summary>
        public ushort StartIndexOfAttributes => _startIndexOfAttributes;

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
