// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.Runtime.InteropServices;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// The data head of the binary schema constraint data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal readonly struct SdbDataHead
    {
        /// <summary>
        /// This value must be changed if the layout of any of the structs contained within
        /// <see cref="SdbSchemaData"/> are changed (ie those contained in the constructor
        /// for <see cref="SdbDataHead"/>
        /// </summary>
        private static readonly Guid CurrentVersion = new Guid("06dd55b7-ef4d-46ee-a618-042af4c3904e");

        public SdbDataHead(
            FileFormatVersions fileFormat,
            SdbClassIdToSchemaTypeIndex[] classIdMap,
            SdbSchemaType[] schemaTypes,
            SdbParticleConstraint[] particles,
            SdbParticleChildrenIndex[] particleIndexes,
            SdbAttributeConstraint[] attributes)
        {
            Version = CurrentVersion;
            FileFormat = fileFormat;
            ClassIds = SdbSpan.Create(Marshal.SizeOf<SdbDataHead>(), classIdMap);
            SchemaType = SdbSpan.Create(ClassIds.End, schemaTypes);
            Particles = SdbSpan.Create(SchemaType.End, particles);
            ParticleChildren = SdbSpan.Create(Particles.End, particleIndexes);
            Attributes = SdbSpan.Create(ParticleChildren.End, attributes);
        }

        public void Validate()
        {
            if (Version != CurrentVersion
                || ClassIds.Size != Marshal.SizeOf<SdbClassIdToSchemaTypeIndex>()
                || SchemaType.Size != Marshal.SizeOf<SdbSchemaType>()
                || Particles.Size != Marshal.SizeOf<SdbParticleConstraint>()
                || ParticleChildren.Size != Marshal.SizeOf<SdbParticleChildrenIndex>()
                || Attributes.Size != Marshal.SizeOf<SdbAttributeConstraint>())
            {
                throw new InvalidDataException();
            }
        }

        public Guid Version { get; }

        public FileFormatVersions FileFormat { get; }

        public int End => Attributes.End;

        public SdbSpan ClassIds { get; }

        public SdbSpan SchemaType { get; }

        public SdbSpan Particles { get; }

        public SdbSpan ParticleChildren { get; }

        public SdbSpan Attributes { get; }
    }
}
