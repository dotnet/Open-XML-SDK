// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons
{
    /// <summary>
    /// ParseRefExistConstraint
    /// 3.1 reference exist
    /// </summary>
    internal record Schematron3_1(ElementReference Type, AttributeReference Attribute, string Part, ElementReference Element, AttributeReference ElementAttribute) : ISchematron
    {
        // reference exist
        // element;attribute;part;element;attribute
        // Index-of(document('Part:CommentsPart')//w:comment/@id, @w:id")
        public static IEnumerable<ISchematron> Parse(SchematronEntry data)
        {
            var tree = SyntaxAnalysor.Analysis(data.Test);
            var paraNodes = tree.PreorderTraverse().Where(n => !n.Children.Any()).ToArray();

            var contextElements = ParseContext.ParseContextElement(data.Context, new string[] { paraNodes[3].Text });
            for (var i = 0; i < contextElements.Length; i++)
            {
                var type = contextElements[i];

                var attribute = ParseContext.ParseAttribute(paraNodes[3].Text);

                var part = ParseContext.ParsePart(paraNodes[0].Text).ToString();
                var (element, _) = ParseContext.ParseElement(paraNodes[1].Text);
                var elementAttribute = ParseContext.ParseAttribute(paraNodes[2].Text);

                yield return new Schematron3_1(type, attribute, part, element, elementAttribute);
            }
        }
    }
}
