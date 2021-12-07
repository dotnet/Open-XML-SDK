// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;

namespace DocumentFormat.OpenXml.Generator;

[Generator]
public class KnownFeaturesGenerator : ISourceGenerator
{
    private static readonly DiagnosticDescriptor DuplicateAttribute = new("OOX1000", "Duplicate known features", "Service {0} is already registered for {1}", "KnownFeatures", DiagnosticSeverity.Error, isEnabledByDefault: true);
    private static readonly DiagnosticDescriptor SingleContractForFeature = new("OOX1001", "Duplicate contracts registered", "Can only register a single contract for {0}", "KnownFeatures", DiagnosticSeverity.Error, isEnabledByDefault: true);

    public void Execute(GeneratorExecutionContext context)
    {
        if (context.SyntaxReceiver is not KnownFeatureReceiver receiver)
        {
            return;
        }

        var knownFeatureSymbol = context.Compilation.GetTypeByMetadataName("DocumentFormat.OpenXml.KnownFeatureAttribute");

        if (knownFeatureSymbol is null)
        {
            return;
        }

        foreach (var node in receiver.Nodes)
        {
            var model = context.Compilation.GetSemanticModel(node.SyntaxTree);
            var contracts = new HashSet<INamedTypeSymbol>(SymbolEqualityComparer.Default);

            if (model.GetDeclaredSymbol(node) is IMethodSymbol method)
            {
                var features = new HashSet<(INamedTypeSymbol Contract, INamedTypeSymbol Service)>();

                foreach (var attribute in method.GetAttributes())
                {
                    if (SymbolEqualityComparer.Default.Equals(attribute.AttributeClass, knownFeatureSymbol))
                    {
                        if (attribute.ConstructorArguments[0].Value is INamedTypeSymbol contract)
                        {
                            var service = attribute.ConstructorArguments[1].Value as INamedTypeSymbol ?? contract;

                            if (!contracts.Add(contract))
                            {
                                if (!features.Add((contract, service)))
                                {
                                    var location = attribute.ApplicationSyntaxReference?.GetSyntax(context.CancellationToken)?.GetLocation();
                                    context.ReportDiagnostic(Diagnostic.Create(DuplicateAttribute, location: location, service.ToDisplayString(), contract.ToDisplayString()));
                                }
                                else
                                {
                                    features.Remove((contract, service));
                                    var location = attribute.ApplicationSyntaxReference?.GetSyntax(context.CancellationToken)?.GetLocation();
                                    context.ReportDiagnostic(Diagnostic.Create(SingleContractForFeature, location: location, service.ToDisplayString()));
                                }
                            }
                            else if (!features.Add((contract, service)))
                            {
                                var location = attribute.ApplicationSyntaxReference?.GetSyntax(context.CancellationToken)?.GetLocation();
                                context.ReportDiagnostic(Diagnostic.Create(DuplicateAttribute, location: location, service.ToDisplayString(), contract.ToDisplayString()));
                            }
                        }
                    }
                }

                var source = method.Build(features);

                context.AddSource($"{method.ContainingType.Name}_{method.Name}", source);
            }
        }
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        context.RegisterForSyntaxNotifications(() => new KnownFeatureReceiver());
        context.RegisterForPostInitialization(context =>
        {
            var sb = new StringWriter();
            var indented = new IndentedTextWriter(sb);

            const string Source = @"namespace DocumentFormat.OpenXml;

[global::System.Diagnostics.Conditional(""GENERATOR"")]
[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = true)]
internal sealed class KnownFeatureAttribute : global::System.Attribute
{
    public KnownFeatureAttribute(global::System.Type contract, global::System.Type? service = null)
    {
    }
}";

            sb.WriteFileHeader();
            sb.WriteLine(Source);

            context.AddSource("KnownFeatureAttribute", sb.ToString());
        });
    }

    private class KnownFeatureReceiver : ISyntaxReceiver
    {
        public List<MethodDeclarationSyntax> Nodes { get; } = new();

        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
        {
            if (syntaxNode.IsKind(SyntaxKind.MethodDeclaration) && syntaxNode is MethodDeclarationSyntax method)
            {
                foreach (var list in method.AttributeLists)
                {
                    foreach (var attribute in list.Attributes)
                    {
                        if (attribute.Name.ToString().Contains("KnownFeature"))
                        {
                            Nodes.Add(method);
                            return;
                        }
                    }
                }
            }
        }
    }
}
