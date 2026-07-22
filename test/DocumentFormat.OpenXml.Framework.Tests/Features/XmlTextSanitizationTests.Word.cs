// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.IO;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Features.Tests;

public partial class XmlTextSanitizationTests
{
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
}
