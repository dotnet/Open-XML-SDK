// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Attributes.Translator
{
    internal class TextDirectionTagAttributeTranslator : TagAttributeTranslator
    {
        private static string[] arrayOfOrigTagAttrNames = { "val", "val", "val", "val", "val", "val" };
        private static string[] arrayOfNewTagAttrNames = { "val", "val", "val", "val", "val", "val" };
        private static string[] arrayOfOrigTagAttrValues = { "lr", "tb", "tbV", "lrV", "rl", "rlV" };
        private static string[] arrayOfNewTagAttrValues = { "btLr", "lrTb", "lrTbV", "tbLrV", "tbRl", "tbRlV" };
        private static long[] arrayOfTagAttrTraits = { 0, 0, 0, 0, 0, 0 };

        internal TextDirectionTagAttributeTranslator()
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
