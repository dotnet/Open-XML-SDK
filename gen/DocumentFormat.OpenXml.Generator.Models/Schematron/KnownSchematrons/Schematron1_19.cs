// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons
{
    /// <summary>
    /// AttrValueSetWhenOther
    /// 1.19 attribute should be of some value if another attribute is of some value
    /// element;attribute;value1;value2...;;atribute;value;value;...
    /// ((@a=1 or @a=2 or @a=3) and (@b=4 or @b=5 or @b=6)) or (@b!=4 and @b!=5 and @b!=6)
    /// </summary>
    internal record Schematron1_19(ElementReference Type, AttributeReference Attribute1, AttributeReference Attribute2, IReadOnlyCollection<string> Items1, IReadOnlyCollection<string> Items2) : ISchematron
    {
        // category 1.19
        // element;attribute;value1;value2...;;atribute;value;value;...
        // ((@a=1 or @a=2 or @a=3) and (@b=4 or @b=5 or @b=6)) or (@b!=4 and @b!=5 and @b!=6)
        public static IEnumerable<ISchematron> Parse(SchematronEntry data)
        {
            var tree = SyntaxAnalysor.Analysis(data.Test);

            var firstSubTree = new SyntaxTree
            {
                Root = tree.Root.Children.First().Children.First(),
            };
            var firstParaNodes = firstSubTree.PreorderTraverse().Where(n => !n.Children.Any()).ToArray();

            var secondSubTree = new SyntaxTree
            {
                Root = tree.Root.Children.Last(),
            };
            var secondParaNodes = secondSubTree.PreorderTraverse().Where(n => !n.Children.Any()).ToArray();

            var contextElements = ParseContext.ParseContextElement(data.Context, new string[] { firstParaNodes[0].Text, secondParaNodes[0].Text });
            for (var i = 0; i < contextElements.Length; i++)
            {
                var type = contextElements[i];
                var attribute1 = ParseContext.ParseAttribute(firstParaNodes[0].Text);

                var result1 = new List<string>();
                for (var j = 1; j < firstParaNodes.Length; j = j + 2)
                {
                    result1.Add(ParseContext.TrimQuotes(firstParaNodes[j].Text).ToString());
                }

                var attribute2 = ParseContext.ParseAttribute(secondParaNodes[0].Text);
                var result2 = new List<string>();

                for (var j = 1; j < secondParaNodes.Length; j = j + 2)
                {
                    result2.Add(ParseContext.TrimQuotes(secondParaNodes[j].Text).ToString());
                }

                yield return new Schematron1_19(type, attribute1, attribute2, result1, result2);
            }
        }
    }
}
