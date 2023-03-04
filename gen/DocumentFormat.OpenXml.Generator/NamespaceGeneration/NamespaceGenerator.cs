// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Models;
using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

namespace DocumentFormat.OpenXml.Generator.NamespaceGeneration;

public static class NamespaceGenerator
{
    private static readonly DiagnosticDescriptor MalformedDataFileDescriptor = new("OOX3000", "Malformed data file", "Failed to load data file", "Data", DiagnosticSeverity.Error, isEnabledByDefault: true);

    public static void WriteNamespaces(SourceProductionContext context, ImmutableArray<NamespaceInfo> namespaces)
    {
        if (namespaces.IsDefaultOrEmpty)
        {
            return;
        }

        try
        {
            context.AddSource("Namespaces", namespaces.Generate());
        }
        catch (Exception)
        {
            context.ReportDiagnostic(Diagnostic.Create(MalformedDataFileDescriptor, location: null));
        }
    }
}
