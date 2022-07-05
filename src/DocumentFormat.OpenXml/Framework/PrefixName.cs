// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml;

internal readonly struct PrefixName
{
    public PrefixName(string prefix, string name)
    {
        Prefix = prefix;
        Name = name;
    }

    public string Prefix { get; }

    public string Name { get; }

    public static PrefixName Parse(string name)
    {
#if NET5_0
        var idx = name.IndexOf(':', StringComparison.Ordinal);
#else
        var idx = name.IndexOf(':');
#endif

        if (((idx == -1) || (idx == 0)) || ((name.Length - 1) == idx))
        {
            var start = idx + 1;

            return new(string.Empty, name.Substring(start));
        }
        else
        {
            var prefix = name.Substring(0, idx);
            var localName = name.Substring(idx + 1);

            return new(prefix, localName);
        }
    }
}
