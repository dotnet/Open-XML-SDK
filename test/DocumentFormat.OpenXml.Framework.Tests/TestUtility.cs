// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    internal static class TestUtility
    {
        private static readonly JsonSerializerOptions _options = new()
        {
            Converters =
            {
                new OpenXmlNamespaceConverter(),
                new OpenXmlQNameConverter(),
                new JsonStringEnumConverter(),
            },
            WriteIndented = true,
        };

        public static T Deserialize<T>(string name)
        {
            using (var stream = typeof(TestUtility).GetTypeInfo().Assembly.GetManifestResourceStream($"DocumentFormat.OpenXml.Framework.Tests.{name}"))
            using (var reader = new StreamReader(stream))
            {
                var txt = reader.ReadToEnd();

                return JsonSerializer.Deserialize<T>(txt, _options);
            }
        }

        public static string Serialize<T>(T obj) => JsonSerializer.Serialize(obj, _options);

        private sealed class OpenXmlQNameConverter : JsonConverter<OpenXmlQualifiedName>
        {
            public override OpenXmlQualifiedName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.GetString() is { } str && str.Split('*') is [{ } ns, { } name])
                {
                    return new OpenXmlQualifiedName(new OpenXmlNamespace(ns), name);
                }

                return default;
            }

            public override void Write(Utf8JsonWriter writer, OpenXmlQualifiedName value, JsonSerializerOptions options)
            {
                writer.WriteStringValue($"{value.Namespace}*{value.Name}");
            }
        }

        private sealed class OpenXmlNamespaceConverter : JsonConverter<OpenXmlNamespace>
        {
            public override OpenXmlNamespace Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.GetString() is string str)
                {
                    return new OpenXmlNamespace(str);
                }

                return default;
            }

            public override void Write(Utf8JsonWriter writer, OpenXmlNamespace value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToString());
        }
    }
}
