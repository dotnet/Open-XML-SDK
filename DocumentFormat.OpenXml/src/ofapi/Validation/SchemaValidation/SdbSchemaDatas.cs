// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
    using SdbIndex = UInt16;
    using OpenXmlTypeId = UInt16;
    using DocumentFormat.OpenXml.Validation;
    
    /// <summary>
    /// Defines SdbSchemaDatas class.
    /// </summary>
    /// <remarks>
    /// This class serve as the loader which load the schema constraint datas from binary data.
    /// </remarks>
    internal partial class SdbSchemaDatas
    {
        // private static readonly WeakReference _weakReferenceToOffice2007Schemas = new WeakReference(null);

        /*******************************************************************
         * Data format.
         * 
         * Data head.
         * Table1 a list of SdbClassIdToSchemaTypeIndex (classId => ctIndex)
         * Table2 a list of all SdbSchemaType (schema types).  
         * Table3 a list of all SdbParticleConstraint.
         * Table4 a list of all SdbParticleChildrenIndex
         * Table5 a list of all attribute constraint
         * Table6 a list of all STs
         * *****************************************************************/

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SdbDataArray<SdbClassIdToSchemaTypeIndex> SdbClassIdMap { get; set; }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SdbDataArray<SdbSchemaType> SdbSchemaTypes { get; set; }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SdbDataArray<SdbParticleConstraint> SdbParticles { get; set; }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SdbDataArray<SdbParticleChildrenIndex> SdbParticleIndexs { get; set; }
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SdbDataArray<SdbAttributeConstraint> SdbAttributes { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SimpleTypeRestrictions SimpleTypeRestrictions { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ParticleConstraint[] EmptyChildrenParticles = new ParticleConstraint[0];

        /// <summary>
        /// Cache the created 
        /// </summary>
        private Dictionary<OpenXmlTypeId, SchemaTypeData> _schemaTypeDatas;
        private bool _loaded;
        private FileFormatVersions _fileFormat;

        /// <summary>
        /// The data head. 
        /// </summary>
        public SdbDataHead SdbDataHead { get; private set; }

        private SdbSchemaDatas(FileFormatVersions fileFormat)
        {
            Debug.Assert(fileFormat == FileFormatVersions.Office2007 || fileFormat == FileFormatVersions.Office2010 || fileFormat == FileFormatVersions.Office2013);

            this.SdbDataHead = new SdbDataHead();
            this._fileFormat = fileFormat;
        }

        //// Explicit static constructor to tell C# compiler
        //// not to mark type as beforefieldinit
        //static SdbSchemaDatas()
        //{
        //}
               
        /// <summary>
        /// Return an instance of SchemaConstraintDatabase which will load Office2007 schemas.
        /// </summary>
        public static SdbSchemaDatas GetOffice2007SchemaDatas()
        {
            // Remark: should we use WeakReference singleton? If yes, then be careful for multi-thread issue.
            SdbSchemaDatas o12Datas = new SdbSchemaDatas(FileFormatVersions.Office2007);
            o12Datas.InitOnDemand();
            return (SdbSchemaDatas)o12Datas;
        }

        /// <summary>
        /// Return an instance of SchemaConstraintDatabase which will load Office2010 schemas.
        /// </summary>
        public static SdbSchemaDatas GetOffice2010SchemaDatas()
        {
            // Remark: should we use WeakReference singleton? If yes, then be careful for multi-thread issue.
            SdbSchemaDatas o14Datas = new SdbSchemaDatas(FileFormatVersions.Office2010);
            o14Datas.InitOnDemand();
            return (SdbSchemaDatas)o14Datas;
        }

        /// <summary>
        /// Return an instance of SchemaConstraintDatabase which will load Office2010 schemas.
        /// </summary>
        public static SdbSchemaDatas GetOffice2013SchemaDatas()
        {
            // Remark: should we use WeakReference singleton? If yes, then be careful for multi-thread issue.
            SdbSchemaDatas o15Datas = new SdbSchemaDatas(FileFormatVersions.Office2013);
            o15Datas.InitOnDemand();
            return (SdbSchemaDatas)o15Datas;
        }

        /// <summary>
        /// Load schema type constraint data for the specified element.
        /// </summary>
        /// <param name="openxmlElement">The element.</param>
        /// <returns>The constraint data of the schema type.</returns>
        internal SchemaTypeData GetSchemaTypeData(OpenXmlElement openxmlElement)
        {
            Debug.Assert(openxmlElement != null);
            Debug.Assert(!(openxmlElement is OpenXmlUnknownElement));
            Debug.Assert(!(openxmlElement is OpenXmlMiscNode));

            return this.GetSchemaTypeData(openxmlElement.ElementTypeId);
        }

        /// <summary>
        /// Load schema type constraint data for the specified element type ID.
        /// </summary>
        /// <param name="openxmlTypeId"></param>
        /// <returns>The constraint data of the schema type.</returns>
        internal SchemaTypeData GetSchemaTypeData(int openxmlTypeId)
        {
            InitOnDemand();

            Debug.Assert(openxmlTypeId >= this.SdbDataHead.StartClassId);
            Debug.Assert(openxmlTypeId < this.SdbDataHead.StartClassId + this.SdbDataHead.ClassIdsCount);
            
            OpenXmlTypeId typeId = (OpenXmlTypeId)openxmlTypeId;

            SchemaTypeData schemaTypeData;

            if (this._schemaTypeDatas.TryGetValue(typeId, out schemaTypeData))
            {
                Debug.Assert( openxmlTypeId == schemaTypeData.OpenXmlTypeId );

                return schemaTypeData;
            }
            else
            {
                schemaTypeData = this.LoadSchemaTypeData(typeId);

                this._schemaTypeDatas.Add( typeId, schemaTypeData );

                return schemaTypeData;
            }
        }

        private void InitOnDemand()
        {
            if (this._loaded)
            {
                return;
            }
            Init();
        }

        private void Init()
        {
            this._schemaTypeDatas = new Dictionary<ushort, SchemaTypeData>();

            byte[] constraintBinaryData;

            switch (this._fileFormat)
            {
                case FileFormatVersions.Office2007:
                    constraintBinaryData = ValidationResources.O12SchemaConstraintDatas;
                    break;

                case FileFormatVersions.Office2010:
                    constraintBinaryData = ValidationResources.O14SchemaConstraintDatas;
                    break;

                case FileFormatVersions.Office2013:
                    constraintBinaryData = ValidationResources.O15SchemaConstraintDatas;
                    break;

                default:
                    Debug.Assert(this._fileFormat == FileFormatVersions.Office2007 || this._fileFormat == FileFormatVersions.Office2010 || this._fileFormat == FileFormatVersions.Office2013);
                    constraintBinaryData = ValidationResources.O12SchemaConstraintDatas;
                    break;
            }
            // Load the database from disk.    
            using (var byteStream = new MemoryStream(constraintBinaryData, false))
            {
                this.Load(byteStream);
            }
            return;
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
                    attributeConstraints[i] = new AttributeConstraint(sdbAttributeData.AttributeUse, simpleTypeConstraint, (FileFormatVersions)(sdbAttributeData.FileFormatVersion));
                }
                return attributeConstraints;
            }

            return null;
        }

        #region database loading

        /// <summary>
        /// Load the schema constraint data from the stream.
        /// </summary>
        /// <param name="dataStream">The data stream.</param>
        internal void Load(Stream dataStream)
        {
            Debug.Assert(dataStream != null);
            Debug.Assert(dataStream.CanRead);
            Debug.Assert(dataStream.CanSeek);
            Debug.Assert(dataStream.Length > SdbDataHead.HeadSize);

            byte[] headBytes = new byte[SdbDataHead.HeadSize];

            dataStream.Read(headBytes, 0, SdbDataHead.HeadSize);
            this.SdbDataHead.LoadFromBytes(headBytes, 0);

            CheckDataHead((int)(dataStream.Length));

            byte[] dataBytes;
            int count;

            // class ID map
            count = this.SdbDataHead.ClassIdsCount * SdbClassIdToSchemaTypeIndex.TypeSize;
            dataBytes = new byte[count];
            dataStream.Read(dataBytes, 0, count);
            this.SdbClassIdMap = new SdbDataArray<SdbClassIdToSchemaTypeIndex>(dataBytes);
            

            // schema types
            count = this.SdbDataHead.SchemaTypeCount * SdbSchemaType.TypeSize;
            dataBytes = new byte[count];
            dataStream.Read(dataBytes, 0, count);
            this.SdbSchemaTypes = new SdbDataArray<SdbSchemaType>(dataBytes);

            // particle constraints
            count = this.SdbDataHead.ParticleCount * SdbParticleConstraint.TypeSize;
            dataBytes = new byte[count];
            dataStream.Read(dataBytes, 0, count);
            this.SdbParticles = new SdbDataArray<SdbParticleConstraint>(dataBytes);

            // particle children index 
            count = this.SdbDataHead.ParticleChildrenIndexCount * SdbParticleChildrenIndex.TypeSize;
            dataBytes = new byte[count];
            dataStream.Read(dataBytes, 0, count);
            this.SdbParticleIndexs = new SdbDataArray<SdbParticleChildrenIndex>(dataBytes);

            // attribute constraints
            count = this.SdbDataHead.AttributeCount * SdbAttributeConstraint.TypeSize;
            dataBytes = new byte[count];
            dataStream.Read(dataBytes, 0, count);
            this.SdbAttributes = new SdbDataArray<SdbAttributeConstraint>(dataBytes);

            // simple type constraints
            dataStream.Seek(this.SdbDataHead.SimpleTypeDataOffset, SeekOrigin.Begin);
            this.SimpleTypeRestrictions = SimpleTypeRestrictions.Deserialize(dataStream, this._fileFormat);
            
            Assert(this.SdbDataHead.SimpleTypeCount == this.SimpleTypeRestrictions.SimpleTypeCount);

            CheckData();

            this._loaded = true;
        }

        /// <summary>
        /// Get a SdbClassIdToSchemaTypeIndex data for the sepcified class ID.
        /// </summary>
        /// <param name="classId">The class ID.</param>
        /// <returns>A SdbClassIdToSchemaTypeIndex data.</returns>
        private SdbClassIdToSchemaTypeIndex GetClassIdData(SdbIndex classId)
        {
            int index = SdbClassIdToSchemaTypeIndex.ArrayIndexFromClassId(classId);
            return this.SdbClassIdMap[index];
        }

        /// <summary>
        /// Make sure that the SdbDataHead data is correct.
        /// </summary>
        /// <param name="streamLength">The length of the data.</param>
        private void CheckDataHead(int streamLength)
        {
            var dataHead = this.SdbDataHead;

            Assert(dataHead.StartClassId == 10001);

            // head data saved both in head and in tail
            Assert(dataHead.DataByteCount + SdbDataHead.HeadSize * 2 == streamLength);
            Assert(dataHead.ClassIdsCount > 0);

            Assert(dataHead.SchemaTypeCount > 0);
            Assert(dataHead.SchemaTypeDataOffset == dataHead.ClassIdsDataOffset + dataHead.ClassIdsCount * SdbClassIdToSchemaTypeIndex.TypeSize);

            Assert(dataHead.ParticleCount > 0);
            Assert(dataHead.ParticleDataOffset == dataHead.SchemaTypeDataOffset + dataHead.SchemaTypeCount * SdbSchemaType.TypeSize);

            Assert(dataHead.ParticleChildrenIndexCount > 0);
            Assert(dataHead.ParticleChildrenIndexDataOffset == dataHead.ParticleDataOffset + dataHead.ParticleCount * SdbParticleConstraint.TypeSize);

            Assert(dataHead.AttributeCount > 0);
            Assert(dataHead.AttributeDataOffset == dataHead.ParticleChildrenIndexDataOffset + dataHead.ParticleChildrenIndexCount * SdbParticleChildrenIndex.TypeSize);

            Assert(dataHead.SimpleTypeCount > 0);
            Assert(dataHead.SimpleTypeDataOffset == dataHead.AttributeDataOffset + dataHead.AttributeCount * SdbAttributeConstraint.TypeSize);

            Assert(dataHead.SimpleTypeDataOffset < streamLength);
        }

        private static void Assert(bool value)
        {
            if (! value)
            {
                throw new InvalidDataException("Invalid schema constraint binary data.");
            }
        }

        /// <summary>
        /// Check the loaded schema constraint datas.
        /// </summary>
        private void CheckData()
        {
            
#if DEBUG
            SdbClassIdToSchemaTypeIndex classIdData;

            // check all datas in debug build
            for (var classId = SdbClassIdToSchemaTypeIndex.StartClassId; classId < SdbClassIdToSchemaTypeIndex.StartClassId + this.SdbDataHead.ClassIdsCount - 1; classId++)
            {
                classIdData = GetClassIdData(classId);
                Debug.Assert(classIdData.ClassId == classId);

                CheckSchemaType(classIdData.SchemaTypeIndex);
            }
#else
            return;
#endif
        }

#if DEBUG
        private void CheckSchemaType(int schemaTypeIndex)
        {
            if (schemaTypeIndex == ushort.MaxValue)
                return;

            var schemaType = this.SdbSchemaTypes[schemaTypeIndex];
            SdbParticleConstraint particle;
            if (schemaType.IsCompositeType)
            {
                particle = this.SdbParticles[schemaType.ParticleIndex];
                Debug.Assert(particle.ParticleType != ParticleType.Element &&
                            particle.ParticleType != ParticleType.Invalid &&
                            particle.ParticleType != ParticleType.Any &&
                            particle.ParticleType != ParticleType.AnyWithUri);

                CheckParticle(schemaType.ParticleIndex);
            }
            else if (schemaType.IsSimpleContent)
            {
                // 
            }
            else
            {
                // only attributes
            }
            
            // check attributes
            for (int i = 0; i < schemaType.AttributesCount; i++)
            {
                var attribute = this.SdbAttributes[schemaType.StartIndexOfAttributes + i];
                CheckSimpleType(attribute.SimpleTypeIndex);
            }

        }

        private void CheckParticle(int particleIndex)
        {
            var particle = this.SdbParticles[particleIndex];
            switch (particle.ParticleType)
            {

                case ParticleType.Element:
                    Debug.Assert(particle.ChildrenCount == 0);
                    // element type ID must be a valid ID in the class ID map.
                    Debug.Assert(particle.ElementTypeId >= SdbClassIdToSchemaTypeIndex.StartClassId);
                    Debug.Assert(particle.ElementTypeId < SdbClassIdToSchemaTypeIndex.StartClassId + this.SdbDataHead.ClassIdsCount);
                    break;

                case ParticleType.All:
                case ParticleType.Choice:
                case ParticleType.Group:
                case ParticleType.Sequence:
                    Debug.Assert(particle.ChildrenCount >= 0); // CT_Ink has an empty <xsd:sequence></xsd:sequence>
                    for (int i = 0; i < particle.ChildrenCount; i++)
                    {
                        var childIndex = this.SdbParticleIndexs[particle.ChildrenStartIndex + i];
                        CheckParticle(childIndex.ParticleIndex);
                    }
                    break;

                case ParticleType.Any:
                case ParticleType.AnyWithUri:
                    SdbIndex namespaceId = particle.XsdAnyNamespaceId;
                    Debug.Assert(namespaceId != SdbData.InvalidId);
                    break;

                case ParticleType.Invalid:
                default:
                    Debug.Assert(false);
                    break;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        private void CheckSimpleType(int index)
        {
            var simpleType = this.SimpleTypeRestrictions.SimpleTypes[index];

            if (simpleType.IsEnum)
            {
                Debug.Assert(simpleType is EnumValueRestriction);
                // Debug.Assert(simpleType.XsdType == XsdType.String || simpleType.XsdType == XsdType.Token);
                Debug.Assert(simpleType.IsList == false);
            }
            else if (simpleType.IsList)
            {
                Debug.Assert(simpleType is ListValueRestriction);
                Debug.Assert(simpleType.IsEnum == false);
                Debug.Assert(simpleType.XsdType == XsdType.List);
//                Debug.Assert(simpleType.XsdType == XsdType.AnySimpleType);
            }
            else if (simpleType is RedirectedRestriction)
            {
                Debug.Assert(simpleType.XsdType == XsdType.Redirected);
            }
            else
            {
                Debug.Assert(simpleType.IsEnum == false);

                // !!!! comment out lines are types need to be coded in validation.

                Debug.Assert(simpleType.XsdType != XsdType.AnySimpleType);
                // Debug.Assert(simpleType.XsdType != XsdType.AnyURI);
                // Debug.Assert(simpleType.XsdType != XsdType.Base64Binary);
                // Debug.Assert(simpleType.XsdType != XsdType.Boolean);
                // Debug.Assert(simpleType.XsdType != XsdType.Byte);
                // Debug.Assert(simpleType.XsdType != XsdType.Date);
                // Debug.Assert(simpleType.XsdType != XsdType.DateTime);
                // Debug.Assert(simpleType.XsdType != XsdType.Decimal);
                // Debug.Assert(simpleType.XsdType != XsdType.Double);
                Debug.Assert(simpleType.XsdType != XsdType.Duration);
                Debug.Assert(simpleType.XsdType != XsdType.ENTITIES);
                Debug.Assert(simpleType.XsdType != XsdType.ENTITY);
                // Debug.Assert(simpleType.XsdType != XsdType.Float);
                Debug.Assert(simpleType.XsdType != XsdType.GDay);
                Debug.Assert(simpleType.XsdType != XsdType.GMonth);
                Debug.Assert(simpleType.XsdType != XsdType.GMonthDay);
                Debug.Assert(simpleType.XsdType != XsdType.GYear);
                Debug.Assert(simpleType.XsdType != XsdType.GYearMonth);
                // Debug.Assert(simpleType.XsdType != XsdType.HexBinary);
                // Debug.Assert(simpleType.XsdType != XsdType.ID);
                // Debug.Assert(simpleType.XsdType != XsdType.IDREF);
                Debug.Assert(simpleType.XsdType != XsdType.IDREFS);
                // Debug.Assert(simpleType.XsdType != XsdType.Int);
                // Debug.Assert(simpleType.XsdType != XsdType.Integer);
                // Debug.Assert(simpleType.XsdType != XsdType.Language);
                // Debug.Assert(simpleType.XsdType != XsdType.Long);
                // Debug.Assert(simpleType.XsdType != XsdType.Name);
                // Debug.Assert(simpleType.XsdType != XsdType.NCName);
                Debug.Assert(simpleType.XsdType != XsdType.NegativeInteger);
                Debug.Assert(simpleType.XsdType != XsdType.NMTOKEN);
                Debug.Assert(simpleType.XsdType != XsdType.NMTOKENS);
                // Debug.Assert(simpleType.XsdType != XsdType.NonNegativeInteger);
                Debug.Assert(simpleType.XsdType != XsdType.NonPositiveInteger);
                // Debug.Assert(simpleType.XsdType != XsdType.NormalizedString);
                Debug.Assert(simpleType.XsdType != XsdType.NOTATION);
                // Debug.Assert(simpleType.XsdType != XsdType.PositiveInteger);
                // Debug.Assert(simpleType.XsdType != XsdType.QName);
                // Debug.Assert(simpleType.XsdType != XsdType.Short);
                // Debug.Assert(simpleType.XsdType != XsdType.String);
                Debug.Assert(simpleType.XsdType != XsdType.Time);
                // Debug.Assert(simpleType.XsdType != XsdType.Token);
                // Debug.Assert(simpleType.XsdType != XsdType.UnsignedByte);
                // Debug.Assert(simpleType.XsdType != XsdType.UnsignedInt);
                // Debug.Assert(simpleType.XsdType != XsdType.UnsignedLong);
                // Debug.Assert(simpleType.XsdType != XsdType.UnsignedShort);
            }

            switch (simpleType.XsdType)
            {
                case XsdType.Boolean:
                case XsdType.SpecialBoolean:
                    Debug.Assert(simpleType is BooleanValueRestriction);
                    break;

                case XsdType.String:
                    Debug.Assert(simpleType is StringRestriction);
                    break;

                //case XsdType.NormalizedString:
                //    Debug.Assert(simpleType is NormalizedStringRestriction);
                //    break;

                case XsdType.HexBinary:
                    Debug.Assert(simpleType is HexBinaryRestriction);
                    break;

                //case XsdType.Name:
                //    Debug.Assert(simpleType is NameRestriction);
                //    break;

                case XsdType.Token:
                    Debug.Assert(simpleType is TokenRestriction);
                    break;

                case XsdType.Byte:
                    // xsd:byte is SByte in CLR
                    Debug.Assert(simpleType is SByteValueRestriction);
                    break;

                case XsdType.UnsignedByte:
                    // xsd:unsignedByte is Byte in CLR
                    Debug.Assert(simpleType is ByteValueRestriction);
                    break;

                case XsdType.Short:
                    Debug.Assert(simpleType is Int16ValueRestriction);
                    break;

                case XsdType.Int:
                    Debug.Assert(simpleType is Int32ValueRestriction);
                    break;

                case XsdType.Long:
                    Debug.Assert(simpleType is Int64ValueRestriction);
                    break;

                case XsdType.UnsignedShort:
                    Debug.Assert(simpleType is UInt16ValueRestriction);
                    break;

                case XsdType.UnsignedInt:
                    Debug.Assert(simpleType is UInt32ValueRestriction);
                    break;

                case XsdType.UnsignedLong:
                    Debug.Assert(simpleType is UInt64ValueRestriction);
                    break;

                case XsdType.Double:
                    Debug.Assert(simpleType is DoubleValueRestriction);
                    break;

                case XsdType.Decimal:
                    Debug.Assert(simpleType is DecimalValueRestriction);
                    break;

                case XsdType.Integer:
                    Debug.Assert(simpleType is IntegerValueRestriction);
                    break;

                case XsdType.NonNegativeInteger:
                    Debug.Assert(simpleType is NonNegativeIntegerValueRestriction);
                    break;

                case XsdType.DateTime:
                    Debug.Assert(simpleType is DateTimeValueRestriction);
                    break;

                case XsdType.Base64Binary:
                    Debug.Assert(simpleType is Base64BinaryRestriction);
                    break;

                case XsdType.IDREF:
                case XsdType.NCName:
                    Debug.Assert(simpleType is NcNameRestriction);
                    break;

                case XsdType.Language:
                    Debug.Assert(simpleType is LanguageRestriction);
                    break;

                case XsdType.AnyURI:
                    Debug.Assert(simpleType is AnyUriRestriction);
                    break;

                case XsdType.Float:
                    Debug.Assert(simpleType is SingleValueRestriction);
                    break;

                case XsdType.PositiveInteger:
                    Debug.Assert(simpleType is PositiveIntegerValueRestriction);
                    break;

                //case XsdType.AnySimpleType:
                //    Debug.Assert(simpleType is OtherSimpleTypeRestriction);
                //    break;

                // enum, list 

                case XsdType.Enum:
                    Debug.Assert(simpleType is EnumValueRestriction);
                    break;

                case XsdType.List:
                    Debug.Assert(simpleType is ListValueRestriction);
                    break;

                case XsdType.QName:
                    Debug.Assert(simpleType is QnameRestriction);
                    break;

                case XsdType.ID:
                    Debug.Assert(simpleType is IdStringRestriction);
                    break;

                case XsdType.Union:
                    Debug.Assert(simpleType is UnionValueRestriction);
                    break;

                case XsdType.Date:
                    Debug.Assert(simpleType is DateValueRestriction);
                    break;

                case XsdType.Redirected:
                    Debug.Assert(simpleType is RedirectedRestriction);
                    break;

                default:
                    throw new InvalidDataException("The xsd type is not processed.");
            }

            simpleType.Verify();
        }
#endif

        #endregion
    }


    internal class SdbDataArray<T> 
        // : IEnumerable<T>
        where T : SdbData, new()
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte[] _sdbDataBytes;

        public SdbDataArray(byte[] sdbDataBytes)
        {
            Debug.Assert(sdbDataBytes != null);
            Debug.Assert(sdbDataBytes.Length > 0);

            this._sdbDataBytes = sdbDataBytes;
        }

        /// <summary>
        /// Indexer to retriver a specified data.
        /// </summary>
        /// <param name="index">The index of the data item.</param>
        /// <returns>Always returns a new data object.</returns>
        public T this[int index]
        {
            get
            {
                Debug.Assert(index >= 0);

                T sdbData = new T();

                Debug.Assert(index < this._sdbDataBytes.Length / sdbData.DataSize);

                sdbData.LoadFromBytes(this._sdbDataBytes, index * sdbData.DataSize);

                return sdbData;
            }
        }

        //#region IEnumerable<T> Members

        //public IEnumerator<T> GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        //#endregion

        //#region IEnumerable Members

        //System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        //#endregion
    }
}
