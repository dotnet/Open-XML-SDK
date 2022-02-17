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

    public static T? Load<T>(string? text)
    {
        if (text is null)
        {
            return default;
        }

        return JsonConvert.DeserializeObject<T>(text, _settings);
    }
}
