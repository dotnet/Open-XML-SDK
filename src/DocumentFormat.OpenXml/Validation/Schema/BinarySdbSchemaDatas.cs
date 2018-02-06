// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Validation.Schema.Restrictions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

using SdbIndex = System.UInt16;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    internal class BinarySdbSchemaDatas : SdbSchemaDatas
    {
        private FileFormatVersions _fileFormat;

        public BinarySdbSchemaDatas(FileFormatVersions fileFormat)
        {
            Debug.Assert(fileFormat.Any());

            this.SdbDataHead = new SdbDataHead();
            this._fileFormat = fileFormat;

            using (var schema = GetSchemaStream(fileFormat))
            {
                this.Load(schema);
            }
        }

        private static Stream GetSchemaStream(FileFormatVersions fileFormat)
        {
            Stream GetEmbeddedResource(string name)
            {
                return typeof(ValidationResources).GetTypeInfo().Assembly.GetManifestResourceStream($"DocumentFormat.OpenXml.GeneratedCode.{name}.bin");
            }

            switch (fileFormat)
            {
                case FileFormatVersions.Office2007:
                    return GetEmbeddedResource("O12SchemaConstraintDatas");
                case FileFormatVersions.Office2010:
                    return GetEmbeddedResource("O14SchemaConstraintDatas");
                case FileFormatVersions.Office2013:
                    return GetEmbeddedResource("O15SchemaConstraintDatas");
                default:
                    Debug.Assert(fileFormat.Any());
                    return GetEmbeddedResource("O12SchemaConstraintDatas");
            }
        }

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

#if DEBUG
            CheckDataHead((int)dataStream.Length);
#endif

            byte[] dataBytes;
            int count;

            // class ID map
            count = this.SdbDataHead.ClassIdsCount * SdbClassIdToSchemaTypeIndex.TypeSize;
            dataBytes = new byte[count];
            dataStream.Read(dataBytes, 0, count);
            this.SdbClassIdMap = new SdbDataArray<SdbClassIdToSchemaTypeIndex>(dataBytes, SdbDataHead.ClassIdsCount);

            // schema types
            count = this.SdbDataHead.SchemaTypeCount * SdbSchemaType.TypeSize;
            dataBytes = new byte[count];
            dataStream.Read(dataBytes, 0, count);
            this.SdbSchemaTypes = new SdbDataArray<SdbSchemaType>(dataBytes, SdbDataHead.SchemaTypeCount);

            // particle constraints
            count = this.SdbDataHead.ParticleCount * SdbParticleConstraint.TypeSize;
            dataBytes = new byte[count];
            dataStream.Read(dataBytes, 0, count);
            this.SdbParticles = new SdbDataArray<SdbParticleConstraint>(dataBytes, SdbDataHead.ParticleCount);

            // particle children index
            count = this.SdbDataHead.ParticleChildrenIndexCount * SdbParticleChildrenIndex.TypeSize;
            dataBytes = new byte[count];
            dataStream.Read(dataBytes, 0, count);
            this.SdbParticleIndexs = new SdbDataArray<SdbParticleChildrenIndex>(dataBytes, SdbDataHead.ParticleChildrenIndexCount);

            // attribute constraints
            count = this.SdbDataHead.AttributeCount * SdbAttributeConstraint.TypeSize;
            dataBytes = new byte[count];
            dataStream.Read(dataBytes, 0, count);
            this.SdbAttributes = new SdbDataArray<SdbAttributeConstraint>(dataBytes, SdbDataHead.AttributeCount);

            // simple type constraints
            dataStream.Seek(this.SdbDataHead.SimpleTypeDataOffset, SeekOrigin.Begin);
            this.SimpleTypeRestrictions = Restrictions.SimpleTypeRestrictions.Deserialize(dataStream, this._fileFormat);

#if DEBUG
            Assert(this.SdbDataHead.SimpleTypeCount == this.SimpleTypeRestrictions.SimpleTypeCount);

            CheckData();
#endif
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

#if DEBUG
        /// <summary>
        /// Make sure that the SdbDataHead data is correct.
        /// </summary>
        /// <param name="streamLength">The length of the data.</param>
        private void CheckDataHead(int streamLength)
        {
            var dataHead = this.SdbDataHead;

            Assert(dataHead.StartClassId == 10001);

            // head data saved only in head
            Assert(dataHead.DataByteCount + SdbDataHead.HeadSize == streamLength);
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
            if (!value)
            {
                throw new InvalidDataException("Invalid schema constraint binary data.");
            }
        }

        /// <summary>
        /// Check the loaded schema constraint datas.
        /// </summary>
        private void CheckData()
        {
            SdbClassIdToSchemaTypeIndex classIdData;

            // check all datas in debug build
            for (var classId = SdbClassIdToSchemaTypeIndex.StartClassId; classId < SdbClassIdToSchemaTypeIndex.StartClassId + this.SdbDataHead.ClassIdsCount - 1; classId++)
            {
                classIdData = GetClassIdData(classId);
                Debug.Assert(classIdData.ClassId == classId);

                CheckSchemaType(classIdData.SchemaTypeIndex);
            }
        }

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

        private class SdbDataArray<T> : IReadOnlyList<T>
            where T : SdbData, new()
        {
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private byte[] _sdbDataBytes;

            public SdbDataArray(byte[] sdbDataBytes, int count)
            {
                Debug.Assert(sdbDataBytes != null);
                Debug.Assert(sdbDataBytes.Length > 0);

                this._sdbDataBytes = sdbDataBytes;

                Count = count;
            }

            public int Count { get; }

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

            public IEnumerator<T> GetEnumerator()
            {
                return new SdbDataArrayIterator(Count, index => this[index]);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return new SdbDataArrayIterator(Count, index => this[index]);
            }

            private sealed class SdbDataArrayIterator : IEnumerator<T>
            {
                private readonly int _max;
                private readonly Func<int, T> _index;

                private int _count;

                public SdbDataArrayIterator(int max, Func<int, T> index)
                {
                    _max = max;
                    _index = index;
                    _count = 0;
                }

                public T Current { get; private set; }

                object IEnumerator.Current => Current;

                public void Dispose()
                {
                }

                public bool MoveNext()
                {
                    if (_count < _max)
                    {
                        Current = _index(_count);
                        _count++;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                public void Reset()
                {
                    _count = 0;
                }
            }
        }
    }
}
