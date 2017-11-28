using System;
using System.Globalization;

namespace DocumentFormat.OpenXml.Spreadsheet
{
    /// <summary>
    /// This provides an additional constructor than in the generated files.
    /// 
    /// TODO: The schema generator should be updated to include this constructor
    /// </summary>
    public partial class CellValue
    {
        /// <summary>
        /// Instantiates an instance of <see cref="CellValue"/> for a <see cref="DateTime"/>. Dates must
        /// be in ISO 861 format, which this constructor ensures
        /// </summary>
        /// <param name="dateTime">DateTime for cell</param>
        public CellValue(DateTime dateTime)
            : this(dateTime.ToString("u", CultureInfo.InvariantCulture))
        {
        }

        /// <summary>
        /// Instantiates an instance of <see cref="CellValue"/> for a <see cref="DateTimeOffset"/>. Dates must
        /// be in ISO 861 format, which this constructor ensures
        /// </summary>
        /// <param name="dateTimeOffset">DateTime for cell</param>
        public CellValue(DateTimeOffset dateTimeOffset)
            : this(dateTimeOffset.ToString("u", CultureInfo.InvariantCulture))
        {
        }
    }
}
