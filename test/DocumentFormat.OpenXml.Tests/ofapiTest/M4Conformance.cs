// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
            //"w:start" element is newly added
            //its class is StartBorder
            //its parent is TableCellBorder
            //its parent should have corresponding attribute
            foreach (var ce in typeof(TableCellBorders).GetTypeInfo().GetCustomAttributes<ChildElementInfoAttribute>(false))
            {
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

            var attr1 = typeof(EndBorder).GetTypeInfo().GetCustomAttributes<OfficeAvailabilityAttribute>(false).First();
            Assert.True(attr1.OfficeVersion == FileFormatVersions.Office2010);
        }

        ///<summary>
        ///O14ElesInO14.
        ///</summary>
        [Fact]
        public void O14ElesInO14()
        {
            foreach (var attr in typeof(TableCellBorders).GetTypeInfo().GetCustomAttributes<ChildElementInfoAttribute>(false))
            {
                if (attr.ElementType == typeof(TopBorder))
                {
                    Assert.True(attr.AvailableInVersion.All());
                }
                else if (attr.ElementType == typeof(StartBorder) || attr.ElementType == typeof(EndBorder))
                {
                    Assert.True(attr.AvailableInVersion.Includes(FileFormatVersions.Office2010));
                }
            }

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
