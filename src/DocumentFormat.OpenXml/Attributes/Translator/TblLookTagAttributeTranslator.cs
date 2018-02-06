// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Attributes.Formatter;

namespace DocumentFormat.OpenXml.Attributes.Translator
{
    internal class TblLookTagAttributeTranslator : TagAttributeTranslator
    {
        private static string[] arrayOfOrigTagAttrNames = { "firstRow", "lastRow", "firstColumn", "lastColumn", "noHBand", "noVBand" };
        private static string[] arrayOfNewTagAttrNames = { "val", "val", "val", "val", "val", "val" };
        private static long[] arrayOfTagAttrTraits = { 0x0020, 0x0040, 0x0080, 0x0100, 0x0200, 0x0400 };

        internal TblLookTagAttributeTranslator()
        {
            arrayOfOrigAttrNames = arrayOfOrigTagAttrNames;
            arrayOfNewAttrNames = arrayOfNewTagAttrNames;
            arrayOfOrigAttrValues = null;
            arrayOfNewAttrValues = null;
            arrayOfAttrTraits = arrayOfTagAttrTraits;
            formatter = new HexAttributeFormatter(arrayOfTagAttrTraits.Length);
        }

        /// <summary>
        /// Set the index to specify the attribute name to translate.
        /// </summary>
        /// <returns>The index</returns>
        protected override int SetIndex()
        {
            return this.GetIndexByAttributeName();
        }

        /// <inheritdoc/>
        internal override string Value
        {
            get { return this.strAttrValue; }
        }
    }
}
