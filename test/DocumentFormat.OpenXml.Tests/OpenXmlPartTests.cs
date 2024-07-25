// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.IO;
using System.Text;
using Xunit;

namespace DocumentFormat.OpenXml.Packaging.Tests;

public class OpenXmlPartTests
{
    [InlineData(FileAccess.Write)]
    [InlineData(FileAccess.ReadWrite)]
    [Theory]
    public void GetStreamWrite(FileAccess access)
    {
        // Arrange
        const string expected = """<x:sst xmlns:x="http://schemas.openxmlformats.org/spreadsheetml/2006/main"><x:si><x:t>Test</x:t></x:si></x:sst>""";
        var stream = new MemoryStream();
        {
            using var package = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook);
            var wb = package.AddWorkbookPart();

            var part = wb.AddNewPart<SharedStringTablePart>();

            part.SharedStringTable = new SharedStringTable();

            using var partStream = part.GetStream(FileMode.Create, access);

            var bytes = Encoding.UTF8.GetBytes(expected);
            partStream.Write(bytes, 0, bytes.Length);
        }

        // Reopen package
        stream.Position = 0;
        using var spreadsheet = SpreadsheetDocument.Open(stream, isEditable: false);

        // Assert
        Assert.Equal(expected, spreadsheet.WorkbookPart.SharedStringTablePart.RootElement.OuterXml);
    }

    [InlineData(FileAccess.Write)]
    [InlineData(FileAccess.ReadWrite)]
    [Theory]
    public void GetStreamWriteNoUpdates(FileAccess access)
    {
        // Arrange
        const string expected = """<x:sst xmlns:x="http://schemas.openxmlformats.org/spreadsheetml/2006/main" />""";
        var stream = new MemoryStream();
        {
            using var package = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook);
            var wb = package.AddWorkbookPart();

            var part = wb.AddNewPart<SharedStringTablePart>();

            part.SharedStringTable = new SharedStringTable();

            package.Save();

            using var partStream = part.GetStream(FileMode.Open, access);
        }

        // Reopen package
        stream.Position = 0;
        using var spreadsheet = SpreadsheetDocument.Open(stream, isEditable: false);

        // Assert
        Assert.Equal(expected, spreadsheet.WorkbookPart.SharedStringTablePart.RootElement.OuterXml);
    }
}
