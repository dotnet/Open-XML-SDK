// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class CellTests
    {
        public enum Value
        {
            Number,
            Boolean,
            Date,
        }

        // Numbers
        [InlineData("StringValue", Value.Number, false)]
        [InlineData("1", Value.Number, true)]
        [InlineData("1.0", Value.Number, true)]
        [InlineData("-1.0", Value.Number, true)]
        [InlineData("9.999E+307", Value.Number, true)]
        [InlineData("-2.4E-6", Value.Number, true)]

        // Boolean
        [InlineData("false", Value.Boolean, true)]
        [InlineData("False", Value.Boolean, false)]
        [InlineData("true", Value.Boolean, true)]
        [InlineData("True", Value.Boolean, false)]
        [InlineData("other", Value.Boolean, false)]
        [InlineData("0", Value.Boolean, true)]
        [InlineData("1", Value.Boolean, true)]

        // Dates
        [InlineData("DateValue", Value.Date, false)]
        [InlineData("2017-11-28T12:25:02.123+00:00", Value.Date, true)]
        [InlineData("2017-11-28T12:25:02.123", Value.Date, true)]
        [InlineData("2017-11-28T12:25:02.000", Value.Date, true)]
        [InlineData("2017-11-28T12:25:02.000+00:00", Value.Date, true)]
        [Theory]
        public void CellValidationTest(string value, Value type, bool isValid)
        {
            var cell = new Cell
            {
                CellValue = new CellValue(value),
                DataType = GetCellValue(type),
            };

            var validator = new OpenXmlValidator();
            var results = validator.Validate(cell);

            if (isValid)
            {
                Assert.Empty(results);
            }
            else
            {
                Assert.Single(results);
            }
        }

        private static CellValues GetCellValue(Value value) => value switch
        {
            Value.Number => CellValues.Number,
            Value.Boolean => CellValues.Boolean,
            Value.Date => CellValues.Date,
            _ => throw new System.NotImplementedException(),
        };

        // Boolean
        [InlineData(false, Value.Boolean, true)]
        [InlineData(true, Value.Boolean, true)]
        [Theory]
        public void CellBooleanValueValidationTest(bool value, Value type, bool isValid)
        {
            var cell = new Cell
            {
                CellValue = new CellValue(value),
                DataType = GetCellValue(type),
            };

            var validator = new OpenXmlValidator();
            var results = validator.Validate(cell);

            if (isValid)
            {
                Assert.Empty(results);
            }
            else
            {
                Assert.Single(results);
            }
        }
    }
}
