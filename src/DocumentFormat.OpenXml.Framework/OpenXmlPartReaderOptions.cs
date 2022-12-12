// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml;

/// <summary>
/// A collection of options for reading part information.
/// </summary>
public struct OpenXmlPartReaderOptions
{
    /// <summary>
    /// Gets or sets a value indicating  whether miscellaneous nodes are read.
    /// </summary>
    public bool ReadMiscellaneousNodes { get; set; }

    /// <summary>
    /// Gets or sets the maximum characters allowed in a part.
    /// </summary>
    public long MaxCharactersInPart { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether whitespace will be ignored.
    /// </summary>
    public bool IgnoreWhitespace { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the stream should be closed on the part reader being closed.
    /// </summary>
    public bool CloseStream { get; set; }

    internal OpenXmlPartReaderOptions UpdateForPart(OpenXmlPart part) => new()
    {
        ReadMiscellaneousNodes = ReadMiscellaneousNodes,
        MaxCharactersInPart = MaxCharactersInPart != 0 ? MaxCharactersInPart : part.MaxCharactersInPart,
        IgnoreWhitespace = IgnoreWhitespace,
        CloseStream = true,
    };
}
