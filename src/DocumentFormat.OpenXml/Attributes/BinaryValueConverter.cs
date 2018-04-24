// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;
using System.Text;

namespace DocumentFormat.OpenXml.Attributes
{
    internal class BinaryValueConverter : IValueConverter
    {
        private readonly int _length;

        public BinaryValueConverter(int length)
        {
            _length = length;
        }

        public long StringToValue(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            var value = 0L;
            var length = str.Length;

            Debug.Assert(length <= 64); // The length of str changes depending on the attribute representation, but it at least needs to be less-than-equal 64(bit).

            for (int count = 0; count < length; count++)
            {
                long bit;
                if (str[count] == '1')
                {
                    bit = 1;
                }
                else if (str[count] == '0')
                {
                    bit = 0;
                }
                else
                {
                    // if strValue[count] is neither '1' nor '0', we ignore this value by setting the bit zero.
                    bit = 0;
                }

                value = (bit == 0) ? (value & ~(bit << (length - 1 - count))) : (value | (bit << (length - 1 - count)));
            }

            return value;
        }

        public string ValueToString(long value)
        {
            var str = new StringBuilder(_length);

            for (int count = _length - 1; count >= 0; count--)
            {
                str.Append((value & (1 << count)) > 0 ? '1' : '0');
            }

            return str.ToString();
        }
    }
}
