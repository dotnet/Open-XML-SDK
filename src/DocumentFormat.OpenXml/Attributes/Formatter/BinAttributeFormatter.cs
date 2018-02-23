// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;
using System.Text;

namespace DocumentFormat.OpenXml.Attributes.Formatter
{
    /// <summary>
    /// Convert format between long and bin.
    /// </summary>
    internal class BinAttributeFormatter : AttributeFormatter
    {
        /// <summary>
        /// The constructor to set the length of characters to express.
        /// </summary>
        /// <param name="length"></param>
        internal BinAttributeFormatter(int length) : base(length)
        {
        }

        /// <summary>
        /// Convert string to long.
        /// </summary>
        /// <param name="strValue"></param>
        /// <returns>the converted long value</returns>
        internal override long StringToValue(string strValue)
        {
            long longValue = 0;
            int length;

            Debug.Assert(strValue != null);

            length = strValue.Length;

            Debug.Assert(length > 0);
            Debug.Assert(length <= 64); // The length of strValue changes depending on the attribute representation, but it at least needs to be less-than-equal 64(bit).

            for (int count = 0; count < length; count++)
            {
                long bit;
                if (strValue[count] == '1')
                {
                    bit = 1;
                }
                else if (strValue[count] == '0')
                {
                    bit = 0;
                }
                else
                {
                    // if strValue[count] is neither '1' nor '0', we ignore this value by setting the bit zero.
                    bit = 0;
                }

                longValue = (bit == 0) ? (longValue & ~(bit << (length - 1 - count))) : (longValue | (bit << (length - 1 - count)));
            }

            return longValue;
        }

        /// <summary>
        /// Convert long to string.
        /// </summary>
        /// <param name="longValue"></param>
        /// <returns>the converted string</returns>
        internal override string ValueToString(long longValue)
        {
            StringBuilder strBin = new StringBuilder();

            for (int count = this.length - 1; count >= 0; count--)
            {
                strBin.Append((longValue & (1 << count)) > 0 ? '1' : '0');
            }

            return strBin.ToString();
        }
    }
}
