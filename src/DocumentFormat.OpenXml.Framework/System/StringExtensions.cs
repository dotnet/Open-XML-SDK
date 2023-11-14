// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if !NET5_0_OR_GREATER

using System;

namespace DocumentFormat.OpenXml;

internal static class StringExtensions
{
    public static bool Contains(this string str, string value, StringComparison comparison)
        => str.IndexOf(value, StringComparison.Ordinal) != -1;

    public static bool Contains(this string str, char c)
        => str.IndexOf(c.ToString(), StringComparison.Ordinal) != -1;

    public static int IndexOf(this string str, char c, StringComparison comparison)
        => str.IndexOf(c.ToString(), comparison);

    public static bool StartsWith(this string str, char c)
        => str.StartsWith(c.ToString(), StringComparison.Ordinal);

    public static bool EndsWith(this string str, char c)
        => str.EndsWith(c.ToString(), StringComparison.Ordinal);
}

#endif
