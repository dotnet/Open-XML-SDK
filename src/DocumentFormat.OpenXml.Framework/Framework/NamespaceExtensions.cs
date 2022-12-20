// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;

namespace DocumentFormat.OpenXml;

internal static class NamespaceExtensions
{
    public static IOpenXmlNamespaceResolver GetNamespaceResolver(this IFeatureCollection features) => features.GetRequired<IOpenXmlNamespaceResolver>();

    public static bool IsKnown(this IOpenXmlNamespaceResolver resolver, OpenXmlNamespace ns)
        => resolver.GetVersion(ns) != FileFormatVersions.None;

    public static bool HasVersion(this IOpenXmlNamespaceResolver resolver, OpenXmlNamespace ns, FileFormatVersions version)
        => resolver.GetVersion(ns) == version;

    public static OpenXmlQualifiedName ParseQName(this IOpenXmlNamespaceResolver resolver, string name, string? nsUri = null)
    {
        var parsed = PrefixName.Parse(name);

        return new(nsUri ?? resolver.LookupNamespace(parsed.Prefix) ?? string.Empty, parsed.Name);
    }
}
