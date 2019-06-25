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
using Xunit;

namespace DocumentFormat.OpenXml.Packaging.Tests
{
    public class ParticleTests
    {
        [Fact]
        public void Test1()
        {
            var exclude = new HashSet<Type>
            {
                typeof(OpenXmlUnknownElement),
                typeof(OpenXmlMiscNode),
            };

            var elements = typeof(OpenXmlElement).Assembly.GetTypes()
                .Where(t => !t.IsAbstract && typeof(OpenXmlElement).IsAssignableFrom(t))
                .Where(t => !exclude.Contains(t));

            var set = new Dictionary<Type, VersionCollection<ParticleConstraint>>();

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
                                if (set.TryGetValue(type, out var current))
                                {
                                    current.Add(version, typeData.ParticleConstraint);
                                }
                                else
                                {
                                    set.Add(type, new VersionCollection<ParticleConstraint> { { version, typeData.ParticleConstraint } });
                                }
                            }
                        }
                    }
                }
            }

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

            using (var fs = File.OpenWrite($@"C:\Users\tasou\Projects\Software\Open-XML-SDK\test\DocumentFormat.OpenXml.Packaging.Tests\data\Particles.json"))
            {
                fs.SetLength(0);

                using (var textWriter = new StreamWriter(fs))
                using (var writer = new JsonTextWriter(textWriter) { Indentation = 1 })
                {
                    serializer.Serialize(writer, set.OrderBy(t => t.Key.FullName));
                }
            }
        }

        private class OccursDefaultResolver : DefaultContractResolver
        {
            protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
            {
                var properties = base.CreateProperties(type, memberSerialization);
                var children = default(JsonProperty);

                foreach (var prop in properties)
                {
                    if (prop.PropertyName == nameof(ParticleConstraint.MinOccurs) || prop.PropertyName == nameof(ParticleConstraint.MaxOccurs))
                    {
                        prop.DefaultValue = 1;
                    }
                    else if (prop.PropertyName == nameof(ParticleConstraint.ChildrenParticles))
                    {
                        children = prop;
                        prop.DefaultValue = Cached.Array<ParticleConstraint>();
                    }
                }

                if (children != null)
                {
                    properties.Remove(children);
                    properties.Insert(0, children);
                }

                return properties;
            }
        }

        private class ParticleConstraintConverter : JsonConverter<ParticleConstraint>
        {
            public override ParticleConstraint ReadJson(JsonReader reader, Type objectType, ParticleConstraint existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }

            public override void WriteJson(JsonWriter writer, ParticleConstraint value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
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
            public override bool CanWrite => true;

            public override bool CanRead => base.CanRead;

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
