// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;
using DocumentFormat.OpenXml.Generator.NamespaceGeneration;
using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

namespace DocumentFormat.OpenXml.Generator;

[Generator]
public class OpenXmlGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var data = context.GetOpenXmlDataFiles();
        var ooxContext = data.GetOpenXmlGeneratorContext();
        var openXml = ooxContext.GetOpenXmlServices();
        var options = context.GetOpenXmlOptions();

        context.RegisterSourceOutput(
            data.Combine(options).Where(static data => data.Right.GenerateNamespaces)
                .Select((data, _) => data.Left)
                .GetKnownNamespaces(),
            NamespaceGenerator.WriteNamespaces);

        context.RegisterSourceOutput(
            openXml.When(options, static options => options.GenerateParts),
            PartGenerator.WritePartFiles);

        context.RegisterSourceOutput(
            openXml.When(options, static options => options.GenerateFactories),
            (context, services) =>
            {
                if (services is null)
                {
                    return;
                }

                FactoryGenerator.GeneratePartFactory(context, services);
                FactoryGenerator.GenerateRootActivator(context, services);
            });

        context.RegisterSourceOutput(
            openXml.When(options, static options => options.GenerateFactories)
                   .GetPackageFactories(),
            FactoryGenerator.GenerateDocumentSpecificPartFeature);

        context.RegisterSourceOutput(
            openXml.When(options, static options => options.GenerateSchema)
                   .SelectMany((s, _) => s?.Context.Namespaces ?? ImmutableArray.Create<SchemaNamespace>())
                   .Combine(openXml),
            (context, services) => SchemaGenerator.WriteSchemaFiles(context, services.Right, services.Left));
    }
}
