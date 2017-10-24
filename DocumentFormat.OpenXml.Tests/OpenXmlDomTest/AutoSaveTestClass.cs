// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using DocumentFormat.OpenXml.Packaging;
using System.IO;
using System.IO.Packaging;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class AutoSaveTestClass
    {
        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.O12Typical)]
        public void DefaultStreamReadOnly(string testfile)
        {
            using (var file = TestAssets.AsFile(testfile, FileAccess.Read))
            {
                Assert.Throws<IOException>(() =>
                {
                    using (var package = file.Open(true))
                    {
                    }
                });
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, false)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, true)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, false)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.O12Typical, true)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.O12Typical, false)]
        public void DefaultStreamReadWriteAutosave(string testfile, bool autosave)
        {
            using (var stream = TestAssets.Open(testfile, FileAccess.ReadWrite))
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
            using (var file = TestAssets.Open(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, FileAccess.Write))
            using (var stream = file.Open())
            {
                Assert.Throws<IOException>(() =>
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
            using (var file = TestAssets.AsFile(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, FileAccess.Write))
            using (var stream = file.Open())
            {
                Assert.Throws<IOException>(() =>
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
            using (var file = TestAssets.Open(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.O12Typical, FileAccess.Write))
            using (var stream = file.Open())
            {
                Assert.Throws<IOException>(() =>
                {
                    using (var package = WordprocessingDocument.Open(stream, true))
                    {
                    }
                });
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, false)]
        public void DefaultWithFilePathWord(string testfile, bool isEditable)
        {
            using (var file = TestAssets.AsFile(testfile))
            using (var package = WordprocessingDocument.Open(file.Path, isEditable))
            {
                Assert.NotNull(package);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, true)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, false)]
        public void DefaultWithFilePathExcel(string testfile, bool isEditable)
        {
            using (var file = TestAssets.AsFile(testfile))
            using (var package = SpreadsheetDocument.Open(file.Path, isEditable))
            {
                Assert.NotNull(package);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.O12Typical, true)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.O12Typical, false)]
        public void DefaultWithFilePathPresentation(string testfile, bool isEditable)
        {
            using (var file = TestAssets.AsFile(testfile))
            using (var package = PresentationDocument.Open(file.Path, isEditable))
            {
                Assert.NotNull(package);
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, FileAccess.Read)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, FileAccess.ReadWrite)]
        public void OpenPackageWord(string testfile, FileAccess access)
        {
            using (var file = TestAssets.AsFile(testfile, access))
            {
                using (var p = Package.Open(file.Path, FileMode.Open, access))
                using (var package = WordprocessingDocument.Open(p))
                {
                    Assert.NotNull(package);
                }
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, FileAccess.Read)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, FileAccess.ReadWrite)]
        public void OpenPackageExcel(string testfile, FileAccess access)
        {
            using (var file = TestAssets.AsFile(testfile, access))
            {
                using (var p = Package.Open(file.Path, FileMode.Open, access))
                using (var package = SpreadsheetDocument.Open(p))
                {
                    Assert.NotNull(package);
                }
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.O12Typical, FileAccess.Read)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.O12Typical, FileAccess.ReadWrite)]
        public void OpenPackagePresentation(string testfile, FileAccess access)
        {
            using (var file = TestAssets.AsFile(testfile, access))
            {
                using (var p = Package.Open(file.Path, FileMode.Open, access))
                using (var package = PresentationDocument.Open(p))
                {
                    Assert.NotNull(package);
                }
            }
        }

        [Theory]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.O12Typical, true, true)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.O12Typical, false, true)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.O12Typical, true, false)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.O12Typical, false, false)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true, true)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, false, true)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, true, false)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, false, false)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, true, true)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, false, true)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, true, false)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, false, false)]
        public void AutoSaveStream(string testfile, bool edit, bool autosave)
        {
            using (var stream = TestAssets.Open(testfile, FileAccess.ReadWrite))
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
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.PerformanceEng, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.O12Typical, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.O12Typical, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts)]
        [InlineData(TestAssets.TestDataStorage.V2FxTestFiles.Bvt.O12Typical, FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess)]
        public void OpenMcPackage(string testfile, FileFormatVersions format, MarkupCompatibilityProcessMode mcMode)
        {
            using (var file = TestAssets.Open(testfile, FileAccess.ReadWrite))
            {
                var settings = new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(mcMode, format) };

                using (var package = file.Open(true, settings))
                {
                    Assert.NotNull(package);
                }
            }
        }
    }
}
