// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// An initializer for a package.
/// </summary>
[Experimental(ExperimentalApis.PackageBuilder)]
public interface IPackageInitializer
{
    /// <summary>
    /// Initializes a package.
    /// </summary>
    /// <param name="package">Package to initialize.</param>
    void Initialize(OpenXmlPackage package);
}
