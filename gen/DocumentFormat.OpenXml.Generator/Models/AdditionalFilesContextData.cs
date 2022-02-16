// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace DocumentFormat.OpenXml.Generator.Models
{
    internal class AdditionalFilesContextData : IContextData
    {
        private const string NamespaceKey = "Namespace";

        public AdditionalFilesContextData(GeneratorExecutionContext context)
        {
            var namespaces = context.AdditionalFiles.Where(a => IsApplicable(context.AnalyzerConfigOptions, a, NamespaceKey)).FirstOrDefault();

            if (namespaces is not null && namespaces.GetText(context.CancellationToken) is SourceText text)
            {
                Namespaces = text.ToString();
            }
        }

        private static bool IsApplicable(AnalyzerConfigOptionsProvider options, AdditionalText text, string metadataValue)
            => options.GetOptions(text).TryGetValue("build_metadata.AdditionalFiles.OpenXml", out var value) && string.Equals(value, metadataValue, StringComparison.Ordinal);

        public string Namespaces { get; } = string.Empty;
    }
}
