// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging;

#pragma warning disable CA1707 // Identifiers should not contain underscores

/// <summary>
/// An enum that describes the version to keep compatibility with.
/// </summary>
public enum CompatibilityLevel
{
    /// <summary>
    /// Use all the latest version behavior.
    /// </summary>
    Default,

    /// <summary>
    /// Maintain compatibility with v2.20 if possible
    /// </summary>
    Version_2_20,

    /// <summary>
    /// Maintain compatibility with v3.0 if possible
    /// </summary>
    Version_3_0,
}
