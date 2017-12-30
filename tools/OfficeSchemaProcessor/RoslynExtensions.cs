// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis;
using System;
using System.Text;

using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace OfficeSchemaProcessor
{
    internal static class RoslynExtensions
    {
        public static T AddDocumentationComment<T>(this T node, DocumentCommentOptions option)
            where T : SyntaxNode
        {
            var sb = new StringBuilder();

            sb.AppendLine("/// <summary>");
            sb.Append("/// ");
            sb.AppendLine(option.Summary);
            sb.AppendLine("/// </summary>");

            foreach (var parameter in option.Parameters)
            {
                sb.Append("/// <param name=\"");
                sb.Append(parameter.paramName);
                sb.Append("\">");
                sb.Append(parameter.message);
                sb.AppendLine("</param>");
            }

            if (!string.IsNullOrEmpty(option.Return))
            {
                sb.Append("/// <return>");
                sb.Append(option.Return);
                sb.AppendLine("</return>");
            }

            return node
                .WithLeadingTrivia(ParseLeadingTrivia(sb.ToString()));
        }

        public static T AddDocumentationComment<T>(this T node, string summary)
            where T : SyntaxNode
        {
            return node.AddDocumentationComment(new DocumentCommentOptions { Summary = summary });
        }

        public static T InheritDocumentation<T>(this T node)
            where T : SyntaxNode
        {
            return node
                .WithLeadingTrivia(ParseLeadingTrivia($"/// <inheritdoc/>{Environment.NewLine}"));
        }

        public static T AddLicense<T>(this T node)
            where T : SyntaxNode
        {
            const string License = @"// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

";

            return node
                .WithLeadingTrivia(ParseLeadingTrivia(License));
        }
    }
}
