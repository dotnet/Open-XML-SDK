// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons
{
    /// <summary>
    /// ParseAttrOmitWhenOther
    /// 1.14 attribute should be absent if another attribute equals some value
    /// element;attribute;attribute;value1[;value2...]
    /// @a and (@b=1 or @b=2 or @b=3)
    /// </summary>
    internal record Schematron1_14(ElementReference Type, AttributeReference Attribute1, AttributeReference Attribute2, IReadOnlyCollection<string> Items) : ISchematron
    {
        // category 1.14
        // element;attribute;attribute;value1[;value2...]
        // @a and (@b=1 or @b=2 or @b=3)
        public static IEnumerable<ISchematron> Parse(SchematronEntry data)
        {
            var tree = SyntaxAnalysor.Analysis(data.Test);
            var paraNodes = tree.PreorderTraverse().Where(n => !n.Children.Any()).ToArray();

            var contextElements = ParseContext.ParseContextElement(data.Context, new string[] { paraNodes[0].Text, paraNodes[1].Text });
            for (var i = 0; i < contextElements.Length; i++)
            {
                var type = contextElements[i];

                var attribute1 = ParseContext.ParseAttribute(paraNodes[0].Text);
                var attribute2 = ParseContext.ParseAttribute(paraNodes[1].Text);

                var result = new List<string>();

                for (var j = 2; j < paraNodes.Length; j += 2)
                {
                    result.Add(ParseContext.TrimQuotes(paraNodes[j].Text).ToString());
                }

                yield return new Schematron1_14(type, attribute1, attribute2, result);
            }
        }
    }
}
