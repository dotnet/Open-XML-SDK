// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Spreadsheet
{
    /// <summary>
    /// This provides additional constructors than in the generated files.
    /// </summary>
    public partial class CellValue
    {
        private const string DateTimeFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff";
        private const string DateTimeOffsetFormatString = DateTimeFormatString + "zzz";

        /// <summary>
        /// Instantiates an instance of <see cref="CellValue"/> for a <see cref="DateTime"/>. Dates must
        /// be in ISO 8601 format, which this constructor ensures
        /// </summary>
        /// <param name="dateTime">DateTime for cell</param>
        public CellValue(DateTime dateTime)
            : this(ToCellFormat(dateTime))
        {
        }

        /// <summary>
        /// Instantiates an instance of <see cref="CellValue"/> for a <see cref="DateTimeOffset"/>. Dates must
        /// be in ISO 8601 format, which this constructor ensures
        /// </summary>
        /// <param name="dateTimeOffset">DateTime for cell</param>
        public CellValue(DateTimeOffset dateTimeOffset)
            : this(ToCellFormat(dateTimeOffset))
        {
        }

        /// <summary>
        /// Instantiates an instance of <see cref="CellValue"/> for a <see cref="bool"/>.
        /// </summary>
        /// <param name="value">Boolean value</param>
        public CellValue(bool value)
            : this(value.ToString())
        {
        }

        /// <summary>
        /// Instantiates an instance of <see cref="CellValue"/> for a <see cref="double"/>.
        /// </summary>
        /// <param name="value">Number.</param>
        public CellValue(double value)
            : this(value.ToString())
        {
        }

        /// <summary>
        /// Instantiates an instance of <see cref="CellValue"/> for a <see cref="int"/>.
        /// </summary>
        /// <param name="value">Number.</param>
        public CellValue(int value)
            : this(value.ToString())
        {
        }

        /// <summary>
        /// Instantiates an instance of <see cref="CellValue"/> for a <see cref="decimal"/>.
        /// </summary>
        /// <param name="value">Number.</param>
        public CellValue(decimal value)
            : this(value.ToString())
        {
        }

        /// <summary>
        /// Attempts to parse cell value to retrieve a <see cref="DateTime"/>.
        /// </summary>
        /// <param name="dt">The result if successful.</param>
        /// <returns>Success or failure</returns>
        public bool TryGetDateTime(out DateTime dt)
            => DateTime.TryParseExact(InnerText, DateTimeFormatString, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);

        /// <summary>
        /// Attempts to parse cell value to retrieve a <see cref="DateTimeOffset"/>.
        /// </summary>
        /// <param name="dt">The result if successful.</param>
        /// <returns>Success or failure</returns>
        public bool TryGetDateTimeOffset(out DateTimeOffset dt)
            => DateTimeOffset.TryParseExact(InnerText, DateTimeOffsetFormatString, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);

        /// <summary>
        /// Attempts to parse cell value to retrieve a <see cref="double"/>.
        /// </summary>
        /// <param name="dbl">The result if successful.</param>
        /// <returns>Success or failure</returns>
        public bool TryGetDouble(out double dbl)
            => double.TryParse(InnerText, NumberStyles.Number, CultureInfo.InvariantCulture, out dbl);

        /// <summary>
        /// Attempts to parse cell value to retrieve a <see cref="int"/>.
        /// </summary>
        /// <param name="value">The result if successful.</param>
        /// <returns>Success or failure</returns>
        public bool TryGetInt(out int value)
            => int.TryParse(InnerText, NumberStyles.Number, CultureInfo.InvariantCulture, out value);

        /// <summary>
        /// Attempts to parse cell value to retrieve a <see cref="decimal"/>.
        /// </summary>
        /// <param name="value">The result if successful.</param>
        /// <returns>Success or failure</returns>
        public bool TryGetDecimal(out decimal value)
            => decimal.TryParse(InnerText, NumberStyles.Number, CultureInfo.InvariantCulture, out value);

        /// <summary>
        /// Attempts to parse cell value to retrieve a <see cref="bool"/>.
        /// </summary>
        /// <param name="value">The result if successful.</param>
        /// <returns>Success or failure</returns>
        public bool TryGetBoolean(out bool value)
            => bool.TryParse(InnerText, out value);

        private static string ToCellFormat(DateTime dateTime)
            => dateTime.ToString(DateTimeFormatString, CultureInfo.InvariantCulture);

        private static string ToCellFormat(DateTimeOffset dateTime)
            => dateTime.ToString(DateTimeOffsetFormatString, CultureInfo.InvariantCulture);
    }
}
