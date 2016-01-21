// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
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
using OxTest;
#if WB
using DocumentFormat.OpenXml.WB.Tests;
#endif

namespace DocumentFormat.OpenXml.Tests
{
    public class M4Conformance
    {
        ///<summary>
        ///Constructor.
        ///</summary>
        public M4Conformance()
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
                    Assert.True((ce.AvailableInVersion & FileFormatVersions.Office2007) > 0);
                    Assert.True((ce.AvailableInVersion & FileFormatVersions.Office2010) > 0);
                }
                else if (ce.ElementType == typeof(StartBorder) || ce.ElementType == typeof(EndBorder))
                {
                    Assert.True((ce.AvailableInVersion & FileFormatVersions.Office2010) > 0);
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
                    var av = ce.AvailableInVersion;
                    var isIn2010 = (ce.AvailableInVersion & FileFormatVersions.Office2010) > 0;
                    if (!isIn2010)
                        Console.WriteLine();
                    Assert.True(isIn2010);
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
            string file = System.IO.Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
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
