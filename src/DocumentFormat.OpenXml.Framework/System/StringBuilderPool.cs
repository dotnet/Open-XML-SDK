// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Text;

namespace DocumentFormat.OpenXml;

/// <summary>
/// Provides a reusable pool of <see cref="StringBuilder"/> instances to reduce allocations.
/// </summary>
internal static class StringBuilderPool
{
    // Maximum capacity (in characters) a StringBuilder may have before it is not returned to the pool.
    private const int MaxBuilderCapacity = 360;

    // Two slots per thread to handle cases where two StringBuilders are active simultaneously.
    [System.ThreadStatic]
    private static StringBuilder? _primary;

    [System.ThreadStatic]
    private static StringBuilder? _secondary;

    /// <summary>
    /// Acquires a <see cref="StringBuilder"/> from the pool, or creates a new one if the pool is empty.
    /// </summary>
    public static StringBuilder Acquire()
    {
        var sb = _primary;
        if (sb is not null)
        {
            _primary = null;
            return sb;
        }

        sb = _secondary;
        if (sb is not null)
        {
            _secondary = null;
            return sb;
        }

        return new StringBuilder();
    }

    /// <summary>
    /// Returns the string value of the <see cref="StringBuilder"/> and releases it back to the pool.
    /// </summary>
    public static string GetValueAndRelease(StringBuilder sb)
    {
        var result = sb.ToString();
        Release(sb);
        return result;
    }

    /// <summary>
    /// Releases a <see cref="StringBuilder"/> back to the pool after clearing it.
    /// </summary>
    public static void Release(StringBuilder sb)
    {
        // Don't pool excessively large instances to avoid holding onto large memory allocations.
        if (sb.Capacity > MaxBuilderCapacity)
        {
            return;
        }

        // Use Length = 0 instead of Clear() for .NET 3.5 compatibility
        sb.Length = 0;

        if (_primary is null)
        {
            _primary = sb;
        }
        else if (_secondary is null)
        {
            _secondary = sb;
        }

        // If both slots are full, the instance is abandoned and will be garbage collected.
    }
}
