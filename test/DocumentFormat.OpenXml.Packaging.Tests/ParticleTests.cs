// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Xunit;

namespace DocumentFormat.OpenXml.Packaging.Tests
{
    public class ParticleTests
    {
        private readonly OpenXmlSchemaType _type = new(new OpenXmlQualifiedName("Test", "http://test.com"), new OpenXmlQualifiedName("Test", "http://test.com"));
        private readonly ITestOutputHelper _output;

        public ParticleTests(ITestOutputHelper output)
        {
            _output = output;
        }

        public static IEnumerable<object[]> Versions => FileFormatVersionExtensions.AllVersions.Select(v => new object[] { v });

        [Fact]
        public void RequireFilter()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1, requireFilter: true)
            {
                new CompositeParticle(ParticleType.Group,  1, 1),
                new CompositeParticle(ParticleType.Group,  1, 2, version: FileFormatVersions.Office2010),
            }.Build();

            var built2007 = Assert.IsType<CompositeParticle>(particle.Build(FileFormatVersions.Office2007));

            Assert.NotSame(particle, built2007);

            var result2007 = Assert.Single(built2007.ChildrenParticles);

            Assert.Equal(ParticleType.Group, result2007.ParticleType);
            Assert.Equal(1, result2007.MaxOccurs);

            var built2010 = Assert.IsType<CompositeParticle>(particle.Build(FileFormatVersions.Office2010));

            Assert.NotSame(particle, built2010);

            var result2010 = Assert.Single(built2010.ChildrenParticles);

            Assert.Equal(ParticleType.Group, result2010.ParticleType);
            Assert.Equal(2, result2010.MaxOccurs);
        }

        [Fact]
        public void CompositeSequenceVersion()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(_type, 1, 1),
                new AnyParticle(1, 1, version: FileFormatVersions.Office2010),
                new AnyParticle(0, 1, 1),
            }.Build();

            var built2007 = Assert.IsType<CompositeParticle>(particle.Build(FileFormatVersions.Office2007));

            Assert.NotSame(particle, built2007);

            Assert.Collection(
                built2007.ChildrenParticles,
                p => Assert.Same(p, particle.ChildrenParticles[0]),
                p => Assert.Same(p, particle.ChildrenParticles[2]));

            var built2010 = Assert.IsType<CompositeParticle>(particle.Build(FileFormatVersions.Office2010));

            Assert.NotSame(particle, built2010);

            Assert.Collection(
                built2010.ChildrenParticles,
                p => Assert.Same(p, particle.ChildrenParticles[0]),
                p => Assert.Same(p, particle.ChildrenParticles[1]),
                p => Assert.Same(p, particle.ChildrenParticles[2]));
        }

        [Fact]
        public void CompositeSequenceMultipleVersion()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(_type, 1, 1),
                new ElementParticle(_type, 1, 1, version: FileFormatVersions.Office2010),
                new AnyParticle(0, 1, 1),
            }.Build();

            var built2007 = Assert.IsType<CompositeParticle>(particle.Build(FileFormatVersions.Office2007));

            Assert.NotSame(particle, built2007);

            Assert.Collection(
                built2007.ChildrenParticles,
                p => Assert.Same(p, particle.ChildrenParticles[0]),
                p => Assert.Same(p, particle.ChildrenParticles[2]));

            var built2010 = Assert.IsType<CompositeParticle>(particle.Build(FileFormatVersions.Office2010));

            Assert.NotSame(particle, built2010);

            Assert.Collection(
                built2010.ChildrenParticles,
                p => Assert.Same(p, particle.ChildrenParticles[1]),
                p => Assert.Same(p, particle.ChildrenParticles[2]));
        }

        [MemberData(nameof(Versions))]
        [Theory]
        public void CompositeSequenceNoVersion(FileFormatVersions version)
        {
            var particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(_type, 1, 1),
                new AnyParticle(1, 1),
                new AnyParticle(0, 1, 1),
            }.Build();

            var built = Assert.IsType<CompositeParticle>(particle.Build(version));

            Assert.NotSame(particle, built);

            Assert.Collection(
                built.ChildrenParticles,
                p => Assert.Same(p, particle.ChildrenParticles[0]),
                p => Assert.Same(p, particle.ChildrenParticles[1]),
                p => Assert.Same(p, particle.ChildrenParticles[2]));
        }

        [MemberData(nameof(Versions))]
        [Theory]
        public void ElementParticleBuildSame(FileFormatVersions version)
        {
            var particle = new ElementParticle(_type, 1, 1);

            Assert.Same(particle, particle.Build(version));
        }

        [MemberData(nameof(Versions))]
        [Theory]
        public void AnyParticleBuildSame(FileFormatVersions version)
        {
            var particle = new AnyParticle(1, 1);

            Assert.Same(particle, particle.Build(version));
        }

        [Fact]
        public void ValidateExpectedParticles()
        {
            var exclude = new HashSet<Type>
            {
                typeof(OpenXmlUnknownElement),
                typeof(OpenXmlMiscNode),
            };

            var elements = typeof(SpreadsheetDocument).GetTypeInfo().Assembly.GetTypes()
                .Where(t => !t.GetTypeInfo().IsAbstract && typeof(OpenXmlElement).IsAssignableFrom(t))
                .Where(t => !exclude.Contains(t));

            var constraints = new Dictionary<Type, VersionCollection<ParticleConstraint>>();

            foreach (var version in FileFormatVersionExtensions.AllVersions)
            {
                foreach (var type in elements)
                {
                    var constructor = type.GetConstructor(Cached.Array<Type>());

                    if (constructor is not null)
                    {
#nullable disable
                        var element = (OpenXmlElement)Activator.CreateInstance(type);
#nullable enable

                        if (version.AtLeast(element!.InitialVersion))
                        {
                            var constraint = element.Metadata.Particle?.Particle?.Build(version);

                            if (constraint is not null)
                            {
                                if (constraints.TryGetValue(type, out var current))
                                {
                                    current.Add(version, constraint);
                                }
                                else
                                {
                                    constraints.Add(type, new VersionCollection<ParticleConstraint> { { version, constraint } });
                                }
                            }
                        }
                    }
                }
            }

            AssertEqual(constraints);
        }

        private void AssertEqual(Dictionary<Type, VersionCollection<ParticleConstraint>> constraints)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNamingPolicy = null,
                Converters =
                {
                    new JsonStringEnumConverter(),
                    new TypeNameConverter(),
                    new QNameConverter(),
                },
            };

            var tmp = Path.GetTempFileName();

            _output.WriteLine($"Writing output to {tmp}");
            _output.WriteLine(@"Expected output in data\Particles.json");

            using (var fs = File.OpenWrite(tmp))
            {
                fs.SetLength(0);

                var orderedData = constraints.OrderBy(t => t.Key.FullName, StringComparer.Ordinal);

                // Use Utf8JsonWriter with custom indentation to match expected format
                var writerOptions = new JsonWriterOptions
                {
                    Indented = true,
                    IndentSize = 1,
                };

                using (var writer = new Utf8JsonWriter(fs, writerOptions))
                {
                    JsonSerializer.Serialize(writer, orderedData, options);
                }
            }

            using (var expectedStream = typeof(ParticleTests).GetTypeInfo().Assembly.GetManifestResourceStream("DocumentFormat.OpenXml.Packaging.Tests.data.Particles.json"))
            using (var expectedStreamReader = new StreamReader(expectedStream!))
            using (var actualStream = File.OpenRead(tmp))
            using (var actualStreamReader = new StreamReader(actualStream))
            {
                var expected = expectedStreamReader.ReadToEnd().Replace("\r\n", "\n");
                var actual = actualStreamReader.ReadToEnd().Replace("\r\n", "\n");

                Assert.Equal(expected, actual);
            }
        }

        private class VersionCollection<T> : IEnumerable<KeyValuePair<FileFormatVersions, T>>
        {
            private readonly List<KeyValuePair<FileFormatVersions, T>> _dic = new List<KeyValuePair<FileFormatVersions, T>>();

            public VersionCollection()
            {
            }

            public VersionCollection(IEnumerable<KeyValuePair<FileFormatVersions, T>> items)
            {
                foreach (var item in items)
                {
                    Add(item.Key, item.Value);
                }
            }

            public void Add(FileFormatVersions key, T value)
            {
                foreach (var entry in _dic)
                {
                    if (entry.Value!.Equals(value))
                    {
                        _dic.Remove(entry);
                        _dic.Insert(0, new KeyValuePair<FileFormatVersions, T>(entry.Key | key, value));
                        return;
                    }
                }

                _dic.Add(new KeyValuePair<FileFormatVersions, T>(key, value));
            }

            public IEnumerator<KeyValuePair<FileFormatVersions, T>> GetEnumerator() => _dic.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        private sealed class TypeNameConverter : JsonConverter<Type>
        {
            public override Type? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override void Write(Utf8JsonWriter writer, Type value, JsonSerializerOptions options)
            {
                writer.WriteStringValue(value.FullName);
            }
        }

        private sealed class QNameConverter : JsonConverter<OpenXmlQualifiedName>
        {
            public override OpenXmlQualifiedName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override void Write(Utf8JsonWriter writer, OpenXmlQualifiedName value, JsonSerializerOptions options)
            {
                writer.WriteStringValue(value.ToString());
            }
        }
    }
}
