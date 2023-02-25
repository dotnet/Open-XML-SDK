// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis;

namespace DocumentFormat.OpenXml.Generator;

[Generator]
public class LinqGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var openXml = context.GetOpenXmlGeneratorContext().GetOpenXmlServices();
        var options = context.GetOpenXmlOptions().Select(static (o, _) => o.GenerateLinq);
        var parts = openXml.Combine(options);

        context.RegisterSourceOutput(parts, (context, data) =>
        {
            if (!data.Right)
            {
                return;
            }

            var openXml = data.Left;

            WriteLinqFiles(context, openXml);
        });
    }

    private static void WriteLinqFiles(SourceProductionContext context, OpenXmlGeneratorServices services)
    {
        foreach (var (className, contents) in services.GenerateLinqFiles())
        {
            context.AddSource(className, contents);
        }
    }
}
