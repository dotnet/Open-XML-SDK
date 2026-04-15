// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using System.Linq;
using Xunit;

using A = DocumentFormat.OpenXml.Drawing;
using P = DocumentFormat.OpenXml.Presentation;

namespace DocumentFormat.OpenXml.Features.Tests;

public partial class XmlTextSanitizationTests
{
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
}
