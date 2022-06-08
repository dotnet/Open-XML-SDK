// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using DocumentFormat.OpenXml.Generator.Models;
using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

namespace DocumentFormat.OpenXml.Generator
{
    public static class GeneratorContextExtensions
    {
        public static OpenXmlGeneratorContext LoadNamespaces(this OpenXmlGeneratorContext context, ImmutableArray<AdditionalText> namespaces, CancellationToken token)
        {
            var builder = ImmutableArray.CreateBuilder<NamespaceInfo>();

            foreach (var n in namespaces)
            {
                var deserialized = OpenXmlGeneratorContext.Deserialize<NamespaceInfo[]>(n.GetText(token)?.ToString());

                if (deserialized is not null)
                {
                    builder.AddRange(deserialized);
                }
            }

            return context with { KnownNamespaces = builder.ToImmutable() };
        }
    }
}
