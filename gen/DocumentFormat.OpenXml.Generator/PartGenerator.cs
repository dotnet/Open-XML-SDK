// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Editor;
using DocumentFormat.OpenXml.Generator.Generators.Parts;
using Microsoft.CodeAnalysis;
using System.CodeDom.Compiler;
using System.Text;

namespace DocumentFormat.OpenXml.Generator;

[Generator]
public class PartGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var openXml = context.GetOpenXmlGeneratorContext().GetOpenXmlServices();
        var options = context.GetOpenXmlOptions().Select(static (o, _) => o.GenerateParts);
        var parts = openXml.Combine(options);

        context.RegisterSourceOutput(parts, (context, data) =>
        {
            if (!data.Right)
            {
                return;
            }

            var openXml = data.Left;

            WritePartFiles(context, openXml);
        });
    }

    private static void WritePartFiles(SourceProductionContext context, OpenXmlGeneratorServices openXml)
    {
        var sb = new StringBuilder();
        var sw = new StringWriter(sb);
        var writer = new IndentedTextWriter(sw);

        foreach (var part in openXml.Context.Parts.Concat(openXml.Context.Packages))
        {
            sb.Clear();

            writer.WriteFileHeader();
            writer.WritePart(openXml, part);

            context.AddSource(part.Name, sb.ToString());
        }
    }
}
