// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Globalization;

namespace DocumentFormat.OpenXml.Attributes.Formatter
{
    /// <summary>
    /// Convert format between long and hex.
    /// </summary>
    internal class HexAttributeFormatter : AttributeFormatter
    {
        /// <summary>
        /// The constructor to set the length of characters to express.
        /// </summary>
        /// <param name="length"></param>
        internal HexAttributeFormatter(int length) : base(length)
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

            Debug.Assert(strValue != null);

            try
            {
                Int64.TryParse(strValue, NumberStyles.HexNumber, new CultureInfo("en-US"), out longValue);
            }
            catch
            {
                Debug.Assert(true, "Int64.TryParse failed.");
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
            return longValue.ToString("X4");
        }
    }
}
