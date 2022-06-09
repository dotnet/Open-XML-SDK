// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Schematron.KnownSchematrons
{
    /// <summary>
    /// AttrValueSetWhenOther
    /// 1.1 attribute cannot omit
    /// element;attribute
    /// DocumentFormat.OpenXml.Wordprocessing.Comment;w:id
    /// </summary>
    internal record Schematron1_1(ElementReference Type, AttributeReference Attribute) : ISchematron
    {
        // category 1.19
        // element;attribute;value1;value2...;;atribute;value;value;...
        // ((@a=1 or @a=2 or @a=3) and (@b=4 or @b=5 or @b=6)) or (@b!=4 and @b!=5 and @b!=6)
        public static IEnumerable<ISchematron> Parse(SchematronEntry data)
        {
            var contextElements = ParseContext.ParseContextElement(data.Context, new string[] { data.Test });
            for (var i = 0; i < contextElements.Length; i++)
            {
                var type = contextElements[i];
                var attribute = ParseContext.ParseAttribute(data.Test);

                yield return new Schematron1_1(type, attribute);
            }
        }
    }
}
