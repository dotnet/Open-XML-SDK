// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Attributes.Translator
{
    internal class DocumentTagAttributeTranslator : TagAttributeTranslator
    {
        private static string[] arrayOfOrigTagAttrNames = { "conformance" };
        private static string[] arrayOfNewTagAttrNames = { "conformance" };
        private static string[] arrayOfOrigTagAttrValues = { "strict" };
        private static string[] arrayOfNewTagAttrValues = { "" }; // Must be "".
        private static long[] arrayOfTagAttrTraits = { 0 };

        internal DocumentTagAttributeTranslator()
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
