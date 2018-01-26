// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Attributes.Formatter;

namespace DocumentFormat.OpenXml.Attributes.Translator
{
    internal class CnfStyleTagAttributeTranslator : TagAttributeTranslator
    {
        private static string[] arrayOfOrigTagAttrNames = { "firstRow", "lastRow", "firstColumn", "lastColumn", "oddVBand", "evenVBand", "oddHBand", "evenHBand", "firstRowLastColumn", "firstRowFirstColumn", "lastRowFirstColumn", "lastRowLastColumn" };
        private static string[] arrayOfNewTagAttrNames = { "val", "val", "val", "val", "val", "val", "val", "val", "val", "val", "val", "val" };
        private static long[] arrayOfTagAttrTraits = { 0x800, 0x400, 0x200, 0x100, 0x080, 0x040, 0x020, 0x010, 0x008, 0x004, 0x002, 0x001 };

        internal CnfStyleTagAttributeTranslator()
        {
            arrayOfNewAttrNames = arrayOfNewTagAttrNames;
            arrayOfOrigAttrNames = arrayOfOrigTagAttrNames;
            arrayOfOrigAttrValues = null;
            arrayOfNewAttrValues = null;
            arrayOfAttrTraits = arrayOfTagAttrTraits;
            formatter = new BinAttributeFormatter(arrayOfTagAttrTraits.Length);
        }

        /// <summary>
        /// Set the index to specify the attribute name to translate.
        /// </summary>
        /// <returns>The index</returns>
        protected override int SetIndex()
        {
            return this.GetIndexByAttributeName();
        }

        /// <summary>
        /// Gets the attribute value.
        /// </summary>
        /// <returns>The attribute value</returns>
        internal override string Value
        {
            get { return this.strAttrValue; }
        }
    }
}
