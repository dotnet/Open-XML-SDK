// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema.Restrictions;
using System.Collections.Generic;
using System.Diagnostics;

using OpenXmlTypeId = System.UInt16;
using SdbIndex = System.UInt16;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Defines SdbSchemaDatas class.
    /// </summary>
    /// <remarks>
    /// This class serve as the loader which load the schema constraint datas from binary data.
    /// </remarks>
    internal abstract class SdbSchemaDatas
    {
        private readonly Dictionary<OpenXmlTypeId, SchemaTypeData> _schemaTypeDatas = new Dictionary<ushort, SchemaTypeData>();

        protected SdbDataHead SdbDataHead { get; set; }

        protected IReadOnlyList<SdbClassIdToSchemaTypeIndex> SdbClassIdMap { get; set; }

        protected IReadOnlyList<SdbSchemaType> SdbSchemaTypes { get; set; }

        protected IReadOnlyList<SdbParticleConstraint> SdbParticles { get; set; }

        protected IReadOnlyList<SdbParticleChildrenIndex> SdbParticleIndexs { get; set; }

        protected IReadOnlyList<SdbAttributeConstraint> SdbAttributes { get; set; }

        protected SimpleTypeRestrictions SimpleTypeRestrictions { get; set; }

        protected ParticleConstraint[] EmptyChildrenParticles = Cached.Array<ParticleConstraint>();

        /// <summary>
        /// Return an instance of SchemaConstraintDatabase which will load Office2007 schemas.
        /// </summary>
        public static SdbSchemaDatas GetOffice2007SchemaDatas()
        {
            return new BinarySdbSchemaDatas(FileFormatVersions.Office2007);
        }

        /// <summary>
        /// Return an instance of SchemaConstraintDatabase which will load Office2010 schemas.
        /// </summary>
        public static SdbSchemaDatas GetOffice2010SchemaDatas()
        {
            return new BinarySdbSchemaDatas(FileFormatVersions.Office2010);
        }

        /// <summary>
        /// Return an instance of SchemaConstraintDatabase which will load Office2010 schemas.
        /// </summary>
        public static SdbSchemaDatas GetOffice2013SchemaDatas()
        {
            return new BinarySdbSchemaDatas(FileFormatVersions.Office2013);
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
            Debug.Assert(openxmlTypeId >= this.SdbDataHead.StartClassId);
            Debug.Assert(openxmlTypeId < this.SdbDataHead.StartClassId + this.SdbDataHead.ClassIdsCount);

            OpenXmlTypeId typeId = (OpenXmlTypeId)openxmlTypeId;

            SchemaTypeData schemaTypeData;

            if (this._schemaTypeDatas.TryGetValue(typeId, out schemaTypeData))
            {
                Debug.Assert(openxmlTypeId == schemaTypeData.OpenXmlTypeId);

                return schemaTypeData;
            }
            else
            {
                schemaTypeData = this.LoadSchemaTypeData(typeId);

                this._schemaTypeDatas.Add(typeId, schemaTypeData);

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
            Debug.Assert(sdbSchemaTpye != null);

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
        private ParticleConstraint BuildParticleConstraint(SdbIndex particleIndex)
        {
            Debug.Assert(particleIndex >= 0);
            Debug.Assert(particleIndex < this.SdbDataHead.ParticleCount);

            SdbParticleConstraint sdbParticleConstraint = this.SdbParticles[particleIndex];
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
                for (SdbIndex i = 0; i < sdbParticleConstraint.ChildrenCount; i++)
                {
                    SdbIndex childIndex = this.SdbParticleIndexs[(SdbIndex)(sdbParticleConstraint.ChildrenStartIndex + i)].ParticleIndex;
                    particleConstraint.ChildrenParticles[i] = this.BuildParticleConstraint(childIndex);
                }
            }
            else if (sdbParticleConstraint.ParticleType == ParticleType.All ||
                        sdbParticleConstraint.ParticleType == ParticleType.Choice ||
                        sdbParticleConstraint.ParticleType == ParticleType.Group ||
                        sdbParticleConstraint.ParticleType == ParticleType.Sequence)
            {
                particleConstraint.ChildrenParticles = EmptyChildrenParticles;
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
            Debug.Assert(sdbSchemaTpye != null);
            if (sdbSchemaTpye.AttributesCount > 0)
            {
                int count = sdbSchemaTpye.AttributesCount;
                var attributeConstraints = new AttributeConstraint[count];

                SdbIndex sdbIndex = sdbSchemaTpye.StartIndexOfAttributes;
                for (int i = 0; i < count; i++)
                {
                    var sdbAttributeData = this.SdbAttributes[sdbIndex + i];
                    // then load the simple type constraint for this attribute
                    var simpleTypeIndex = sdbAttributeData.SimpleTypeIndex;
                    var simpleTypeConstraint = this.SimpleTypeRestrictions[simpleTypeIndex];
                    attributeConstraints[i] = new AttributeConstraint(sdbAttributeData.AttributeUse, simpleTypeConstraint, (FileFormatVersions) sdbAttributeData.FileFormatVersion);
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
        private SchemaTypeData LoadSchemaTypeData(OpenXmlTypeId openxmlTypeId)
        {
            Debug.Assert(openxmlTypeId >= this.SdbDataHead.StartClassId);
            Debug.Assert(openxmlTypeId < this.SdbDataHead.StartClassId + this.SdbDataHead.ClassIdsCount);

            SdbIndex index = (SdbIndex)(openxmlTypeId - this.SdbDataHead.StartClassId);
            var sdbSchemaType = this.SdbSchemaTypes[this.SdbClassIdMap[index].SchemaTypeIndex];
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
                var simpleTypeConstraint = this.SimpleTypeRestrictions[sdbSchemaType.SimpleTypeIndex];
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
