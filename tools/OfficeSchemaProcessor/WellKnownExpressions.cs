// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;

using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace OfficeSchemaProcessor
{
    internal class WellKnownExpressions
    {
        private readonly SyntaxGenerator _generator;

        public WellKnownExpressions(SyntaxGenerator generator)
        {
            _generator = generator;
        }

        public ExpressionSyntax ThrowArgumentOutOfRange(string arg)
        {
            return (ExpressionSyntax)_generator.ThrowExpression(
                _generator.ObjectCreationExpression(
                    ParseTypeName("ArgumentOutOfRangeException"),
                    _generator.NameOfExpression(ParseName(arg))));
        }

        public ExpressionSyntax ThrowArgumentNull(string arg)
        {
            return (ExpressionSyntax)_generator.ThrowExpression(
                _generator.ObjectCreationExpression(
                    ParseTypeName("ArgumentNullException"),
                    _generator.NameOfExpression(ParseName(arg))));
        }
    }
}
