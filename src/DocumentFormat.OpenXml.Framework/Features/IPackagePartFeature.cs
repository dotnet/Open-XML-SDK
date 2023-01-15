// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// A feature to access the current package part.
/// </summary>
internal interface IPackagePartFeature
{
    /// <summary>
    /// Gets the current package part.
    /// </summary>
    IPackagePart Part { get; }
}
