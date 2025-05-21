// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Converters;
using DocumentFormat.OpenXml.Generator.Models;
using DocumentFormat.OpenXml.Generator.Schematron;
using System.Collections.Immutable;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DocumentFormat.OpenXml.Generator;

public record OpenXmlGeneratorDataSource
{
    private static readonly JsonSerializerOptions _options = new()
    {
        Converters =
        {
            new JsonStringEnumConverter(),
            new QualifiedNameConverter(),
            new TypedQNameConverter(),
        },
    };

    public static T? Deserialize<T>(string? content) => content is null ? default : JsonSerializer.Deserialize<T>(content, _options);

    public ImmutableArray<NamespaceInfo> KnownNamespaces { get; init; } = ImmutableArray.Create<NamespaceInfo>();

    public ImmutableArray<SchemaNamespace> Namespaces { get; init; } = ImmutableArray.Create<SchemaNamespace>();

    public ImmutableArray<Part> Parts { get; init; } = ImmutableArray.Create<Part>();

    public ImmutableArray<SchematronEntry> Schematrons { get; init; } = ImmutableArray.Create<SchematronEntry>();

    public ImmutableArray<StronglyTypedNamespace> TypedNamespaces { get; init; } = ImmutableArray.Create<StronglyTypedNamespace>();

    public ImmutableArray<StronglyTypedElement> TypedClasses { get; init; } = ImmutableArray.Create<StronglyTypedElement>();

    public ImmutableArray<Part> Packages { get; init; } = ImmutableArray.Create<Part>();
}
