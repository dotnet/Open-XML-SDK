// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons
{
    /// <summary>
    /// AttrRequiredWhenOther
    /// 1.18 attribute is required if another attribute equals some value
    /// element;attribute;attribute;value1[;value2...]
    /// (@a and (@b=1 or @b=2 or @b=3 )) or (b != 1 and b !=2 and b != 3)
    /// </summary>
    internal record Schematron1_18(ElementReference Type, AttributeReference Attribute1, AttributeReference Attribute2, IReadOnlyCollection<string> Items) : ISchematron
    {
        // category 1.18
        // element;attribute;attribute;value1[;value2...]
        // (@a and (@b=1 or @b=2 or @b=3 )) or (b != 1 and b !=2 and b != 3)
        public static IEnumerable<ISchematron> Parse(SchematronEntry data)
        {
            var tree = SyntaxAnalysor.Analysis(data.Test);

            var firstSubTree = new SyntaxTree
            {
                Root = tree.Root.Children.First(),
            };
            var firstParaNodes = firstSubTree.PreorderTraverse().Where(n => !n.Children.Any()).ToArray();

            var contextElements = ParseContext.ParseContextElement(data.Context, new string[] { firstParaNodes[0].Text, firstParaNodes[1].Text });
            for (var i = 0; i < contextElements.Length; i++)
            {
                var type = contextElements[i];
                var attribute1 = ParseContext.ParseAttribute(firstParaNodes[0].Text);
                var attribute2 = ParseContext.ParseAttribute(firstParaNodes[1].Text);

                var result = new List<string>();
                for (var j = 2; j < firstParaNodes.Length; j = j + 2)
                {
                    result.Add(ParseContext.TrimQuotes(firstParaNodes[j].Text).ToString());
                }

                yield return new Schematron1_18(type, attribute1, attribute2, result);
            }
        }
    }
}
