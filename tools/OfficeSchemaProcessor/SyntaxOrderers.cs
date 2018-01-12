// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using System;
using System.Collections.Generic;

namespace OfficeSchemaProcessor
{
    internal static class SyntaxOrderers
    {
        public static IComparer<SyntaxNode> ByName { get; } = new NameOrderer();

        public static IComparer<SyntaxNode> ByType { get; } = new ClassItemOrderer();

        private class NameOrderer : IComparer<SyntaxNode>
        {
            private readonly SyntaxGenerator _generator;

            public NameOrderer()
            {
                _generator = SyntaxGenerator.GetGenerator(new AdhocWorkspace(), LanguageNames.CSharp);
            }

            public int Compare(SyntaxNode x, SyntaxNode y)
            {
                return StringComparer.Ordinal.Compare(_generator.GetName(x), _generator.GetName(y));
            }
        }

        private class ClassItemOrderer : IComparer<SyntaxNode>
        {
            public int Compare(SyntaxNode x, SyntaxNode y)
            {
                return _dictionary[x.GetType()].CompareTo(_dictionary[y.GetType()]);
            }

            private static readonly Dictionary<Type, int> _dictionary = new Dictionary<Type, int>
            {
                { typeof(FieldDeclarationSyntax), 1 },
                { typeof(ConstructorDeclarationSyntax), 2 },
                { typeof(PropertyDeclarationSyntax), 3 },
                { typeof(MethodDeclarationSyntax), 4 },
            };
        }
    }
}
