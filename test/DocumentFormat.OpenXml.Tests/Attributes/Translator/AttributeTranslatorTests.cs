// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Xunit;

namespace DocumentFormat.OpenXml.Attributes.Translator
{
    public class AttributeTranslatorTests
    {
        // DocumentTagAttributeTranslator
        [InlineData("document", "conformance", "something", null, null, null, 0, null)]
        [InlineData("document", "something", "something", null, null, null, 0, null)]
        [InlineData("document", "conformance", "strict", typeof(DocumentTagAttributeTranslator), "conformance", "", 0, null)]
        [InlineData("Document", "conformance", "strict", null, null, null, 0, null)]

        // CnfStyleTagAttributeTranslator
        [InlineData("cnfStyle", "firstRow", "", typeof(CnfStyleTagAttributeTranslator), "val", "", 0x800, typeof(BinaryValueConverter))]
        [InlineData("cnfStyle", "firstRow", "a", typeof(CnfStyleTagAttributeTranslator), "val", "a", 0x800, typeof(BinaryValueConverter))]
        [InlineData("cnfStyle", "lastRow", "", typeof(CnfStyleTagAttributeTranslator), "val", "", 0x400, typeof(BinaryValueConverter))]
        [InlineData("cnfStyle", "firstColumn", "", typeof(CnfStyleTagAttributeTranslator), "val", "", 0x200, typeof(BinaryValueConverter))]
        [InlineData("cnfStyle", "lastColumn", "", typeof(CnfStyleTagAttributeTranslator), "val", "", 0x100, typeof(BinaryValueConverter))]
        [InlineData("cnfStyle", "oddVBand", "", typeof(CnfStyleTagAttributeTranslator), "val", "", 0x080, typeof(BinaryValueConverter))]
        [InlineData("cnfStyle", "evenVBand", "", typeof(CnfStyleTagAttributeTranslator), "val", "", 0x040, typeof(BinaryValueConverter))]
        [InlineData("cnfStyle", "oddHBand", "", typeof(CnfStyleTagAttributeTranslator), "val", "", 0x020, typeof(BinaryValueConverter))]
        [InlineData("cnfStyle", "evenHBand", "", typeof(CnfStyleTagAttributeTranslator), "val", "", 0x010, typeof(BinaryValueConverter))]
        [InlineData("cnfStyle", "firstRowLastColumn", "", typeof(CnfStyleTagAttributeTranslator), "val", "", 0x008, typeof(BinaryValueConverter))]
        [InlineData("cnfStyle", "firstRowFirstColumn", "", typeof(CnfStyleTagAttributeTranslator), "val", "", 0x004, typeof(BinaryValueConverter))]
        [InlineData("cnfStyle", "lastRowFirstColumn", "", typeof(CnfStyleTagAttributeTranslator), "val", "", 0x002, typeof(BinaryValueConverter))]
        [InlineData("cnfStyle", "lastRowLastColumn", "", typeof(CnfStyleTagAttributeTranslator), "val", "", 0x001, typeof(BinaryValueConverter))]

        // TblLookTagAttributeTranslator
        [InlineData("tblLook", "firstRow", "", typeof(TblLookTagAttributeTranslator), "val", "", 0x0020, typeof(HexValueConverter))]
        [InlineData("tblLook", "lastRow", "", typeof(TblLookTagAttributeTranslator), "val", "", 0x0040, typeof(HexValueConverter))]
        [InlineData("tblLook", "firstColumn", "", typeof(TblLookTagAttributeTranslator), "val", "", 0x0080, typeof(HexValueConverter))]
        [InlineData("tblLook", "lastColumn", "", typeof(TblLookTagAttributeTranslator), "val", "", 0x0100, typeof(HexValueConverter))]
        [InlineData("tblLook", "noHBand", "", typeof(TblLookTagAttributeTranslator), "val", "", 0x0200, typeof(HexValueConverter))]
        [InlineData("tblLook", "noVBand", "", typeof(TblLookTagAttributeTranslator), "val", "", 0x400, typeof(HexValueConverter))]

        // IndTagAttributeTranslator
        [InlineData("ind", "left", "", typeof(IndTagAttributeTranslator), "start", "", 0, null)]
        [InlineData("ind", "left", "b", typeof(IndTagAttributeTranslator), "start", "b", 0, null)]
        [InlineData("ind", "leftChars", "", typeof(IndTagAttributeTranslator), "startChars", "", 0, null)]
        [InlineData("ind", "right", "", typeof(IndTagAttributeTranslator), "end", "", 0, null)]
        [InlineData("ind", "rightChars", "", typeof(IndTagAttributeTranslator), "endChars", "", 0, null)]

        // JcTabTagAttributeTranslator
        [InlineData("jc", "val", "start", null, null, null, 0, null)]
        [InlineData("jc", "val", "end", null, null, null, 0, null)]
        [InlineData("tab", "val", "start", typeof(JcTabTagAttributeTranslator), "val", "left", 0, null)]
        [InlineData("tab", "val", "end", typeof(JcTabTagAttributeTranslator), "val", "right", 0, null)]
        [InlineData("jc", "val", "", null, null, null, 0, null)]
        [InlineData("tab", "val", "", null, null, null, 0, null)]

        // StylePaneSortMethodTagAttributeTranslator
        [InlineData("stylePaneSortMethod", "val", "name", typeof(StylePaneSortMethodTagAttributeTranslator), "val", "0000", 0, null)]
        [InlineData("stylePaneSortMethod", "val", "priority", typeof(StylePaneSortMethodTagAttributeTranslator), "val", "0001", 0, null)]
        [InlineData("stylePaneSortMethod", "val", "default", typeof(StylePaneSortMethodTagAttributeTranslator), "val", "0002", 0, null)]
        [InlineData("stylePaneSortMethod", "val", "font", typeof(StylePaneSortMethodTagAttributeTranslator), "val", "0003", 0, null)]
        [InlineData("stylePaneSortMethod", "val", "basedOn", typeof(StylePaneSortMethodTagAttributeTranslator), "val", "0004", 0, null)]
        [InlineData("stylePaneSortMethod", "val", "type", typeof(StylePaneSortMethodTagAttributeTranslator), "val", "0005", 0, null)]
        [InlineData("stylePaneSortMethod", "val", "", null, null, null, 0, null)]

        // TextDirectionTagAttributeTranslator
        [InlineData("textDirection", "val", "lr", typeof(TextDirectionTagAttributeTranslator), "val", "btLr", 0, null)]
        [InlineData("textDirection", "val", "tb", typeof(TextDirectionTagAttributeTranslator), "val", "lrTb", 0, null)]
        [InlineData("textDirection", "val", "tbV", typeof(TextDirectionTagAttributeTranslator), "val", "lrTbV", 0, null)]
        [InlineData("textDirection", "val", "lrV", typeof(TextDirectionTagAttributeTranslator), "val", "tbLrV", 0, null)]
        [InlineData("textDirection", "val", "rl", typeof(TextDirectionTagAttributeTranslator), "val", "tbRl", 0, null)]
        [InlineData("textDirection", "val", "rlV", typeof(TextDirectionTagAttributeTranslator), "val", "tbRlV", 0, null)]

        // Negative tests
        [InlineData("document", null, null, null, null, null, 0, null)]
        [Theory]
        public void RetrieveTranslator(string strTag, string strLocalName, string strValue, Type expected, string localName, string value, long trait, Type converter)
        {
            var translator = AttributeTranslator.Translate(strTag, strLocalName, strValue);

            if (expected == null)
            {
                Assert.Equal(default, translator);
            }
            else
            {
                Assert.IsType(expected, translator);
                Assert.Equal(localName, translator.LocalName);
                Assert.Equal(value, translator.Value);
                Assert.Equal(trait, translator.Trait);

                if (translator.Converter != null)
                {
                    Assert.IsType(converter, translator.Converter);
                }
                else
                {
                    Assert.Null(converter);
                }
            }
        }
    }
}
