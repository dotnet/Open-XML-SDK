// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml;

internal static class EnumExtensions
{
    public static bool HasFlagFast<T>(this T e, T value)
        where T : struct, Enum
    {
        Debug.Assert(Enum.GetUnderlyingType(typeof(T)) == typeof(int));

        // This boxing gets removed by the JIT on release builds
        var ei = (int)(object)e;
        var valuei = (int)(object)value;

        return (ei & valuei) == valuei;
    }
}
