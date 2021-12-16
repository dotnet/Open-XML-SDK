// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office2013.ExcelAc;
using DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.IO;
using System.Linq;

namespace AddNamedSheetView
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Common.ExampleUtilities.ShowHelp(new string[]
                {
                    "NamedSheetView: ",
                    "Usage: NamedSheetView <filename>",
                    "Where: <filename> is the .xlsx file in which to add a named sheet view.",
                });
            }
            else if (Common.ExampleUtilities.CheckIfFilesExist(args))
            {
                InsertNamedSheetView(args[0]);
            }
        }

        public static void InsertNamedSheetView(string xlsxPath)
        {
            if (xlsxPath == null)
            {
                throw new ArgumentNullException(nameof(xlsxPath));
            }

            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(xlsxPath, true))
            {
                WorksheetPart worksheetPart = spreadsheetDocument.WorkbookPart.GetPartsOfType<WorksheetPart>().First();
                NamedSheetViewsPart namedSheetViewsPart = worksheetPart.AddNewPart<NamedSheetViewsPart>();

                NamedSheetView namedSheetView = new NamedSheetView();
                namedSheetView.Id = "{" + System.Guid.NewGuid().ToString().ToUpper() + "}";
                namedSheetView.Name = "testview";

                namedSheetViewsPart.NamedSheetViews = new NamedSheetViews(
                    namedSheetView);
                namedSheetViewsPart.NamedSheetViews.AddNamespaceDeclaration("x", "http://schemas.openxmlformats.org/spreadsheetml/2006/main");
            }
        }
    }
}
