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
    /// <remarks>
    /// We cannot use auto-properties here due to failure in .NET Native to compile them. For further details, https://github.com/OfficeDev/Open-XML-SDK/issues/567.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal readonly struct SdbDataHead
    {
        /// <summary>
        /// This value must be changed if the layout of any of the structs contained within
        /// <see cref="SdbSchemaData"/> are changed (ie those contained in the constructor
        /// for <see cref="SdbDataHead"/>
        /// </summary>
        private static readonly Guid CurrentVersion = new Guid("06dd55b7-ef4d-46ee-a618-042af4c3904e");

        private readonly Guid _version;
        private readonly FileFormatVersions _fileFormat;
        private readonly SdbSpan _classIds;
        private readonly SdbSpan _schemaType;
        private readonly SdbSpan _particles;
        private readonly SdbSpan _particleChildren;
        private readonly SdbSpan _attributes;

        public SdbDataHead(
            FileFormatVersions fileFormat,
            SdbClassIdToSchemaTypeIndex[] classIdMap,
            SdbSchemaType[] schemaTypes,
            SdbParticleConstraint[] particles,
            SdbParticleChildrenIndex[] particleIndexes,
            SdbAttributeConstraint[] attributes)
        {
            _version = CurrentVersion;
            _fileFormat = fileFormat;
            _classIds = SdbSpan.Create(Marshal.SizeOf<SdbDataHead>(), classIdMap);
            _schemaType = SdbSpan.Create(_classIds.End, schemaTypes);
            _particles = SdbSpan.Create(_schemaType.End, particles);
            _particleChildren = SdbSpan.Create(_particles.End, particleIndexes);
            _attributes = SdbSpan.Create(_particleChildren.End, attributes);
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

        public Guid Version => _version;

        public FileFormatVersions FileFormat => _fileFormat;

        public int End => Attributes.End;

        public SdbSpan ClassIds => _classIds;

        public SdbSpan SchemaType => _schemaType;

        public SdbSpan Particles => _particles;

        public SdbSpan ParticleChildren => _particleChildren;

        public SdbSpan Attributes => _attributes;
    }
}
