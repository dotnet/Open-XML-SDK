// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    public class DocumentOpenTests
    {
        [Fact]
        public void UriExceptionIsWrapped()
        {
            using (var stream = GetStream(TestFiles.malformed_uri_xlsx))
            {
                var exception = Assert.Throws<OpenXmlPackageException>(() => SpreadsheetDocument.Open(stream, false));

                Assert.IsType<UriFormatException>(exception.InnerException);
            }
        }

        [Fact]
        public void ThrowIfFileCannotBeFound()
        {
            const string NonExistantFile = "Unknown";

            Assert.False(File.Exists(NonExistantFile));

            Assert.Throws<FileNotFoundException>(() => SpreadsheetDocument.Open(NonExistantFile, true));
            Assert.Throws<FileNotFoundException>(() => SpreadsheetDocument.Open(NonExistantFile, false));
            Assert.Throws<FileNotFoundException>(() => SpreadsheetDocument.Open(NonExistantFile, true, new OpenSettings()));
            Assert.Throws<FileNotFoundException>(() => SpreadsheetDocument.Open(NonExistantFile, false, new OpenSettings()));

            Assert.Throws<FileNotFoundException>(() => WordprocessingDocument.Open(NonExistantFile, true));
            Assert.Throws<FileNotFoundException>(() => WordprocessingDocument.Open(NonExistantFile, false));
            Assert.Throws<FileNotFoundException>(() => WordprocessingDocument.Open(NonExistantFile, true, new OpenSettings()));
            Assert.Throws<FileNotFoundException>(() => WordprocessingDocument.Open(NonExistantFile, false, new OpenSettings()));

            Assert.Throws<FileNotFoundException>(() => PresentationDocument.Open(NonExistantFile, true));
            Assert.Throws<FileNotFoundException>(() => PresentationDocument.Open(NonExistantFile, false));
            Assert.Throws<FileNotFoundException>(() => PresentationDocument.Open(NonExistantFile, true, new OpenSettings()));
            Assert.Throws<FileNotFoundException>(() => PresentationDocument.Open(NonExistantFile, false, new OpenSettings()));
        }
    }
}
