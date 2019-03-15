// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Linq;
using System.Reflection;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    public class M4Conformance
    {
        ///<summary>
        ///O14OnlyElesInO12.
        ///</summary>
        [Fact]
        public void O14OnlyElesInO12()
        {
            EndBorder eb = new EndBorder();
            Assert.True(eb.IsInVersion(FileFormatVersions.Office2010));
            Assert.False(eb.IsInVersion(FileFormatVersions.Office2007));

            var attr1 = typeof(EndBorder).GetTypeInfo().GetCustomAttributes<OfficeAvailabilityAttribute>(false).First();
            Assert.True(attr1.OfficeVersion == FileFormatVersions.Office2010);
        }

        ///<summary>
        ///O14ElesInO14.
        ///</summary>
        [Fact]
        public void O14ElesInO14()
        {
            EndBorder eb = new EndBorder();
            Assert.True(eb.IsInVersion(FileFormatVersions.Office2010));
            Assert.False(eb.IsInVersion(FileFormatVersions.Office2007));

            var attr1 = typeof(EndBorder).GetTypeInfo().GetCustomAttributes<OfficeAvailabilityAttribute>(false).First();
            Assert.True(attr1.OfficeVersion == FileFormatVersions.Office2010);
        }

        ///<summary>
        ///LoadExt.
        ///</summary>
        [Fact]
        public void LoadExt()
        {
            using (var stream = GetStream(TestFiles.excel14))
            using (var doc = SpreadsheetDocument.Open(stream, false))
            {
                var ele14 = doc.WorkbookPart.RootElement.LastChild.First().First();
                Assert.True(ele14 is DocumentFormat.OpenXml.Office2010.Excel.WorkbookProperties);
            }
        }

        [Fact]
        public void LoadExt2()
        {
            using (var stream = GetStream(TestFiles.extlst))
            using (var doc = SpreadsheetDocument.Open(stream, false))
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
