// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// An abstraction for <see cref="System.IO.Packaging.PackagePart"/> that is easier to override.
/// </summary>
internal interface IPackagePart
{
    /// <summary>
    /// Gets a reference to the containing package.
    /// </summary>
    IPackage Package { get; }

    /// <summary>
    /// Gets the URI for the current part.
    /// </summary>
    Uri Uri { get; }

    /// <summary>
    /// Gets the MIME type of the content stream.
    /// </summary>
    string ContentType { get; }

    /// <summary>
    /// Gets a collection of relationships.
    /// </summary>
    IRelationshipCollection Relationships { get; }

    /// <summary>
    /// Gets the data stream for the part.
    /// </summary>
    /// <param name="open">Mode in which to open the stream.</param>
    /// <param name="write">Access mode in which to open the stream.</param>
    /// <returns>A stream for the data of the part.</returns>
    Stream GetStream(FileMode open, FileAccess write);
}
