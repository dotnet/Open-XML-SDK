// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis;

namespace DocumentFormat.OpenXml.Generator.NamespaceGeneration;

[Generator]
public class NamespaceGenerator : IIncrementalGenerator
{
    private static readonly DiagnosticDescriptor MalformedDataFileDescriptor = new("OOX3000", "Malformed data file", "Failed to load data file", "Data", DiagnosticSeverity.Error, isEnabledByDefault: true);

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var namespaces = context.GetOpenXmlDataFiles("Namespace");

        context.RegisterSourceOutput(namespaces.Combine(context.AnalyzerConfigOptionsProvider), static (context, data) =>
        {
            try
            {
                if (data.Right.GlobalOptions.TryGetValue("build_property.DocumentFormat_OpenXml_GeneratorNamespaceLookup", out var generatorSwitch) && bool.TryParse(generatorSwitch, out var result) && result)
                {
                    var ooxmlContext = new OpenXmlGeneratorContext().LoadNamespaces(data.Left, context.CancellationToken);

                    context.AddSource("Namespaces", ooxmlContext.Namespaces.Generate());
                }
            }
            catch (Exception)
            {
                context.ReportDiagnostic(Diagnostic.Create(MalformedDataFileDescriptor, location: null));
            }
        });
    }
}
