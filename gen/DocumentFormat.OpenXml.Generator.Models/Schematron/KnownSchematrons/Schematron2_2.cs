// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons
{
    /// <summary>
    /// ParseRelTypeConstraint
    /// 2.2 relationship type
    /// element,attribute,type
    /// DocumentFormat.OpenXml.Wordprocessing.Comment;w:id;type_uri
    /// </summary>
    internal record Schematron2_2(ElementReference Type, AttributeReference Attribute, string RelationshipType) : ISchematron
    {
        public static IEnumerable<ISchematron> Parse(SchematronEntry data)
        {
            var tree = SyntaxAnalysor.Analysis(data.Test);
            var paraNodes = tree.PreorderTraverse().Where(n => !n.Children.Any()).ToArray();

            var contextElements = ParseContext.ParseContextElement(data.Context, new string[] { paraNodes[4].Text });
            for (var i = 0; i < contextElements.Length; i++)
            {
                var type = contextElements[i];
                var attribute = ParseContext.ParseAttribute(paraNodes[4].Text);

                var relationshipType = ParseContext.TrimQuotes(paraNodes[6].Text).ToString();

                yield return new Schematron2_2(type, attribute, relationshipType);
            }
        }
    }
}
