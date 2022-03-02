// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Editor;
using DocumentFormat.OpenXml.Generator.Generators.Elements;
using Microsoft.CodeAnalysis;
using System.CodeDom.Compiler;
using System.Text;

namespace DocumentFormat.OpenXml.Generator;

[Generator]
public class SchemaGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var openXmlContext = context.GetOpenXmlGeneratorContext();
        var ns = openXmlContext.SelectMany((s, _) => s.Namespaces);
        var services = openXmlContext.GetOpenXmlServices();
        var options = context.GetOpenXmlOptions().Select(static (o, _) => o.GenerateSchema);

        context.RegisterSourceOutput(ns.Combine(services).Combine(options), (context, data) =>
        {
            if (!data.Right)
            {
                return;
            }

            var openXml = data.Left.Right;
            var sw = new StringWriter();
            var writer = new IndentedTextWriter(sw);

            writer.WriteFileHeader();
            writer.WriteLine("#pragma warning disable CS0618 // Type or member is obsolete");
            writer.WriteLine();

            if (writer.GetDataModelSyntax(openXml, data.Left.Left))
            {
                context.AddSource(GetPath(data.Left.Left.TargetNamespace), sw.ToString());
            }
        });
    }

    private static string GetPath(string ns)
    {
        var sb = new StringBuilder(ns);

        sb.Replace("http://", string.Empty);
        sb.Replace("urn:", string.Empty);
        sb.Replace('/', '_');
        sb.Replace('.', '_');
        sb.Replace(':', '_');

        return sb.ToString();
    }
}
