// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#pragma warning disable OOXML0005

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.IO;

using P = DocumentFormat.OpenXml.Presentation;
using S = DocumentFormat.OpenXml.Spreadsheet;
using W = DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml.Benchmarks
{
    public class ForwardOnlyBenchmarks
    {
        [Benchmark(Baseline = true)]
        public void Word_Simple_Standard()
        {
            using var stream = new NonwritingStream();
            using var doc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);
            doc.AddMainDocumentPart().Document = new Document(
                new Body(
                    new Paragraph(
                        new W.Run(new W.Text("Hello, world!")))));
        }

        [Benchmark]
        public void Word_Simple_ForwardOnly()
        {
            using var stream = new NonwritingStream();
            using var writer = WordprocessingDocument.CreateForwardOnly(stream, WordprocessingDocumentType.Document);
            writer.WritePart(
                new Uri("/word/document.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml",
                new Document(
                    new Body(
                        new Paragraph(
                            new W.Run(new W.Text("Hello, world!"))))));
        }

        [Benchmark]
        public void Word_Medium_Standard()
        {
            using var stream = new NonwritingStream();
            using var doc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            var body = new Body();

            for (int i = 0; i < 20; i++)
            {
                body.AppendChild(new Paragraph(
                    new ParagraphProperties(new W.Bold()),
                    new W.Run(
                        new W.RunProperties(new W.Italic()),
                        new W.Text("Paragraph " + i))));
            }

            doc.AddMainDocumentPart().Document = new Document(body);
        }

        [Benchmark]
        public void Word_Medium_ForwardOnly()
        {
            using var stream = new NonwritingStream();
            using var writer = WordprocessingDocument.CreateForwardOnly(stream, WordprocessingDocumentType.Document);

            var body = new Body();

            for (int i = 0; i < 20; i++)
            {
                body.AppendChild(new Paragraph(
                    new ParagraphProperties(new W.Bold()),
                    new W.Run(
                        new W.RunProperties(new W.Italic()),
                        new W.Text("Paragraph " + i))));
            }

            writer.WritePart(
                new Uri("/word/document.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml",
                new Document(body));
        }

        [Benchmark]
        public void Word_Complex_Standard()
        {
            using var stream = new NonwritingStream();
            using var doc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            var mainPart = doc.AddMainDocumentPart();

            var body = new Body();

            for (int i = 0; i < 100; i++)
            {
                body.AppendChild(new Paragraph(
                    new ParagraphProperties(
                        new ParagraphStyleId { Val = "Heading1" }),
                    new W.Run(
                        new W.RunProperties(
                            new W.Bold(),
                            new W.FontSize { Val = "28" }),
                        new W.Text("Section " + i)),
                    new W.Run(
                        new W.Break()),
                    new W.Run(
                        new W.Text("Content for section " + i + " with some additional text to make it realistic."))));
            }

            mainPart.Document = new Document(body);

            var stylesPart = mainPart.AddNewPart<StyleDefinitionsPart>();
            stylesPart.Styles = new Styles(
                new Style(
                    new StyleName { Val = "heading 1" },
                    new BasedOn { Val = "Normal" })
                { Type = StyleValues.Paragraph, StyleId = "Heading1" });
        }

        [Benchmark]
        public void Word_Complex_ForwardOnly()
        {
            using var stream = new NonwritingStream();
            using var writer = WordprocessingDocument.CreateForwardOnly(stream, WordprocessingDocumentType.Document);

            var body = new Body();

            for (int i = 0; i < 100; i++)
            {
                body.AppendChild(new Paragraph(
                    new ParagraphProperties(
                        new ParagraphStyleId { Val = "Heading1" }),
                    new W.Run(
                        new W.RunProperties(
                            new W.Bold(),
                            new W.FontSize { Val = "28" }),
                        new W.Text("Section " + i)),
                    new W.Run(
                        new W.Break()),
                    new W.Run(
                        new W.Text("Content for section " + i + " with some additional text to make it realistic."))));
            }

            var relationships = new[]
            {
                new PartRelationship(
                    new Uri("styles.xml", UriKind.Relative),
                    "http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles",
                    id: "rId1"),
            };

            writer.WritePart(
                new Uri("/word/document.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml",
                new Document(body),
                relationships);

            writer.WritePart(
                new Uri("/word/styles.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.wordprocessingml.styles+xml",
                new Styles(
                    new Style(
                        new StyleName { Val = "heading 1" },
                        new BasedOn { Val = "Normal" })
                    { Type = StyleValues.Paragraph, StyleId = "Heading1" }));
        }

        [Benchmark]
        public void Spreadsheet_Simple_Standard()
        {
            using var stream = new NonwritingStream();
            using var doc = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook);

            var workbookPart = doc.AddWorkbookPart();
            var sheetPart = workbookPart.AddNewPart<WorksheetPart>();
            sheetPart.Worksheet = new Worksheet(
                new SheetData(
                    new Row(
                        new Cell { CellValue = new CellValue("Hello"), DataType = CellValues.String })));

            workbookPart.Workbook = new Workbook(
                new Sheets(
                    new Sheet { Name = "Sheet1", SheetId = 1, Id = workbookPart.GetIdOfPart(sheetPart) }));
        }

        [Benchmark]
        public void Spreadsheet_Simple_ForwardOnly()
        {
            using var stream = new NonwritingStream();
            using var writer = SpreadsheetDocument.CreateForwardOnly(stream, SpreadsheetDocumentType.Workbook);

            writer.WritePart(
                new Uri("/xl/worksheets/sheet1.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml",
                new Worksheet(
                    new SheetData(
                        new Row(
                            new Cell { CellValue = new CellValue("Hello"), DataType = CellValues.String }))));

            writer.WritePart(
                new Uri("/xl/workbook.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml",
                new Workbook(
                    new Sheets(
                        new Sheet { Name = "Sheet1", SheetId = 1, Id = "rId1" })),
                new[]
                {
                    new PartRelationship(
                        new Uri("worksheets/sheet1.xml", UriKind.Relative),
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet",
                        id: "rId1"),
                });
        }

        [Benchmark]
        public void Spreadsheet_Medium_Standard()
        {
            using var stream = new NonwritingStream();
            using var doc = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook);

            var workbookPart = doc.AddWorkbookPart();
            var sheetPart = workbookPart.AddNewPart<WorksheetPart>();

            var sheetData = new SheetData();

            for (uint r = 1; r <= 100; r++)
            {
                var row = new Row { RowIndex = r };

                for (int c = 0; c < 10; c++)
                {
                    row.AppendChild(new Cell
                    {
                        CellValue = new CellValue(((r * 10) + c).ToString()),
                        DataType = CellValues.Number,
                    });
                }

                sheetData.AppendChild(row);
            }

            sheetPart.Worksheet = new Worksheet(sheetData);

            workbookPart.Workbook = new Workbook(
                new Sheets(
                    new Sheet { Name = "Sheet1", SheetId = 1, Id = workbookPart.GetIdOfPart(sheetPart) }));
        }

        [Benchmark]
        public void Spreadsheet_Medium_ForwardOnly()
        {
            using var stream = new NonwritingStream();
            using var writer = SpreadsheetDocument.CreateForwardOnly(stream, SpreadsheetDocumentType.Workbook);

            var sheetData = new SheetData();

            for (uint r = 1; r <= 100; r++)
            {
                var row = new Row { RowIndex = r };

                for (int c = 0; c < 10; c++)
                {
                    row.AppendChild(new Cell
                    {
                        CellValue = new CellValue(((r * 10) + c).ToString()),
                        DataType = CellValues.Number,
                    });
                }

                sheetData.AppendChild(row);
            }

            writer.WritePart(
                new Uri("/xl/worksheets/sheet1.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml",
                new Worksheet(sheetData));

            writer.WritePart(
                new Uri("/xl/workbook.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml",
                new Workbook(
                    new Sheets(
                        new Sheet { Name = "Sheet1", SheetId = 1, Id = "rId1" })),
                new[]
                {
                    new PartRelationship(
                        new Uri("worksheets/sheet1.xml", UriKind.Relative),
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet",
                        id: "rId1"),
                });
        }

        [Benchmark]
        public void Spreadsheet_Complex_Standard()
        {
            using var stream = new NonwritingStream();
            using var doc = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook);

            var workbookPart = doc.AddWorkbookPart();
            var sheets = new Sheets();

            for (int s = 0; s < 3; s++)
            {
                var sheetPart = workbookPart.AddNewPart<WorksheetPart>();

                var sheetData = new SheetData();

                for (uint r = 1; r <= 500; r++)
                {
                    var row = new Row { RowIndex = r };

                    for (int c = 0; c < 10; c++)
                    {
                        row.AppendChild(new Cell
                        {
                            CellValue = new CellValue(((s * 5000) + (r * 10) + c).ToString()),
                            DataType = CellValues.Number,
                        });
                    }

                    sheetData.AppendChild(row);
                }

                sheetPart.Worksheet = new Worksheet(sheetData);

                sheets.AppendChild(new Sheet
                {
                    Name = "Sheet" + (s + 1),
                    SheetId = (uint)(s + 1),
                    Id = workbookPart.GetIdOfPart(sheetPart),
                });
            }

            workbookPart.Workbook = new Workbook(sheets);
        }

        [Benchmark]
        public void Spreadsheet_Complex_ForwardOnly()
        {
            using var stream = new NonwritingStream();
            using var writer = SpreadsheetDocument.CreateForwardOnly(stream, SpreadsheetDocumentType.Workbook);

            var sheetRels = new PartRelationship[3];

            for (int s = 0; s < 3; s++)
            {
                var sheetData = new SheetData();

                for (uint r = 1; r <= 500; r++)
                {
                    var row = new Row { RowIndex = r };

                    for (int c = 0; c < 10; c++)
                    {
                        row.AppendChild(new Cell
                        {
                            CellValue = new CellValue(((s * 5000) + (r * 10) + c).ToString()),
                            DataType = CellValues.Number,
                        });
                    }

                    sheetData.AppendChild(row);
                }

                var sheetUri = "worksheets/sheet" + (s + 1) + ".xml";
                var relId = "rId" + (s + 1);

                writer.WritePart(
                    new Uri("/xl/" + sheetUri, UriKind.Relative),
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml",
                    new Worksheet(sheetData));

                sheetRels[s] = new PartRelationship(
                    new Uri(sheetUri, UriKind.Relative),
                    "http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet",
                    id: relId);
            }

            var sheets = new Sheets();

            for (int s = 0; s < 3; s++)
            {
                sheets.AppendChild(new Sheet
                {
                    Name = "Sheet" + (s + 1),
                    SheetId = (uint)(s + 1),
                    Id = "rId" + (s + 1),
                });
            }

            writer.WritePart(
                new Uri("/xl/workbook.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml",
                new Workbook(sheets),
                sheetRels);
        }

        [Benchmark]
        public void Presentation_Simple_Standard()
        {
            using var stream = new NonwritingStream();
            using var doc = PresentationDocument.Create(stream, PresentationDocumentType.Presentation);

            var presentationPart = doc.AddPresentationPart();
            var slidePart = presentationPart.AddNewPart<SlidePart>();
            slidePart.Slide = new P.Slide(
                new P.CommonSlideData(
                    new P.ShapeTree()));

            presentationPart.Presentation = new P.Presentation(
                new P.SlideIdList(
                    new P.SlideId { Id = 256, RelationshipId = presentationPart.GetIdOfPart(slidePart) }),
                new P.SlideSize { Cx = 9144000, Cy = 6858000 });
        }

        [Benchmark]
        public void Presentation_Simple_ForwardOnly()
        {
            using var stream = new NonwritingStream();
            using var writer = PresentationDocument.CreateForwardOnly(stream, PresentationDocumentType.Presentation);

            writer.WritePart(
                new Uri("/ppt/slides/slide1.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.presentationml.slide+xml",
                new P.Slide(
                    new P.CommonSlideData(
                        new P.ShapeTree())));

            writer.WritePart(
                new Uri("/ppt/presentation.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.presentationml.presentation.main+xml",
                new P.Presentation(
                    new P.SlideIdList(
                        new P.SlideId { Id = 256, RelationshipId = "rId1" }),
                    new P.SlideSize { Cx = 9144000, Cy = 6858000 }),
                new[]
                {
                    new PartRelationship(
                        new Uri("slides/slide1.xml", UriKind.Relative),
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide",
                        id: "rId1"),
                });
        }

        [Benchmark]
        public void Presentation_Medium_Standard()
        {
            using var stream = new NonwritingStream();
            using var doc = PresentationDocument.Create(stream, PresentationDocumentType.Presentation);

            var presentationPart = doc.AddPresentationPart();
            var slideIdList = new P.SlideIdList();

            for (uint i = 0; i < 10; i++)
            {
                var slidePart = presentationPart.AddNewPart<SlidePart>();
                slidePart.Slide = new P.Slide(
                    new P.CommonSlideData(
                        new P.ShapeTree(
                            new P.Shape(
                                new P.TextBody(
                                    new Drawing.Paragraph(
                                        new Drawing.Run(
                                            new Drawing.Text("Slide " + (i + 1)))))))));

                slideIdList.AppendChild(new P.SlideId
                {
                    Id = 256 + i,
                    RelationshipId = presentationPart.GetIdOfPart(slidePart),
                });
            }

            presentationPart.Presentation = new P.Presentation(
                slideIdList,
                new P.SlideSize { Cx = 9144000, Cy = 6858000 });
        }

        [Benchmark]
        public void Presentation_Medium_ForwardOnly()
        {
            using var stream = new NonwritingStream();
            using var writer = PresentationDocument.CreateForwardOnly(stream, PresentationDocumentType.Presentation);

            var slideRels = new PartRelationship[10];
            var slideIdList = new P.SlideIdList();

            for (uint i = 0; i < 10; i++)
            {
                var relId = "rId" + (i + 1);

                writer.WritePart(
                    new Uri("/ppt/slides/slide" + (i + 1) + ".xml", UriKind.Relative),
                    "application/vnd.openxmlformats-officedocument.presentationml.slide+xml",
                    new P.Slide(
                        new P.CommonSlideData(
                            new P.ShapeTree(
                                new P.Shape(
                                    new P.TextBody(
                                        new Drawing.Paragraph(
                                            new Drawing.Run(
                                                new Drawing.Text("Slide " + (i + 1))))))))));

                slideRels[i] = new PartRelationship(
                    new Uri("slides/slide" + (i + 1) + ".xml", UriKind.Relative),
                    "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide",
                    id: relId);

                slideIdList.AppendChild(new P.SlideId { Id = 256 + i, RelationshipId = relId });
            }

            writer.WritePart(
                new Uri("/ppt/presentation.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.presentationml.presentation.main+xml",
                new P.Presentation(
                    slideIdList,
                    new P.SlideSize { Cx = 9144000, Cy = 6858000 }),
                slideRels);
        }

        [Benchmark]
        public void Presentation_Complex_Standard()
        {
            using var stream = new NonwritingStream();
            using var doc = PresentationDocument.Create(stream, PresentationDocumentType.Presentation);

            var presentationPart = doc.AddPresentationPart();
            var slideIdList = new P.SlideIdList();

            for (uint i = 0; i < 30; i++)
            {
                var slidePart = presentationPart.AddNewPart<SlidePart>();

                var shapeTree = new P.ShapeTree();

                for (int j = 0; j < 5; j++)
                {
                    shapeTree.AppendChild(new P.Shape(
                        new P.NonVisualShapeProperties(
                            new P.NonVisualDrawingProperties { Id = (uint)(j + 1), Name = "Shape " + j },
                            new P.NonVisualShapeDrawingProperties(),
                            new P.ApplicationNonVisualDrawingProperties()),
                        new P.ShapeProperties(
                            new Drawing.Transform2D(
                                new Drawing.Offset { X = j * 1000000L, Y = 1000000L },
                                new Drawing.Extents { Cx = 900000L, Cy = 500000L })),
                        new P.TextBody(
                            new Drawing.BodyProperties(),
                            new Drawing.Paragraph(
                                new Drawing.Run(
                                    new Drawing.Text("Shape " + j + " on Slide " + (i + 1)))))));
                }

                slidePart.Slide = new P.Slide(new P.CommonSlideData(shapeTree));

                slideIdList.AppendChild(new P.SlideId
                {
                    Id = 256 + i,
                    RelationshipId = presentationPart.GetIdOfPart(slidePart),
                });
            }

            presentationPart.Presentation = new P.Presentation(
                slideIdList,
                new P.SlideSize { Cx = 9144000, Cy = 6858000 });
        }

        [Benchmark]
        public void Presentation_Complex_ForwardOnly()
        {
            using var stream = new NonwritingStream();
            using var writer = PresentationDocument.CreateForwardOnly(stream, PresentationDocumentType.Presentation);

            var slideRels = new PartRelationship[30];
            var slideIdList = new P.SlideIdList();

            for (uint i = 0; i < 30; i++)
            {
                var relId = "rId" + (i + 1);

                var shapeTree = new P.ShapeTree();

                for (int j = 0; j < 5; j++)
                {
                    shapeTree.AppendChild(new P.Shape(
                        new P.NonVisualShapeProperties(
                            new P.NonVisualDrawingProperties { Id = (uint)(j + 1), Name = "Shape " + j },
                            new P.NonVisualShapeDrawingProperties(),
                            new P.ApplicationNonVisualDrawingProperties()),
                        new P.ShapeProperties(
                            new Drawing.Transform2D(
                                new Drawing.Offset { X = j * 1000000L, Y = 1000000L },
                                new Drawing.Extents { Cx = 900000L, Cy = 500000L })),
                        new P.TextBody(
                            new Drawing.BodyProperties(),
                            new Drawing.Paragraph(
                                new Drawing.Run(
                                    new Drawing.Text("Shape " + j + " on Slide " + (i + 1)))))));
                }

                writer.WritePart(
                    new Uri("/ppt/slides/slide" + (i + 1) + ".xml", UriKind.Relative),
                    "application/vnd.openxmlformats-officedocument.presentationml.slide+xml",
                    new P.Slide(new P.CommonSlideData(shapeTree)));

                slideRels[i] = new PartRelationship(
                    new Uri("slides/slide" + (i + 1) + ".xml", UriKind.Relative),
                    "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide",
                    id: relId);

                slideIdList.AppendChild(new P.SlideId { Id = 256 + i, RelationshipId = relId });
            }

            writer.WritePart(
                new Uri("/ppt/presentation.xml", UriKind.Relative),
                "application/vnd.openxmlformats-officedocument.presentationml.presentation.main+xml",
                new P.Presentation(
                    slideIdList,
                    new P.SlideSize { Cx = 9144000, Cy = 6858000 }),
                slideRels);
        }
    }
}
