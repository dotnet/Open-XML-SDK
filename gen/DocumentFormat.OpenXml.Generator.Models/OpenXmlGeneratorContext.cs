// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Immutable;

namespace DocumentFormat.OpenXml.Generator;

public record OpenXmlGeneratorContext
{
    private static readonly JsonSerializerSettings _settings = new()
    {
        Converters = new[]
        {
            new StringEnumConverter(),
        },
    };

    public ImmutableArray<NamespaceInfo> Namespaces { get; init; } = ImmutableArray.Create<NamespaceInfo>();

    public static OpenXmlGeneratorContext Load(IContextData data)
        => new()
        {
            Namespaces = Load(data.Namespaces, Array.Empty<NamespaceInfo>()).ToImmutableArray(),
        };

    private static T Load<T>(string text, T defaultValue)
    {
        if (string.IsNullOrEmpty(text))
        {
            return defaultValue;
        }

        return JsonConvert.DeserializeObject<T>(text) ?? defaultValue;
    }
}
