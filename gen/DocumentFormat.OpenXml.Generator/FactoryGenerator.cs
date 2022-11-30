// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Editor;
using DocumentFormat.OpenXml.Generator.Generators.Parts;
using Microsoft.CodeAnalysis;
using System.CodeDom.Compiler;
using System.Collections.Immutable;
using System.Linq.Expressions;
using System.Text;

namespace DocumentFormat.OpenXml.Generator;

[Generator]
public class FactoryGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var openXml = context.GetOpenXmlGeneratorContext()
            .GetOpenXmlServices();

        var partFactory = openXml.Select((o, token) =>
        {
            var result = ImmutableDictionary.CreateBuilder<string, ImmutableArray<Models.Part>>();

            try
            {
                var dict = o.Context.Parts.ToDictionary(p => p.Name);

                foreach (var doc in o.Context.Packages)
                {
                    var seen = new HashSet<string>();
                    var queue = new Queue<Models.Part>();
                    queue.Enqueue(doc);
                    var partResult = ImmutableArray.CreateBuilder<Models.Part>();

                    while (queue.Count > 0)
                    {
                        var part = queue.Dequeue();

                        foreach (var child in part.Children)
                        {
                            if (seen.Add(child.Name) && dict.TryGetValue(child.Name, out var childPart))
                            {
                                queue.Enqueue(childPart);
                                partResult.Add(childPart);
                            }
                        }
                    }

                    result.Add(doc.Name, partResult.ToImmutable());
                }
            }
            catch (Exception e)
            {
                result.Add("Error", ImmutableArray.Create(new Models.Part { Name = e.Message }));
            }

            return result.ToImmutable();
        });

        context.RegisterSourceOutput(partFactory, GenerateDocumentSpecificPartFeature);
        context.RegisterSourceOutput(openXml, (context, openXml) =>
        {
            GeneratePartFactory(context, openXml);
            GenerateRootActivator(context, openXml);
        });
    }

    private static void GenerateDocumentSpecificPartFeature(SourceProductionContext context, ImmutableDictionary<string, ImmutableArray<Models.Part>> parts)
    {
        using var sw = new StringWriter();
        using var writer = new IndentedTextWriter(sw);

        writer.WriteFileHeader();

        writer.WriteLine("using DocumentFormat.OpenXml;");
        writer.WriteLine("using DocumentFormat.OpenXml.Features;");
        writer.WriteLine();
        writer.WriteLine("namespace DocumentFormat.OpenXml.Packaging;");

        foreach (var part in parts)
        {
            writer.WriteLine();

            writer.Write("partial class ");
            writer.WriteLine(part.Key);

            using (writer.AddBlock())
            {
                writer.Write("partial class ");
                writer.Write(part.Key);
                writer.WriteLine("Features : IPartFactoryFeature");

                using (writer.AddBlock())
                {
                    writer.WriteLine("OpenXmlPart IPartFactoryFeature.Create(string relationship)");

                    using (writer.AddBlock())
                    {
                        foreach (var relationship in part.Value)
                        {
                            writer.Write("if (relationship == \"");
                            writer.Write(relationship.RelationshipType);
                            writer.WriteLine("\")");

                            using (writer.AddBlock())
                            {
                                writer.Write("return new ");
                                writer.Write(relationship.Name);
                                writer.WriteLine("();");
                            }
                        }

                        writer.WriteLine("return new ExtendedPart(relationship);");
                    }
                }
            }
        }

        context.AddSource("DocumentPartFactoryFeature", sw.ToString());
    }

    private static void GeneratePartFactory(SourceProductionContext context, OpenXmlGeneratorServices openXml)
    {
        using var sw = new StringWriter();
        using var writer = new IndentedTextWriter(sw);

        writer.WriteFileHeader();

        writer.WriteLine("using DocumentFormat.OpenXml;");
        writer.WriteLine("using DocumentFormat.OpenXml.Packaging;");
        writer.WriteLine();
        writer.WriteLine("namespace DocumentFormat.OpenXml.Features;");

        writer.WriteLine("internal partial class TypedPartFactory : IPartFactory");

        using (writer.AddBlock())
        {
            writer.WriteLine("public T? Create<T>() where T : OpenXmlPart");

            using (writer.AddBlock())
            {
                foreach (var part in openXml.Context.Parts)
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
        }

        context.AddSource("TypedPartFactory", sw.ToString());
    }

    private static void GenerateRootActivator(SourceProductionContext context, OpenXmlGeneratorServices openXml)
    {
        using var sw = new StringWriter();
        using var writer = new IndentedTextWriter(sw);

        writer.WriteFileHeader();

        writer.WriteLine("using System;");
        writer.WriteLine("using System.Collections.Generic;");
        writer.WriteLine("using DocumentFormat.OpenXml;");
        writer.WriteLine("using DocumentFormat.OpenXml.Packaging;");
        writer.WriteLine("using DocumentFormat.OpenXml.Framework.Metadata;");
        writer.WriteLine();
        writer.WriteLine("namespace DocumentFormat.OpenXml.Features;");

        writer.WriteLine("internal partial class TypedRootElementFactory : IRootElementFactory");

        using (writer.AddBlock())
        {
            writer.WriteLine("public static IEnumerable<ElementFactory> GetAllRootElements()");

            using (writer.AddBlock())
            {
                foreach (var model in openXml.Context.Namespaces)
                {
                    foreach (var type in model.Types)
                    {
                        if (type.IsRootElement)
                        {
                            var className = openXml.FindClassName(type.Name, fullyQualified: true);

                            writer.Write("yield return new ElementFactory(typeof(");
                            writer.Write(className);
                            writer.Write("), new(");
                            writer.WriteString(openXml.GetNamespaceInfo(type.Name.QName.Prefix).Uri);
                            writer.Write(", ");
                            writer.WriteString(type.Name.QName.Name);
                            writer.Write("), () => new ");
                            writer.Write(className);
                            writer.WriteLine("());");
                        }
                    }
                }
            }
        }

        context.AddSource("TypedRootFactory", sw.ToString());
    }
}
