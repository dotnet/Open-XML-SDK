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
    /// SemanticValidationTest 的摘要说明
    /// </summary>
    
    public class SemanticValidationTest
    {
        ///<summary>
        ///Constructor.
        ///</summary>
        public SemanticValidationTest()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
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

        #region 附加测试属性
        //
        // 编写测试时，还可使用以下附加属性:
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

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

#if false
        // TODO EW

        ///<summary>
        ///UT4Bug671276.
        ///</summary>
        [Fact]
        public void UT4Bug671276()
        {
            using (var stream = new System.IO.MemoryStream(TestFileStreams.Revision___NameCommentChange, true))
            {
                using (SpreadsheetDocument testDocument = SpreadsheetDocument.Open(stream, false))
                {
                    OpenXmlValidator val = new OpenXmlValidator(FileFormatVersions.Office2010);

                    var part = testDocument.WorkbookPart.GetPartById("rId7").GetPartById("rId3");

                    RevisionDefinedName rdn = part.RootElement.GetFirstChild<RevisionDefinedName>();

                    rdn.Name = "1abcd0101,01_***";

                    var cnt = val.Validate(rdn).Count();

                    Assert.Equal(cnt, 1);
                }
            }
        }
#endif

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
