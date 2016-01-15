// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml.Packaging;
using Wetp = DocumentFormat.OpenXml.Office2013.WebExtentionPane;
using DocumentFormat.OpenXml;
using We = DocumentFormat.OpenXml.Office2013.WebExtension;
using DocumentFormat.OpenXml.Spreadsheet;
using S = DocumentFormat.OpenXml.Spreadsheet;
using X15ac = DocumentFormat.OpenXml.Office2013.ExcelAc;
using X15 = DocumentFormat.OpenXml.Office2013.Excel;
using A = DocumentFormat.OpenXml.Drawing;
using Thm15 = DocumentFormat.OpenXml.Office2013.Theme;
using Xdr = DocumentFormat.OpenXml.Drawing.Spreadsheet;
using X14 = DocumentFormat.OpenXml.Office2010.Excel;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;
using Vt = DocumentFormat.OpenXml.VariantTypes;

namespace DocumentFormat.OpenXml.Tests.WebExtensionClass
{
    public class WebExtensionData
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
            WebExTaskpanesPart webExTaskpanesPart1 = document.AddNewPart<WebExTaskpanesPart>("rId2");
            GenerateWebExTaskpanesPart1Content(webExTaskpanesPart1);

            WebExtensionPart webExtensionPart1 = webExTaskpanesPart1.AddNewPart<WebExtensionPart>("rId2");
            GenerateWebExtensionPart1Content(webExtensionPart1);

            WebExtensionPart webExtensionPart2 = webExTaskpanesPart1.AddNewPart<WebExtensionPart>("rId1");
            GenerateWebExtensionPart2Content(webExtensionPart2);

            WorkbookPart workbookPart1 = document.AddWorkbookPart();
            GenerateWorkbookPart1Content(workbookPart1);

            ThemePart themePart1 = workbookPart1.AddNewPart<ThemePart>("rId3");
            GenerateThemePart1Content(themePart1);

            WorksheetPart worksheetPart1 = workbookPart1.AddNewPart<WorksheetPart>("rId2");
            GenerateWorksheetPart1Content(worksheetPart1);

            DrawingsPart drawingsPart1 = worksheetPart1.AddNewPart<DrawingsPart>("rId1");
            GenerateDrawingsPart1Content(drawingsPart1);

            WebExtensionPart webExtensionPart3 = drawingsPart1.AddNewPart<WebExtensionPart>("rId3");
            GenerateWebExtensionPart3Content(webExtensionPart3);

            ImagePart imagePart1 = webExtensionPart3.AddNewPart<ImagePart>("image/png", "rId1");
            GenerateImagePart1Content(imagePart1);

            ImagePart imagePart2 = drawingsPart1.AddNewPart<ImagePart>("image/png", "rId2");
            GenerateImagePart2Content(imagePart2);

            WebExtensionPart webExtensionPart4 = drawingsPart1.AddNewPart<WebExtensionPart>("rId1");
            GenerateWebExtensionPart4Content(webExtensionPart4);

            webExtensionPart4.AddPart(imagePart2, "rId1");

            drawingsPart1.AddPart(imagePart1, "rId4");

            WorksheetPart worksheetPart2 = workbookPart1.AddNewPart<WorksheetPart>("rId1");
            GenerateWorksheetPart2Content(worksheetPart2);

            DrawingsPart drawingsPart2 = worksheetPart2.AddNewPart<DrawingsPart>("rId1");
            GenerateDrawingsPart2Content(drawingsPart2);

            ImagePart imagePart3 = drawingsPart2.AddNewPart<ImagePart>("image/png", "rId2");
            GenerateImagePart3Content(imagePart3);

            WebExtensionPart webExtensionPart5 = drawingsPart2.AddNewPart<WebExtensionPart>("rId1");
            GenerateWebExtensionPart5Content(webExtensionPart5);

            webExtensionPart5.AddPart(imagePart3, "rId1");

            WorkbookStylesPart workbookStylesPart1 = workbookPart1.AddNewPart<WorkbookStylesPart>("rId4");
            GenerateWorkbookStylesPart1Content(workbookStylesPart1);

            ExtendedFilePropertiesPart extendedFilePropertiesPart1 = document.AddNewPart<ExtendedFilePropertiesPart>("rId4");
            GenerateExtendedFilePropertiesPart1Content(extendedFilePropertiesPart1);

            SetPackageProperties(document);
        }

        // Generates content of webExTaskpanesPart1.
        private void GenerateWebExTaskpanesPart1Content(WebExTaskpanesPart webExTaskpanesPart1)
        {
            Wetp.Taskpanes taskpanes1 = new Wetp.Taskpanes();
            taskpanes1.AddNamespaceDeclaration("wetp", "http://schemas.microsoft.com/office/webextensions/taskpanes/2010/11");

            Wetp.WebExtensionTaskpane webExtensionTaskpane1 = new Wetp.WebExtensionTaskpane(){ DockState = "", Visibility = true, Width = 270D, Row = (UInt32Value)1U };

            Wetp.WebExtensionPartReference webExtensionPartReference1 = new Wetp.WebExtensionPartReference(){ Id = "rId1" };
            webExtensionPartReference1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            webExtensionTaskpane1.Append(webExtensionPartReference1);

            Wetp.WebExtensionTaskpane webExtensionTaskpane2 = new Wetp.WebExtensionTaskpane(){ DockState = "", Visibility = true, Width = 270D, Row = (UInt32Value)2U };

            Wetp.WebExtensionPartReference webExtensionPartReference2 = new Wetp.WebExtensionPartReference(){ Id = "rId2" };
            webExtensionPartReference2.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            webExtensionTaskpane2.Append(webExtensionPartReference2);

            taskpanes1.Append(webExtensionTaskpane1);
            taskpanes1.Append(webExtensionTaskpane2);

            webExTaskpanesPart1.Taskpanes = taskpanes1;
        }

        // Generates content of webExtensionPart1.
        private void GenerateWebExtensionPart1Content(WebExtensionPart webExtensionPart1)
        {
            We.WebExtension webExtension1 = new We.WebExtension(){ Id = "{FDBCC95A-4F5D-4EE2-B679-0C399AE7911A}" };
            webExtension1.AddNamespaceDeclaration("we", "http://schemas.microsoft.com/office/webextensions/webextension/2010/11");
            We.WebExtensionStoreReference webExtensionStoreReference1 = new We.WebExtensionStoreReference(){ Id = "JArgil_M3_Taskpane_ActiveX", Version = "15.0", Store = "developer", StoreType = "Registry" };
            We.WebExtensionReferenceList webExtensionReferenceList1 = new We.WebExtensionReferenceList();
            We.WebExtensionPropertyBag webExtensionPropertyBag1 = new We.WebExtensionPropertyBag();
            We.WebExtensionBindingList webExtensionBindingList1 = new We.WebExtensionBindingList();

            We.Snapshot snapshot1 = new We.Snapshot();
            snapshot1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            webExtension1.Append(webExtensionStoreReference1);
            webExtension1.Append(webExtensionReferenceList1);
            webExtension1.Append(webExtensionPropertyBag1);
            webExtension1.Append(webExtensionBindingList1);
            webExtension1.Append(snapshot1);

            webExtensionPart1.WebExtension = webExtension1;
        }

        // Generates content of webExtensionPart2.
        private void GenerateWebExtensionPart2Content(WebExtensionPart webExtensionPart2)
        {
            We.WebExtension webExtension2 = new We.WebExtension(){ Id = "{4C8E485B-015B-4A7A-8E64-00F01CCA9580}" };
            webExtension2.AddNamespaceDeclaration("we", "http://schemas.microsoft.com/office/webextensions/webextension/2010/11");
            We.WebExtensionStoreReference webExtensionStoreReference2 = new We.WebExtensionStoreReference(){ Id = "JArgil_M3_Taskpane_1", Version = "15.0", Store = "developer", StoreType = "Registry" };
            We.WebExtensionReferenceList webExtensionReferenceList2 = new We.WebExtensionReferenceList();
            We.WebExtensionPropertyBag webExtensionPropertyBag2 = new We.WebExtensionPropertyBag();
            We.WebExtensionBindingList webExtensionBindingList2 = new We.WebExtensionBindingList();

            We.Snapshot snapshot2 = new We.Snapshot();
            snapshot2.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            webExtension2.Append(webExtensionStoreReference2);
            webExtension2.Append(webExtensionReferenceList2);
            webExtension2.Append(webExtensionPropertyBag2);
            webExtension2.Append(webExtensionBindingList2);
            webExtension2.Append(snapshot2);

            webExtensionPart2.WebExtension = webExtension2;
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

            X15ac.AbsolutePath absolutePath1 = new X15ac.AbsolutePath(){ Url = "D:\\Users\\dito\\Desktop\\TestDocumentResaver\\OpenXmlApiConversion\\WebExtension\\" };
            absolutePath1.AddNamespaceDeclaration("x15ac", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/ac");

            alternateContentChoice1.Append(absolutePath1);

            alternateContent1.Append(alternateContentChoice1);

            BookViews bookViews1 = new BookViews();
            WorkbookView workbookView1 = new WorkbookView(){ XWindow = 0, YWindow = 0, WindowWidth = (UInt32Value)26940U, WindowHeight = (UInt32Value)15120U };

            bookViews1.Append(workbookView1);

            Sheets sheets1 = new Sheets();
            Sheet sheet1 = new Sheet(){ Name = "Sheet1", SheetId = (UInt32Value)1U, Id = "rId1" };
            Sheet sheet2 = new Sheet(){ Name = "Sheet2", SheetId = (UInt32Value)2U, Id = "rId2" };

            sheets1.Append(sheet1);
            sheets1.Append(sheet2);
            CalculationProperties calculationProperties1 = new CalculationProperties(){ CalculationId = (UInt32Value)152511U };

            WorkbookExtensionList workbookExtensionList1 = new WorkbookExtensionList();

            WorkbookExtension workbookExtension1 = new WorkbookExtension(){ Uri = "{140A7094-0E35-4892-8432-C4D2E57EDEB5}" };
            workbookExtension1.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
            X15.WorkbookProperties workbookProperties2 = new X15.WorkbookProperties(){ ChartTrackingReferenceBase = true };

            workbookExtension1.Append(workbookProperties2);

            workbookExtensionList1.Append(workbookExtension1);

            workbook1.Append(fileVersion1);
            workbook1.Append(workbookProperties1);
            workbook1.Append(alternateContent1);
            workbook1.Append(bookViews1);
            workbook1.Append(sheets1);
            workbook1.Append(calculationProperties1);
            workbook1.Append(workbookExtensionList1);

            workbookPart1.Workbook = workbook1;
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

            A.FontScheme fontScheme1 = new A.FontScheme(){ Name = "Office" };

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

            fontScheme1.Append(majorFont1);
            fontScheme1.Append(minorFont1);

            A.FormatScheme formatScheme1 = new A.FormatScheme(){ Name = "Office" };

            A.FillStyleList fillStyleList1 = new A.FillStyleList();

            A.SolidFill solidFill1 = new A.SolidFill();
            A.SchemeColor schemeColor1 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill1.Append(schemeColor1);

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

            fillStyleList1.Append(solidFill1);
            fillStyleList1.Append(gradientFill1);
            fillStyleList1.Append(gradientFill2);

            A.LineStyleList lineStyleList1 = new A.LineStyleList();

            A.Outline outline1 = new A.Outline(){ Width = 6350, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill2 = new A.SolidFill();
            A.SchemeColor schemeColor8 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill2.Append(schemeColor8);
            A.PresetDash presetDash1 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };
            A.Miter miter1 = new A.Miter(){ Limit = 800000 };

            outline1.Append(solidFill2);
            outline1.Append(presetDash1);
            outline1.Append(miter1);

            A.Outline outline2 = new A.Outline(){ Width = 12700, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill3 = new A.SolidFill();
            A.SchemeColor schemeColor9 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill3.Append(schemeColor9);
            A.PresetDash presetDash2 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };
            A.Miter miter2 = new A.Miter(){ Limit = 800000 };

            outline2.Append(solidFill3);
            outline2.Append(presetDash2);
            outline2.Append(miter2);

            A.Outline outline3 = new A.Outline(){ Width = 19050, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill4 = new A.SolidFill();
            A.SchemeColor schemeColor10 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill4.Append(schemeColor10);
            A.PresetDash presetDash3 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };
            A.Miter miter3 = new A.Miter(){ Limit = 800000 };

            outline3.Append(solidFill4);
            outline3.Append(presetDash3);
            outline3.Append(miter3);

            lineStyleList1.Append(outline1);
            lineStyleList1.Append(outline2);
            lineStyleList1.Append(outline3);

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

            A.SolidFill solidFill5 = new A.SolidFill();
            A.SchemeColor schemeColor11 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill5.Append(schemeColor11);

            A.SolidFill solidFill6 = new A.SolidFill();

            A.SchemeColor schemeColor12 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint5 = new A.Tint(){ Val = 95000 };
            A.SaturationModulation saturationModulation7 = new A.SaturationModulation(){ Val = 170000 };

            schemeColor12.Append(tint5);
            schemeColor12.Append(saturationModulation7);

            solidFill6.Append(schemeColor12);

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

            backgroundFillStyleList1.Append(solidFill5);
            backgroundFillStyleList1.Append(solidFill6);
            backgroundFillStyleList1.Append(gradientFill3);

            formatScheme1.Append(fillStyleList1);
            formatScheme1.Append(lineStyleList1);
            formatScheme1.Append(effectStyleList1);
            formatScheme1.Append(backgroundFillStyleList1);

            themeElements1.Append(colorScheme1);
            themeElements1.Append(fontScheme1);
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

        // Generates content of worksheetPart1.
        private void GenerateWorksheetPart1Content(WorksheetPart worksheetPart1)
        {
            Worksheet worksheet1 = new Worksheet(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "x14ac" }  };
            worksheet1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            worksheet1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            worksheet1.AddNamespaceDeclaration("x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");
            SheetDimension sheetDimension1 = new SheetDimension(){ Reference = "A1" };

            SheetViews sheetViews1 = new SheetViews();

            SheetView sheetView1 = new SheetView(){ WorkbookViewId = (UInt32Value)0U };
            Selection selection1 = new Selection(){ ActiveCell = "L27", SequenceOfReferences = new ListValue<StringValue>() { InnerText = "L27" } };

            sheetView1.Append(selection1);

            sheetViews1.Append(sheetView1);
            SheetFormatProperties sheetFormatProperties1 = new SheetFormatProperties(){ DefaultRowHeight = 15D, DyDescent = 0.25D };
            SheetData sheetData1 = new SheetData();
            PageMargins pageMargins1 = new PageMargins(){ Left = 0.7D, Right = 0.7D, Top = 0.75D, Bottom = 0.75D, Header = 0.3D, Footer = 0.3D };
            S.Drawing drawing1 = new S.Drawing(){ Id = "rId1" };

            worksheet1.Append(sheetDimension1);
            worksheet1.Append(sheetViews1);
            worksheet1.Append(sheetFormatProperties1);
            worksheet1.Append(sheetData1);
            worksheet1.Append(pageMargins1);
            worksheet1.Append(drawing1);

            worksheetPart1.Worksheet = worksheet1;
        }

        // Generates content of drawingsPart1.
        private void GenerateDrawingsPart1Content(DrawingsPart drawingsPart1)
        {
            Xdr.WorksheetDrawing worksheetDrawing1 = new Xdr.WorksheetDrawing();
            worksheetDrawing1.AddNamespaceDeclaration("xdr", "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing");
            worksheetDrawing1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            Xdr.TwoCellAnchor twoCellAnchor1 = new Xdr.TwoCellAnchor();

            Xdr.FromMarker fromMarker1 = new Xdr.FromMarker();
            Xdr.ColumnId columnId1 = new Xdr.ColumnId();
            columnId1.Text = "7";
            Xdr.ColumnOffset columnOffset1 = new Xdr.ColumnOffset();
            columnOffset1.Text = "576262";
            Xdr.RowId rowId1 = new Xdr.RowId();
            rowId1.Text = "2";
            Xdr.RowOffset rowOffset1 = new Xdr.RowOffset();
            rowOffset1.Text = "109537";

            fromMarker1.Append(columnId1);
            fromMarker1.Append(columnOffset1);
            fromMarker1.Append(rowId1);
            fromMarker1.Append(rowOffset1);

            Xdr.ToMarker toMarker1 = new Xdr.ToMarker();
            Xdr.ColumnId columnId2 = new Xdr.ColumnId();
            columnId2.Text = "14";
            Xdr.ColumnOffset columnOffset2 = new Xdr.ColumnOffset();
            columnOffset2.Text = "119062";
            Xdr.RowId rowId2 = new Xdr.RowId();
            rowId2.Text = "22";
            Xdr.RowOffset rowOffset2 = new Xdr.RowOffset();
            rowOffset2.Text = "109537";

            toMarker1.Append(columnId2);
            toMarker1.Append(columnOffset2);
            toMarker1.Append(rowId2);
            toMarker1.Append(rowOffset2);

            AlternateContent alternateContent2 = new AlternateContent();
            alternateContent2.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");

            AlternateContentChoice alternateContentChoice2 = new AlternateContentChoice(){ Requires = "we" };
            alternateContentChoice2.AddNamespaceDeclaration("we", "http://schemas.microsoft.com/office/webextensions/webextension/2010/11");

            Xdr.GraphicFrame graphicFrame1 = new Xdr.GraphicFrame(){ Macro = "" };

            Xdr.NonVisualGraphicFrameProperties nonVisualGraphicFrameProperties1 = new Xdr.NonVisualGraphicFrameProperties();
            Xdr.NonVisualDrawingProperties nonVisualDrawingProperties1 = new Xdr.NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Agave 1" };

            Xdr.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties1 = new Xdr.NonVisualGraphicFrameDrawingProperties();
            A.GraphicFrameLocks graphicFrameLocks1 = new A.GraphicFrameLocks(){ NoGrouping = true };

            nonVisualGraphicFrameDrawingProperties1.Append(graphicFrameLocks1);

            nonVisualGraphicFrameProperties1.Append(nonVisualDrawingProperties1);
            nonVisualGraphicFrameProperties1.Append(nonVisualGraphicFrameDrawingProperties1);

            Xdr.Transform transform1 = new Xdr.Transform();
            A.Offset offset1 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents1 = new A.Extents(){ Cx = 0L, Cy = 0L };

            transform1.Append(offset1);
            transform1.Append(extents1);

            A.Graphic graphic1 = new A.Graphic();

            A.GraphicData graphicData1 = new A.GraphicData(){ Uri = "http://schemas.microsoft.com/office/webextensions/webextension/2010/11" };

            We.WebExtensionReference webExtensionReference1 = new We.WebExtensionReference(){ Id = "rId1" };
            webExtensionReference1.AddNamespaceDeclaration("we", "http://schemas.microsoft.com/office/webextensions/webextension/2010/11");
            webExtensionReference1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            graphicData1.Append(webExtensionReference1);

            graphic1.Append(graphicData1);

            graphicFrame1.Append(nonVisualGraphicFrameProperties1);
            graphicFrame1.Append(transform1);
            graphicFrame1.Append(graphic1);

            alternateContentChoice2.Append(graphicFrame1);

            AlternateContentFallback alternateContentFallback1 = new AlternateContentFallback();

            Xdr.Picture picture1 = new Xdr.Picture();

            Xdr.NonVisualPictureProperties nonVisualPictureProperties1 = new Xdr.NonVisualPictureProperties();
            Xdr.NonVisualDrawingProperties nonVisualDrawingProperties2 = new Xdr.NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Agave 1" };
            Xdr.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties1 = new Xdr.NonVisualPictureDrawingProperties();

            nonVisualPictureProperties1.Append(nonVisualDrawingProperties2);
            nonVisualPictureProperties1.Append(nonVisualPictureDrawingProperties1);

            Xdr.BlipFill blipFill1 = new Xdr.BlipFill();

            A.Blip blip1 = new A.Blip(){ Embed = "rId2" };
            blip1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            A.Stretch stretch1 = new A.Stretch();
            A.FillRectangle fillRectangle1 = new A.FillRectangle();

            stretch1.Append(fillRectangle1);

            blipFill1.Append(blip1);
            blipFill1.Append(stretch1);

            Xdr.ShapeProperties shapeProperties1 = new Xdr.ShapeProperties();

            A.PresetGeometry presetGeometry1 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList1 = new A.AdjustValueList();

            presetGeometry1.Append(adjustValueList1);

            shapeProperties1.Append(presetGeometry1);

            picture1.Append(nonVisualPictureProperties1);
            picture1.Append(blipFill1);
            picture1.Append(shapeProperties1);

            alternateContentFallback1.Append(picture1);

            alternateContent2.Append(alternateContentChoice2);
            alternateContent2.Append(alternateContentFallback1);
            Xdr.ClientData clientData1 = new Xdr.ClientData();

            twoCellAnchor1.Append(fromMarker1);
            twoCellAnchor1.Append(toMarker1);
            twoCellAnchor1.Append(alternateContent2);
            twoCellAnchor1.Append(clientData1);

            Xdr.TwoCellAnchor twoCellAnchor2 = new Xdr.TwoCellAnchor();

            Xdr.FromMarker fromMarker2 = new Xdr.FromMarker();
            Xdr.ColumnId columnId3 = new Xdr.ColumnId();
            columnId3.Text = "0";
            Xdr.ColumnOffset columnOffset3 = new Xdr.ColumnOffset();
            columnOffset3.Text = "119062";
            Xdr.RowId rowId3 = new Xdr.RowId();
            rowId3.Text = "3";
            Xdr.RowOffset rowOffset3 = new Xdr.RowOffset();
            rowOffset3.Text = "42862";

            fromMarker2.Append(columnId3);
            fromMarker2.Append(columnOffset3);
            fromMarker2.Append(rowId3);
            fromMarker2.Append(rowOffset3);

            Xdr.ToMarker toMarker2 = new Xdr.ToMarker();
            Xdr.ColumnId columnId4 = new Xdr.ColumnId();
            columnId4.Text = "6";
            Xdr.ColumnOffset columnOffset4 = new Xdr.ColumnOffset();
            columnOffset4.Text = "271462";
            Xdr.RowId rowId4 = new Xdr.RowId();
            rowId4.Text = "23";
            Xdr.RowOffset rowOffset4 = new Xdr.RowOffset();
            rowOffset4.Text = "42862";

            toMarker2.Append(columnId4);
            toMarker2.Append(columnOffset4);
            toMarker2.Append(rowId4);
            toMarker2.Append(rowOffset4);

            AlternateContent alternateContent3 = new AlternateContent();
            alternateContent3.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");

            AlternateContentChoice alternateContentChoice3 = new AlternateContentChoice(){ Requires = "we" };
            alternateContentChoice3.AddNamespaceDeclaration("we", "http://schemas.microsoft.com/office/webextensions/webextension/2010/11");

            Xdr.GraphicFrame graphicFrame2 = new Xdr.GraphicFrame(){ Macro = "" };

            Xdr.NonVisualGraphicFrameProperties nonVisualGraphicFrameProperties2 = new Xdr.NonVisualGraphicFrameProperties();
            Xdr.NonVisualDrawingProperties nonVisualDrawingProperties3 = new Xdr.NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Agave 2" };

            Xdr.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties2 = new Xdr.NonVisualGraphicFrameDrawingProperties();
            A.GraphicFrameLocks graphicFrameLocks2 = new A.GraphicFrameLocks(){ NoGrouping = true };

            nonVisualGraphicFrameDrawingProperties2.Append(graphicFrameLocks2);

            nonVisualGraphicFrameProperties2.Append(nonVisualDrawingProperties3);
            nonVisualGraphicFrameProperties2.Append(nonVisualGraphicFrameDrawingProperties2);

            Xdr.Transform transform2 = new Xdr.Transform();
            A.Offset offset2 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents2 = new A.Extents(){ Cx = 0L, Cy = 0L };

            transform2.Append(offset2);
            transform2.Append(extents2);

            A.Graphic graphic2 = new A.Graphic();

            A.GraphicData graphicData2 = new A.GraphicData(){ Uri = "http://schemas.microsoft.com/office/webextensions/webextension/2010/11" };

            We.WebExtensionReference webExtensionReference2 = new We.WebExtensionReference(){ Id = "rId3" };
            webExtensionReference2.AddNamespaceDeclaration("we", "http://schemas.microsoft.com/office/webextensions/webextension/2010/11");
            webExtensionReference2.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            graphicData2.Append(webExtensionReference2);

            graphic2.Append(graphicData2);

            graphicFrame2.Append(nonVisualGraphicFrameProperties2);
            graphicFrame2.Append(transform2);
            graphicFrame2.Append(graphic2);

            alternateContentChoice3.Append(graphicFrame2);

            AlternateContentFallback alternateContentFallback2 = new AlternateContentFallback();

            Xdr.Picture picture2 = new Xdr.Picture();

            Xdr.NonVisualPictureProperties nonVisualPictureProperties2 = new Xdr.NonVisualPictureProperties();
            Xdr.NonVisualDrawingProperties nonVisualDrawingProperties4 = new Xdr.NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Agave 2" };
            Xdr.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties2 = new Xdr.NonVisualPictureDrawingProperties();

            nonVisualPictureProperties2.Append(nonVisualDrawingProperties4);
            nonVisualPictureProperties2.Append(nonVisualPictureDrawingProperties2);

            Xdr.BlipFill blipFill2 = new Xdr.BlipFill();

            A.Blip blip2 = new A.Blip(){ Embed = "rId4" };
            blip2.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            A.Stretch stretch2 = new A.Stretch();
            A.FillRectangle fillRectangle2 = new A.FillRectangle();

            stretch2.Append(fillRectangle2);

            blipFill2.Append(blip2);
            blipFill2.Append(stretch2);

            Xdr.ShapeProperties shapeProperties2 = new Xdr.ShapeProperties();

            A.PresetGeometry presetGeometry2 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList2 = new A.AdjustValueList();

            presetGeometry2.Append(adjustValueList2);

            shapeProperties2.Append(presetGeometry2);

            picture2.Append(nonVisualPictureProperties2);
            picture2.Append(blipFill2);
            picture2.Append(shapeProperties2);

            alternateContentFallback2.Append(picture2);

            alternateContent3.Append(alternateContentChoice3);
            alternateContent3.Append(alternateContentFallback2);
            Xdr.ClientData clientData2 = new Xdr.ClientData();

            twoCellAnchor2.Append(fromMarker2);
            twoCellAnchor2.Append(toMarker2);
            twoCellAnchor2.Append(alternateContent3);
            twoCellAnchor2.Append(clientData2);

            worksheetDrawing1.Append(twoCellAnchor1);
            worksheetDrawing1.Append(twoCellAnchor2);

            drawingsPart1.WorksheetDrawing = worksheetDrawing1;
        }

        // Generates content of webExtensionPart3.
        private void GenerateWebExtensionPart3Content(WebExtensionPart webExtensionPart3)
        {
            We.WebExtension webExtension3 = new We.WebExtension(){ Id = "{ACAC7A36-8FF8-4343-90BB-FD5DAAB89B97}" };
            webExtension3.AddNamespaceDeclaration("we", "http://schemas.microsoft.com/office/webextensions/webextension/2010/11");
            We.WebExtensionStoreReference webExtensionStoreReference3 = new We.WebExtensionStoreReference(){ Id = "JArgil_M3_InContent_1", Version = "15.0", Store = "developer", StoreType = "Registry" };
            We.WebExtensionReferenceList webExtensionReferenceList3 = new We.WebExtensionReferenceList();
            We.WebExtensionPropertyBag webExtensionPropertyBag3 = new We.WebExtensionPropertyBag();
            We.WebExtensionBindingList webExtensionBindingList3 = new We.WebExtensionBindingList();

            We.Snapshot snapshot3 = new We.Snapshot(){ Embed = "rId1" };
            snapshot3.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            webExtension3.Append(webExtensionStoreReference3);
            webExtension3.Append(webExtensionReferenceList3);
            webExtension3.Append(webExtensionPropertyBag3);
            webExtension3.Append(webExtensionBindingList3);
            webExtension3.Append(snapshot3);

            webExtensionPart3.WebExtension = webExtension3;
        }

        // Generates content of imagePart1.
        private void GenerateImagePart1Content(ImagePart imagePart1)
        {
            System.IO.Stream data = GetBinaryDataStream(imagePart1Data);
            imagePart1.FeedData(data);
            data.Close();
        }

        // Generates content of imagePart2.
        private void GenerateImagePart2Content(ImagePart imagePart2)
        {
            System.IO.Stream data = GetBinaryDataStream(imagePart2Data);
            imagePart2.FeedData(data);
            data.Close();
        }

        // Generates content of webExtensionPart4.
        private void GenerateWebExtensionPart4Content(WebExtensionPart webExtensionPart4)
        {
            We.WebExtension webExtension4 = new We.WebExtension(){ Id = "{CA0F8276-83E3-4B12-8C92-C5B35FC35721}" };
            webExtension4.AddNamespaceDeclaration("we", "http://schemas.microsoft.com/office/webextensions/webextension/2010/11");
            We.WebExtensionStoreReference webExtensionStoreReference4 = new We.WebExtensionStoreReference(){ Id = "JArgil_M3_InContent_ActiveX", Version = "15.0", Store = "developer", StoreType = "Registry" };
            We.WebExtensionReferenceList webExtensionReferenceList4 = new We.WebExtensionReferenceList();
            We.WebExtensionPropertyBag webExtensionPropertyBag4 = new We.WebExtensionPropertyBag();
            We.WebExtensionBindingList webExtensionBindingList4 = new We.WebExtensionBindingList();

            We.Snapshot snapshot4 = new We.Snapshot(){ Embed = "rId1" };
            snapshot4.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            webExtension4.Append(webExtensionStoreReference4);
            webExtension4.Append(webExtensionReferenceList4);
            webExtension4.Append(webExtensionPropertyBag4);
            webExtension4.Append(webExtensionBindingList4);
            webExtension4.Append(snapshot4);

            webExtensionPart4.WebExtension = webExtension4;
        }

        // Generates content of worksheetPart2.
        private void GenerateWorksheetPart2Content(WorksheetPart worksheetPart2)
        {
            Worksheet worksheet2 = new Worksheet(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "x14ac" }  };
            worksheet2.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            worksheet2.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            worksheet2.AddNamespaceDeclaration("x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");
            SheetDimension sheetDimension2 = new SheetDimension(){ Reference = "A1" };

            SheetViews sheetViews2 = new SheetViews();

            SheetView sheetView2 = new SheetView(){ TabSelected = true, TopLeftCell = "A4", WorkbookViewId = (UInt32Value)0U };
            Selection selection2 = new Selection(){ ActiveCell = "K19", SequenceOfReferences = new ListValue<StringValue>() { InnerText = "K19" } };

            sheetView2.Append(selection2);

            sheetViews2.Append(sheetView2);
            SheetFormatProperties sheetFormatProperties2 = new SheetFormatProperties(){ DefaultRowHeight = 15D, DyDescent = 0.25D };
            SheetData sheetData2 = new SheetData();
            PageMargins pageMargins2 = new PageMargins(){ Left = 0.7D, Right = 0.7D, Top = 0.75D, Bottom = 0.75D, Header = 0.3D, Footer = 0.3D };
            S.Drawing drawing2 = new S.Drawing(){ Id = "rId1" };

            worksheet2.Append(sheetDimension2);
            worksheet2.Append(sheetViews2);
            worksheet2.Append(sheetFormatProperties2);
            worksheet2.Append(sheetData2);
            worksheet2.Append(pageMargins2);
            worksheet2.Append(drawing2);

            worksheetPart2.Worksheet = worksheet2;
        }

        // Generates content of drawingsPart2.
        private void GenerateDrawingsPart2Content(DrawingsPart drawingsPart2)
        {
            Xdr.WorksheetDrawing worksheetDrawing2 = new Xdr.WorksheetDrawing();
            worksheetDrawing2.AddNamespaceDeclaration("xdr", "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing");
            worksheetDrawing2.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            Xdr.TwoCellAnchor twoCellAnchor3 = new Xdr.TwoCellAnchor();

            Xdr.FromMarker fromMarker3 = new Xdr.FromMarker();
            Xdr.ColumnId columnId5 = new Xdr.ColumnId();
            columnId5.Text = "1";
            Xdr.ColumnOffset columnOffset5 = new Xdr.ColumnOffset();
            columnOffset5.Text = "33337";
            Xdr.RowId rowId5 = new Xdr.RowId();
            rowId5.Text = "2";
            Xdr.RowOffset rowOffset5 = new Xdr.RowOffset();
            rowOffset5.Text = "61912";

            fromMarker3.Append(columnId5);
            fromMarker3.Append(columnOffset5);
            fromMarker3.Append(rowId5);
            fromMarker3.Append(rowOffset5);

            Xdr.ToMarker toMarker3 = new Xdr.ToMarker();
            Xdr.ColumnId columnId6 = new Xdr.ColumnId();
            columnId6.Text = "7";
            Xdr.ColumnOffset columnOffset6 = new Xdr.ColumnOffset();
            columnOffset6.Text = "185737";
            Xdr.RowId rowId6 = new Xdr.RowId();
            rowId6.Text = "22";
            Xdr.RowOffset rowOffset6 = new Xdr.RowOffset();
            rowOffset6.Text = "61912";

            toMarker3.Append(columnId6);
            toMarker3.Append(columnOffset6);
            toMarker3.Append(rowId6);
            toMarker3.Append(rowOffset6);

            AlternateContent alternateContent4 = new AlternateContent();
            alternateContent4.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");

            AlternateContentChoice alternateContentChoice4 = new AlternateContentChoice(){ Requires = "we" };
            alternateContentChoice4.AddNamespaceDeclaration("we", "http://schemas.microsoft.com/office/webextensions/webextension/2010/11");

            Xdr.GraphicFrame graphicFrame3 = new Xdr.GraphicFrame(){ Macro = "" };

            Xdr.NonVisualGraphicFrameProperties nonVisualGraphicFrameProperties3 = new Xdr.NonVisualGraphicFrameProperties();
            Xdr.NonVisualDrawingProperties nonVisualDrawingProperties5 = new Xdr.NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Agave 1" };

            Xdr.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties3 = new Xdr.NonVisualGraphicFrameDrawingProperties();
            A.GraphicFrameLocks graphicFrameLocks3 = new A.GraphicFrameLocks(){ NoGrouping = true };

            nonVisualGraphicFrameDrawingProperties3.Append(graphicFrameLocks3);

            nonVisualGraphicFrameProperties3.Append(nonVisualDrawingProperties5);
            nonVisualGraphicFrameProperties3.Append(nonVisualGraphicFrameDrawingProperties3);

            Xdr.Transform transform3 = new Xdr.Transform();
            A.Offset offset3 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents3 = new A.Extents(){ Cx = 0L, Cy = 0L };

            transform3.Append(offset3);
            transform3.Append(extents3);

            A.Graphic graphic3 = new A.Graphic();

            A.GraphicData graphicData3 = new A.GraphicData(){ Uri = "http://schemas.microsoft.com/office/webextensions/webextension/2010/11" };

            We.WebExtensionReference webExtensionReference3 = new We.WebExtensionReference(){ Id = "rId1" };
            webExtensionReference3.AddNamespaceDeclaration("we", "http://schemas.microsoft.com/office/webextensions/webextension/2010/11");
            webExtensionReference3.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            graphicData3.Append(webExtensionReference3);

            graphic3.Append(graphicData3);

            graphicFrame3.Append(nonVisualGraphicFrameProperties3);
            graphicFrame3.Append(transform3);
            graphicFrame3.Append(graphic3);

            alternateContentChoice4.Append(graphicFrame3);

            AlternateContentFallback alternateContentFallback3 = new AlternateContentFallback();

            Xdr.Picture picture3 = new Xdr.Picture();

            Xdr.NonVisualPictureProperties nonVisualPictureProperties3 = new Xdr.NonVisualPictureProperties();
            Xdr.NonVisualDrawingProperties nonVisualDrawingProperties6 = new Xdr.NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Agave 1" };
            Xdr.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties3 = new Xdr.NonVisualPictureDrawingProperties();

            nonVisualPictureProperties3.Append(nonVisualDrawingProperties6);
            nonVisualPictureProperties3.Append(nonVisualPictureDrawingProperties3);

            Xdr.BlipFill blipFill3 = new Xdr.BlipFill();

            A.Blip blip3 = new A.Blip(){ Embed = "rId2" };
            blip3.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            A.Stretch stretch3 = new A.Stretch();
            A.FillRectangle fillRectangle3 = new A.FillRectangle();

            stretch3.Append(fillRectangle3);

            blipFill3.Append(blip3);
            blipFill3.Append(stretch3);

            Xdr.ShapeProperties shapeProperties3 = new Xdr.ShapeProperties();

            A.PresetGeometry presetGeometry3 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList3 = new A.AdjustValueList();

            presetGeometry3.Append(adjustValueList3);

            shapeProperties3.Append(presetGeometry3);

            picture3.Append(nonVisualPictureProperties3);
            picture3.Append(blipFill3);
            picture3.Append(shapeProperties3);

            alternateContentFallback3.Append(picture3);

            alternateContent4.Append(alternateContentChoice4);
            alternateContent4.Append(alternateContentFallback3);
            Xdr.ClientData clientData3 = new Xdr.ClientData();

            twoCellAnchor3.Append(fromMarker3);
            twoCellAnchor3.Append(toMarker3);
            twoCellAnchor3.Append(alternateContent4);
            twoCellAnchor3.Append(clientData3);

            worksheetDrawing2.Append(twoCellAnchor3);

            drawingsPart2.WorksheetDrawing = worksheetDrawing2;
        }

        // Generates content of imagePart3.
        private void GenerateImagePart3Content(ImagePart imagePart3)
        {
            System.IO.Stream data = GetBinaryDataStream(imagePart3Data);
            imagePart3.FeedData(data);
            data.Close();
        }

        // Generates content of webExtensionPart5.
        private void GenerateWebExtensionPart5Content(WebExtensionPart webExtensionPart5)
        {
            We.WebExtension webExtension5 = new We.WebExtension(){ Id = "{E60613D7-9E0F-492D-BBAD-04FAEFBE5A0B}" };
            webExtension5.AddNamespaceDeclaration("we", "http://schemas.microsoft.com/office/webextensions/webextension/2010/11");
            We.WebExtensionStoreReference webExtensionStoreReference5 = new We.WebExtensionStoreReference(){ Id = "JArgil_M3_InContent_1", Version = "15.0", Store = "developer", StoreType = "Registry" };
            We.WebExtensionReferenceList webExtensionReferenceList5 = new We.WebExtensionReferenceList();
            We.WebExtensionPropertyBag webExtensionPropertyBag5 = new We.WebExtensionPropertyBag();
            We.WebExtensionBindingList webExtensionBindingList5 = new We.WebExtensionBindingList();

            We.Snapshot snapshot5 = new We.Snapshot(){ Embed = "rId1" };
            snapshot5.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            webExtension5.Append(webExtensionStoreReference5);
            webExtension5.Append(webExtensionReferenceList5);
            webExtension5.Append(webExtensionPropertyBag5);
            webExtension5.Append(webExtensionBindingList5);
            webExtension5.Append(snapshot5);

            webExtensionPart5.WebExtension = webExtension5;
        }

        // Generates content of workbookStylesPart1.
        private void GenerateWorkbookStylesPart1Content(WorkbookStylesPart workbookStylesPart1)
        {
            Stylesheet stylesheet1 = new Stylesheet(){ MCAttributes = new MarkupCompatibilityAttributes(){ Ignorable = "x14ac" }  };
            stylesheet1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            stylesheet1.AddNamespaceDeclaration("x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");

            Fonts fonts1 = new Fonts(){ Count = (UInt32Value)1U, KnownFonts = true };

            Font font1 = new Font();
            FontSize fontSize1 = new FontSize(){ Val = 11D };
            Color color1 = new Color(){ Theme = (UInt32Value)1U };
            FontName fontName1 = new FontName(){ Val = "Calibri" };
            FontFamilyNumbering fontFamilyNumbering1 = new FontFamilyNumbering(){ Val = 2 };
            FontScheme fontScheme2 = new FontScheme(){ Val = FontSchemeValues.Minor };

            font1.Append(fontSize1);
            font1.Append(color1);
            font1.Append(fontName1);
            font1.Append(fontFamilyNumbering1);
            font1.Append(fontScheme2);

            fonts1.Append(font1);

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

            cellStyleFormats1.Append(cellFormat1);

            CellFormats cellFormats1 = new CellFormats(){ Count = (UInt32Value)1U };
            CellFormat cellFormat2 = new CellFormat(){ NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U };

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
            vTInt321.Text = "2";

            variant2.Append(vTInt321);

            vTVector1.Append(variant1);
            vTVector1.Append(variant2);

            headingPairs1.Append(vTVector1);

            Ap.TitlesOfParts titlesOfParts1 = new Ap.TitlesOfParts();

            Vt.VTVector vTVector2 = new Vt.VTVector(){ BaseType = Vt.VectorBaseValues.Lpstr, Size = (UInt32Value)2U };
            Vt.VTLPSTR vTLPSTR2 = new Vt.VTLPSTR();
            vTLPSTR2.Text = "Sheet1";
            Vt.VTLPSTR vTLPSTR3 = new Vt.VTLPSTR();
            vTLPSTR3.Text = "Sheet2";

            vTVector2.Append(vTLPSTR2);
            vTVector2.Append(vTLPSTR3);

            titlesOfParts1.Append(vTVector2);
            Ap.Company company1 = new Ap.Company();
            company1.Text = "Microsoft Corporation";
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
            properties1.Append(company1);
            properties1.Append(linksUpToDate1);
            properties1.Append(sharedDocument1);
            properties1.Append(hyperlinksChanged1);
            properties1.Append(applicationVersion1);

            extendedFilePropertiesPart1.Properties = properties1;
        }

        private void SetPackageProperties(OpenXmlPackage document)
        {
            document.PackageProperties.Creator = "Max Levy";
            document.PackageProperties.Created = System.Xml.XmlConvert.ToDateTime("2012-04-12T01:09:38Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2012-10-03T08:49:57Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.LastModifiedBy = "Dan Ito";
        }

        #region Binary Data
        private string imagePart1Data = "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";

        private string imagePart2Data = "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";

        private string imagePart3Data = "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";

        private System.IO.Stream GetBinaryDataStream(string base64String)
        {
            return new System.IO.MemoryStream(System.Convert.FromBase64String(base64String));
        }

        #endregion

    }
}
