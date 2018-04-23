// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Globalization;

namespace DocumentFormat.OpenXml.Attributes
{
    /// <summary>
    /// Convert format between long and hex.
    /// </summary>
    internal class HexValueConverter : IValueConverter
    {
        public static IValueConverter Instance { get; } = new HexValueConverter();

        private HexValueConverter()
        {
        }

        public long StringToValue(string str)
        {
            if (long.TryParse(str, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var value))
            {
                return value;
            }

            return 0;
        }

        public string ValueToString(long value) => value.ToString("X4", CultureInfo.InvariantCulture);
    }
}
