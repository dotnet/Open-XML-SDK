using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFormat.OpenXml;

internal readonly struct OpenXmlPartReaderState
{
    internal OpenXmlPartReaderState(bool? standalone, string? encoding)
    {
        StandaloneXml = standalone ?? true;
        Encoding = encoding;
    }

    internal string? Encoding { get; }

    internal bool? StandaloneXml { get; }
}
