// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons
{
    /// <summary>
    /// ParseIndexedConstraint
    /// 3.2 index exist
    /// element;attribute;part;element;index-base
    /// DocumentFormat.OpenXml.Wordprocessing.CommentReference;w:id;WordprocessingCommentsPart;DocumentFormat.OpenXml.Wordprocessing.Comment;1
    /// </summary>
    internal record Schematron3_2(ElementReference Type, AttributeReference Attribute, string Part, ElementReference Parent, ElementReference Element, int Index) : ISchematron
    {
        // index exist
        // element;attribute;part;element;index-base
        // "@w:id < count(document('Part:CommentsPart')//w:comment) +1"
        public static IEnumerable<ISchematron> Parse(SchematronEntry data)
        {
            var tree = SyntaxAnalysor.Analysis(data.Test);
            var paraNodes = tree.PreorderTraverse().Where(n => !n.Children.Any()).ToArray();

            var contextElements = ParseContext.ParseContextElement(data.Context, new string[] { paraNodes[0].Text });
            for (var i = 0; i < contextElements.Length; i++)
            {
                var type = contextElements[i];

                var attribute = ParseContext.ParseAttribute(paraNodes[0].Text);
                var part = ParseContext.ParsePart(paraNodes[1].Text).ToString();

                var (element, parent) = ParseContext.ParseElement(paraNodes[2].Text);
                var index = int.Parse(ParseContext.TrimQuotes(paraNodes[3].Text).ToString());

                yield return new Schematron3_2(type, attribute, part, parent, element, index);
            }
        }
    }
}
