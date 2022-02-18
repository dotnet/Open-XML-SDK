// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons
{
    /// <summary>
    /// ParseRelExistConstraint
    /// 2.1 relationship should be existed
    /// DocumentFormat.OpenXml.Wordprocessing.Comment;3#w:id
    /// RelationshipExistConstraint(byte rIdAttribute)
    /// </summary>
    internal record Schematron2_1(ElementReference Type, AttributeReference Attribute) : ISchematron
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

                yield return new Schematron2_1(type, attribute);
            }
        }
    }
}
