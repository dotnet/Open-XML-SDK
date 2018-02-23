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
            this.indexOfAttr = (int)State.NotInitialized;
            this.strAttrName = null;
            this.strAttrValue = null;
        }

        /// <summary>
        /// Set LocalName and Value.
        /// </summary>
        /// <param name="strLocalName"></param>
        /// <param name="strValue"></param>
        internal void SetLocalNameAndValue(string strLocalName, string strValue)
        {
            this.indexOfAttr = (int)State.NotInitialized;
            this.strAttrName = strLocalName;
            this.strAttrValue = strValue;
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
                if (arrayOfOrigAttrNames[count] == this.strAttrName)
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
                if (arrayOfOrigAttrValues[count] == this.strAttrValue)
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
                if (this.indexOfAttr == (int)State.NotInitialized)
                {
                    this.indexOfAttr = this.SetIndex();
                }

                return this.indexOfAttr;
            }
        }

        /// <summary>
        /// Gets the LocalName
        /// </summary>
        /// <returns>The LocalName</returns>
        internal virtual string LocalName
        {
            get { return (this.Index == (int)State.NotInitialized) ? this.strAttrName : this.arrayOfNewAttrNames[this.Index]; }
        }

        /// <summary>
        /// Gets the Value
        /// </summary>
        /// <returns>The value</returns>
        internal virtual string Value
        {
            get { return (this.Index == (int)State.NotInitialized) ? this.strAttrValue : this.arrayOfNewAttrValues[this.Index]; }
        }

        /// <summary>
        /// Gets the Trait.
        /// </summary>
        /// <returns>The Trait</returns>
        internal virtual long Trait
        {
            get { return (this.Index == (int)State.NotInitialized) ? 0 : this.arrayOfAttrTraits[this.Index]; }
        }

        /// <summary>
        /// Gets the formatter.
        /// </summary>
        internal virtual AttributeFormatter Formatter
        {
            get { return this.formatter; }
        }
    }
}
