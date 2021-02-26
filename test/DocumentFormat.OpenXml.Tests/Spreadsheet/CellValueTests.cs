// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class CellValueTests
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

        [InlineData("987.6E+30", 9.876E+32)]
        [InlineData("-12.34E-20", -1.234E-19)]
        [Theory]
        public void CellDoubleTestExponential(string num, double expected)
        {
            var value = new CellValue(num);

            Assert.Equal(num, value.Text);
            Assert.Equal(num, value.InnerText);
            Assert.Equal(@$"<x:v xmlns:x=""http://schemas.openxmlformats.org/spreadsheetml/2006/main"">{num}</x:v>", value.OuterXml);
            Assert.True(value.TryGetDouble(out var result));
            Assert.Equal(expected, result);
        }

        [InlineData(null)]
        [InlineData("")]
        [InlineData("other")]
        [Theory]
        public void CellDoubleTestFalse(string input)
        {
            var value = new CellValue { Text = input };

            Assert.False(value.TryGetDouble(out _));
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

        [InlineData("987E+5", 98700000)]
        [Theory]
        public void CellIntTestExponential(string num, int expected)
        {
            var value = new CellValue(num);

            Assert.Equal(num, value.Text);
            Assert.Equal(num, value.InnerText);
            Assert.Equal(@$"<x:v xmlns:x=""http://schemas.openxmlformats.org/spreadsheetml/2006/main"">{num}</x:v>", value.OuterXml);
            Assert.True(value.TryGetInt(out var result));
            Assert.Equal(expected, result);
        }

        [InlineData(null)]
        [InlineData("")]
        [InlineData("other")]
        [Theory]
        public void CellIntTestNegative(string input)
        {
            var value = new CellValue { Text = input };

            Assert.False(value.TryGetInt(out _));
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

        [InlineData("987.6E+8", 9.876E+10)]
        [InlineData("-12.34E-7", -1.234E-6)]
        [Theory]
        public void CellDecimalTestExponential(string num, decimal expected)
        {
            var value = new CellValue(num);

            Assert.Equal(num, value.Text);
            Assert.Equal(num, value.InnerText);
            Assert.Equal(@$"<x:v xmlns:x=""http://schemas.openxmlformats.org/spreadsheetml/2006/main"">{num}</x:v>", value.OuterXml);
            Assert.True(value.TryGetDecimal(out var result));
            Assert.Equal(expected, result);
        }

        [InlineData(null)]
        [InlineData("")]
        [InlineData("other")]
        [Theory]
        public void CellDecimalTestNegative(string input)
        {
            var value = new CellValue { Text = input };

            Assert.False(value.TryGetDecimal(out _));
        }

        [InlineData("0", false)]
        [InlineData("false", false)]
        [InlineData("1", true)]
        [InlineData("true", true)]
        [Theory]
        public void CellBooleanTest(string input, bool expected)
        {
            var value = new CellValue { Text = input };

            Assert.True(value.TryGetBoolean(out var result));
            Assert.Equal(expected, result);
        }

        [InlineData(null)]
        [InlineData("")]
        [InlineData("other")]
        [InlineData("False")]
        [InlineData("True")]
        [Theory]
        public void CellBooleanTestNegative(string input)
        {
            var value = new CellValue { Text = input };

            Assert.False(value.TryGetBoolean(out _));
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
