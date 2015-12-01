using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using DocumentFormat.OpenXml.Internal.SemanticValidation;
using DocumentFormat.OpenXml;
using Excel = DocumentFormat.OpenXml.Spreadsheet;
using Word = DocumentFormat.OpenXml.Wordprocessing;
using Vml = DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Validation;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// Summary description for SemanticConstraintTest
    /// </summary>
    
    public class SemanticConstraintTest
    {
        public SemanticConstraintTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
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

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [Fact]
        public void AttributeMinMaxConstraintTest()
        {
            Excel.Column column = new Excel.Column();
            ValidationContext context = new ValidationContext() { Element = column };

            AttributeMinMaxConstraint constraint = new AttributeMinMaxConstraint("", "min", "", "max") ;

            column.Max = 2;
            column.Min = 1;
            Assert.Null(constraint.Validate(context)); //max > min, should pass validation

            column.Max = 2;
            column.Min = 2;
            Assert.Null(constraint.Validate(context)); //max == min, should pass validation

            column.Max = 2;
            column.Min = 3;
            Assert.NotNull(constraint.Validate(context)); //max < min, validation should be failed.
        }

        [Fact]
        public void AttributePairConstraintTest()
        {
            Word.MoveFromRangeStart moveFromRangeStart = new Word.MoveFromRangeStart();
            ValidationContext context = new ValidationContext() { Element = moveFromRangeStart };

            AttributePairConstraint constraint = new AttributePairConstraint("http://schemas.openxmlformats.org/wordprocessingml/2006/main", "colFirst", "http://schemas.openxmlformats.org/wordprocessingml/2006/main", "colLast");

            moveFromRangeStart.ColumnFirst = 1;
            moveFromRangeStart.ColumnLast = 2;
            Assert.Null(constraint.Validate(context));

            moveFromRangeStart.RemoveAttribute("colFirst", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            moveFromRangeStart.ColumnLast = 2;
            Assert.NotNull(constraint.Validate(context));

            moveFromRangeStart.ColumnFirst = 1;
            moveFromRangeStart.RemoveAttribute("colLast", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            Assert.NotNull(constraint.Validate(context));

            moveFromRangeStart.ColumnFirst = null;
            moveFromRangeStart.ColumnLast = null;
            Assert.Null(constraint.Validate(context));
        }

#if false
        // TODO EW
        [Fact]
        public void AttributeValueLengthConstraintTest()
        {
            Word.DecimalSymbol decimalSymbol = new Word.DecimalSymbol();
            ValidationContext context = new ValidationContext() { Element = decimalSymbol };

            AttributeValueLengthConstraint constraint = new AttributeValueLengthConstraint()
            {
                AttributeLocalName = "val",
                AttributeNamespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main",
                MinLength = 1,
                MaxLength = 1
            };

            Assert.Null(constraint.Validate(context));
            
            decimalSymbol.Val = null;
            Assert.Null(constraint.Validate(context));

            decimalSymbol.Val = "";
            Assert.Null(constraint.Validate(context));

            decimalSymbol.Val = ",";
            Assert.Null(constraint.Validate(context));

            decimalSymbol.Val = "!~";
            Assert.NotNull(constraint.Validate(context));
        }

        [Fact]
        public void AttributeValuePatternConstraintTest()
        {
            Excel.MdxTuple mdxTuple = new Excel.MdxTuple();
            ValidationContext context = new ValidationContext() { Element = mdxTuple };

            AttributeValuePatternConstraint constraint = new AttributeValuePatternConstraint()
            {
                AttributeLocalName = "bc",
                AttributeNamespace = "",
                Pattern = "^0x00[0-9]{6,6}$"
            };

            Assert.Null(constraint.Validate(context));

            mdxTuple.BackgroundColor = null;
            Assert.Null(constraint.Validate(context));

            mdxTuple.BackgroundColor = "";
            Assert.Null(constraint.Validate(context));

            mdxTuple.BackgroundColor = "0x12345678";
            Assert.NotNull(constraint.Validate(context));

            mdxTuple.BackgroundColor = "0x00123456";
            Assert.Null(constraint.Validate(context));
        }

        [Fact]
        public void AttributeValueRangeConstraintTest()
        {
            Excel.Column column = new Excel.Column();
            ValidationContext context = new ValidationContext() { Element = column };

            AttributeValueRangeConstraint constraint = new AttributeValueRangeConstraint()
            {
                AttributeLocalName = "outlineLevel",
                AttributeNamespace = "",
                IsValidRange = true,
                MinValue = 0,
                MaxValue = 7
            };

            Assert.Null(constraint.Validate(context));

            column.OutlineLevel = null;
            Assert.Null(constraint.Validate(context));

            column.OutlineLevel = 8;
            Assert.NotNull(constraint.Validate(context));

            column.OutlineLevel = 7;
            Assert.Null(constraint.Validate(context));

            column.OutlineLevel = 0;
            Assert.Null(constraint.Validate(context));
        }

        [Fact]
        public void AttributeValueSetConstraintTest()
        {
            Excel.Parameter parameter = new Excel.Parameter();
            ValidationContext context = new ValidationContext() { Element = parameter };

            AttributeValueSetConstraint constraint = new AttributeValueSetConstraint()
            {
                AttributeLocalName = "sqlType",
                AttributeNamespace = "",
                IsValidValueSet = true,
                ValueSet = new string[] { "-22", "-20", "-11", "-10", "-9", "-8", "-7", "-6", "-5", "-4", "-3", "-2", "-1", 
                                                    "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "101", "102", 
                                                    "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113" }
            };

            Assert.Null(constraint.Validate(context));

            parameter.SqlType = -22;
            Assert.Null(constraint.Validate(context));

            parameter.SqlType = 113;
            Assert.Null(constraint.Validate(context));

            parameter.SqlType = 13;
            Assert.NotNull(constraint.Validate(context));

            parameter.SqlType = 114;
            Assert.NotNull(constraint.Validate(context));
        }

        [Fact]
        public void ParentTypeConstraintTest()
        {
            Word.TableProperties tblPr = new Word.TableProperties();
            ValidationContext context = new ValidationContext() { Element = tblPr };

            ParentTypeConstraint constraint = new ParentTypeConstraint()
            {
                ParentType = typeof(Word.Table)
            };

            Assert.Null(constraint.Validate(context));


            Word.Table tbl = new Word.Table();
            tbl.Append(tblPr);
            Assert.Null(constraint.Validate(context));

            tbl.RemoveAllChildren();
            Word.Paragraph p = new Word.Paragraph();
            p.Append(tblPr);
            Assert.NotNull(constraint.Validate(context));
        }
#endif
    }
}
