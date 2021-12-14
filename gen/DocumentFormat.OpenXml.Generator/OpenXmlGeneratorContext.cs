// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DocumentFormat.OpenXml.Generator;

public record OpenXmlGeneratorContext
{
    private static readonly JsonSerializer _serializer = JsonSerializer.Create(new()
    {
        Converters = new[]
        {
            new StringEnumConverter(),
        },
    });

    public static OpenXmlGeneratorContext Shared { get; } = Load();

    public IEnumerable<NamespaceInfo> Namespaces { get; init; } = Enumerable.Empty<NamespaceInfo>();

    public static OpenXmlGeneratorContext Load()
        => new()
        {
            Namespaces = Load<NamespaceInfo[]>("namespaces.json"),
        };

    private static T Load<T>(string name)
    {
        using var stream = typeof(OpenXmlGeneratorContext).Assembly.GetManifestResourceStream(typeof(OpenXmlGeneratorContext), $"Data.{name}");

        if (stream is null)
        {
            throw new InvalidOperationException($"Could not find stream '{name}'");
        }

        using var text = new StreamReader(stream);
        using var reader = new JsonTextReader(text);

        return _serializer.Deserialize<T>(reader)!;
    }
}
