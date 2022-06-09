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
        var namespaces = context.GetOpenXmlDataFiles().GetKnownNamespaces();
        var shouldGenerate = context.GetOpenXmlOptions().Select(static (o, _) => o.GenerateNamespaces);

        context.RegisterSourceOutput(namespaces.Combine(shouldGenerate), static (context, data) =>
        {
            try
            {
                if (data.Right)
                {
                    context.AddSource("Namespaces", data.Left.Generate());
                }
            }
            catch (Exception)
            {
                context.ReportDiagnostic(Diagnostic.Create(MalformedDataFileDescriptor, location: null));
            }
        });
    }
}
