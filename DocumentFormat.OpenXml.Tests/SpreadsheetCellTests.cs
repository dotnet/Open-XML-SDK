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

            Assert.Equal("2017-11-28T12:25:02.0000000", value.Text);
        }

        [Fact]
        public void CellDateTimeOffsetTest()
        {
            var dt = new DateTimeOffset(2017, 11, 28, 12, 25, 2, TimeSpan.Zero);
            var value = new CellValue(dt);

            Assert.Equal("2017-11-28T12:25:02.0000000+00:00", value.Text);
        }
    }
}
