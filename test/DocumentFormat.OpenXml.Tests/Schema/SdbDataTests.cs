// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Packaging.Tests
{
    public class SdbDataTests
    {
        private readonly ITestOutputHelper _output;

        public SdbDataTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void SdbDataHeadTest()
        {
            const int DataVersion = 0x00010000;
            const int DataByteCount = 5323;
            const int StartClassId = 16;
            const int ClassIdsCount = 32;
            const int ClassIdsDataOffset = 124;
            const int SchemaTypeCount = 6432;
            const int SchemaTypeDataOffset = 1234;
            const int ParticleCount = 62234;
            const int ParticleDataOffset = 1536;
            const int ParticleChildrenIndexCount = 2314;
            const int ParticleChildrenIndexDataOffset = 187;
            const int AttributeCount = 7908;
            const int AttributeDataOffset = 7587;
            const int SimpleTypeCount = 4887;
            const int SimpleTypeDataOffset = 5980;

            var instance = new SdbDataHead(
                DataVersion,
                DataByteCount,
                StartClassId,
                ClassIdsCount,
                ClassIdsDataOffset,
                SchemaTypeCount,
                SchemaTypeDataOffset,
                ParticleCount,
                ParticleDataOffset,
                ParticleChildrenIndexCount,
                ParticleChildrenIndexDataOffset,
                AttributeCount,
                AttributeDataOffset,
                SimpleTypeCount,
                SimpleTypeDataOffset);

            Assert.Equal(DataVersion, instance.DataVersion);
            Assert.Equal(DataByteCount, instance.DataByteCount);
            Assert.Equal(StartClassId, instance.StartClassId);
            Assert.Equal(ClassIdsCount, instance.ClassIdsCount);
            Assert.Equal(ClassIdsDataOffset, instance.ClassIdsDataOffset);
            Assert.Equal(SchemaTypeCount, instance.SchemaTypeCount);
            Assert.Equal(SchemaTypeDataOffset, instance.SchemaTypeDataOffset);
            Assert.Equal(ParticleCount, instance.ParticleCount);
            Assert.Equal(ParticleDataOffset, instance.ParticleDataOffset);
            Assert.Equal(ParticleChildrenIndexCount, instance.ParticleChildrenIndexCount);
            Assert.Equal(ParticleChildrenIndexDataOffset, instance.ParticleChildrenIndexDataOffset);
            Assert.Equal(AttributeCount, instance.AttributeCount);
            Assert.Equal(AttributeDataOffset, instance.AttributeDataOffset);
            Assert.Equal(SimpleTypeCount, instance.SimpleTypeCount);
            Assert.Equal(SimpleTypeDataOffset, instance.SimpleTypeDataOffset);

            var bytes = WriteBytes(instance.Serialize());
            var expected = new byte[]
            {
                0x4F, 0x50, 0x45, 0x4E, 0x58, 0x4D, 0x4C, 0x20, 0x53, 0x43, 0x48, 0x4D, 0x20, 0x20, 0x20,
                0x20, 0x00, 0x00, 0x01, 0x00, 0xCB, 0x14, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00, 0x20, 0x00,
                0x00, 0x00, 0x7C, 0x00, 0x00, 0x00, 0x20, 0x19, 0x00, 0x00, 0xD2, 0x04, 0x00, 0x00, 0x1A,
                0xF3, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x0A, 0x09, 0x00, 0x00, 0xBB, 0x00, 0x00, 0x00,
                0xE4, 0x1E, 0x00, 0x00, 0xA3, 0x1D, 0x00, 0x00, 0x17, 0x13, 0x00, 0x00, 0x5C, 0x17, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            };

            Assert.Equal(expected, bytes);

            var deserialized = SdbDataHead.Deserialize(bytes, 0);

            Assert.Equal(DataVersion, deserialized.DataVersion);
            Assert.Equal(DataByteCount, deserialized.DataByteCount);
            Assert.Equal(StartClassId, deserialized.StartClassId);
            Assert.Equal(ClassIdsCount, deserialized.ClassIdsCount);
            Assert.Equal(ClassIdsDataOffset, deserialized.ClassIdsDataOffset);
            Assert.Equal(SchemaTypeCount, deserialized.SchemaTypeCount);
            Assert.Equal(SchemaTypeDataOffset, deserialized.SchemaTypeDataOffset);
            Assert.Equal(ParticleCount, deserialized.ParticleCount);
            Assert.Equal(ParticleDataOffset, deserialized.ParticleDataOffset);
            Assert.Equal(ParticleChildrenIndexCount, deserialized.ParticleChildrenIndexCount);
            Assert.Equal(ParticleChildrenIndexDataOffset, deserialized.ParticleChildrenIndexDataOffset);
            Assert.Equal(AttributeCount, deserialized.AttributeCount);
            Assert.Equal(AttributeDataOffset, deserialized.AttributeDataOffset);
            Assert.Equal(SimpleTypeCount, deserialized.SimpleTypeCount);
            Assert.Equal(SimpleTypeDataOffset, deserialized.SimpleTypeDataOffset);

            Assert.Equal(instance, deserialized);
        }

        [Fact]
        public void SdbClassIdToSchemaTypeIndexTest()
        {
            const ushort ClassId = 50;
            const ushort SchemaTypeIndex = 63;

            var instance = new SdbClassIdToSchemaTypeIndex(ClassId, SchemaTypeIndex);

            Assert.Equal(ClassId, instance.ClassId);
            Assert.Equal(SchemaTypeIndex, instance.SchemaTypeIndex);

            var bytes = WriteBytes(instance.Serialize());

            Assert.True(bytes.SequenceEqual(new byte[] { 0x32, 0x00, 0x3F, 0x00 }));

            var deserialized = SdbClassIdToSchemaTypeIndex.Deserialize(bytes, 0);

            Assert.Equal(ClassId, deserialized.ClassId);
            Assert.Equal(SchemaTypeIndex, deserialized.SchemaTypeIndex);

            Assert.Equal(instance, deserialized);
        }

        [Fact]
        public void SdbSchemaTypeTest()
        {
            const ushort ParticleIndex = 50;
            const ushort SimpleTypeIndex = 63;
            const ushort AttributesCount = 20;
            const ushort StartIndexOfAttributes = 10;

            var instance = new SdbSchemaType(ParticleIndex, SimpleTypeIndex, AttributesCount, StartIndexOfAttributes);

            Assert.Equal(ParticleIndex, instance.ParticleIndex);
            Assert.Equal(SimpleTypeIndex, instance.SimpleTypeIndex);
            Assert.Equal(AttributesCount, instance.AttributesCount);
            Assert.Equal(StartIndexOfAttributes, instance.StartIndexOfAttributes);

            var bytes = WriteBytes(instance.Serialize());

            Assert.True(bytes.SequenceEqual(new byte[] { 0x32, 0x00, 0x3F, 0x00, 0x14, 0x00, 0x0A, 0x00 }));

            var deserialized = SdbSchemaType.Deserialize(bytes, 0);

            Assert.Equal(ParticleIndex, deserialized.ParticleIndex);
            Assert.Equal(SimpleTypeIndex, deserialized.SimpleTypeIndex);
            Assert.Equal(AttributesCount, deserialized.AttributesCount);
            Assert.Equal(StartIndexOfAttributes, deserialized.StartIndexOfAttributes);

            Assert.Equal(instance, deserialized);
        }

        [Fact]
        public void SdbParticleConstraintTest()
        {
            const ParticleType ParticleType = ParticleType.AnyWithUri;
            const ushort ElementTypeId = 18;
            const ushort MinOccurs = 2;
            const int MaxOccurs = 60;
            const ushort ChildrenCount = 80;
            const ushort ChildrenStartIndex = 132;

            var instance = new SdbParticleConstraint(ParticleType, ElementTypeId, MinOccurs, MaxOccurs, ChildrenCount, ChildrenStartIndex);

            Assert.Equal(ParticleType, instance.ParticleType);
            Assert.Equal(ElementTypeId, instance.ElementTypeId);
            Assert.Equal(MinOccurs, instance.MinOccurs);
            Assert.Equal(MaxOccurs, instance.MaxOccurs);
            Assert.Equal(ChildrenCount, instance.ChildrenCount);
            Assert.Equal(ChildrenStartIndex, instance.ChildrenStartIndex);

            var bytes = WriteBytes(instance.GetBytes());
            Assert.True(bytes.SequenceEqual(new byte[] { 0x06, 0x12, 0x00, 0x02, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x50, 0x00, 0x84, 0x00 }));

            var deserialized = SdbParticleConstraint.Deserialize(bytes, 0);

            Assert.Equal(ParticleType, deserialized.ParticleType);
            Assert.Equal(ElementTypeId, deserialized.ElementTypeId);
            Assert.Equal(MinOccurs, deserialized.MinOccurs);
            Assert.Equal(MaxOccurs, deserialized.MaxOccurs);
            Assert.Equal(ChildrenCount, deserialized.ChildrenCount);
            Assert.Equal(ChildrenStartIndex, deserialized.ChildrenStartIndex);

            Assert.Equal(instance, deserialized);
        }

        [Fact]
        public void SdbParticleChildrenIndexTest()
        {
            const ushort ParticleIndex = 63;

            var instance = new SdbParticleChildrenIndex(ParticleIndex);

            Assert.Equal(ParticleIndex, instance.ParticleIndex);

            var bytes = WriteBytes(instance.Serialize());

            Assert.True(bytes.SequenceEqual(new byte[] { 0x3F, 0x00 }));

            var deserialized = SdbParticleChildrenIndex.Deserialize(bytes, 0);

            Assert.Equal(ParticleIndex, deserialized.ParticleIndex);

            Assert.Equal(instance, deserialized);
        }

        [Fact]
        public void SdbAttributeConstraintTest()
        {
            const XsdAttributeUse AttributeUse = XsdAttributeUse.Prohibited;
            const ushort SimpleTypeIndex = 53;
            const byte FileFormatVersion = 32;

            var instance = new SdbAttributeConstraint(AttributeUse, SimpleTypeIndex, FileFormatVersion);

            Assert.Equal(AttributeUse, instance.AttributeUse);
            Assert.Equal(SimpleTypeIndex, instance.SimpleTypeIndex);
            Assert.Equal(FileFormatVersion, instance.FileFormatVersion);

            var bytes = WriteBytes(instance.Serialize());

            Assert.True(bytes.SequenceEqual(new byte[] { 0x02, 0x35, 0x00, 0x20 }));

            var deserialized = SdbAttributeConstraint.Deserialize(bytes, 0);

            Assert.Equal(AttributeUse, deserialized.AttributeUse);
            Assert.Equal(SimpleTypeIndex, deserialized.SimpleTypeIndex);
            Assert.Equal(FileFormatVersion, deserialized.FileFormatVersion);

            Assert.Equal(instance, deserialized);
        }

        private byte[] WriteBytes(byte[] bytes)
        {
            var str = string.Join(", ", bytes.Select(t => "0x" + t.ToString("X2")));
            _output.WriteLine($"{{{str}}}");
            return bytes;
        }
    }
}
