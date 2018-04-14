// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Validation.Schema
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
            const FileFormatVersions FileFormat = FileFormatVersions.Office2010;
            var classIds = new SdbClassIdToSchemaTypeIndex[5];
            var schemaTypes = new SdbSchemaType[8];
            var particleConstraints = new SdbParticleConstraint[2];
            var particleChildrenIndexes = new SdbParticleChildrenIndex[11];
            var attributes = new SdbAttributeConstraint[4];

            var instance = new SdbDataHead(
                FileFormat,
                classIds,
                schemaTypes,
                particleConstraints,
                particleChildrenIndexes,
                attributes);

            Assert.Equal(FileFormat, instance.FileFormat);

            Assert.Equal(SdbSpan.Create(instance.ClassIds.Offset, classIds), instance.ClassIds);
            Assert.Equal(instance.ClassIds.End, instance.SchemaType.Offset);

            Assert.Equal(SdbSpan.Create(instance.SchemaType.Offset, schemaTypes), instance.SchemaType);
            Assert.Equal(instance.SchemaType.End, instance.Particles.Offset);

            Assert.Equal(SdbSpan.Create(instance.Particles.Offset, particleConstraints), instance.Particles);
            Assert.Equal(instance.Particles.End, instance.ParticleChildren.Offset);

            Assert.Equal(SdbSpan.Create(instance.ParticleChildren.Offset, particleChildrenIndexes), instance.ParticleChildren);
            Assert.Equal(instance.ParticleChildren.End, instance.Attributes.Offset);

            Assert.Equal(SdbSpan.Create(instance.Attributes.Offset, attributes), instance.Attributes);
            Assert.Equal(instance.Attributes.End, instance.End);

            var expected = new byte[]
            {
                0xB7, 0x55, 0xDD, 0x06, 0x4D, 0xEF, 0xEE, 0x46, 0xA6, 0x18, 0x04, 0x2A, 0xF4,
                0xC3, 0x90, 0x4E, 0x02, 0x00, 0x00, 0x00, 0x50, 0x00, 0x00, 0x00, 0x05, 0x00,
                0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x64, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00,
                0x00, 0x08, 0x00, 0x00, 0x00, 0xA4, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00,
                0x0D, 0x00, 0x00, 0x00, 0xBE, 0x00, 0x00, 0x00, 0x0B, 0x00, 0x00, 0x00, 0x02,
                0x00, 0x00, 0x00, 0xD4, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x04, 0x00,
                0x00, 0x00,
            };

            var bytes = VerifyBytes(instance, expected);

            var deserialized = Assert.Single(Deserialize<SdbDataHead>(bytes));

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

            var bytes = VerifyBytes(instance, new byte[] { 0x32, 0x00, 0x3F, 0x00 });

            var deserialized = Assert.Single(Deserialize<SdbClassIdToSchemaTypeIndex>(bytes));

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

            var bytes = VerifyBytes(instance, new byte[] { 0x32, 0x00, 0x3F, 0x00, 0x14, 0x00, 0x0A, 0x00 });

            var deserialized = Assert.Single(Deserialize<SdbSchemaType>(bytes));

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

            var bytes = VerifyBytes(instance, new byte[] { 0x06, 0x12, 0x00, 0x02, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x50, 0x00, 0x84, 0x00 });

            var deserialized = Assert.Single(Deserialize<SdbParticleConstraint>(bytes));

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

            var bytes = VerifyBytes(instance, new byte[] { 0x3F, 0x00 });
            var deserialized = Assert.Single(Deserialize<SdbParticleChildrenIndex>(bytes));

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

            var bytes = VerifyBytes(instance, new byte[] { 0x02, 0x35, 0x00, 0x20 });
            var deserialized = Assert.Single(Deserialize<SdbAttributeConstraint>(bytes));

            Assert.Equal(AttributeUse, deserialized.AttributeUse);
            Assert.Equal(SimpleTypeIndex, deserialized.SimpleTypeIndex);
            Assert.Equal(FileFormatVersion, deserialized.FileFormatVersion);

            Assert.Equal(instance, deserialized);
        }

        [InlineData(FileFormatVersions.Office2007)]
        [InlineData(FileFormatVersions.Office2010)]
        [InlineData(FileFormatVersions.Office2013)]
        [Theory]
        public void ValidateFormats(FileFormatVersions version)
        {
            byte[] Roundtrip()
            {
                var data = SdbSchemaData.GetSchemaData(version);
                using (var ms = new MemoryStream())
                {
                    data.SerializeSdbData(ms);
                    return ms.ToArray();
                }
            }

            byte[] GetStream()
            {
                using (var stream = SdbSchemaData.GetStream(version, SdbSchemaData.Constraints))
                using (var ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    return ms.ToArray();
                }
            }

            var expected = GetStream();
            var actual = Roundtrip();

            Assert.Equal(expected.Length, actual.Length);
            Assert.Equal(expected, actual);
        }

        private byte[] VerifyBytes<T>(T instance, byte[] expected)
            where T : struct
        {
            var structLayout = typeof(T).GetTypeInfo().StructLayoutAttribute;

            Assert.NotNull(structLayout);
            Assert.Equal(LayoutKind.Sequential, structLayout.Value);
            Assert.Equal(1, structLayout.Pack);

            var serialized = SdbData.Serialize(new[] { instance });

            var str = string.Join(", ", serialized.Select(t => "0x" + t.ToString("X2")));
            _output.WriteLine($"{{{str}}}");

            Assert.Equal(expected.Length, Marshal.SizeOf<T>());
            Assert.Equal(expected.Length, serialized.Length);
            Assert.Equal(expected, serialized);

            return serialized;
        }

        private static T[] Deserialize<T>(byte[] data)
            where T : struct
        {
            using (var ms = new MemoryStream(data))
            {
                return SdbData.Deserialize<T>(ms, SdbSpan.Create<T>(0));
            }
        }
    }
}
