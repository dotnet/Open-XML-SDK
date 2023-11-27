// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Experimental;

/// <summary>
/// Extensions to retrieve package details.
/// </summary>
[Experimental(ExperimentalApis.IPackage, UrlFormat = ExperimentalApis.UrlFormat)]
[Obsolete(ExperimentalApis.Message, DiagnosticId = ExperimentalApis.IPackage, UrlFormat = ExperimentalApis.UrlFormat)]
public static class PackageExtensions
{
    /// <summary>
    /// Gets the current <see cref="IPackage"/> for the <paramref name="package"/>.
    /// </summary>
    /// <param name="package">Current package.</param>
    /// <returns>The underlying <see cref="IPackage"/>.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="package"/> is <c>null</c>.</exception>
    public static IPackage GetPackage(this OpenXmlPackage package)
    {
        if (package is null)
        {
            throw new ArgumentNullException(nameof(package));
        }

        return package.Features.GetRequired<IPackageFeature>().Package;
    }
}
