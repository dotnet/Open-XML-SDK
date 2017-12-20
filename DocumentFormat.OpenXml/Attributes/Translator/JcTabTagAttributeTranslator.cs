// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Attributes.Translator
{
    internal class JcTabTagAttributeTranslator : TagAttributeTranslator
    {
        private static string[] arrayOfOrigTagAttrNames = { "val", "val" };
        private static string[] arrayOfNewTagAttrNames = { "val", "val" };
        private static string[] arrayOfOrigTagAttrValues = { "start", "end" };
        private static string[] arrayOfNewTagAttrValues = { "left", "right" };
        private static long[] arrayOfTagAttrTraits = { 0, 0 };

        internal JcTabTagAttributeTranslator()
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
