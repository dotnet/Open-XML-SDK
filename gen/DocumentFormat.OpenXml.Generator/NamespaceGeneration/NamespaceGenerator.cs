// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis;

namespace DocumentFormat.OpenXml.Generator.NamespaceGeneration;

[Generator]
public class NamespaceGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        if (context.AnalyzerConfigOptions.GlobalOptions.TryGetValue("build_property.DocumentFormat_OpenXml_GeneratorNamespaceLookup", out var generatorSwitch) && bool.TryParse(generatorSwitch, out var result) && result)
        {
            context.AddSource("Namespaces", OpenXmlGeneratorContext.Shared.Namespaces.Generate());
        }
    }

    public void Initialize(GeneratorInitializationContext context)
    {
    }
}
