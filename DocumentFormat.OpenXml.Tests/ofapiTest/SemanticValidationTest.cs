// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation;
using System.Collections.Generic;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// SemanticValidationTest
    /// </summary>
    public class SemanticValidationTest
    {
        private static bool ErrorShowsUp(IEnumerable<ValidationErrorInfo> errors, string errorDescription)
        {
            bool errShowsUp = false;
            foreach (var error in errors)
            {
                if (error.Description == "Attribute 'totalsRowLabel' should be absent when the value of attribute 'totalsRowFunction' is 'custom'.")
                {
                    errShowsUp = true;
                    break;
                }
            }

            return errShowsUp;
        }

        ///<summary>
        ///Category1_14Test.
        ///</summary>
        [Fact]
        public void Category1_14Test()
        {
            OpenXmlValidator o12Validator = new OpenXmlValidator(FileFormatVersions.Office2007);
            OpenXmlValidator o14Validator = new OpenXmlValidator(FileFormatVersions.Office2010);

            TableColumn column = new TableColumn();

            column.TotalsRowFunction = TotalsRowFunctionValues.Custom;
            Assert.False(ErrorShowsUp(o12Validator.Validate(column), "Attribute 'totalsRowLabel' should be absent when the value of attribute 'totalsRowFunction' is 'custom'."));
            Assert.False(ErrorShowsUp(o14Validator.Validate(column), "Attribute 'totalsRowLabel' should be absent when the value of attribute 'totalsRowFunction' is 'custom'."));

            column.TotalsRowLabel = "somevalue";
            Assert.True(ErrorShowsUp(o12Validator.Validate(column), "Attribute 'totalsRowLabel' should be absent when the value of attribute 'totalsRowFunction' is 'custom'."));
            Assert.True(ErrorShowsUp(o14Validator.Validate(column), "Attribute 'totalsRowLabel' should be absent when the value of attribute 'totalsRowFunction' is 'custom'."));
        }

        ///<summary>
        ///UT4Bug683087.
        ///</summary>
        [Fact]
        public void UT4Bug683087()
        {
            DocumentFormat.OpenXml.Spreadsheet.ServerFormat sf = new DocumentFormat.OpenXml.Spreadsheet.ServerFormat();
            sf.Culture = "test";
            sf.Format = "test";
            var errors = new OpenXmlValidator(FileFormatVersions.Office2010).Validate(sf);

            Assert.Single(errors);
        }
    }
}
