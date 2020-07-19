// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Spreadsheet;
using System;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class SpreadsheetCellTests
    {
        [Fact]
        public void CellDateTimeTest()
        {
            var dt = new DateTime(2017, 11, 28, 12, 25, 2);
            var value = new CellValue(dt);

            Assert.Equal("2017-11-28T12:25:02.000", value.Text);
        }

        [Fact]
        public void CellDateTimeOffsetTest()
        {
            var dt = new DateTimeOffset(2017, 11, 28, 12, 25, 2, TimeSpan.Zero);
            var value = new CellValue(dt);

            Assert.Equal("2017-11-28T12:25:02.000+00:00", value.Text);
        }

        [Fact]
        public void CellDateTimeWithMillisecondsTest()
        {
            var dt = new DateTime(2017, 11, 28, 12, 25, 2).AddMilliseconds(123);
            var value = new CellValue(dt);

            Assert.Equal("2017-11-28T12:25:02.123", value.Text);
        }

        [Fact]
        public void CellDateTimeOffsetWithMillisecondsTest()
        {
            var dt = new DateTimeOffset(2017, 11, 28, 12, 25, 2, TimeSpan.Zero).AddMilliseconds(123);
            var value = new CellValue(dt);

            Assert.Equal("2017-11-28T12:25:02.123+00:00", value.Text);
        }
    }
}
