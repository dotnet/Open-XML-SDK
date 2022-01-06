// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;

namespace DocumentFormat.OpenXml.Generator;

public static class KnownFeaturesGeneratorExtensions
{
    public static string Build(this IMethodSymbol method, IEnumerable<(INamedTypeSymbol Contract, ISymbol Service)> features, bool isThreadSafe)
    {
        var sb = new StringWriter();
        var indented = new IndentedTextWriter(sb);

        indented.WriteFileHeader();

        if (isThreadSafe)
        {
            indented.WriteLine("using System.Threading;");
            indented.WriteLineNoTabs();
        }

        indented.Write("namespace ");
        indented.Write(method.ContainingType.ContainingNamespace.ToString());
        indented.WriteLine(";");

        indented.WriteLine();

        WriteContainingClass(indented, GetNestedClasses(method.ContainingType), method, features, isThreadSafe);

        return sb.ToString();
    }

    private static Stack<INamedTypeSymbol> GetNestedClasses(INamedTypeSymbol type)
    {
        var stack = new Stack<INamedTypeSymbol>();

        while (type is not null)
        {
            stack.Push(type);
            type = type.ContainingType;
        }

        return stack;
    }

    private static void WriteContainingClass(IndentedTextWriter indented, Stack<INamedTypeSymbol> types, IMethodSymbol method, IEnumerable<(INamedTypeSymbol Contract, ISymbol Service)> features, bool isThreadSafe)
    {
        if (types.Count == 0)
        {
            WriteInjectedCode(indented, method, features, isThreadSafe);
        }
        else
        {
            var type = types.Pop();
            indented.Write(GetAccessibility(type));
            indented.Write(" partial class ");
            indented.WriteLine(type.Name);

            using (indented.AddBlock())
            {
                WriteContainingClass(indented, types, method, features, isThreadSafe);
            }
        }
    }

    private static void WriteInjectedCode(IndentedTextWriter indented, IMethodSymbol method, IEnumerable<(INamedTypeSymbol Contract, ISymbol Service)> features, bool isThreadSafe)
    {
        foreach (var (contract, service) in features)
        {
            indented.Write("private ");
            indented.WriteSymbol(contract);
            indented.Write("? _");
            indented.Write(service.Name);
            indented.WriteLine(";");
        }

        indented.WriteLineNoTabs();

        indented.Write(GetAccessibility(method));
        indented.Write(" partial T? ");
        indented.Write(method.Name);
        indented.WriteLine("<T>()");

        using (indented.AddBlock())
        {
            foreach (var (contract, service) in features)
            {
                indented.Write("if (typeof(T) == typeof(");
                indented.WriteSymbol(contract);
                indented.WriteLine("))");

                using (indented.AddBlock())
                {
                    WriteFeatureCreation(indented, service, isThreadSafe);

                    indented.WriteLineNoTabs();
                    indented.Write("return (T)");

                    if (contract.TypeKind != TypeKind.Interface)
                    {
                        indented.Write("(object)");
                    }

                    indented.Write("_");
                    indented.Write(service.Name);
                    indented.WriteLine(";");
                }

                indented.WriteLineNoTabs();
            }

            indented.WriteLine("return default;");
        }
    }

    private static void WriteFeatureCreation(IndentedTextWriter indented, ISymbol service, bool isThreadSafe)
    {
        indented.Write("if (");
        indented.Write("_");
        indented.Write(service.Name);
        indented.WriteLine(" is null)");

        using (indented.AddBlock())
        {
            if (isThreadSafe)
            {
                indented.Write("Interlocked.CompareExchange(ref _");
                indented.Write(service.Name);
                indented.Write(", ");
                indented.CreateInstance(service);
                indented.WriteLine(", null);");
            }
            else
            {
                indented.Write("_");
                indented.Write(service.Name);
                indented.Write(" = ");
                indented.CreateInstance(service);
                indented.WriteLine(";");
            }
        }
    }

    private static void CreateInstance(this TextWriter writer, ISymbol symbol)
    {
        if (symbol is IMethodSymbol method)
        {
            writer.Write(method.Name);
            writer.Write("()");
        }
        else if (symbol is INamedTypeSymbol type)
        {
            writer.Write("new ");
            writer.WriteSymbol(type);
            writer.Write("()");
        }
    }

    private static void WriteSymbol(this TextWriter writer, ISymbol symbol)
    {
        writer.Write(symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat));
    }

    private static string GetAccessibility(ISymbol symbol) => symbol.DeclaredAccessibility switch
    {
        Accessibility.Private => "private",
        Accessibility.ProtectedAndInternal => "private protected",
        Accessibility.Protected => "protected",
        Accessibility.Internal => "internal",
        Accessibility.ProtectedOrInternal => "protected internal",
        Accessibility.Public => "public",
        _ => throw new NotImplementedException(),
    };
}
