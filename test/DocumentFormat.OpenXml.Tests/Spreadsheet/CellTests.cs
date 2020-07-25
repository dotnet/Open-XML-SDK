﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class CellTests
    {
        // Numbers
        [InlineData("StringValue", CellValues.Number, false)]
        [InlineData("1", CellValues.Number, true)]
        [InlineData("1.0", CellValues.Number, true)]
        [InlineData("-1.0", CellValues.Number, true)]

        // Boolean
        [InlineData("false", CellValues.Boolean, true)]
        [InlineData("true", CellValues.Boolean, true)]
        [InlineData("other", CellValues.Boolean, false)]

        // Dates
        [InlineData("DateValue", CellValues.Date, false)]
        [InlineData("2017-11-28T12:25:02.123+00:00", CellValues.Date, true)]
        [InlineData("2017-11-28T12:25:02.123", CellValues.Date, true)]
        [InlineData("2017-11-28T12:25:02.000", CellValues.Date, true)]
        [InlineData("2017-11-28T12:25:02.000+00:00", CellValues.Date, true)]
        [Theory]
        public void CellValidationTest(string value, CellValues type, bool success)
        {
            var cell = new Cell
            {
                CellValue = new CellValue(value),
                DataType = type,
            };

            var validator = new OpenXmlValidator();
            var results = validator.Validate(cell);

            if (success)
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
