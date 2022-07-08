// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
#nullable enable
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Common
{
    public class ExampleUtilities
    {
        public static void ShowHelp(string[] helpMessages)
        {
            foreach (string message in helpMessages)
            {
                Console.WriteLine(message);
            }
        }

        public static bool CheckIfFilesExist(string[] files)
        {
            bool exist = true;

            foreach (string file in files)
            {
                if (!File.Exists(file))
                {
                    Console.Error.WriteLine($"file not found: {file}");
                    exist = false;
                }
            }

            return exist;
        }

        public static SpreadsheetDocument? CreateSpreadsheetWorkbook(string filepath, string sheetName)
        {
            // Create a spreadsheet document by supplying the filepath.
            // By default, AutoSave = true, Editable = true, and Type = xlsx.
            SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.
                Create(filepath, SpreadsheetDocumentType.Workbook);

            // Add a WorkbookPart to the document.
            WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();
            workbookpart.Workbook = new Workbook();

            // Add a WorksheetPart to the WorkbookPart.
            WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());

            // Add Sheets to the Workbook.
            Sheets? sheets = spreadsheetDocument?.WorkbookPart?.Workbook.AppendChild<Sheets>(new Sheets());

            // Append a new worksheet and associate it with the workbook.
            Sheet sheet = new()
            {
                Id = spreadsheetDocument?.WorkbookPart?.GetIdOfPart(worksheetPart),
                SheetId = 1,
                Name = sheetName,
            };
            sheets?.Append(sheet);

            workbookpart.Workbook.Save();

            return spreadsheetDocument;
        }

        public static bool FileCheck(string filepath)
        {
            if (!File.Exists(filepath))
            {
                Console.WriteLine(string.Concat("File ", filepath, " does not exist."));
                return false;
            }

            Console.WriteLine(string.Concat("File ", filepath, " exists."));
            return true;
        }

        public static void InsertText(SpreadsheetDocument sd, string sheetName, string text, string column, uint row)
        {
            // Get the SharedStringTablePart. If it does not exist, create a new one.
            SharedStringTablePart? shareStringPart = null;

            if (sd.WorkbookPart?.GetPartsOfType<SharedStringTablePart>().Count() > 0)
            {
                shareStringPart = sd.WorkbookPart.GetPartsOfType<SharedStringTablePart>().First();
            }
            else if (sd.WorkbookPart != null)
            {
                shareStringPart = sd.WorkbookPart.AddNewPart<SharedStringTablePart>();
            }

            // Insert the text into the SharedStringTablePart.
            int index = InsertSharedStringItem(text, shareStringPart);

            // Insert a new worksheet.
            // WorksheetPart worksheetPart = InsertWorksheet(spreadSheet.WorkbookPart);
            Sheets? allSheets = sd.WorkbookPart?.Workbook?.GetFirstChild<Sheets>();

            if (allSheets != null)
            {
                IEnumerable<Sheet> sheets = allSheets.Elements<Sheet>().Where(s => s.Name == sheetName);
                if (sheets.Count() == 0)
                {
                    // The specified worksheet does not exist.
                    return;
                }

                string? relationshipId = sheets.First().Id?.Value;

                if (relationshipId != null)
                {
                    WorksheetPart? worksheetPart = (WorksheetPart?)sd.WorkbookPart?.GetPartById(relationshipId);

                    if (worksheetPart != null)
                    {
                        // Insert cell A1 into the new worksheet.
                        Cell cell = InsertCellInWorksheet(column, row, worksheetPart);

                        // Set the value of cell A1.
                        cell.CellValue = new CellValue(index.ToString());
                        cell.DataType = new EnumValue<CellValues>(CellValues.SharedString);

                        // Save the new worksheet.
                        worksheetPart.Worksheet.Save();
                    }
                }
            }
            else
            {
                return;
            }
        }

        //// Get the sheet by name
        public static WorksheetPart GetSheet(SpreadsheetDocument sd, string sheetName)
        {
            WorkbookPart workbookPart;

            if (sd.WorkbookPart is null)
            {
                workbookPart = sd.AddWorkbookPart();
            }
            else
            {
                workbookPart = sd.WorkbookPart;
            }

            IEnumerable<Sheet>? sheets = workbookPart.Workbook.GetFirstChild<Sheets>()?.Elements<Sheet>().Where(s => s.Name == sheetName);

            if (sheets is null || sheets.Count() == 0)
            {
                // The specified worksheet does not exist.
                throw new ArgumentException(sheetName + " is not found.");
            }

            string? relationshipId = sheets.First()?.Id?.Value;
            WorksheetPart worksheetPart;

            if (!(relationshipId is null))
            {
                worksheetPart = (WorksheetPart)workbookPart.GetPartById(relationshipId);
            }
            else
            {
                worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
            }

            return worksheetPart;
        }

        private static int InsertSharedStringItem(string text, SharedStringTablePart? shareStringPart)
        {
            // If the part does not contain a SharedStringTable, create one.
            if (shareStringPart != null && shareStringPart.SharedStringTable == null)
            {
                shareStringPart.SharedStringTable = new SharedStringTable();
            }

            int i = 0;

            if (shareStringPart?.SharedStringTable != null)
            {
                // Iterate through all the items in the SharedStringTable. If the text already exists, return its index.
                foreach (SharedStringItem item in shareStringPart.SharedStringTable.Elements<SharedStringItem>())
                {
                    if (item.InnerText == text)
                    {
                        return i;
                    }

                    i++;
                }

                // The text does not exist in the part. Create the SharedStringItem and return its index.
                shareStringPart.SharedStringTable.AppendChild(new SharedStringItem(new DocumentFormat.OpenXml.Spreadsheet.Text(text)));
                shareStringPart.SharedStringTable.Save();
            }

            return i;
        }

        private static Cell InsertCellInWorksheet(string columnName, uint rowIndex, WorksheetPart worksheetPart)
        {
            Worksheet worksheet = worksheetPart.Worksheet;
            SheetData? sheetData = worksheet.GetFirstChild<SheetData>();

            string cellReference = columnName + rowIndex;

            // If the worksheet does not contain a row with the specified row index, insert one.
            Row row;
            IEnumerable<Row>? rows = sheetData?.Elements<Row>().Where(r => !(r.RowIndex is null) && r.RowIndex == rowIndex);

            if (!(rows is null) && rows.Count() != 0)
            {
                row = rows.First();
            }
            else
            {
                if (sheetData is null)
                {
                    sheetData = new SheetData();
                    worksheet.PrependChild(sheetData);
                }

                row = new Row() { RowIndex = rowIndex };
                sheetData.Append(row);
            }

            // If there is not a cell with the specified column name, insert one.
            IEnumerable<Cell> cells = row.Elements<Cell>().Where(c => !(c is null) && !(c.CellReference is null) && c.CellReference.Value == columnName + rowIndex);

            if (cells.Count() > 0)
            {
                return cells.First();
            }
            else
            {
                // Cells must be in sequential order according to CellReference. Determine where to insert the new cell.
                Cell? refCell = null;

                foreach (Cell cell in row.Elements<Cell>())
                {
                    if (!(cell.CellReference is null) && !(cell.CellReference.Value is null) && cell.CellReference.Value.Length == cellReference.Length)
                    {
                        if (string.Compare(cell.CellReference.Value, cellReference, true) > 0)
                        {
                            refCell = cell;
                            break;
                        }
                    }
                }

                Cell newCell = new Cell() { CellReference = cellReference };
                row.InsertBefore(newCell, refCell);

                worksheet.Save();
                return newCell;
            }
        }
    }
}
