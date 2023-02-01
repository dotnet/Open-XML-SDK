// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// An enum that describes how a package is going to be opened
/// </summary>
internal enum PackageOpenMode
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
