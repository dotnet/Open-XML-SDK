// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Editor;
using DocumentFormat.OpenXml.Generator.Models;
using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Generator.NamespaceGeneration;

internal static class NamespaceGeneratorExtensions
{
    public static string Generate(this IEnumerable<NamespaceInfo> namespaces)
    {
        var sb = new StringWriter();
        var writer = new IndentedTextWriter(sb);

        writer.WriteFileHeader();
        writer.WriteLine("using System.Collections.Generic;");
        writer.WriteLine();
        writer.WriteLine("namespace DocumentFormat.OpenXml.Features;");
        writer.WriteLine();
        writer.WriteLine("internal partial class OpenXmlNamespaceResolver");

        using (writer.AddBlock())
        {
            writer.WriteLine("private readonly Dictionary<string, string> _urlToPrefix = new()");

            using (writer.AddBlock(new() { IncludeSemiColon = true }))
            {
                foreach (var ns in namespaces)
                {
                    writer.WriteList(ns.Uri, ns.Prefix);
                    writer.WriteLine(",");
                }
            }

            writer.WriteLineNoTabs();
            writer.WriteLine("private readonly Dictionary<string, string> _prefixToUrl = new()");

            using (writer.AddBlock(new() { IncludeSemiColon = true }))
            {
                foreach (var ns in namespaces)
                {
                    writer.WriteList(ns.Prefix, ns.Uri);
                    writer.WriteLine(",");
                }
            }

            writer.WriteLineNoTabs();
            writer.WriteLine("private readonly Dictionary<string, FileFormatVersions> _prefixToVersion = new()");

            using (writer.AddBlock(new() { IncludeSemiColon = true }))
            {
                foreach (var ns in namespaces)
                {
                    writer.WriteList(ns.Prefix, ns.Version);

                    writer.WriteLine(",");
                }
            }
        }

        return sb.ToString();
    }
}
