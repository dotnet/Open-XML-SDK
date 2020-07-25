// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
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

            Assert.True(value.TryGetDateTime(out var result));
            Assert.Equal(dt, result);
        }

        [Fact]
        public void CellDateTimeOffsetTest()
        {
            var dt = new DateTimeOffset(2017, 11, 28, 12, 25, 2, TimeSpan.Zero);
            var value = new CellValue(dt);

            Assert.Equal("2017-11-28T12:25:02.000+00:00", value.Text);

            Assert.True(value.TryGetDateTimeOffset(out var result));
            Assert.Equal(dt, result);
        }

        [Fact]
        public void CellDateTimeWithMillisecondsTest()
        {
            var dt = new DateTime(2017, 11, 28, 12, 25, 2).AddMilliseconds(123);
            var value = new CellValue(dt);

            Assert.Equal("2017-11-28T12:25:02.123", value.Text);

            Assert.True(value.TryGetDateTime(out var result));
            Assert.Equal(dt, result);
        }

        [Fact]
        public void CellDateTimeOffsetWithMillisecondsTest()
        {
            var dt = new DateTimeOffset(2017, 11, 28, 12, 25, 2, TimeSpan.Zero).AddMilliseconds(123);
            var value = new CellValue(dt);

            Assert.Equal("2017-11-28T12:25:02.123+00:00", value.Text);
            Assert.True(value.TryGetDateTimeOffset(out var result));
            Assert.Equal(dt, result);
        }

        [InlineData(-1.5)]
        [InlineData(-1.0)]
        [InlineData(0.0)]
        [InlineData(1.0)]
        [InlineData(1.5)]
        [Theory]
        public void CellDoubleTest(double num)
        {
            var value = new CellValue(num);

            Assert.Equal(num.ToString(), value.Text);
            Assert.Equal(num.ToString(), value.InnerText);
            Assert.Equal(@$"<x:v xmlns:x=""http://schemas.openxmlformats.org/spreadsheetml/2006/main"">{num}</x:v>", value.OuterXml);
            Assert.True(value.TryGetDouble(out var result));
            Assert.Equal(num, result);
        }

        [InlineData(int.MinValue)]
        [InlineData(int.MinValue + 1)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(int.MaxValue - 1)]
        [InlineData(int.MaxValue)]
        [Theory]
        public void CellIntTest(int num)
        {
            var value = new CellValue(num);

            Assert.Equal(num.ToString(), value.Text);
            Assert.Equal(num.ToString(), value.InnerText);
            Assert.Equal(@$"<x:v xmlns:x=""http://schemas.openxmlformats.org/spreadsheetml/2006/main"">{num}</x:v>", value.OuterXml);
            Assert.True(value.TryGetInt(out var result));
            Assert.Equal(num, result);
        }

        [MemberData(nameof(DecimalTests))]
        [Theory]
        public void CellDecimalTest(decimal num)
        {
            var value = new CellValue(num);

            Assert.Equal(num.ToString(), value.Text);
            Assert.Equal(num.ToString(), value.InnerText);
            Assert.Equal(@$"<x:v xmlns:x=""http://schemas.openxmlformats.org/spreadsheetml/2006/main"">{num}</x:v>", value.OuterXml);
            Assert.True(value.TryGetDecimal(out var result));
            Assert.Equal(num, result);
        }

        private static readonly decimal[] _decimalValues = new decimal[]
        {
            decimal.MinValue,
            decimal.MinValue + 1,
            -1M,
            0M,
            1M,
            decimal.MaxValue - 1,
            decimal.MaxValue,
        };

        public static IEnumerable<object[]> DecimalTests()
        {
            foreach (var v in _decimalValues)
            {
                yield return new object[] { v };
            }
        }
    }
}
