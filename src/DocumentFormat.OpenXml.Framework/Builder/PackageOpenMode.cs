// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Builder;

/// <summary>
/// An enum that describes how a package is going to be opened
/// </summary>
[Experimental(ExperimentalApis.PackageBuilder, UrlFormat = ExperimentalApis.UrlFormat)]
[Obsolete(ExperimentalApis.Message, error: true, DiagnosticId = ExperimentalApis.PackageBuilder, UrlFormat = ExperimentalApis.UrlFormat)]
public enum PackageOpenMode
{
    /// <summary>
    /// Indicates that a new package will be created.
    /// </summary>
    Create,

    /// <summary>
    /// Indicates that a package will be opened in read mode.
    /// </summary>
    Read,

    /// <summary>
    /// Indicates that a package will be opened in read/write mode.
    /// </summary>
    ReadWrite,
}
