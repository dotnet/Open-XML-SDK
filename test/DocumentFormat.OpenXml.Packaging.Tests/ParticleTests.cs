﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Validation.Schema;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
        public void ExpectedKind()
        {
            var elements = typeof(OpenXmlElement).GetTypeInfo().Assembly.GetTypes()
                .Where(t => !t.GetTypeInfo().IsAbstract && typeof(OpenXmlCompositeElement).IsAssignableFrom(t) && t.GetConstructor(Cached.Array<Type>()) != null)
                .Select(t =>
                {
                    var element = (OpenXmlCompositeElement)Activator.CreateInstance(t);

                    return new ParticleInfo
                    {
                        Name = t.FullName,
                        Type = element.OpenXmlCompositeType,
                    };
                })
                .Where(p => p.Type != OpenXmlCompositeType.Other)
                .OrderBy(o => o.Name);

#if DEBUG
            var tmp = Path.GetTempFileName();

            _output.WriteLine($"Wrote to temp path {tmp}");

            File.WriteAllText(tmp, JsonConvert.SerializeObject(elements, Formatting.Indented, new StringEnumConverter()));
#endif

            var expected = GetData<IEnumerable<ParticleInfo>>("CompositeParticleTypes");

            CollectionAssert(expected, elements);
        }

        private static void CollectionAssert<T>(IEnumerable<T> expected, IEnumerable<T> actual)
        {
            Assert.Equal(expected.Count(), actual.Count());

            using (var e1 = expected.GetEnumerator())
            using (var e2 = actual.GetEnumerator())
            {
                while (e1.MoveNext() && e2.MoveNext())
                {
                    Assert.Equal(e1.Current, e2.Current);
                }
            }
        }

        private class ParticleInfo
        {
            public string Name { get; set; }

            public OpenXmlCompositeType Type { get; set; }

            public override bool Equals(object obj)
            {
                if (obj is ParticleInfo other)
                {
                    return string.Equals(Name, other.Name, StringComparison.Ordinal)
                        && Type == other.Type;
                }

                return false;
            }

            public override int GetHashCode() => Framework.HashCode.Combine(Name, Type);
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
                var data = SdbSchemaData.GetSchemaData(version);
                foreach (var type in elements)
                {
                    var constructor = type.GetConstructor(Cached.Array<Type>());

                    if (constructor != null)
                    {
                        var element = (OpenXmlElement)Activator.CreateInstance(type);

                        if (version.AtLeast(element.InitialVersion))
                        {
                            if (data.TryGetSchemaTypeData(element.ElementTypeId, out var typeData) && typeData != null)
                            {
                                if (constraints.TryGetValue(type, out var current))
                                {
                                    current.Add(version, typeData.ParticleConstraint);
                                }
                                else
                                {
                                    constraints.Add(type, new VersionCollection<ParticleConstraint> { { version, typeData.ParticleConstraint } });
                                }
                            }
                        }
                    }
                }
            }

            AssertEqual(constraints);
        }

        private static T GetData<T>(string name)
        {
            var serializer = JsonSerializer.Create();

            using (var stream = typeof(ParticleTests).GetTypeInfo().Assembly.GetManifestResourceStream($"DocumentFormat.OpenXml.Packaging.Tests.data.{name}.json"))
            using (var streamReader = new StreamReader(stream))
            using (var reader = new JsonTextReader(streamReader))
            {
                return serializer.Deserialize<T>(reader);
            }
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
