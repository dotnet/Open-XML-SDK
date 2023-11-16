// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// An initializer for a package.
/// </summary>
[Experimental(ExperimentalApis.PackageBuilder, UrlFormat = ExperimentalApis.UrlFormat)]
[Obsolete(ExperimentalApis.Message, error: true, DiagnosticId = ExperimentalApis.PackageBuilder, UrlFormat = ExperimentalApis.UrlFormat)]
public interface IPackageInitializer
{
    /// <summary>
    /// Initializes a package.
    /// </summary>
    /// <param name="package">Package to initialize.</param>
    void Initialize(OpenXmlPackage package);
}
