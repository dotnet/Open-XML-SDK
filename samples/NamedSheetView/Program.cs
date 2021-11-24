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
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                _showHelp();
            }
            else if (_checkIfFilesExist(args))
            {
                InsertNamedSheetView(args[0]);
            }

        }

        private static void _showHelp()
        {
            Console.WriteLine("NamedSheetView: ");
            Console.WriteLine("Usage: NamedSheetView <filename>");
            Console.WriteLine("Where: <filename> is the .xlsx file in which to add a named sheet view.");
            Console.WriteLine();
        }

        private static bool _checkIfFilesExist(string[] files)
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

        public static void InsertNamedSheetView(string xlsxPath)
        {
            if (xlsxPath == null)
            {
                throw new ArgumentNullException("xlsxPath");
            }

            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(xlsxPath, true))
            {
                WorksheetPart worksheetPart = spreadsheetDocument.WorkbookPart.GetPartsOfType<WorksheetPart>().First();
                NamedSheetViewsPart namedSheetViewsPart = worksheetPart.AddNewPart<NamedSheetViewsPart>();

                NamedSheetView namedSheetView = new NamedSheetView();
                namedSheetView.Id = "{" + System.Guid.NewGuid().ToString().ToUpper() + "}";
                namedSheetView.Name = "testview";

                namedSheetViewsPart.NamedSheetViews = new NamedSheetViews(
                    namedSheetView
                );
                namedSheetViewsPart.NamedSheetViews.AddNamespaceDeclaration("x", "http://schemas.openxmlformats.org/spreadsheetml/2006/main");

                spreadsheetDocument.Save();
            }
        }
    }
}