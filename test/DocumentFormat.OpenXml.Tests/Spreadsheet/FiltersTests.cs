// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation;
using Xunit;

using X14 = DocumentFormat.OpenXml.Office2010.Excel;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// CT_Filters is a sequence of filter [0..*] followed by dateGroupItem [0..*] (ISO/IEC 29500-1 18.3.2.8).
    /// MS-XLSX allows x14:filter elements in place of the x:filter elements.
    /// </summary>
    public class FiltersTests
    {
        [InlineData(FileFormatVersions.Office2007)]
        [InlineData(FileFormatVersions.Microsoft365)]
        [Theory]
        public void EmptyIsValid(FileFormatVersions version)
        {
            AssertValid(version, new Filters());
        }

        [InlineData(FileFormatVersions.Office2007)]
        [InlineData(FileFormatVersions.Microsoft365)]
        [Theory]
        public void FiltersOnlyIsValid(FileFormatVersions version)
        {
            AssertValid(version, new Filters(CreateFilter("a"), CreateFilter("b")));
        }

        [InlineData(FileFormatVersions.Office2007)]
        [InlineData(FileFormatVersions.Microsoft365)]
        [Theory]
        public void DateGroupItemsOnlyIsValid(FileFormatVersions version)
        {
            AssertValid(version, new Filters(CreateDateGroupItem(2023), CreateDateGroupItem(2024)));
        }

        [InlineData(FileFormatVersions.Office2007)]
        [InlineData(FileFormatVersions.Office2010)]
        [InlineData(FileFormatVersions.Office2013)]
        [InlineData(FileFormatVersions.Office2016)]
        [InlineData(FileFormatVersions.Office2019)]
        [InlineData(FileFormatVersions.Office2021)]
        [InlineData(FileFormatVersions.Microsoft365)]
        [Theory]
        public void FilterFollowedByDateGroupItemIsValid(FileFormatVersions version)
        {
            AssertValid(version, new Filters(
                CreateFilter("a"),
                CreateFilter("b"),
                CreateDateGroupItem(2023),
                CreateDateGroupItem(2024)));
        }

        [InlineData(FileFormatVersions.Office2010)]
        [InlineData(FileFormatVersions.Microsoft365)]
        [Theory]
        public void X14FilterFollowedByDateGroupItemIsValid(FileFormatVersions version)
        {
            AssertValid(version, new Filters(
                new X14.Filter { Val = "a" },
                new X14.Filter { Val = "b" },
                CreateDateGroupItem(2024)));
        }

        [InlineData(FileFormatVersions.Office2007)]
        [InlineData(FileFormatVersions.Microsoft365)]
        [Theory]
        public void DateGroupItemFollowedByFilterIsInvalid(FileFormatVersions version)
        {
            AssertInvalid(version, new Filters(CreateDateGroupItem(2024), CreateFilter("a")));
        }

        [Fact]
        public void X14FilterIsInvalidInOffice2007()
        {
            AssertInvalid(FileFormatVersions.Office2007, new Filters(new X14.Filter { Val = "a" }));
        }

        [Fact]
        public void X14FilterMixedWithFilterIsInvalid()
        {
            AssertInvalid(FileFormatVersions.Microsoft365, new Filters(new X14.Filter { Val = "a" }, CreateFilter("b")));
        }

        private static Filter CreateFilter(string val) => new Filter { Val = val };

        private static DateGroupItem CreateDateGroupItem(ushort year) => new DateGroupItem
        {
            Year = year,
            DateTimeGrouping = DateTimeGroupingValues.Year,
        };

        private static void AssertValid(FileFormatVersions version, Filters filters)
        {
            var validator = new OpenXmlValidator(version);

            Assert.Empty(validator.Validate(filters, TestContext.Current.CancellationToken));
        }

        private static void AssertInvalid(FileFormatVersions version, Filters filters)
        {
            var validator = new OpenXmlValidator(version);

            Assert.NotEmpty(validator.Validate(filters, TestContext.Current.CancellationToken));
        }
    }
}
