﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml;

internal static class EnumerableExtensions
{
    /// <summary>
    /// Similar to <see cref="Enumerable.FirstOrDefault{TSource}(IEnumerable{TSource})"/> but will also verify that at most there is one.
    /// </summary>
    public static T? FirstOrDefaultAndMaxOne<T>(this IEnumerable<T> enumerable, Func<Exception>? exceptionFactory = null)
    {
        using var e = enumerable.GetEnumerator();

        if (e.MoveNext())
        {
            var first = e.Current;

            if (e.MoveNext())
            {
                throw exceptionFactory?.Invoke() ?? throw new InvalidOperationException(ExceptionMessages.FirstOrDefaultMaxOne);
            }

            return first;
        }

        return default;
    }
}
