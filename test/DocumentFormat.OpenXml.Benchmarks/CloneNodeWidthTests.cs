// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml.Benchmarks;

/// <summary>
/// Benchmarks how <see cref="OpenXmlElement.CloneNode(bool)"/> cost scales with the number of
/// sibling paragraphs in a <see cref="Body"/>, across both shallow and deep clone. Useful for
/// characterizing the growth curve that fixed-size spot checks in
/// <see cref="CloneNodeTests"/> cannot reveal on their own.
/// </summary>
public class CloneNodeWidthTests
{
    private Body _body = null!;

    [Params(0, 1, 10, 100, 1_000)]
    public int ParagraphCount { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _body = BuildBody(ParagraphCount);
    }

    [Benchmark]
    public OpenXmlElement Body_DeepClone() => _body.CloneNode(true);

    [Benchmark]
    public OpenXmlElement Body_ShallowClone() => _body.CloneNode(false);

    private static Body BuildBody(int paragraphCount)
    {
        var body = new Body();

        for (var i = 0; i < paragraphCount; i++)
        {
            body.AppendChild(
                new Paragraph(
                    new Run(
                        new Text($"Paragraph {i}"))));
        }

        return body;
    }
}
