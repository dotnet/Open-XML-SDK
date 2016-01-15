using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// SemanticValidationTest
    /// </summary>
    
    public class SemanticValidationTest
    {
        ///<summary>
        ///Constructor.
        ///</summary>
        public SemanticValidationTest()
        {
        }

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

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

            Assert.Equal(errors.Count(), 1);
        }
    }
}
