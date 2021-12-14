// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis;
using System;

namespace DocumentFormat.OpenXml.Generator.NamespaceGeneration;

[Generator]
internal class NamespaceGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        if (string.Equals(context.Compilation.AssemblyName, "DocumentFormat.OpenXml", StringComparison.Ordinal))
        {
            context.AddSource("Namespaces", OpenXmlGeneratorContext.Shared.Namespaces.Generate());
        }
    }

    public void Initialize(GeneratorInitializationContext context)
    {
    }
}
