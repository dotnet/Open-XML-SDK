// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.IO;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// A feature to access the backing <see cref="IPackage"/> data.
/// </summary>
internal interface IPackageFeature
{
    /// <summary>
    /// Gets the <see cref="IPackage"/>.
    /// </summary>
    IPackage Package { get; }

    /// <summary>
    /// Gets the capabilities of the package.
    /// </summary>
    PackageCapabilities Capabilities { get; }

    /// <summary>
    /// Reloads the package.
    /// </summary>
    /// <param name="mode">File mode to use with reloaded package. If absent, will use original mode.</param>
    /// <param name="access">File access to use with the reloaded package. If absent, will use original access.</param>
    void Reload(FileMode? mode = default, FileAccess? access = default);
}
