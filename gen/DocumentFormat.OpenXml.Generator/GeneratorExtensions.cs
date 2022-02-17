// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

namespace DocumentFormat.OpenXml.Generator;

public static class GeneratorExtensions
{
    public static IncrementalValueProvider<ImmutableArray<AdditionalText>> GetOpenXmlDataFiles(this IncrementalGeneratorInitializationContext context, string name)
        => context.AdditionalTextsProvider
                .Combine(context.AnalyzerConfigOptionsProvider)
                .Where(args => args.Right.GetOptions(args.Left).TryGetValue("build_metadata.AdditionalFiles.OpenXml", out var result) && string.Equals(name, result, StringComparison.Ordinal))
                .Select((args, _) => args.Left)
                .Collect();
}
