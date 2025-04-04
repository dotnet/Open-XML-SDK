// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml;

internal readonly struct OpenXmlPartReaderState
{
    internal OpenXmlPartReaderState(bool? standalone, string? encoding)
    {
        StandaloneXml = standalone;
        Encoding = encoding;
    }

    internal string? Encoding { get; }

    internal bool? StandaloneXml { get; }
}
