// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using System;

using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace OfficeSchemaProcessor
{
    internal class WellKnownTypes
    {
        private readonly SyntaxGenerator _generator;

        public WellKnownTypes(SyntaxGenerator generator)
        {
            SystemString = (TypeSyntax)generator.TypeExpression(SpecialType.System_String);
            PartConstraintDictionary = (TypeSyntax)generator.WithTypeArguments(ParseTypeName("Dictionary"), SystemString, ParseTypeName("PartConstraintRule"));
            PartContstraintIDictionary = (TypeSyntax)generator.WithTypeArguments(ParseTypeName("IDictionary"), SystemString, ParseTypeName("PartConstraintRule"));
            SystemBoolean = (TypeSyntax)generator.TypeExpression(SpecialType.System_Boolean);

            _generator = generator;
        }

        public TypeSyntax SystemString { get; }

        public TypeSyntax SystemBoolean { get; }

        public TypeSyntax PartConstraintDictionary { get; }

        public TypeSyntax PartContstraintIDictionary { get; }

        public ExpressionSyntax GetExpression(bool input)
        {
            if (input)
            {
                return (ExpressionSyntax)_generator.TrueLiteralExpression();
            }
            else
            {
                return (ExpressionSyntax)_generator.FalseLiteralExpression();
            }
        }

        public TypeSyntax GetType(object value)
        {
            if (value is bool)
            {
                return SystemBoolean;
            }
            else if (value is string)
            {
                return SystemString;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
