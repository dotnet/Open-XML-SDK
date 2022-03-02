// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;
using DocumentFormat.OpenXml.Generator.Schematron;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Collections.Immutable;

using IncrementalOpenXmlTextValuesProvider = Microsoft.CodeAnalysis.IncrementalValuesProvider<(Microsoft.CodeAnalysis.AdditionalText Text, string Type)>;

namespace DocumentFormat.OpenXml.Generator;

public static class GeneratorExtensions
{
    // NOTE: These must align with the metadata defined in SourceGenerator.targets
    private const string AdditionalFileNamespace = "Namespace";
    private const string AdditionalFilePart = "Part";
    private const string AdditionalFileSchema = "Schema";
    private const string AdditionalFileSchematron = "Schematron";
    private const string AdditionalFileTypedSchema = "TypedSchema";
    private const string AdditionalFileTypedNamespace = "TypedNamespace";

    private const string OptionsPrefix = "build_property.DocumentFormat_OpenXml_Generator_";
    private const string OptionsGenerateNamespace = $"{OptionsPrefix}NamespaceLookup";
    private const string OptionsGeneratePart = $"{OptionsPrefix}Parts";
    private const string OptionsGenerateSchemas = $"{OptionsPrefix}Schemas";

    public static IncrementalValueProvider<OpenXmlGeneratorOptions> GetOpenXmlOptions(this IncrementalGeneratorInitializationContext context)
        => context.AnalyzerConfigOptionsProvider.Select((options, token) =>
        {
            return new OpenXmlGeneratorOptions
            {
                GenerateNamespaces = IsEnabled(options, OptionsGenerateNamespace),
                GenerateParts = IsEnabled(options, OptionsGeneratePart),
                GenerateSchema = IsEnabled(options, OptionsGenerateSchemas),
            };

            static bool IsEnabled(AnalyzerConfigOptionsProvider options, string name)
                => options.GlobalOptions.TryGetValue(name, out var generatorSwitch) && bool.TryParse(generatorSwitch, out var result) && result;
        });

    public static IncrementalValueProvider<ImmutableArray<NamespaceInfo>> GetKnownNamespaces(this IncrementalOpenXmlTextValuesProvider types)
        => types
            .IsOpenXmlType(AdditionalFileNamespace)
            .Deserialize<NamespaceInfo[]>()
            .SelectMany((n, _) => n ?? Enumerable.Empty<NamespaceInfo>())
            .Collect();

    public static IncrementalValueProvider<ImmutableArray<Part>> GetParts(this IncrementalOpenXmlTextValuesProvider types)
        => types
            .IsOpenXmlType(AdditionalFilePart)
            .Deserialize<Part>()
            .Collect();

    public static IncrementalValueProvider<ImmutableArray<SchemaNamespace>> GetNamespaceTypes(this IncrementalOpenXmlTextValuesProvider texts)
        => texts
            .IsOpenXmlType(AdditionalFileSchema)
            .Deserialize<SchemaNamespace>()
            .Collect();

    public static IncrementalValueProvider<ImmutableArray<SchematronEntry>> GetSchematrons(this IncrementalOpenXmlTextValuesProvider texts)
        => texts
            .IsOpenXmlType(AdditionalFileSchematron)
            .Deserialize<SchematronEntry[]>()
            .SelectMany((s, _) => s ?? Enumerable.Empty<SchematronEntry>())
            .Collect();

    public static IncrementalValueProvider<ImmutableArray<StronglyTypedElement>> GetStronglyTypedSchemas(this IncrementalOpenXmlTextValuesProvider texts)
        => texts
            .IsOpenXmlType(AdditionalFileTypedSchema)
            .Deserialize<StronglyTypedElement[]>()
            .SelectMany((s, _) => s ?? Enumerable.Empty<StronglyTypedElement>())
            .Collect();

    public static IncrementalValueProvider<ImmutableArray<StronglyTypedNamespace>> GetStronglyTypedNamespace(this IncrementalOpenXmlTextValuesProvider texts)
        => texts
            .IsOpenXmlType(AdditionalFileTypedNamespace)
            .Deserialize<StronglyTypedNamespace[]>()
            .SelectMany((s, _) => s ?? Enumerable.Empty<StronglyTypedNamespace>())
            .Collect();

    public static IncrementalValueProvider<OpenXmlGeneratorContext> GetOpenXmlGeneratorContext(this IncrementalGeneratorInitializationContext context)
    {
        var openXmlFiles = context.GetOpenXmlDataFiles();
        var namespaces = openXmlFiles.GetKnownNamespaces();
        var namespaceTypes = openXmlFiles.GetNamespaceTypes();
        var parts = openXmlFiles.GetParts();
        var schematrons = openXmlFiles.GetSchematrons();
        var stronglyTypedSchema = openXmlFiles.GetStronglyTypedSchemas();
        var stronglyTypedNamespace = openXmlFiles.GetStronglyTypedNamespace();

        return namespaces.Combine(namespaceTypes).Combine(parts).Combine(schematrons).Combine(stronglyTypedSchema).Combine(stronglyTypedNamespace)
            .Select((arg, token) => new OpenXmlGeneratorContext
            {
                KnownNamespaces = arg.Left.Left.Left.Left.Left,
                Namespaces = arg.Left.Left.Left.Left.Right,
                Parts = arg.Left.Left.Left.Right,
                Schematrons = arg.Left.Left.Right,
                TypedClasses = arg.Left.Right,
                TypedNamespaces = arg.Right,
            });
    }

    public static IncrementalValueProvider<OpenXmlGeneratorServices> GetOpenXmlServices(this IncrementalValueProvider<OpenXmlGeneratorContext> context)
        => context.Select((context, _) => new OpenXmlGeneratorServices(context));

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

    private static IncrementalValuesProvider<AdditionalText> IsOpenXmlType(this IncrementalOpenXmlTextValuesProvider types, string type)
        => types.Where(t => string.Equals(t.Type, type, StringComparison.Ordinal)).Select((t, _) => t.Text);

    private static IncrementalValuesProvider<T> Deserialize<T>(this IncrementalValuesProvider<AdditionalText> texts)
        => texts.Select((t, token) => OpenXmlGeneratorContext.Deserialize<T>(t.GetText(token)?.ToString())).Where(t => t is not null)!;
}
