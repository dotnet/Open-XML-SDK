// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable disable

using DocumentFormat;

namespace DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons
{
    /// <summary>
    /// ParseUniqueAttributeConstraint
    /// 2.3 unique attribute
    /// element;attribute;ancestor;IsCaseSensitive
    /// DocumentFormat.OpenXml.Wordprocessing.Comment;w:id;DocumentFormat.OpenXml.Wordprocessing.Comments;true
    /// </summary>
    internal record Schematron2_3(ElementReference Type, ElementReference Parent, AttributeReference Attribute, bool IsLowerCase) : ISchematron
    {
        // Unique attribute
        // element;attribute;ancestor;IsCaseSensitive
        // "count(distinct-values(ancestor::scope//element/@id) = count(ancestor::scope//element/@id)"
        public static IEnumerable<ISchematron> Parse(SchematronEntry data)
        {
            var tree = SyntaxAnalysor.Analysis(data.Test);
            var paraNodes = tree.PreorderTraverse().Where(n => !n.Children.Any()).ToArray();
            var contextElements = ParseContext.ParseContextElement(data.Context, new string[] { paraNodes[paraNodes.Length - 1].Text });

            for (var i = 0; i < contextElements.Length; i++)
            {
                var type = contextElements[i];
                var attribute = ParseContext.ParseAttribute(paraNodes[paraNodes.Length - 1].Text);

                ElementReference parent = default;
                if (paraNodes.Length == 6)
                {
                    (parent, _) = ParseContext.ParseElement(paraNodes[0].Text);
                }

                var lowerCase = !tree.PreorderTraverse().Select(n => n.Text).Contains("fn:lower-case");

                yield return new Schematron2_3(type, parent, attribute, lowerCase);
            }
        }
    }
}
