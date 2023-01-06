// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// A feature to access the current package part.
/// </summary>
public interface IPackagePartFeature
{
    /// <summary>
    /// Gets the current package part.
    /// </summary>
    IPackagePart Part { get; }
}
