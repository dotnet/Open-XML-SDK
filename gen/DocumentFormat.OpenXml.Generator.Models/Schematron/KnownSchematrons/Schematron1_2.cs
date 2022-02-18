// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons
{
    /// <summary>
    /// ParseAttributePatternConstraint
    /// 1.2 attribute value follow specified regex
    /// element;attribute;regex
    /// DocumentFormat.OpenXml.Wordprocessing.Comment;w:id;{/d}
    /// </summary>
    internal record Schematron1_2(ElementReference Type, AttributeReference Attribute, string Text) : ISchematron
    {
        // attribute value match regex
        // element;attribute;regex
        // matches(@attribute, regex)
        public static IEnumerable<ISchematron> Parse(SchematronEntry data)
        {
            var tree = SyntaxAnalysor.Analysis(data.Test);
            var paraNodes = tree.PreorderTraverse().Where(n => !n.Children.Any()).ToArray();

            var contextElements = ParseContext.ParseContextElement(data.Context, new string[] { paraNodes[0].Text });
            for (var i = 0; i < contextElements.Length; i++)
            {
                var type = contextElements[i];
                var attribute = ParseContext.ParseAttribute(paraNodes[0].Text);
                var text = ParseContext.TrimQuotes(paraNodes[1].Text);

                yield return new Schematron1_2(type, attribute, text.ToString());
            }
        }
    }
}
