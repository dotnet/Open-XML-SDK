// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using Xunit;

using A = DocumentFormat.OpenXml.Drawing;
using Body = DocumentFormat.OpenXml.Wordprocessing.Body;
using Cell = DocumentFormat.OpenXml.Spreadsheet.Cell;
using CellValues = DocumentFormat.OpenXml.Spreadsheet.CellValues;
using Document = DocumentFormat.OpenXml.Wordprocessing.Document;
using InlineString = DocumentFormat.OpenXml.Spreadsheet.InlineString;
using P = DocumentFormat.OpenXml.Presentation;
using Paragraph = DocumentFormat.OpenXml.Wordprocessing.Paragraph;
using Row = DocumentFormat.OpenXml.Spreadsheet.Row;
using Run = DocumentFormat.OpenXml.Wordprocessing.Run;
using Sheet = DocumentFormat.OpenXml.Spreadsheet.Sheet;
using SheetData = DocumentFormat.OpenXml.Spreadsheet.SheetData;
using Sheets = DocumentFormat.OpenXml.Spreadsheet.Sheets;
using SheetText = DocumentFormat.OpenXml.Spreadsheet.Text;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;
using Workbook = DocumentFormat.OpenXml.Spreadsheet.Workbook;
using Worksheet = DocumentFormat.OpenXml.Spreadsheet.Worksheet;

namespace DocumentFormat.OpenXml.Features.Tests;

public class XmlTextSanitizationTests
{
    [Fact]
    public void SanitizeIfNeeded_Null_ReturnsNull()
    {
        Assert.Null(XmlCharacterSanitizer.SanitizeIfNeeded(null));
    }

    [Fact]
    public void SanitizeIfNeeded_Empty_ReturnsEmpty()
    {
        Assert.Same(string.Empty, XmlCharacterSanitizer.SanitizeIfNeeded(string.Empty));
    }

    [Fact]
    public void SanitizeIfNeeded_AllValid_ReturnsSameReference()
    {
        var input = "Hello, world! Tabs\tnewlines\nand returns\r are fine.";
        Assert.Same(input, XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void SanitizeIfNeeded_SingleControlChar_IsStripped()
    {
        var input = "valid\u0002text";
        Assert.Equal("validtext", XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void SanitizeIfNeeded_LeadingControlChar_IsStripped()
    {
        Assert.Equal("abc", XmlCharacterSanitizer.SanitizeIfNeeded("\u0001abc"));
    }

    [Fact]
    public void SanitizeIfNeeded_TrailingControlChar_IsStripped()
    {
        Assert.Equal("abc", XmlCharacterSanitizer.SanitizeIfNeeded("abc\u001f"));
    }

    [Fact]
    public void SanitizeIfNeeded_MultipleControlChars_AllStripped()
    {
        var input = "a\u0001b\u0002c\u001fd";
        Assert.Equal("abcd", XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void SanitizeIfNeeded_TabNewlineCarriageReturn_Preserved()
    {
        var input = "a\tb\nc\rd";
        Assert.Same(input, XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void SanitizeIfNeeded_ValidSurrogatePair_Preserved()
    {
        // U+1F600 grinning face emoji
        var input = "hi\uD83D\uDE00!";
        Assert.Same(input, XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void SanitizeIfNeeded_OrphanedHighSurrogate_Stripped()
    {
        var input = "start\uD83Dend";
        Assert.Equal("startend", XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void SanitizeIfNeeded_OrphanedLowSurrogate_Stripped()
    {
        var input = "start\uDE00end";
        Assert.Equal("startend", XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void SanitizeIfNeeded_NonCharacterFFFE_Stripped()
    {
        var input = "a\uFFFEb";
        Assert.Equal("ab", XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void SanitizeIfNeeded_NonCharacterFFFF_Stripped()
    {
        var input = "a\uFFFFb";
        Assert.Equal("ab", XmlCharacterSanitizer.SanitizeIfNeeded(input));
    }

    [Fact]
    public void IsValidXmlChar_KnownValid_ReturnsTrue()
    {
        Assert.True(XmlCharacterSanitizer.IsValidXmlChar('\t'));
        Assert.True(XmlCharacterSanitizer.IsValidXmlChar('\n'));
        Assert.True(XmlCharacterSanitizer.IsValidXmlChar('\r'));
        Assert.True(XmlCharacterSanitizer.IsValidXmlChar(' '));
        Assert.True(XmlCharacterSanitizer.IsValidXmlChar('A'));
        Assert.True(XmlCharacterSanitizer.IsValidXmlChar('\uD7FF'));
        Assert.True(XmlCharacterSanitizer.IsValidXmlChar('\uE000'));
        Assert.True(XmlCharacterSanitizer.IsValidXmlChar('\uFFFD'));
    }

    [Fact]
    public void IsValidXmlChar_KnownInvalid_ReturnsFalse()
    {
        for (var c = '\u0000'; c < '\u0020'; c++)
        {
            if (c == '\t' || c == '\n' || c == '\r')
            {
                continue;
            }

            Assert.False(XmlCharacterSanitizer.IsValidXmlChar(c), $"Expected 0x{(int)c:X4} to be invalid");
        }

        Assert.False(XmlCharacterSanitizer.IsValidXmlChar('\uFFFE'));
        Assert.False(XmlCharacterSanitizer.IsValidXmlChar('\uFFFF'));
    }

    [Fact]
    public void DefaultPackage_HasDefaultXmlWriterFactoryFeature()
    {
        using var stream = new MemoryStream();
        using var document = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

        var feature = document.Features.Get<IXmlWriterFactoryFeature>();

        Assert.NotNull(feature);
        Assert.IsType<DefaultXmlWriterFactoryFeature>(feature);
    }

    [Fact]
    public void UseXmlTextSanitization_NullPackage_Throws()
    {
        OpenXmlPackage? package = null;
        Assert.Throws<ArgumentNullException>(() => package!.UseXmlTextSanitization());
    }

    [Fact]
    public void UseXmlTextSanitization_RegistersSanitizingFactory()
    {
        using var stream = new MemoryStream();
        using var document = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

        document.UseXmlTextSanitization();

        var feature = document.Features.Get<IXmlWriterFactoryFeature>();

        Assert.IsType<SanitizingXmlWriterFactoryFeature>(feature);
    }

    [Fact]
    public void UseXmlTextSanitization_ReturnsSamePackage()
    {
        using var stream = new MemoryStream();
        using var document = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

        var result = document.UseXmlTextSanitization();

        Assert.Same(document, result);
    }

    [Fact]
    public void UseXmlTextSanitization_Idempotent()
    {
        using var stream = new MemoryStream();
        using var document = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

        document.UseXmlTextSanitization();
        var first = document.Features.Get<IXmlWriterFactoryFeature>();

        document.UseXmlTextSanitization();
        var second = document.Features.Get<IXmlWriterFactoryFeature>();

        Assert.Same(first, second);
    }

    [Fact]
    public void SanitizingWriter_WriteString_StripsInvalidChars()
    {
        var xml = WriteTestXml(writer =>
        {
            writer.WriteStartElement("r");
            writer.WriteString("a\u0002b");
            writer.WriteEndElement();
        });

        Assert.Contains("<r>ab</r>", xml);
    }

    [Fact]
    public void SanitizingWriter_WriteAttributeString_StripsInvalidCharsInValue()
    {
        var xml = WriteTestXml(writer =>
        {
            writer.WriteStartElement("r");
            writer.WriteAttributeString("name", "bad\u0003value");
            writer.WriteEndElement();
        });

        Assert.Contains("name=\"badvalue\"", xml);
    }

    [Fact]
    public void SanitizingWriter_WriteCData_StripsInvalidChars()
    {
        var xml = WriteTestXml(writer =>
        {
            writer.WriteStartElement("r");
            writer.WriteCData("data\u0002more");
            writer.WriteEndElement();
        });

        Assert.Contains("<![CDATA[datamore]]>", xml);
    }

    [Fact]
    public void SanitizingWriter_WriteComment_StripsInvalidChars()
    {
        var xml = WriteTestXml(writer =>
        {
            writer.WriteStartElement("r");
            writer.WriteComment("hello\u0004world");
            writer.WriteEndElement();
        });

        Assert.Contains("<!--helloworld-->", xml);
    }

    [Fact]
    public void SanitizingWriter_WriteChars_StripsInvalidChars()
    {
        var xml = WriteTestXml(writer =>
        {
            writer.WriteStartElement("r");
            var chars = "a\u0002b".ToCharArray();
            writer.WriteChars(chars, 0, chars.Length);
            writer.WriteEndElement();
        });

        Assert.Contains("<r>ab</r>", xml);
    }

    [Fact]
    public void SanitizingWriter_Raw_IsNotSanitized()
    {
        var xml = WriteTestXml(writer =>
        {
            writer.WriteStartElement("r");
            writer.WriteRaw("<child>valid</child>");
            writer.WriteEndElement();
        });

        Assert.Contains("<r><child>valid</child></r>", xml);
    }

    [Fact]
    public void SanitizingWriter_ElementNameWithInvalidChar_StillThrows()
    {
        // Element names are structural and must still reject invalid chars.
        Assert.ThrowsAny<Exception>(() =>
        {
            WriteTestXml(writer =>
            {
                writer.WriteStartElement("bad\u0002name");
                writer.WriteEndElement();
            });
        });
    }

    [Fact]
    public void WordprocessingDocument_WithoutSanitization_ControlCharThrows()
    {
        using var stream = new MemoryStream();

        Assert.Throws<ArgumentException>(() =>
        {
            using var document = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document);

            var main = document.AddMainDocumentPart();
            main!.Document = new Document(
                new Body(
                    new Paragraph(
                        new Run(
                            new Text("Hello\u0002World")))));

            document.Save();
        });
    }

    [Fact]
    public void WordprocessingDocument_WithSanitization_ControlCharRemoved()
    {
        using var stream = new MemoryStream();

        using (var document = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
        {
            document.UseXmlTextSanitization();

            var main = document.AddMainDocumentPart();
            main!.Document = new Document(
                new Body(
                    new Paragraph(
                        new Run(
                            new Text("Hello\u0002World")))));

            document.Save();
        }

        stream.Position = 0;

        using var reopened = WordprocessingDocument.Open(stream, false);
        var text = reopened.MainDocumentPart!.Document!.Body!
            .Descendants<Text>()
            .Single()
            .Text;

        Assert.Equal("HelloWorld", text);
    }

    [Fact]
    public void WordprocessingDocument_WithSanitization_MultipleRunsAllCleaned()
    {
        using var stream = new MemoryStream();

        using (var document = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
        {
            document.UseXmlTextSanitization();

            var main = document.AddMainDocumentPart();
            main!.Document = new Document(
                new Body(
                    new Paragraph(
                        new Run(new Text("First\u0001run")),
                        new Run(new Text("Second\u0002run")),
                        new Run(new Text("Third\u001frun")))));

            document.Save();
        }

        stream.Position = 0;

        using var reopened = WordprocessingDocument.Open(stream, false);
        var texts = reopened.MainDocumentPart!.Document!.Body!
            .Descendants<Text>()
            .Select(t => t.Text)
            .ToArray();

        Assert.Equal(new[] { "Firstrun", "Secondrun", "Thirdrun" }, texts);
    }

    [Fact]
    public void WordprocessingDocument_WithSanitization_ValidEmojiPreserved()
    {
        using var stream = new MemoryStream();

        using (var document = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
        {
            document.UseXmlTextSanitization();

            var main = document.AddMainDocumentPart();
            main!.Document = new Document(
                new Body(
                    new Paragraph(
                        new Run(
                            new Text("Hello \uD83D\uDE00 world")))));

            document.Save();
        }

        stream.Position = 0;

        using var reopened = WordprocessingDocument.Open(stream, false);
        var text = reopened.MainDocumentPart!.Document!.Body!
            .Descendants<Text>()
            .Single()
            .Text;

        Assert.Equal("Hello \uD83D\uDE00 world", text);
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
                        InlineString = new InlineString(new SheetText("bad\u0002data")),
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
            .Worksheet!.Descendants<SheetText>()
            .Single()
            .Text;

        Assert.Equal("baddata", cellText);
    }

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
                        InlineString = new InlineString(new SheetText("bad\u0002data")),
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
    public void PresentationDocument_UseXmlTextSanitization_RegistersSanitizingFactory()
    {
        using var stream = new MemoryStream();
        using var presentation = PresentationDocument.Create(stream, PresentationDocumentType.Presentation);

        presentation.UseXmlTextSanitization();

        var feature = presentation.Features.Get<IXmlWriterFactoryFeature>();

        Assert.IsType<SanitizingXmlWriterFactoryFeature>(feature);
    }

    [Fact]
    public void PresentationDocument_WithoutSanitization_ControlCharThrows()
    {
        using var stream = new MemoryStream();

        Assert.Throws<ArgumentException>(() =>
        {
            using var presentation = PresentationDocument.Create(stream, PresentationDocumentType.Presentation);

            var presentationPart = presentation.AddPresentationPart();
            presentationPart.Presentation = new P.Presentation();

            var slidePart = presentationPart.AddNewPart<SlidePart>();
            slidePart.Slide = CreateSlideWithText("bad\u0002text");

            presentationPart.Presentation.Save();
            slidePart.Slide.Save();
        });
    }

    [Fact]
    public void PresentationDocument_WithSanitization_SlideTextCleaned()
    {
        using var stream = new MemoryStream();

        using (var presentation = PresentationDocument.Create(stream, PresentationDocumentType.Presentation))
        {
            presentation.UseXmlTextSanitization();

            var presentationPart = presentation.AddPresentationPart();
            presentationPart.Presentation = new P.Presentation();

            var slidePart = presentationPart.AddNewPart<SlidePart>();
            slidePart.Slide = CreateSlideWithText("bad\u0002text");

            presentationPart.Presentation.Save();
            slidePart.Slide.Save();
        }

        stream.Position = 0;

        using var reopened = PresentationDocument.Open(stream, false);
        var slide = reopened.PresentationPart!.SlideParts.Single().Slide!;
        var text = slide.Descendants<A.Text>().Single().Text;

        Assert.Equal("badtext", text);
    }

    [Fact]
    public void PresentationDocument_WithSanitization_ValidEmojiPreserved()
    {
        using var stream = new MemoryStream();

        using (var presentation = PresentationDocument.Create(stream, PresentationDocumentType.Presentation))
        {
            presentation.UseXmlTextSanitization();

            var presentationPart = presentation.AddPresentationPart();
            presentationPart.Presentation = new P.Presentation();

            var slidePart = presentationPart.AddNewPart<SlidePart>();
            slidePart.Slide = CreateSlideWithText("Hello \uD83D\uDE00 world");

            presentationPart.Presentation.Save();
            slidePart.Slide.Save();
        }

        stream.Position = 0;

        using var reopened = PresentationDocument.Open(stream, false);
        var slide = reopened.PresentationPart!.SlideParts.Single().Slide!;
        var text = slide.Descendants<A.Text>().Single().Text;

        Assert.Equal("Hello \uD83D\uDE00 world", text);
    }

    private static P.Slide CreateSlideWithText(string content) => new(
        new P.CommonSlideData(
            new P.ShapeTree(
                new P.NonVisualGroupShapeProperties(
                    new P.NonVisualDrawingProperties { Id = 1U, Name = string.Empty },
                    new P.NonVisualGroupShapeDrawingProperties(),
                    new P.ApplicationNonVisualDrawingProperties()),
                new P.GroupShapeProperties(),
                new P.Shape(
                    new P.NonVisualShapeProperties(
                        new P.NonVisualDrawingProperties { Id = 2U, Name = "TextShape" },
                        new P.NonVisualShapeDrawingProperties(),
                        new P.ApplicationNonVisualDrawingProperties()),
                    new P.ShapeProperties(),
                    new P.TextBody(
                        new A.BodyProperties(),
                        new A.ListStyle(),
                        new A.Paragraph(
                            new A.Run(
                                new A.RunProperties { Language = "en-US" },
                                new A.Text(content))))))));

    private static string WriteTestXml(Action<XmlWriter> action)
    {
        var output = new MemoryStream();
        var factory = SanitizingXmlWriterFactoryFeature.Instance;
        var settings = new XmlWriterSettings
        {
            Encoding = Encoding.UTF8,
            OmitXmlDeclaration = true,
            CloseOutput = false,
        };

        using (var writer = factory.Create(output, settings))
        {
            action(writer);
            writer.Flush();
        }

        return Encoding.UTF8.GetString(output.ToArray());
    }
}
