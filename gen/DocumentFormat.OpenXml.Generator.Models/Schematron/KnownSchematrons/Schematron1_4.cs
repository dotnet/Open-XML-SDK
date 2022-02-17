// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons
{
    /// <summary>
    /// ParseValidSetConstraint
    /// 1.4 attribute valid set
    /// element;attribute;value1;value2;value3 ...
    /// DocumentFormat.OpenXml.Wordprocessing.Comment;w:id;1;2;3
    /// </summary>
    internal record Schematron1_4(ElementReference Type, AttributeReference Attribute, IReadOnlyCollection<string> Items) : ISchematron
    {
        // attribute must be specified values
        // element;attribute;value1;value2;...
        // @attribute = value1 or @attribute or value2 and @attribute or value3 ...
        public static IEnumerable<ISchematron> Parse(SchematronEntry data)
        {
            var tree = SyntaxAnalysor.Analysis(data.Test);
            var paraNodes = tree.PreorderTraverse().Where(n => !n.Children.Any()).ToArray();

            var contextElements = ParseContext.ParseContextElement(data.Context, new string[] { paraNodes[0].Text });
            for (var i = 0; i < contextElements.Length; i++)
            {
                var type = contextElements[i];
                var attribute = ParseContext.ParseAttribute(paraNodes[0].Text);

                var result = new List<string>();

                for (var j = 1; j < paraNodes.Length; j += 2)
                {
                    result.Add(ParseContext.TrimQuotes(paraNodes[j].Text).ToString());
                }

                yield return new Schematron1_4(type, attribute, result);
            }
        }
    }
}
