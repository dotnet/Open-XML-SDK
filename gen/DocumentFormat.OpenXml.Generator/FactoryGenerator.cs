// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Editor;
using Microsoft.CodeAnalysis;
using System.CodeDom.Compiler;
using System.Collections.Immutable;

namespace DocumentFormat.OpenXml.Generator;

[Generator]
public class FactoryGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var openXml = context.GetOpenXmlGeneratorContext()
            .GetOpenXmlServices();
        var options = context.GetOpenXmlOptions().Select(static (o, _) => o.GenerateFactories);
        var factories = openXml.Combine(options);

        var packageFactories = openXml.GetPackageFactories().Combine(options);

        context.RegisterSourceOutput(packageFactories, (context, factories) =>
        {
            if (!factories.Right)
            {
                return;
            }

            GenerateDocumentSpecificPartFeature(context, factories.Left);
        });

        context.RegisterSourceOutput(factories, (context, factories) =>
        {
            if (!factories.Right)
            {
                return;
            }

            var openXml = factories.Left;

            GeneratePartFactory(context, openXml);
            GenerateRootActivator(context, openXml);
        });
    }

    private static void GenerateDocumentSpecificPartFeature(SourceProductionContext context, ImmutableArray<PackageInformation> packages)
    {
        foreach (var package in packages)
        {
            using var sw = new StringWriter();
            using var writer = new IndentedTextWriter(sw);

            writer.WriteFileHeader();

            writer.WriteLine("using DocumentFormat.OpenXml;");
            writer.WriteLine("using DocumentFormat.OpenXml.Features;");
            writer.WriteLine();
            writer.WriteLine("namespace DocumentFormat.OpenXml.Packaging;");
            writer.WriteLine();

            writer.Write("partial class ");
            writer.WriteLine(package.ClassName);

            using (writer.AddBlock())
            {
                writer.Write("partial class ");
                writer.Write(package.ClassName);
                writer.WriteLine("Features : IPartFactoryFeature");

                using (writer.AddBlock())
                {
                    writer.WriteLine("OpenXmlPart? IPartFactoryFeature.Create(string relationship) => relationship switch");

                    using (writer.AddBlock(new() { IncludeSemiColon = true }))
                    {
                        foreach (var relationship in package.Parts)
                        {
                            writer.Write(relationship.Name);
                            writer.Write(".RelationshipTypeConstant => new ");
                            writer.Write(relationship.Name);
                            writer.WriteLine("(),");
                        }

                        writer.WriteLine("_ => default,");
                    }
                }
            }

            context.AddSource($"{package.ClassName}PartFactoryFeature", sw.ToString());
        }
    }

    private static void GeneratePartFactory(SourceProductionContext context, OpenXmlGeneratorServices openXml)
    {
        using var sw = new StringWriter();
        using var writer = new IndentedTextWriter(sw);

        writer.WriteFileHeader();

        writer.WriteLine("using DocumentFormat.OpenXml;");
        writer.WriteLine("using DocumentFormat.OpenXml.Packaging;");
        writer.WriteLine("using DocumentFormat.OpenXml.Features;");
        writer.WriteLine();
        writer.WriteLine("namespace DocumentFormat.OpenXml.Packaging;");
        writer.WriteLine();

        writer.WriteLine("public abstract partial class TypedOpenXmlPackage");

        using (writer.AddBlock())
        {
            writer.WriteLine("private protected abstract partial class TypedPackageFeatureCollection<TDocumentType, TMainPart> : ITypedPartFactoryFeature");
            writer.Indent++;
            writer.WriteLine("where TDocumentType : struct, System.Enum");
            writer.WriteLine("where TMainPart : OpenXmlPart");
            writer.Indent--;

            using (writer.AddBlock())
            {
                writer.WriteLine("T? ITypedPartFactoryFeature.Create<T>() where T : class");

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
