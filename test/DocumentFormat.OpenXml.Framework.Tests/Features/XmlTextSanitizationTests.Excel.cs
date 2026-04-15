// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.IO;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Features.Tests;

public partial class XmlTextSanitizationTests
{
    [Fact]
    public void SpreadsheetDocument_WithoutSanitization_ControlCharThrows()
    {
        using var stream = new MemoryStream();

        Assert.Throws<ArgumentException>(() =>
        {
            using var document = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook);

            var workbookPart = document.AddWorkbookPart();
            workbookPart.Workbook = new Workbook();

            var worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
            var sheetData = new SheetData(
                new Row(
                    new Cell
                    {
                        DataType = CellValues.InlineString,
                        InlineString = new InlineString(new Text("bad\u0002data")),
                    }));
            worksheetPart.Worksheet = new Worksheet(sheetData);

            var sheets = workbookPart.Workbook.AppendChild(new Sheets());
            sheets.Append(new Sheet
            {
                Id = workbookPart.GetIdOfPart(worksheetPart),
                SheetId = 1U,
                Name = "Sheet1",
            });

            workbookPart.Workbook.Save();
        });
    }

    [Fact]
    public void SpreadsheetDocument_WithSanitization_CellValueCleaned()
    {
        using var stream = new MemoryStream();

        using (var document = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook))
        {
            document.UseXmlTextSanitization();

            var workbookPart = document.AddWorkbookPart();
            workbookPart.Workbook = new Workbook();

            var worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
            var sheetData = new SheetData(
                new Row(
                    new Cell
                    {
                        DataType = CellValues.InlineString,
                        InlineString = new InlineString(new Text("bad\u0002data")),
                    }));
            worksheetPart.Worksheet = new Worksheet(sheetData);

            var sheets = workbookPart.Workbook.AppendChild(new Sheets());
            sheets.Append(new Sheet
            {
                Id = workbookPart.GetIdOfPart(worksheetPart),
                SheetId = 1U,
                Name = "Sheet1",
            });

            workbookPart.Workbook.Save();
        }

        stream.Position = 0;

        using var reopened = SpreadsheetDocument.Open(stream, false);
        var cellText = reopened.WorkbookPart!
            .WorksheetParts.Single()
            .Worksheet!.Descendants<Text>()
            .Single()
            .Text;

        Assert.Equal("baddata", cellText);
    }
}
