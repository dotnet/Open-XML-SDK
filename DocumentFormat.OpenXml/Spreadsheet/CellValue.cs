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
        /// <summary>
        /// Instantiates an instance of <see cref="CellValue"/> for a <see cref="DateTime"/>. Dates must
        /// be in ISO 8601 format, which this constructor ensures
        /// </summary>
        /// <param name="dateTime">DateTime for cell</param>
        public CellValue(DateTime dateTime)
            : this(dateTime.ToString("o", CultureInfo.InvariantCulture))
        {
        }

        /// <summary>
        /// Instantiates an instance of <see cref="CellValue"/> for a <see cref="DateTimeOffset"/>. Dates must
        /// be in ISO 8601 format, which this constructor ensures
        /// </summary>
        /// <param name="dateTimeOffset">DateTime for cell</param>
        public CellValue(DateTimeOffset dateTimeOffset)
            : this(dateTimeOffset.ToString("o", CultureInfo.InvariantCulture))
        {
        }
    }
}
