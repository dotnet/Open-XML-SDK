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
        var idx = IndexOfColon(name);

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

    /// <summary>
    /// Parses a name that is required to be prefixed, i.e. it contains a single colon that separates the prefix from the local name.
    /// </summary>
    /// <remarks>
    /// Unlike <see cref="Parse(string)"/>, a name that has no colon or more than one colon is not a valid prefixed name. The prefix
    /// and the local name may themselves be empty, so both <c>:name</c> and <c>prefix:</c> are parsed successfully.
    /// </remarks>
    /// <param name="name">The name to parse.</param>
    /// <param name="result">The prefix and local name of <paramref name="name"/>, if it is prefixed.</param>
    /// <returns><see langword="true"/> if <paramref name="name"/> contains a single colon; otherwise <see langword="false"/>.</returns>
    public static bool TryParsePrefixed(string name, out PrefixName result)
    {
        var idx = IndexOfColon(name);

        if (idx < 0 || name.IndexOf(':', idx + 1) >= 0)
        {
            result = default;
            return false;
        }

        result = new(name.Substring(0, idx), name.Substring(idx + 1));
        return true;
    }

    private static int IndexOfColon(string name)
    {
#if NET5_0_OR_GREATER
        return name.IndexOf(':', StringComparison.Ordinal);
#else
        return name.IndexOf(':');
#endif
    }
}
