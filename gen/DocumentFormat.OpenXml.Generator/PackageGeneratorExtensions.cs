// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Editor;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.CodeDom.Compiler;
using System.Text;

namespace DocumentFormat.OpenXml.Generator;

#pragma warning disable SA1118 // Parameter should not span multiple lines

internal static class PackageGeneratorExtensions
{
    public static IFeatureImplementationBuilder RegisterPackageGenerator(
        this IncrementalGeneratorInitializationContext context,
        IncrementalValueProvider<OpenXmlGeneratorServices> services)
    {
        context.RegisterPostInitializationOutput(context =>
        {
            context.AddSource("Attributes.g.cs", """
            using System;

            namespace DocumentFormat.OpenXml.Generator;
            
            [AttributeUsage(AttributeTargets.Class)]
            internal sealed class OpenXmlPackageAttribute : Attribute
            {
                public OpenXmlPackageAttribute(string packageType)
                {
                }
            }
            """);
        });

        var package = context.SyntaxProvider
          .ForAttributeWithMetadataName(
              "DocumentFormat.OpenXml.Generator.OpenXmlPackageAttribute",
              (node, token) => node.IsKind(SyntaxKind.ClassDeclaration),
              (context, token) =>
              {
                  var classNode = (ClassDeclarationSyntax)context.TargetNode;

                  if (context.Attributes[0].ConstructorArguments[0].Value is string packageName)
                  {
                      var symbol = context.SemanticModel.GetDeclaredSymbol(context.TargetNode);

                      return new DefinedPackage(packageName, symbol.GetContainingNamespace(), classNode.GetContainingTypes());
                  }

                  return null;
              });
        var builder = new Builder();

        var namespaces = new[]
        {
            "DocumentFormat.OpenXml",
            "DocumentFormat.OpenXml.Features",
            "DocumentFormat.OpenXml.Framework",
            "System",
            "System.Collections.Generic",
            "System.Diagnostics.CodeAnalysis",
        }.OrderBy(t => t).ToArray();

        context.RegisterSourceOutput(package.Combine(services), (context, data) =>
        {
            if (data.Left is not { } source)
            {
                return;
            }

            var properties = new Dictionary<string, string>
            {
                { "OpenXmlPackage", source.PackageName },
            };
            var gContext = new OpenXmlGeneratorContext(data.Right, properties);

            var features = builder.Build(gContext).ToList();

            var sb = new StringBuilder();
            var writer = new IndentedTextWriter(new StringWriter(sb));

            foreach (var feature in features)
            {
                sb.Clear();

                writer.WriteFileHeader();

                foreach (var n in namespaces)
                {
                    writer.Write("using ");
                    writer.Write(n);
                    writer.WriteLine(";");
                }

                writer.WriteLine();
                writer.Write("namespace ");
                writer.Write(source.Namespace);
                writer.WriteLine(";");
                writer.WriteLine();

                var count = writer.Indent;

                var c = source.Chain;

                while (c is not null)
                {
                    writer.Write("partial ");
                    writer.Write(c.Keyword);
                    writer.Write(' ');
                    writer.Write(c.Name);

                    if (c.Child is null)
                    {
                        writer.Write(" : ");
                        writer.Write(feature.Name);
                    }

                    writer.Write(' ');
                    writer.WriteLine(c.Constraints);
                    writer.WriteLine("{");

                    writer.Indent++;

                    c = c.Child;
                }

                feature.Action(writer, gContext);

                while (writer.Indent > count)
                {
                    writer.Indent--;
                    writer.WriteLine("}");
                }

                context.AddSource($"Package_{source.PackageName}_{feature.Name}", sb.ToString());
            }
        });

        return builder;
    }

    private sealed class Builder : IFeatureImplementationBuilder
    {
        private readonly List<(string, Func<OpenXmlGeneratorContext, bool>, Action<IndentedTextWriter, OpenXmlGeneratorContext>)> _list = new();

        IFeatureImplementationBuilder IFeatureImplementationBuilder.AddFeature(string name, Func<OpenXmlGeneratorContext, bool> isApplicable, Action<IndentedTextWriter, OpenXmlGeneratorContext> action)
        {
            _list.Add((name, isApplicable, action));
            return this;
        }

        public IEnumerable<(string Name, Action<IndentedTextWriter, OpenXmlGeneratorContext> Action)> Build(OpenXmlGeneratorContext context)
        {
            foreach (var item in _list)
            {
                if (item.Item2(context))
                {
                    yield return (item.Item1, item.Item3);
                }
            }
        }
    }

    private sealed record class DefinedPackage(string PackageName, string Namespace, ParentClass Chain);
}
