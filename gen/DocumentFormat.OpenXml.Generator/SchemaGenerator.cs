// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Editor;
using DocumentFormat.OpenXml.Generator.Generators.Elements;
using DocumentFormat.OpenXml.Generator.Models;
using Microsoft.CodeAnalysis;
using System.CodeDom.Compiler;
using System.Text;

namespace DocumentFormat.OpenXml.Generator;

public static class SchemaGenerator
{
    public static void WriteSchemaFiles(SourceProductionContext context, OpenXmlGeneratorServices openXml, SchemaNamespace namespaces)
    {
        var sw = new StringWriter();
        var writer = new IndentedTextWriter(sw);

        writer.WriteFileHeader();

        if (writer.GetDataModelSyntax(openXml, namespaces))
        {
            context.AddSource(GetPath(namespaces.TargetNamespace), sw.ToString());
        }
    }

    private static string GetPath(string ns)
    {
        var sb = new StringBuilder(ns);

        sb.Replace("http://", string.Empty);
        sb.Replace("urn:", string.Empty);
        sb.Replace('/', '_');
        sb.Replace('.', '_');
        sb.Replace(':', '_');
        sb.Append("g.cs");

        return sb.ToString();
    }
}
