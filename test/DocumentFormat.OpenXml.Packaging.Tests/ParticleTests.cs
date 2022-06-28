// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Validation.Schema;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Packaging.Tests
{
    public class ParticleTests
    {
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
                new ElementParticle(typeof(ParticleTests), 1, 1),
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
                new ElementParticle(typeof(ParticleTests), 1, 1),
                new ElementParticle(typeof(ParticleTests), 1, 1, version: FileFormatVersions.Office2010),
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
                new ElementParticle(typeof(ParticleTests), 1, 1),
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
            var particle = new ElementParticle(typeof(ParticleTests), 1, 1);

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

            var elements = typeof(TypedFeatures).GetTypeInfo().Assembly.GetTypes()
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
                        var element = (OpenXmlElement)Activator.CreateInstance(type);

                        if (version.AtLeast(element.InitialVersion))
                        {
                            var constraint = element.Metadata.Particle.Particle?.Build(version);

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
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                Converters = new JsonConverter[]
                {
                    new StringEnumConverter(),
                    new TypeNameConverter(),
                },
                ContractResolver = new OccursDefaultResolver(),
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore,
            };

            var serializer = JsonSerializer.Create(settings);
            var tmp = Path.GetTempFileName();

            _output.WriteLine($"Writing output to {tmp}");
            _output.WriteLine(@"Expected output in data\Particles.json");

            using (var fs = File.OpenWrite(tmp))
            {
                fs.SetLength(0);

                using (var textWriter = new StreamWriter(fs))
                using (var writer = new JsonTextWriter(textWriter) { Indentation = 1 })
                {
                    serializer.Serialize(writer, constraints.OrderBy(t => t.Key.FullName, StringComparer.Ordinal));
                }
            }

            using (var expectedStream = typeof(ParticleTests).GetTypeInfo().Assembly.GetManifestResourceStream("DocumentFormat.OpenXml.Packaging.Tests.data.Particles.json"))
            using (var expectedStreamReader = new StreamReader(expectedStream))
            using (var actualStream = File.OpenRead(tmp))
            using (var actualStreamReader = new StreamReader(actualStream))
            {
                var expected = expectedStreamReader.ReadToEnd().Replace("\r\n", "\n");
                var actual = actualStreamReader.ReadToEnd().Replace("\r\n", "\n");

                Assert.Equal(expected, actual);
            }
        }

        private class OccursDefaultResolver : DefaultContractResolver
        {
            protected override JsonContract CreateContract(Type objectType)
            {
                // CompositeParticle implements IEnumerable to enable collection initializers, but we want it to serialize as if it were just the object
                if (objectType == typeof(CompositeParticle))
                {
                    return CreateObjectContract(objectType);
                }

                return base.CreateContract(objectType);
            }

            protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
            {
                var properties = base.CreateProperties(type, memberSerialization);

                foreach (var prop in properties)
                {
                    if (prop.PropertyName == nameof(ParticleConstraint.MinOccurs) || prop.PropertyName == nameof(ParticleConstraint.MaxOccurs))
                    {
                        prop.DefaultValue = 1;
                    }
                    else if (prop.PropertyName == nameof(ParticleConstraint.Version) || prop.PropertyName == nameof(CompositeParticle.RequireFilter))
                    {
                        prop.Ignored = true;
                    }
                    else if (prop.PropertyName == nameof(CompositeParticle.ChildrenParticles))
                    {
                        prop.PropertyType = typeof(IEnumerable<ParticleConstraint>);
                        prop.ShouldSerialize = c => ((CompositeParticle)c).ChildrenParticles.Any();
                    }
                }

                return properties.OrderBy(p => p.PropertyName).ToList();
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
                    if (entry.Value.Equals(value))
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

        private class TypeNameConverter : JsonConverter<Type>
        {
            public override Type ReadJson(JsonReader reader, Type objectType, Type existingValue, bool hasExistingValue, JsonSerializer serializer)
                => throw new NotImplementedException();

            public override void WriteJson(JsonWriter writer, Type value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value.FullName);
            }
        }
    }
}
