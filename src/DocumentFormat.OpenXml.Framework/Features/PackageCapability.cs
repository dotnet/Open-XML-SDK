// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// Values to query the capabilities of a package.
/// </summary>
[Flags]
public enum PackageCapability
{
    /// <summary>
    /// No capabilities
    /// </summary>
    None = 0,

    /// <summary>
    /// Capability that indicates that the package can be saved.
    /// </summary>
    Save = 1 << 2,

    /// <summary>
    /// Capability that indicates that the package can be reloaded.
    /// </summary>
    Reload = 1 << 1,
}
