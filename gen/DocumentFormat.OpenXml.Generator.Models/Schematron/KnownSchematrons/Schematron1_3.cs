// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Globalization;

namespace DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons
{
    /// <summary>
    /// ParseMinMaxConstraint
    /// 1.3 attribute value range
    /// element;attribute;min;max
    /// DocumentFormat.OpenXml.Wordprocessing.Comment;w:id;double.NegativeInfinity;2
    /// </summary>
    internal record Schematron1_3(ElementReference Type, AttributeReference Attribute, double MinValue, bool MinInclusive, double MaxValue, bool MaxInclusive) : ISchematron
    {
        // min max
        // element;attribute;min;max
        // @w:id >= 1 and @w:id <= 2
        public static IEnumerable<ISchematron> Parse(SchematronEntry data)
        {
            var tree = SyntaxAnalysor.Analysis(data.Test);
            var paraNodes = tree.PreorderTraverse().Where(n => !n.Children.Any()).ToArray();

            var contextElements = ParseContext.ParseContextElement(data.Context, new string[] { paraNodes[0].Text });

            for (var i = 0; i < contextElements.Length; i++)
            {
                var type = contextElements[i];
                var attribute = ParseContext.ParseAttribute(paraNodes[0].Text.AsSpan());

                if (tree.Root.Text.Equals(" and "))
                {
                    var minValue = ParseDouble(ParseContext.TrimQuotes(paraNodes[1].Text.AsSpan()));
                    var minExclusive = tree.PreorderTraverse().Select(n => n.Text).Contains(">=");
                    var maxValue = ParseDouble(ParseContext.TrimQuotes(paraNodes[3].Text.AsSpan()));
                    var maxExclusive = tree.PreorderTraverse().Select(n => n.Text).Contains("<=");

                    yield return new Schematron1_3(type, attribute, minValue, minExclusive, maxValue, maxExclusive);
                }
                else if (tree.Root.Text.Equals(">=") || tree.Root.Text.Equals(">"))
                {
                    var minValue = ParseDouble(ParseContext.TrimQuotes(paraNodes[1].Text.AsSpan()));
                    var minExclusive = tree.Root.Text.Equals(">=");
                    var maxValue = double.PositiveInfinity;
                    var maxExclusive = true;

                    yield return new Schematron1_3(type, attribute, minValue, minExclusive, maxValue, maxExclusive);
                }
                else if (tree.Root.Text.Equals("<=") || tree.Root.Text.Equals("<"))
                {
                    var minValue = double.NegativeInfinity;
                    var minExclusive = true;
                    var maxValue = ParseDouble(ParseContext.TrimQuotes(paraNodes[1].Text.AsSpan()));
                    var maxExclusive = tree.Root.Text.Equals("<=");

                    yield return new Schematron1_3(type, attribute, minValue, minExclusive, maxValue, maxExclusive);
                }
            }
        }

        private static double ParseDouble(ReadOnlySpan<char> input)
        {
            if (input.StartsWith("0x".AsSpan(), StringComparison.Ordinal))
            {
                return uint.Parse(input.Slice(2).ToString(), NumberStyles.HexNumber);
            }

            if (input.EndsWith("f".AsSpan(), StringComparison.Ordinal))
            {
                input = input.Slice(0, input.Length - 1);
            }

            return double.Parse(input.ToString());
        }
    }
}
