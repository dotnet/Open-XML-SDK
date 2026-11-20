// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml.Benchmarks;

/// <summary>
/// Benchmarks the strongly typed child properties (for example <see cref="Paragraph.ParagraphProperties"/>), which resolve
/// the child through the compiled particle of the parent: the getter compares the schema type of every child, the setter
/// looks up the particle path of every child.
/// </summary>
[MemoryDiagnoser]
public class TypedChildPropertyBenchmarks
{
    private Paragraph _withProperties = null!;
    private Paragraph _withoutProperties = null!;
    private Run _run = null!;

    [Params(4, 32, 256)]
    public int Runs { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _withProperties = CreateParagraph(withProperties: true);
        _withoutProperties = CreateParagraph(withProperties: false);
        _run = new Run(new RunProperties(new Bold()), new Text("text"));
    }

    [Benchmark]
    public ParagraphProperties? GetAbsent() => _withoutProperties.ParagraphProperties;

    [Benchmark]
    public ParagraphProperties? GetPresent() => _withProperties.ParagraphProperties;

    [Benchmark]
    public void SetReplace() => _withProperties.ParagraphProperties = new ParagraphProperties();

    [Benchmark]
    public void SetRunProperties() => _run.RunProperties = new RunProperties();

    private Paragraph CreateParagraph(bool withProperties)
    {
        var paragraph = new Paragraph();

        if (withProperties)
        {
            paragraph.AppendChild(new ParagraphProperties(new ParagraphStyleId { Val = "Normal" }));
        }

        for (var i = 0; i < Runs; i++)
        {
            paragraph.AppendChild(new Run(new RunProperties(new Bold()), new Text("text " + i)));
        }

        return paragraph;
    }
}
