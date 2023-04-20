// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// Defines information used in creating a new part.
/// </summary>
public readonly record struct PartTypeInfo
{
    /// <summary>
    /// Ctor - assign content type and extention.
    /// </summary>
    public PartTypeInfo(string contentType, string extension)
    {
        ContentType = contentType;
        Extension = extension;
    }

    /// <summary>
    /// Gets content type for the part.
    /// </summary>
    public string ContentType { get; }

    /// <summary>
    /// Gets the file extension for the part.
    /// </summary>
    public string Extension { get; }
}
