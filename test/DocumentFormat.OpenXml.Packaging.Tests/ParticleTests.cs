// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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

namespace DocumentFormat.OpenXml.Packaging.Tests
{
    public class ParticleTests
    {
        [Fact]
        public void ValidateExpectedParticles()
        {
            var exclude = new HashSet<Type>
            {
                typeof(OpenXmlUnknownElement),
                typeof(OpenXmlMiscNode),
            };

            var elements = typeof(OpenXmlElement).Assembly.GetTypes()
                .Where(t => !t.IsAbstract && typeof(OpenXmlElement).IsAssignableFrom(t))
                .Where(t => !exclude.Contains(t));

            var constraints = new Dictionary<Type, VersionCollection<ParticleConstraint>>();

            foreach (var version in FileFormatVersionExtensions.AllVersions)
            {
                var data = SdbSchemaData.GetSchemaData(version);
                foreach (var type in elements)
                {
                    var constructor = type.GetConstructor(Array.Empty<Type>());

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

        private static void AssertEqual(Dictionary<Type, VersionCollection<ParticleConstraint>> constraints)
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
                var expected = expectedStreamReader.ReadToEnd();
                var actual = actualStreamReader.ReadToEnd();

                Assert.Equal(expected, actual);
            }
        }

        private class OccursDefaultResolver : DefaultContractResolver
        {
            protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
            {
                var properties = base.CreateProperties(type, memberSerialization);

                foreach (var prop in properties)
                {
                    if (prop.PropertyName == nameof(ParticleConstraint.MinOccurs) || prop.PropertyName == nameof(ParticleConstraint.MaxOccurs))
                    {
                        prop.DefaultValue = 1;
                    }
                    else if (prop.PropertyName == nameof(ParticleConstraint.ChildrenParticles))
                    {
                        prop.PropertyType = typeof(IEnumerable<ParticleConstraint>);
                        prop.ShouldSerialize = c => ((ParticleConstraint)c).ChildrenParticles.Any();
                    }
                }

                return properties;
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
            {
                var name = reader.Value.ToString();

                return typeof(OpenXmlElement).Assembly.GetType(name);
            }

            public override void WriteJson(JsonWriter writer, Type value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value.FullName);
            }
        }
    }
}
