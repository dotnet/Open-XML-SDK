// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema.Restrictions;
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
        private readonly FileFormatVersions _fileFormat;
        private readonly Dictionary<ushort, SchemaTypeData> _cache;

        private SdbDataHead DataHead { get; }

        private SdbDataArray<SdbClassIdToSchemaTypeIndex> ClassIdMap { get; }

        private SdbDataArray<SdbSchemaType> SchemaTypes { get; }

        private SdbDataArray<SdbParticleConstraint> Particles { get; }

        private SdbDataArray<SdbParticleChildrenIndex> ParticleIndexes { get; }

        private SdbDataArray<SdbAttributeConstraint> Attributes { get; }

        private SimpleTypeRestrictions Restrictions { get; }

        public static SdbSchemaData GetSchemaData(FileFormatVersions fileFormat)
        {
            return new SdbSchemaData(fileFormat);
        }

        private SdbSchemaData(FileFormatVersions fileFormat)
        {
            if (!fileFormat.Any())
            {
                throw new ArgumentOutOfRangeException(nameof(fileFormat));
            }

            _cache = new Dictionary<ushort, SchemaTypeData>();
            _fileFormat = fileFormat;

            var name = $"DocumentFormat.OpenXml.GeneratedCode.{fileFormat}.constraints";

#if DEBUG
            var names = typeof(ValidationResources).GetTypeInfo().Assembly.GetManifestResourceNames();
#endif

            using (var schema = typeof(ValidationResources).GetTypeInfo().Assembly.GetManifestResourceStream(name))
            {
                if (schema == null)
                {
                    var message = string.Format(System.Globalization.CultureInfo.CurrentUICulture,
                        ExceptionMessages.FileFormatNotSupported,
                        fileFormat);

                    throw new ArgumentOutOfRangeException(nameof(fileFormat), message);
                }

                byte[] headBytes = new byte[SdbDataHead.HeadSize];

                schema.Read(headBytes, 0, SdbDataHead.HeadSize);
                DataHead = SdbDataHead.Deserialize(headBytes, 0);

#if DEBUG
                CheckDataHead((int)schema.Length);
#endif

                ClassIdMap = new SdbDataArray<SdbClassIdToSchemaTypeIndex>(schema, DataHead.ClassIdsCount, SdbClassIdToSchemaTypeIndex.TypeSize, SdbClassIdToSchemaTypeIndex.Deserialize);
                SchemaTypes = new SdbDataArray<SdbSchemaType>(schema, DataHead.SchemaTypeCount, SdbSchemaType.TypeSize, SdbSchemaType.Deserialize);
                Particles = new SdbDataArray<SdbParticleConstraint>(schema, DataHead.ParticleCount, SdbParticleConstraint.TypeSize, SdbParticleConstraint.Deserialize);
                ParticleIndexes = new SdbDataArray<SdbParticleChildrenIndex>(schema, DataHead.ParticleChildrenIndexCount, SdbParticleChildrenIndex.TypeSize, SdbParticleChildrenIndex.Deserialize);
                Attributes = new SdbDataArray<SdbAttributeConstraint>(schema, DataHead.AttributeCount, SdbAttributeConstraint.TypeSize, SdbAttributeConstraint.Deserialize);

                // simple type constraints
                schema.Seek(DataHead.SimpleTypeDataOffset, SeekOrigin.Begin);
                Restrictions = SimpleTypeRestrictions.Deserialize(schema, _fileFormat);

#if DEBUG
                Assert(DataHead.SimpleTypeCount == Restrictions.SimpleTypeCount);

                CheckData();
#endif
            }
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

        /// <summary>
        /// Load schema type constraint data for the specified element type ID.
        /// </summary>
        /// <param name="openxmlTypeId"></param>
        /// <returns>The constraint data of the schema type.</returns>
        public SchemaTypeData GetSchemaTypeData(int openxmlTypeId)
        {
            Debug.Assert(openxmlTypeId >= DataHead.StartClassId);
            Debug.Assert(openxmlTypeId < DataHead.StartClassId + DataHead.ClassIdsCount);

            ushort typeId = (ushort)openxmlTypeId;

            if (_cache.TryGetValue(typeId, out var schemaTypeData))
            {
                Debug.Assert(openxmlTypeId == schemaTypeData.OpenXmlTypeId);

                return schemaTypeData;
            }
            else
            {
                schemaTypeData = LoadSchemaTypeData(typeId);

                _cache.Add(typeId, schemaTypeData);

                return schemaTypeData;
            }
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
            Debug.Assert(particleIndex < DataHead.ParticleCount);

            SdbParticleConstraint sdbParticleConstraint = Particles[particleIndex];
            var particleConstraint = ParticleConstraint.CreateParticleConstraint(sdbParticleConstraint.ParticleType);

            particleConstraint.ParticleType = sdbParticleConstraint.ParticleType;
            particleConstraint.MaxOccurs = sdbParticleConstraint.MaxOccurs;
            particleConstraint.MinOccurs = sdbParticleConstraint.MinOccurs;
            particleConstraint.ElementId = sdbParticleConstraint.ElementTypeId;

            if (sdbParticleConstraint.ChildrenCount > 0)
            {
                Debug.Assert(sdbParticleConstraint.ParticleType == ParticleType.All ||
                                sdbParticleConstraint.ParticleType == ParticleType.Choice ||
                                sdbParticleConstraint.ParticleType == ParticleType.Group ||
                                sdbParticleConstraint.ParticleType == ParticleType.Sequence);
                particleConstraint.ChildrenParticles = new ParticleConstraint[sdbParticleConstraint.ChildrenCount];
                for (ushort i = 0; i < sdbParticleConstraint.ChildrenCount; i++)
                {
                    ushort childIndex = ParticleIndexes[(ushort)(sdbParticleConstraint.ChildrenStartIndex + i)].ParticleIndex;
                    particleConstraint.ChildrenParticles[i] = BuildParticleConstraint(childIndex);
                }
            }
            else if (sdbParticleConstraint.ParticleType == ParticleType.All ||
                        sdbParticleConstraint.ParticleType == ParticleType.Choice ||
                        sdbParticleConstraint.ParticleType == ParticleType.Group ||
                        sdbParticleConstraint.ParticleType == ParticleType.Sequence)
            {
                particleConstraint.ChildrenParticles = Cached.Array<ParticleConstraint>();
            }

            return particleConstraint;
        }

        /// <summary>
        /// Load the attribute constraints and simple type constraint for attributes for the schema type.
        /// </summary>
        /// <param name="sdbSchemaTpye"></param>
        /// <returns></returns>
        private AttributeConstraint[] BuildAttributeConstraint(SdbSchemaType sdbSchemaTpye)
        {
            if (sdbSchemaTpye.AttributesCount > 0)
            {
                int count = sdbSchemaTpye.AttributesCount;
                var attributeConstraints = new AttributeConstraint[count];

                ushort sdbIndex = sdbSchemaTpye.StartIndexOfAttributes;
                for (int i = 0; i < count; i++)
                {
                    var sdbAttributeData = Attributes[sdbIndex + i];

                    // then load the simple type constraint for this attribute
                    var simpleTypeIndex = sdbAttributeData.SimpleTypeIndex;
                    var simpleTypeConstraint = Restrictions[simpleTypeIndex];
                    attributeConstraints[i] = new AttributeConstraint(sdbAttributeData.AttributeUse, simpleTypeConstraint, (FileFormatVersions)sdbAttributeData.FileFormatVersion);
                }

                return attributeConstraints;
            }

            return null;
        }

        /// <summary>
        /// Load the data in the binary database into SchemaTypeData object.
        /// </summary>
        /// <param name="openxmlTypeId">The id of the type (the OpenXmlElement class).</param>
        /// <returns>The SchemaTypeData object.</returns>
        private SchemaTypeData LoadSchemaTypeData(ushort openxmlTypeId)
        {
            Debug.Assert(openxmlTypeId >= DataHead.StartClassId);
            Debug.Assert(openxmlTypeId < DataHead.StartClassId + DataHead.ClassIdsCount);

            ushort index = (ushort)(openxmlTypeId - DataHead.StartClassId);
            var sdbSchemaType = SchemaTypes[ClassIdMap[index].SchemaTypeIndex];
            var attributeConstraints = BuildAttributeConstraint(sdbSchemaType);

            var particleConstraint = BuildParticleConstraint(sdbSchemaType);
            if (particleConstraint != null)
            {
                return new SchemaTypeData(openxmlTypeId, attributeConstraints, particleConstraint);
            }
            else if (sdbSchemaType.IsSimpleContent)
            {
                Debug.Assert(sdbSchemaType.SimpleTypeIndex != SdbData.InvalidId);

                // simple content
                var simpleTypeConstraint = Restrictions[sdbSchemaType.SimpleTypeIndex];
                return new SchemaTypeData(openxmlTypeId, attributeConstraints, simpleTypeConstraint);
            }
            else
            {
                // leaf element
                Debug.Assert(sdbSchemaType.SimpleTypeIndex == SdbData.InvalidId);
                return new SchemaTypeData(openxmlTypeId, attributeConstraints);
            }
        }
    }
}
