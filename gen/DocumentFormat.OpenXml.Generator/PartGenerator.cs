// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Editor;
using DocumentFormat.OpenXml.Generator.Generators.Parts;
using Microsoft.CodeAnalysis;
using System.CodeDom.Compiler;
using System.Text;

namespace DocumentFormat.OpenXml.Generator;

public static class PartGenerator
{
    public static void WritePartFiles(SourceProductionContext context, OpenXmlGeneratorServices? openXml)
    {
        if (openXml is null)
        {
            return;
        }

        var sb = new StringBuilder();
        var sw = new StringWriter(sb);
        var writer = new IndentedTextWriter(sw);

        foreach (var part in openXml.DataSource.Parts.Concat(openXml.DataSource.Packages))
        {
            sb.Clear();

            writer.WriteFileHeader();
            writer.WritePart(openXml, part);

            context.AddSource($"Part_{part.Name}", sb.ToString());
        }
    }
}
