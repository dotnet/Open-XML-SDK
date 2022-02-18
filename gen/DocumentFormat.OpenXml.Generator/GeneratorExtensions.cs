// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;
using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

using IncrementalOpenXmlTextValuesProvider = Microsoft.CodeAnalysis.IncrementalValuesProvider<(Microsoft.CodeAnalysis.AdditionalText Text, string Type)>;

namespace DocumentFormat.OpenXml.Generator;

public static class GeneratorExtensions
{
    public static IncrementalOpenXmlTextValuesProvider GetOpenXmlDataFiles(this IncrementalGeneratorInitializationContext context)
        => context.AdditionalTextsProvider
                .Combine(context.AnalyzerConfigOptionsProvider)
                .Select((args, token) =>
                {
                    if (args.Right.GetOptions(args.Left).TryGetValue("build_metadata.AdditionalFiles.OpenXml", out var result))
                    {
                        return (args.Left, result);
                    }

                    return default;
                })
                .Where(args => args != default);

    public static IncrementalValuesProvider<AdditionalText> IsOpenXmlType(this IncrementalOpenXmlTextValuesProvider types, string type)
        => types.Where(t => string.Equals(t.Type, type, StringComparison.Ordinal)).Select((t, _) => t.Text);

    public static IncrementalValuesProvider<T> Deserialize<T>(this IncrementalValuesProvider<AdditionalText> texts)
        => texts.Select((t, token) => OpenXmlGeneratorContext.Deserialize<T>(t.GetText(token)?.ToString())).Where(t => t is not null)!;

    public static IncrementalValueProvider<ImmutableArray<NamespaceInfo>> GetKnownNamespaces(this IncrementalOpenXmlTextValuesProvider types)
        => types
            .IsOpenXmlType("Namespace")
            .Deserialize<NamespaceInfo[]>()
            .SelectMany((n, _) => n ?? Enumerable.Empty<NamespaceInfo>())
            .Collect();

    public static IncrementalValueProvider<ImmutableArray<SchemaNamespace>> GetNamespaceTypes(this IncrementalOpenXmlTextValuesProvider texts)
        => texts
            .IsOpenXmlType("Schema")
            .Deserialize<SchemaNamespace>()
            .Collect();

    public static IncrementalValueProvider<OpenXmlGeneratorContext> GetOpenXmlGeneratorContext(this IncrementalGeneratorInitializationContext context)
    {
        var openXmlFiles = context.GetOpenXmlDataFiles();
        var namespaces = openXmlFiles.GetKnownNamespaces();
        var namespaceTypes = openXmlFiles.GetNamespaceTypes();

        return namespaces.Combine(namespaceTypes)
            .Select((arg, token) => new OpenXmlGeneratorContext
            {
                KnownNamespaces = arg.Left,
                Namespaces = arg.Right,
            });
    }
}
