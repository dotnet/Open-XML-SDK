// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons
{
    /// <summary>
    /// AttrMinMax
    /// 1.17 value of one attribute must be less than or equal another's
    /// element;attribute1;attribute2;false
    /// @a &lt; @b
    /// </summary>
    internal record Schematron1_17(ElementReference Type, AttributeReference Attribute1, AttributeReference Attribute2, bool CanEqual) : ISchematron
    {
        // category 1.17
        // element;attribute1;attribute2;false
        // @a < @b
        public static IEnumerable<ISchematron> Parse(SchematronEntry data)
        {
            var tree = SyntaxAnalysor.Analysis(data.Test);
            var paraNodes = tree.PreorderTraverse().Where(n => !n.Children.Any()).ToArray();

            var contextElements = ParseContext.ParseContextElement(data.Context, new string[] { paraNodes[0].Text, paraNodes[1].Text });

            var canEqual = tree.Root.Text == "<" ? false : true;

            for (var i = 0; i < contextElements.Length; i++)
            {
                var type = contextElements[i];
                var attribute1 = ParseContext.ParseAttribute(paraNodes[0].Text);
                var attribute2 = ParseContext.ParseAttribute(paraNodes[1].Text);

                yield return new Schematron1_17(type, attribute1, attribute2, canEqual);
            }
        }
    }
}
