// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Text;

namespace DocumentFormat.OpenXml;

/// <summary>
/// Settings for the <see cref="OpenXmlPartWriter" /> .
/// </summary>
public class OpenXmlPartWriterSettings
{
#if FEATURE_ASYNC_SAX_XML
    /// <summary>
    /// Gets or sets a value indicating whether asynchronous <see cref="OpenXmlPartWriter" />  methods can be used.
    /// </summary>
    public bool Async { get; set; }
#endif

    /// <summary>
    /// Gets or sets a value indicating whether the <see cref="OpenXmlPartWriter" />  should also close the underlying stream or TextWriter when the Close() method is called.
    /// </summary>
    public bool CloseOutput { get; set; }

    /// <summary>
    /// Gets or sets the type of text encoding to use.
    /// </summary>
    public Encoding Encoding { get; set; } = Encoding.UTF8;
}
