// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.IO;
using System.IO.Packaging;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    public class FlatOpcTests
    {
        [Fact]
        public void CanCreateFlatOpcPresentationDocuments()
        {
            using (var inputStream = GetStream(TestFiles.Presentation))
            using (var source = PresentationDocument.Open(inputStream, false))
            {
                var flatOpcDoc = source.ToFlatOpcDocument();
                using (var dest = PresentationDocument.FromFlatOpcDocument(flatOpcDoc))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcPresentationDocuments2()
        {
            using (var inputStream = GetStream(TestFiles.Presentation))
            using (var source = PresentationDocument.Open(inputStream, false))
            using (Stream stream = new MemoryStream())
            {
                var flatOpcDoc = source.ToFlatOpcDocument();

                using (PresentationDocument.FromFlatOpcDocument(flatOpcDoc, stream, false))
                using (var dest = PresentationDocument.Open(stream, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcPresentationDocuments3()
        {
            using (var inputStream = GetStream(TestFiles.Presentation))
            using (var source = PresentationDocument.Open(inputStream, false))
            {
                var flatOpcDoc = source.ToFlatOpcDocument();

                using (var tempFile = TemporaryFile.Create())
                using (PresentationDocument.FromFlatOpcDocument(flatOpcDoc, tempFile.Path, false))
                using (var dest = PresentationDocument.Open(tempFile.Path, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcPresentationDocuments4()
        {
            using (var inputStream = GetStream(TestFiles.Presentation))
            using (var source = PresentationDocument.Open(inputStream, false))
            {
                using (var stream = new MemoryStream())
                using (var package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
                {
                    var flatOpcDoc = source.ToFlatOpcDocument();

                    using (var dest = PresentationDocument.FromFlatOpcDocument(flatOpcDoc, package))
                    {
                        PackageAssert.Equal(source, dest);
                    }
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcPresentationDocuments5()
        {
            using (var inputStream = GetStream(TestFiles.Presentation))
            using (var source = PresentationDocument.Open(inputStream, false))
            {
                var flatOpcString = source.ToFlatOpcString();

                using (var dest = PresentationDocument.FromFlatOpcString(flatOpcString))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcPresentationDocuments6()
        {
            using (var inputStream = GetStream(TestFiles.Presentation))
            using (var source = PresentationDocument.Open(inputStream, false))
            {
                var flatOpcString = source.ToFlatOpcString();

                using (Stream stream = new MemoryStream())
                using (PresentationDocument.FromFlatOpcString(flatOpcString, stream, false))
                using (var dest = PresentationDocument.Open(stream, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcPresentationDocuments7()
        {
            using (var inputStream = GetStream(TestFiles.Presentation))
            using (var source = PresentationDocument.Open(inputStream, false))
            {
                var flatOpcString = source.ToFlatOpcString();

                using (var tempFile = TemporaryFile.Create())
                using (PresentationDocument.FromFlatOpcString(flatOpcString, tempFile.Path, false))
                using (var dest = PresentationDocument.Open(tempFile.Path, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcPresentationDocuments8()
        {
            using (var inputStream = GetStream(TestFiles.Presentation))
            using (var source = PresentationDocument.Open(inputStream, false))
            {
                var flatOpcString = source.ToFlatOpcString();

                using (var stream = new MemoryStream())
                using (var package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
                using (var dest = PresentationDocument.FromFlatOpcString(flatOpcString, package))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcSpreadsheetDocuments1()
        {
            using (var inputStream = GetStream(TestFiles.Spreadsheet))
            using (var source = SpreadsheetDocument.Open(inputStream, false))
            {
                var flatOpcDoc = source.ToFlatOpcDocument();

                using (var dest = SpreadsheetDocument.FromFlatOpcDocument(flatOpcDoc))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcSpreadsheetDocuments2()
        {
            using (var inputStream = GetStream(TestFiles.Spreadsheet))
            using (var source = SpreadsheetDocument.Open(inputStream, false))
            using (Stream stream = new MemoryStream())
            {
                var flatOpcDoc = source.ToFlatOpcDocument();

                using (SpreadsheetDocument.FromFlatOpcDocument(flatOpcDoc, stream, false))
                using (var dest = SpreadsheetDocument.Open(stream, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcSpreadsheetDocuments3()
        {
            using (var inputStream = GetStream(TestFiles.Spreadsheet))
            using (var source = SpreadsheetDocument.Open(inputStream, false))
            {
                var flatOpcDoc = source.ToFlatOpcDocument();

                using (var tempFile = TemporaryFile.Create())
                using (SpreadsheetDocument.FromFlatOpcDocument(flatOpcDoc, tempFile.Path, false))
                using (var dest = SpreadsheetDocument.Open(tempFile.Path, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcSpreadsheetDocuments4()
        {
            using (var inputStream = GetStream(TestFiles.Spreadsheet))
            using (var source = SpreadsheetDocument.Open(inputStream, false))
            using (var stream = new MemoryStream())
            using (var package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
            {
                var flatOpcDoc = source.ToFlatOpcDocument();

                using (var dest = SpreadsheetDocument.FromFlatOpcDocument(flatOpcDoc, package))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcSpreadsheetDocuments5()
        {
            using (var inputStream = GetStream(TestFiles.Spreadsheet))
            using (var source = SpreadsheetDocument.Open(inputStream, false))
            {
                var flatOpcString = source.ToFlatOpcString();

                using (var dest = SpreadsheetDocument.FromFlatOpcString(flatOpcString))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcSpreadsheetDocuments6()
        {
            using (var inputStream = GetStream(TestFiles.Spreadsheet))
            using (var source = SpreadsheetDocument.Open(inputStream, false))
            using (Stream stream = new MemoryStream())
            {
                var flatOpcString = source.ToFlatOpcString();

                using (SpreadsheetDocument.FromFlatOpcString(flatOpcString, stream, false))
                using (var dest = SpreadsheetDocument.Open(stream, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcSpreadsheetDocuments7()
        {
            using (var inputStream = GetStream(TestFiles.Spreadsheet))
            using (var source = SpreadsheetDocument.Open(inputStream, false))
            {
                var flatOpcString = source.ToFlatOpcString();

                using (var tempFile = TemporaryFile.Create())
                using (SpreadsheetDocument.FromFlatOpcString(flatOpcString, tempFile.Path, false))
                using (var dest = SpreadsheetDocument.Open(tempFile.Path, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcSpreadsheetDocuments8()
        {
            using (var inputStream = GetStream(TestFiles.Spreadsheet))
            using (var source = SpreadsheetDocument.Open(inputStream, false))
            using (var stream = new MemoryStream())
            using (var package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
            {
                var flatOpcString = source.ToFlatOpcString();

                using (var dest = SpreadsheetDocument.FromFlatOpcString(flatOpcString, package))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcWordprocessingDocuments1()
        {
            using (var inputStream = GetStream(TestFiles.Document))
            using (var source = WordprocessingDocument.Open(inputStream, false))
            {
                var flatOpcDoc = source.ToFlatOpcDocument();

                using (var dest = WordprocessingDocument.FromFlatOpcDocument(flatOpcDoc))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcWordprocessingDocuments2()
        {
            using (var inputStream = GetStream(TestFiles.Document))
            using (var source = WordprocessingDocument.Open(inputStream, false))
            {
                var flatOpcDoc = source.ToFlatOpcDocument();

                using (Stream stream = new MemoryStream())
                using (WordprocessingDocument.FromFlatOpcDocument(flatOpcDoc, stream, false))
                using (var dest = WordprocessingDocument.Open(stream, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcWordprocessingDocuments3()
        {
            using (var inputStream = GetStream(TestFiles.Document))
            using (var source = WordprocessingDocument.Open(inputStream, false))
            {
                var flatOpcDoc = source.ToFlatOpcDocument();

                using (var tempFile = TemporaryFile.Create())
                using (WordprocessingDocument.FromFlatOpcDocument(flatOpcDoc, tempFile.Path, false))
                using (var dest = WordprocessingDocument.Open(tempFile.Path, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcWordprocessingDocuments4()
        {
            using (var inputStream = GetStream(TestFiles.Document))
            using (var source = WordprocessingDocument.Open(inputStream, false))
            {
                var flatOpcDoc = source.ToFlatOpcDocument();

                using (var stream = new MemoryStream())
                using (var package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
                using (var dest = WordprocessingDocument.FromFlatOpcDocument(flatOpcDoc, package))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcWordprocessingDocuments5()
        {
            using (var inputStream = GetStream(TestFiles.Document))
            using (var source = WordprocessingDocument.Open(inputStream, false))
            {
                var flatOpcString = source.ToFlatOpcString();

                using (var dest = WordprocessingDocument.FromFlatOpcString(flatOpcString))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcWordprocessingDocuments6()
        {
            using (var inputStream = GetStream(TestFiles.Document))
            using (var source = WordprocessingDocument.Open(inputStream, false))
            {
                var flatOpcString = source.ToFlatOpcString();

                using (Stream stream = new MemoryStream())
                using (WordprocessingDocument.FromFlatOpcString(flatOpcString, stream, false))
                using (var dest = WordprocessingDocument.Open(stream, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcWordprocessingDocuments7()
        {
            using (var inputStream = GetStream(TestFiles.Document))
            using (var source = WordprocessingDocument.Open(inputStream, false))
            {
                var flatOpcString = source.ToFlatOpcString();

                using (var tempFile = TemporaryFile.Create())
                using (WordprocessingDocument.FromFlatOpcString(flatOpcString, tempFile.Path, false))
                using (var dest = WordprocessingDocument.Open(tempFile.Path, false))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }

        [Fact]
        public void CanCreateFlatOpcWordprocessingDocuments8()
        {
            using (var inputStream = GetStream(TestFiles.Document))
            using (var source = WordprocessingDocument.Open(inputStream, false))
            {
                var flatOpcString = source.ToFlatOpcString();

                using (var stream = new MemoryStream())
                using (var package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
                using (var dest = WordprocessingDocument.FromFlatOpcString(flatOpcString, package))
                {
                    PackageAssert.Equal(source, dest);
                }
            }
        }
    }
}
