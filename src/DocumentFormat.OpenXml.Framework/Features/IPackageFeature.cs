// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Features;

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
