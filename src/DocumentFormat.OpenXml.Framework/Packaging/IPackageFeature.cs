// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// A feature to access the backing <see cref="IPackage"/> data.
/// </summary>
public interface IPackageFeature
{
    /// <summary>
    /// Gets the <see cref="IPackage"/>.
    /// </summary>
    IPackage Package { get; }
}
