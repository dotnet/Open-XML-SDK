// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml.Packaging;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;
using Vt = DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using S = DocumentFormat.OpenXml.Spreadsheet;
using X15ac = DocumentFormat.OpenXml.Office2013.ExcelAc;
using X14 = DocumentFormat.OpenXml.Office2010.Excel;
using X15 = DocumentFormat.OpenXml.Office2013.Excel;
using Xdr = DocumentFormat.OpenXml.Drawing.Spreadsheet;
using A = DocumentFormat.OpenXml.Drawing;
using Sle = DocumentFormat.OpenXml.Office2010.Drawing.Slicer;
using Thm15 = DocumentFormat.OpenXml.Office2013.Theme;

namespace DocumentFormat.OpenXml.Tests.SlicerClass
{
    public class GeneratedDocument
    {
        // Creates a SpreadsheetDocument.
        public void CreatePackage(string filePath)
        {
            using(SpreadsheetDocument package = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                CreateParts(package);
            }
        }

        // Adds child parts and generates content of the specified part.
        private void CreateParts(SpreadsheetDocument document)
        {
            ExtendedFilePropertiesPart extendedFilePropertiesPart1 = document.AddNewPart<ExtendedFilePropertiesPart>("rId3");
            GenerateExtendedFilePropertiesPart1Content(extendedFilePropertiesPart1);

            WorkbookPart workbookPart1 = document.AddWorkbookPart();
            GenerateWorkbookPart1Content(workbookPart1);

            SlicerCachePart slicerCachePart1 = workbookPart1.AddNewPart<SlicerCachePart>("rId3");
            GenerateSlicerCachePart1Content(slicerCachePart1);

            SharedStringTablePart sharedStringTablePart1 = workbookPart1.AddNewPart<SharedStringTablePart>("rId7");
            GenerateSharedStringTablePart1Content(sharedStringTablePart1);

            SlicerCachePart slicerCachePart2 = workbookPart1.AddNewPart<SlicerCachePart>("rId2");
            GenerateSlicerCachePart2Content(slicerCachePart2);

            WorksheetPart worksheetPart1 = workbookPart1.AddNewPart<WorksheetPart>("rId1");
            GenerateWorksheetPart1Content(worksheetPart1);

            TableDefinitionPart tableDefinitionPart1 = worksheetPart1.AddNewPart<TableDefinitionPart>("rId3");
            GenerateTableDefinitionPart1Content(tableDefinitionPart1);

            TableDefinitionPart tableDefinitionPart2 = worksheetPart1.AddNewPart<TableDefinitionPart>("rId2");
            GenerateTableDefinitionPart2Content(tableDefinitionPart2);

            DrawingsPart drawingsPart1 = worksheetPart1.AddNewPart<DrawingsPart>("rId1");
            GenerateDrawingsPart1Content(drawingsPart1);

            SlicersPart slicersPart1 = worksheetPart1.AddNewPart<SlicersPart>("rId4");
            GenerateSlicersPart1Content(slicersPart1);

            WorkbookStylesPart workbookStylesPart1 = workbookPart1.AddNewPart<WorkbookStylesPart>("rId6");
            GenerateWorkbookStylesPart1Content(workbookStylesPart1);

            ThemePart themePart1 = workbookPart1.AddNewPart<ThemePart>("rId5");
            GenerateThemePart1Content(themePart1);

            SlicerCachePart slicerCachePart3 = workbookPart1.AddNewPart<SlicerCachePart>("rId4");
            GenerateSlicerCachePart3Content(slicerCachePart3);

            SetPackageProperties(document);
        }

        // Generates content of extendedFilePropertiesPart1.
        private void GenerateExtendedFilePropertiesPart1Content(ExtendedFilePropertiesPart extendedFilePropertiesPart1)
        {
            Ap.Properties properties1 = new Ap.Properties();
            properties1.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
            Ap.Application application1 = new Ap.Application();
            application1.Text = "Microsoft Excel";
            Ap.DocumentSecurity documentSecurity1 = new Ap.DocumentSecurity();
            documentSecurity1.Text = "0";
            Ap.ScaleCrop scaleCrop1 = new Ap.ScaleCrop();
            scaleCrop1.Text = "false";

            Ap.HeadingPairs headingPairs1 = new Ap.HeadingPairs();

            Vt.VTVector vTVector1 = new Vt.VTVector(){ BaseType = Vt.VectorBaseValues.Variant, Size = (UInt32Value)2U };

            Vt.Variant variant1 = new Vt.Variant();
            Vt.VTLPSTR vTLPSTR1 = new Vt.VTLPSTR();
            vTLPSTR1.Text = "Worksheets";

            variant1.Append(vTLPSTR1);

            Vt.Variant variant2 = new Vt.Variant();
            Vt.VTInt32 vTInt321 = new Vt.VTInt32();
            vTInt321.Text = "1";

            variant2.Append(vTInt321);

            vTVector1.Append(variant1);
            vTVector1.Append(variant2);

            headingPairs1.Append(vTVector1);

            Ap.TitlesOfParts titlesOfParts1 = new Ap.TitlesOfParts();

            Vt.VTVector vTVector2 = new Vt.VTVector(){ BaseType = Vt.VectorBaseValues.Lpstr, Size = (UInt32Value)1U };
            Vt.VTLPSTR vTLPSTR2 = new Vt.VTLPSTR();
            vTLPSTR2.Text = "Sheet1";

            vTVector2.Append(vTLPSTR2);

            titlesOfParts1.Append(vTVector2);
            Ap.LinksUpToDate linksUpToDate1 = new Ap.LinksUpToDate();
            linksUpToDate1.Text = "false";
            Ap.SharedDocument sharedDocument1 = new Ap.SharedDocument();
            sharedDocument1.Text = "false";
            Ap.HyperlinksChanged hyperlinksChanged1 = new Ap.HyperlinksChanged();
            hyperlinksChanged1.Text = "false";
            Ap.ApplicationVersion applicationVersion1 = new Ap.ApplicationVersion();
            applicationVersion1.Text = "15.0300";

            properties1.Append(application1);
            properties1.Append(documentSecurity1);
            properties1.Append(scaleCrop1);
            properties1.Append(headingPairs1);
            properties1.Append(titlesOfParts1);
            properties1.Append(linksUpToDate1);
            properties1.Append(sharedDocument1);
            properties1.Append(hyperlinksChanged1);
            properties1.Append(applicationVersion1);

            extendedFilePropertiesPart1.Properties = properties1;
        }

        // Generates content of workbookPart1.
        private void GenerateWorkbookPart1Content(WorkbookPart workbookPart1)
        {
            Workbook workbook1 = new Workbook(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "x15" }  };
            workbook1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            workbook1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            workbook1.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
            FileVersion fileVersion1 = new FileVersion(){ ApplicationName = "xl", LastEdited = "6", LowestEdited = "6", BuildVersion = "14420" };
            WorkbookProperties workbookProperties1 = new WorkbookProperties(){ DefaultThemeVersion = (UInt32Value)153222U };

            AlternateContent alternateContent1 = new AlternateContent();
            alternateContent1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");

            AlternateContentChoice alternateContentChoice1 = new AlternateContentChoice(){ Requires = "x15" };

            X15ac.AbsolutePath absolutePath1 = new X15ac.AbsolutePath(){ Url = "D:\\Users\\dito\\Desktop\\TestDocumentResaver\\OpenXmlApiConversion\\Slicer\\" };
            absolutePath1.AddNamespaceDeclaration("x15ac", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/ac");

            alternateContentChoice1.Append(absolutePath1);

            alternateContent1.Append(alternateContentChoice1);

            BookViews bookViews1 = new BookViews();
            WorkbookView workbookView1 = new WorkbookView(){ XWindow = 0, YWindow = 0, WindowWidth = (UInt32Value)26940U, WindowHeight = (UInt32Value)15120U };

            bookViews1.Append(workbookView1);

            Sheets sheets1 = new Sheets();
            Sheet sheet1 = new Sheet(){ Name = "Sheet1", SheetId = (UInt32Value)1U, Id = "rId1" };

            sheets1.Append(sheet1);

            DefinedNames definedNames1 = new DefinedNames();
            DefinedName definedName1 = new DefinedName(){ Name = "Slicer_Column1" };
            definedName1.Text = "#N/A";
            DefinedName definedName2 = new DefinedName(){ Name = "Slicer_Column2" };
            definedName2.Text = "#N/A";
            DefinedName definedName3 = new DefinedName(){ Name = "Slicer_Column3" };
            definedName3.Text = "#N/A";

            definedNames1.Append(definedName1);
            definedNames1.Append(definedName2);
            definedNames1.Append(definedName3);
            CalculationProperties calculationProperties1 = new CalculationProperties(){ CalculationId = (UInt32Value)152511U };

            WorkbookExtensionList workbookExtensionList1 = new WorkbookExtensionList();

            WorkbookExtension workbookExtension1 = new WorkbookExtension(){ Uri = "{79F54976-1DA5-4618-B147-4CDE4B953A38}" };
            workbookExtension1.AddNamespaceDeclaration("x14", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main");
            X14.WorkbookProperties workbookProperties2 = new X14.WorkbookProperties();

            workbookExtension1.Append(workbookProperties2);

            WorkbookExtension workbookExtension2 = new WorkbookExtension(){ Uri = "{46BE6895-7355-4a93-B00E-2C351335B9C9}" };
            workbookExtension2.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");

            X15.SlicerCaches slicerCaches1 = new X15.SlicerCaches();
            slicerCaches1.AddNamespaceDeclaration("x14", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main");
            X14.SlicerCache slicerCache1 = new X14.SlicerCache(){ Id = "rId2" };
            X14.SlicerCache slicerCache2 = new X14.SlicerCache(){ Id = "rId3" };
            X14.SlicerCache slicerCache3 = new X14.SlicerCache(){ Id = "rId4" };

            slicerCaches1.Append(slicerCache1);
            slicerCaches1.Append(slicerCache2);
            slicerCaches1.Append(slicerCache3);

            workbookExtension2.Append(slicerCaches1);

            WorkbookExtension workbookExtension3 = new WorkbookExtension(){ Uri = "{140A7094-0E35-4892-8432-C4D2E57EDEB5}" };
            workbookExtension3.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
            X15.WorkbookProperties workbookProperties3 = new X15.WorkbookProperties(){ ChartTrackingReferenceBase = true };

            workbookExtension3.Append(workbookProperties3);

            workbookExtensionList1.Append(workbookExtension1);
            workbookExtensionList1.Append(workbookExtension2);
            workbookExtensionList1.Append(workbookExtension3);

            workbook1.Append(fileVersion1);
            workbook1.Append(workbookProperties1);
            workbook1.Append(alternateContent1);
            workbook1.Append(bookViews1);
            workbook1.Append(sheets1);
            workbook1.Append(definedNames1);
            workbook1.Append(calculationProperties1);
            workbook1.Append(workbookExtensionList1);

            workbookPart1.Workbook = workbook1;
        }

        // Generates content of slicerCachePart1.
        private void GenerateSlicerCachePart1Content(SlicerCachePart slicerCachePart1)
        {
            X14.SlicerCacheDefinition slicerCacheDefinition1 = new X14.SlicerCacheDefinition(){ Name = "Slicer_Column2", SourceName = "Column2", MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "x" }  };
            slicerCacheDefinition1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            slicerCacheDefinition1.AddNamespaceDeclaration("x", "http://schemas.openxmlformats.org/spreadsheetml/2006/main");

            X14.SlicerCacheDefinitionExtensionList slicerCacheDefinitionExtensionList1 = new X14.SlicerCacheDefinitionExtensionList();

            SlicerCacheDefinitionExtension slicerCacheDefinitionExtension1 = new SlicerCacheDefinitionExtension(){ Uri = "{2F2917AC-EB37-4324-AD4E-5DD8C200BD13}" };
            slicerCacheDefinitionExtension1.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
            X15.TableSlicerCache tableSlicerCache1 = new X15.TableSlicerCache(){ TableId = (UInt32Value)1U, Column = (UInt32Value)2U };

            slicerCacheDefinitionExtension1.Append(tableSlicerCache1);

            slicerCacheDefinitionExtensionList1.Append(slicerCacheDefinitionExtension1);

            slicerCacheDefinition1.Append(slicerCacheDefinitionExtensionList1);

            slicerCachePart1.SlicerCacheDefinition = slicerCacheDefinition1;
        }

        // Generates content of sharedStringTablePart1.
        private void GenerateSharedStringTablePart1Content(SharedStringTablePart sharedStringTablePart1)
        {
            SharedStringTable sharedStringTable1 = new SharedStringTable(){ Count = (UInt32Value)18U, UniqueCount = (UInt32Value)15U };

            SharedStringItem sharedStringItem1 = new SharedStringItem();
            Text text1 = new Text();
            text1.Text = "TEST_A_1";
            PhoneticProperties phoneticProperties1 = new PhoneticProperties(){ FontId = (UInt32Value)1U };

            sharedStringItem1.Append(text1);
            sharedStringItem1.Append(phoneticProperties1);

            SharedStringItem sharedStringItem2 = new SharedStringItem();
            Text text2 = new Text();
            text2.Text = "TEST_A_2";
            PhoneticProperties phoneticProperties2 = new PhoneticProperties(){ FontId = (UInt32Value)1U };

            sharedStringItem2.Append(text2);
            sharedStringItem2.Append(phoneticProperties2);

            SharedStringItem sharedStringItem3 = new SharedStringItem();
            Text text3 = new Text();
            text3.Text = "A";
            PhoneticProperties phoneticProperties3 = new PhoneticProperties(){ FontId = (UInt32Value)1U };

            sharedStringItem3.Append(text3);
            sharedStringItem3.Append(phoneticProperties3);

            SharedStringItem sharedStringItem4 = new SharedStringItem();
            Text text4 = new Text();
            text4.Text = "B";
            PhoneticProperties phoneticProperties4 = new PhoneticProperties(){ FontId = (UInt32Value)1U };

            sharedStringItem4.Append(text4);
            sharedStringItem4.Append(phoneticProperties4);

            SharedStringItem sharedStringItem5 = new SharedStringItem();
            Text text5 = new Text();
            text5.Text = "TEST_B_1";
            PhoneticProperties phoneticProperties5 = new PhoneticProperties(){ FontId = (UInt32Value)1U };

            sharedStringItem5.Append(text5);
            sharedStringItem5.Append(phoneticProperties5);

            SharedStringItem sharedStringItem6 = new SharedStringItem();
            Text text6 = new Text();
            text6.Text = "TEST_B_2";
            PhoneticProperties phoneticProperties6 = new PhoneticProperties(){ FontId = (UInt32Value)1U };

            sharedStringItem6.Append(text6);
            sharedStringItem6.Append(phoneticProperties6);

            SharedStringItem sharedStringItem7 = new SharedStringItem();
            Text text7 = new Text();
            text7.Text = "TETS_A_3";
            PhoneticProperties phoneticProperties7 = new PhoneticProperties(){ FontId = (UInt32Value)1U };

            sharedStringItem7.Append(text7);
            sharedStringItem7.Append(phoneticProperties7);

            SharedStringItem sharedStringItem8 = new SharedStringItem();
            Text text8 = new Text();
            text8.Text = "C";
            PhoneticProperties phoneticProperties8 = new PhoneticProperties(){ FontId = (UInt32Value)1U };

            sharedStringItem8.Append(text8);
            sharedStringItem8.Append(phoneticProperties8);

            SharedStringItem sharedStringItem9 = new SharedStringItem();
            Text text9 = new Text();
            text9.Text = "TEST_B_3";
            PhoneticProperties phoneticProperties9 = new PhoneticProperties(){ FontId = (UInt32Value)1U };

            sharedStringItem9.Append(text9);
            sharedStringItem9.Append(phoneticProperties9);

            SharedStringItem sharedStringItem10 = new SharedStringItem();
            Text text10 = new Text();
            text10.Text = "D";
            PhoneticProperties phoneticProperties10 = new PhoneticProperties(){ FontId = (UInt32Value)1U };

            sharedStringItem10.Append(text10);
            sharedStringItem10.Append(phoneticProperties10);

            SharedStringItem sharedStringItem11 = new SharedStringItem();
            Text text11 = new Text();
            text11.Text = "E";
            PhoneticProperties phoneticProperties11 = new PhoneticProperties(){ FontId = (UInt32Value)1U };

            sharedStringItem11.Append(text11);
            sharedStringItem11.Append(phoneticProperties11);

            SharedStringItem sharedStringItem12 = new SharedStringItem();
            Text text12 = new Text();
            text12.Text = "F";
            PhoneticProperties phoneticProperties12 = new PhoneticProperties(){ FontId = (UInt32Value)1U };

            sharedStringItem12.Append(text12);
            sharedStringItem12.Append(phoneticProperties12);

            SharedStringItem sharedStringItem13 = new SharedStringItem();
            Text text13 = new Text();
            text13.Text = "Column1";

            sharedStringItem13.Append(text13);

            SharedStringItem sharedStringItem14 = new SharedStringItem();
            Text text14 = new Text();
            text14.Text = "Column2";

            sharedStringItem14.Append(text14);

            SharedStringItem sharedStringItem15 = new SharedStringItem();
            Text text15 = new Text();
            text15.Text = "Column3";

            sharedStringItem15.Append(text15);

            sharedStringTable1.Append(sharedStringItem1);
            sharedStringTable1.Append(sharedStringItem2);
            sharedStringTable1.Append(sharedStringItem3);
            sharedStringTable1.Append(sharedStringItem4);
            sharedStringTable1.Append(sharedStringItem5);
            sharedStringTable1.Append(sharedStringItem6);
            sharedStringTable1.Append(sharedStringItem7);
            sharedStringTable1.Append(sharedStringItem8);
            sharedStringTable1.Append(sharedStringItem9);
            sharedStringTable1.Append(sharedStringItem10);
            sharedStringTable1.Append(sharedStringItem11);
            sharedStringTable1.Append(sharedStringItem12);
            sharedStringTable1.Append(sharedStringItem13);
            sharedStringTable1.Append(sharedStringItem14);
            sharedStringTable1.Append(sharedStringItem15);

            sharedStringTablePart1.SharedStringTable = sharedStringTable1;
        }

        // Generates content of slicerCachePart2.
        private void GenerateSlicerCachePart2Content(SlicerCachePart slicerCachePart2)
        {
            X14.SlicerCacheDefinition slicerCacheDefinition2 = new X14.SlicerCacheDefinition(){ Name = "Slicer_Column1", SourceName = "Column1", MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "x" }  };
            slicerCacheDefinition2.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            slicerCacheDefinition2.AddNamespaceDeclaration("x", "http://schemas.openxmlformats.org/spreadsheetml/2006/main");

            X14.SlicerCacheDefinitionExtensionList slicerCacheDefinitionExtensionList2 = new X14.SlicerCacheDefinitionExtensionList();

            SlicerCacheDefinitionExtension slicerCacheDefinitionExtension2 = new SlicerCacheDefinitionExtension(){ Uri = "{2F2917AC-EB37-4324-AD4E-5DD8C200BD13}" };
            slicerCacheDefinitionExtension2.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
            X15.TableSlicerCache tableSlicerCache2 = new X15.TableSlicerCache(){ TableId = (UInt32Value)1U, Column = (UInt32Value)1U };

            slicerCacheDefinitionExtension2.Append(tableSlicerCache2);

            slicerCacheDefinitionExtensionList2.Append(slicerCacheDefinitionExtension2);

            slicerCacheDefinition2.Append(slicerCacheDefinitionExtensionList2);

            slicerCachePart2.SlicerCacheDefinition = slicerCacheDefinition2;
        }

        // Generates content of worksheetPart1.
        private void GenerateWorksheetPart1Content(WorksheetPart worksheetPart1)
        {
            Worksheet worksheet1 = new Worksheet(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "x14ac" }  };
            worksheet1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            worksheet1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            worksheet1.AddNamespaceDeclaration("x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");
            SheetDimension sheetDimension1 = new SheetDimension(){ Reference = "A1:G4" };

            SheetViews sheetViews1 = new SheetViews();
            SheetView sheetView1 = new SheetView(){ TabSelected = true, WorkbookViewId = (UInt32Value)0U };

            sheetViews1.Append(sheetView1);
            SheetFormatProperties sheetFormatProperties1 = new SheetFormatProperties(){ DefaultRowHeight = 15D };

            Columns columns1 = new Columns();
            Column column1 = new Column(){ Min = (UInt32Value)1U, Max = (UInt32Value)3U, Width = 10.5703125D, CustomWidth = true };
            Column column2 = new Column(){ Min = (UInt32Value)5U, Max = (UInt32Value)7U, Width = 10.5703125D, CustomWidth = true };

            columns1.Append(column1);
            columns1.Append(column2);

            SheetData sheetData1 = new SheetData();

            Row row1 = new Row(){ RowIndex = (UInt32Value)1U, Spans = new ListValue<StringValue>() { InnerText = "1:7" } };

            Cell cell1 = new Cell(){ CellReference = "A1", DataType = CellValues.SharedString };
            CellValue cellValue1 = new CellValue();
            cellValue1.Text = "12";

            cell1.Append(cellValue1);

            Cell cell2 = new Cell(){ CellReference = "B1", DataType = CellValues.SharedString };
            CellValue cellValue2 = new CellValue();
            cellValue2.Text = "13";

            cell2.Append(cellValue2);

            Cell cell3 = new Cell(){ CellReference = "C1", DataType = CellValues.SharedString };
            CellValue cellValue3 = new CellValue();
            cellValue3.Text = "14";

            cell3.Append(cellValue3);

            Cell cell4 = new Cell(){ CellReference = "E1", DataType = CellValues.SharedString };
            CellValue cellValue4 = new CellValue();
            cellValue4.Text = "12";

            cell4.Append(cellValue4);

            Cell cell5 = new Cell(){ CellReference = "F1", DataType = CellValues.SharedString };
            CellValue cellValue5 = new CellValue();
            cellValue5.Text = "13";

            cell5.Append(cellValue5);

            Cell cell6 = new Cell(){ CellReference = "G1", DataType = CellValues.SharedString };
            CellValue cellValue6 = new CellValue();
            cellValue6.Text = "14";

            cell6.Append(cellValue6);

            row1.Append(cell1);
            row1.Append(cell2);
            row1.Append(cell3);
            row1.Append(cell4);
            row1.Append(cell5);
            row1.Append(cell6);

            Row row2 = new Row(){ RowIndex = (UInt32Value)2U, Spans = new ListValue<StringValue>() { InnerText = "1:7" } };

            Cell cell7 = new Cell(){ CellReference = "A2", DataType = CellValues.SharedString };
            CellValue cellValue7 = new CellValue();
            cellValue7.Text = "0";

            cell7.Append(cellValue7);

            Cell cell8 = new Cell(){ CellReference = "B2", DataType = CellValues.SharedString };
            CellValue cellValue8 = new CellValue();
            cellValue8.Text = "2";

            cell8.Append(cellValue8);

            Cell cell9 = new Cell(){ CellReference = "C2" };
            CellValue cellValue9 = new CellValue();
            cellValue9.Text = "1";

            cell9.Append(cellValue9);

            Cell cell10 = new Cell(){ CellReference = "E2", DataType = CellValues.SharedString };
            CellValue cellValue10 = new CellValue();
            cellValue10.Text = "4";

            cell10.Append(cellValue10);

            Cell cell11 = new Cell(){ CellReference = "F2", DataType = CellValues.SharedString };
            CellValue cellValue11 = new CellValue();
            cellValue11.Text = "9";

            cell11.Append(cellValue11);

            Cell cell12 = new Cell(){ CellReference = "G2" };
            CellValue cellValue12 = new CellValue();
            cellValue12.Text = "3";

            cell12.Append(cellValue12);

            row2.Append(cell7);
            row2.Append(cell8);
            row2.Append(cell9);
            row2.Append(cell10);
            row2.Append(cell11);
            row2.Append(cell12);

            Row row3 = new Row(){ RowIndex = (UInt32Value)3U, Spans = new ListValue<StringValue>() { InnerText = "1:7" } };

            Cell cell13 = new Cell(){ CellReference = "A3", DataType = CellValues.SharedString };
            CellValue cellValue13 = new CellValue();
            cellValue13.Text = "1";

            cell13.Append(cellValue13);

            Cell cell14 = new Cell(){ CellReference = "B3", DataType = CellValues.SharedString };
            CellValue cellValue14 = new CellValue();
            cellValue14.Text = "3";

            cell14.Append(cellValue14);

            Cell cell15 = new Cell(){ CellReference = "C3" };
            CellValue cellValue15 = new CellValue();
            cellValue15.Text = "2";

            cell15.Append(cellValue15);

            Cell cell16 = new Cell(){ CellReference = "E3", DataType = CellValues.SharedString };
            CellValue cellValue16 = new CellValue();
            cellValue16.Text = "5";

            cell16.Append(cellValue16);

            Cell cell17 = new Cell(){ CellReference = "F3", DataType = CellValues.SharedString };
            CellValue cellValue17 = new CellValue();
            cellValue17.Text = "10";

            cell17.Append(cellValue17);

            Cell cell18 = new Cell(){ CellReference = "G3" };
            CellValue cellValue18 = new CellValue();
            cellValue18.Text = "4";

            cell18.Append(cellValue18);

            row3.Append(cell13);
            row3.Append(cell14);
            row3.Append(cell15);
            row3.Append(cell16);
            row3.Append(cell17);
            row3.Append(cell18);

            Row row4 = new Row(){ RowIndex = (UInt32Value)4U, Spans = new ListValue<StringValue>() { InnerText = "1:7" } };

            Cell cell19 = new Cell(){ CellReference = "A4", DataType = CellValues.SharedString };
            CellValue cellValue19 = new CellValue();
            cellValue19.Text = "6";

            cell19.Append(cellValue19);

            Cell cell20 = new Cell(){ CellReference = "B4", DataType = CellValues.SharedString };
            CellValue cellValue20 = new CellValue();
            cellValue20.Text = "7";

            cell20.Append(cellValue20);

            Cell cell21 = new Cell(){ CellReference = "C4" };
            CellValue cellValue21 = new CellValue();
            cellValue21.Text = "3";

            cell21.Append(cellValue21);

            Cell cell22 = new Cell(){ CellReference = "E4", DataType = CellValues.SharedString };
            CellValue cellValue22 = new CellValue();
            cellValue22.Text = "8";

            cell22.Append(cellValue22);

            Cell cell23 = new Cell(){ CellReference = "F4", DataType = CellValues.SharedString };
            CellValue cellValue23 = new CellValue();
            cellValue23.Text = "11";

            cell23.Append(cellValue23);

            Cell cell24 = new Cell(){ CellReference = "G4" };
            CellValue cellValue24 = new CellValue();
            cellValue24.Text = "5";

            cell24.Append(cellValue24);

            row4.Append(cell19);
            row4.Append(cell20);
            row4.Append(cell21);
            row4.Append(cell22);
            row4.Append(cell23);
            row4.Append(cell24);

            sheetData1.Append(row1);
            sheetData1.Append(row2);
            sheetData1.Append(row3);
            sheetData1.Append(row4);
            PhoneticProperties phoneticProperties13 = new PhoneticProperties(){ FontId = (UInt32Value)1U };
            PageMargins pageMargins1 = new PageMargins(){ Left = 0.7D, Right = 0.7D, Top = 0.75D, Bottom = 0.75D, Header = 0.3D, Footer = 0.3D };
            S.Drawing drawing1 = new S.Drawing(){ Id = "rId1" };

            TableParts tableParts1 = new TableParts(){ Count = (UInt32Value)2U };
            TablePart tablePart1 = new TablePart(){ Id = "rId2" };
            TablePart tablePart2 = new TablePart(){ Id = "rId3" };

            tableParts1.Append(tablePart1);
            tableParts1.Append(tablePart2);

            WorksheetExtensionList worksheetExtensionList1 = new WorksheetExtensionList();

            WorksheetExtension worksheetExtension1 = new WorksheetExtension(){ Uri = "{3A4CF648-6AED-40f4-86FF-DC5316D8AED3}" };
            worksheetExtension1.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");

            X14.SlicerList slicerList1 = new X14.SlicerList();
            slicerList1.AddNamespaceDeclaration("x14", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main");
            X14.SlicerRef slicerRef1 = new X14.SlicerRef(){ Id = "rId4" };

            slicerList1.Append(slicerRef1);

            worksheetExtension1.Append(slicerList1);

            worksheetExtensionList1.Append(worksheetExtension1);

            worksheet1.Append(sheetDimension1);
            worksheet1.Append(sheetViews1);
            worksheet1.Append(sheetFormatProperties1);
            worksheet1.Append(columns1);
            worksheet1.Append(sheetData1);
            worksheet1.Append(phoneticProperties13);
            worksheet1.Append(pageMargins1);
            worksheet1.Append(drawing1);
            worksheet1.Append(tableParts1);
            worksheet1.Append(worksheetExtensionList1);

            worksheetPart1.Worksheet = worksheet1;
        }

        // Generates content of tableDefinitionPart1.
        private void GenerateTableDefinitionPart1Content(TableDefinitionPart tableDefinitionPart1)
        {
            Table table1 = new Table(){ Id = (UInt32Value)2U, Name = "Table2", DisplayName = "Table2", Reference = "E1:G4", TotalsRowShown = false };
            AutoFilter autoFilter1 = new AutoFilter(){ Reference = "E1:G4" };

            TableColumns tableColumns1 = new TableColumns(){ Count = (UInt32Value)3U };
            TableColumn tableColumn1 = new TableColumn(){ Id = (UInt32Value)1U, Name = "Column1" };
            TableColumn tableColumn2 = new TableColumn(){ Id = (UInt32Value)2U, Name = "Column2" };
            TableColumn tableColumn3 = new TableColumn(){ Id = (UInt32Value)3U, Name = "Column3" };

            tableColumns1.Append(tableColumn1);
            tableColumns1.Append(tableColumn2);
            tableColumns1.Append(tableColumn3);
            TableStyleInfo tableStyleInfo1 = new TableStyleInfo(){ Name = "TableStyleMedium2", ShowFirstColumn = false, ShowLastColumn = false, ShowRowStripes = true, ShowColumnStripes = false };

            table1.Append(autoFilter1);
            table1.Append(tableColumns1);
            table1.Append(tableStyleInfo1);

            tableDefinitionPart1.Table = table1;
        }

        // Generates content of tableDefinitionPart2.
        private void GenerateTableDefinitionPart2Content(TableDefinitionPart tableDefinitionPart2)
        {
            Table table2 = new Table(){ Id = (UInt32Value)1U, Name = "Table1", DisplayName = "Table1", Reference = "A1:C4", TotalsRowShown = false };
            AutoFilter autoFilter2 = new AutoFilter(){ Reference = "A1:C4" };

            TableColumns tableColumns2 = new TableColumns(){ Count = (UInt32Value)3U };
            TableColumn tableColumn4 = new TableColumn(){ Id = (UInt32Value)1U, Name = "Column1" };
            TableColumn tableColumn5 = new TableColumn(){ Id = (UInt32Value)2U, Name = "Column2" };
            TableColumn tableColumn6 = new TableColumn(){ Id = (UInt32Value)3U, Name = "Column3" };

            tableColumns2.Append(tableColumn4);
            tableColumns2.Append(tableColumn5);
            tableColumns2.Append(tableColumn6);
            TableStyleInfo tableStyleInfo2 = new TableStyleInfo(){ Name = "TableStyleMedium2", ShowFirstColumn = false, ShowLastColumn = false, ShowRowStripes = true, ShowColumnStripes = false };

            table2.Append(autoFilter2);
            table2.Append(tableColumns2);
            table2.Append(tableStyleInfo2);

            tableDefinitionPart2.Table = table2;
        }

        // Generates content of drawingsPart1.
        private void GenerateDrawingsPart1Content(DrawingsPart drawingsPart1)
        {
            Xdr.WorksheetDrawing worksheetDrawing1 = new Xdr.WorksheetDrawing();
            worksheetDrawing1.AddNamespaceDeclaration("xdr", "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing");
            worksheetDrawing1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            Xdr.TwoCellAnchor twoCellAnchor1 = new Xdr.TwoCellAnchor(){ EditAs = Xdr.EditAsValues.Absolute };

            Xdr.FromMarker fromMarker1 = new Xdr.FromMarker();
            Xdr.ColumnId columnId1 = new Xdr.ColumnId();
            columnId1.Text = "0";
            Xdr.ColumnOffset columnOffset1 = new Xdr.ColumnOffset();
            columnOffset1.Text = "0";
            Xdr.RowId rowId1 = new Xdr.RowId();
            rowId1.Text = "5";
            Xdr.RowOffset rowOffset1 = new Xdr.RowOffset();
            rowOffset1.Text = "161925";

            fromMarker1.Append(columnId1);
            fromMarker1.Append(columnOffset1);
            fromMarker1.Append(rowId1);
            fromMarker1.Append(rowOffset1);

            Xdr.ToMarker toMarker1 = new Xdr.ToMarker();
            Xdr.ColumnId columnId2 = new Xdr.ColumnId();
            columnId2.Text = "2";
            Xdr.ColumnOffset columnOffset2 = new Xdr.ColumnOffset();
            columnOffset2.Text = "209550";
            Xdr.RowId rowId2 = new Xdr.RowId();
            rowId2.Text = "19";
            Xdr.RowOffset rowOffset2 = new Xdr.RowOffset();
            rowOffset2.Text = "142875";

            toMarker1.Append(columnId2);
            toMarker1.Append(columnOffset2);
            toMarker1.Append(rowId2);
            toMarker1.Append(rowOffset2);

            AlternateContent alternateContent2 = new AlternateContent();
            alternateContent2.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            alternateContent2.AddNamespaceDeclaration("a15", "http://schemas.microsoft.com/office/drawing/2012/main");

            AlternateContentChoice alternateContentChoice2 = new AlternateContentChoice(){ Requires = "a15" };

            Xdr.GraphicFrame graphicFrame1 = new Xdr.GraphicFrame(){ Macro = "" };

            Xdr.NonVisualGraphicFrameProperties nonVisualGraphicFrameProperties1 = new Xdr.NonVisualGraphicFrameProperties();
            Xdr.NonVisualDrawingProperties nonVisualDrawingProperties1 = new Xdr.NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Slicer_1" };
            Xdr.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties1 = new Xdr.NonVisualGraphicFrameDrawingProperties();

            nonVisualGraphicFrameProperties1.Append(nonVisualDrawingProperties1);
            nonVisualGraphicFrameProperties1.Append(nonVisualGraphicFrameDrawingProperties1);

            Xdr.Transform transform1 = new Xdr.Transform();
            A.Offset offset1 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents1 = new A.Extents(){ Cx = 0L, Cy = 0L };

            transform1.Append(offset1);
            transform1.Append(extents1);

            A.Graphic graphic1 = new A.Graphic();

            A.GraphicData graphicData1 = new A.GraphicData(){ Uri = "http://schemas.microsoft.com/office/drawing/2010/slicer" };

            Sle.Slicer slicer1 = new Sle.Slicer(){ Name = "Slicer_1" };
            slicer1.AddNamespaceDeclaration("sle", "http://schemas.microsoft.com/office/drawing/2010/slicer");

            graphicData1.Append(slicer1);

            graphic1.Append(graphicData1);

            graphicFrame1.Append(nonVisualGraphicFrameProperties1);
            graphicFrame1.Append(transform1);
            graphicFrame1.Append(graphic1);

            alternateContentChoice2.Append(graphicFrame1);

            AlternateContentFallback alternateContentFallback1 = new AlternateContentFallback();

            Xdr.Shape shape1 = new Xdr.Shape(){ Macro = "", TextLink = "" };

            Xdr.NonVisualShapeProperties nonVisualShapeProperties1 = new Xdr.NonVisualShapeProperties();
            Xdr.NonVisualDrawingProperties nonVisualDrawingProperties2 = new Xdr.NonVisualDrawingProperties(){ Id = (UInt32Value)0U, Name = "" };

            Xdr.NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties1 = new Xdr.NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks1 = new A.ShapeLocks(){ NoTextEdit = true };

            nonVisualShapeDrawingProperties1.Append(shapeLocks1);

            nonVisualShapeProperties1.Append(nonVisualDrawingProperties2);
            nonVisualShapeProperties1.Append(nonVisualShapeDrawingProperties1);

            Xdr.ShapeProperties shapeProperties1 = new Xdr.ShapeProperties();

            A.Transform2D transform2D1 = new A.Transform2D();
            A.Offset offset2 = new A.Offset(){ X = 0L, Y = 1019175L };
            A.Extents extents2 = new A.Extents(){ Cx = 1828800L, Cy = 2381250L };

            transform2D1.Append(offset2);
            transform2D1.Append(extents2);

            A.PresetGeometry presetGeometry1 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList1 = new A.AdjustValueList();

            presetGeometry1.Append(adjustValueList1);

            A.SolidFill solidFill1 = new A.SolidFill();
            A.PresetColor presetColor1 = new A.PresetColor(){ Val = A.PresetColorValues.White };

            solidFill1.Append(presetColor1);

            A.Outline outline1 = new A.Outline(){ Width = 1 };

            A.SolidFill solidFill2 = new A.SolidFill();
            A.PresetColor presetColor2 = new A.PresetColor(){ Val = A.PresetColorValues.Green };

            solidFill2.Append(presetColor2);

            outline1.Append(solidFill2);

            shapeProperties1.Append(transform2D1);
            shapeProperties1.Append(presetGeometry1);
            shapeProperties1.Append(solidFill1);
            shapeProperties1.Append(outline1);

            Xdr.TextBody textBody1 = new Xdr.TextBody();
            A.BodyProperties bodyProperties1 = new A.BodyProperties(){ VerticalOverflow = A.TextVerticalOverflowValues.Clip, HorizontalOverflow = A.TextHorizontalOverflowValues.Clip };
            A.ListStyle listStyle1 = new A.ListStyle();

            A.Paragraph paragraph1 = new A.Paragraph();

            A.Run run1 = new A.Run();
            A.RunProperties runProperties1 = new A.RunProperties(){ Language = "ja-JP", AlternativeLanguage = "en-US", FontSize = 1100 };
            A.Text text16 = new A.Text();
            text16.Text = "This shape represents a table slicer. Table slicers can be used in at least Excel 15.\n\nIf the shape was modified in an earlier version of Excel, or if the workbook was saved in Excel 2010 or earlier, the slicer cannot be used.";

            run1.Append(runProperties1);
            run1.Append(text16);

            paragraph1.Append(run1);

            textBody1.Append(bodyProperties1);
            textBody1.Append(listStyle1);
            textBody1.Append(paragraph1);

            shape1.Append(nonVisualShapeProperties1);
            shape1.Append(shapeProperties1);
            shape1.Append(textBody1);

            alternateContentFallback1.Append(shape1);

            alternateContent2.Append(alternateContentChoice2);
            alternateContent2.Append(alternateContentFallback1);
            Xdr.ClientData clientData1 = new Xdr.ClientData();

            twoCellAnchor1.Append(fromMarker1);
            twoCellAnchor1.Append(toMarker1);
            twoCellAnchor1.Append(alternateContent2);
            twoCellAnchor1.Append(clientData1);

            Xdr.TwoCellAnchor twoCellAnchor2 = new Xdr.TwoCellAnchor(){ EditAs = Xdr.EditAsValues.Absolute };

            Xdr.FromMarker fromMarker2 = new Xdr.FromMarker();
            Xdr.ColumnId columnId3 = new Xdr.ColumnId();
            columnId3.Text = "3";
            Xdr.ColumnOffset columnOffset3 = new Xdr.ColumnOffset();
            columnOffset3.Text = "0";
            Xdr.RowId rowId3 = new Xdr.RowId();
            rowId3.Text = "6";
            Xdr.RowOffset rowOffset3 = new Xdr.RowOffset();
            rowOffset3.Text = "0";

            fromMarker2.Append(columnId3);
            fromMarker2.Append(columnOffset3);
            fromMarker2.Append(rowId3);
            fromMarker2.Append(rowOffset3);

            Xdr.ToMarker toMarker2 = new Xdr.ToMarker();
            Xdr.ColumnId columnId4 = new Xdr.ColumnId();
            columnId4.Text = "5";
            Xdr.ColumnOffset columnOffset4 = new Xdr.ColumnOffset();
            columnOffset4.Text = "333375";
            Xdr.RowId rowId4 = new Xdr.RowId();
            rowId4.Text = "19";
            Xdr.RowOffset rowOffset4 = new Xdr.RowOffset();
            rowOffset4.Text = "152400";

            toMarker2.Append(columnId4);
            toMarker2.Append(columnOffset4);
            toMarker2.Append(rowId4);
            toMarker2.Append(rowOffset4);

            AlternateContent alternateContent3 = new AlternateContent();
            alternateContent3.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            alternateContent3.AddNamespaceDeclaration("a15", "http://schemas.microsoft.com/office/drawing/2012/main");

            AlternateContentChoice alternateContentChoice3 = new AlternateContentChoice(){ Requires = "a15" };

            Xdr.GraphicFrame graphicFrame2 = new Xdr.GraphicFrame(){ Macro = "" };

            Xdr.NonVisualGraphicFrameProperties nonVisualGraphicFrameProperties2 = new Xdr.NonVisualGraphicFrameProperties();
            Xdr.NonVisualDrawingProperties nonVisualDrawingProperties3 = new Xdr.NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Slicer_2" };
            Xdr.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties2 = new Xdr.NonVisualGraphicFrameDrawingProperties();

            nonVisualGraphicFrameProperties2.Append(nonVisualDrawingProperties3);
            nonVisualGraphicFrameProperties2.Append(nonVisualGraphicFrameDrawingProperties2);

            Xdr.Transform transform2 = new Xdr.Transform();
            A.Offset offset3 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents3 = new A.Extents(){ Cx = 0L, Cy = 0L };

            transform2.Append(offset3);
            transform2.Append(extents3);

            A.Graphic graphic2 = new A.Graphic();

            A.GraphicData graphicData2 = new A.GraphicData(){ Uri = "http://schemas.microsoft.com/office/drawing/2010/slicer" };

            Sle.Slicer slicer2 = new Sle.Slicer(){ Name = "Slicer_2" };
            slicer2.AddNamespaceDeclaration("sle", "http://schemas.microsoft.com/office/drawing/2010/slicer");

            graphicData2.Append(slicer2);

            graphic2.Append(graphicData2);

            graphicFrame2.Append(nonVisualGraphicFrameProperties2);
            graphicFrame2.Append(transform2);
            graphicFrame2.Append(graphic2);

            alternateContentChoice3.Append(graphicFrame2);

            AlternateContentFallback alternateContentFallback2 = new AlternateContentFallback();

            Xdr.Shape shape2 = new Xdr.Shape(){ Macro = "", TextLink = "" };

            Xdr.NonVisualShapeProperties nonVisualShapeProperties2 = new Xdr.NonVisualShapeProperties();
            Xdr.NonVisualDrawingProperties nonVisualDrawingProperties4 = new Xdr.NonVisualDrawingProperties(){ Id = (UInt32Value)0U, Name = "" };

            Xdr.NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties2 = new Xdr.NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks2 = new A.ShapeLocks(){ NoTextEdit = true };

            nonVisualShapeDrawingProperties2.Append(shapeLocks2);

            nonVisualShapeProperties2.Append(nonVisualDrawingProperties4);
            nonVisualShapeProperties2.Append(nonVisualShapeDrawingProperties2);

            Xdr.ShapeProperties shapeProperties2 = new Xdr.ShapeProperties();

            A.Transform2D transform2D2 = new A.Transform2D();
            A.Offset offset4 = new A.Offset(){ X = 2428875L, Y = 1028700L };
            A.Extents extents4 = new A.Extents(){ Cx = 1828800L, Cy = 2381250L };

            transform2D2.Append(offset4);
            transform2D2.Append(extents4);

            A.PresetGeometry presetGeometry2 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList2 = new A.AdjustValueList();

            presetGeometry2.Append(adjustValueList2);

            A.SolidFill solidFill3 = new A.SolidFill();
            A.PresetColor presetColor3 = new A.PresetColor(){ Val = A.PresetColorValues.White };

            solidFill3.Append(presetColor3);

            A.Outline outline2 = new A.Outline(){ Width = 1 };

            A.SolidFill solidFill4 = new A.SolidFill();
            A.PresetColor presetColor4 = new A.PresetColor(){ Val = A.PresetColorValues.Green };

            solidFill4.Append(presetColor4);

            outline2.Append(solidFill4);

            shapeProperties2.Append(transform2D2);
            shapeProperties2.Append(presetGeometry2);
            shapeProperties2.Append(solidFill3);
            shapeProperties2.Append(outline2);

            Xdr.TextBody textBody2 = new Xdr.TextBody();
            A.BodyProperties bodyProperties2 = new A.BodyProperties(){ VerticalOverflow = A.TextVerticalOverflowValues.Clip, HorizontalOverflow = A.TextHorizontalOverflowValues.Clip };
            A.ListStyle listStyle2 = new A.ListStyle();

            A.Paragraph paragraph2 = new A.Paragraph();

            A.Run run2 = new A.Run();
            A.RunProperties runProperties2 = new A.RunProperties(){ Language = "ja-JP", AlternativeLanguage = "en-US", FontSize = 1100 };
            A.Text text17 = new A.Text();
            text17.Text = "This shape represents a table slicer. Table slicers can be used in at least Excel 15.\n\nIf the shape was modified in an earlier version of Excel, or if the workbook was saved in Excel 2010 or earlier, the slicer cannot be used.";

            run2.Append(runProperties2);
            run2.Append(text17);

            paragraph2.Append(run2);

            textBody2.Append(bodyProperties2);
            textBody2.Append(listStyle2);
            textBody2.Append(paragraph2);

            shape2.Append(nonVisualShapeProperties2);
            shape2.Append(shapeProperties2);
            shape2.Append(textBody2);

            alternateContentFallback2.Append(shape2);

            alternateContent3.Append(alternateContentChoice3);
            alternateContent3.Append(alternateContentFallback2);
            Xdr.ClientData clientData2 = new Xdr.ClientData();

            twoCellAnchor2.Append(fromMarker2);
            twoCellAnchor2.Append(toMarker2);
            twoCellAnchor2.Append(alternateContent3);
            twoCellAnchor2.Append(clientData2);

            Xdr.TwoCellAnchor twoCellAnchor3 = new Xdr.TwoCellAnchor(){ EditAs = Xdr.EditAsValues.Absolute };

            Xdr.FromMarker fromMarker3 = new Xdr.FromMarker();
            Xdr.ColumnId columnId5 = new Xdr.ColumnId();
            columnId5.Text = "6";
            Xdr.ColumnOffset columnOffset5 = new Xdr.ColumnOffset();
            columnOffset5.Text = "0";
            Xdr.RowId rowId5 = new Xdr.RowId();
            rowId5.Text = "6";
            Xdr.RowOffset rowOffset5 = new Xdr.RowOffset();
            rowOffset5.Text = "9525";

            fromMarker3.Append(columnId5);
            fromMarker3.Append(columnOffset5);
            fromMarker3.Append(rowId5);
            fromMarker3.Append(rowOffset5);

            Xdr.ToMarker toMarker3 = new Xdr.ToMarker();
            Xdr.ColumnId columnId6 = new Xdr.ColumnId();
            columnId6.Text = "8";
            Xdr.ColumnOffset columnOffset6 = new Xdr.ColumnOffset();
            columnOffset6.Text = "333375";
            Xdr.RowId rowId6 = new Xdr.RowId();
            rowId6.Text = "19";
            Xdr.RowOffset rowOffset6 = new Xdr.RowOffset();
            rowOffset6.Text = "161925";

            toMarker3.Append(columnId6);
            toMarker3.Append(columnOffset6);
            toMarker3.Append(rowId6);
            toMarker3.Append(rowOffset6);

            AlternateContent alternateContent4 = new AlternateContent();
            alternateContent4.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            alternateContent4.AddNamespaceDeclaration("a15", "http://schemas.microsoft.com/office/drawing/2012/main");

            AlternateContentChoice alternateContentChoice4 = new AlternateContentChoice(){ Requires = "a15" };

            Xdr.GraphicFrame graphicFrame3 = new Xdr.GraphicFrame(){ Macro = "" };

            Xdr.NonVisualGraphicFrameProperties nonVisualGraphicFrameProperties3 = new Xdr.NonVisualGraphicFrameProperties();
            Xdr.NonVisualDrawingProperties nonVisualDrawingProperties5 = new Xdr.NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Slicer_3" };
            Xdr.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties3 = new Xdr.NonVisualGraphicFrameDrawingProperties();

            nonVisualGraphicFrameProperties3.Append(nonVisualDrawingProperties5);
            nonVisualGraphicFrameProperties3.Append(nonVisualGraphicFrameDrawingProperties3);

            Xdr.Transform transform3 = new Xdr.Transform();
            A.Offset offset5 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents5 = new A.Extents(){ Cx = 0L, Cy = 0L };

            transform3.Append(offset5);
            transform3.Append(extents5);

            A.Graphic graphic3 = new A.Graphic();

            A.GraphicData graphicData3 = new A.GraphicData(){ Uri = "http://schemas.microsoft.com/office/drawing/2010/slicer" };

            Sle.Slicer slicer3 = new Sle.Slicer(){ Name = "Slicer_3" };
            slicer3.AddNamespaceDeclaration("sle", "http://schemas.microsoft.com/office/drawing/2010/slicer");

            graphicData3.Append(slicer3);

            graphic3.Append(graphicData3);

            graphicFrame3.Append(nonVisualGraphicFrameProperties3);
            graphicFrame3.Append(transform3);
            graphicFrame3.Append(graphic3);

            alternateContentChoice4.Append(graphicFrame3);

            AlternateContentFallback alternateContentFallback3 = new AlternateContentFallback();

            Xdr.Shape shape3 = new Xdr.Shape(){ Macro = "", TextLink = "" };

            Xdr.NonVisualShapeProperties nonVisualShapeProperties3 = new Xdr.NonVisualShapeProperties();
            Xdr.NonVisualDrawingProperties nonVisualDrawingProperties6 = new Xdr.NonVisualDrawingProperties(){ Id = (UInt32Value)0U, Name = "" };

            Xdr.NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties3 = new Xdr.NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks3 = new A.ShapeLocks(){ NoTextEdit = true };

            nonVisualShapeDrawingProperties3.Append(shapeLocks3);

            nonVisualShapeProperties3.Append(nonVisualDrawingProperties6);
            nonVisualShapeProperties3.Append(nonVisualShapeDrawingProperties3);

            Xdr.ShapeProperties shapeProperties3 = new Xdr.ShapeProperties();

            A.Transform2D transform2D3 = new A.Transform2D();
            A.Offset offset6 = new A.Offset(){ X = 4733925L, Y = 1038225L };
            A.Extents extents6 = new A.Extents(){ Cx = 1828800L, Cy = 2381250L };

            transform2D3.Append(offset6);
            transform2D3.Append(extents6);

            A.PresetGeometry presetGeometry3 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList3 = new A.AdjustValueList();

            presetGeometry3.Append(adjustValueList3);

            A.SolidFill solidFill5 = new A.SolidFill();
            A.PresetColor presetColor5 = new A.PresetColor(){ Val = A.PresetColorValues.White };

            solidFill5.Append(presetColor5);

            A.Outline outline3 = new A.Outline(){ Width = 1 };

            A.SolidFill solidFill6 = new A.SolidFill();
            A.PresetColor presetColor6 = new A.PresetColor(){ Val = A.PresetColorValues.Green };

            solidFill6.Append(presetColor6);

            outline3.Append(solidFill6);

            shapeProperties3.Append(transform2D3);
            shapeProperties3.Append(presetGeometry3);
            shapeProperties3.Append(solidFill5);
            shapeProperties3.Append(outline3);

            Xdr.TextBody textBody3 = new Xdr.TextBody();
            A.BodyProperties bodyProperties3 = new A.BodyProperties(){ VerticalOverflow = A.TextVerticalOverflowValues.Clip, HorizontalOverflow = A.TextHorizontalOverflowValues.Clip };
            A.ListStyle listStyle3 = new A.ListStyle();

            A.Paragraph paragraph3 = new A.Paragraph();

            A.Run run3 = new A.Run();
            A.RunProperties runProperties3 = new A.RunProperties(){ Language = "ja-JP", AlternativeLanguage = "en-US", FontSize = 1100 };
            A.Text text18 = new A.Text();
            text18.Text = "This shape represents a table slicer. Table slicers can be used in at least Excel 15.\n\nIf the shape was modified in an earlier version of Excel, or if the workbook was saved in Excel 2010 or earlier, the slicer cannot be used.";

            run3.Append(runProperties3);
            run3.Append(text18);

            paragraph3.Append(run3);

            textBody3.Append(bodyProperties3);
            textBody3.Append(listStyle3);
            textBody3.Append(paragraph3);

            shape3.Append(nonVisualShapeProperties3);
            shape3.Append(shapeProperties3);
            shape3.Append(textBody3);

            alternateContentFallback3.Append(shape3);

            alternateContent4.Append(alternateContentChoice4);
            alternateContent4.Append(alternateContentFallback3);
            Xdr.ClientData clientData3 = new Xdr.ClientData();

            twoCellAnchor3.Append(fromMarker3);
            twoCellAnchor3.Append(toMarker3);
            twoCellAnchor3.Append(alternateContent4);
            twoCellAnchor3.Append(clientData3);

            worksheetDrawing1.Append(twoCellAnchor1);
            worksheetDrawing1.Append(twoCellAnchor2);
            worksheetDrawing1.Append(twoCellAnchor3);

            drawingsPart1.WorksheetDrawing = worksheetDrawing1;
        }

        // Generates content of slicersPart1.
        private void GenerateSlicersPart1Content(SlicersPart slicersPart1)
        {
            X14.Slicers slicers1 = new X14.Slicers(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "x" }  };
            slicers1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            slicers1.AddNamespaceDeclaration("x", "http://schemas.openxmlformats.org/spreadsheetml/2006/main");
            X14.Slicer slicer4 = new X14.Slicer(){ Name = "Slicer_1", Cache = "Slicer_Column1", Caption = "Slicer_1", RowHeight = (UInt32Value)225425U };
            X14.Slicer slicer5 = new X14.Slicer(){ Name = "Slicer_2", Cache = "Slicer_Column2", Caption = "Slicer_2", RowHeight = (UInt32Value)225425U };
            X14.Slicer slicer6 = new X14.Slicer(){ Name = "Slicer_3", Cache = "Slicer_Column3", Caption = "Slicer_3", RowHeight = (UInt32Value)225425U };

            slicers1.Append(slicer4);
            slicers1.Append(slicer5);
            slicers1.Append(slicer6);

            slicersPart1.Slicers = slicers1;
        }

        // Generates content of workbookStylesPart1.
        private void GenerateWorkbookStylesPart1Content(WorkbookStylesPart workbookStylesPart1)
        {
            Stylesheet stylesheet1 = new Stylesheet(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "x14ac" }  };
            stylesheet1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            stylesheet1.AddNamespaceDeclaration("x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");

            Fonts fonts1 = new Fonts(){ Count = (UInt32Value)2U };

            Font font1 = new Font();
            FontSize fontSize1 = new FontSize(){ Val = 11D };
            Color color1 = new Color(){ Theme = (UInt32Value)1U };
            FontName fontName1 = new FontName(){ Val = "Calibri" };
            FontFamilyNumbering fontFamilyNumbering1 = new FontFamilyNumbering(){ Val = 2 };
            FontCharSet fontCharSet1 = new FontCharSet(){ Val = 128 };
            FontScheme fontScheme1 = new FontScheme(){ Val = FontSchemeValues.Minor };

            font1.Append(fontSize1);
            font1.Append(color1);
            font1.Append(fontName1);
            font1.Append(fontFamilyNumbering1);
            font1.Append(fontCharSet1);
            font1.Append(fontScheme1);

            Font font2 = new Font();
            FontSize fontSize2 = new FontSize(){ Val = 6D };
            FontName fontName2 = new FontName(){ Val = "Calibri" };
            FontFamilyNumbering fontFamilyNumbering2 = new FontFamilyNumbering(){ Val = 2 };
            FontCharSet fontCharSet2 = new FontCharSet(){ Val = 128 };
            FontScheme fontScheme2 = new FontScheme(){ Val = FontSchemeValues.Minor };

            font2.Append(fontSize2);
            font2.Append(fontName2);
            font2.Append(fontFamilyNumbering2);
            font2.Append(fontCharSet2);
            font2.Append(fontScheme2);

            fonts1.Append(font1);
            fonts1.Append(font2);

            Fills fills1 = new Fills(){ Count = (UInt32Value)2U };

            Fill fill1 = new Fill();
            PatternFill patternFill1 = new PatternFill(){ PatternType = PatternValues.None };

            fill1.Append(patternFill1);

            Fill fill2 = new Fill();
            PatternFill patternFill2 = new PatternFill(){ PatternType = PatternValues.Gray125 };

            fill2.Append(patternFill2);

            fills1.Append(fill1);
            fills1.Append(fill2);

            Borders borders1 = new Borders(){ Count = (UInt32Value)1U };

            Border border1 = new Border();
            LeftBorder leftBorder1 = new LeftBorder();
            RightBorder rightBorder1 = new RightBorder();
            TopBorder topBorder1 = new TopBorder();
            BottomBorder bottomBorder1 = new BottomBorder();
            DiagonalBorder diagonalBorder1 = new DiagonalBorder();

            border1.Append(leftBorder1);
            border1.Append(rightBorder1);
            border1.Append(topBorder1);
            border1.Append(bottomBorder1);
            border1.Append(diagonalBorder1);

            borders1.Append(border1);

            CellStyleFormats cellStyleFormats1 = new CellStyleFormats(){ Count = (UInt32Value)1U };

            CellFormat cellFormat1 = new CellFormat(){ NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U };
            Alignment alignment1 = new Alignment(){ Vertical = VerticalAlignmentValues.Center };

            cellFormat1.Append(alignment1);

            cellStyleFormats1.Append(cellFormat1);

            CellFormats cellFormats1 = new CellFormats(){ Count = (UInt32Value)1U };

            CellFormat cellFormat2 = new CellFormat(){ NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U };
            Alignment alignment2 = new Alignment(){ Vertical = VerticalAlignmentValues.Center };

            cellFormat2.Append(alignment2);

            cellFormats1.Append(cellFormat2);

            CellStyles cellStyles1 = new CellStyles(){ Count = (UInt32Value)1U };
            CellStyle cellStyle1 = new CellStyle(){ Name = "Normal", FormatId = (UInt32Value)0U, BuiltinId = (UInt32Value)0U };

            cellStyles1.Append(cellStyle1);
            DifferentialFormats differentialFormats1 = new DifferentialFormats(){ Count = (UInt32Value)0U };
            TableStyles tableStyles1 = new TableStyles(){ Count = (UInt32Value)0U, DefaultTableStyle = "TableStyleMedium2", DefaultPivotStyle = "PivotStyleLight16" };

            StylesheetExtensionList stylesheetExtensionList1 = new StylesheetExtensionList();

            StylesheetExtension stylesheetExtension1 = new StylesheetExtension(){ Uri = "{EB79DEF2-80B8-43e5-95BD-54CBDDF9020C}" };
            stylesheetExtension1.AddNamespaceDeclaration("x14", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main");
            X14.SlicerStyles slicerStyles1 = new X14.SlicerStyles(){ DefaultSlicerStyle = "SlicerStyleLight1" };

            stylesheetExtension1.Append(slicerStyles1);

            StylesheetExtension stylesheetExtension2 = new StylesheetExtension(){ Uri = "{9260A510-F301-46a8-8635-F512D64BE5F5}" };
            stylesheetExtension2.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
            X15.TimelineStyles timelineStyles1 = new X15.TimelineStyles(){ DefaultTimelineStyle = "TimeSlicerStyleLight1" };

            stylesheetExtension2.Append(timelineStyles1);

            stylesheetExtensionList1.Append(stylesheetExtension1);
            stylesheetExtensionList1.Append(stylesheetExtension2);

            stylesheet1.Append(fonts1);
            stylesheet1.Append(fills1);
            stylesheet1.Append(borders1);
            stylesheet1.Append(cellStyleFormats1);
            stylesheet1.Append(cellFormats1);
            stylesheet1.Append(cellStyles1);
            stylesheet1.Append(differentialFormats1);
            stylesheet1.Append(tableStyles1);
            stylesheet1.Append(stylesheetExtensionList1);

            workbookStylesPart1.Stylesheet = stylesheet1;
        }

        // Generates content of themePart1.
        private void GenerateThemePart1Content(ThemePart themePart1)
        {
            A.Theme theme1 = new A.Theme(){ Name = "Office Theme" };
            theme1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.ThemeElements themeElements1 = new A.ThemeElements();

            A.ColorScheme colorScheme1 = new A.ColorScheme(){ Name = "Office" };

            A.Dark1Color dark1Color1 = new A.Dark1Color();
            A.SystemColor systemColor1 = new A.SystemColor(){ Val = A.SystemColorValues.WindowText, LastColor = "000000" };

            dark1Color1.Append(systemColor1);

            A.Light1Color light1Color1 = new A.Light1Color();
            A.SystemColor systemColor2 = new A.SystemColor(){ Val = A.SystemColorValues.Window, LastColor = "FFFFFF" };

            light1Color1.Append(systemColor2);

            A.Dark2Color dark2Color1 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex1 = new A.RgbColorModelHex(){ Val = "44546A" };

            dark2Color1.Append(rgbColorModelHex1);

            A.Light2Color light2Color1 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex2 = new A.RgbColorModelHex(){ Val = "E7E6E6" };

            light2Color1.Append(rgbColorModelHex2);

            A.Accent1Color accent1Color1 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex3 = new A.RgbColorModelHex(){ Val = "5B9BD5" };

            accent1Color1.Append(rgbColorModelHex3);

            A.Accent2Color accent2Color1 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex4 = new A.RgbColorModelHex(){ Val = "ED7D31" };

            accent2Color1.Append(rgbColorModelHex4);

            A.Accent3Color accent3Color1 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex5 = new A.RgbColorModelHex(){ Val = "A5A5A5" };

            accent3Color1.Append(rgbColorModelHex5);

            A.Accent4Color accent4Color1 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex6 = new A.RgbColorModelHex(){ Val = "FFC000" };

            accent4Color1.Append(rgbColorModelHex6);

            A.Accent5Color accent5Color1 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex7 = new A.RgbColorModelHex(){ Val = "4472C4" };

            accent5Color1.Append(rgbColorModelHex7);

            A.Accent6Color accent6Color1 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex8 = new A.RgbColorModelHex(){ Val = "70AD47" };

            accent6Color1.Append(rgbColorModelHex8);

            A.Hyperlink hyperlink1 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex9 = new A.RgbColorModelHex(){ Val = "0563C1" };

            hyperlink1.Append(rgbColorModelHex9);

            A.FollowedHyperlinkColor followedHyperlinkColor1 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex10 = new A.RgbColorModelHex(){ Val = "954F72" };

            followedHyperlinkColor1.Append(rgbColorModelHex10);

            colorScheme1.Append(dark1Color1);
            colorScheme1.Append(light1Color1);
            colorScheme1.Append(dark2Color1);
            colorScheme1.Append(light2Color1);
            colorScheme1.Append(accent1Color1);
            colorScheme1.Append(accent2Color1);
            colorScheme1.Append(accent3Color1);
            colorScheme1.Append(accent4Color1);
            colorScheme1.Append(accent5Color1);
            colorScheme1.Append(accent6Color1);
            colorScheme1.Append(hyperlink1);
            colorScheme1.Append(followedHyperlinkColor1);

            A.FontScheme fontScheme3 = new A.FontScheme(){ Name = "Office" };

            A.MajorFont majorFont1 = new A.MajorFont();
            A.LatinFont latinFont1 = new A.LatinFont(){ Typeface = "Calibri Light", Panose = "020F0302020204030204" };
            A.EastAsianFont eastAsianFont1 = new A.EastAsianFont(){ Typeface = "" };
            A.ComplexScriptFont complexScriptFont1 = new A.ComplexScriptFont(){ Typeface = "" };
            A.SupplementalFont supplementalFont1 = new A.SupplementalFont(){ Script = "Jpan", Typeface = "ＭＳ Ｐゴシック" };
            A.SupplementalFont supplementalFont2 = new A.SupplementalFont(){ Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont3 = new A.SupplementalFont(){ Script = "Hans", Typeface = "宋体" };
            A.SupplementalFont supplementalFont4 = new A.SupplementalFont(){ Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont5 = new A.SupplementalFont(){ Script = "Arab", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont6 = new A.SupplementalFont(){ Script = "Hebr", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont7 = new A.SupplementalFont(){ Script = "Thai", Typeface = "Tahoma" };
            A.SupplementalFont supplementalFont8 = new A.SupplementalFont(){ Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont9 = new A.SupplementalFont(){ Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont10 = new A.SupplementalFont(){ Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont11 = new A.SupplementalFont(){ Script = "Khmr", Typeface = "MoolBoran" };
            A.SupplementalFont supplementalFont12 = new A.SupplementalFont(){ Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont13 = new A.SupplementalFont(){ Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont14 = new A.SupplementalFont(){ Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont15 = new A.SupplementalFont(){ Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont16 = new A.SupplementalFont(){ Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont17 = new A.SupplementalFont(){ Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont18 = new A.SupplementalFont(){ Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont19 = new A.SupplementalFont(){ Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont20 = new A.SupplementalFont(){ Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont21 = new A.SupplementalFont(){ Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont22 = new A.SupplementalFont(){ Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont23 = new A.SupplementalFont(){ Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont24 = new A.SupplementalFont(){ Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont25 = new A.SupplementalFont(){ Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont26 = new A.SupplementalFont(){ Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont27 = new A.SupplementalFont(){ Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont28 = new A.SupplementalFont(){ Script = "Viet", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont29 = new A.SupplementalFont(){ Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont30 = new A.SupplementalFont(){ Script = "Geor", Typeface = "Sylfaen" };

            majorFont1.Append(latinFont1);
            majorFont1.Append(eastAsianFont1);
            majorFont1.Append(complexScriptFont1);
            majorFont1.Append(supplementalFont1);
            majorFont1.Append(supplementalFont2);
            majorFont1.Append(supplementalFont3);
            majorFont1.Append(supplementalFont4);
            majorFont1.Append(supplementalFont5);
            majorFont1.Append(supplementalFont6);
            majorFont1.Append(supplementalFont7);
            majorFont1.Append(supplementalFont8);
            majorFont1.Append(supplementalFont9);
            majorFont1.Append(supplementalFont10);
            majorFont1.Append(supplementalFont11);
            majorFont1.Append(supplementalFont12);
            majorFont1.Append(supplementalFont13);
            majorFont1.Append(supplementalFont14);
            majorFont1.Append(supplementalFont15);
            majorFont1.Append(supplementalFont16);
            majorFont1.Append(supplementalFont17);
            majorFont1.Append(supplementalFont18);
            majorFont1.Append(supplementalFont19);
            majorFont1.Append(supplementalFont20);
            majorFont1.Append(supplementalFont21);
            majorFont1.Append(supplementalFont22);
            majorFont1.Append(supplementalFont23);
            majorFont1.Append(supplementalFont24);
            majorFont1.Append(supplementalFont25);
            majorFont1.Append(supplementalFont26);
            majorFont1.Append(supplementalFont27);
            majorFont1.Append(supplementalFont28);
            majorFont1.Append(supplementalFont29);
            majorFont1.Append(supplementalFont30);

            A.MinorFont minorFont1 = new A.MinorFont();
            A.LatinFont latinFont2 = new A.LatinFont(){ Typeface = "Calibri", Panose = "020F0502020204030204" };
            A.EastAsianFont eastAsianFont2 = new A.EastAsianFont(){ Typeface = "" };
            A.ComplexScriptFont complexScriptFont2 = new A.ComplexScriptFont(){ Typeface = "" };
            A.SupplementalFont supplementalFont31 = new A.SupplementalFont(){ Script = "Jpan", Typeface = "ＭＳ Ｐゴシック" };
            A.SupplementalFont supplementalFont32 = new A.SupplementalFont(){ Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont33 = new A.SupplementalFont(){ Script = "Hans", Typeface = "宋体" };
            A.SupplementalFont supplementalFont34 = new A.SupplementalFont(){ Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont35 = new A.SupplementalFont(){ Script = "Arab", Typeface = "Arial" };
            A.SupplementalFont supplementalFont36 = new A.SupplementalFont(){ Script = "Hebr", Typeface = "Arial" };
            A.SupplementalFont supplementalFont37 = new A.SupplementalFont(){ Script = "Thai", Typeface = "Tahoma" };
            A.SupplementalFont supplementalFont38 = new A.SupplementalFont(){ Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont39 = new A.SupplementalFont(){ Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont40 = new A.SupplementalFont(){ Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont41 = new A.SupplementalFont(){ Script = "Khmr", Typeface = "DaunPenh" };
            A.SupplementalFont supplementalFont42 = new A.SupplementalFont(){ Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont43 = new A.SupplementalFont(){ Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont44 = new A.SupplementalFont(){ Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont45 = new A.SupplementalFont(){ Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont46 = new A.SupplementalFont(){ Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont47 = new A.SupplementalFont(){ Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont48 = new A.SupplementalFont(){ Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont49 = new A.SupplementalFont(){ Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont50 = new A.SupplementalFont(){ Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont51 = new A.SupplementalFont(){ Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont52 = new A.SupplementalFont(){ Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont53 = new A.SupplementalFont(){ Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont54 = new A.SupplementalFont(){ Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont55 = new A.SupplementalFont(){ Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont56 = new A.SupplementalFont(){ Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont57 = new A.SupplementalFont(){ Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont58 = new A.SupplementalFont(){ Script = "Viet", Typeface = "Arial" };
            A.SupplementalFont supplementalFont59 = new A.SupplementalFont(){ Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont60 = new A.SupplementalFont(){ Script = "Geor", Typeface = "Sylfaen" };

            minorFont1.Append(latinFont2);
            minorFont1.Append(eastAsianFont2);
            minorFont1.Append(complexScriptFont2);
            minorFont1.Append(supplementalFont31);
            minorFont1.Append(supplementalFont32);
            minorFont1.Append(supplementalFont33);
            minorFont1.Append(supplementalFont34);
            minorFont1.Append(supplementalFont35);
            minorFont1.Append(supplementalFont36);
            minorFont1.Append(supplementalFont37);
            minorFont1.Append(supplementalFont38);
            minorFont1.Append(supplementalFont39);
            minorFont1.Append(supplementalFont40);
            minorFont1.Append(supplementalFont41);
            minorFont1.Append(supplementalFont42);
            minorFont1.Append(supplementalFont43);
            minorFont1.Append(supplementalFont44);
            minorFont1.Append(supplementalFont45);
            minorFont1.Append(supplementalFont46);
            minorFont1.Append(supplementalFont47);
            minorFont1.Append(supplementalFont48);
            minorFont1.Append(supplementalFont49);
            minorFont1.Append(supplementalFont50);
            minorFont1.Append(supplementalFont51);
            minorFont1.Append(supplementalFont52);
            minorFont1.Append(supplementalFont53);
            minorFont1.Append(supplementalFont54);
            minorFont1.Append(supplementalFont55);
            minorFont1.Append(supplementalFont56);
            minorFont1.Append(supplementalFont57);
            minorFont1.Append(supplementalFont58);
            minorFont1.Append(supplementalFont59);
            minorFont1.Append(supplementalFont60);

            fontScheme3.Append(majorFont1);
            fontScheme3.Append(minorFont1);

            A.FormatScheme formatScheme1 = new A.FormatScheme(){ Name = "Office" };

            A.FillStyleList fillStyleList1 = new A.FillStyleList();

            A.SolidFill solidFill7 = new A.SolidFill();
            A.SchemeColor schemeColor1 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill7.Append(schemeColor1);

            A.GradientFill gradientFill1 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList1 = new A.GradientStopList();

            A.GradientStop gradientStop1 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor2 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation1 = new A.LuminanceModulation(){ Val = 110000 };
            A.SaturationModulation saturationModulation1 = new A.SaturationModulation(){ Val = 105000 };
            A.Tint tint1 = new A.Tint(){ Val = 67000 };

            schemeColor2.Append(luminanceModulation1);
            schemeColor2.Append(saturationModulation1);
            schemeColor2.Append(tint1);

            gradientStop1.Append(schemeColor2);

            A.GradientStop gradientStop2 = new A.GradientStop(){ Position = 50000 };

            A.SchemeColor schemeColor3 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation2 = new A.LuminanceModulation(){ Val = 105000 };
            A.SaturationModulation saturationModulation2 = new A.SaturationModulation(){ Val = 103000 };
            A.Tint tint2 = new A.Tint(){ Val = 73000 };

            schemeColor3.Append(luminanceModulation2);
            schemeColor3.Append(saturationModulation2);
            schemeColor3.Append(tint2);

            gradientStop2.Append(schemeColor3);

            A.GradientStop gradientStop3 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor4 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation3 = new A.LuminanceModulation(){ Val = 105000 };
            A.SaturationModulation saturationModulation3 = new A.SaturationModulation(){ Val = 109000 };
            A.Tint tint3 = new A.Tint(){ Val = 81000 };

            schemeColor4.Append(luminanceModulation3);
            schemeColor4.Append(saturationModulation3);
            schemeColor4.Append(tint3);

            gradientStop3.Append(schemeColor4);

            gradientStopList1.Append(gradientStop1);
            gradientStopList1.Append(gradientStop2);
            gradientStopList1.Append(gradientStop3);
            A.LinearGradientFill linearGradientFill1 = new A.LinearGradientFill(){ Angle = 5400000, Scaled = false };

            gradientFill1.Append(gradientStopList1);
            gradientFill1.Append(linearGradientFill1);

            A.GradientFill gradientFill2 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList2 = new A.GradientStopList();

            A.GradientStop gradientStop4 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor5 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.SaturationModulation saturationModulation4 = new A.SaturationModulation(){ Val = 103000 };
            A.LuminanceModulation luminanceModulation4 = new A.LuminanceModulation(){ Val = 102000 };
            A.Tint tint4 = new A.Tint(){ Val = 94000 };

            schemeColor5.Append(saturationModulation4);
            schemeColor5.Append(luminanceModulation4);
            schemeColor5.Append(tint4);

            gradientStop4.Append(schemeColor5);

            A.GradientStop gradientStop5 = new A.GradientStop(){ Position = 50000 };

            A.SchemeColor schemeColor6 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.SaturationModulation saturationModulation5 = new A.SaturationModulation(){ Val = 110000 };
            A.LuminanceModulation luminanceModulation5 = new A.LuminanceModulation(){ Val = 100000 };
            A.Shade shade1 = new A.Shade(){ Val = 100000 };

            schemeColor6.Append(saturationModulation5);
            schemeColor6.Append(luminanceModulation5);
            schemeColor6.Append(shade1);

            gradientStop5.Append(schemeColor6);

            A.GradientStop gradientStop6 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor7 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation6 = new A.LuminanceModulation(){ Val = 99000 };
            A.SaturationModulation saturationModulation6 = new A.SaturationModulation(){ Val = 120000 };
            A.Shade shade2 = new A.Shade(){ Val = 78000 };

            schemeColor7.Append(luminanceModulation6);
            schemeColor7.Append(saturationModulation6);
            schemeColor7.Append(shade2);

            gradientStop6.Append(schemeColor7);

            gradientStopList2.Append(gradientStop4);
            gradientStopList2.Append(gradientStop5);
            gradientStopList2.Append(gradientStop6);
            A.LinearGradientFill linearGradientFill2 = new A.LinearGradientFill(){ Angle = 5400000, Scaled = false };

            gradientFill2.Append(gradientStopList2);
            gradientFill2.Append(linearGradientFill2);

            fillStyleList1.Append(solidFill7);
            fillStyleList1.Append(gradientFill1);
            fillStyleList1.Append(gradientFill2);

            A.LineStyleList lineStyleList1 = new A.LineStyleList();

            A.Outline outline4 = new A.Outline(){ Width = 6350, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill8 = new A.SolidFill();
            A.SchemeColor schemeColor8 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill8.Append(schemeColor8);
            A.PresetDash presetDash1 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };
            A.Miter miter1 = new A.Miter(){ Limit = 800000 };

            outline4.Append(solidFill8);
            outline4.Append(presetDash1);
            outline4.Append(miter1);

            A.Outline outline5 = new A.Outline(){ Width = 12700, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill9 = new A.SolidFill();
            A.SchemeColor schemeColor9 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill9.Append(schemeColor9);
            A.PresetDash presetDash2 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };
            A.Miter miter2 = new A.Miter(){ Limit = 800000 };

            outline5.Append(solidFill9);
            outline5.Append(presetDash2);
            outline5.Append(miter2);

            A.Outline outline6 = new A.Outline(){ Width = 19050, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill10 = new A.SolidFill();
            A.SchemeColor schemeColor10 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill10.Append(schemeColor10);
            A.PresetDash presetDash3 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };
            A.Miter miter3 = new A.Miter(){ Limit = 800000 };

            outline6.Append(solidFill10);
            outline6.Append(presetDash3);
            outline6.Append(miter3);

            lineStyleList1.Append(outline4);
            lineStyleList1.Append(outline5);
            lineStyleList1.Append(outline6);

            A.EffectStyleList effectStyleList1 = new A.EffectStyleList();

            A.EffectStyle effectStyle1 = new A.EffectStyle();
            A.EffectList effectList1 = new A.EffectList();

            effectStyle1.Append(effectList1);

            A.EffectStyle effectStyle2 = new A.EffectStyle();
            A.EffectList effectList2 = new A.EffectList();

            effectStyle2.Append(effectList2);

            A.EffectStyle effectStyle3 = new A.EffectStyle();

            A.EffectList effectList3 = new A.EffectList();

            A.OuterShadow outerShadow1 = new A.OuterShadow(){ BlurRadius = 57150L, Distance = 19050L, Direction = 5400000, Alignment = A.RectangleAlignmentValues.Center, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex11 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha1 = new A.Alpha(){ Val = 63000 };

            rgbColorModelHex11.Append(alpha1);

            outerShadow1.Append(rgbColorModelHex11);

            effectList3.Append(outerShadow1);

            effectStyle3.Append(effectList3);

            effectStyleList1.Append(effectStyle1);
            effectStyleList1.Append(effectStyle2);
            effectStyleList1.Append(effectStyle3);

            A.BackgroundFillStyleList backgroundFillStyleList1 = new A.BackgroundFillStyleList();

            A.SolidFill solidFill11 = new A.SolidFill();
            A.SchemeColor schemeColor11 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill11.Append(schemeColor11);

            A.SolidFill solidFill12 = new A.SolidFill();

            A.SchemeColor schemeColor12 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint5 = new A.Tint(){ Val = 95000 };
            A.SaturationModulation saturationModulation7 = new A.SaturationModulation(){ Val = 170000 };

            schemeColor12.Append(tint5);
            schemeColor12.Append(saturationModulation7);

            solidFill12.Append(schemeColor12);

            A.GradientFill gradientFill3 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList3 = new A.GradientStopList();

            A.GradientStop gradientStop7 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor13 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint6 = new A.Tint(){ Val = 93000 };
            A.SaturationModulation saturationModulation8 = new A.SaturationModulation(){ Val = 150000 };
            A.Shade shade3 = new A.Shade(){ Val = 98000 };
            A.LuminanceModulation luminanceModulation7 = new A.LuminanceModulation(){ Val = 102000 };

            schemeColor13.Append(tint6);
            schemeColor13.Append(saturationModulation8);
            schemeColor13.Append(shade3);
            schemeColor13.Append(luminanceModulation7);

            gradientStop7.Append(schemeColor13);

            A.GradientStop gradientStop8 = new A.GradientStop(){ Position = 50000 };

            A.SchemeColor schemeColor14 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint7 = new A.Tint(){ Val = 98000 };
            A.SaturationModulation saturationModulation9 = new A.SaturationModulation(){ Val = 130000 };
            A.Shade shade4 = new A.Shade(){ Val = 90000 };
            A.LuminanceModulation luminanceModulation8 = new A.LuminanceModulation(){ Val = 103000 };

            schemeColor14.Append(tint7);
            schemeColor14.Append(saturationModulation9);
            schemeColor14.Append(shade4);
            schemeColor14.Append(luminanceModulation8);

            gradientStop8.Append(schemeColor14);

            A.GradientStop gradientStop9 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor15 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade5 = new A.Shade(){ Val = 63000 };
            A.SaturationModulation saturationModulation10 = new A.SaturationModulation(){ Val = 120000 };

            schemeColor15.Append(shade5);
            schemeColor15.Append(saturationModulation10);

            gradientStop9.Append(schemeColor15);

            gradientStopList3.Append(gradientStop7);
            gradientStopList3.Append(gradientStop8);
            gradientStopList3.Append(gradientStop9);
            A.LinearGradientFill linearGradientFill3 = new A.LinearGradientFill(){ Angle = 5400000, Scaled = false };

            gradientFill3.Append(gradientStopList3);
            gradientFill3.Append(linearGradientFill3);

            backgroundFillStyleList1.Append(solidFill11);
            backgroundFillStyleList1.Append(solidFill12);
            backgroundFillStyleList1.Append(gradientFill3);

            formatScheme1.Append(fillStyleList1);
            formatScheme1.Append(lineStyleList1);
            formatScheme1.Append(effectStyleList1);
            formatScheme1.Append(backgroundFillStyleList1);

            themeElements1.Append(colorScheme1);
            themeElements1.Append(fontScheme3);
            themeElements1.Append(formatScheme1);
            A.ObjectDefaults objectDefaults1 = new A.ObjectDefaults();
            A.ExtraColorSchemeList extraColorSchemeList1 = new A.ExtraColorSchemeList();

            A.OfficeStyleSheetExtensionList officeStyleSheetExtensionList1 = new A.OfficeStyleSheetExtensionList();

            A.OfficeStyleSheetExtension officeStyleSheetExtension1 = new A.OfficeStyleSheetExtension(){ Uri = "{05A4C25C-085E-4340-85A3-A5531E510DB2}" };

            Thm15.ThemeFamily themeFamily1 = new Thm15.ThemeFamily(){ Name = "Office Theme", Id = "{62F939B6-93AF-4DB8-9C6B-D6C7DFDC589F}", Vid = "{4A3C46E8-61CC-4603-A589-7422A47A8E4A}" };
            themeFamily1.AddNamespaceDeclaration("thm15", "http://schemas.microsoft.com/office/thememl/2012/main");

            officeStyleSheetExtension1.Append(themeFamily1);

            officeStyleSheetExtensionList1.Append(officeStyleSheetExtension1);

            theme1.Append(themeElements1);
            theme1.Append(objectDefaults1);
            theme1.Append(extraColorSchemeList1);
            theme1.Append(officeStyleSheetExtensionList1);

            themePart1.Theme = theme1;
        }

        // Generates content of slicerCachePart3.
        private void GenerateSlicerCachePart3Content(SlicerCachePart slicerCachePart3)
        {
            X14.SlicerCacheDefinition slicerCacheDefinition3 = new X14.SlicerCacheDefinition(){ Name = "Slicer_Column3", SourceName = "Column3", MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "x" }  };
            slicerCacheDefinition3.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            slicerCacheDefinition3.AddNamespaceDeclaration("x", "http://schemas.openxmlformats.org/spreadsheetml/2006/main");

            X14.SlicerCacheDefinitionExtensionList slicerCacheDefinitionExtensionList3 = new X14.SlicerCacheDefinitionExtensionList();

            SlicerCacheDefinitionExtension slicerCacheDefinitionExtension3 = new SlicerCacheDefinitionExtension(){ Uri = "{2F2917AC-EB37-4324-AD4E-5DD8C200BD13}" };
            slicerCacheDefinitionExtension3.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
            X15.TableSlicerCache tableSlicerCache3 = new X15.TableSlicerCache(){ TableId = (UInt32Value)1U, Column = (UInt32Value)3U };

            slicerCacheDefinitionExtension3.Append(tableSlicerCache3);

            slicerCacheDefinitionExtensionList3.Append(slicerCacheDefinitionExtension3);

            slicerCacheDefinition3.Append(slicerCacheDefinitionExtensionList3);

            slicerCachePart3.SlicerCacheDefinition = slicerCacheDefinition3;
        }

        private void SetPackageProperties(OpenXmlPackage document)
        {
            document.PackageProperties.Creator = "Masaki Tamura (Pasona Tech)";
            document.PackageProperties.Created = System.Xml.XmlConvert.ToDateTime("2012-02-06T03:18:17Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2012-10-03T08:44:58Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.LastModifiedBy = "Dan Ito";
        }


    }
}
