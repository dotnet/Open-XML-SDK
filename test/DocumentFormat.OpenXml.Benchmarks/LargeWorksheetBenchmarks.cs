// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.IO;
using System.Linq;

namespace DocumentFormat.OpenXml.Benchmarks;

/// <summary>
/// Reproduces https://github.com/dotnet/Open-XML-SDK/issues/1511: adding a data validation to a large
/// worksheet via the DOM requires the full worksheet to be materialized.
/// </summary>
public class LargeWorksheetBenchmarks
{
    private const int Columns = 10;

    private byte[] _package = null!;

    [Params(5_000, 20_000, 50_000)]
    public int Rows { get; set; }

    [GlobalSetup]
    public void Setup() => _package = CreatePackage(Rows);

    /// <summary>
    /// The flow from the issue: open, find existing data validations, append one, save.
    /// </summary>
    [Benchmark(Baseline = true)]
    public long ReporterFlow()
    {
        using var stream = CreateEditableStream();

        using (var document = SpreadsheetDocument.Open(stream, true))
        {
            var worksheetPart = GetWorksheetPart(document);
            var worksheet = worksheetPart.Worksheet;
            var existing = worksheet.GetFirstChild<DataValidations>();

            if (existing is null)
            {
                worksheet.AppendChild(new DataValidations(CreateDataValidation()));
            }
            else
            {
                existing.Append(CreateDataValidation());
            }

            worksheet.Save();
        }

        return stream.Length;
    }

    /// <summary>
    /// Only materializes the worksheet DOM, to isolate the load cost from the rest of the flow.
    /// </summary>
    [Benchmark]
    public object LoadWorksheet()
    {
        using var stream = new MemoryStream(_package, writable: false);
        using var document = SpreadsheetDocument.Open(stream, false);

        return GetWorksheetPart(document).Worksheet;
    }

    /// <summary>
    /// Loads the worksheet and reads every typed attribute value, the worst case for deferring their creation.
    /// </summary>
    [Benchmark]
    public int ReadAllAttributes()
    {
        using var stream = new MemoryStream(_package, writable: false);
        using var document = SpreadsheetDocument.Open(stream, false);

        var count = 0;

        foreach (var row in GetWorksheetPart(document).Worksheet.Descendants<Row>())
        {
            if (row.RowIndex is not null)
            {
                count += (int)row.RowIndex.Value;
            }

            foreach (var cell in row.Elements<Cell>())
            {
                if (cell.CellReference?.Value is not null)
                {
                    count++;
                }

                if (cell.DataType is not null && cell.DataType.Value == CellValues.SharedString)
                {
                    count++;
                }
            }
        }

        return count;
    }

    /// <summary>
    /// Loads the worksheet and saves it without reading any typed attribute value.
    /// </summary>
    [Benchmark]
    public long RoundTrip()
    {
        using var stream = CreateEditableStream();

        using (var document = SpreadsheetDocument.Open(stream, true))
        {
            var worksheetPart = GetWorksheetPart(document);
            worksheetPart.Worksheet.Save();
        }

        return stream.Length;
    }

    /// <summary>
    /// Streams the worksheet into a new part, inserting the data validation, without building a DOM.
    /// </summary>
    [Benchmark]
    public long SaxFlow()
    {
        using var stream = CreateEditableStream();

        using (var document = SpreadsheetDocument.Open(stream, true))
        {
            var workbookPart = document.WorkbookPart!;
            var sheet = workbookPart.Workbook.Descendants<Sheet>().First();
            var oldPart = (WorksheetPart)workbookPart.GetPartById(sheet.Id!);
            var newPart = workbookPart.AddNewPart<WorksheetPart>();

            using (var reader = OpenXmlReader.Create(oldPart))
            using (var writer = OpenXmlWriter.Create(newPart))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement)
                    {
                        writer.WriteStartElement(reader);

                        var text = reader.GetText();

                        if (text.Length > 0)
                        {
                            writer.WriteString(text);
                        }
                    }
                    else if (reader.IsEndElement)
                    {
                        writer.WriteEndElement();

                        if (reader.ElementType == typeof(SheetData))
                        {
                            writer.WriteElement(new DataValidations(CreateDataValidation()));
                        }
                    }
                }
            }

            sheet.Id = workbookPart.GetIdOfPart(newPart);
            workbookPart.DeletePart(oldPart);
        }

        return stream.Length;
    }

    internal static byte[] CreatePackage(int rows)
    {
        using var stream = new MemoryStream();

        using (var document = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook))
        {
            var workbookPart = document.AddWorkbookPart();
            var worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
            var sharedStrings = workbookPart.AddNewPart<SharedStringTablePart>();

            const int UniqueStrings = 1_000;

            using (var writer = OpenXmlWriter.Create(sharedStrings))
            {
                writer.WriteStartElement(new SharedStringTable());

                for (var i = 0; i < UniqueStrings; i++)
                {
                    writer.WriteElement(new SharedStringItem(new Text($"Value {i}")));
                }

                writer.WriteEndElement();
            }

            using (var writer = OpenXmlWriter.Create(worksheetPart))
            {
                writer.WriteStartElement(new Worksheet());
                writer.WriteStartElement(new SheetData());

                for (var r = 1; r <= rows; r++)
                {
                    writer.WriteStartElement(new Row { RowIndex = (uint)r });

                    for (var c = 0; c < Columns; c++)
                    {
                        var reference = $"{(char)('A' + c)}{r}";

                        // Alternate numeric and shared string cells.
                        var cell = c % 2 == 0
                            ? new Cell(new CellValue((r * c) + 0.5)) { CellReference = reference }
                            : new Cell(new CellValue((r * c) % UniqueStrings)) { CellReference = reference, DataType = CellValues.SharedString };

                        writer.WriteElement(cell);
                    }

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndElement();
            }

            workbookPart.Workbook = new Workbook(
                new Sheets(
                    new Sheet { Name = "Sheet1", SheetId = 1, Id = workbookPart.GetIdOfPart(worksheetPart) }));
        }

        return stream.ToArray();
    }

    internal static WorksheetPart GetWorksheetPart(SpreadsheetDocument document)
    {
        var workbookPart = document.WorkbookPart!;
        var sheet = workbookPart.Workbook.Descendants<Sheet>().First(s => s.Name == "Sheet1");

        return (WorksheetPart)workbookPart.GetPartById(sheet.Id!);
    }

    private static DataValidation CreateDataValidation()
        => new(new Formula1("Lists!$A$1:$A$10"))
        {
            Type = DataValidationValues.List,
            AllowBlank = true,
            SequenceOfReferences = new ListValue<StringValue> { InnerText = "B1:B1048576" },
        };

    private MemoryStream CreateEditableStream()
    {
        var stream = new MemoryStream();
        stream.Write(_package, 0, _package.Length);
        stream.Position = 0;
        return stream;
    }
}
