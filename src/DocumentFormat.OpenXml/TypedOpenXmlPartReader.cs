// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System.IO;

namespace DocumentFormat.OpenXml;

/// <summary>
/// Represents an implementation of <see cref="OpenXmlPartReader"/> that is aware of the strongly typed classes.
/// </summary>
public sealed class TypedOpenXmlPartReader : OpenXmlPartReader
{
    internal const string ObsoleteMessage = "Use TypedOpenXmlPartReader instead.";

    /// <summary>
    /// Initializes a new instance of the <see cref="TypedOpenXmlPartReader"/> class.
    /// </summary>
    /// <param name="partStream">The stream of the part contents.</param>
    /// <param name="options">Options for how to read the part stream.</param>
    public TypedOpenXmlPartReader(Stream partStream, OpenXmlPartReaderOptions options = default)
        : base(partStream, TypedFeatures.Shared, options)
    {
    }
}
