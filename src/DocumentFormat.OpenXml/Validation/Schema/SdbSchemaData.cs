// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// This class serve as the loader which load the schema constraint data from binary data.
    /// </summary>
    internal sealed partial class SdbSchemaData
    {
        public const string Constraints = "constraints";

        private readonly FileFormatVersions _fileFormat;
        private readonly Dictionary<ushort, SchemaTypeData> _cache = new Dictionary<ushort, SchemaTypeData>();

        private SdbClassIdToSchemaTypeIndex[] ClassIdMap { get; }

        private SdbSchemaType[] SchemaTypes { get; }

        private SdbParticleConstraint[] Particles { get; }

        private SdbParticleChildrenIndex[] ParticleIndexes { get; }

        private SdbAttributeConstraint[] Attributes { get; }

        public static SdbSchemaData GetSchemaData(FileFormatVersions fileFormat)
        {
            return new SdbSchemaData(fileFormat);
        }

        public SdbSchemaData(
            FileFormatVersions fileFormat,
            SdbClassIdToSchemaTypeIndex[] classIdMap,
            SdbSchemaType[] schemaTypes,
            SdbParticleConstraint[] particles,
            SdbParticleChildrenIndex[] particleIndexes,
            SdbAttributeConstraint[] attributes)
        {
            _fileFormat = fileFormat;
            ClassIdMap = classIdMap;
            SchemaTypes = schemaTypes;
            Particles = particles;
            ParticleIndexes = particleIndexes;
            Attributes = attributes;
        }

        /// <summary>
        /// Creates an instance of <see cref="SdbSchemaData"/> using embedded streams for constraint data and simple types.
        /// </summary>
        /// <remarks>
        /// Constraint data are contained in a binary file that is defined as:
        ///
        /// <![CDATA[
        /// [SdbDataHead][SdbClassIdToSchemaTypeIndex][SdbSchemaType][SdbParticleConstraint][SdbParticleChildrenIndex][SdbAttributeConstraint]
        /// ]]>
        ///
        /// Since the size of the arrays are different for different <paramref name="fileFormat"/>, these are all marshalled separately, with the information
        /// of offsets contained in <see cref="SdbDataHead"/>. These items are deserialized in this method, while <see cref="SerializeSdbData(Stream)"/> provides
        /// the infrastructure to serialize them back to a binary file in the correct order
        /// </remarks>
        /// <param name="fileFormat">The version to load</param>
        private SdbSchemaData(FileFormatVersions fileFormat)
        {
            if (!fileFormat.Any())
            {
                throw new ArgumentOutOfRangeException(nameof(fileFormat));
            }

            _fileFormat = fileFormat;

            using (var schema = GetStream(fileFormat, Constraints))
            {
                var dataHead = SdbData.Deserialize<SdbDataHead>(schema);

                dataHead.Validate();

                var length = (int)schema.Length;

                if (dataHead.End != length)
                {
                    throw new InvalidDataException();
                }

                ClassIdMap = SdbData.Deserialize<SdbClassIdToSchemaTypeIndex>(schema, dataHead.ClassIds);
                SchemaTypes = SdbData.Deserialize<SdbSchemaType>(schema, dataHead.SchemaType);
                Particles = SdbData.Deserialize<SdbParticleConstraint>(schema, dataHead.Particles);
                ParticleIndexes = SdbData.Deserialize<SdbParticleChildrenIndex>(schema, dataHead.ParticleChildren);
                Attributes = SdbData.Deserialize<SdbAttributeConstraint>(schema, dataHead.Attributes);
            }
        }

        public static Stream GetStream(FileFormatVersions fileFormat, string extension)
        {
            var name = $"DocumentFormat.OpenXml.GeneratedCode.{fileFormat}.{extension}";

#if DEBUG
            var names = typeof(ValidationResources).GetTypeInfo().Assembly.GetManifestResourceNames();
#endif

            var schema = typeof(ValidationResources).GetTypeInfo().Assembly.GetManifestResourceStream(name);

            if (schema == null)
            {
                throw new ArgumentOutOfRangeException(nameof(fileFormat), SR.Format(ExceptionMessages.FileFormatNotSupported, fileFormat));
            }

            return schema;
        }

        public void SerializeSdbData(Stream stream)
        {
            var head = new SdbDataHead(
                _fileFormat,
                ClassIdMap,
                SchemaTypes,
                Particles,
                ParticleIndexes,
                Attributes);

            head.Validate();

            void ValidatePosition(int position)
            {
                if (position != stream.Position)
                {
                    throw new InvalidDataException();
                }
            }

            ValidatePosition(0);
            SdbData.Serialize(head, stream);

            ValidatePosition(head.ClassIds.Offset);
            SdbData.Serialize(ClassIdMap, stream);

            ValidatePosition(head.SchemaType.Offset);
            SdbData.Serialize(SchemaTypes, stream);

            ValidatePosition(head.Particles.Offset);
            SdbData.Serialize(Particles, stream);

            ValidatePosition(head.ParticleChildren.Offset);
            SdbData.Serialize(ParticleIndexes, stream);

            ValidatePosition(head.Attributes.Offset);
            SdbData.Serialize(Attributes, stream);
        }

        /// <summary>
        /// Load schema type constraint data for the specified element.
        /// </summary>
        /// <param name="openxmlElement">The element.</param>
        /// <returns>The constraint data of the schema type.</returns>
        public SchemaTypeData GetSchemaTypeData(OpenXmlElement openxmlElement)
        {
            Debug.Assert(openxmlElement != null);
            Debug.Assert(!(openxmlElement is OpenXmlUnknownElement));
            Debug.Assert(!(openxmlElement is OpenXmlMiscNode));

            return GetSchemaTypeData(openxmlElement.ElementTypeId);
        }

        private SchemaTypeData GetSchemaTypeData(int openxmlTypeId)
        {
            Debug.Assert(TryGetSchemaTypeData(openxmlTypeId, out var data));

            return data;
        }

        /// <summary>
        /// Load schema type constraint data for the specified element type ID.
        /// </summary>
        public bool TryGetSchemaTypeData(int openxmlTypeId, out SchemaTypeData data)
        {
            if (openxmlTypeId < SdbClassIdToSchemaTypeIndex.StartClassId)
            {
                data = null;
                return false;
            }

            if (openxmlTypeId >= SdbClassIdToSchemaTypeIndex.StartClassId + ClassIdMap.Length)
            {
                data = null;
                return false;
            }

            ushort typeId = (ushort)openxmlTypeId;

            if (_cache.TryGetValue(typeId, out var schemaTypeData))
            {
                Debug.Assert(openxmlTypeId == schemaTypeData.OpenXmlTypeId);

                data = schemaTypeData;
            }
            else
            {
                schemaTypeData = LoadSchemaTypeData(typeId);

                _cache.Add(typeId, schemaTypeData);

                data = schemaTypeData;
            }

            return data != null;
        }

        /// <summary>
        /// Load the particle constraint from the specified data in binary database.
        /// </summary>
        /// <param name="sdbSchemaTpye">The data in binary database.</param>
        /// <returns>The particle constraint in ParticleConstraint.</returns>
        private ParticleConstraint BuildParticleConstraint(SdbSchemaType sdbSchemaTpye)
        {
            if (sdbSchemaTpye.IsCompositeType)
            {
                var particleConstraint = BuildParticleConstraint(sdbSchemaTpye.ParticleIndex);

                Debug.Assert(particleConstraint.ParticleType == ParticleType.All || particleConstraint.ParticleType == ParticleType.Any ||
                              particleConstraint.ParticleType == ParticleType.Choice || particleConstraint.ParticleType == ParticleType.Sequence ||
                              particleConstraint.ParticleType == ParticleType.Group); // <xsd:group ref="..." /> is valid under <xsd:complexType>
                Debug.Assert(particleConstraint.ElementId == SdbData.InvalidId);

                return particleConstraint;
            }

            return null;
        }

        /// <summary>
        /// Load the particle constraint from the specified data in binary database.
        /// </summary>
        /// <param name="particleIndex">The index of the particle constraint data in the binary database.</param>
        /// <returns>The particle constraint in ParticleConstraint.</returns>
        private ParticleConstraint BuildParticleConstraint(ushort particleIndex)
        {
            Debug.Assert(particleIndex >= 0);
            Debug.Assert(particleIndex < Particles.Length);

            var sdbParticleConstraint = Particles[particleIndex];
            var particleConstraint = CreateParticleConstraint(sdbParticleConstraint);

            if (sdbParticleConstraint.ChildrenCount > 0)
            {
                Debug.Assert(sdbParticleConstraint.ParticleType == ParticleType.All ||
                                sdbParticleConstraint.ParticleType == ParticleType.Choice ||
                                sdbParticleConstraint.ParticleType == ParticleType.Group ||
                                sdbParticleConstraint.ParticleType == ParticleType.Sequence);

                for (ushort i = 0; i < sdbParticleConstraint.ChildrenCount; i++)
                {
                    ushort childIndex = ParticleIndexes[(ushort)(sdbParticleConstraint.ChildrenStartIndex + i)].ParticleIndex;
                    particleConstraint.Add(BuildParticleConstraint(childIndex));
                }
            }

            return particleConstraint;
        }

        private static ParticleConstraint CreateParticleConstraint(SdbParticleConstraint sdb)
        {
            switch (sdb.ParticleType)
            {
                case ParticleType.Element:
                    return new ElementParticle(sdb.ElementTypeId, sdb.MinOccurs, sdb.MaxOccurs);

                case ParticleType.Any:
                    return new AnyParticle(sdb.ElementTypeId, sdb.MinOccurs, sdb.MaxOccurs);

                case ParticleType.AnyWithUri:
                    return new NsAnyParticle(sdb.ElementTypeId, sdb.MinOccurs, sdb.MaxOccurs);

                case ParticleType.Invalid:
                    Debug.Assert(sdb.ParticleType != ParticleType.Invalid);
                    return null;

                default:
                    return new CompositeParticle(sdb.ParticleType, sdb.MinOccurs, sdb.MaxOccurs);
            }
        }

        /// <summary>
        /// Load the data in the binary database into SchemaTypeData object.
        /// </summary>
        /// <param name="openxmlTypeId">The id of the type (the OpenXmlElement class).</param>
        /// <returns>The SchemaTypeData object.</returns>
        private SchemaTypeData LoadSchemaTypeData(ushort openxmlTypeId)
        {
            Debug.Assert(openxmlTypeId >= SdbClassIdToSchemaTypeIndex.StartClassId);
            Debug.Assert(openxmlTypeId < SdbClassIdToSchemaTypeIndex.StartClassId + ClassIdMap.Length);

            ushort index = (ushort)(openxmlTypeId - SdbClassIdToSchemaTypeIndex.StartClassId);
            var sdbSchemaType = SchemaTypes[ClassIdMap[index].SchemaTypeIndex];

            var particleConstraint = BuildParticleConstraint(sdbSchemaType);

            if (particleConstraint is null)
            {
                return null;
            }

            return new SchemaTypeData(openxmlTypeId, particleConstraint);
        }
    }
}
