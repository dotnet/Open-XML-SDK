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
        public void SdbClassIdToSchemaTypeIndexTest()
        {
            const ushort ClassId = 50;
            const ushort SchemaTypeIndex = 63;

            var instance = new SdbClassIdToSchemaTypeIndex(ClassId, SchemaTypeIndex);

            Assert.Equal(ClassId, instance.ClassId);
            Assert.Equal(SchemaTypeIndex, instance.SchemaTypeIndex);

            var bytes = WriteBytes(instance.GetBytes());

            Assert.True(bytes.SequenceEqual(new byte[] { 0x32, 0x00, 0x3F, 0x00 }));

            var deserialized = new SdbClassIdToSchemaTypeIndex();
            deserialized.LoadFromBytes(bytes, 0);

            Assert.Equal(ClassId, deserialized.ClassId);
            Assert.Equal(SchemaTypeIndex, deserialized.SchemaTypeIndex);
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

            var bytes = WriteBytes(instance.GetBytes());

            Assert.True(bytes.SequenceEqual(new byte[] { 0x32, 0x00, 0x3F, 0x00, 0x14, 0x00, 0x0A, 0x00 }));

            var deserialized = new SdbSchemaType();
            deserialized.LoadFromBytes(bytes, 0);

            Assert.Equal(ParticleIndex, deserialized.ParticleIndex);
            Assert.Equal(SimpleTypeIndex, deserialized.SimpleTypeIndex);
            Assert.Equal(AttributesCount, deserialized.AttributesCount);
            Assert.Equal(StartIndexOfAttributes, deserialized.StartIndexOfAttributes);
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

            var instance = new SdbParticleConstraint
            {
                ParticleType = ParticleType,
                ElementTypeId = ElementTypeId,
                MinOccurs = MinOccurs,
                MaxOccurs = MaxOccurs,
                ChildrenCount = ChildrenCount,
                ChildrenStartIndex = ChildrenStartIndex,
            };

            Assert.Equal(ParticleType, instance.ParticleType);
            Assert.Equal(ElementTypeId, instance.ElementTypeId);
            Assert.Equal(MinOccurs, instance.MinOccurs);
            Assert.Equal(MaxOccurs, instance.MaxOccurs);
            Assert.Equal(ChildrenCount, instance.ChildrenCount);
            Assert.Equal(ChildrenStartIndex, instance.ChildrenStartIndex);

            var bytes = WriteBytes(instance.GetBytes());
            Assert.True(bytes.SequenceEqual(new byte[] { 0x06, 0x12, 0x00, 0x02, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x50, 0x00, 0x84, 0x00 }));

            var deserialized = new SdbParticleConstraint();
            deserialized.LoadFromBytes(bytes, 0);

            Assert.Equal(ParticleType, deserialized.ParticleType);
            Assert.Equal(ElementTypeId, deserialized.ElementTypeId);
            Assert.Equal(MinOccurs, deserialized.MinOccurs);
            Assert.Equal(MaxOccurs, deserialized.MaxOccurs);
            Assert.Equal(ChildrenCount, deserialized.ChildrenCount);
            Assert.Equal(ChildrenStartIndex, deserialized.ChildrenStartIndex);
        }

        [Fact]
        public void SdbParticleChildrenIndexTest()
        {
            const ushort ParticleIndex = 63;

            var instance = new SdbParticleChildrenIndex(ParticleIndex);

            Assert.Equal(ParticleIndex, instance.ParticleIndex);

            var bytes = WriteBytes(instance.GetBytes());

            Assert.True(bytes.SequenceEqual(new byte[] { 0x3F, 0x00 }));

            var deserialized = new SdbParticleChildrenIndex();
            deserialized.LoadFromBytes(bytes, 0);

            Assert.Equal(ParticleIndex, deserialized.ParticleIndex);
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

            var bytes = WriteBytes(instance.GetBytes());

            Assert.True(bytes.SequenceEqual(new byte[] { 0x02, 0x35, 0x00, 0x20 }));

            var deserialized = new SdbAttributeConstraint();
            deserialized.LoadFromBytes(bytes, 0);

            Assert.Equal(AttributeUse, deserialized.AttributeUse);
            Assert.Equal(SimpleTypeIndex, deserialized.SimpleTypeIndex);
            Assert.Equal(FileFormatVersion, deserialized.FileFormatVersion);
        }

        private byte[] WriteBytes(byte[] bytes)
        {
            var str = string.Join(", ", bytes.Select(t => "0x" + t.ToString("X2")));
            _output.WriteLine($"{{{str}}}");
            return bytes;
        }
    }
}
