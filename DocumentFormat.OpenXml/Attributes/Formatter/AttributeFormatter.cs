// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace DocumentFormat.OpenXml.Attributes.Formatter
{
    /// <summary>
    /// The base class of the Attribute formatter. (abstract)
    /// </summary>
    abstract internal class AttributeFormatter
    {
        protected int length = 0;

        /// <summary>
        /// The constructor to set the length of characters to express.
        /// </summary>
        /// <param name="length"></param>
        internal AttributeFormatter(int length)
        {
            Debug.Assert(length > 0);

            this.length = length;
        }

        /// <summary>
        /// Convert string to long. (abstract)
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns>the converted long value</returns>
        abstract internal long StringToValue(string strValue);

        /// <summary>
        /// Convert long to string. (abstract)
        /// </summary>
        /// <param name="longValue"></param>
        /// <returns>the converted string</returns>
        abstract internal string ValueToString(long longValue);
    }
}
