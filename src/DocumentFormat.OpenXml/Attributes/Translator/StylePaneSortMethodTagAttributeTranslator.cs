// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Attributes.Translator
{
    internal class StylePaneSortMethodTagAttributeTranslator : TagAttributeTranslator
    {
        private static string[] arrayOfOrigTagAttrNames = { "val", "val", "val", "val", "val", "val" };
        private static string[] arrayOfNewTagAttrNames = { "val", "val", "val", "val", "val", "val" };
        private static string[] arrayOfOrigTagAttrValues = { "name", "priority", "default", "font", "basedOn", "type" };
        private static string[] arrayOfNewTagAttrValues = { "0000", "0001", "0002", "0003", "0004", "0005" };
        private static long[] arrayOfTagAttrTraits = { 0, 0, 0, 0, 0, 0 };

        internal StylePaneSortMethodTagAttributeTranslator()
        {
            arrayOfOrigAttrNames = arrayOfOrigTagAttrNames;
            arrayOfNewAttrNames = arrayOfNewTagAttrNames;
            arrayOfOrigAttrValues = arrayOfOrigTagAttrValues;
            arrayOfNewAttrValues = arrayOfNewTagAttrValues;
            arrayOfAttrTraits = arrayOfTagAttrTraits;
            formatter = null;
        }

        /// <summary>
        /// Set the index to specify the value to translate.
        /// </summary>
        /// <returns>The index</returns>
        protected override int SetIndex()
        {
            return this.GetIndexByValue();
        }
    }
}
