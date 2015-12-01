using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;
using excel = DocumentFormat.OpenXml.Spreadsheet;
using System.Reflection;
#if WB
using DocumentFormat.OpenXml.WB.Tests;
#endif

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// UnitTest1 的摘要说明
    /// </summary>
    
    public class M4Conformance
    {
        ///<summary>
        ///Constructor.
        ///</summary>
        public M4Conformance()
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

        ///<summary>
        ///O14OnlyElesInO12.
        ///</summary>
        [Fact]
        public void O14OnlyElesInO12()
        {
            //"w:start" element is newly added 
            //its class is StartBorder
            //its parent is TableCellBorder
            //its parent should have corresponding attring
            foreach (var attr in typeof(TableCellBorders).GetCustomAttributes(typeof(ChildElementInfoAttribute), false))
            {
                var ce = attr as ChildElementInfoAttribute;
                if (ce.ElementType == typeof(TopBorder))
                {
                    Assert.Equal(ce.AvailableInVersion, FileFormatVersions.Office2007 | FileFormatVersions.Office2010);
                }
                else if (ce.ElementType == typeof(StartBorder) || ce.ElementType == typeof(EndBorder))
                {
                    Assert.Equal(ce.AvailableInVersion, FileFormatVersions.Office2010);
                }
            }

            EndBorder eb = new EndBorder();
            Assert.True(eb.IsInVersion(FileFormatVersions.Office2010));
            Assert.False(eb.IsInVersion(FileFormatVersions.Office2007));

            var attr1 = typeof(EndBorder).GetCustomAttributes(false).OfType<OfficeAvailabilityAttribute>().First();
            Assert.True(attr1.OfficeVersion == FileFormatVersions.Office2010);

            Assert.True(typeof(TableCellBorders).GetCustomAttributes(false).OfType<OfficeAvailabilityAttribute>().FirstOrDefault() == null);
        }

        ///<summary>
        ///O14ElesInO14.
        ///</summary>
        [Fact]
        public void O14ElesInO14()
        {
            foreach (var attr in typeof(TableCellBorders).GetCustomAttributes(typeof(ChildElementInfoAttribute), false))
            {
                var ce = attr as ChildElementInfoAttribute;
                if (ce.ElementType == typeof(TopBorder))
                {
                    Assert.Equal(ce.AvailableInVersion, FileFormatVersions.Office2007 | FileFormatVersions.Office2010);
                }
                else if (ce.ElementType == typeof(StartBorder) || ce.ElementType == typeof(EndBorder))
                {
                    Assert.Equal(ce.AvailableInVersion, FileFormatVersions.Office2010);
                }
            }

            EndBorder eb = new EndBorder();
            Assert.True(eb.IsInVersion(FileFormatVersions.Office2010));
            Assert.False(eb.IsInVersion(FileFormatVersions.Office2007));

            var attr1 = typeof(EndBorder).GetCustomAttributes(false).OfType<OfficeAvailabilityAttribute>().First();
            Assert.True(attr1.OfficeVersion == FileFormatVersions.Office2010);

            Assert.True(typeof(TableCellBorders).GetCustomAttributes(false).OfType<OfficeAvailabilityAttribute>().FirstOrDefault() == null);
        }

        ///<summary>
        ///LoadExt.
        ///</summary>
        [Fact]
        public void LoadExt()
        {
            string file = "14.docx";
            CopyFileStream(TestFileStreams.excel14, file);

            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(file, false))
            {
                var ele14 = doc.WorkbookPart.RootElement.LastChild.First().First();
                Assert.True(ele14 is DocumentFormat.OpenXml.Office2010.Excel.WorkbookProperties);
            }

            CopyFileStream(TestFileStreams.extlst, file);

            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(file, false))
            {
                var ele14 = doc.WorkbookPart.GetPartById("rId1").GetPartById("rId2").GetPartById("rId1").RootElement.LastChild.FirstChild.FirstChild;
                Assert.True(ele14 is DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions);
            }

        }


        private void CopyFileStream(byte[] srcBuffer, string fileName)
        {
            using (var target = System.IO.File.Create(fileName))
            {
                using (var src = new System.IO.MemoryStream(srcBuffer, false))
                {
                    src.WriteTo(target);
                }
            }
        }
    }
}
