// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if FEATURE_ASYNC_SAX_XML
using System.Text;

namespace DocumentFormat.OpenXml;

/// <summary>
/// Settings for the OpenXmlPartWriter.
/// </summary>
public class OpenXmlPartWriterSettings
{
    /// <summary>
    /// Gets or sets a value indicating whether asynchronous OpenXmlPartWriter methods can be used.
    /// </summary>
    public bool Async { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the OpenXmlPartWriter should check to ensure that all characters in the document conform to the "2.2 Characters" section of the W3C XML 1.0 Recommendation.
    /// </summary>
    public bool CloseOutput { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the OpenXmlPartWriter should also close the underlying stream or TextWriter when the Close() method is called.
    /// </summary>
    public Encoding Encoding { get; set; } = Encoding.UTF8;
}
#endif
