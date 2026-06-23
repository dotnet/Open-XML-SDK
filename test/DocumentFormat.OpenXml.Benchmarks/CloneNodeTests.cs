// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml.Benchmarks;

/// <summary>
/// Benchmarks <see cref="OpenXmlElement.CloneNode(bool)"/> across several representative element
/// shapes — leaf text, formatted run, simple paragraph, paragraph with properties, and a wider
/// body. Loop-driven docx renderers (e.g. Parchment) call <c>CloneNode(true)</c> once per loop
/// iteration so each iteration's allocation profile dominates the render's GC cost.
/// </summary>
public class CloneNodeTests
{
    private Text _text = null!;
    private Run _runWithFormatting = null!;
    private Paragraph _simpleParagraph = null!;
    private Paragraph _formattedParagraph = null!;
    private Body _bodyOfTen = null!;
    private Body _bodyOfHundred = null!;

    [GlobalSetup]
    public void Setup()
    {
        _text = new Text("Hello world");

        _runWithFormatting = new Run(
            new RunProperties(
                new RunFonts { Ascii = "Calibri" },
                new FontSize { Val = "22" },
                new Bold()),
            new Text("Some formatted text"));

        _simpleParagraph = new Paragraph(
            new Run(new Text("First run")),
            new Run(new Text(" second run")),
            new Run(new Text(" third run")));

        _formattedParagraph = new Paragraph(
            new ParagraphProperties(
                new ParagraphStyleId { Val = "Normal" },
                new Justification { Val = JustificationValues.Left },
                new SpacingBetweenLines { Before = "0", After = "200" }),
            new Run(
                new RunProperties(new Bold()),
                new Text("Bold lead-in")),
            new Run(new Text(" body text continues")),
            new Run(
                new RunProperties(new Italic()),
                new Text(" italic tail")));

        _bodyOfTen = BuildBody(10);
        _bodyOfHundred = BuildBody(100);
    }

    [Benchmark]
    public OpenXmlElement Text_Shallow() => _text.CloneNode(false);

    [Benchmark]
    public OpenXmlElement Text_Deep() => _text.CloneNode(true);

    [Benchmark]
    public OpenXmlElement Run_Shallow() => _runWithFormatting.CloneNode(false);

    [Benchmark]
    public OpenXmlElement Run_Deep() => _runWithFormatting.CloneNode(true);

    [Benchmark]
    public OpenXmlElement Paragraph_Simple_Deep() => _simpleParagraph.CloneNode(true);

    [Benchmark]
    public OpenXmlElement Paragraph_Formatted_Deep() => _formattedParagraph.CloneNode(true);

    [Benchmark]
    public OpenXmlElement Body_TenParagraphs_Deep() => _bodyOfTen.CloneNode(true);

    [Benchmark]
    public OpenXmlElement Body_HundredParagraphs_Deep() => _bodyOfHundred.CloneNode(true);

    private static Body BuildBody(int paragraphCount)
    {
        var body = new Body();
        for (var i = 0; i < paragraphCount; i++)
        {
            body.AppendChild(new Paragraph(
                new ParagraphProperties(
                    new ParagraphStyleId { Val = "Normal" }),
                new Run(
                    new RunProperties(new RunFonts { Ascii = "Calibri" }),
                    new Text($"Paragraph {i} text content"))));
        }

        return body;
    }
}
