// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Editor;
using DocumentFormat.OpenXml.Generator.Generators.Parts;
using Microsoft.CodeAnalysis;
using System.CodeDom.Compiler;
using System.Text;

namespace DocumentFormat.OpenXml.Generator;

[Generator]
public class FactoryGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var openXml = context.GetOpenXmlGeneratorContext()
            .GetOpenXmlServices();

        context.RegisterSourceOutput(openXml, (context, openXml) =>
        {
            GeneratePartFactory(context, openXml);
            GenerateRootActivator(context, openXml);
        });
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

    private static void WritePartFiles(SourceProductionContext context, OpenXmlGeneratorServices openXml)
    {
        var sb = new StringBuilder();
        var sw = new StringWriter(sb);
        var writer = new IndentedTextWriter(sw);

        foreach (var part in openXml.Context.Parts)
        {
            sb.Clear();

            writer.WriteFileHeader();
            writer.WritePart(openXml, part);

            context.AddSource(part.Name, sb.ToString());
        }
    }
}
