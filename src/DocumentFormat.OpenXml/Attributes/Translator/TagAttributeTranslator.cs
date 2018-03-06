// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Attributes.Formatter;

namespace DocumentFormat.OpenXml.Attributes.Translator
{
    /// <summary>
    /// The base class of the Attribute translator for Tag.
    /// TagAttributeTranslator converts an attribute from OrigAttrName="OrigAttrValue" to NewAttrName="NewAttrValue".
    /// AttrTrait is currently used as the bit mask when NewAttrValue needs to be in the bit field representation.
    /// </summary>
    abstract internal class TagAttributeTranslator
    {
        internal enum State
        {
            NotInitialized = -1,
        }

        protected int indexOfAttr;
        protected string strAttrName;
        protected string strAttrValue;
        protected string[] arrayOfOrigAttrNames;
        protected string[] arrayOfNewAttrNames;
        protected string[] arrayOfOrigAttrValues;
        protected string[] arrayOfNewAttrValues;
        protected long[] arrayOfAttrTraits;
        protected AttributeFormatter formatter;

        internal TagAttributeTranslator()
        {
            indexOfAttr = (int)State.NotInitialized;
            strAttrName = null;
            strAttrValue = null;
        }

        /// <summary>
        /// Set LocalName and Value.
        /// </summary>
        /// <param name="strLocalName"></param>
        /// <param name="strValue"></param>
        internal void SetLocalNameAndValue(string strLocalName, string strValue)
        {
            indexOfAttr = (int)State.NotInitialized;
            strAttrName = strLocalName;
            strAttrValue = strValue;
        }

        /// <summary>
        /// Get the index to specify the attribute name to translate.
        /// </summary>
        /// <returns>The index</returns>
        protected int GetIndexByAttributeName()
        {
            int index = (int)State.NotInitialized;

            for (int count = 0; count < arrayOfOrigAttrNames.Length; count++)
            {
                if (arrayOfOrigAttrNames[count] == strAttrName)
                {
                    index = count;
                    break;
                }
            }

            return index;
        }

        /// <summary>
        /// Get the index to specify the value to translate.
        /// </summary>
        /// <returns>The index</returns>
        protected int GetIndexByValue()
        {
            int index = (int)State.NotInitialized;

            for (int count = 0; count < arrayOfOrigAttrValues.Length; count++)
            {
                if (arrayOfOrigAttrValues[count] == strAttrValue)
                {
                    index = count;
                    break;
                }
            }

            return index;
        }

        /// <summary>
        /// Set the index.
        /// </summary>
        /// <returns>The index</returns>
        abstract protected int SetIndex();

        /// <summary>
        /// Gets the Index
        /// </summary>
        /// <returns>The index</returns>
        internal virtual int Index
        {
            get
            {
                if (indexOfAttr == (int)State.NotInitialized)
                {
                    indexOfAttr = SetIndex();
                }

                return indexOfAttr;
            }
        }

        /// <summary>
        /// Gets the LocalName
        /// </summary>
        /// <returns>The LocalName</returns>
        internal virtual string LocalName
        {
            get { return (Index == (int)State.NotInitialized) ? strAttrName : arrayOfNewAttrNames[Index]; }
        }

        /// <summary>
        /// Gets the Value
        /// </summary>
        /// <returns>The value</returns>
        internal virtual string Value
        {
            get { return (Index == (int)State.NotInitialized) ? strAttrValue : arrayOfNewAttrValues[Index]; }
        }

        /// <summary>
        /// Gets the Trait.
        /// </summary>
        /// <returns>The Trait</returns>
        internal virtual long Trait
        {
            get { return (Index == (int)State.NotInitialized) ? 0 : arrayOfAttrTraits[Index]; }
        }

        /// <summary>
        /// Gets the formatter.
        /// </summary>
        internal virtual AttributeFormatter Formatter
        {
            get { return formatter; }
        }
    }
}
