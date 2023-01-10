// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// A feature that defines what extensions are used for a given part content type
/// </summary>
public interface IPartExtensionFeature
{
    /// <summary>
    /// Registers a extension to be used for a content type.
    /// </summary>
    /// <param name="contentType">Conent type to register extension for.</param>
    /// <param name="extension">Extension to register.</param>
    void Register(string contentType, string extension);

    /// <summary>
    /// Attempts to retrieve a registered extension for the content type.
    /// </summary>
    /// <param name="contentType">Content type to find extension for.</param>
    /// <param name="extension">Registered extension.</param>
    /// <returns>Whether an extension was found.</returns>
    bool TryGetExtension(string contentType, [MaybeNullWhen(false)] out string extension);
}
