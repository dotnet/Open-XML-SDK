// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Spreadsheet;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class RowTests
    {
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("999999", 999999)]
        [InlineData("1e6", 1e6)]
        [Theory]
        public void ValidRowNumber(string value, uint expected)
        {
            var outerXml = $@"<x:row r=""{value}"" xmlns:x=""http://schemas.openxmlformats.org/spreadsheetml/2006/main"" />";
            var row = new Row(outerXml);

            Assert.Equal(expected, row.RowIndex.Value);
        }
    }
}
