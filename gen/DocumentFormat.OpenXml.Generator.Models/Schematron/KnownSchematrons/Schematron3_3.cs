// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons
{
    /// <summary>
    /// ParseRootAttrConstraint
    /// 3.3 attribute of part root element should be unique within whole package
    /// DocumentFormat.OpenXml.Wordprocessing.Comment;3#w:id;WordprocessingCommentsPart;false
    /// public RootAttributeUniqueConstraint(byte attribute, Type partType, bool ignoreCase)
    /// </summary>
    internal record Schematron3_3(ElementReference Type, AttributeReference Attribute, bool IsCaseSensitive) : ISchematron
    {
        public static IEnumerable<ISchematron> Parse(SchematronEntry data)
        {
            var tree = SyntaxAnalysor.Analysis(data.Test);
            var paraNodes = tree.PreorderTraverse().Where(n => !n.Children.Any()).ToArray();

            var contextElements = ParseContext.ParseContextElement(data.Context, new string[] { paraNodes[2].Text });

            for (var i = 0; i < contextElements.Length; i++)
            {
                var type = contextElements[i];

                var para1 = ParseContext.ParseAttribute(paraNodes[2].Text);

                var partName = paraNodes[0].Text.Replace("/Part:", string.Empty);
                partName = partName.Substring(1, partName.Length - 2);

                var para2 = partName;

                var caseInsensitive = !tree.PreorderTraverse().Select(n => n.Text).Contains("fn:lower-case");

                yield return new Schematron3_3(type, para1, caseInsensitive);
            }
        }
    }
}
