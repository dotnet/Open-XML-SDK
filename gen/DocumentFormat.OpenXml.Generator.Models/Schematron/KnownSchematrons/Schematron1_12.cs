// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons
{
    /// <summary>
    /// ParseAttributeLengthConstraint
    /// 1.12 attribute value length
    /// element;attribute;minLen;maxLen
    /// DocumentFormat.OpenXml.Wordprocessing.Comment;w:id;1;2
    /// </summary>
    internal record Schematron1_12(ElementReference Type, AttributeReference Attribute, int MinLength, int MaxLength) : ISchematron
    {
        public static IEnumerable<ISchematron> Parse(SchematronEntry data)
        {
            var tree = SyntaxAnalysor.Analysis(data.Test);
            var paraNodes = tree.PreorderTraverse().Where(n => !n.Children.Any()).ToArray();

            var contextElements = ParseContext.ParseContextElement(data.Context, new string[] { paraNodes[0].Text });
            for (var i = 0; i < contextElements.Length; i++)
            {
                var type = contextElements[i];

                var attribute = ParseContext.ParseAttribute(paraNodes[0].Text);

                if (tree.Root.Text == " and ")
                {
                    var minLength = ParseInt(ParseContext.TrimQuotes(paraNodes[1].Text));
                    var maxLength = ParseInt(ParseContext.TrimQuotes(paraNodes[3].Text));

                    yield return new Schematron1_12(type, attribute, minLength, maxLength);
                }
                else if (tree.Root.Text == ">=")
                {
                    var minLength = ParseInt(ParseContext.TrimQuotes(paraNodes[1].Text));
                    var maxLength = int.MaxValue;

                    yield return new Schematron1_12(type, attribute, minLength, maxLength);
                }
                else if (tree.Root.Text == "<=")
                {
                    var minLength = 0;
                    var maxLength = ParseInt(ParseContext.TrimQuotes(paraNodes[1].Text));

                    yield return new Schematron1_12(type, attribute, minLength, maxLength);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }

        private static int ParseInt(ReadOnlySpan<char> input)
        {
            return int.Parse(input.ToString());
        }
    }
}
