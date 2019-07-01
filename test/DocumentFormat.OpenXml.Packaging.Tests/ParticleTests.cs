// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Wordprocessing;
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

        [Fact]
        public void V()
        {
            var p = new ColorMostRecentlyUsed();
            var fn = new FunctionName();
            var j = fn.ParticleConstraint.Build(FileFormatVersions.Office2010);
            var v7 = p.ParticleConstraint.Build(FileFormatVersions.Office2007);
            var v10 = p.ParticleConstraint.Build(FileFormatVersions.Office2010);
        }

        [Fact]
        public void ValidateExpectedParticles()
        {
            var exclude = new HashSet<Type>
            {
                typeof(OpenXmlUnknownElement),
                typeof(OpenXmlMiscNode),
            };

            var elements = typeof(OpenXmlElement).GetTypeInfo().Assembly.GetTypes()
                .Where(t => !t.GetTypeInfo().IsAbstract && typeof(OpenXmlElement).IsAssignableFrom(t))
                .Where(t => !exclude.Contains(t));

            var constraints = new Dictionary<Type, VersionCollection<ParticleConstraint>>();

            foreach (var version in FileFormatVersionExtensions.AllVersions)
            {
                foreach (var type in elements)
                {
                    var constructor = type.GetConstructor(Cached.Array<Type>());

                    if (constructor != null)
                    {
                        var element = (OpenXmlElement)Activator.CreateInstance(type);

                        if (version.AtLeast(element.InitialVersion))
                        {
                            var constraint = element.ParticleConstraint?.Build(version);

                            if (constraint != null)
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

            using (var fs = File.OpenWrite(tmp))
            {
                fs.SetLength(0);

                using (var textWriter = new StreamWriter(fs))
                using (var writer = new JsonTextWriter(textWriter) { Indentation = 1 })
                {
                    serializer.Serialize(writer, constraints.OrderBy(t => t.Key.FullName));
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
