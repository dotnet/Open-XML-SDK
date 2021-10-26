// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    public abstract partial class DocumentTests<T>
        where T : OpenXmlPackage
    {
        [InlineData(true)]
        [InlineData(false)]
        [Theory]
        public void CreateWithAutoSaveTest(bool autosave)
        {
            using (var file = GetStream(Path, false))
            using (var sourcePackage = Open(file, false))
            {
                using (var ms = new MemoryStream())
                {
                    using (var createdPackage = Create(ms, autosave))
                    {
                        DuplicateMainPart(sourcePackage, createdPackage);
                        Assert.NotNull(createdPackage.MainPart().RootElement);
                    }

                    using (var createdPackage = Open(ms, false))
                    {
                        if (autosave)
                        {
                            Assert.NotNull(createdPackage.MainPart().RootElement);
                        }
                        else
                        {
                            Assert.Null(createdPackage.MainPart().RootElement);
                        }
                    }
                }
            }
        }

        [Theory]
        [InlineData(true)]
        public void DefaultStreamReadWriteAutosave(bool autosave)
        {
            using (var stream = OpenFile(Path, true))
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
        public void CreateWithNoAutoSaveTest()
        {
            using (var file = GetStream(Path, false))
            using (var sourcePackage = Open(file, false))
            {
                using (var ms = new MemoryStream())
                {
                    using (var createdPackage = Create(ms))
                    {
                        DuplicateMainPart(sourcePackage, createdPackage);
                        Assert.NotNull(createdPackage.MainPart().RootElement);
                    }

                    using (var createdPackage = Open(ms, false))
                    {
                        Assert.NotNull(createdPackage.MainPart().RootElement);
                    }
                }
            }
        }

        [Fact]
        public void DefaultStreamReadOnly()
        {
            using (var file = OpenFile(Path, FileAccess.Read))
            {
                Assert.Throws<OpenXmlPackageException>(() =>
                {
                    using (var stream = file.Open())
                    {
                        Assert.False(stream.CanWrite);

                        using (var package = Open(stream, true))
                        {
                        }
                    }
                });
            }
        }

        [Fact]
        public void DefaultStreamWrite()
        {
            using (var file = OpenFile(Path, FileAccess.Write))
            using (var stream = file.Open())
            {
                Assert.ThrowsAny<OpenXmlPackageException>(() =>
                {
                    using (var package = Open(stream, true))
                    {
                    }
                });
            }
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DefaultWithFilePath(bool isEditable)
        {
            using (var file = OpenFile(Path, FileAccess.ReadWrite))
            using (var package = Open(file.Path, isEditable))
            {
                Assert.NotNull(package);
            }
        }

        [Theory]
        [InlineData(FileAccess.Read)]
        [InlineData(FileAccess.ReadWrite)]
        public void OpenPackageWord(FileAccess access)
        {
            using (var file = OpenFile(Path, access))
            {
                using (var p = Package.Open(file.Path, FileMode.Open, access))
                using (var package = Open(p))
                {
                    Assert.NotNull(package);
                }
            }
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(false, true)]
        [InlineData(true, false)]
        [InlineData(false, false)]
        public void AutoSaveStream(bool edit, bool autosave)
        {
            using (var stream = OpenFile(Path, true))
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
        [InlineData(FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly)]
        [InlineData(FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.ProcessAllParts)]
        [InlineData(FileFormatVersions.Office2007, MarkupCompatibilityProcessMode.NoProcess)]
        public void OpenMcPackage(FileFormatVersions format, MarkupCompatibilityProcessMode mcMode)
        {
            using (var file = OpenFile(Path, true))
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
                using (var package = Create(ms))
                {
                    AddMainPart(package);
                }

                using (var package = Open(ms, false))
                {
                    var part = package.MainPart();

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
