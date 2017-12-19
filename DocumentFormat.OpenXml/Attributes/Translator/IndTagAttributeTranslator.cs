// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Attributes.Translator
{
    internal class IndTagAttributeTranslator : TagAttributeTranslator
    {
        private static string[] arrayOfOrigTagAttrNames = { "left", "leftChars", "right", "rightChars" };
        private static string[] arrayOfNewTagAttrNames = { "start", "startChars", "end", "endChars" };
        private static long[] arrayOfTagAttrTraits = { 0, 0, 0, 0 };

        internal IndTagAttributeTranslator()
        {
            arrayOfOrigAttrNames = arrayOfOrigTagAttrNames;
            arrayOfNewAttrNames = arrayOfNewTagAttrNames;
            arrayOfOrigAttrValues = null;
            arrayOfNewAttrValues = null;
            arrayOfAttrTraits = arrayOfTagAttrTraits;
            formatter = null;
        }

        /// <summary>
        /// Set the index to specify the attribte name to translate.
        /// </summary>
        /// <returns>The index</returns>
        protected override int SetIndex()
        {
            return this.GetIndexByAttributeName();
        }

        /// <summary>
        /// Get the attribute value.
        /// </summary>
        /// <returns>The attribute value</returns>
        internal override string Value
        {
            get { return this.strAttrValue; }
        }
    }
}
