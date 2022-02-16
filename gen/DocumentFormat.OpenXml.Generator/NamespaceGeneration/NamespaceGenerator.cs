// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;
using Microsoft.CodeAnalysis;

namespace DocumentFormat.OpenXml.Generator.NamespaceGeneration;

[Generator]
public class NamespaceGenerator : ISourceGenerator
{
    private static readonly DiagnosticDescriptor MalformedDataFileDescriptor = new("OOX3000", "Malformed data file", "Failed to load data file", "Data", DiagnosticSeverity.Error, isEnabledByDefault: true);

    public void Execute(GeneratorExecutionContext context)
    {
        try
        {
            if (context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.DocumentFormat_OpenXml_GeneratorNamespaceLookup", out var generatorSwitch) && bool.TryParse(generatorSwitch, out var result) && result)
            {
                var ooxmlContext = OpenXmlGeneratorContext.Load(new AdditionalFilesContextData(context));

                context.AddSource("Namespaces", ooxmlContext.Namespaces.Generate());
            }
        }
        catch (Exception)
        {
            context.ReportDiagnostic(Diagnostic.Create(MalformedDataFileDescriptor, location: null));
        }
    }

    public void Initialize(GeneratorInitializationContext context)
    {
    }
}
