// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    public class AutoSaveTestClass
    {
        [Fact]
        public void DefaultStreamReadOnlyWord()
        {
            using (var file = OpenFile(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, FileAccess.Read))
            {
                Assert.Throws<OpenXmlPackageException>(() =>
                {
                    using (var stream = file.Open())
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                    }
                });
            }
        }

        [Fact]
        public void DefaultStreamReadOnlyExcel()
        {
            using (var file = OpenFile(TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, FileAccess.Read))
            {
                Assert.Throws<OpenXmlPackageException>(() =>
                {
                    using (var stream = file.Open())
                    using (var package = SpreadsheetDocument.Open(stream, true))
                    {
                    }
                });
            }
        }

        [Fact]
        public void DefaultStreamReadOnlyPresentation()
        {
            using (var file = OpenFile(TestDataStorage.V2FxTestFiles.Bvt.O12Typical, FileAccess.Read))
            {
                Assert.Throws<OpenXmlPackageException>(() =>
                {
                    using (var stream = file.Open())
                    using (var package = PresentationDocument.Open(stream, true))
                    {
                    }
                });
            }
        }

        [Theory]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, false)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, true)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, false)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.O12Typical, true)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.O12Typical, false)]
        public void DefaultStreamReadWriteAutosave(string testfile, bool autosave)
        {
            using (var stream = OpenFile(testfile, true))
            {
                string expected;

                using (var package = stream.Open(true, new OpenSettings() { AutoSave = autosave }))
                {
                    expected = package.MainPart().RootElement.FirstChild?.InnerText;
                    package.MainPart().RootElement.FirstChild.Remove();

                    if (autosave)
                    {
                        expected = package.MainPart().RootElement.FirstChild?.InnerText;
                    }
                }

                using (var package = stream.Open(true, new OpenSettings() { AutoSave = false }))
                {
                    var actual = package.MainPart().RootElement.FirstChild?.InnerText;

                    Assert.Equal(expected, actual);
                }
            }
        }

        [Fact]
        public void DefaultStreamWriteWord()
        {
            using (var file = OpenFile(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, FileAccess.Write))
            using (var stream = file.Open())
            {
                Assert.ThrowsAny<OpenXmlPackageException>(() =>
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                    }
                });
            }
        }

        [Fact]
        public void DefaultStreamWriteExcel()
        {
            using (var file = OpenFile(TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, FileAccess.Write))
            using (var stream = file.Open())
            {
                Assert.ThrowsAny<OpenXmlPackageException>(() =>
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                    }
                });
            }
        }

        [Fact]
        public void DefaultStreamWritePowerpoint()
        {
            using (var file = OpenFile(TestDataStorage.V2FxTestFiles.Bvt.O12Typical, FileAccess.Write))
            using (var stream = file.Open())
            {
                Assert.ThrowsAny<OpenXmlPackageException>(() =>
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                    }
                });
            }
        }

        [Theory]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, false)]
        public void DefaultWithFilePathWord(string testfile, bool isEditable)
        {
            using (var file = OpenFile(testfile, FileAccess.ReadWrite))
            using (var package = WordprocessingDocument.Open(file.Path, isEditable))
            {
                Assert.NotNull(package);
            }
        }

        [Theory]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, true)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, false)]
        public void DefaultWithFilePathExcel(string testfile, bool isEditable)
        {
            using (var file = OpenFile(testfile, FileAccess.ReadWrite))
            using (var package = SpreadsheetDocument.Open(file.Path, isEditable))
            {
                Assert.NotNull(package);
            }
        }

        [Theory]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.O12Typical, true)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.O12Typical, false)]
        public void DefaultWithFilePathPresentation(string testfile, bool isEditable)
        {
            using (var file = OpenFile(testfile, FileAccess.ReadWrite))
            using (var package = PresentationDocument.Open(file.Path, isEditable))
            {
                Assert.NotNull(package);
            }
        }

        [Theory]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, FileAccess.Read)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, FileAccess.ReadWrite)]
        public void OpenPackageWord(string testfile, FileAccess access)
        {
            using (var file = OpenFile(testfile, access))
            {
                using (var p = Package.Open(file.Path, FileMode.Open, access))
                using (var package = WordprocessingDocument.Open(p))
                {
                    Assert.NotNull(package);
                }
            }
        }

        [Theory]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, FileAccess.Read)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, FileAccess.ReadWrite)]
        public void OpenPackageExcel(string testfile, FileAccess access)
        {
            using (var file = OpenFile(testfile, access))
            {
                using (var p = Package.Open(file.Path, FileMode.Open, access))
                using (var package = SpreadsheetDocument.Open(p))
                {
                    Assert.NotNull(package);
                }
            }
        }

        [Theory]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.O12Typical, FileAccess.Read)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.O12Typical, FileAccess.ReadWrite)]
        public void OpenPackagePresentation(string testfile, FileAccess access)
        {
            using (var file = OpenFile(testfile, access))
            {
                using (var p = Package.Open(file.Path, FileMode.Open, access))
                using (var package = PresentationDocument.Open(p))
                {
                    Assert.NotNull(package);
                }
            }
        }

        [Theory]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.O12Typical, true, true)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.O12Typical, false, true)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.O12Typical, true, false)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.O12Typical, false, false)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true, true)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, false, true)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true, false)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, false, false)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, true, true)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, false, true)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, true, false)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, false, false)]
        public void AutoSaveStream(string testfile, bool edit, bool autosave)
        {
            using (var stream = OpenFile(testfile, true))
            {
                string expected;

                using (var package = stream.Open(edit, new OpenSettings() { AutoSave = autosave }))
                {
                    expected = package.MainPart().RootElement.FirstChild?.InnerText;
                    package.MainPart().RootElement.FirstChild.Remove();

                    if (autosave && edit)
                    {
                        expected = package.MainPart().RootElement.FirstChild?.InnerText;
                    }
                }

                using (var package = stream.Open(false, new OpenSettings() { AutoSave = false }))
                {
                    var actual = package.MainPart().RootElement.FirstChild?.InnerText;

                    Assert.Equal(expected, actual);
                }
            }
        }

        [Theory]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.O12Typical, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.O12Typical, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts)]
        [InlineData(TestDataStorage.V2FxTestFiles.Bvt.O12Typical, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess)]
        public void OpenMcPackage(string testfile, FileFormatVersions format, MarkupCompatibilityProcessMode mcMode)
        {
            using (var file = OpenFile(testfile, true))
            {
                var settings = new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(mcMode, format) };

                using (var package = file.Open(true, settings))
                {
                    Assert.NotNull(package);
                }
            }
        }

        [Fact]
        public void PartsShouldBeEncodedWithUTF8WithoutBOM()
        {
            using (var ms = new MemoryStream())
            {
                using (var package = SpreadsheetDocument.Create(ms, SpreadsheetDocumentType.Workbook))
                {
                    var wb = package.AddWorkbookPart();

                    wb.Workbook = new Workbook();
                }

                using (var package = Package.Open(ms))
                {
                    var part = package.GetPart(new Uri("/xl/workbook.xml", UriKind.Relative));

                    using (var stream = part.GetStream())
                    using (var msPart = new MemoryStream())
                    {
                        stream.CopyTo(msPart);
                        var bytes = msPart.ToArray();

                        Assert.NotEmpty(bytes);

                        var preamble = Encoding.UTF8.GetPreamble();

                        Assert.Empty(preamble.Where((b, i) => b == bytes[i]));
                    }
                }
            }
        }
    }
}
