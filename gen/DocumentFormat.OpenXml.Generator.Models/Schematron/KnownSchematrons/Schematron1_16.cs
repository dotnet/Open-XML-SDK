// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons
{
    /// <summary>
    /// AttrMutualExclusive
    /// 1.16 only one of a group attributes can exist
    /// element;attribute1;attribute2[;attribute3...]
    /// (@a and @b) or (@a and @c) or (@b and @c)
    /// </summary>
    internal record Schematron1_16(ElementReference Type, IReadOnlyCollection<AttributeReference> Attributes) : ISchematron
    {
        // category 1.16
        // element;attribute1;attribute2[;attribute3...]
        // (@a and @b) or (@a and @c) or (@b and @c)
        public static IEnumerable<ISchematron> Parse(SchematronEntry data)
        {
            var tree = SyntaxAnalysor.Analysis(data.Test);
            var paraNodes = tree.PreorderTraverse().Where(n => !n.Children.Any()).ToArray();

            var contextElements = ParseContext.ParseContextElement(data.Context, new string[] { paraNodes[0].Text, paraNodes[1].Text });

            for (var i = 0; i < contextElements.Length; i++)
            {
                var type = contextElements[i];
                var attributes = new List<AttributeReference>();

                for (var j = 0; j < paraNodes.Length; j++)
                {
                    var attr = ParseContext.ParseAttribute(paraNodes[j].Text);
                    if (!attributes.Contains(attr))
                    {
                        attributes.Add(attr);
                    }
                }

                yield return new Schematron1_16(type, attributes);
            }
        }
    }
}
