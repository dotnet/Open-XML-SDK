// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if !NET5_0_OR_GREATER
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml;

internal static class StringExtensions
{
    public static bool Contains(this string str, string value, StringComparison comparison)
        => str.IndexOf(value, StringComparison.Ordinal) != -1;

    public static bool Index(this string str, char c)
        => str.IndexOf(c.ToString()) != -1;
}

#endif
