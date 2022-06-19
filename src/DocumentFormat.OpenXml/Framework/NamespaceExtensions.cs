// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;

namespace DocumentFormat.OpenXml;

internal static class NamespaceExtensions
{
    public static IOpenXmlNamespaceResolver GetNamespaceResolver(this IFeatureCollection features) => features.GetRequired<IOpenXmlNamespaceResolver>();

    public static bool IsKnown(this IOpenXmlNamespaceResolver resolver, OpenXmlNamespace ns)
        => resolver.GetVersion(ns) != FileFormatVersions.None;

    public static bool HasVersion(this IOpenXmlNamespaceResolver resolver, OpenXmlNamespace ns, FileFormatVersions version)
        => resolver.GetVersion(ns) == version;

    public static OpenXmlNamespace CreateNamespace(this IOpenXmlNamespaceResolver resolver, string name, string? prefix = null)
        => prefix is not null ? new(name, prefix) : new(name, resolver.LookupPrefix(name));

    public static OpenXmlQualifiedName ParseQName(this IOpenXmlNamespaceResolver resolver, string name, string? nsUri = null)
    {
#if NET5_0
        var idx = name.IndexOf(':', StringComparison.Ordinal);
#else
        var idx = name.IndexOf(':');
#endif

        if (((idx == -1) || (idx == 0)) || ((name.Length - 1) == idx))
        {
            var start = idx + 1;

            if (nsUri is null)
            {
                return new OpenXmlQualifiedName(string.Empty, name.Substring(start));
            }
            else
            {
                return new OpenXmlQualifiedName(nsUri, name.Substring(start));
            }
        }
        else
        {
            var prefix = name.Substring(0, idx);
            var uri = nsUri ?? resolver.LookupNamespace(prefix) ?? string.Empty;
            var localName = name.Substring(idx + 1);

            return new OpenXmlQualifiedName(new OpenXmlNamespace(uri, prefix), localName);
        }
    }
}
