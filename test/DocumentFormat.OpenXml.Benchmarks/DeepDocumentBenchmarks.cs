// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;

namespace DocumentFormat.OpenXml.Benchmarks;

/// <summary>
/// Loads documents whose elements sit at different depths. Resolving features for an element walks up to the part root,
/// so anything done per element while parsing costs more the deeper the element is.
/// </summary>
public class DeepDocumentBenchmarks
{
    private const int Paragraphs = 50_000;

    private byte[] _package = null!;

    /// <summary>
    /// Gets or sets the number of nested tables the paragraphs are placed in. Each level adds three elements of depth.
    /// </summary>
    [Params(0, 5, 25)]
    public int Nesting { get; set; }

    [GlobalSetup]
    public void Setup() => _package = CreatePackage(Nesting);

    [Benchmark]
    public object LoadDocument()
    {
        using var stream = new MemoryStream(_package, writable: false);
        using var document = WordprocessingDocument.Open(stream, false);

        return document.MainDocumentPart!.Document;
    }

    internal static byte[] CreatePackage(int nesting)
    {
        using var stream = new MemoryStream();

        using (var document = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
        {
            var main = document.AddMainDocumentPart();

            using var writer = OpenXmlWriter.Create(main);

            writer.WriteStartElement(new Document());
            writer.WriteStartElement(new Body());

            for (var i = 0; i < nesting; i++)
            {
                writer.WriteStartElement(new Table());
                writer.WriteStartElement(new TableRow());
                writer.WriteStartElement(new TableCell());
            }

            for (var i = 0; i < Paragraphs; i++)
            {
                writer.WriteElement(new Paragraph(new Run(new Text($"Paragraph {i}"))));
            }

            for (var i = 0; i < nesting; i++)
            {
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        return stream.ToArray();
    }
}
