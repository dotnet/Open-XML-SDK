// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Editor;
using DocumentFormat.OpenXml.Generator.Models;
using DocumentFormat.OpenXml.Generator.NamespaceGeneration;
using Microsoft.CodeAnalysis;
using System.CodeDom.Compiler;
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

        context.RegisterPackageGenerator(openXml)
            .AddFeature("IPartFactoryFeature", context => context.Properties.ContainsKey("OpenXmlPackage"), (writer, context) =>
            {
                writer.WriteLine("OpenXmlPart? IPartFactoryFeature.Create(string relationship) => relationship switch");

                using (writer.AddBlock(new() { IncludeSemiColon = true }))
                {
                    var parts = context.Services.GetParts(context.Properties["OpenXmlPackage"]);

                    foreach (var relationship in parts)
                    {
                        writer.Write(relationship.Name);
                        writer.Write(".RelationshipTypeConstant => new ");
                        writer.Write(relationship.Name);
                        writer.WriteLine("(),");
                    }

                    writer.WriteLine("_ => default,");
                }
            })
            .AddFeature("ITypedPartFactoryFeature", context => context.Properties.ContainsKey("OpenXmlPackage"), (writer, context) =>
            {
                writer.WriteLine("T? ITypedPartFactoryFeature.Create<T>() where T : class");

                using (writer.AddBlock())
                {
                    foreach (var part in context.Services.DataSource.Parts)
                    {
                        writer.Write("if (typeof(T) == typeof(");
                        writer.Write(part.Name);
                        writer.WriteLine("))");

                        using (writer.AddBlock())
                        {
                            writer.Write("return (T)(object)new ");
                            writer.Write(part.Name);
                            writer.WriteLine("();");
                        }

                        writer.WriteLine();
                    }

                    writer.WriteLine("return default;");
                }
            })
            .AddFeature("IRootElementFeature", context => context.Properties.ContainsKey("OpenXmlPackage"), (writer, context) =>
            {
                writer.WriteLine("private readonly Dictionary<OpenXmlQualifiedName, Func<OpenXmlElement>> _factory = new ()");

                using (writer.AddBlock(new() { IncludeSemiColon = true }))
                {
                    foreach (var model in context.Services.DataSource.Namespaces)
                    {
                        foreach (var type in model.Types)
                        {
                            if (type.IsRootElement)
                            {
                                var className = context.Services.FindClassName(type.Name, fullyQualified: true);

                                writer.Write("{ new OpenXmlQualifiedName(");
                                writer.WriteString(context.Services.GetNamespaceInfo(type.Name.QName.Prefix).Uri);
                                writer.Write(", ");
                                writer.WriteString(type.Name.QName.Name);
                                writer.Write("), () => new ");
                                writer.Write(className);
                                writer.WriteLine("() },");
                            }
                        }
                    }
                }

                writer.WriteLine();

                writer.WriteLine("bool IRootElementFeature.TryCreate(in OpenXmlQualifiedName qname, [NotNullWhen(true)] out OpenXmlElement? element)");

                using (writer.AddBlock())
                {
                    writer.WriteLine("if (_factory.TryGetValue(qname, out var factory))");

                    using (writer.AddBlock())
                    {
                        writer.WriteLine("element = factory();");
                        writer.WriteLine("return true;");
                    }

                    writer.WriteLine("element = default;");
                    writer.WriteLine("return false;");
                }
            });

        context.RegisterSourceOutput(
            data.Combine(options).Where(static data => data.Right.GenerateNamespaces)
                .Select((data, _) => data.Left)
                .GetKnownNamespaces(),
            NamespaceGenerator.WriteNamespaces);

        context.RegisterSourceOutput(
            openXml.When(options, static options => options.GenerateParts),
            PartGenerator.WritePartFiles);

        context.RegisterSourceOutput(
            openXml.When(options, static options => options.GenerateSchema)
                   .SelectMany((s, _) => s?.DataSource.Namespaces ?? ImmutableArray.Create<SchemaNamespace>())
                   .Combine(openXml),
            (context, services) => SchemaGenerator.WriteSchemaFiles(context, services.Right, services.Left));

        context.RegisterSourceOutput(
            openXml.When(options, static options => options.GenerateLinq),
            (context, services) =>
            {
                if (services is null)
                {
                    return;
                }

                foreach (var (className, contents) in services.GenerateLinqFiles())
                {
                    context.AddSource($"Linq.{className}.g.cs", contents);
                }
            });
    }
}
